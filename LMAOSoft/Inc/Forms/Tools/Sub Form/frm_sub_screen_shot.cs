using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMAOSoft.Inc.Forms.Tools.Sub_Form
{
    public partial class frm_sub_screen_shot : Form
    {
        public frm_sub_screen_shot()
        {
            InitializeComponent();
        }

        private void lv_manage_images_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cms_main.Show(Cursor.Position);
        }
    }
}
