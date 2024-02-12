using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_Numero_ingresado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            Close();   

        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            listResultado.Items.Clear();
            TxCalculaer.Clear();
        }

        private void BTNmultiplicar_Click(object sender, EventArgs e)
        {
            
            int i;
            int t;
            t = Convert.ToInt32(TxCalculaer.Text);

            for (i = 1; i < 13;i++)

            {

                listResultado.Items.Add(i + " x " +  t+ " = " + (i * t)); ;
            }
        }

        private void TxCalculaer_TextChanged(object sender, EventArgs e)
        {
            TxCalculaer.Focus();
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {

            if (listResultado.SelectedIndex != -1)
            {
                listResultado.Items.RemoveAt(listResultado.SelectedIndex);
            }

        }
    }
}
