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
using Koop.Forms;

namespace Koop
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            ribbonPageMain.Visible = false;
            OpenForm(new LoginForm(), "Login");
        }


        private void OpenForm(Form f, string name)
        {
            documentManager.BeginUpdate();
            f.Name = name;
            documentManager.View.AddDocument(f);
            documentManager.EndUpdate();
        }
    }
}