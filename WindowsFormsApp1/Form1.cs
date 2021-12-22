using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Char> alphabet = new List<Char>();
        string subchain;
        int multiplicityLength;
        int leftBorder;
        int rightBorder;

        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (!validateAlphabet())
            {
                return;
            }
            if (!validateRangeLength())
            {
                return;
            }
            if (!validateSubchain())
            {
                return;
            }
            if (!validateMultiplicityLength())
            {
                return;
            }

            //генерация
        }

        private bool validateRangeLength()
        {
            if (leftLengthRangeTextBox.Text == "" || rightLengthRangeTextBox.Text == "")
            {
                MessageBox.Show("Заполните диапазон длин");
                return false;
            }

            try
            {
                leftBorder = Convert.ToInt32(leftLengthRangeTextBox.Text);
                rightBorder = Convert.ToInt32(rightLengthRangeTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте поля диапазона длин на наличие лишних символов");
                return false;
            }

            if ( leftBorder > rightBorder )
            {
                MessageBox.Show("Левая граница должна быть меньше правой границы диапазона длин");
                return false;
            }


            return true;
        }
        private bool validateSubchain()
        {
            foreach (char item in subchainTextBox.Text)
            {
                if (!alphabet.Contains(item))
                {
                    MessageBox.Show("Подцепочка состоит из несуществующего символа");
                    return false;
                }
            }
            subchain = subchainTextBox.Text;
            return true;
        }

        private bool validateMultiplicityLength()
        {
            if (multiplicityLengthTextBox.Text != "")
            {
                try
                {
                    multiplicityLength =  Convert.ToInt32(multiplicityLengthTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Проверьте поле кратности длин на наличие лишних символов");
                    return false;
                }
            }

            return true;
        }

        private bool validateAlphabet()
        {
            if (alphabetTextBox.Text == "")
            {
                 MessageBox.Show("Заполните алфавит");
                 return false;
            }
            try
            {
                string[] alphabetArray = alphabetTextBox.Text.Split(',');
                List<String> alphabetList = alphabetArray.ToList();
                foreach (string item in alphabetList)
                {
                    alphabet.Add(Convert.ToChar(item));
                }
            }
            catch 
            {
                alphabet.Clear();
                MessageBox.Show("Заполните алфавит по указанному правилу");
                return false;
            }
            return true;
        }
    }
}
