using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_gyak2
{
    public partial class FormEditButton : Form
    {
        public VersenyzokData VersenyzokData;
        public FormEditButton()
        {
            InitializeComponent();
        }

        private void FormEditButton_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = VersenyzokData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
        }
    }
}
