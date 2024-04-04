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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void Receber(float peso, int idade)
        {
            if (peso<=4){
                label1.Text = "Seu cachorrinho precisa de 55 a 95 gramas de ração por dia.";
            }
            else if (peso > 4 && peso <= 8){
                label1.Text = "Seu cachorrinho precisa de 95 a 155 gramas de ração por dia.";
            }
            else if (peso > 8 && peso <= 20){
                label1.Text = "Seu cachorro precisa de 160 a 320 gramas de ração por dia.";
            }
            else if (peso > 20 && peso <= 40){
                label1.Text = "Seu cachorro precisa de 320 a 530 gramas de ração por dia.";
            }
            else{
                label1.Text = "Seu cachorro precisa de mais de 500 gramas de ração por dia.";
            }
            label2.Text = $"Peso: {peso} - Idade: {idade}";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
