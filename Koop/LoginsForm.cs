using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Koop
{
    public partial class LoginsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private StructureMap.Container _container = Program.Container;
        public LoginsForm()
        {
            InitializeComponent();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            int vert = emptySpaceTop.Height + emptySpaceBottom.Height;
            emptySpaceTop.Height = (vert / 2) - 50;

            int horz = emptySpaceLeft.Width + emptySpaceRight.Width;
            emptySpaceLeft.Width = horz / 2;
        }

        private void textEditPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
            }
        }

        private void LoginUser(string user, string password)
        {

        }
    }
}