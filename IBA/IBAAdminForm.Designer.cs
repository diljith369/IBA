
namespace IBA
{
    partial class IBAAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBAAdminForm));
            this.panelChildFormHolder = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.logopanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bntViewAllUsers = new System.Windows.Forms.Button();
            this.panelChildFormHolder.SuspendLayout();
            this.toppanel.SuspendLayout();
            this.leftpanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChildFormHolder
            // 
            this.panelChildFormHolder.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelChildFormHolder.Controls.Add(this.toppanel);
            this.panelChildFormHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormHolder.Location = new System.Drawing.Point(129, 0);
            this.panelChildFormHolder.Name = "panelChildFormHolder";
            this.panelChildFormHolder.Size = new System.Drawing.Size(772, 523);
            this.panelChildFormHolder.TabIndex = 5;
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.lblHeader);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(772, 87);
            this.toppanel.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(154, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Logged in as Administrator ";
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.bntViewAllUsers);
            this.leftpanel.Controls.Add(this.button3);
            this.leftpanel.Controls.Add(this.btnEditUser);
            this.leftpanel.Controls.Add(this.btnAddUser);
            this.leftpanel.Controls.Add(this.logopanel);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(129, 523);
            this.leftpanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 99);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete User";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditUser.BackgroundImage")));
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Location = new System.Drawing.Point(6, 209);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(117, 99);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Location = new System.Drawing.Point(6, 104);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(117, 99);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // logopanel
            // 
            this.logopanel.Controls.Add(this.label1);
            this.logopanel.Controls.Add(this.picLogo);
            this.logopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logopanel.Location = new System.Drawing.Point(0, 0);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(129, 87);
            this.logopanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "IBA";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(3, 1);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(126, 84);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // bntViewAllUsers
            // 
            this.bntViewAllUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntViewAllUsers.BackgroundImage")));
            this.bntViewAllUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bntViewAllUsers.FlatAppearance.BorderSize = 0;
            this.bntViewAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntViewAllUsers.Location = new System.Drawing.Point(6, 420);
            this.bntViewAllUsers.Name = "bntViewAllUsers";
            this.bntViewAllUsers.Size = new System.Drawing.Size(117, 99);
            this.bntViewAllUsers.TabIndex = 5;
            this.bntViewAllUsers.Text = "View All";
            this.bntViewAllUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntViewAllUsers.UseVisualStyleBackColor = true;
            this.bntViewAllUsers.Click += new System.EventHandler(this.bntViewAllUsers_Click);
            // 
            // IBAAdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(901, 523);
            this.Controls.Add(this.panelChildFormHolder);
            this.Controls.Add(this.leftpanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IBAAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IBA Admin Form";
            this.panelChildFormHolder.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.leftpanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChildFormHolder;
        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel logopanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntViewAllUsers;
    }
}

