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
    }
}
