using System;
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

namespace Lab2
{
    public partial class Airport1 : Form
    {
        public Airport1()
        {
            InitializeComponent();
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

        private void PrintObj_Click(object sender, EventArgs e)
        {
            foreach (Airport item in Airport.GetList())
            {
                string s = item.ToString();
                output.Text += s + "\r" + "\n" + "\r" + "\n";
            }
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

        private void create_Click(object sender, EventArgs e)
        {
            foreach (Control item in create.Parent.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                    return;
                }
            }
            try
            {
                string name1 = name.Text;
                string code1 = code.Text;
                int flights1 = Int32.Parse(flights.Text);
                int planes1 = Int32.Parse(planes.Text);
                int people1 = Int32.Parse(people.Text);
                float passengers1 = float.Parse(passengers.Text);
                double revenue1 = Double.Parse(revenue.Text);

                new Airport(name1, code1, flights1, planes1, people1, passengers1, revenue1).List_push();
                obcount.Text = Airport.GetCount().ToString();

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
        }

        private void Airport1_Load(object sender, EventArgs e)
        {
            obcount.Text = Airport.GetCount().ToString();
        }

        private void print_field_Click(object sender, EventArgs e)
        {
            foreach (Control item in print_field.Parent.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                    return;
                }
            }
            string id = id2.Text;
            string field = field2.Text;

            Type type = typeof(Airport);

            try
            {
                if (Int32.Parse(id) >= Airport.GetCount())
                {
                    MessageBox(0, $"Объект с ID {id} не найден", "Неверный ID объекта", 0);
                    return;
                }
                if (type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic) == null)
                {
                    throw new UnidentifiedFieldException($"Поля {field} не существует в контескте класса Airport");
                }
            }
            catch (FormatException ex)
            {
                InvalidConvertingException ex1 = new InvalidConvertingException($"Невозможно преобразовать " +
                    $"{id} к типу ", ex.TargetSite.Name);
                MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                return;
            }
            catch (UnidentifiedFieldException ex)
            {
                MessageBox(0, ex.Message, "Неизвестное поле класса", 0);
                return;
            }

            string s = "";
            foreach (Airport item in Airport.GetList())
            {
                if (item.GetID().ToString() == id)
                {
                    var f = type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic);
                    var value = f?.GetValue(item);
                    s += $"{field}:  {value}" + "\r" + "\n" + "\r" + "\n"; ;
                    output.Text += s;
                    break;
                }
            }
            foreach (Control item in print_field.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    item.Text = "";
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            foreach (Control item in change.Parent.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                    return;
                }
            }
            string id = id1.Text;
            string field = field1.Text;
            string value = value1.Text;

            Type type = typeof(Airport);

            try
            {
                if (Int32.Parse(id) >= Airport.GetCount())
                {
                    MessageBox(0, $"Объект с ID {id} не найден", "Неверный ID объекта", 0);
                    return;
                }
                if (type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static) == null)
                {
                    throw new UnidentifiedFieldException($"Поля {field} не существует в контескте класса Airport");
                }
            }
            catch (FormatException ex)
            {
                InvalidConvertingException ex1 = new InvalidConvertingException($"Невозможно преобразовать " +
                    $"{id} к типу ", ex.TargetSite.Name);
                MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                return;
            }
            catch (UnidentifiedFieldException ex)
            {
                MessageBox(0, ex.Message, "Неизвестное поле класса", 0);
                return;
            }

            if (field == "_id")
            {
                MessageBox(0, "Невозможно изменить значение поля ID", "Изменение невозможно", 0);
                return;
            }

            if (type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static).IsStatic)
            {
                MessageBox(0, "Невозможно изменить значение статического поля класса", "Изменение невозможно", 0);
                return;
            }

            foreach (Airport item in Airport.GetList())
            {
                try
                {
                    if (item.GetID().ToString() == id)
                    {
                        var f = type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic);
                        string n = f.FieldType.Name;
                        if (n == "Int32")
                        {
                            f?.SetValue(item, Int32.Parse(value));
                        }
                        else if (n == "String")
                        {
                            f?.SetValue(item, value);
                        }
                        else if (n == "Single")
                        {
                            f?.SetValue(item, float.Parse(value));
                        }
                        else if (n == "Double")
                        {
                            f?.SetValue(item, Double.Parse(value));
                        }
                        output.Text += $"Поле {field} объекта с ID {id} успешно изменено" + "\r" + "\n" + "\r" + "\n";
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    InvalidConvertingException ex1 = new InvalidConvertingException($"Невозможно преобразовать " +
                        $"{value} к типу ", ex.TargetSite.Name);
                    MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                    return;
                }
            }
            foreach (Control item in change.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    item.Text = "";
                }
            }
        }
    }
}
