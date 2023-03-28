using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab4
{
    public partial class Dictionary : Form
    {
        Dictionary<int, string> d = new Dictionary<int, string>();
        public Dictionary()
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

        private void create_Click(object sender, EventArgs e)
        {
            d.Clear();
            int _size = (int)size.Value;
            if (_size <= 0)
            {
                MessageBox(0, "Неверный размер словаря", "Ошибка", 0);
                return;
            }

            string str = val.Text;
            string pattern = "[^\\s]+(\\s[^\\s]+)*$";
            if (!Regex.IsMatch(str, pattern))
            {
                MessageBox(0, "Вводите строки через пробел", "Ошибка", 0);
                return;
            }

            string[] w = str.Split(' ');
            if (w.Length != _size)
            {
                MessageBox(0, "Неверное количество строк", "Ошибка", 0);
                return;
            }

            for (int i = 0; i < w.Length; i++)
            {
                d.Add(i + 1, w[i]);
            }

            val.Text = "";
            size.Value = 0;
        }

        private void d_print_Click(object sender, EventArgs e)
        {
            string s = "Dictionary:" + "\r" + "\n"; ;
            foreach (var item in d)
            {
                s += $"key: {item.Key}  value: {item.Value}" + "\r" + "\n"; ;
            }
            s += "\r" + "\n" + "\r" + "\n";
            output.Text += s;
        }

        private async void file_save_Click(object sender, EventArgs e)
        {
            string s = "Dictionary:" + "\r" + "\n"; ;
            foreach (var item in d)
            {
                s += $"key: {item.Key}  value: {item.Value}" + "\r" + "\n";
            }
            s += "\r" + "\n" + "\r" + "\n";
            using (StreamWriter writer = new StreamWriter("dictionary.txt", true))
            {
                await writer.WriteLineAsync(s);
            }
        }

        private void find_count_Click(object sender, EventArgs e)
        {
            int size = (int)len.Value;
            if (size <= 0)
            {
                MessageBox(0, "Неверный размер строки", "Ошибка", 0);
                return;
            }

            int count = d.Where(item => item.Value.Length == size).Count();
            output.Text += $"Количество строк длиной {size} равно {count}" + "\r" + "\n" + "\r" + "\n";
        }

        private void find_in_Click(object sender, EventArgs e)
        {
            string s = fval.Text;
            var mas = d.Where(item => item.Value.Contains(s));
            output.Text += $"Строки, содержащие {s}:" + "\r" + "\n";
            foreach (var item in mas)
            {
                output.Text += item.Value + "\r" + "\n";
            }
            output.Text += "\r" + "\n";
        }

        private void highs_Click(object sender, EventArgs e)
        {
            d = d.OrderBy(item => item.Value).ToDictionary(t => t.Key, t => t.Value);
        }

        private void downs_Click(object sender, EventArgs e)
        {
            d = d.OrderByDescending(item => item.Value).ToDictionary(t => t.Key, t => t.Value);
        }
    }
}
