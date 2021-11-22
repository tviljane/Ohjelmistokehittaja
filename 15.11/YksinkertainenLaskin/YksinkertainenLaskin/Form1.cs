using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YksinkertainenLaskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeTB_Click(object sender, EventArgs e)
        {
            float lasku = 0;
           float Luku1 = float.Parse(LukuYksiTB.Text);
           float Luku2 = float.Parse(LukuKaksiTB.Text);
            string merkki = LaskutoimitusCB.Text;
            switch (merkki)
            {
                case "+":
                    lasku = Luku1 + Luku2;
                    break;
                case "-":
                    lasku = Luku1 - Luku2;
                    break;
                case "*":
                    lasku = Luku1 * Luku2;
                    break;
                case "/":
                    if (Luku2 == 0)
                    {
                        VastausLB.Text = "Nollalla ei voi jakaa";
                        goto HYPPY;
                    }
                    else
                    {
                        lasku = Luku1 / Luku2;
                    }
                    break;

            }
            VastausLB.Text = lasku + "";
            HYPPY:
            VastausLB.Visible = true;
        
        }
    }
}
