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
    public partial class IBAAdminForm : Form
    {
        private Form currentChildForm;
        public IBAAdminForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA Add User";
            OpenChildForm(new AddUserForm(), sender);
        }
       
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA User Settings";
            OpenChildForm(new UserSettingsForm(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA User Delete";
            OpenChildForm(new DeleteUserForm(), sender);
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

        private void bntViewAllUsers_Click(object sender, EventArgs e)
        {
            lblHeader.Text = "IBA User Delete";
            OpenChildForm(new ViewAllForm(), sender);
        }
    }
}
