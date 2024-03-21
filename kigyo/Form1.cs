namespace kigyo
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irany_x = 1;
        int irany_y = 0;

        int lepesszam;

        int hossz = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;

            //Fejnövesztés
            fej_x += irany_x * KígyóElem.Méret;
            fej_y += irany_y * KígyóElem.Méret;

            foreach (KígyóElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

            //Farokvágás
            if (Controls.Count > hossz)
            {
                //KígyóElem levágandó = kígyó[0];
                Controls.RemoveAt(0);
            }

            KígyóElem ke = new();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irany_y = -1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                irany_y = 0;
                irany_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                irany_y = 0;
                irany_x = 1;
            }

        }
    }
}