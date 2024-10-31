/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2010 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using OpenHardwareMonitorLib;

namespace OpenHardwareMonitor.GUI
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
            label3.Text = "Version " +
                          System.Windows.Forms.Application.ProductVersion;

            projectLinkLabel.Links.Remove(projectLinkLabel.Links[0]);
            projectLinkLabel.Links.Add(0, projectLinkLabel.Text.Length,
                "https://github.com/hexagon-oss/openhardwaremonitor");

            licenseLinkLabel.Links.Remove(licenseLinkLabel.Links[0]);
            licenseLinkLabel.Links.Add(0, licenseLinkLabel.Text.Length,
                "https://github.com/hexagon-oss/openhardwaremonitor/blob/master/LICENSE.txt");
        }

        private void linkLabel_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
            }
            catch (Exception x)
            {
                this.GetCurrentClassLogger().LogError(x, "Unable to launch browser");
            }
        }

    }
}
