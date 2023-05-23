namespace ProbGameOfCountingSimulator
{
    partial class Form_Schet
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Schet));
            this.label_think = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.pBar_time = new System.Windows.Forms.ProgressBar();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_popytka = new System.Windows.Forms.Label();
            this.tBox_level = new System.Windows.Forms.TextBox();
            this.label_slozhost = new System.Windows.Forms.Label();
            this.bt_plus = new System.Windows.Forms.Button();
            this.bt_minus = new System.Windows.Forms.Button();
            this.bt_mult = new System.Windows.Forms.Button();
            this.bt_divs = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_think
            // 
            this.label_think.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_think.Location = new System.Drawing.Point(12, 40);
            this.label_think.Name = "label_think";
            this.label_think.Size = new System.Drawing.Size(286, 66);
            this.label_think.TabIndex = 0;
            this.label_think.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_answer.Location = new System.Drawing.Point(304, 40);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(293, 49);
            this.textBox_answer.TabIndex = 1;
            // 
            // pBar_time
            // 
            this.pBar_time.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pBar_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pBar_time.Location = new System.Drawing.Point(12, 113);
            this.pBar_time.Maximum = 30;
            this.pBar_time.Name = "pBar_time";
            this.pBar_time.Size = new System.Drawing.Size(584, 23);
            this.pBar_time.TabIndex = 9;
            this.pBar_time.Tag = "progressBar";
            this.pBar_time.Visible = false;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(285, 113);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(30, 13);
            this.lb_time.TabIndex = 11;
            this.lb_time.Text = "Time";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_popytka
            // 
            this.lb_popytka.Location = new System.Drawing.Point(13, 18);
            this.lb_popytka.Name = "lb_popytka";
            this.lb_popytka.Size = new System.Drawing.Size(55, 13);
            this.lb_popytka.TabIndex = 12;
            this.lb_popytka.Text = "попытка";
            // 
            // tBox_level
            // 
            this.tBox_level.Location = new System.Drawing.Point(495, 14);
            this.tBox_level.Name = "tBox_level";
            this.tBox_level.Size = new System.Drawing.Size(93, 20);
            this.tBox_level.TabIndex = 7;
            this.tBox_level.Text = "0";
            this.tBox_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_slozhost
            // 
            this.label_slozhost.AutoSize = true;
            this.label_slozhost.Location = new System.Drawing.Point(380, 17);
            this.label_slozhost.Name = "label_slozhost";
            this.label_slozhost.Size = new System.Drawing.Size(109, 13);
            this.label_slozhost.TabIndex = 13;
            this.label_slozhost.Text = "Уровень сложности";
            // 
            // bt_plus
            // 
            this.bt_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_plus.Location = new System.Drawing.Point(13, 148);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(142, 35);
            this.bt_plus.TabIndex = 2;
            this.bt_plus.Tag = "plus";
            this.bt_plus.Text = "Сложение";
            this.bt_plus.UseVisualStyleBackColor = true;
            this.bt_plus.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_minus
            // 
            this.bt_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_minus.Location = new System.Drawing.Point(161, 148);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(142, 35);
            this.bt_minus.TabIndex = 4;
            this.bt_minus.Tag = "minus";
            this.bt_minus.Text = "Вычитание";
            this.bt_minus.UseVisualStyleBackColor = true;
            this.bt_minus.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_mult
            // 
            this.bt_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_mult.Location = new System.Drawing.Point(309, 148);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(153, 35);
            this.bt_mult.TabIndex = 5;
            this.bt_mult.Tag = "mult";
            this.bt_mult.Text = "Умножение";
            this.bt_mult.UseVisualStyleBackColor = true;
            this.bt_mult.Click += new System.EventHandler(this.button_Click);
            // 
            // bt_divs
            // 
            this.bt_divs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_divs.Location = new System.Drawing.Point(455, 148);
            this.bt_divs.Name = "bt_divs";
            this.bt_divs.Size = new System.Drawing.Size(142, 35);
            this.bt_divs.TabIndex = 6;
            this.bt_divs.Tag = "divs";
            this.bt_divs.Text = "Деление";
            this.bt_divs.UseVisualStyleBackColor = true;
            this.bt_divs.Click += new System.EventHandler(this.button_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(12, 189);
            this.progressBar.Maximum = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(583, 10);
            this.progressBar.TabIndex = 14;
            this.progressBar.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Schet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bt_divs);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.bt_minus);
            this.Controls.Add(this.bt_plus);
            this.Controls.Add(this.label_slozhost);
            this.Controls.Add(this.tBox_level);
            this.Controls.Add(this.lb_popytka);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.pBar_time);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label_think);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Schet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажер устного счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_think;
        private System.Windows.Forms.TextBox textBox_answer;
        private System.Windows.Forms.ProgressBar pBar_time;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_popytka;
        private System.Windows.Forms.TextBox tBox_level;
        private System.Windows.Forms.Label label_slozhost;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_mult;
        private System.Windows.Forms.Button bt_divs;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button1;
    }
}

