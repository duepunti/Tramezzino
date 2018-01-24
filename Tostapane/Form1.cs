using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tostapane
{
    public partial class Form1 : Form
    {
        String testo;
        String sfondo;
        String colore;

        public Form1()
        {
            InitializeComponent();
            string[] args;
            args = Environment.GetCommandLineArgs();

            try
            {
                testo = args[1];
                string finale = testo.Replace("*_*", " ");
                toast.Text = finale;
            }
            catch
            {
                MessageBox.Show("Nessun Argomento Fornito", "DuePunti");
            }

            try
            {
                sfondo = args[2];
                sfondo = sfondo.ToLower();

                // ITALIANO
                if(sfondo == "nero")
                {
                    this.BackColor = Color.Black;
                }
                else if(sfondo == "bianco")
                {
                    this.BackColor = Color.White;
                }
                else if(sfondo == "giallo")
                {
                    this.BackColor = Color.Yellow;
                }
                else if(sfondo == "arancione")
                {
                    this.BackColor = Color.Orange;
                }
                else if(sfondo == "verde")
                {
                    this.BackColor = Color.Green;
                }
                else if(sfondo == "rosso")
                {
                    this.BackColor = Color.Red;
                }
                else if(sfondo == "azzurro")
                {
                    this.BackColor = Color.LightBlue;
                }
                else if(sfondo == "fuchsia")
                {
                    this.BackColor = Color.Fuchsia;
                }
                else if(sfondo == "grigio")
                {
                    this.BackColor = Color.Gray;
                }
                else if(sfondo == "blu")
                {
                    this.BackColor = Color.Blue;
                }

                //  INGLESE
                else if (sfondo == "white")
                {
                    this.BackColor = Color.White;
                }
                else if (sfondo == "yellow")
                {
                    this.BackColor = Color.Yellow;
                }
                else if (sfondo == "orange")
                {
                    this.BackColor = Color.Orange;
                }
                else if (sfondo == "green")
                {
                    this.BackColor = Color.Green;
                }
                else if (sfondo == "red")
                {
                    this.BackColor = Color.Red;
                }
                else if (sfondo == "lightblue")
                {
                    this.BackColor = Color.LightBlue;
                }
                else if (sfondo == "fuchsia")
                {
                    this.BackColor = Color.Fuchsia;
                }
                else if (sfondo == "gray")
                {
                    this.BackColor = Color.Gray;
                }
                else if(sfondo == "blue")
                {
                    this.BackColor = Color.Blue;
                }


            }
            catch { }

            try
            {
                colore = args[3];
                colore = colore.ToLower();

                //  ITALIANO
                if(colore == "bianco")
                {
                    toast.ForeColor = Color.White;
                }
                else if (colore == "nero")
                {
                    toast.ForeColor = Color.Black;
                }
                else if (colore == "giallo")
                {
                    toast.ForeColor = Color.Yellow;
                }
                else if (colore == "arancione")
                {
                    toast.ForeColor = Color.Orange;
                }
                else if (colore == "verde")
                {
                    toast.ForeColor = Color.Green;
                }
                else if (colore == "rosso")
                {
                    toast.ForeColor = Color.Red;
                }
                else if (colore == "azzurro")
                {
                    toast.ForeColor = Color.LightBlue;
                }
                else if (colore == "fuchsia")
                {
                    toast.ForeColor = Color.Fuchsia;
                }
                else if (colore == "grigio")
                {
                    toast.ForeColor = Color.Gray;
                }
                else if (colore == "blu")
                {
                    toast.ForeColor = Color.Blue;
                }

                // INGLESE
                else if (colore == "white")
                {
                    toast.ForeColor = Color.White;
                }
                else if (colore == "yellow")
                {
                    toast.ForeColor = Color.Yellow;
                }
                else if (colore == "orange")
                {
                    toast.ForeColor = Color.Orange;
                }
                else if (colore == "green")
                {
                    toast.ForeColor = Color.Green;
                }
                else if (colore == "red")
                {
                    toast.ForeColor = Color.Red;
                }
                else if (colore == "lightblue")
                {
                    toast.ForeColor = Color.LightBlue;
                }
                else if (colore == "fuchsia")
                {
                    toast.ForeColor = Color.Fuchsia;
                }
                else if (colore == "gray")
                {
                    toast.ForeColor = Color.Gray;
                }
                else if (colore == "blue")
                {
                    toast.ForeColor = Color.Blue;
                }
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int len = toast.Text.Length;
            int piu = len + 100;
            this.Size = new Size(200, 33);
            //this.ClientSize.Width
            toast.Left = (this.ClientSize.Width - toast.Size.Width) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
