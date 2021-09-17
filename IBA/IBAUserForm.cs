using IBA.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBA
{
    public partial class IBAUserForm : Form
    {
        private Form currentChildForm;

        public IBAUserForm()
        {
            InitializeComponent();
        }

        private void IBAUserForm_Load(object sender, EventArgs e)
        {
            lblHeader.Text = "Logged in as " + GlobalHandler.LoggedInUser;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA Add User";
            OpenChildForm(new AddUserForm(), sender);
        }

        private void OpenChildForm(Form childForm, object Sender)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panelChildFormHolder.Controls.Add(currentChildForm);
            panelChildFormHolder.Tag = currentChildForm;
            currentChildForm.BringToFront();
            currentChildForm.Show();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA User Settings";
            OpenChildForm(new UserSettingsForm(), sender);
        }
    }
}
