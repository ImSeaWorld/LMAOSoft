using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using FormEssentials;

namespace LMAOSoft.Inc.Forms.Tools.Sub_Form
{
    public partial class frm_sub_edit_ini : Form
    {
        private string[] recoveredDrives = null;

        public frm_sub_edit_ini(string[] drives = null)
        {
            InitializeComponent();

            if (drives != null)
                this.recoveredDrives = drives;
        }

        private void frm_sub_edit_ini_Load(object sender, EventArgs e)
        {
            if (this.recoveredDrives != null) {
                foreach (string drive in this.recoveredDrives) {
                    cb_recovered_drive.Items.Add(drive);
                } cb_recovered_drive.SelectedIndex = 01;
            }
        }

        private void btn_this_one_Click(object sender, EventArgs e)
        {
            var ini = Application.OpenForms["frm_edit_ini"] as frm_edit_ini;
            ini.Invoke(new MethodInvoker(delegate {
                ini.chosen_drive = (cb_recovered_drive.SelectedItem as string);
            }));
            DialogResult = DialogResult.OK;
        }
    }
}
