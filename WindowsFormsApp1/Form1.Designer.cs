namespace WindowsFormsApp1
{
    partial class Form1
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
            this.leftLinearRadioButton = new System.Windows.Forms.RadioButton();
            this.rightLinearRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.leftLengthRangeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rightLengthRangeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outpuTextBox = new System.Windows.Forms.TextBox();
            this.subchainTextBox = new System.Windows.Forms.TextBox();
            this.multiplicityLengthTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultButton = new System.Windows.Forms.Button();
            this.alphabetTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftLinearRadioButton
            // 
            this.leftLinearRadioButton.AutoSize = true;
            this.leftLinearRadioButton.Location = new System.Drawing.Point(6, 42);
            this.leftLinearRadioButton.Name = "leftLinearRadioButton";
            this.leftLinearRadioButton.Size = new System.Drawing.Size(99, 17);
            this.leftLinearRadioButton.TabIndex = 0;
            this.leftLinearRadioButton.Text = "Леволинейная";
            this.leftLinearRadioButton.UseVisualStyleBackColor = true;
            // 
            // rightLinearRadioButton
            // 
            this.rightLinearRadioButton.AutoSize = true;
            this.rightLinearRadioButton.Checked = true;
            this.rightLinearRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rightLinearRadioButton.Name = "rightLinearRadioButton";
            this.rightLinearRadioButton.Size = new System.Drawing.Size(105, 17);
            this.rightLinearRadioButton.TabIndex = 1;
            this.rightLinearRadioButton.TabStop = true;
            this.rightLinearRadioButton.Text = "Праволинейная";
            this.rightLinearRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "от";
            // 
            // leftLengthRangeTextBox
            // 
            this.leftLengthRangeTextBox.Location = new System.Drawing.Point(30, 19);
            this.leftLengthRangeTextBox.Name = "leftLengthRangeTextBox";
            this.leftLengthRangeTextBox.Size = new System.Drawing.Size(43, 20);
            this.leftLengthRangeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "до";
            // 
            // rightLengthRangeTextBox
            // 
            this.rightLengthRangeTextBox.Location = new System.Drawing.Point(104, 19);
            this.rightLengthRangeTextBox.Name = "rightLengthRangeTextBox";
            this.rightLengthRangeTextBox.Size = new System.Drawing.Size(48, 20);
            this.rightLengthRangeTextBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightLengthRangeTextBox);
            this.groupBox1.Controls.Add(this.leftLengthRangeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Диапазон длин";
            // 
            // outpuTextBox
            // 
            this.outpuTextBox.Location = new System.Drawing.Point(12, 168);
            this.outpuTextBox.Multiline = true;
            this.outpuTextBox.Name = "outpuTextBox";
            this.outpuTextBox.ReadOnly = true;
            this.outpuTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outpuTextBox.Size = new System.Drawing.Size(776, 270);
            this.outpuTextBox.TabIndex = 5;
            // 
            // subchainTextBox
            // 
            this.subchainTextBox.Location = new System.Drawing.Point(6, 19);
            this.subchainTextBox.Name = "subchainTextBox";
            this.subchainTextBox.Size = new System.Drawing.Size(162, 20);
            this.subchainTextBox.TabIndex = 6;
            // 
            // multiplicityLengthTextBox
            // 
            this.multiplicityLengthTextBox.Location = new System.Drawing.Point(6, 19);
            this.multiplicityLengthTextBox.Name = "multiplicityLengthTextBox";
            this.multiplicityLengthTextBox.Size = new System.Drawing.Size(101, 20);
            this.multiplicityLengthTextBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subchainTextBox);
            this.groupBox2.Location = new System.Drawing.Point(180, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 48);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Подцепочка";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.multiplicityLengthTextBox);
            this.groupBox3.Location = new System.Drawing.Point(366, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 48);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кратность длины";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(485, 103);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(204, 31);
            this.resultButton.TabIndex = 10;
            this.resultButton.Text = "Вывод";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // alphabetTextBox
            // 
            this.alphabetTextBox.Location = new System.Drawing.Point(6, 19);
            this.alphabetTextBox.Name = "alphabetTextBox";
            this.alphabetTextBox.Size = new System.Drawing.Size(168, 20);
            this.alphabetTextBox.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.alphabetTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(608, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 85);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Алфавит";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "* Перечислить через запятую. Пример: a,c,f,g";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rightLinearRadioButton);
            this.groupBox5.Controls.Add(this.leftLinearRadioButton);
            this.groupBox5.Location = new System.Drawing.Point(485, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(117, 85);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.outpuTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Регулярная грамматика";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton leftLinearRadioButton;
        private System.Windows.Forms.RadioButton rightLinearRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leftLengthRangeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rightLengthRangeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outpuTextBox;
        private System.Windows.Forms.TextBox subchainTextBox;
        private System.Windows.Forms.TextBox multiplicityLengthTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.TextBox alphabetTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

