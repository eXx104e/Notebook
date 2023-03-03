using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace FirstHomeWorkPart2
{
    public partial class Form1 : Form
    {
        private string openFile;

        public Form1()
        {
            InitializeComponent();
        }


        public void PrintThisPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBoxMain.Text, richTextBoxMain.Font, Brushes.Black, 0, 0);
        }

        
        private void richTextBoxMain_TextChanged_1(object sender, EventArgs e)
        {

        }



        
        private void создатьStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxMain.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\Users\";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "Новый текстовый документ";
                saveFileDialog.Filter = "Новый документ (*.txt) | *.txt | Все файлы | *.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBoxMain.Text);
                }

                richTextBoxMain.Text = "";
                openFile = null;
            }
            else if (richTextBoxMain.Text == "" && openFile != null)
            {
                File.WriteAllText(openFile, richTextBoxMain.Text);
                richTextBoxMain.Text = "";

                openFile = null;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\Users\";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "Новый текстовый документ";
                saveFileDialog.Filter = "Новый документ (*.txt) | *.txt | Все файлы | *.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBoxMain.Text);
                }
            }
            else
            {
                File.WriteAllText(openFile, richTextBoxMain.Text);
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые документы (*.txt) | *.txt | Все файлы | *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxMain.Text = File.ReadAllText(openFileDialog.FileName);

                openFile = openFileDialog.FileName;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.InitialDirectory = @"C:\Users\";
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = "Новый текстовый документ";
                    saveFileDialog.Filter = "Новый документ (*.txt) | *.txt | Все файлы | *.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBoxMain.Text);

                        openFile = saveFileDialog.FileName;
                    }
                }
                else
                {
                    File.WriteAllText(openFile, richTextBoxMain.Text);
                }

                Application.Exit();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintThisPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDialog.Document.Print();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"C:\Users\";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "Новый текстовый документ";
                saveFileDialog.Filter = "Новый документ (*.txt) | *.txt | Все файлы | *.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBoxMain.Text);

                    openFile = saveFileDialog.FileName;
                }
            }
            else
            {
                File.WriteAllText(openFile, richTextBoxMain.Text);
            }

            Application.Exit();
        }



        
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog myFont = new FontDialog();

            if (myFont.ShowDialog() == DialogResult.OK)
            {
                //Clipboard.SetText(richTextBoxMain.SelectedText);


                if (richTextBoxMain.SelectedText != "")
                {
                    richTextBoxMain.SelectionFont = myFont.Font;
                }
                else
                {
                    richTextBoxMain.Font = myFont.Font;
                }
            }
        }



        
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2AboutProgram form2AboutProgram = new Form2AboutProgram();
            form2AboutProgram.ShowDialog();
        }



        
        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxMain.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxMain.SelectedText);
                richTextBoxMain.SelectedText = string.Empty;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxMain.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxMain.SelectedText);
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxMain.SelectedText = richTextBoxMain.SelectedText + Clipboard.GetText();
        }
    }
}
