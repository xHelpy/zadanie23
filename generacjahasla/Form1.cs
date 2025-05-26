using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generacjahasla
{
    public partial class Form1 : Form
    {
        public int passwordLength = 0;
        public bool characterState = false;
        public bool numbersState = false;
        public bool lettersState = false;


        public string position = "";
        public string name = "";
        public string surname = "";

        public string Password;
        public string smalLetters = "abcdefghijklmnopqrstuvwxyz";
        public string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string specialCharset = "!@#$%^&*()_-+=";
        public string numberCharset = "1234567890";

        Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void specialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            if(!characterState)
                characterState = true;
            else
                characterState = false;
        }

        private void numbers_CheckedChanged(object sender, EventArgs e)
        {
            if (!numbersState)
                numbersState = true;
            else
                numbersState = false;
        }

        private void letters_CheckedChanged(object sender, EventArgs e)
        {
            if (!lettersState)
                lettersState = true;
            else
                lettersState = false;
        }

        private void characterAmount_TextChanged(object sender, EventArgs e)
        {
            passwordLength = int.Parse( characterAmount.Text );
        }

        private void generatePassword_Click(object sender, EventArgs e)
        {
            Password = "";
            for (int i = 0; i < passwordLength; i++)
            {
                if (i == 0 && characterState)
                {
                    int x = random.Next(specialCharset.Length);

                    Password += specialCharset[x];

                } else if(i == 0 && !characterState)
                {
                    Console.WriteLine("1");
                    int x = random.Next(smalLetters.Length);

                    Password += smalLetters[x];
                }
                if (i == 1 && numbersState)
                {
                    int x = random.Next(numberCharset.Length);

                    Password += numberCharset[x];
                }
                else if (i == 1 && !numbersState)
                {
                    int x = random.Next(smalLetters.Length);

                    Password += smalLetters[x];
                }
                if (i == 2 && lettersState) 
                    {
                    int x = random.Next(bigLetters.Length);

                    Password += bigLetters[x];
                }
                else if (i == 2 && !lettersState)
                {
                    int x = random.Next(smalLetters.Length);

                    Password += smalLetters[x];
                }
                if (i > 2)
                {
                    int x = random.Next(smalLetters.Length);

                    Password += smalLetters[x];
                }
                
            }
      
            MessageBox.Show(Password);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            surname = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            position = comboBox1.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name + " " + surname + " " + position + " " + Password);
        }

        private void userName_Click(object sender, EventArgs e)
        {

        }
    }
}
