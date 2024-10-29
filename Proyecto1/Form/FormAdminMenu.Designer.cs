namespace Proyecto1
{
    partial class FormAdminMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminMenu));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSlideAdmin = new System.Windows.Forms.Panel();
            this.panelLeftUp = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnCatalogUser = new System.Windows.Forms.Button();
            this.btnCatalog = new System.Windows.Forms.Button();
            this.panelTop1 = new System.Windows.Forms.Panel();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateAdmin = new System.Windows.Forms.Label();
            this.panelTop2 = new System.Windows.Forms.Panel();
            this.lblUserAdmin = new System.Windows.Forms.Label();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.userControlRegister1 = new Proyecto1.UserControlRegister();
            this.panelLeft.SuspendLayout();
            this.panelLeftUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTop2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.panelSlideAdmin);
            this.panelLeft.Controls.Add(this.panelLeftUp);
            this.panelLeft.Controls.Add(this.btnBookings);
            this.panelLeft.Controls.Add(this.btnCatalogUser);
            this.panelLeft.Controls.Add(this.btnCatalog);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(288, 649);
            this.panelLeft.TabIndex = 0;
            // 
            // panelSlideAdmin
            // 
            this.panelSlideAdmin.BackColor = System.Drawing.Color.White;
            this.panelSlideAdmin.Location = new System.Drawing.Point(9, 257);
            this.panelSlideAdmin.Name = "panelSlideAdmin";
            this.panelSlideAdmin.Size = new System.Drawing.Size(13, 46);
            this.panelSlideAdmin.TabIndex = 3;
            // 
            // panelLeftUp
            // 
            this.panelLeftUp.Controls.Add(this.pictureBox2);
            this.panelLeftUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftUp.Location = new System.Drawing.Point(0, 0);
            this.panelLeftUp.Name = "panelLeftUp";
            this.panelLeftUp.Size = new System.Drawing.Size(288, 200);
            this.panelLeftUp.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnBookings
            // 
            this.btnBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookings.FlatAppearance.BorderSize = 0;
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.ForeColor = System.Drawing.Color.White;
            this.btnBookings.Image = ((System.Drawing.Image)(resources.GetObject("btnBookings.Image")));
            this.btnBookings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookings.Location = new System.Drawing.Point(16, 495);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(253, 77);
            this.btnBookings.TabIndex = 5;
            this.btnBookings.Text = "Reservas";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnCatalogUser
            // 
            this.btnCatalogUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatalogUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalogUser.FlatAppearance.BorderSize = 0;
            this.btnCatalogUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogUser.ForeColor = System.Drawing.Color.White;
            this.btnCatalogUser.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogUser.Image")));
            this.btnCatalogUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogUser.Location = new System.Drawing.Point(16, 372);
            this.btnCatalogUser.Name = "btnCatalogUser";
            this.btnCatalogUser.Size = new System.Drawing.Size(253, 77);
            this.btnCatalogUser.TabIndex = 4;
            this.btnCatalogUser.Text = "    Catálogo Usuarios";
            this.btnCatalogUser.UseVisualStyleBackColor = true;
            this.btnCatalogUser.Click += new System.EventHandler(this.btnCatalogUser_Click);
            // 
            // btnCatalog
            // 
            this.btnCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatalog.FlatAppearance.BorderSize = 0;
            this.btnCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalog.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalog.ForeColor = System.Drawing.Color.White;
            this.btnCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalog.Image")));
            this.btnCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalog.Location = new System.Drawing.Point(16, 239);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(253, 77);
            this.btnCatalog.TabIndex = 3;
            this.btnCatalog.Text = "Catálogo";
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // panelTop1
            // 
            this.panelTop1.Controls.Add(this.linkLabelLogOut);
            this.panelTop1.Controls.Add(this.pictureBox1);
            this.panelTop1.Controls.Add(this.lblDateAdmin);
            this.panelTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop1.Location = new System.Drawing.Point(288, 0);
            this.panelTop1.Name = "panelTop1";
            this.panelTop1.Size = new System.Drawing.Size(1312, 82);
            this.panelTop1.TabIndex = 1;
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLogOut.Location = new System.Drawing.Point(1229, 43);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(71, 19);
            this.linkLabelLogOut.TabIndex = 2;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1154, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateAdmin
            // 
            this.lblDateAdmin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateAdmin.AutoSize = true;
            this.lblDateAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDateAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAdmin.Location = new System.Drawing.Point(6, 58);
            this.lblDateAdmin.Name = "lblDateAdmin";
            this.lblDateAdmin.Size = new System.Drawing.Size(19, 19);
            this.lblDateAdmin.TabIndex = 0;
            this.lblDateAdmin.Text = "?";
            // 
            // panelTop2
            // 
            this.panelTop2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop2.Controls.Add(this.lblUserAdmin);
            this.panelTop2.Controls.Add(this.lblWelcomeAdmin);
            this.panelTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop2.Location = new System.Drawing.Point(288, 82);
            this.panelTop2.Name = "panelTop2";
            this.panelTop2.Size = new System.Drawing.Size(1312, 73);
            this.panelTop2.TabIndex = 2;
            // 
            // lblUserAdmin
            // 
            this.lblUserAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserAdmin.AutoSize = true;
            this.lblUserAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAdmin.ForeColor = System.Drawing.Color.White;
            this.lblUserAdmin.Location = new System.Drawing.Point(115, 45);
            this.lblUserAdmin.Name = "lblUserAdmin";
            this.lblUserAdmin.Size = new System.Drawing.Size(19, 19);
            this.lblUserAdmin.TabIndex = 2;
            this.lblUserAdmin.Text = "?";
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(3, 45);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(106, 19);
            this.lblWelcomeAdmin.TabIndex = 1;
            this.lblWelcomeAdmin.Text = "Bienvenido:";
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.BackColor = System.Drawing.Color.White;
            this.userControlRegister1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRegister1.Location = new System.Drawing.Point(295, 162);
            this.userControlRegister1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(1293, 487);
            this.userControlRegister1.TabIndex = 3;
            this.userControlRegister1.Visible = false;
            // 
            // FormAdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 649);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.panelTop2);
            this.Controls.Add(this.panelTop1);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdminMenu";
            this.Load += new System.EventHandler(this.FormAdminMenu_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeftUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop1.ResumeLayout(false);
            this.panelTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTop2.ResumeLayout(false);
            this.panelTop2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop1;
        private System.Windows.Forms.Panel panelTop2;
        private System.Windows.Forms.Label lblDateAdmin;
        private System.Windows.Forms.Label lblUserAdmin;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCatalogUser;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeftUp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelSlideAdmin;
        private System.Windows.Forms.Timer timer2;
        private UserControlRegister userControlRegister1;
    }
}