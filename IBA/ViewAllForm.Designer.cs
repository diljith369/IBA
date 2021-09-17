
namespace IBA
{
    partial class ViewAllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllForm));
            this.leftpanel = new System.Windows.Forms.Panel();
            this.gvwViewAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvwViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftpanel.Location = new System.Drawing.Point(661, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(66, 447);
            this.leftpanel.TabIndex = 0;
            // 
            // gvwViewAll
            // 
            this.gvwViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.gvwViewAll.Location = new System.Drawing.Point(0, 0);
            this.gvwViewAll.Name = "gvwViewAll";
            this.gvwViewAll.Size = new System.Drawing.Size(661, 390);
            this.gvwViewAll.TabIndex = 1;
            // 
            // ViewAllForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(727, 447);
            this.Controls.Add(this.gvwViewAll);
            this.Controls.Add(this.leftpanel);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllForm";
            this.Text = "ViewAllForm";
            this.Load += new System.EventHandler(this.ViewAllForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.DataGridView gvwViewAll;
    }
}