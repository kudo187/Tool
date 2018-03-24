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
    public partial class ucSendElementById : UserControl
    {
        private static ucSendElementById _instance;
        public static ucSendElementById Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSendElementById();
                return _instance;
            }
        }
        public ucSendElementById()
        {
            InitializeComponent();
        }

        private void ucSendElementById_Load(object sender, EventArgs e)
        {

        }
    }
}
