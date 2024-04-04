using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetCare
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float peso = float.Parse(textBox1.Text);
            int idade = int.Parse(textBox2.Text);

            if (peso != 0 && idade != 0){

                Form3 form3 = new Form3();
                form3.Receber(peso, idade);
                form3.Show();
            }
            else
            {
                MessageBox.Show("ERRO");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
