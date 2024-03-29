using System.Diagnostics;

namespace Fibonacci
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();

            for (int i = 0; i < 20; i++)
            {
                Sor �jSor = new Sor();
                �jSor.Sorsz�m = i;
                �jSor.�rt�k = Fibonacci(i);

                sorok.Add(�jSor);

                Button button = new();
                button.Top = (i * 30);
                button.Text = Fibonacci(i).ToString();

                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;


        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}