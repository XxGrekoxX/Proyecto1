namespace Proyecto1
{
    partial class UserControlRegister
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRegister = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblUpdateUser = new System.Windows.Forms.Label();
            this.txtMail1 = new System.Windows.Forms.TextBox();
            this.txtTelef1 = new System.Windows.Forms.TextBox();
            this.txtLastName1 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.lblUpdateTelef = new System.Windows.Forms.Label();
            this.lblUpdateMail = new System.Windows.Forms.Label();
            this.lblUpdateLastName = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.lblUpdatePassword = new System.Windows.Forms.Label();
            this.lblUpdate_User = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabControlRegister.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRegister
            // 
            this.tabControlRegister.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRegister.Controls.Add(this.tabPageAddUser);
            this.tabControlRegister.Controls.Add(this.tabPageSearchUser);
            this.tabControlRegister.Controls.Add(this.tabPageUpdate);
            this.tabControlRegister.Location = new System.Drawing.Point(17, 13);
            this.tabControlRegister.Name = "tabControlRegister";
            this.tabControlRegister.SelectedIndex = 0;
            this.tabControlRegister.Size = new System.Drawing.Size(1068, 354);
            this.tabControlRegister.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.txtMail);
            this.tabPageAddUser.Controls.Add(this.txtTelef);
            this.tabPageAddUser.Controls.Add(this.txtLastName);
            this.tabPageAddUser.Controls.Add(this.txtName);
            this.tabPageAddUser.Controls.Add(this.txtPassword);
            this.tabPageAddUser.Controls.Add(this.txtUser);
            this.tabPageAddUser.Controls.Add(this.lblTelef);
            this.tabPageAddUser.Controls.Add(this.lblEmail);
            this.tabPageAddUser.Controls.Add(this.lblLastName);
            this.tabPageAddUser.Controls.Add(this.lblName);
            this.tabPageAddUser.Controls.Add(this.lblPassword);
            this.tabPageAddUser.Controls.Add(this.lblUser);
            this.tabPageAddUser.Controls.Add(this.btnAdd);
            this.tabPageAddUser.Controls.Add(this.txtId);
            this.tabPageAddUser.Controls.Add(this.lblId);
            this.tabPageAddUser.Controls.Add(this.lblAddUser);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1060, 320);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Agregar Usuario";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Click += new System.EventHandler(this.tabPageAddUser_Click);
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Location = new System.Drawing.Point(654, 93);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(253, 28);
            this.txtMail.TabIndex = 26;
            // 
            // txtTelef
            // 
            this.txtTelef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelef.Location = new System.Drawing.Point(654, 152);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(253, 28);
            this.txtTelef.TabIndex = 25;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Location = new System.Drawing.Point(654, 34);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(253, 28);
            this.txtLastName.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(246, 206);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 28);
            this.txtName.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(246, 147);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 28);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Location = new System.Drawing.Point(246, 88);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(253, 28);
            this.txtUser.TabIndex = 17;
            // 
            // lblTelef
            // 
            this.lblTelef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(546, 156);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(84, 19);
            this.lblTelef.TabIndex = 14;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(546, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 19);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(546, 38);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(91, 19);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Apellidos:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(114, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 19);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(114, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(108, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(114, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuario:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(125, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(246, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(253, 28);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(114, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(126, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Identificacion:";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAddUser.Location = new System.Drawing.Point(6, 3);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(145, 19);
            this.lblAddUser.TabIndex = 0;
            this.lblAddUser.Text = "Agregar Usuario:";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUser.Controls.Add(this.txtUserSearch);
            this.tabPageSearchUser.Controls.Add(this.lblUserSearch);
            this.tabPageSearchUser.Controls.Add(this.lblSearchUser);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1060, 320);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Buscar Usuario";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            this.tabPageSearchUser.Enter += new System.EventHandler(this.tabPageSearchUser_Enter);
            this.tabPageSearchUser.Leave += new System.EventHandler(this.tabPageSearchUser_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridViewUser.Location = new System.Drawing.Point(10, 46);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(1044, 257);
            this.dataGridViewUser.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_Id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_User";
            this.Column2.HeaderText = "Usuario";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Contraseña";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "User_Name";
            this.Column4.HeaderText = "Nombre";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "User_LastName";
            this.Column5.HeaderText = "Apellidos";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "User_Email";
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "User_Telef";
            this.Column7.HeaderText = "Telefono";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "User_Booking";
            this.Column8.HeaderText = "Reservas";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Location = new System.Drawing.Point(433, 11);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(264, 28);
            this.txtUserSearch.TabIndex = 2;
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.Location = new System.Drawing.Point(331, 14);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(75, 21);
            this.lblUserSearch.TabIndex = 1;
            this.lblUserSearch.Text = "Usuario:";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSearchUser.Location = new System.Drawing.Point(6, 3);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(135, 21);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Buscar Usuario:";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.btnDelete);
            this.tabPageUpdate.Controls.Add(this.lblUpdateUser);
            this.tabPageUpdate.Controls.Add(this.txtMail1);
            this.tabPageUpdate.Controls.Add(this.txtTelef1);
            this.tabPageUpdate.Controls.Add(this.txtLastName1);
            this.tabPageUpdate.Controls.Add(this.txtName1);
            this.tabPageUpdate.Controls.Add(this.txtPassword1);
            this.tabPageUpdate.Controls.Add(this.txtUser1);
            this.tabPageUpdate.Controls.Add(this.lblUpdateTelef);
            this.tabPageUpdate.Controls.Add(this.lblUpdateMail);
            this.tabPageUpdate.Controls.Add(this.lblUpdateLastName);
            this.tabPageUpdate.Controls.Add(this.lblUpdateName);
            this.tabPageUpdate.Controls.Add(this.lblUpdatePassword);
            this.tabPageUpdate.Controls.Add(this.lblUpdate_User);
            this.tabPageUpdate.Controls.Add(this.btnUpdate);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(1060, 320);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Actualizar Información";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            this.tabPageUpdate.Leave += new System.EventHandler(this.tabPageUpdate_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(543, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 39);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblUpdateUser
            // 
            this.lblUpdateUser.AutoSize = true;
            this.lblUpdateUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUpdateUser.Location = new System.Drawing.Point(6, 14);
            this.lblUpdateUser.Name = "lblUpdateUser";
            this.lblUpdateUser.Size = new System.Drawing.Size(159, 19);
            this.lblUpdateUser.TabIndex = 42;
            this.lblUpdateUser.Text = "Actualizar Usuario:";
            // 
            // txtMail1
            // 
            this.txtMail1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail1.Location = new System.Drawing.Point(674, 89);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(253, 28);
            this.txtMail1.TabIndex = 41;
            // 
            // txtTelef1
            // 
            this.txtTelef1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelef1.Location = new System.Drawing.Point(674, 148);
            this.txtTelef1.Name = "txtTelef1";
            this.txtTelef1.Size = new System.Drawing.Size(253, 28);
            this.txtTelef1.TabIndex = 40;
            // 
            // txtLastName1
            // 
            this.txtLastName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName1.Location = new System.Drawing.Point(674, 30);
            this.txtLastName1.Name = "txtLastName1";
            this.txtLastName1.Size = new System.Drawing.Size(253, 28);
            this.txtLastName1.TabIndex = 39;
            // 
            // txtName1
            // 
            this.txtName1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName1.Location = new System.Drawing.Point(258, 148);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(253, 28);
            this.txtName1.TabIndex = 38;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword1.Location = new System.Drawing.Point(258, 89);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(253, 28);
            this.txtPassword1.TabIndex = 37;
            // 
            // txtUser1
            // 
            this.txtUser1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser1.Location = new System.Drawing.Point(258, 30);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(253, 28);
            this.txtUser1.TabIndex = 36;
            // 
            // lblUpdateTelef
            // 
            this.lblUpdateTelef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateTelef.AutoSize = true;
            this.lblUpdateTelef.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTelef.Location = new System.Drawing.Point(566, 152);
            this.lblUpdateTelef.Name = "lblUpdateTelef";
            this.lblUpdateTelef.Size = new System.Drawing.Size(84, 19);
            this.lblUpdateTelef.TabIndex = 35;
            this.lblUpdateTelef.Text = "Telefono:";
            // 
            // lblUpdateMail
            // 
            this.lblUpdateMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateMail.AutoSize = true;
            this.lblUpdateMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateMail.Location = new System.Drawing.Point(566, 93);
            this.lblUpdateMail.Name = "lblUpdateMail";
            this.lblUpdateMail.Size = new System.Drawing.Size(58, 19);
            this.lblUpdateMail.TabIndex = 34;
            this.lblUpdateMail.Text = "Email:";
            // 
            // lblUpdateLastName
            // 
            this.lblUpdateLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateLastName.AutoSize = true;
            this.lblUpdateLastName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateLastName.Location = new System.Drawing.Point(566, 34);
            this.lblUpdateLastName.Name = "lblUpdateLastName";
            this.lblUpdateLastName.Size = new System.Drawing.Size(91, 19);
            this.lblUpdateLastName.TabIndex = 33;
            this.lblUpdateLastName.Text = "Apellidos:";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateName.Location = new System.Drawing.Point(126, 157);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(81, 19);
            this.lblUpdateName.TabIndex = 32;
            this.lblUpdateName.Text = "Nombre:";
            // 
            // lblUpdatePassword
            // 
            this.lblUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdatePassword.AutoSize = true;
            this.lblUpdatePassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePassword.Location = new System.Drawing.Point(126, 98);
            this.lblUpdatePassword.Name = "lblUpdatePassword";
            this.lblUpdatePassword.Size = new System.Drawing.Size(108, 19);
            this.lblUpdatePassword.TabIndex = 31;
            this.lblUpdatePassword.Text = "Contraseña:";
            // 
            // lblUpdate_User
            // 
            this.lblUpdate_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUpdate_User.AutoSize = true;
            this.lblUpdate_User.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate_User.Location = new System.Drawing.Point(126, 39);
            this.lblUpdate_User.Name = "lblUpdate_User";
            this.lblUpdate_User.Size = new System.Drawing.Size(73, 19);
            this.lblUpdate_User.TabIndex = 30;
            this.lblUpdate_User.Text = "Usuario:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(308, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 39);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // UserControlRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRegister);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlRegister";
            this.Size = new System.Drawing.Size(1102, 390);
            this.tabControlRegister.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRegister;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Label lblUpdateUser;
        private System.Windows.Forms.TextBox txtMail1;
        private System.Windows.Forms.TextBox txtTelef1;
        private System.Windows.Forms.TextBox txtLastName1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.Label lblUpdateTelef;
        private System.Windows.Forms.Label lblUpdateMail;
        private System.Windows.Forms.Label lblUpdateLastName;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.Label lblUpdatePassword;
        private System.Windows.Forms.Label lblUpdate_User;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPageAddUser;
    }
}
