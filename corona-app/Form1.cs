using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corona_app
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pnlVraag1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
                pnlVraag1.Show();
        }

        private void btnVraag1_Click(object sender, EventArgs e)
        {
            if (rbtnVraag1JA.Checked == true || rbtnVraag1NEE.Checked == true)
            {
                pnlVraag2.Show();
                errorPanelVraag1.Hide();

            } else
            {
                errorPanelVraag1.Show();
            }
        }

        private void btnVraag2_Click(object sender, EventArgs e)
        {
            if (rbtnVraag2JA.Checked == true || rbtnVraag2NEE.Checked == true)
            {
                pnlVraag3.Show();
                errorPanelVraag2.Hide();

            } else
            {
                errorPanelVraag2.Show();
            }
        }

        private void btnVraag3_Click(object sender, EventArgs e)
        {
            if (rbtnVraag3JA.Checked == true || rbtnVraag3NEE.Checked == true)
            {
                pnlVraag4.Show();
                errorPanelVraag3.Hide();
            } else
            {
                errorPanelVraag3.Show();
            }
        }

        private void btnVraag4_Click(object sender, EventArgs e)
        {
            double temperatuur = 0.0;

            try 
            { 
                temperatuur = double.Parse(tbVraag4.Text);

            } catch (Exception)
            {
                errorPanelVraag4.Show();
            }

            if (temperatuur >= 32 && temperatuur <= 44)
            {
                pnlAdvies.Show();
                pnlVraag1.Hide();
                pnlVraag2.Hide();
                pnlVraag3.Hide();
                pnlVraag4.Hide();
                errorPanelVraag4.Hide();
                if ((temperatuur <= 36.5 || temperatuur >= 37.5) || rbtnVraag1JA.Checked == true || rbtnVraag2JA.Checked == true || rbtnVraag3JA.Checked == true)
                {
                    lblAdvies.Text = "Blijf thuis, bel de GGD en laat je testen";
                } else
                {
                    lblAdvies.Text = "Niks aan de hand";
                }
            }
            else
            {
                errorPanelVraag4.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlAdvies.Hide();
            rbtnVraag1JA.Checked = false;
            rbtnVraag1NEE.Checked = false;
            rbtnVraag2JA.Checked = false;
            rbtnVraag2NEE.Checked = false;
            rbtnVraag3JA.Checked = false;
            rbtnVraag3NEE.Checked = false;
            tbVraag4.Text = "";
            lblAdvies.Text = "";
        }
    }
}
