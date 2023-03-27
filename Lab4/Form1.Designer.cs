namespace Lab4
{
    partial class Airport1
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.delc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.delm = new System.Windows.Forms.NumericUpDown();
            this.Delete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.TextBox();
            this.addm = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.passengers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.people = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.planes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.file_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.find = new System.Windows.Forms.Button();
            this.airname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arr_print = new System.Windows.Forms.Button();
            this.arr_sort = new System.Windows.Forms.Button();
            this.OutputClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delm)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.file_save);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.arr_print);
            this.groupBox1.Controls.Add(this.arr_sort);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 698);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коллекции объектов класса Airport";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox6.Controls.Add(this.delc);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.delm);
            this.groupBox6.Controls.Add(this.Delete);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(6, 245);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 75);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Удаление объекта";
            // 
            // delc
            // 
            this.delc.Location = new System.Drawing.Point(177, 42);
            this.delc.Name = "delc";
            this.delc.Size = new System.Drawing.Size(117, 25);
            this.delc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(174, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Индекс в коллекции";
            // 
            // delm
            // 
            this.delm.Location = new System.Drawing.Point(14, 42);
            this.delm.Name = "delm";
            this.delm.Size = new System.Drawing.Size(117, 25);
            this.delm.TabIndex = 6;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(351, 32);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(127, 35);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Индекс в массиве";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.revenue);
            this.groupBox4.Controls.Add(this.addm);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.passengers);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.people);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.planes);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.flights);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.code);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.create);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(6, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 356);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавление нового объекта";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(15, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(228, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Доход за последний год (млрд руб)";
            // 
            // revenue
            // 
            this.revenue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.revenue.Location = new System.Drawing.Point(272, 247);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(206, 25);
            this.revenue.TabIndex = 18;
            // 
            // addm
            // 
            this.addm.Location = new System.Drawing.Point(14, 321);
            this.addm.Name = "addm";
            this.addm.Size = new System.Drawing.Size(117, 25);
            this.addm.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Индекс в массиве";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(15, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Количество пассажиров в год (млн)";
            // 
            // passengers
            // 
            this.passengers.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passengers.Location = new System.Drawing.Point(272, 213);
            this.passengers.Name = "passengers";
            this.passengers.Size = new System.Drawing.Size(206, 25);
            this.passengers.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(15, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Количество сотрудников";
            // 
            // people
            // 
            this.people.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.people.Location = new System.Drawing.Point(272, 173);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(206, 25);
            this.people.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Число самолетов";
            // 
            // planes
            // 
            this.planes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.planes.Location = new System.Drawing.Point(272, 135);
            this.planes.Name = "planes";
            this.planes.Size = new System.Drawing.Size(206, 25);
            this.planes.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Число рейсов";
            // 
            // flights
            // 
            this.flights.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flights.Location = new System.Drawing.Point(272, 100);
            this.flights.Name = "flights";
            this.flights.Size = new System.Drawing.Size(206, 25);
            this.flights.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Код ИАТА";
            // 
            // code
            // 
            this.code.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.code.Location = new System.Drawing.Point(272, 65);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(206, 25);
            this.code.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Название аэропорта";
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.create.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(351, 311);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(127, 35);
            this.create.TabIndex = 5;
            this.create.Text = "Добавить";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(272, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 25);
            this.name.TabIndex = 0;
            // 
            // file_save
            // 
            this.file_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.file_save.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.file_save.Location = new System.Drawing.Point(278, 24);
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
            this.groupBox2.Controls.Add(this.find);
            this.groupBox2.Controls.Add(this.airname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(7, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LINQ-запросы";
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.find.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(350, 22);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(127, 35);
            this.find.TabIndex = 15;
            this.find.Text = "Найти коллекции";
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // airname
            // 
            this.airname.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airname.Location = new System.Drawing.Point(145, 28);
            this.airname.Name = "airname";
            this.airname.Size = new System.Drawing.Size(144, 25);
            this.airname.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название аэропорта";
            // 
            // arr_print
            // 
            this.arr_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.arr_print.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr_print.Location = new System.Drawing.Point(6, 24);
            this.arr_print.Name = "arr_print";
            this.arr_print.Size = new System.Drawing.Size(212, 35);
            this.arr_print.TabIndex = 11;
            this.arr_print.Text = "Вывести массив коллекций";
            this.arr_print.UseVisualStyleBackColor = false;
            this.arr_print.Click += new System.EventHandler(this.arr_print_Click);
            // 
            // arr_sort
            // 
            this.arr_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.arr_sort.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arr_sort.Location = new System.Drawing.Point(6, 65);
            this.arr_sort.Name = "arr_sort";
            this.arr_sort.Size = new System.Drawing.Size(212, 35);
            this.arr_sort.TabIndex = 13;
            this.arr_sort.Text = "Отсортировать коллекции";
            this.arr_sort.UseVisualStyleBackColor = false;
            this.arr_sort.Click += new System.EventHandler(this.arr_sort_Click);
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
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(176)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(883, 707);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Завершить";
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
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(18, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(212, 35);
            this.button6.TabIndex = 5;
            this.button6.Text = "Коллекция строк";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Airport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 764);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.OutputClear);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Airport1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аэропорт";
            this.Load += new System.EventHandler(this.Airport1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delm)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OutputClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox planes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox flights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passengers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox people;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox revenue;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox airname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button arr_sort;
        private System.Windows.Forms.Button file_save;
        private System.Windows.Forms.Button arr_print;
        private System.Windows.Forms.NumericUpDown delc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delm;
        private System.Windows.Forms.NumericUpDown addm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
    }
}

