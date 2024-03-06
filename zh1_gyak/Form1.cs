namespace zh1_gyak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzamoloGomb b = new SzamoloGomb();

                    b.Left = sor * 20;
                    b.Top = oszlop * 20;

                    Controls.Add(b);
                }
            }

        }
    }
}
