using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }
       
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileName = openFileDialog1.FileName;
         
          

         //   using (StreamReader reader = new StreamReader(fileStream))
         //   {
         //       fileContent = reader.ReadToEnd();
         //   }
            

            pictureBox1.Image= Image.FromFile(fileName);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }


    }
}
