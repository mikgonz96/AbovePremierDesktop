namespace AbovePremierDesktop
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BienvenidoTxt = new System.Windows.Forms.Label();
            this.Inicie = new System.Windows.Forms.Label();
            this.UserTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.UsuarioTxt = new System.Windows.Forms.Label();
            this.ContraseñaTxt = new System.Windows.Forms.Label();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BienvenidoTxt
            // 
            this.BienvenidoTxt.AutoSize = true;
            this.BienvenidoTxt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BienvenidoTxt.Font = new System.Drawing.Font("Rubik", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienvenidoTxt.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.BienvenidoTxt.Location = new System.Drawing.Point(118, 59);
            this.BienvenidoTxt.Name = "BienvenidoTxt";
            this.BienvenidoTxt.Size = new System.Drawing.Size(364, 64);
            this.BienvenidoTxt.TabIndex = 0;
            this.BienvenidoTxt.Text = "¡Bienvenido!";
            // 
            // Inicie
            // 
            this.Inicie.AutoSize = true;
            this.Inicie.Font = new System.Drawing.Font("Rubik Medium", 14.5F, System.Drawing.FontStyle.Bold);
            this.Inicie.ForeColor = System.Drawing.Color.LavenderBlush;
            this.Inicie.Location = new System.Drawing.Point(173, 123);
            this.Inicie.Name = "Inicie";
            this.Inicie.Size = new System.Drawing.Size(243, 24);
            this.Inicie.TabIndex = 1;
            this.Inicie.Text = "Por favor inicie sesión";
            // 
            // UserTxt
            // 
            this.UserTxt.Location = new System.Drawing.Point(278, 227);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(135, 20);
            this.UserTxt.TabIndex = 2;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(278, 286);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(135, 20);
            this.PassTxt.TabIndex = 3;
            this.PassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxt_KeyPress);
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.AutoSize = true;
            this.UsuarioTxt.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTxt.ForeColor = System.Drawing.Color.LavenderBlush;
            this.UsuarioTxt.Location = new System.Drawing.Point(188, 226);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(62, 19);
            this.UsuarioTxt.TabIndex = 4;
            this.UsuarioTxt.Text = "Usuario";
            // 
            // ContraseñaTxt
            // 
            this.ContraseñaTxt.AutoSize = true;
            this.ContraseñaTxt.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTxt.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ContraseñaTxt.Location = new System.Drawing.Point(175, 287);
            this.ContraseñaTxt.Name = "ContraseñaTxt";
            this.ContraseñaTxt.Size = new System.Drawing.Size(90, 19);
            this.ContraseñaTxt.TabIndex = 5;
            this.ContraseñaTxt.Text = "Contraseña";
            // 
            // IngresarButton
            // 
            this.IngresarButton.Font = new System.Drawing.Font("Rubik", 10F);
            this.IngresarButton.Location = new System.Drawing.Point(243, 356);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(105, 28);
            this.IngresarButton.TabIndex = 6;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Font = new System.Drawing.Font("Rubik", 11F);
            this.Error.ForeColor = System.Drawing.Color.Firebrick;
            this.Error.Location = new System.Drawing.Point(131, 334);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 19);
            this.Error.TabIndex = 7;
            this.Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Error.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::AbovePremierDesktop.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(603, 437);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.ContraseñaTxt);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.Inicie);
            this.Controls.Add(this.BienvenidoTxt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 400);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Above Premier - Bienvenido";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidoTxt;
        private System.Windows.Forms.Label Inicie;
        private System.Windows.Forms.TextBox UserTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label UsuarioTxt;
        private System.Windows.Forms.Label ContraseñaTxt;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.Label Error;
    }
}

