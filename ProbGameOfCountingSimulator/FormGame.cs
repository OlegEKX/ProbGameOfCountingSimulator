﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbGameOfCountingSimulator
{
    public partial class FormShet : Form
    {
        int minuteTimeForTimer = 0;
        int timeForTimer = 0;
        int rightAnswer = 0;
        int wrongAnswer = 0;
        int count = 0; //количество попыток
        int minNumber = 1;
        int maxNumber = 10; //уровень сложности задачи 10 - двухзначные числа, 100 - трехзначные числа
        Random rnd = new Random();
        string answer;
        int countMax = 3; // для прогресс бара максимальное количество попыток
        string mode = ""; // режим, что будет выполняться: сложение, вычитание, деление
        bool plus = true,
            minus = true,
            mult = true,
            divs = true;

        public FormShet()
        {
            InitializeComponent();
            textBoxLevel.Text = maxNumber.ToString();
            //timer.Interval = 1000; // 1 секунда
            
        }

        
        
        private void start(string myMode)
        {
            labelTry.Visible = true;
            count = 0;
            rules.Visible = false;

            mode = myMode;
            //убираем все кнопки на время игры
            buttonPlus.Visible = false;
            buttonMinus.Visible = false;
            buttonMult.Visible = false;
            buttonDivs.Visible = false;

            textBoxAnswer.Enabled = true;
            labelThink.Enabled = true;
            textBoxAnswer.Focus();
            textBoxAnswer.Text = "";
            labelThink.Text = "";
            labelTry.Text = "Попытка " + count + " из " + countMax;

            // элементы try и catch - исключения, при выполнении этого блока, сначала выполняется действие в try, если исключение появится, то программа перейдет к действиям находящимся в catch
            try
            {
                maxNumber = Convert.ToInt16(textBoxLevel.Text);
            }
            catch
            {
                maxNumber = 10;
                textBoxLevel.Text = maxNumber.ToString();
            }
            think();
        }

        private void think()
        {
            timer.Enabled = true;
            textBoxAnswer.Text = "";
            textBoxAnswer.Focus();
            if (rightAnswer < countMax)
            {
                int a, b;
                a = rnd.Next(minNumber, maxNumber + 1);
                b = rnd.Next(minNumber, maxNumber + 1);

                if (mode == "plus")
                {
                    labelThink.Text = a.ToString() + " + " + b.ToString() + " = ";
                    answer = (a + b).ToString();
                }

                if (mode == "minus")
                {
                    if (a < b) //чтобы не было отрицательных чисел, поменяем местами
                    {
                        int x = a;
                        a = b;
                        b = x;
                    }
                    labelThink.Text = a.ToString() + " - " + b.ToString() + " = "; // - = ALT+0150 на цифровой
                    answer = (a - b).ToString();
                }

                if (mode == "mult")
                {
                    labelThink.Text = a.ToString() + " * " + b.ToString() + " = ";
                    answer = (a * b).ToString();
                }
                if (mode == "divs")
                {
                    // можно так выпендриться, чтобы не использовать целочисленное деление
                    labelThink.Text = (a * b).ToString() + " ; " + b.ToString() + " = ";
                    answer = a.ToString();
                }
            }
            else
            {
                minuteTimeForTimer = 0;
                timeForTimer = 0;
                timer.Stop();
                done();
            }
        }

        private void done()
        {
            labelTry.Visible = false;
            labelThink.Enabled = false;
            textBoxAnswer.Enabled = false;
            buttonPlus.Focus(); // передаем фокус на кнопку игры
            count = 0;
            rightAnswer = 0;

            // возвращаем кнопки на панель согласно условию
            // если какое-то задание выполнено, кнопка становится неактивной
            // убираем все кнопки на время игры
            buttonPlus.Visible = true;
            buttonMinus.Visible = true;
            buttonMult.Visible = true;
            buttonDivs.Visible = true;
            buttonAnswer.Visible = true;

            buttonPlus.Enabled = plus;
            buttonMinus.Enabled = minus;
            buttonMult.Enabled = mult;
            buttonDivs.Enabled = divs;

            if (!plus && !minus && !mult && !divs)
            {
                MessageBox.Show("Ты прошел все уровни!", "Твоя победа и полное поражение компьютера");
                buttonAnswer.Visible = false;
            }
        }

        private void rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"«Инструкция по тренажеру устного счета» \n\n" +
                $"✪ Вам дается возможность поочередно выбирать режими счета\n\n" +
                $"✪ В правом верхнем углу можно настроить сложность примеров, указав число, в пределах которого будут генерироваться числа для примеров\n\n" +
                $"✪ При нажатии на одну из кнопок режима, активируется таймер, благодаря которому вы сможете отслеживать время на решение трех примеров\n\n" +
                $"✪ Левее от таймера можно отслеживать количество решенных примеров\n\n" +
                $"✪ В левом окне появляется пример, с действием выбранным ранее\n\n" +
                $"✪ В правом окне необходимо ввести ответ\n\n" +
                $"✪ После ввода ответа, с помощью левой кнопки мыши нажмите на кнопку ответить\n\n",$"Правила");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeForTimer < 60)
            {
                if (timeForTimer == 59)
                {
                    timeForTimer = 0;
                    minuteTimeForTimer++;
                    labelTimer.Text = $"Затрачено времени: {minuteTimeForTimer} мин. {timeForTimer.ToString()} сек.";
                }
                else
                {
                    timeForTimer++;
                }
                labelTimer.Text = $"Затрачено времени: {minuteTimeForTimer} мин. {timeForTimer.ToString()} сек.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Focus();
            string result = textBoxAnswer.Text;
            if (result == "")
            {
                MessageBox.Show("Введите результат!");
            }
            else
            {
                if (answer == result)
                {
                    count++;
                    rightAnswer++;
                    labelTry.Text = "Попытка " + count + " из " + countMax;
                }
                else
                {
                    wrongAnswer++;
                    MessageBox.Show($"Попробуй ещё раз, количество неправильных ответов: {wrongAnswer}");
                }
                think();
            }
        }


        private void button_Click(object sender, EventArgs e) // обработка нажатых кнопок скопом
        {
            mode = ((Button)sender).Tag.ToString();

            if (((Button)sender).Tag.ToString().Equals("plus"))
                plus = false;
            else
                if (((Button)sender).Tag.ToString().Equals("minus"))
                minus = false;
            else
                if (((Button)sender).Tag.ToString().Equals("mult"))
                mult = false;
            else
                if (((Button)sender).Tag.ToString().Equals("divs"))
                divs = false;
            start( ((Button)sender).Tag.ToString() );
        }


        //private void textBox_answer_KeyDown(object sender, KeyEventArgs e)
        //{
        


        //    if (e.KeyCode == Keys.Enter) // если в текстовом поле был нажат Enter, то считаем пример
        //    {
        //        lb_popytka.Text = "Попытка " + count + " из " + count_max;
        //        if (count <= count_max) progressBar.Value = count;
        //        if (textBox_answer.Text == answer)
        //        {
        //            if (count == count_max)
        //            {
        //                game_wins(); return;
        //            }
        //            textBox_answer.Text = "";
        //            think(); // к следующему примеру, если ответ верный
        //        }
        //        else
        //        {
        //            game_over();
        //        }
        //    }
        //}

        //private void bt_plus_Click(object sender, EventArgs e)
        //{

        //}

        //private void timer_Tick(object sender, EventArgs e)
        //{
        //    pBar_time.Increment(1);
        //    lb_time.Text = "время решения " + i.ToString();
        //    i++;

        //    if (pBar_time.Value == pBar_time.Maximum) // как только достигнет максимума
        //    {
        //        t.Stop(); // останавливает проверку
        //        timer.Stop(); // останавливает таймер
        //    }

        //    if (timer.Enabled == false)
        //    {
        //        MessageBox.Show("Не справился с задачей!" + t.Elapsed.ToString(), "Думай быстрее ");
        //        game_over();
        //    }



        //}
    }
}
