using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

namespace Lab6
{
    public partial class Lib : Form
    {
        public Lib()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
            String caption, uint type);

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            output.Clear();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || rate.Text == "")
            {
                MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                return;
            }

            try
            {
                string _name = name.Text;
                int _books = (int)books.Value;
                double _rating = Double.Parse(rate.Text);

                if (rbchild.Checked)
                {
                    Library.Add(new Library(_name, _books, _rating, "Kids"));
                }
                else if (rbpublic.Checked)
                {
                    Library.Add(new Library(_name, _books, _rating, "Public"));
                }
                else
                {
                    Library.Add(new Library(_name, _books, _rating, "University"));
                }
            }
            catch (FormatException ex)
            {
                InvalidConvertingException ex1 = new InvalidConvertingException("Невозможно преобразовать " +
                    "введенные данные к типу ", ex.TargetSite.Name);
                MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                return;
            }

            foreach (Control item in create.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    item.Text = "";
                }
            }
            books.Value = 0;
        }

        private void print_Click(object sender, EventArgs e)
        {
            foreach (Library item in Library.GetList())
            {
                output.Text += item.ToString() + "\r" + "\n" + "\r" + "\n";
            }
        }
    }
}
