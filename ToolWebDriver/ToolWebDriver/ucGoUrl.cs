using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolWebDriver
{
    public partial class ucGoUrl : UserControl
    {
        public delegate void ucGoUrlDelegate(string data);
        public event ucGoUrlDelegate sendData;
        private static ucGoUrl _instance;
        public static ucGoUrl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucGoUrl();
                return _instance;
            }
        }
        public ucGoUrl()
        {
            InitializeComponent();
        }

        private void ucGoUrl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAction_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Wrong url!!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (sendData != null)
            {
               sendData(url);
            }
            else
            {
                this.Controls.Clear();
                this.ParentForm.Close();
            }
        }
    }
}
