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
using static System.Windows.Forms.LinkLabel;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
         (StreamReader inputFile = new StreamReader(Path.Combine("C:/temp1", "Note.txt")))
            {

                NoteTextBox.Text = inputFile.ReadLine();
            }*/

        
                NoteTextBox.Text = File.ReadAllText("C:/temp1/Note.txt");
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine("C:/temp1", "Note.txt")))
            {
               
                    outputFile.WriteLine(NoteTextBox.Text);
            }

        }
    }
}
