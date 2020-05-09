using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods_Stringler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string TersCevir(string deger)
        {
            char[] karakterler = deger.ToCharArray();
            Array.Reverse(karakterler);
            return new string(karakterler); // Ters karakterler dizisinden bir string yap.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelen_deger = textBox1.Text;
            string ters_hali = TersCevir(gelen_deger);
            if (gelen_deger == ters_hali)
            {
                MessageBox.Show("Aynıdır.");
            }
            else
            {
                MessageBox.Show("Aynı değildir.");
            }
        }
    }
}