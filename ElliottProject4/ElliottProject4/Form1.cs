using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElliottProject4
{
    public partial class Form1 : Form
    {
        public BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Clicking the exit button will close the program
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"BinaryTextFile.txt");   

            //Splits text file by the characters below
            char[] delimiterChars = { ' ', '"', '.', ':', '\t', '\r', '\n', '?', '!', ';', '(', ')' };
            string[] words = text.Split(delimiterChars);
            

            foreach (string s in words)
            {
                if(!string.IsNullOrWhiteSpace(s.Replace(",","")))
                {
                    //ToLower makes all words lowercase
                    tree.addNode(s.ToLower().Replace(",",""));
                }
            }

            txtBox.Text = tree.printOut();
            label1.Text = "Total Word Count: " + tree.counter.ToString();
        }
    }
}
