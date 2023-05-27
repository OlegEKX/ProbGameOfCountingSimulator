using System;
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
    public partial class Form_Schet : Form
    {
        //System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
        int minuteTimeForTimer = 0;
        int timeForTimer = 55;
        int rightAnswer = 0;
        int wrongAnswer = 0;
        int count = 0; //количество попыток
        int minNumber = 1;
        int i = 0; //для отображения секунд на форме
        int maxNumber = 10; //уровень сложности задачи 10 - двухзначные числа, 100 - трехзначные числа
        Random rnd = new Random();
        string answer;
        int count_max = 3; // для прогресс бара максимальное количество попыток
        string mode = ""; // режим, что будет выполняться: сложение, вычитание, деление
        bool plus = true,
            minus = true,
            mult = true,
            divs = true;

        public Form_Schet()
        {
            InitializeComponent();
            tBox_level.Text = maxNumber.ToString();
            //timer.Interval = 1000; // 1 секунда
            
        }

        
        
        private void start(string my_mode)
        {
            
            //pBar_time.Visible = true;
            //pBar_time.Value = 0; // 30 секунд максимум
            lb_popytka.Visible = true;
            count = 0;
            rules.Visible = false;


            mode = my_mode;
            //убираем все кнопки на время игры
            bt_plus.Visible = false;
            bt_minus.Visible = false;
            bt_mult.Visible = false;
            bt_divs.Visible = false;

            //progressBar.Visible = true;
            textBox_answer.Enabled = true;
            label_think.Enabled = true;
            textBox_answer.Focus();
            //progressBar.Minimum = 0;
            //progressBar.Maximum = count_max;
            //progressBar.Value = 0;
            textBox_answer.Text = "";
            label_think.Text = "";
            lb_popytka.Text = "Попытка " + count + " из " + count_max;

            // элементы try и catch - исключения, при выполнении этого блока, сначала выполняется действие в try, если исключение появится, то программа перейдет к действиям находящимся в catch
            try
            {
                maxNumber = Convert.ToInt16(tBox_level.Text);
            }
            catch
            {
                maxNumber = 10;
                tBox_level.Text = maxNumber.ToString();
            }
            think();
        }

        private void think()
        {
            timer.Enabled = true;
            textBox_answer.Text = "";
            textBox_answer.Focus();
            if (rightAnswer < count_max)
            {
                int a, b;
                i = 0;
                a = rnd.Next(minNumber, maxNumber + 1);
                b = rnd.Next(minNumber, maxNumber + 1);

                //на время запускаем счетчик

                //timer.Start();
                //t.Start();
                //pBar_time.Value = 0;



                if (mode == "plus")
                {
                    label_think.Text = a.ToString() + " + " + b.ToString() + " = ";
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
                    label_think.Text = a.ToString() + " - " + b.ToString() + " = "; // - = ALT+0150 на цифровой
                    answer = (a - b).ToString();
                }

                if (mode == "mult")
                {
                    label_think.Text = a.ToString() + " * " + b.ToString() + " = ";
                    answer = (a * b).ToString();
                }
                if (mode == "divs")
                {
                    // можно так выпендриться, чтобы не использовать целочисленное деление
                    label_think.Text = (a * b).ToString() + " ; " + b.ToString() + " = ";
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
        private void game_over()
        {
            textBox_answer.Text = "Нет = " + answer;
            done();
        }

        private void done()
        {
            lb_popytka.Visible = false;
            label_think.Enabled = false;
            textBox_answer.Enabled = false;
            //pBar_time.Visible = false;
            //progressBar.Visible = false;
            bt_plus.Focus(); // передаем фокус на кнопку игры
            count = 0;
            rightAnswer = 0;

            // возвращаем кнопки на панель согласно условию
            // если какое-то задание выполнено, кнопка становится неактивной
            // убираем все кнопки на время игры
            bt_plus.Visible = true;
            bt_minus.Visible = true;
            bt_mult.Visible = true;
            bt_divs.Visible = true;
            button1.Visible = true;

            bt_plus.Enabled = plus;
            bt_minus.Enabled = minus;
            bt_mult.Enabled = mult;
            bt_divs.Enabled = divs;

            if (!plus && !minus && !mult && !divs)
            {
                MessageBox.Show("Ты прошел все уровни!", "Твоя победа и полное поражение компьютера");
                button1.Visible = false;
                
            }
                
            //t.Stop();

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
            //ДОБАВИТЬ МИНУТНОЕ ПРЕДСТАВЛЕНИЕ путем добавления условия, где проверяется количество секунд таймера для секунд
            //условие else будет обнулять секунды и добавлять одну минуту в минутный счетчик
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
                //timeForTimer++;
                labelTimer.Text = $"Затрачено времени: {minuteTimeForTimer} мин. {timeForTimer.ToString()} сек.";
            }
            

            //timeForTimer++;
            //labelTimer.Text = $"Затрачено времени: {timeForTimer.ToString()} сек.";
        }

        

        private void game_wins()
        {
            int x = rnd.Next(1, 4); // случайное сообщение, всплывающее при прохождении уровня
            if (x == 1) MessageBox.Show("Считаешь верно!!!", "А ты молодец. Математик!");
            if (x == 2) MessageBox.Show("Верно!!!", "А ты молодец. Математик!");
            if (x == 3) MessageBox.Show("Ответ принят!!!", "А ты молодец. Математик!");
            if (x == 4) MessageBox.Show("У тебя все получается!!!", "А ты молодец. Математик!");

            // если все посчитали верно кнопка становится недоступна
            if (mode == "plus") plus = false;
            if (mode == "minus") minus = false;
            if (mode == "mult") mult = false;
            if (mode == "divs") divs = false;
            if (!plus && !minus && !mult && !divs)
            {
                MessageBox.Show("Ты прошел все уровни!", "Твоя победа и полное поражение компьютера");
            }
            done();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_answer.Focus();
            string result = textBox_answer.Text;
            if (result == "")
            {

                MessageBox.Show("Введите результат!");
            }
            else
            {
                if (answer == result)
                {
                    count++;
                    //MessageBox.Show("Верно");
                    rightAnswer++;
                    lb_popytka.Text = "Попытка " + count + " из " + count_max;
                }
                else
                {
                    wrongAnswer++;
                    MessageBox.Show($"Попробуй ещё раз, количество неправильных ответов: {wrongAnswer}");
                    //MessageBox.Show(" НЕ Верно");
                }
                //count++; уже не нужно
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
