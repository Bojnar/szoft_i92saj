namespace SzamoloGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int oszlop = 0; oszlop < 10; oszlop++)
            {
                for (int sor = 0; sor < 10; sor++)
                {
                    Button b = new SzamoloGomb();
                    b.Left = oszlop * 40;
                    b.Top = sor * 40;
                    b.Width = 40;
                    b.Height = 40;

                    Controls.Add(b);
                }
            }
        }
    }
}