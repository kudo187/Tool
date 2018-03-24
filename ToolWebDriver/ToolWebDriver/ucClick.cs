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
    public partial class ucClick : UserControl
    {
        private static ucClick _instance;
        public static ucClick Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucClick();
                return _instance;
            }
        }
        public ucClick()
        {
            InitializeComponent();
        }

        private void ucClick_Load(object sender, EventArgs e)
        {
            cboKieu.SelectedIndex = 0;
        }

    }
}
