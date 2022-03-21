using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okna_dialogowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            DodajForm dodaj = new DodajForm();
            var result = dodaj.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox.Items.Add($"{dodaj.person.ToString()}");
            }
            
        }
    }
}
