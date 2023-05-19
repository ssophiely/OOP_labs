namespace Lab8
{
    public partial class Form1 : Form
    {
        private List<int> _list;
        private CancellationTokenSource _cts;
        private CancellationToken _token;
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            int _count = (int)count.Value;
            int _min = (int)min.Value;
            int _max = (int)max.Value;

            _list = new List<int>();
            Random _rnd = new Random();
            for (int i = 0; i < _count; i++)
            {
                _list.Add(_rnd.Next(_min, _max));
            }
        }

        async private void Print_Click(object sender, EventArgs e)
        {
            OutputElems.Clear();
            for (int i = 0; i < _list.Count; i++)
            {
                OutputElems.Text += await Task.Run(() =>
                {
                    return _list[i].ToString();
                }) + "\t";
            }
        }

        async public void Sum_Click(object sender, EventArgs e)
        {
            OutputSum.Text = "";
            int _sum = await SumListAsync();
            OutputSum.Text += $"Сумма элементов равна {_sum}" + '\r' + '\n';
        }

        async public Task<int> SumListAsync()
        {
            return await Task.Run(() =>
            {
                int _sum = 0;
                for (int i = 0; i < _list.Count; i++)
                {
                    _sum += _list[i];
                }
                return _sum;
            });
        }

        public void Time_Click(object sender, EventArgs e)
        {
            if (Time.Text == "Включить системное время")
            {
                _cts = new CancellationTokenSource();
                _token = _cts.Token;
                GetTime();
                Time.Text = "Остановить системное время";
            }
            else
            {
                _cts.Cancel();
                Time.Text = "Включить системное время";
            }
        }

        public async Task GetTime()
        {
            while (true)
            {
                if (_token.IsCancellationRequested)
                {
                    break;
                }
                string _time = DateTime.Now.ToLongTimeString();
                timeLabel.Text = _time;
                await Task.Delay(1000);
            }
        }
    }
}