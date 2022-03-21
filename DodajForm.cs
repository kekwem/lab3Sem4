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
    public partial class DodajForm : Form
    {
        public Person person;

        public DodajForm()
        {
            InitializeComponent();
        }

        private void doddawanieButton_Click(object sender, EventArgs e)
        {
            person = new Person(imieTextBox.Text, nazwiskoTextBox.Text, Double.Parse(wiekTextBox.Text), miastoTextBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
