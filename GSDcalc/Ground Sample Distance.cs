using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gdscalc
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange800, Primary.DeepOrange900, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);

        }

        string s;
        double a;
        double b;
        double c;
        double d;
        double f;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = textBox1.Text;
            a = Convert.ToDouble(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s = textBox2.Text;
            b = Convert.ToDouble(s);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s = textBox3.Text;
            c = Convert.ToDouble(s);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            s = textBox4.Text;
            d = Convert.ToDouble(s);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            {
                f = ((a * b * 100) / (c * d));
                label7.Text = f.ToString("#.##");
            }
        }
    }
}