﻿using System.ComponentModel;
using System.Windows.Forms;

namespace BulkCrapUninstaller.Forms
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxPreUninstall = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPostUninstall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxAutoLoad = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdateSearch = new System.Windows.Forms.CheckBox();
            this.checkBoxSendStats = new System.Windows.Forms.CheckBox();
            this.checkBoxRatings = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxMessages = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxLoud = new System.Windows.Forms.CheckBox();
            this.checkBoxBackup = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxJunk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxRestore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxExternal = new System.Windows.Forms.GroupBox();
            this.checkBoxEnableExternal = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.usageTracker1 = new Klocman.Subsystems.Tracking.UsageTracker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.propertiesSidebar1 = new BulkCrapUninstaller.Controls.PropertiesSidebar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uninstallationSettings1 = new BulkCrapUninstaller.Controls.UninstallationSettings();
            this.tabPageExternal = new System.Windows.Forms.TabPage();
            this.tabPageFolders = new System.Windows.Forms.TabPage();
            this.groupBoxProgramFolders = new System.Windows.Forms.GroupBox();
            this.textBoxProgramFolders = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelProgramFolders = new System.Windows.Forms.Label();
            this.tabPageMisc = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBoxMessages.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxExternal.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageExternal.SuspendLayout();
            this.tabPageFolders.SuspendLayout();
            this.groupBoxProgramFolders.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tabPageMisc.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPreUninstall);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPostUninstall);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            // 
            // textBoxPreUninstall
            // 
            resources.ApplyResources(this.textBoxPreUninstall, "textBoxPreUninstall");
            this.textBoxPreUninstall.Name = "textBoxPreUninstall";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxPostUninstall
            // 
            resources.ApplyResources(this.textBoxPostUninstall, "textBoxPostUninstall");
            this.textBoxPostUninstall.Name = "textBoxPostUninstall";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBoxMisc
            // 
            resources.ApplyResources(this.groupBoxMisc, "groupBoxMisc");
            this.groupBoxMisc.Controls.Add(this.flowLayoutPanel3);
            this.groupBoxMisc.Controls.Add(this.panel3);
            this.groupBoxMisc.Controls.Add(this.flowLayoutPanel4);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Controls.Add(this.checkBoxAutoLoad);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxUpdateSearch);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxSendStats);
            this.flowLayoutPanel3.Controls.Add(this.checkBoxRatings);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // checkBoxAutoLoad
            // 
            resources.ApplyResources(this.checkBoxAutoLoad, "checkBoxAutoLoad");
            this.checkBoxAutoLoad.Name = "checkBoxAutoLoad";
            this.checkBoxAutoLoad.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdateSearch
            // 
            resources.ApplyResources(this.checkBoxUpdateSearch, "checkBoxUpdateSearch");
            this.checkBoxUpdateSearch.Name = "checkBoxUpdateSearch";
            this.checkBoxUpdateSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxSendStats
            // 
            resources.ApplyResources(this.checkBoxSendStats, "checkBoxSendStats");
            this.checkBoxSendStats.Name = "checkBoxSendStats";
            this.checkBoxSendStats.UseVisualStyleBackColor = true;
            // 
            // checkBoxRatings
            // 
            resources.ApplyResources(this.checkBoxRatings, "checkBoxRatings");
            this.checkBoxRatings.Name = "checkBoxRatings";
            this.checkBoxRatings.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.comboBoxLanguage);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Name = "panel3";
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(this.comboBoxLanguage, "comboBoxLanguage");
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // flowLayoutPanel4
            // 
            resources.ApplyResources(this.flowLayoutPanel4, "flowLayoutPanel4");
            this.flowLayoutPanel4.Controls.Add(this.label10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBoxMessages
            // 
            resources.ApplyResources(this.groupBoxMessages, "groupBoxMessages");
            this.groupBoxMessages.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxMessages.Controls.Add(this.panel1);
            this.groupBoxMessages.Controls.Add(this.panel2);
            this.groupBoxMessages.Name = "groupBoxMessages";
            this.groupBoxMessages.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.checkBoxLoud);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxBackup);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // checkBoxLoud
            // 
            resources.ApplyResources(this.checkBoxLoud, "checkBoxLoud");
            this.checkBoxLoud.Name = "checkBoxLoud";
            this.checkBoxLoud.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackup
            // 
            resources.ApplyResources(this.checkBoxBackup, "checkBoxBackup");
            this.checkBoxBackup.Name = "checkBoxBackup";
            this.checkBoxBackup.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.comboBoxJunk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // comboBoxJunk
            // 
            resources.ApplyResources(this.comboBoxJunk, "comboBoxJunk");
            this.comboBoxJunk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJunk.FormattingEnabled = true;
            this.comboBoxJunk.Name = "comboBoxJunk";
            this.comboBoxJunk.SelectedIndexChanged += new System.EventHandler(this.comboBoxJunk_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.comboBoxRestore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Name = "panel2";
            // 
            // comboBoxRestore
            // 
            resources.ApplyResources(this.comboBoxRestore, "comboBoxRestore");
            this.comboBoxRestore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRestore.FormattingEnabled = true;
            this.comboBoxRestore.Name = "comboBoxRestore";
            this.comboBoxRestore.SelectedIndexChanged += new System.EventHandler(this.comboBoxRestore_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBoxExternal
            // 
            resources.ApplyResources(this.groupBoxExternal, "groupBoxExternal");
            this.groupBoxExternal.Controls.Add(this.splitContainer1);
            this.groupBoxExternal.Controls.Add(this.checkBoxEnableExternal);
            this.groupBoxExternal.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxExternal.Name = "groupBoxExternal";
            this.groupBoxExternal.TabStop = false;
            // 
            // checkBoxEnableExternal
            // 
            resources.ApplyResources(this.checkBoxEnableExternal, "checkBoxEnableExternal");
            this.checkBoxEnableExternal.Checked = true;
            this.checkBoxEnableExternal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableExternal.Name = "checkBoxEnableExternal";
            this.checkBoxEnableExternal.UseVisualStyleBackColor = true;
            this.checkBoxEnableExternal.CheckedChanged += new System.EventHandler(this.checkBoxEnableExternal_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usageTracker1
            // 
            this.usageTracker1.ContainerControl = this;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPageExternal);
            this.tabControl.Controls.Add(this.tabPageFolders);
            this.tabControl.Controls.Add(this.tabPageMisc);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.propertiesSidebar1);
            resources.ApplyResources(this.tabPageGeneral, "tabPageGeneral");
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // propertiesSidebar1
            // 
            resources.ApplyResources(this.propertiesSidebar1, "propertiesSidebar1");
            this.propertiesSidebar1.InvalidEnabled = true;
            this.propertiesSidebar1.Name = "propertiesSidebar1";
            this.propertiesSidebar1.OrphansEnabled = true;
            this.propertiesSidebar1.ProtectedEnabled = true;
            this.propertiesSidebar1.StoreAppsEnabled = true;
            this.propertiesSidebar1.SysCompEnabled = true;
            this.propertiesSidebar1.UpdatesEnabled = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.uninstallationSettings1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // uninstallationSettings1
            // 
            resources.ApplyResources(this.uninstallationSettings1, "uninstallationSettings1");
            this.uninstallationSettings1.Name = "uninstallationSettings1";
            // 
            // tabPageExternal
            // 
            this.tabPageExternal.Controls.Add(this.groupBoxExternal);
            resources.ApplyResources(this.tabPageExternal, "tabPageExternal");
            this.tabPageExternal.Name = "tabPageExternal";
            this.tabPageExternal.UseVisualStyleBackColor = true;
            // 
            // tabPageFolders
            // 
            this.tabPageFolders.Controls.Add(this.groupBoxProgramFolders);
            resources.ApplyResources(this.tabPageFolders, "tabPageFolders");
            this.tabPageFolders.Name = "tabPageFolders";
            this.tabPageFolders.UseVisualStyleBackColor = true;
            // 
            // groupBoxProgramFolders
            // 
            resources.ApplyResources(this.groupBoxProgramFolders, "groupBoxProgramFolders");
            this.groupBoxProgramFolders.Controls.Add(this.textBoxProgramFolders);
            this.groupBoxProgramFolders.Controls.Add(this.flowLayoutPanel5);
            this.groupBoxProgramFolders.Name = "groupBoxProgramFolders";
            this.groupBoxProgramFolders.TabStop = false;
            // 
            // textBoxProgramFolders
            // 
            resources.ApplyResources(this.textBoxProgramFolders, "textBoxProgramFolders");
            this.textBoxProgramFolders.Name = "textBoxProgramFolders";
            // 
            // flowLayoutPanel5
            // 
            resources.ApplyResources(this.flowLayoutPanel5, "flowLayoutPanel5");
            this.flowLayoutPanel5.Controls.Add(this.labelProgramFolders);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            // 
            // labelProgramFolders
            // 
            resources.ApplyResources(this.labelProgramFolders, "labelProgramFolders");
            this.labelProgramFolders.Name = "labelProgramFolders";
            // 
            // tabPageMisc
            // 
            this.tabPageMisc.Controls.Add(this.groupBoxMisc);
            this.tabPageMisc.Controls.Add(this.groupBoxMessages);
            resources.ApplyResources(this.tabPageMisc, "tabPageMisc");
            this.tabPageMisc.Name = "tabPageMisc";
            this.tabPageMisc.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // SettingsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsWindow_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBoxMessages.ResumeLayout(false);
            this.groupBoxMessages.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxExternal.ResumeLayout(false);
            this.groupBoxExternal.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPageExternal.ResumeLayout(false);
            this.tabPageExternal.PerformLayout();
            this.tabPageFolders.ResumeLayout(false);
            this.tabPageFolders.PerformLayout();
            this.groupBoxProgramFolders.ResumeLayout(false);
            this.groupBoxProgramFolders.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tabPageMisc.ResumeLayout(false);
            this.tabPageMisc.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxMessages;
        private CheckBox checkBoxBackup;
        private CheckBox checkBoxLoud;
        private ComboBox comboBoxRestore;
        private ComboBox comboBoxJunk;
        private Label label2;
        private Label label1;
        private Button button2;
        private GroupBox groupBoxMisc;
        private CheckBox checkBoxUpdateSearch;
        private Klocman.Subsystems.Tracking.UsageTracker usageTracker1;
        private GroupBox groupBoxExternal;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox checkBoxSendStats;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private TextBox textBoxPreUninstall;
        private Label label6;
        private TextBox textBoxPostUninstall;
        private Label label7;
        private CheckBox checkBoxEnableExternal;
        private Panel panel3;
        private ComboBox comboBoxLanguage;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel4;
        private SplitContainer splitContainer1;
        private TabControl tabControl;
        private TabPage tabPageMisc;
        private TabPage tabPageExternal;
        private Panel panel4;
        private TabPage tabPageGeneral;
        private Controls.PropertiesSidebar propertiesSidebar1;
        private TabPage tabPageFolders;
        private GroupBox groupBoxProgramFolders;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelProgramFolders;
        private TextBox textBoxProgramFolders;
        private CheckBox checkBoxAutoLoad;
        private CheckBox checkBoxRatings;
        private TabPage tabPage1;
        private Controls.UninstallationSettings uninstallationSettings1;
    }
}