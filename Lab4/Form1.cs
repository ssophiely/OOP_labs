﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace Lab4
{
    public partial class Airport1 : Form
    {
        private CollectionType<Airport>[] array;
        public Airport1()
        {
            InitializeComponent();

            CollectionType<Airport> collection1 = new CollectionType<Airport>();
            CollectionType<Airport> collection2 = new CollectionType<Airport>();
            CollectionType<Airport> collection3 = new CollectionType<Airport>();

            Airport dmd = new Airport("Домодедово", "DME", 5000, 500, 1000, 30.6f, 10.3);
            dmd.List_push();
            Airport shmt = new Airport("Шереметьево", "SVO", 5000, 500, 1000, 24.0f, 12.2);
            shmt.List_push();
            Airport dubai = new Airport("Дубай", "DXB", 30000, 800, 6000, 89.7f, 78.8);
            dubai.List_push();
            Airport la = new Airport("Лос-Анджелес", "LAX", 23000, 600, 4000, 24.7f, 50.8);
            la.List_push();
            Airport atl = new Airport("Атланта", "ATL", 12000, 400, 1000, 40.0f, 15.8);
            atl.List_push();

            collection1.Add(dmd);
            collection1.Add(shmt);
            collection2.Add(la);
            collection2.Add(atl);
            collection2.Add(dubai);
            collection3.Add(dubai);

            array = new[] { collection1, collection2, collection3 };
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
                    String caption, uint type);

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OutputClear_Click(object sender, EventArgs e)
        {
            output.Clear();
        }

        private void output_class_Click(object sender, EventArgs e)
        {
            Type type = typeof(Airport);
            string s = "Поля:" + "\r" + "\n";

            foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Static))
            {
                string modificator = "";
                if (field.IsPublic)
                    modificator += "public  ";
                else if (field.IsPrivate)
                    modificator += "private  ";
                if (field.IsStatic) modificator += "static  ";

                s += $"{modificator}{field.FieldType.Name}   {field.Name}" + "\r" + "\n"; ;
            }

            s += "\r" + "\n" + "Методы:" + "\r" + "\n";

            foreach (MethodInfo method in type.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic) modificator += "static  ";
                if (method.IsVirtual) modificator += "virtual  ";
                s += $"{modificator}{method.ReturnType.Name}   {method.Name} ()" + "\r" + "\n";
            }
            output.Text += s + "\r" + "\n";
        }

        //// Создать объект
        //private void create_Click(object sender, EventArgs e)
        //{
        //    foreach (Control item in create.Parent.Controls)
        //    {
        //        if (item.Text == "")
        //        {
        //            MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
        //            return;
        //        }
        //    }
        //    try
        //    {
        //        string name1 = name.Text;
        //        string code1 = code.Text;
        //        int flights1 = Int32.Parse(flights.Text);
        //        int planes1 = Int32.Parse(planes.Text);
        //        int people1 = Int32.Parse(people.Text);
        //        float passengers1 = float.Parse(passengers.Text);
        //        double revenue1 = Double.Parse(revenue.Text);

        //        Airport a = new Airport(name1, code1, flights1, planes1, people1, passengers1, revenue1);
        //        a.List_push();
        //        list1.Add(a);
        //        obcount.Text = Airport.GetCount().ToString();

        //    }
        //    catch (FormatException ex)
        //    {
        //        InvalidConvertingException ex1 = new InvalidConvertingException("Невозможно преобразовать " +
        //            "введенные данные к типу ", ex.TargetSite.Name);
        //        MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
        //        return;
        //    }
        //    foreach (Control item in create.Parent.Controls)
        //    {
        //        if (item.GetType().Name == "TextBox")
        //        {
        //            item.Text = "";
        //        }
        //    }
        //}

        private void Airport1_Load(object sender, EventArgs e)
        {
        }

        //private void Delete_Click(object sender, EventArgs e)
        //{
        //    if (rid.Text == "")
        //    {
        //        MessageBox(0, "Заполните поле ID объекта", "Найдено пустое поле", 0);
        //    }
        //    string id = rid.Text;

        //    try
        //    {
        //        list1.Remove((Int32.Parse(id)));
        //    }
        //    catch (FormatException ex)
        //    {
        //        InvalidConvertingException ex1 = new InvalidConvertingException($"Невозможно преобразовать " +
        //            $"{id} к типу ", ex.TargetSite.Name);
        //        MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
        //        return;
        //    }
        //    rid.Text = "";
        //}

        private void arr_print_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                string s = $"Array[{i}]:" + "\r" + "\n";
                foreach (Airport item in array[i])
                {
                    s += item.ToString() + "\r" + "\n" + "\r" + "\n";
                }
                output.Text += s + "\r" + "\n" + "\r" + "\n";
            }
        }

        private void arr_sort_Click(object sender, EventArgs e)
        {
            foreach (CollectionType<Airport> item in array)
            {
                item._list.Sort();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int arr_ind = (int)delm.Value;
            int col_ind = (int)delc.Value;

            if (arr_ind >= array.Length)
            {
                MessageBox(0, "Индекс за пределами массива", "Ошибка", 0);
                return;
            }
            if (col_ind >= array[arr_ind]._size)
            {
                MessageBox(0, "Индекс за пределами коллекции", "Ошибка", 0);
                return;
            }

            array[arr_ind].Remove(col_ind);
        }

        private async void file_save_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s += $"Array[{i}]:" + "\r" + "\n";
                foreach (Airport item in array[i])
                {
                    s += item.ToString() + "\r" + "\n" + "\r" + "\n";
                }
                s += "\r" + "\n" + "\r" + "\n";
            }
            using (StreamWriter writer = new StreamWriter("airports.txt", false))
            {
                await writer.WriteLineAsync(s);
            }
        }

        private void create_Click(object sender, EventArgs e)
        {

        }
    }
}
