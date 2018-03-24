using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolWebDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddAction Child = new frmAddAction(cboAction.SelectedIndex.ToString());
            Child.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboAction.SelectedIndex = 0;
        }
    }
}
