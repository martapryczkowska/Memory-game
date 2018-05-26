using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORY
{
    public partial class Form2 : Form
 
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void łatwy_Click(object sender, EventArgs e)
        {
            this.okno2 = new Form3();
            this.okno2.rodzic = this;
            this.okno2.Show();
        }
        private void średni_Click(object sender, EventArgs e)
        {
            this.okno = new Form1();
            this.okno.rodzic = this;
            this.okno.Show();
        }
        private void trudny_Click(object sender, EventArgs e)
        {
            this.okno3 = new Form4();
            this.okno3.rodzic = this;
            this.okno3.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void koniec_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            this.okno4 = new Form5();
            this.okno4.rodzic = this;
            this.okno4.Show();
        }
    }
}
