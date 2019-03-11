using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApp
{
    public partial class Form1 : Form
    {
        public char[] EncryptIn;
        public char[] EncryptOut;
        public char[] decryptIn;
        public char[] decryptOut;
        public string result_text;
        public char[,] cryptKey = new char[,]
            {
                {'q','a'},
                {'a','z'},
                {'w','s'},
                {'s','x'},
                {'z','w'},
                {'x','e'},
                {'e','d'},
                {'d','c'},
                {' ','/'},
                {'i','k'},
                {'m','o'},
                {'h','n'},
                {'c','t'},
                {'r','f'},
                {'f','v'},
                {'b','u'},
                {'o','l'},
                {'y','h'},
                {'n','i'},
                {'k','<'},
                {'p',';'},
                {'u','j'},
                {'l','.'},
                {'t','g'}
            };
        public char[] number_Codes = new char[10] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };
            

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_text = null;
            EncryptIn = ((inputText.Text).ToLower()).ToCharArray();
            Array.Resize(ref EncryptOut, EncryptIn.Length);
            int w = cryptKey.GetLength(0);
            for (int i = 0; i < EncryptIn.Length; i++)
            {
                for (int z = 0; z < w; z++)
                {
                    if (cryptKey[z, 0].Equals(EncryptIn[i]))
                    {
                        EncryptOut[i] = cryptKey[z, 1];
                    }
                }
            }
            Random random = new Random();
            
            for (int i = 0; i < EncryptOut.Length; i++)
            {
                int random_Number = random.Next(1, 135);
                if (random_Number % 2 == 0)
                {
                    result_text += (Char.ToString(EncryptOut[i])).ToUpper();
                }
                else
                {
                    result_text += Char.ToString(EncryptOut[i]);
                }
            }
            result.Text = result_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_text = null;
            decryptIn = ((inputCrypt.Text).ToLower()).ToCharArray();
            Array.Resize(ref decryptOut, decryptIn.Length);
            int w = cryptKey.GetLength(0);
            for (int i = 0; i < decryptIn.Length; i++)
            {
                for (int z = 0; z < w; z++)
                {
                    if (cryptKey[z,1].Equals(decryptIn[i]))
                    {
                        decryptOut[i] = cryptKey[z,0];
                    }
                }
            }
            for (int i = 0; i < decryptOut.Length; i++)
            {
                result_text += Char.ToString(decryptOut[i]);
            }
            result_2.Text = result_text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char[] input_text = ((textBox1.Text).ToLower()).ToCharArray();
            int rep = 0;
            for(int i = 0; i < input_text.Length - 1;i++)
            {
                if (input_text.Length == 1)
                {
                    rep = 1;
                }
                else if (input_text.Length > 1)
                {
                    if (input_text[i + 1].Equals(input_text[i]))
                    {
                        rep++;
                    }
                }
            }
            rep += 1;
            label3.Text = rep.ToString();
        }
    }
}
