using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //BackgroundImage = new Bitmap(@"C:\Users\777\Desktop\fon.jpg");
        }
        int poz1 = 0;
        int poz2 = 0;
        int poz3 = 0;
        int poz4 = 0;
        int poz5 = 0;
        int poz6 = 0;

        static string [] ydot = new string [] { "21000", "12000" };
        static int gnrint = 0;
        string delinf = ydot[gnrint];
        







        string[][] text = new string[][] {
            new string [] { "Вывожу основной текст сюда, задаю вопрос, отвечай!" },
            new string [] { "Вывожу второй текст" },
            new string [] { "Вывожу третий текст" }
        };


        string[][] otvet = new string[][] {
              new string [] { "Ответ 1. Удаляется", "Ответ 2. Переход", "Ответ 3. Остается" },
              new string [] { "Ответ 1а. Переход", "Ответ 2а. Удаляется", "Ответ 3а. Остается", "Ответ 4а. Остается" }
        };

        string[][] otvetnaotvet = new string[][] {
            new string [] { "Ответ на ответ 1", "Ответ на ответ 2 и переход на новый текст", "Ответ на ответ 3" },
            new string [] { "Ответ на ответ 1а и переход на новый текст", "Ответ на ответ 2а", "Ответ на ответ 3а"}
        };






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int si = listBox1.SelectedIndex;


            if (si == -1)
            {
                si = 1;
            }

            if (delinf[si] == '1')
            {
                textBox2.Text = "delinf = " + delinf + '\r' + '\n' + "si = " + si;

                textBox1.Text = otvetnaotvet[poz4][si];
                f_otvet();
            }

            else if (delinf[si] == '2')
            {
                textBox2.Text = "delinf = " + delinf + '\r' + '\n' + "si = " + si;

                delinf = delinf.Remove(si, si + 1);
                listBox1.Items.RemoveAt(si);
                textBox1.Text = otvetnaotvet[poz4][si];
                otvetnaotvet[poz4][si] = otvetnaotvet[poz4][si].Remove(si);
            }

            else if (delinf[si] == '0')
            {
                textBox2.Text = "delinf = " + delinf + '\r' + '\n' + "si = " + si;

                textBox1.Text = otvetnaotvet[poz4][si];
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            f_text();
        }


     

        private void f_text()
        {

            listBox1.Items.Clear();

            if (poz1 > text.Length-1)
            {
                poz1 = 0;
            }
            textBox1.Text = text[poz1][poz2];
            poz1 = poz1 + 1;

            f_otvet();
        }

        private void f_otvet()
        {
            listBox1.Items.Clear();


            if (poz3 > otvet.Length-1)
            {
                poz3 = 0;
            }

            for (int i = 0; i < otvet[poz3].Length; i++)
            {
                listBox1.Items.Add(otvet[poz3][i]);
            }
            poz3 = poz3 + 1;
        }



        private void perehod()
        {

        }





        //otvet2.GetLength(0); Длина массива
        //listBox1.Items.RemoveAt(listBox1.SelectedIndex); удаление выбранного элемента
        //listBox1.Items.Clear(); Очищаем листбокс
        //listBox1.Items.Add(otvet2[i]); Добавить элементы в листбокс
        //listBox1.Items.Add(genot[poz3][poz4]); Добавить элементы в листбокс
       // ListBox.ClearSelected(); Снять выделение

















    }
}

