using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace EditorHTML
{
    public partial class Form1 : Form
    {
        string username = Environment.UserName;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            webBrowser1.DocumentText = richTextBox1.Text + richTextBox2.Text;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] textlines = richTextBox1.Lines;
            
            try
            {
                SaveFileDialog salva = new SaveFileDialog();
                salva.Filter = "html files (*.html)|*.html|All files (*.*)|*.*";
               
                salva.ShowDialog();

                using (StreamWriter sw = new StreamWriter(salva.FileName))
                {
                    for (int p = 0; p < textlines.GetUpperBound(0) + 1; p++)
                    {
                        sw.WriteLine(textlines[p]);
                    }
                }
            }
            catch { MessageBox.Show("Errore nel salvataggio");  }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] textlines2 = richTextBox2.Lines;
            try 
            {
                SaveFileDialog salvaCss = new SaveFileDialog();
                salvaCss.Filter = "css files (*.css)|*.css|All Files (*.*)|*.*";
                salvaCss.ShowDialog();
                using (StreamWriter sw = new StreamWriter(salvaCss.FileName))
                {
                    for (int p = 0; p < textlines2.GetUpperBound(0) + 1; p++)
                    {
                        
                        sw.WriteLine(textlines2[p]);
                    }
                }

            }
            catch { MessageBox.Show("Errore nel salvataggio"); }
        }
       
    }
}
