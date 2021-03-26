using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VertShifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] key = {5,3,2,4,1};

        public void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] shifr = text.ToCharArray();
            for (int i = 0; i < text.Length % key.Length; i++)
                text += text[i];

            string result = "";

            for (int i = 0; i < text.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[key[j] - 1] = text[i + j];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }
            textBox2.Text = result ;
            textBox1.Text = "";
        }

        public void button2_Click(object sender, EventArgs e)
        {         
            string text = textBox2.Text;
            char[] shifr = text.ToCharArray();
            for (int i = 0; i < text.Length % key.Length; i++)
                text += text[i];
            string result = "";

            for (int i = 0; i < text.Length; i += key.Length)
            {
                char[] transposition = new char[key.Length];

                for (int j = 0; j < key.Length; j++)
                    transposition[j] = text[i + key[j] - 1];

                for (int j = 0; j < key.Length; j++)
                    result += transposition[j];
            }
            textBox1.Text = result;
            textBox2.Text = "";
        }
    }
}
