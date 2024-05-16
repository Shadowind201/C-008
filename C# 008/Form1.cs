using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(textBoxIdade.Text);
            if (idade >= 18) 
            {
                MessageBox.Show("Permissão concedida");
            }
            else
            {
                MessageBox.Show("Sem permição");
            }
        }
    }
}
