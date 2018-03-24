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
    public partial class frmAddAction : Form
    {
        private string _message;
        public frmAddAction()
        {
            InitializeComponent();
        }

        public frmAddAction(string Message): this()
        {
            _message = Message;
            Message = _message;
        }

        private void frmAddAction_Load(object sender, EventArgs e)
        {
            checkUserControl();
        }

        public void checkUserControl() 
        {
            switch (_message)
            {
                case "0":
                    if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    {
                        panel1.Controls.Add(ucGoUrl.Instance);
                        ucGoUrl.Instance.Dock = DockStyle.Fill;
                        ucGoUrl.Instance.BringToFront();
                    }
                    else
                        ucGoUrl.Instance.BringToFront();
                    break;
                case "1":
                    //if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    //{
                    //    panel1.Controls.Add(ucGoUrl.Instance);
                    //    ucGoUrl.Instance.Dock = DockStyle.Fill;
                    //    ucGoUrl.Instance.BringToFront();
                    //}
                    //else
                    //    ucGoUrl.Instance.BringToFront();
                    //break;
                    MessageBox.Show("Chưa có userControl.");
                    break;
                case "2":
                    if (!panel1.Controls.Contains(ucClick.Instance))
                    {
                        panel1.Controls.Add(ucClick.Instance);
                        ucClick.Instance.Dock = DockStyle.Fill;
                        ucClick.Instance.BringToFront();
                    }
                    else
                        ucClick.Instance.BringToFront();
                    break;
                case "3":
                    if (!panel1.Controls.Contains(ucSendElementById.Instance))
                    {
                        panel1.Controls.Add(ucSendElementById.Instance);
                        ucSendElementById.Instance.Dock = DockStyle.Fill;
                        ucSendElementById.Instance.BringToFront();
                    }
                    else
                        ucSendElementById.Instance.BringToFront();
                    break;
                case "4":
                    //if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    //{
                    //    panel1.Controls.Add(ucGoUrl.Instance);
                    //    ucGoUrl.Instance.Dock = DockStyle.Fill;
                    //    ucGoUrl.Instance.BringToFront();
                    //}
                    //else
                    //    ucGoUrl.Instance.BringToFront();
                    //break;
                    MessageBox.Show("Chưa có userControl.");
                    break;
                case "5":
                    //if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    //{
                    //    panel1.Controls.Add(ucGoUrl.Instance);
                    //    ucGoUrl.Instance.Dock = DockStyle.Fill;
                    //    ucGoUrl.Instance.BringToFront();
                    //}
                    //else
                    //    ucGoUrl.Instance.BringToFront();
                    //break;
                    MessageBox.Show("Chưa có userControl.");
                    break;
                case "6":
                    //if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    //{
                    //    panel1.Controls.Add(ucGoUrl.Instance);
                    //    ucGoUrl.Instance.Dock = DockStyle.Fill;
                    //    ucGoUrl.Instance.BringToFront();
                    //}
                    //else
                    //    ucGoUrl.Instance.BringToFront();
                    //break;
                    MessageBox.Show("Chưa có userControl.");
                    break;
                default:
                    //if (!panel1.Controls.Contains(ucGoUrl.Instance))
                    //{
                    //    panel1.Controls.Add(ucGoUrl.Instance);
                    //    ucGoUrl.Instance.Dock = DockStyle.Fill;
                    //    ucGoUrl.Instance.BringToFront();
                    //}
                    //else
                    //    ucGoUrl.Instance.BringToFront();
                    //break;
                    MessageBox.Show("Chưa có userControl.");
                    break;
            }
        }
    }
}
