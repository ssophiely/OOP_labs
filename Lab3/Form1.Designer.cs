namespace Lab3
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
            this.Compare = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.rid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.revenue = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.print_field = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.field2 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.output_class = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.change = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.value1 = new System.Windows.Forms.TextBox();
            this.field1 = new System.Windows.Forms.TextBox();
            this.id1 = new System.Windows.Forms.TextBox();
            this.OutputClear = new System.Windows.Forms.Button();
            this.PrintObj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.obcount = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.method = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.arcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.Compare);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.output_class);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.OutputClear);
            this.groupBox1.Controls.Add(this.PrintObj);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 746);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функционал";
            // 
            // Compare
            // 
            this.Compare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.Compare.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compare.Location = new System.Drawing.Point(277, 65);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(212, 35);
            this.Compare.TabIndex = 10;
            this.Compare.Text = "Сравнить List и Array";
            this.Compare.UseVisualStyleBackColor = false;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox6.Controls.Add(this.Delete);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.rid);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(5, 316);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(485, 75);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Удаление объекта";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.Delete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(380, 34);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 35);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(15, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "ID объекта";
            // 
            // rid
            // 
            this.rid.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rid.Location = new System.Drawing.Point(7, 42);
            this.rid.Name = "rid";
            this.rid.Size = new System.Drawing.Size(100, 25);
            this.rid.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.revenue);
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
            this.groupBox4.Location = new System.Drawing.Point(6, 417);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 323);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Создание нового объекта";
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
            this.revenue.Location = new System.Drawing.Point(320, 247);
            this.revenue.Name = "revenue";
            this.revenue.Size = new System.Drawing.Size(144, 25);
            this.revenue.TabIndex = 18;
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
            this.passengers.Location = new System.Drawing.Point(320, 213);
            this.passengers.Name = "passengers";
            this.passengers.Size = new System.Drawing.Size(144, 25);
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
            this.people.Location = new System.Drawing.Point(320, 173);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(144, 25);
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
            this.planes.Location = new System.Drawing.Point(320, 135);
            this.planes.Name = "planes";
            this.planes.Size = new System.Drawing.Size(144, 25);
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
            this.flights.Location = new System.Drawing.Point(320, 100);
            this.flights.Name = "flights";
            this.flights.Size = new System.Drawing.Size(144, 25);
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
            this.code.Location = new System.Drawing.Point(320, 65);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(144, 25);
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
            this.create.Location = new System.Drawing.Point(379, 282);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(85, 35);
            this.create.TabIndex = 5;
            this.create.Text = "Создать";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(320, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(144, 25);
            this.name.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.print_field);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.field2);
            this.groupBox3.Controls.Add(this.id2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(5, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 75);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод поля объекта";
            // 
            // print_field
            // 
            this.print_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.print_field.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print_field.Location = new System.Drawing.Point(380, 34);
            this.print_field.Name = "print_field";
            this.print_field.Size = new System.Drawing.Size(85, 35);
            this.print_field.TabIndex = 5;
            this.print_field.Text = "Вывести";
            this.print_field.UseVisualStyleBackColor = false;
            this.print_field.Click += new System.EventHandler(this.print_field_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(156, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Поле";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID объекта";
            // 
            // field2
            // 
            this.field2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field2.Location = new System.Drawing.Point(130, 42);
            this.field2.Name = "field2";
            this.field2.Size = new System.Drawing.Size(100, 25);
            this.field2.TabIndex = 1;
            // 
            // id2
            // 
            this.id2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id2.Location = new System.Drawing.Point(7, 42);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(100, 25);
            this.id2.TabIndex = 0;
            // 
            // output_class
            // 
            this.output_class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.output_class.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_class.Location = new System.Drawing.Point(6, 65);
            this.output_class.Name = "output_class";
            this.output_class.Size = new System.Drawing.Size(212, 35);
            this.output_class.TabIndex = 4;
            this.output_class.Text = "Вывести содержимое класса";
            this.output_class.UseVisualStyleBackColor = false;
            this.output_class.Click += new System.EventHandler(this.output_class_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.change);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.value1);
            this.groupBox2.Controls.Add(this.field1);
            this.groupBox2.Controls.Add(this.id1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение значения поля объекта";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.change.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change.Location = new System.Drawing.Point(379, 31);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(85, 35);
            this.change.TabIndex = 5;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(257, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поле";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID объекта";
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.value1.Location = new System.Drawing.Point(247, 42);
            this.value1.Name = "value1";
            this.value1.Size = new System.Drawing.Size(100, 25);
            this.value1.TabIndex = 4;
            // 
            // field1
            // 
            this.field1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.field1.Location = new System.Drawing.Point(129, 42);
            this.field1.Name = "field1";
            this.field1.Size = new System.Drawing.Size(100, 25);
            this.field1.TabIndex = 1;
            // 
            // id1
            // 
            this.id1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id1.Location = new System.Drawing.Point(6, 42);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(100, 25);
            this.id1.TabIndex = 0;
            // 
            // OutputClear
            // 
            this.OutputClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.OutputClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputClear.Location = new System.Drawing.Point(278, 24);
            this.OutputClear.Name = "OutputClear";
            this.OutputClear.Size = new System.Drawing.Size(212, 35);
            this.OutputClear.TabIndex = 1;
            this.OutputClear.Text = "Очистить окно вывода";
            this.OutputClear.UseVisualStyleBackColor = false;
            this.OutputClear.Click += new System.EventHandler(this.OutputClear_Click);
            // 
            // PrintObj
            // 
            this.PrintObj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(234)))));
            this.PrintObj.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrintObj.Location = new System.Drawing.Point(5, 24);
            this.PrintObj.Name = "PrintObj";
            this.PrintObj.Size = new System.Drawing.Size(212, 35);
            this.PrintObj.TabIndex = 0;
            this.PrintObj.Text = "Вывести объекты";
            this.PrintObj.UseVisualStyleBackColor = false;
            this.PrintObj.Click += new System.EventHandler(this.PrintObj_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(155)))), ((int)(((byte)(176)))));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(883, 711);
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
            this.groupBox5.Location = new System.Drawing.Point(514, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(581, 512);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Окно вывода";
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(6, 24);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output.Size = new System.Drawing.Size(569, 480);
            this.output.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(531, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Количество объектов";
            // 
            // obcount
            // 
            this.obcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.obcount.BackColor = System.Drawing.Color.White;
            this.obcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obcount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obcount.Location = new System.Drawing.Point(883, 23);
            this.obcount.Name = "obcount";
            this.obcount.Size = new System.Drawing.Size(212, 32);
            this.obcount.TabIndex = 4;
            this.obcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.method,
            this.arcol,
            this.listcol});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(514, 602);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 99);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // method
            // 
            this.method.Text = "Метод";
            this.method.Width = 233;
            // 
            // arcol
            // 
            this.arcol.Text = "Array";
            this.arcol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.arcol.Width = 170;
            // 
            // listcol
            // 
            this.listcol.Text = "List";
            this.listcol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.listcol.Width = 170;
            // 
            // Airport1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 764);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.obcount);
            this.Controls.Add(this.label13);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button output_class;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox field1;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OutputClear;
        private System.Windows.Forms.Button PrintObj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button print_field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox field2;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Button change;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label obcount;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rid;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.ColumnHeader method;
        private System.Windows.Forms.ColumnHeader arcol;
        private System.Windows.Forms.ColumnHeader listcol;
    }
}

