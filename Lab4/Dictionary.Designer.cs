namespace Lab4
{
    partial class Dictionary
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.val = new System.Windows.Forms.TextBox();
            this.downs = new System.Windows.Forms.Button();
            this.file_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.find_count = new System.Windows.Forms.Button();
            this.len = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.find_in = new System.Windows.Forms.Button();
            this.fval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.d_print = new System.Windows.Forms.Button();
            this.highs = new System.Windows.Forms.Button();
            this.OutputClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.downs);
            this.groupBox1.Controls.Add(this.file_save);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.d_print);
            this.groupBox1.Controls.Add(this.highs);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 635);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коллекции объектов класса Airport";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.size);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.create);
            this.groupBox3.Controls.Add(this.val);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(484, 144);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создание коллекции";
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(116, 45);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(167, 25);
            this.size.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Строки";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.create.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(328, 92);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(150, 35);
            this.create.TabIndex = 5;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // val
            // 
            this.val.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.val.Location = new System.Drawing.Point(116, 98);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(167, 25);
            this.val.TabIndex = 0;
            // 
            // downs
            // 
            this.downs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.downs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downs.Location = new System.Drawing.Point(278, 83);
            this.downs.Name = "downs";
            this.downs.Size = new System.Drawing.Size(212, 35);
            this.downs.TabIndex = 14;
            this.downs.Text = "Сортировать по убыванию";
            this.downs.UseVisualStyleBackColor = false;
            this.downs.Click += new System.EventHandler(this.downs_Click);
            // 
            // file_save
            // 
            this.file_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.file_save.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_save.Location = new System.Drawing.Point(278, 42);
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(212, 35);
            this.file_save.TabIndex = 12;
            this.file_save.Text = "Сохранить в файл";
            this.file_save.UseVisualStyleBackColor = false;
            this.file_save.Click += new System.EventHandler(this.file_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.find_count);
            this.groupBox2.Controls.Add(this.len);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.find_in);
            this.groupBox2.Controls.Add(this.fval);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 144);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции со строками ";
            // 
            // find_count
            // 
            this.find_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.find_count.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_count.Location = new System.Drawing.Point(328, 93);
            this.find_count.Name = "find_count";
            this.find_count.Size = new System.Drawing.Size(150, 35);
            this.find_count.TabIndex = 18;
            this.find_count.Text = "Найти количество";
            this.find_count.UseVisualStyleBackColor = false;
            this.find_count.Click += new System.EventHandler(this.find_count_Click);
            // 
            // len
            // 
            this.len.Location = new System.Drawing.Point(116, 99);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(167, 25);
            this.len.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Длина";
            // 
            // find_in
            // 
            this.find_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.find_in.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_in.Location = new System.Drawing.Point(328, 45);
            this.find_in.Name = "find_in";
            this.find_in.Size = new System.Drawing.Size(150, 35);
            this.find_in.TabIndex = 15;
            this.find_in.Text = "Найти в коллекции";
            this.find_in.UseVisualStyleBackColor = false;
            this.find_in.Click += new System.EventHandler(this.find_in_Click);
            // 
            // fval
            // 
            this.fval.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fval.Location = new System.Drawing.Point(116, 51);
            this.fval.Name = "fval";
            this.fval.Size = new System.Drawing.Size(167, 25);
            this.fval.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Значение";
            // 
            // d_print
            // 
            this.d_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.d_print.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.d_print.Location = new System.Drawing.Point(6, 42);
            this.d_print.Name = "d_print";
            this.d_print.Size = new System.Drawing.Size(212, 35);
            this.d_print.TabIndex = 11;
            this.d_print.Text = "Вывести коллекцию";
            this.d_print.UseVisualStyleBackColor = false;
            this.d_print.Click += new System.EventHandler(this.d_print_Click);
            // 
            // highs
            // 
            this.highs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.highs.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highs.Location = new System.Drawing.Point(6, 83);
            this.highs.Name = "highs";
            this.highs.Size = new System.Drawing.Size(212, 35);
            this.highs.TabIndex = 13;
            this.highs.Text = "Сортировать по возрастанию";
            this.highs.UseVisualStyleBackColor = false;
            this.highs.Click += new System.EventHandler(this.highs_Click);
            // 
            // OutputClear
            // 
            this.OutputClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.OutputClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputClear.Location = new System.Drawing.Point(290, 19);
            this.OutputClear.Name = "OutputClear";
            this.OutputClear.Size = new System.Drawing.Size(212, 35);
            this.OutputClear.TabIndex = 1;
            this.OutputClear.Text = "Очистить окно вывода";
            this.OutputClear.UseVisualStyleBackColor = false;
            this.OutputClear.Click += new System.EventHandler(this.OutputClear_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(176)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(883, 717);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.output);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(514, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(581, 683);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Окно вывода";
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(6, 23);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(569, 655);
            this.output.TabIndex = 0;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 764);
            this.Controls.Add(this.OutputClear);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.len)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OutputClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button find_in;
        private System.Windows.Forms.TextBox fval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button highs;
        private System.Windows.Forms.Button file_save;
        private System.Windows.Forms.Button d_print;
        private System.Windows.Forms.Button downs;
        private System.Windows.Forms.Button find_count;
        private System.Windows.Forms.NumericUpDown len;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox val;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Label label4;
    }
}

