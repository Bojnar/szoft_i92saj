using System.Xml.Linq;

namespace zh1_gyak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "OK";
            button1.Width = 100;
            button1.Height = 100;

            label1.Text = "OK";

            textBox1.Text = "OK";


            List<Elem> elemek = new List<Elem>();

            for (int i = 0; i < 10; i++)
            {
                Elem elem = new Elem();
                elem.Sorszám = i;
                elem.Érték = i + 1;
                elemek.Add(elem);
            }

            dataGridView1.DataSource = elemek;

            MessageBox.Show(elemek.ToString());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = 1.ToString();
            button1.Width = 20;
            button1.Height = 20;
        }

    }
}
