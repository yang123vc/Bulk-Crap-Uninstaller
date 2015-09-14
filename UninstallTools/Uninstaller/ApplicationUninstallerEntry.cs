﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Klocman.Extensions;
using Klocman.IO;
using Klocman.Localising;
using Klocman.Tools;
using Microsoft.Win32;
using UninstallTools.Properties;
using UninstallTools.Startup;

namespace UninstallTools.Uninstaller
{
    public class ApplicationUninstallerEntry
    {
        public static readonly IEnumerable<string> CompanyNameEndTrimmers =
            new[] {"corp", "corporation", "limited", "inc", "incorporated"};

        public static readonly string RegistryNameBundleProviderKey = "BundleProviderKey";
        public static readonly string RegistryNameComment = "Comment";
        public static readonly string RegistryNameDisplayIcon = "DisplayIcon";
        public static readonly string RegistryNameDisplayName = "DisplayName";
        public static readonly string RegistryNameDisplayVersion = "DisplayVersion";
        public static readonly string RegistryNameEstimatedSize = "EstimatedSize";
        public static readonly string RegistryNameInstallDate = "InstallDate";
        public static readonly string RegistryNameInstallLocation = "InstallLocation";
        public static readonly string RegistryNameInstallSource = "InstallSource";
        public static readonly string RegistryNameModifyPath = "ModifyPath";
        public static readonly string RegistryNameParentKeyName = "ParentKeyName";
        public static readonly string RegistryNamePublisher = "Publisher";
        public static readonly string RegistryNameQuietUninstallString = "QuietUninstallString";

        public static readonly IEnumerable<string> RegistryNamesOfUrlSources = new[]
        {"URLInfoAbout", "URLUpdateInfo", "HelpLink"};

        public static readonly string RegistryNameSystemComponent = "SystemComponent";
        public static readonly string RegistryNameUninstallString = "UninstallString";
        public static readonly string RegistryNameWindowsInstaller = "WindowsInstaller";
        private X509Certificate2 _certificate;
        private bool _certificateGotten;
        private bool? _certificateValid;
        private string[] _mainExecutableCandidates;
        private string _quietUninstallString;
        private string _uninstallerLocation;
        private string _uninstallString;
        internal Icon IconBitmap = null;

        internal ApplicationUninstallerEntry()
        {
        }

        [LocalisedName(typeof (Localisation), "DisplayName")]
        public string DisplayName => string.IsNullOrEmpty(RawDisplayName) ? RegistryKeyName : RawDisplayName;

        [LocalisedName(typeof (Localisation), "DisplayNameTrimmed")]
        public string DisplayNameTrimmed => StringTools.StripStringFromVersionNumber(DisplayName);

        [LocalisedName(typeof (Localisation), "PublisherTrimmed")]
        public string PublisherTrimmed => string.IsNullOrEmpty(Publisher)
            ? string.Empty
            : Publisher.Replace("(R)", string.Empty)
                .ExtendedTrimEndAny(CompanyNameEndTrimmers, StringComparison.CurrentCultureIgnoreCase);

        [LocalisedName(typeof (Localisation), "QuietUninstallPossible")]
        public bool QuietUninstallPossible => !string.IsNullOrEmpty(QuietUninstallString)
                                              ||
                                              (UninstallerKind == UninstallerType.Msiexec &&
                                               BundleProviderKey != Guid.Empty);

        [LocalisedName(typeof (Localisation), "UninstallPossible")]
        public bool UninstallPossible => !string.IsNullOrEmpty(UninstallString);

        [LocalisedName(typeof (Localisation), "AboutUrl")]
        public string AboutUrl { get; internal set; }

        /// <summary>
        ///     Product code used by msiexec. If it wasn't found, returns Guid.Empty.
        /// </summary>
        [LocalisedName(typeof (Localisation), "BundleProviderKey")]
        public Guid BundleProviderKey { get; internal set; }

        [LocalisedName(typeof (Localisation), "Comment")]
        public string Comment { get; internal set; }

        [LocalisedName(typeof (Localisation), "DisplayIcon")]
        public string DisplayIcon { get; internal set; }

        [LocalisedName(typeof (Localisation), "DisplayVersion")]
        public string DisplayVersion { get; internal set; }

        [LocalisedName(typeof (Localisation), "EstimatedSize")]
        public FileSize EstimatedSize { get; internal set; }

        [LocalisedName(typeof (Localisation), "InstallDate")]
        public DateTime InstallDate { get; internal set; }

        [LocalisedName(typeof (Localisation), "InstallLocation")]
        public string InstallLocation { get; internal set; }

        [LocalisedName(typeof (Localisation), "InstallSource")]
        public string InstallSource { get; internal set; }

        [LocalisedName(typeof (Localisation), "Is64Bit")]
        public bool Is64Bit { get; internal set; }

        /// <summary>
        ///     Protection from uninstalling.
        /// </summary>
        [LocalisedName(typeof (Localisation), "IsProtected")]
        public bool IsProtected { get; internal set; }

        /// <summary>
        ///     The application's uniunstaller is mentioned in the registry (if it's not normal uninstallers will not see it)
        /// </summary>
        [LocalisedName(typeof (Localisation), "IsRegistered")]
        public bool IsRegistered { get; internal set; }

        /// <summary>
        ///     True if this is an update for another product
        /// </summary>
        [LocalisedName(typeof (Localisation), "IsUpdate")]
        public bool IsUpdate { get; internal set; }

        /// <summary>
        ///     True if the application can be uninstalled. False if the uninstaller is missing or is invalid (duh).
        /// </summary>
        [LocalisedName(typeof (Localisation), "IsValid")]
        public bool IsValid { get; internal set; }

        [LocalisedName(typeof (Localisation), "ModifyPath")]
        public string ModifyPath { get; internal set; }

        [LocalisedName(typeof (Localisation), "ParentKeyName")]
        public string ParentKeyName { get; internal set; }

        [LocalisedName(typeof (Localisation), "Publisher")]
        public string Publisher { get; internal set; }

        [LocalisedName(typeof (Localisation), "QuietUninstallString")]
        public string QuietUninstallString
        {
            get
            {
                if (string.IsNullOrEmpty(_quietUninstallString) && UninstallerKind == UninstallerType.Msiexec)
                {
                    _quietUninstallString = ApplicationUninstallerManager.GetMsiString(BundleProviderKey,
                        MsiUninstallModes.QuietUninstall);
                }
                return _quietUninstallString;
            }
            internal set { _quietUninstallString = value; }
        }

        [LocalisedName(typeof (Localisation), "RegistryKeyName")]
        public string RegistryKeyName { get; internal set; }

        /// <summary>
        ///     Full registry path of this entry
        /// </summary>
        [LocalisedName(typeof (Localisation), "RegistryPath")]
        public string RegistryPath { get; internal set; }

        [LocalisedName(typeof (Localisation), "StartupEntries")]
        public IEnumerable<StartupEntryBase> StartupEntries { get; set; }

        [LocalisedName(typeof (Localisation), "SystemComponent")]
        public bool SystemComponent { get; internal set; }

        [LocalisedName(typeof (Localisation), "UninstallerFullFilename")]
        public string UninstallerFullFilename { get; internal set; }

        [LocalisedName(typeof (Localisation), "UninstallerKind")]
        public UninstallerType UninstallerKind { get; internal set; }

        //[LocalisedName(typeof(Localisation), "IsInstalled")]
        //public bool IsInstalled { get; internal set; }
        [LocalisedName(typeof (Localisation), "UninstallerLocation")]
        public string UninstallerLocation
        {
            get
            {
                if (_uninstallerLocation == null)
                {
                    _uninstallerLocation = string.Empty;
                    if (!string.IsNullOrEmpty(UninstallerFullFilename))
                    {
                        try
                        {
                            _uninstallerLocation =
                                Path.GetDirectoryName(UninstallerFullFilename);
                        }
                        catch (ArgumentException)
                        {
                        }
                        catch (PathTooLongException)
                        {
                        }
                    }
                }
                return _uninstallerLocation;
            }
        }

        [LocalisedName(typeof (Localisation), "UninstallString")]
        public string UninstallString
        {
            get
            {
                if (string.IsNullOrEmpty(_uninstallString) && UninstallerKind == UninstallerType.Msiexec)
                {
                    _uninstallString = ApplicationUninstallerManager.GetMsiString(BundleProviderKey,
                        MsiUninstallModes.Uninstall);
                }
                return _uninstallString;
            }
            internal set { _uninstallString = value; }
        }

        internal string RawDisplayName { get; set; }

        public static string GetFuzzyDirectory(string fullCommand)
        {
            if (string.IsNullOrEmpty(fullCommand)) return Localisation.Error_InvalidPath;

            if (fullCommand.StartsWith("msiexec", StringComparison.OrdinalIgnoreCase)
                || fullCommand.Contains("msiexec.exe", StringComparison.OrdinalIgnoreCase))
                return "MsiExec";

            try
            {
                if (fullCommand.Contains('\\'))
                {
                    string strOut;
                    try
                    {
                        strOut = ProcessTools.SeparateArgsFromCommand(fullCommand).FileName;
                    }
                    catch
                    {
                        strOut = fullCommand;
                    }

                    strOut = Path.GetDirectoryName(strOut);

                    strOut = PathTools.GetPathUpToLevel(strOut, 1, false);
                    if (strOut.IsNotEmpty())
                    {
                        return PathTools.PathToNormalCase(strOut); //Path.GetFullPath(strOut);
                    }
                }
            }
            catch
            {
                // Assume path is invalid
            }
            return Localisation.Error_InvalidPath;
        }

        /// <summary>
        ///     Get the certificate associated to the uninstaller or application.
        /// </summary>
        /// <param name="onlyStored">If true only return the stored value, otherwise generate it if needed.</param>
        public X509Certificate2 GetCertificate(bool onlyStored)
        {
            return onlyStored ? _certificate : GetCertificate();
        }

        /// <summary>
        ///     Get the certificate associated to the uninstaller or application.
        /// </summary>
        public X509Certificate2 GetCertificate()
        {
            if (!_certificateGotten)
            {
                _certificateGotten = true;
                _certificate = ApplicationUninstallerFactory.TryGetCertificate(this);

                if (_certificate != null)
                    _certificateValid = _certificate.Verify();
            }
            return _certificate;
        }

        public Icon GetIcon()
        {
            return IconBitmap;
        }

        /// <summary>
        ///     Get ordered collection of filenames that could be the main executable of the application.
        ///     The most likely files are first, the least likely are last.
        /// </summary>
        public string[] GetMainExecutableCandidates()
        {
            var trimmedDispName = DisplayNameTrimmed;
            if (string.IsNullOrEmpty(trimmedDispName))
            {
                trimmedDispName = DisplayName;
                if (string.IsNullOrEmpty(trimmedDispName))
                    // Impossible to search for the executable without knowing the app name
                    _mainExecutableCandidates = new string[] {};
            }

            if (_mainExecutableCandidates == null)
            {
                foreach (var targetDir in new[] {InstallLocation, UninstallerLocation}
                    .Where(x => !string.IsNullOrEmpty(x) && Directory.Exists(x)))
                {
                    var files = Directory.GetFiles(targetDir, "*.exe", SearchOption.TopDirectoryOnly);
                    if (files.Length < 40) // Not likely to hit the correct file and would take too long, skip
                    {
                        // Use string similarity algorithm to find out which executable is likely the main application exe
                        var query = from file in files
                            where !file.Equals(UninstallerFullFilename, StringComparison.InvariantCultureIgnoreCase)
                            orderby
                                StringTools.CompareSimilarity(Path.GetFileNameWithoutExtension(file), trimmedDispName)
                                    ascending
                            select file;

                        _mainExecutableCandidates = query.ToArray();
                    }
                }
            }
            return _mainExecutableCandidates;
        }

        public Uri GetUri()
        {
            var temp = AboutUrl;
            if (!temp.IsNotEmpty()) return null;

            temp = temp.Replace("www.", temp.StartsWith("www.") ? @"http://" : string.Empty);

            try
            {
                return new Uri(temp, UriKind.Absolute);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     Check if certificate is valid. It returns null if the certificate is missing or GetCertificate has not
        ///     been ran yet and onlyStored is set to true.
        /// </summary>
        public bool? IsCertificateValid(bool onlyStored)
        {
            if (!onlyStored && !_certificateGotten)
                GetCertificate();

            return _certificateValid;
        }

        /// <summary>
        ///     Opens a new read-only instance of registry key used by this uninstaller. Remember to close it!
        /// </summary>
        public RegistryKey OpenRegKey()
        {
            return RegistryTools.OpenRegistryKey(RegistryPath);
        }

        /// <summary>
        ///     Opens a new instance of registry key used by this uninstaller. Remember to close it!
        /// </summary>
        /// <exception cref="System.Security.SecurityException">
        ///     The user does not have the permissions required to access the registry key in the
        ///     specified mode.
        /// </exception>
        public RegistryKey OpenRegKey(bool writable)
        {
            return RegistryTools.OpenRegistryKey(RegistryPath, writable);
        }

        /// <summary>
        ///     Check if entry has not been uninstalled already (check registry key)
        /// </summary>
        /// <returns></returns>
        public bool RegKeyStillExists()
        {
            if (string.IsNullOrEmpty(RegistryPath))
                return false;
            try
            {
                using (OpenRegKey())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public string ToLongString()
        {
            var sb = new StringBuilder();
            sb.Append(DisplayName);
            sb.AppendFormat(" | {0}", Publisher);
            sb.AppendFormat(" | {0}", DisplayVersion);
            sb.AppendFormat(" | {0}", DateTime.MinValue.Equals(InstallDate) ? "" : InstallDate.ToShortDateString());
            sb.AppendFormat(" | {0}", EstimatedSize);
            sb.AppendFormat(" | {0}", RegistryPath);
            sb.AppendFormat(" | {0}", UninstallerKind);
            sb.AppendFormat(" | {0}", UninstallString);
            sb.AppendFormat(" | {0}", QuietUninstallString);
            sb.AppendFormat(" | {0}", Comment);

            return sb.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(DisplayName);
            sb.AppendFormat(" | {0}", Publisher);
            sb.AppendFormat(" | {0}", DisplayVersion);
            sb.AppendFormat(" | {0}", UninstallString);
            sb.AppendFormat(" | {0}", Comment);

            return sb.ToString();
        }
    }
}