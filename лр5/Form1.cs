using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string list_numb = "";
        public string list_symb = "";
        public string list_all = "";
        public char[] numbs = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char[] symbs = new char[8] { '.', ',', ':', ';', '"','-','!','?' };
        public List<char> list_not_all = new List<char>();

        public void List_numb(char i)
        {
            for (int j = 0; j < numbs.Length; j++)
            {
                if (i == numbs[j])
                {
                    list_numb += i;
                    list_not_all.Add(i);
                }
                
            }
        }
        public void List_symb(char i)
        {
            for (int j = 0; j < symbs.Length; j++)
            {
                if (i == symbs[j])
                {
                    list_symb += i;
                    list_not_all.Add(i);
                }
            }
        }
       
        public void List_all(char i)
        {
           if(list_not_all.Contains(i)==false)
            {
                list_all += i;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Введите текст, используя цифры, слова и знаки препинания";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int count = 0;
            foreach (char i in textBox1.Text)
            {
                List_numb(i);
                List_symb(i);
                List_all(i);
                if(i==' ')
                {
                    count++;
                }
            }
            //Вывод цифр, знаков препинания и других элементов
            textBox2.Text = list_numb;
            textBox3.Text = list_symb;
            textBox4.Text = list_all;
            textBox5.Text = Convert.ToString(count);

            // Очистка строк и списка

            list_numb = "";
            list_symb = "";
            list_all = "";
            list_not_all.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
