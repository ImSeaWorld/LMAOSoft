using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMAOSoft.Inc.Forms.Tools
{
    public partial class frm_edit_ini_ez : Form
    {
        public frm_edit_ini_ez()
        {
            InitializeComponent();
        }

        private void cb_tempbcast_CheckedChanged(object sender, EventArgs e)
        {
            nud_tempport.Enabled = cb_tempbcast.Checked;
            nud_temptime.Enabled = cb_tempbcast.Checked;
        }

        private void cb_regionspoof_CheckStateChanged(object sender, EventArgs e)
        {
            tb_region.Enabled = cb_regionspoof.Checked;
        }

        private void cb_ftpserv_CheckStateChanged(object sender, EventArgs e)
        {
            nud_ftpport.Enabled = cb_ftpserv.Checked;
        }

        private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tc_main.SelectedIndex) {
                case 0:
                    this.Size = new Size(307, 235);
                    break;
                case 1:
                    this.Size = new Size(668, 313);
                    break;
                case 2:
                    this.Size = new Size(390, 245);
                    break;
                case 3:
                    this.Size = new Size(278, 247);
                    break;
            }
        }

        private void cb_autofake_CheckStateChanged(object sender, EventArgs e)
        {
            lb_autofake10.Enabled = cb_autofake.Checked;
            tb_title_autofake.Enabled = cb_autofake.Checked;
            btn_add_autofake.Enabled = cb_autofake.Checked;
        }

        private void frm_edit_ini_ez_Load(object sender, EventArgs e)
        {
            this.Size = new Size(307, 235);
        }

        private void btn_add_autofake_Click(object sender, EventArgs e)
        {
            if (tb_title_autofake.Text.Contains("0x")) {
                if (tb_title_autofake.Text.Length != 10) {
                    MessageBox.Show("Example Title: 0xFFFE07D1\r\nCharacter length of 10, including the \"0x\".", "ISSUES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!tb_title_autofake.Text.Contains("0x")) {
                if (tb_title_autofake.Text.Length != 8) {
                    MessageBox.Show("Example Title: FFFE07D1\r\nCharacter length of 8, not including the \"0x\".", "ISSUES!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            for (int i = 0; i < lb_autofake10.Items.Count; i++) {
                if (lb_autofake10.Items[i].ToString() == (tb_title_autofake.Text.Contains("0x") ? tb_title_autofake.Text : "0x" + tb_title_autofake.Text)) {
                    MessageBox.Show("You've already added this title to the list!", "Uh oh!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (lb_autofake10.Items.Count == 10) {
                if (MessageBox.Show("You've already entered the max ammount of titles for AutoFake. There's a max of 10.\r\n\r\nWould you like to remove the last entry?", "We got an overflow.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
                    lb_autofake10.Items.RemoveAt(lb_autofake10.Items.Count - 1);
                }
            }

            lb_autofake10.Items.Add(tb_title_autofake.Text.Contains("0x") ? tb_title_autofake.Text : "0x" + tb_title_autofake.Text);
        }

        private void lb_autofake10_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                cms_autoFake.Show(Cursor.Position);
            }
        }

        private void tsmi_remove_Click(object sender, EventArgs e)
        {
            if (lb_autofake10.SelectedItems.Count >= 1) {
                lb_autofake10.Items.Remove(lb_autofake10.SelectedItems[0]);
            }
        }

        private void tsmi_clear_list_Click(object sender, EventArgs e)
        {
            lb_autofake10.Items.Clear();
        }
    }
}
