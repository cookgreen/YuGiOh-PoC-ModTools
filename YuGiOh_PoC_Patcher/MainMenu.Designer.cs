using YuGiOh_PoC_Patcher.CustomControls;
using System.Drawing;

namespace YuGiOh_PoC_Patcher
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ctlModernBlack = new jSkin.ctlModernBlack();
            this.linkLabel_ThePage = new System.Windows.Forms.LinkLabel();
            this.label = new System.Windows.Forms.Label();
            this.Button_ChangePath = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_Settings = new YuGiOh_PoC_Patcher.CustomControls.RoundButton();
            this.Button_ModLauncher = new YuGiOh_PoC_Patcher.CustomControls.RoundButton();
            this.Button_BaseSettings = new YuGiOh_PoC_Patcher.CustomControls.RoundButton();
            this.Button_Exit = new YuGiOh_PoC_Patcher.CustomControls.RoundButton();
            this.Button_Game = new YuGiOh_PoC_Patcher.CustomControls.RoundButton();
            this.ctlModernBlack.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlModernBlack1
            // 
            this.ctlModernBlack.Controls.Add(this.linkLabel_ThePage);
            this.ctlModernBlack.Controls.Add(this.label);
            this.ctlModernBlack.Controls.Add(this.Button_ChangePath);
            this.ctlModernBlack.Controls.Add(this.Button_Settings);
            this.ctlModernBlack.Controls.Add(this.Button_ModLauncher);
            this.ctlModernBlack.Controls.Add(this.Button_BaseSettings);
            this.ctlModernBlack.Controls.Add(this.Button_Exit);
            this.ctlModernBlack.Controls.Add(this.Button_Game);
            this.ctlModernBlack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlModernBlack.FixedSingle = true;
            this.ctlModernBlack.Location = new System.Drawing.Point(0, 0);
            this.ctlModernBlack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlModernBlack.Name = "ctlModernBlack1";
            this.ctlModernBlack.Size = new System.Drawing.Size(559, 505);
            this.ctlModernBlack.Stretch = false;
            this.ctlModernBlack.TabIndex = 0;
            // 
            // linkLabel_ThePage
            // 
            this.linkLabel_ThePage.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel_ThePage.AutoSize = true;
            this.linkLabel_ThePage.BackColor = System.Drawing.SystemColors.Window;
            this.linkLabel_ThePage.Location = new System.Drawing.Point(348, 474);
            this.linkLabel_ThePage.Name = "linkLabel_ThePage";
            this.linkLabel_ThePage.Size = new System.Drawing.Size(71, 15);
            this.linkLabel_ThePage.TabIndex = 7;
            this.linkLabel_ThePage.TabStop = true;
            this.linkLabel_ThePage.Text = "Homepage";
            this.linkLabel_ThePage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ThePage_LinkClicked);
            // 
            // label1
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 474);
            this.label.Name = "label1";
            this.label.Size = new System.Drawing.Size(199, 15);
            this.label.TabIndex = 6;
            this.label.Text = "By PhilYeahz && DerPlayer";
            // 
            // Button_ChangePath
            // 
            this.Button_ChangePath.Location = new System.Drawing.Point(308, 52);
            this.Button_ChangePath.Name = "Button_ChangePath";
            this.Button_ChangePath.Size = new System.Drawing.Size(90, 47);
            this.Button_ChangePath.TabIndex = 5;
            this.Button_ChangePath.Text = "Change default game path";
            this.Button_ChangePath.UseVisualStyleBackColor = true;
            this.Button_ChangePath.Click += new System.EventHandler(this.Button_ChangePath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Settings.Location = new System.Drawing.Point(12, 321);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(395, 60);
            this.Button_Settings.TabIndex = 3;
            this.Button_Settings.Text = "Mod tools";
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Button_ModLauncher
            // 
            this.Button_ModLauncher.Location = new System.Drawing.Point(12, 139);
            this.Button_ModLauncher.Name = "Button_ModLauncher";
            this.Button_ModLauncher.Size = new System.Drawing.Size(395, 60);
            this.Button_ModLauncher.TabIndex = 1;
            this.Button_ModLauncher.Text = "Mod selector";
            this.Button_ModLauncher.UseVisualStyleBackColor = true;
            this.Button_ModLauncher.Click += new System.EventHandler(this.Button_ModLauncher_Click);
            // 
            // Button_BaseSettings
            // 
            this.Button_BaseSettings.Location = new System.Drawing.Point(12, 231);
            this.Button_BaseSettings.Name = "Button_BaseSettings";
            this.Button_BaseSettings.Size = new System.Drawing.Size(395, 60);
            this.Button_BaseSettings.TabIndex = 4;
            this.Button_BaseSettings.Text = "Base settings";
            this.Button_BaseSettings.UseVisualStyleBackColor = true;
            this.Button_BaseSettings.Click += new System.EventHandler(this.Button_BaseSettings_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.White;
            this.Button_Exit.Location = new System.Drawing.Point(12, 411);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(395, 60);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Game
            // 
            this.Button_Game.Location = new System.Drawing.Point(12, 45);
            this.Button_Game.Name = "Button_Game";
            this.Button_Game.Size = new System.Drawing.Size(395, 60);
            this.Button_Game.TabIndex = 0;
            this.Button_Game.Text = "Launch/Start";
            this.Button_Game.UseVisualStyleBackColor = true;
            this.Button_Game.Click += new System.EventHandler(this.Button_Game_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 505);
            this.Controls.Add(this.ctlModernBlack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yu-Gi-Oh! Power of Chaos Mod Tools - v";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ctlModernBlack.ResumeLayout(false);
            this.ctlModernBlack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Button_ChangePath;
        private jSkin.ctlModernBlack ctlModernBlack;
        private RoundButton Button_Settings;
        private RoundButton Button_Game;
        private RoundButton Button_ModLauncher;
        private RoundButton Button_Exit;
        private RoundButton Button_BaseSettings;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.LinkLabel linkLabel_ThePage;
    }
}