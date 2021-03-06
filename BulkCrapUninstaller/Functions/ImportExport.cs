﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Klocman.Extensions;
using Klocman.Forms.Tools;
using UninstallTools.Uninstaller;

namespace BulkCrapUninstaller.Functions
{
    internal static class ImportExport
    {
        public static void CopyToClipboard(IEnumerable<string> inputLines)
        {
            var text = string.Join("\r\n", inputLines.OrderBy(t => t).ToArray());

            if (text.IsNotEmpty())
            {
                try
                {
                    Clipboard.SetText(text);
                }
                catch (Exception ex)
                {
                    PremadeDialogs.GenericError(ex);
                }
            }
            else
                MessageBoxes.NothingToCopy();
        }

        public static void CopyNamesToClipboard(IEnumerable<ApplicationUninstallerEntry> items)
        {
            CopyToClipboard(items.Select(z => z.DisplayName));
        }

        public static void CopyRegKeysToClipboard(IEnumerable<ApplicationUninstallerEntry> items)
        {
            CopyToClipboard(items.Select(z => z.RegistryPath));
        }

        public static void CopyUninstallStringsToClipboard(IEnumerable<ApplicationUninstallerEntry> items)
        {
            CopyToClipboard(items.Select(z => z.UninstallString));
        }

        public static void CopyGuidsToClipboard(IEnumerable<ApplicationUninstallerEntry> items)
        {
            CopyToClipboard(items.Select(z => z.BundleProviderKey.ToString("B").ToUpper()));
        }

        public static void CopyFullInformationToClipboard(IEnumerable<ApplicationUninstallerEntry> items)
        {
            CopyToClipboard(items.Select(z => z.ToLongString()));
        }
    }
}