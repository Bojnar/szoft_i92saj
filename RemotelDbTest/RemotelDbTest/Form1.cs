using RemotelDbTest.Models;

namespace RemotelDbTest
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public Student student;
        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //Student x = new Student();
            //x.Student.DataSource = studentBindingSource.Current as Student;
            //x.Show();
        }
    }
}