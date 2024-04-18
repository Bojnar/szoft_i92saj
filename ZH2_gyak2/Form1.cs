using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace ZH2_gyak2
{
    public partial class Form1 : Form
    {
        BindingList<VersenyzokData> versenyzokList = new();
        public Form1()
        {
            InitializeComponent();
            versenyzokDataBindingSource.DataSource = versenyzokList;
            dataGridView1.DataSource = versenyzokDataBindingSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("versenyzok.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<VersenyzokData>();

            foreach (var item in tömb)
            {
                versenyzokList.Add(item);
            }

            sr.Close();
        }

        private void ButonEdit_Click(object sender, EventArgs e)
        {
            if (versenyzokDataBindingSource.Current == null) return;

            FormEditButton b = new FormEditButton();
            b.VersenyzokData = versenyzokDataBindingSource.Current as VersenyzokData;
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(versenyzokList);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
