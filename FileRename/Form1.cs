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
fdjkhsyhgjfdshgjkdshfkjldshfjkshfkjshjfksdhjk
namespace FileRename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "Przetwarzam";
                string[] files;
                files = Directory.GetFiles(textBox1.Text, '*' + textBox2.Text, SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    renameFile(file);
                }
                label4.Text = "Gotowe";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Coś się zjebało.\n" + ex.Message);
            }
        }

        private void renameFile(string file)
        {
            string path = file.Substring(0, file.LastIndexOf('\\')+1);
            string newFile = file.Substring(file.LastIndexOf('\\') + 1,(int)numericUpDown1.Value);
            File.Move(file, path+newFile+textBox2.Text);
        }
    }
}
