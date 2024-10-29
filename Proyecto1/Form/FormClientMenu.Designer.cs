namespace Proyecto1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnInfoUser = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.panelLeftUp = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUpFondo = new System.Windows.Forms.Panel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelUp2 = new System.Windows.Forms.Panel();
            this.linkLblLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlAbout1 = new Proyecto1.UserControlAbout();
            this.userControlUpDate1 = new Proyecto1.UserControlUpDate();
            this.panelLeft.SuspendLayout();
            this.panelLeftUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUpFondo.SuspendLayout();
            this.panelUp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLeft.Controls.Add(this.panelSlide);
            this.panelLeft.Controls.Add(this.btnInfoUser);
            this.panelLeft.Controls.Add(this.btnReservation);
            this.panelLeft.Controls.Add(this.btnService);
            this.panelLeft.Controls.Add(this.btnAboutUs);
            this.panelLeft.Controls.Add(this.panelLeftUp);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(288, 649);
            this.panelLeft.TabIndex = 1;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(12, 232);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 37);
            this.panelSlide.TabIndex = 3;
            // 
            // btnInfoUser
            // 
            this.btnInfoUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoUser.FlatAppearance.BorderSize = 0;
            this.btnInfoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoUser.ForeColor = System.Drawing.Color.White;
            this.btnInfoUser.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoUser.Image")));
            this.btnInfoUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoUser.Location = new System.Drawing.Point(22, 582);
            this.btnInfoUser.Name = "btnInfoUser";
            this.btnInfoUser.Size = new System.Drawing.Size(235, 26);
            this.btnInfoUser.TabIndex = 6;
            this.btnInfoUser.Text = "Perfil";
            this.btnInfoUser.UseVisualStyleBackColor = true;
            this.btnInfoUser.Click += new System.EventHandler(this.btnInfoUser_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(22, 466);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(263, 32);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "    Reservaciones:";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(22, 347);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(235, 29);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "    Servicios";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(22, 239);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(235, 30);
            this.btnAboutUs.TabIndex = 3;
            this.btnAboutUs.Text = "    Acerca de";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // panelLeftUp
            // 
            this.panelLeftUp.Controls.Add(this.pictureBox1);
            this.panelLeftUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeftUp.Location = new System.Drawing.Point(0, 0);
            this.panelLeftUp.Name = "panelLeftUp";
            this.panelLeftUp.Size = new System.Drawing.Size(288, 200);
            this.panelLeftUp.TabIndex = 0;
            this.panelLeftUp.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftUp_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelUpFondo
            // 
            this.panelUpFondo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUpFondo.Controls.Add(this.lblNameUser);
            this.panelUpFondo.Controls.Add(this.lblWelcome);
            this.panelUpFondo.Controls.Add(this.panelUp2);
            this.panelUpFondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpFondo.Location = new System.Drawing.Point(288, 0);
            this.panelUpFondo.Name = "panelUpFondo";
            this.panelUpFondo.Size = new System.Drawing.Size(1312, 172);
            this.panelUpFondo.TabIndex = 2;
            this.panelUpFondo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpFondo_Paint);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.ForeColor = System.Drawing.Color.White;
            this.lblNameUser.Location = new System.Drawing.Point(118, 149);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(19, 19);
            this.lblNameUser.TabIndex = 4;
            this.lblNameUser.Text = "?";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(6, 149);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(106, 19);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Bienvenido:";
            // 
            // panelUp2
            // 
            this.panelUp2.BackColor = System.Drawing.Color.White;
            this.panelUp2.Controls.Add(this.linkLblLogOut);
            this.panelUp2.Controls.Add(this.pictureBox2);
            this.panelUp2.Controls.Add(this.lblFecha);
            this.panelUp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp2.Location = new System.Drawing.Point(0, 0);
            this.panelUp2.Name = "panelUp2";
            this.panelUp2.Size = new System.Drawing.Size(1312, 103);
            this.panelUp2.TabIndex = 0;
            this.panelUp2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUp2_Paint);
            // 
            // linkLblLogOut
            // 
            this.linkLblLogOut.AutoSize = true;
            this.linkLblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblLogOut.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblLogOut.Location = new System.Drawing.Point(1228, 45);
            this.linkLblLogOut.Name = "linkLblLogOut";
            this.linkLblLogOut.Size = new System.Drawing.Size(71, 19);
            this.linkLblLogOut.TabIndex = 4;
            this.linkLblLogOut.TabStop = true;
            this.linkLblLogOut.Text = "Log Out";
            this.linkLblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogOut_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1142, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 75);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(19, 19);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "?";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.userControlAbout1);
            this.panelCentral.Controls.Add(this.userControlUpDate1);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(288, 172);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(1312, 477);
            this.panelCentral.TabIndex = 3;
            this.panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDataTime_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlAbout1
            // 
            this.userControlAbout1.Location = new System.Drawing.Point(202, 26);
            this.userControlAbout1.Name = "userControlAbout1";
            this.userControlAbout1.Size = new System.Drawing.Size(835, 429);
            this.userControlAbout1.TabIndex = 1;
            this.userControlAbout1.Visible = false;
            // 
            // userControlUpDate1
            // 
            this.userControlUpDate1.Location = new System.Drawing.Point(169, 60);
            this.userControlUpDate1.Name = "userControlUpDate1";
            this.userControlUpDate1.Size = new System.Drawing.Size(912, 345);
            this.userControlUpDate1.TabIndex = 0;
            this.userControlUpDate1.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 649);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelUpFondo);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeftUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUpFondo.ResumeLayout(false);
            this.panelUpFondo.PerformLayout();
            this.panelUp2.ResumeLayout(false);
            this.panelUp2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLeftUp;
        private System.Windows.Forms.Panel panelUpFondo;
        private System.Windows.Forms.Panel panelUp2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnInfoUser;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLblLogOut;
        private UserControlUpDate userControlUpDate1;
        private UserControlAbout userControlAbout1;
    }
}