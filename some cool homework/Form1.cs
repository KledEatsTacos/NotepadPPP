/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Mustafa Masri
**				ÖĞRENCİ NUMARASI.......: G221210580
**                         DERSİN ALINDIĞI GRUP...: 2. Öğretim A Grubu
****************************************************************************/

//hello user, this program was made for my object oriented class homework.
//I will probably never check up on it again, so good luck with it!

using System.Diagnostics.CodeAnalysis;

namespace some_cool_homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region file options
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if the user did not save the file, the program will ask the user if they want to save the file
            //it will save as a text file
            if (richTextBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the file?", "Save", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                    richTextBox1.Clear();
                }
                else if (dialogResult == DialogResult.No)
                {
                    richTextBox1.Clear();
                }
            }
            else
            {
                richTextBox1.Clear();
            }
        }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //save the file
            richTextBox1.SaveFile(saveFileDialog1.FileName);

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks, the save file dialog will open
            saveFileDialog1.ShowDialog();

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks, the open file dialog will open, and the user can choose a text file
            openFileDialog1.ShowDialog();
            //and the thing will take the text from the file and paste it into the rich text box
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //before exiting, the program will ask the user if they want to save the file
            if (richTextBox1.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the file?", "Save", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    saveFileDialog1.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
        #endregion
        #region Cut copy paste
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        #endregion
        #region text options
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks, the color dialog will open, and the user can choose a color
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;

        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //the background of the text will change to the color the user chooses
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //the font dialog will open, and the user can choose the font
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }
        private void backgroundColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
        #endregion
        #region templates
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks this, a ready template for the language C will appear, and the user will start coding
            richTextBox1.Text = "#include <stdio.h>\nint main()\n{\n\nreturn 0;\n}";


        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //same thing as the previous one but for C#
            richTextBox1.Text = "using System;\nclass Program\n{\nstatic void Main()\n{\n\n}\n}";
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //same thing but for C++
            richTextBox1.Text = "#include <iostream>\nusing namespace std;\nint main()\n{\n\nreturn 0;\n}";
        }
        #endregion
        #region about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //when the user clicks this, a message box will appear with the information about the program
            MessageBox.Show("Greetings, user!\nthis is a simple program that I made for some homework, and I probably will never come back to check up on it. Good luck!");
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Woah, it seems like you have a problem. Well, I'm too lazy to go fix it, so you'll have to deal with it yourself. Sorry!");
        }

        private void suggestAFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Looks like you want to suggest a feature. Well, I'm too lazy to add it, so you'll have to deal with it yourself. Sorry!");
        }
        #endregion

    }
}