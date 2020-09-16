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
        private ListBox emailListBox;
        public AddEmailList(ListBox EmailListBox)
        {
            InitializeComponent();
            emailListBox = EmailListBox;
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = textBox2.Text;
            if (path.Contains(".txt")){
                //get the name of the file                    
                string[] dir = path.Split('\\');
                string fileName = dir[dir.Length - 1];
                // Get current directory with file name 
                string dirPath = Utilties.GetFilePath("AddressLists\\" + fileName);
                if (!File.Exists(dirPath))
                {

                    string[] oldLines;

                    using (FileStream fs = File.Create(dirPath)) {
                        oldLines = File.ReadAllLines(path);
                    }
                    using (var tw = new StreamWriter(dirPath, true))
                    {
                        foreach (string line in oldLines)
                        {
                            tw.WriteLine(line);
                        }
                    }

                    //Update email list
                    string[] fileList = Utilties.ListDirectory("AddressLists", true);

                    // new fileNameslist cause fileNames contains the full directory
                    string[] outputNames = new string[fileList.Length];
                    for (int i = 0; i < fileList.Length; i++)
                    {
                        string filePath = fileList[i];
                        char[] delim = { '\\' };
                        string[] fileNames = filePath.Split(delim);
                        outputNames[i] = fileNames[fileNames.Length - 1];
                    }
                    
                    emailListBox.DataSource = outputNames;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bu isimle bir email listeniz zaten var. Başka bir ad kullanın ya da " + fileName + " isimli email listesini silin. ");
                }
            }
            else
            {
                MessageBox.Show("Ekleyeceğiniz dosya bir Text (.txt) dosyası olmalı. ");
            }
            
        }
    }
}
