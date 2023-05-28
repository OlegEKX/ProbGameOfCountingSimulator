namespace ProbGameOfCountingSimulator
{
    partial class FormShet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShet));
            this.labelThink = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelTry = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.labelDifficult = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDivs = new System.Windows.Forms.Button();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelThink
            // 
            this.labelThink.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelThink.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThink.Location = new System.Drawing.Point(12, 40);
            this.labelThink.Name = "labelThink";
            this.labelThink.Size = new System.Drawing.Size(286, 66);
            this.labelThink.TabIndex = 0;
            this.labelThink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(304, 40);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(293, 49);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // labelTry
            // 
            this.labelTry.AutoSize = true;
            this.labelTry.Location = new System.Drawing.Point(13, 18);
            this.labelTry.Name = "labelTry";
            this.labelTry.Size = new System.Drawing.Size(50, 13);
            this.labelTry.TabIndex = 12;
            this.labelTry.Text = "попытка";
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(495, 14);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(93, 20);
            this.textBoxLevel.TabIndex = 7;
            this.textBoxLevel.Text = "0";
            this.textBoxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDifficult
            // 
            this.labelDifficult.AutoSize = true;
            this.labelDifficult.Location = new System.Drawing.Point(380, 17);
            this.labelDifficult.Name = "labelDifficult";
            this.labelDifficult.Size = new System.Drawing.Size(109, 13);
            this.labelDifficult.TabIndex = 13;
            this.labelDifficult.Text = "Уровень сложности";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 148);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(142, 35);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Tag = "plus";
            this.buttonPlus.Text = "Сложение";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(161, 148);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(142, 35);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Tag = "minus";
            this.buttonMinus.Text = "Вычитание";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.Location = new System.Drawing.Point(309, 148);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(153, 35);
            this.buttonMult.TabIndex = 5;
            this.buttonMult.Tag = "mult";
            this.buttonMult.Text = "Умножение";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDivs
            // 
            this.buttonDivs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivs.Location = new System.Drawing.Point(455, 148);
            this.buttonDivs.Name = "buttonDivs";
            this.buttonDivs.Size = new System.Drawing.Size(142, 35);
            this.buttonDivs.TabIndex = 6;
            this.buttonDivs.Tag = "divs";
            this.buttonDivs.Text = "Деление";
            this.buttonDivs.UseVisualStyleBackColor = true;
            this.buttonDivs.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Location = new System.Drawing.Point(383, 95);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(106, 19);
            this.buttonAnswer.TabIndex = 15;
            this.buttonAnswer.Tag = "SolutionButton";
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // rules
            // 
            this.rules.Location = new System.Drawing.Point(16, 119);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(61, 23);
            this.rules.TabIndex = 16;
            this.rules.Text = "Правила";
            this.rules.UseVisualStyleBackColor = true;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(119, 18);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(107, 13);
            this.labelTimer.TabIndex = 17;
            this.labelTimer.Text = "Затраченное время";
            // 
            // FormShet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 208);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.buttonDivs);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.labelDifficult);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.labelTry);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelThink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(625, 247);
            this.MinimumSize = new System.Drawing.Size(625, 247);
            this.Name = "FormShet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажер устного счета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelThink;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelTry;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label labelDifficult;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDivs;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
    }
}

