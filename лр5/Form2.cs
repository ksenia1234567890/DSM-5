using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Русский алфавит

        public string alfabet = "йцукенгшщзхъфывапролджэячсмитьбю";
        


        public int how_much = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                foreach(char i in textBox1.Text)
                { 
                    // Переход к низкому регистру

                    string i2 = Convert.ToString(i);
                    string j = i2.ToLower();
                    char j2 = Convert.ToChar(j);

                    // Проверка: написан ли текст на английском языке
                   
                        if (alfabet.Contains(i)==true) 
                        {
                            throw new Exception("Не весь текст написан на английском языке");
                        }
                    
                    // Подсчёт пробелов

                    if (i == ' ')
                    {
                        count++;
                    }
                }

                
                // Удаление пробелов из начала и конца строки, чтобы вырезать слово

                List<string> words = new List<string>();
                foreach (string s in textBox1.Text.Split(' '))
                {
                    words.Add(s);
                }
                string text = "";

                // цикл перебирает все элементы в списке, каждый элемент проходит через метод
                // который меняет первую букву слова на заглавную

                for (int i = 0; i < words.Count; i++)
                {
                    text += ChangeFirstLetter(words[i]) + " ";
                }

                textBox3.Text = text;
                textBox2.Text = Convert.ToString(count);
            }
            catch (Exception x)
            {
                textBox3.Text = x.Message;
            }
        }
        
        // метод, который меняет первую букву на заглавную
        public string ChangeFirstLetter(string letter)
        {

            // Создание массива

            char[] let = new char[letter.Length];
            for(int i=0; i<let.Length; i++)
            {
                let[i] = letter[i];
            }

            // Изменение первой буквы на заглавную и присвоение буквы в массиве

            string g = Convert.ToString(letter[0]);
            g = g.ToUpper();
            char letter_change = Convert.ToChar(g); 
            let[0] = letter_change;
            string line = string.Join("", let);
            return line;
        }
    }
}
