/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2018 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

namespace OpenHardwareMonitor.GUI {
  partial class AboutBox {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            okButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            projectLinkLabel = new System.Windows.Forms.LinkLabel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            licenseLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            okButton.Location = new System.Drawing.Point(327, 79);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(10, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(48, 48);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 12);
            label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 15);
            label1.TabIndex = 2;
            label1.Text = "Open Hardware Monitor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(74, 46);
            label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(309, 15);
            label2.TabIndex = 3;
            label2.Text = "Copyright © 2009-2023 Michael Möller and contributors. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(74, 29);
            label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 15);
            label3.TabIndex = 4;
            label3.Text = "(unknown)";
            // 
            // projectLinkLabel
            // 
            projectLinkLabel.AutoSize = true;
            projectLinkLabel.Location = new System.Drawing.Point(164, 80);
            projectLinkLabel.Margin = new System.Windows.Forms.Padding(0);
            projectLinkLabel.Name = "projectLinkLabel";
            projectLinkLabel.Size = new System.Drawing.Size(89, 15);
            projectLinkLabel.TabIndex = 6;
            projectLinkLabel.TabStop = true;
            projectLinkLabel.Text = "Project Website";
            projectLinkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new System.Drawing.Point(10, 100);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // licenseLinkLabel
            // 
            licenseLinkLabel.AutoSize = true;
            licenseLinkLabel.Location = new System.Drawing.Point(25, 80);
            licenseLinkLabel.Margin = new System.Windows.Forms.Padding(0);
            licenseLinkLabel.Name = "licenseLinkLabel";
            licenseLinkLabel.Size = new System.Drawing.Size(123, 15);
            licenseLinkLabel.TabIndex = 9;
            licenseLinkLabel.TabStop = true;
            licenseLinkLabel.Text = "Licensing Information";
            licenseLinkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // AboutBox
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(417, 115);
            Controls.Add(licenseLinkLabel);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(projectLinkLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(okButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.LinkLabel projectLinkLabel;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.LinkLabel licenseLinkLabel;
  }
}
