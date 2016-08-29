﻿namespace AutoPrintr
{
    partial class mainWin
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWin));
            this.tabs = new System.Windows.Forms.TabControl();
            this.printersTab = new System.Windows.Forms.TabPage();
            this.printersTable = new System.Windows.Forms.TableLayoutPanel();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.saveConfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.jobsTab = new System.Windows.Forms.TabPage();
            this.logTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.helpButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.licenseText = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.configSaveStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxSlider1 = new AutoPrintr.CheckBoxSlider();
            this.locationsList = new AutoPrintr.CheckBoxList();
            this.jobsList = new AutoPrintr.JobsList();
            this.checkBoxList1 = new AutoPrintr.CheckBoxList();
            this.tabs.SuspendLayout();
            this.printersTab.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.jobsTab.SuspendLayout();
            this.logTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Controls.Add(this.printersTab);
            this.tabs.Controls.Add(this.settingsTab);
            this.tabs.Controls.Add(this.jobsTab);
            this.tabs.Controls.Add(this.logTab);
            this.tabs.Controls.Add(this.aboutTab);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            // 
            // printersTab
            // 
            resources.ApplyResources(this.printersTab, "printersTab");
            this.printersTab.Controls.Add(this.printersTable);
            this.printersTab.Name = "printersTab";
            this.printersTab.UseVisualStyleBackColor = true;
            // 
            // printersTable
            // 
            resources.ApplyResources(this.printersTable, "printersTable");
            this.printersTable.Name = "printersTable";
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.checkBoxSlider1);
            this.settingsTab.Controls.Add(this.saveConfig);
            this.settingsTab.Controls.Add(this.groupBox3);
            this.settingsTab.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.settingsTab, "settingsTab");
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // saveConfig
            // 
            resources.ApplyResources(this.saveConfig, "saveConfig");
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.locationsList);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Controls.Add(this.submit);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.password);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // loginLabel
            // 
            resources.ApplyResources(this.loginLabel, "loginLabel");
            this.loginLabel.Name = "loginLabel";
            // 
            // submit
            // 
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.Name = "login";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // jobsTab
            // 
            resources.ApplyResources(this.jobsTab, "jobsTab");
            this.jobsTab.Controls.Add(this.jobsList);
            this.jobsTab.Name = "jobsTab";
            this.jobsTab.UseVisualStyleBackColor = true;
            // 
            // logTab
            // 
            resources.ApplyResources(this.logTab, "logTab");
            this.logTab.Controls.Add(this.richTextBox1);
            this.logTab.Name = "logTab";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.helpButton);
            this.aboutTab.Controls.Add(this.versionLabel);
            this.aboutTab.Controls.Add(this.groupBox4);
            resources.ApplyResources(this.aboutTab, "aboutTab");
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // helpButton
            // 
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // versionLabel
            // 
            resources.ApplyResources(this.versionLabel, "versionLabel");
            this.versionLabel.Name = "versionLabel";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.licenseText);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // licenseText
            // 
            resources.ApplyResources(this.licenseText, "licenseText");
            this.licenseText.Name = "licenseText";
            this.licenseText.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusServer,
            this.statusSeparator1,
            this.statusLogin,
            this.statusSeparator2,
            this.configSaveStatus});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            resources.ApplyResources(this.statusLabel, "statusLabel");
            // 
            // statusServer
            // 
            this.statusServer.Name = "statusServer";
            resources.ApplyResources(this.statusServer, "statusServer");
            // 
            // statusSeparator1
            // 
            this.statusSeparator1.Name = "statusSeparator1";
            resources.ApplyResources(this.statusSeparator1, "statusSeparator1");
            // 
            // statusLogin
            // 
            this.statusLogin.Name = "statusLogin";
            resources.ApplyResources(this.statusLogin, "statusLogin");
            // 
            // statusSeparator2
            // 
            this.statusSeparator2.Name = "statusSeparator2";
            resources.ApplyResources(this.statusSeparator2, "statusSeparator2");
            // 
            // configSaveStatus
            // 
            this.configSaveStatus.Name = "configSaveStatus";
            resources.ApplyResources(this.configSaveStatus, "configSaveStatus");
            // 
            // checkBoxSlider1
            // 
            this.checkBoxSlider1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSlider1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.checkBoxSlider1, "checkBoxSlider1");
            this.checkBoxSlider1.Name = "checkBoxSlider1";
            // 
            // locationsList
            // 
            resources.ApplyResources(this.locationsList, "locationsList");
            this.locationsList.Name = "locationsList";
            // 
            // jobsList
            // 
            resources.ApplyResources(this.jobsList, "jobsList");
            this.jobsList.Name = "jobsList";
            // 
            // checkBoxList1
            // 
            resources.ApplyResources(this.checkBoxList1, "checkBoxList1");
            this.checkBoxList1.Name = "checkBoxList1";
            // 
            // mainWin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabs);
            this.Name = "mainWin";
            this.tabs.ResumeLayout(false);
            this.printersTab.ResumeLayout(false);
            this.printersTab.PerformLayout();
            this.settingsTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.jobsTab.ResumeLayout(false);
            this.logTab.ResumeLayout(false);
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TabPage printersTab;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusServer;
        private System.Windows.Forms.ToolStripStatusLabel statusLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel statusSeparator1;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.ToolStripStatusLabel statusSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel configSaveStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private CheckBoxList checkBoxList1;
        private CheckBoxList locationsList;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox licenseText;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.TabPage jobsTab;
        private System.Windows.Forms.TabPage logTab;
        private JobsList jobsList;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel printersTable;
        private CheckBoxSlider checkBoxSlider1;
    }
}

