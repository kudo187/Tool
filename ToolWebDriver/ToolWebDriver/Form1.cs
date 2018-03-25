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
        public ucGoUrl.ucGoUrlDelegate getData;
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
            getData += new ucGoUrl.ucGoUrlDelegate(message);
            cboAction.SelectedIndex = 0;
        }
        public void message(string data)
        {
            MessageBox.Show(data);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
