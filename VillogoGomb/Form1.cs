namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button b = new Button();
            //Controls.Add(b);
            //b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            //b.Top = ClientRectangle.Height / 2 - b.Width / 2;

            for (int oszlop = 0; oszlop < 20; oszlop++)
            {
                for (int sor = 0; sor < 20; sor++)
                {
                    Button button = new VillogoGomb();
                    button.Width = 20;
                    button.Height = 20;
                    button.Left = oszlop * 20;
                    button.Top = sor * 20;

                    Controls.Add((button));
                }
            }
        }
    }
}