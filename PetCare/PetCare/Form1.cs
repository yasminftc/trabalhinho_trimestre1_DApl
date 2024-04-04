using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if ((Box1.Text == "senha123") && (Box2.Text == "email@petcare"))
            {
                MessageBox.Show("Login aceito!!!");

                //Form1.Close

                Form4 form4 = new Form4();
                form4.Show();
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }

    }
}

