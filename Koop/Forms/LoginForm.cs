using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Koop.Business.Security;

namespace Koop.Forms
{
    public partial class LoginForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private StructureMap.Container _container = Program.Container;

        public LoginForm()
        {
            InitializeComponent();
            ribbon.Visible = false;
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            int vert = emptySpaceTop.Height + emptySpaceBottom.Height;
            emptySpaceTop.Height = (vert / 2) - 50;

            int horz = emptySpaceLeft.Width + emptySpaceRight.Width;
            emptySpaceLeft.Width = horz / 2;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login(textEditUser.Text, textEditPassword.Text);
        }

        private void Login(string username, string password)
        {
            var loginService = _container.GetInstance<LoginService>();
            var identiy = loginService.Authenticate(username, password);
        }
    }
}