namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OutputElems = new TextBox();
            groupBox1 = new GroupBox();
            max = new NumericUpDown();
            min = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            count = new NumericUpDown();
            label1 = new Label();
            Create = new Button();
            Print = new Button();
            Time = new Button();
            Sum = new Button();
            button5 = new Button();
            Close = new Button();
            timeLabel = new Label();
            OutputSum = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)max).BeginInit();
            ((System.ComponentModel.ISupportInitialize)min).BeginInit();
            ((System.ComponentModel.ISupportInitialize)count).BeginInit();
            SuspendLayout();
            // 
            // OutputElems
            // 
            OutputElems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputElems.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OutputElems.Location = new Point(431, 59);
            OutputElems.Multiline = true;
            OutputElems.Name = "OutputElems";
            OutputElems.ScrollBars = ScrollBars.Both;
            OutputElems.Size = new Size(551, 301);
            OutputElems.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(max);
            groupBox1.Controls.Add(min);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(count);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Create);
            groupBox1.Controls.Add(Print);
            groupBox1.Controls.Add(Time);
            groupBox1.Controls.Add(Sum);
            groupBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 391);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Интерфейс пользователя";
            // 
            // max
            // 
            max.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            max.Location = new Point(288, 73);
            max.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            max.Name = "max";
            max.Size = new Size(92, 27);
            max.TabIndex = 9;
            max.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // min
            // 
            min.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            min.Location = new Point(68, 73);
            min.Name = "min";
            min.Size = new Size(92, 27);
            min.TabIndex = 8;
            min.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 75);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 7;
            label3.Text = "Макс:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 75);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 6;
            label2.Text = "Мин:";
            // 
            // count
            // 
            count.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            count.Location = new Point(288, 33);
            count.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            count.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            count.Name = "count";
            count.Size = new Size(92, 27);
            count.TabIndex = 5;
            count.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(228, 19);
            label1.TabIndex = 4;
            label1.Text = "Количество значений в списке:";
            // 
            // Create
            // 
            Create.BackColor = Color.MintCream;
            Create.Location = new Point(217, 113);
            Create.Name = "Create";
            Create.Size = new Size(163, 28);
            Create.TabIndex = 3;
            Create.Text = "Создать";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // Print
            // 
            Print.BackColor = Color.MistyRose;
            Print.Location = new Point(7, 212);
            Print.Name = "Print";
            Print.Size = new Size(264, 28);
            Print.TabIndex = 2;
            Print.Text = "Вывести элементы";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // Time
            // 
            Time.BackColor = Color.MistyRose;
            Time.Location = new Point(7, 296);
            Time.Name = "Time";
            Time.Size = new Size(264, 28);
            Time.TabIndex = 1;
            Time.Text = "Включить системное время";
            Time.UseVisualStyleBackColor = false;
            Time.Click += Time_Click;
            // 
            // Sum
            // 
            Sum.BackColor = Color.MistyRose;
            Sum.Location = new Point(6, 255);
            Sum.Name = "Sum";
            Sum.Size = new Size(264, 28);
            Sum.TabIndex = 0;
            Sum.Text = "Найти сумму элементов";
            Sum.UseVisualStyleBackColor = false;
            Sum.Click += Sum_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(519, 403);
            button5.Name = "button5";
            button5.Size = new Size(228, 28);
            button5.TabIndex = 10;
            button5.Text = "Очистить вывод";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Close.BackColor = Color.Black;
            Close.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = Color.White;
            Close.Location = new Point(754, 403);
            Close.Name = "Close";
            Close.Size = new Size(228, 28);
            Close.TabIndex = 11;
            Close.Text = "Закрыть";
            Close.UseVisualStyleBackColor = false;
            Close.Click += Close_Click;
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Location = new Point(431, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(551, 32);
            timeLabel.TabIndex = 12;
            timeLabel.Text = "label4";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutputSum
            // 
            OutputSum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OutputSum.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            OutputSum.Location = new Point(431, 366);
            OutputSum.Name = "OutputSum";
            OutputSum.ScrollBars = ScrollBars.Both;
            OutputSum.Size = new Size(551, 27);
            OutputSum.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(996, 442);
            Controls.Add(OutputSum);
            Controls.Add(timeLabel);
            Controls.Add(Close);
            Controls.Add(button5);
            Controls.Add(groupBox1);
            Controls.Add(OutputElems);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Асинхронное программирование";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)max).EndInit();
            ((System.ComponentModel.ISupportInitialize)min).EndInit();
            ((System.ComponentModel.ISupportInitialize)count).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OutputElems;
        private GroupBox groupBox1;
        private NumericUpDown max;
        private NumericUpDown min;
        private Label label3;
        private Label label2;
        private NumericUpDown count;
        private Label label1;
        private Button Create;
        private Button Print;
        private Button Sum;
        private Button button5;
        private Button Close;
        private Label timeLabel;
        private Button Time;
        private TextBox OutputSum;
    }
}