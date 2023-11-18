using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            BackColor = Color.FromArgb(255, RTrackBarBackground.Value, GTrackBarBackground.Value, BTrackBarBackground.Value);
            label1.Text = "" + RTrackBarBackground.Value;
        }

        private void GTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            BackColor = Color.FromArgb(255, RTrackBarBackground.Value, GTrackBarBackground.Value, BTrackBarBackground.Value);
            label2.Text = "" + GTrackBarBackground.Value;
        }

        private void BTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            BackColor = Color.FromArgb(255, RTrackBarBackground.Value, GTrackBarBackground.Value, BTrackBarBackground.Value);
            label3.Text = "" + BTrackBarBackground.Value;
        }

        private void guna2TrackBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            ForeColor = Color.FromArgb(255, RTrackBarFont.Value, GTrackBarFont.Value, BTrackBarFont.Value);
            label8.Text = "" + RTrackBarFont.Value;
        }

        private void GTrackBarFont_Scroll(object sender, ScrollEventArgs e)
        {
            ForeColor = Color.FromArgb(255, RTrackBarFont.Value, GTrackBarFont.Value, BTrackBarFont.Value);
            label7.Text = "" + GTrackBarFont.Value;
        }

        private void BTrackBarFont_Scroll(object sender, ScrollEventArgs e)
        {
            ForeColor = Color.FromArgb(255, RTrackBarFont.Value, GTrackBarFont.Value, BTrackBarFont.Value);
            label6.Text = "" + BTrackBarFont.Value;
        }
    }
}
