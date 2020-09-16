using EmaililePazarlamaUygulaması.Source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmaililePazarlamaUygulaması
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
            string[] fileList = Utilties.ListDirectory("AddressLists", true);
            for (int i = 0; i < fileList.Length; i++)
            {
                string filePath = fileList[i];
                char[] delim = {'\\'};
                string[] fileName = filePath.Split(delim);
                listBox1.Items.Add(fileName[fileName.Length -1]);
            }
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Utilties.GetFilePath("AddressList");
            string deneme = Utilties.ListDirectory("",false)[0];
            richTextBox1.Text = deneme;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmailList addEmail = new AddEmailList(listBox1);
            addEmail.ShowDialog();
        }
    }
}
