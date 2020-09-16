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

namespace EmaililePazarlamaUygulaması.Source
{
    public partial class AddEmailList : Form
    {
        public AddEmailList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "AddressLists\\" + textBox1.Text + ".txt";
            string path = Utilties.GetFilePath(fileName);
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu isimle bir email listeniz zaten var. Başka bir ad kullanın ya da " + textBox1.Text + " isimli email listesini silin. ");
            }
            
        }
    }
}
