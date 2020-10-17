using System;

namespace AbovePremierDesktop.Vistas
{
    partial class Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.BuscadorArchivos = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Opciones = new System.Windows.Forms.ComboBox();
            this.BarraCarga = new System.Windows.Forms.ProgressBar();
            this.ConvertirButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.FramesTxt = new System.Windows.Forms.TextBox();
            this.ResTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RutaTxt = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscadorArchivos
            // 
            this.BuscadorArchivos.Filter = "*.mp4|*.mp4|*.avi|*.avi|*.mpeg|*.mpeg|*.flv|*.flv|Todos los Archivos|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Rubik", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione su archivo...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Rubik", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(47, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccione la acción que desea realizar...";
            // 
            // Opciones
            // 
            this.Opciones.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.Opciones.FormattingEnabled = true;
            this.Opciones.Items.AddRange(new object[] {
            "Convertir a .mp4",
            "Convertir a .mpeg",
            "Convertir a .avi",
            "Convertir a .flv",
            "Obtener audio (.mp3)",
            "Quitar audio",
            "Cambiar resolución",
            "Extraer imagenes cada \'x\' frames"});
            this.Opciones.Location = new System.Drawing.Point(90, 280);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(204, 22);
            this.Opciones.TabIndex = 10;
            this.Opciones.Text = "  ------";
            this.Opciones.SelectedIndexChanged += new System.EventHandler(this.Opciones_SelectedIndexChanged);
            // 
            // BarraCarga
            // 
            this.BarraCarga.ForeColor = System.Drawing.Color.LimeGreen;
            this.BarraCarga.Location = new System.Drawing.Point(133, 414);
            this.BarraCarga.Name = "BarraCarga";
            this.BarraCarga.Size = new System.Drawing.Size(358, 15);
            this.BarraCarga.TabIndex = 11;
            // 
            // ConvertirButton
            // 
            this.ConvertirButton.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.ConvertirButton.Location = new System.Drawing.Point(272, 355);
            this.ConvertirButton.Name = "ConvertirButton";
            this.ConvertirButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertirButton.TabIndex = 12;
            this.ConvertirButton.Text = "Convertir";
            this.ConvertirButton.UseVisualStyleBackColor = true;
            this.ConvertirButton.Click += new System.EventHandler(this.ConvertirButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.SalirButton.Location = new System.Drawing.Point(509, 465);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 23);
            this.SalirButton.TabIndex = 13;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // FramesTxt
            // 
            this.FramesTxt.Enabled = false;
            this.FramesTxt.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.FramesTxt.Location = new System.Drawing.Point(390, 258);
            this.FramesTxt.Name = "FramesTxt";
            this.FramesTxt.Size = new System.Drawing.Size(47, 21);
            this.FramesTxt.TabIndex = 14;
            // 
            // ResTxt
            // 
            this.ResTxt.Enabled = false;
            this.ResTxt.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.ResTxt.Location = new System.Drawing.Point(419, 297);
            this.ResTxt.Name = "ResTxt";
            this.ResTxt.Size = new System.Drawing.Size(100, 21);
            this.ResTxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(327, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Frames";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(327, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Resolución";
            // 
            // RutaTxt
            // 
            this.RutaTxt.Enabled = false;
            this.RutaTxt.Font = new System.Drawing.Font("Rubik", 8.25F);
            this.RutaTxt.Location = new System.Drawing.Point(90, 138);
            this.RutaTxt.Name = "RutaTxt";
            this.RutaTxt.Size = new System.Drawing.Size(378, 21);
            this.RutaTxt.TabIndex = 18;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Rubik", 9F);
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BuscarButton.Location = new System.Drawing.Point(492, 138);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(27, 20);
            this.BuscarButton.TabIndex = 19;
            this.BuscarButton.Text = "...";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImage = global::AbovePremierDesktop.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(639, 519);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RutaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResTxt);
            this.Controls.Add(this.FramesTxt);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.ConvertirButton);
            this.Controls.Add(this.BarraCarga);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 400);
            this.Name = "Conversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbovePremier - Inicio";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Conversor_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.OpenFileDialog BuscadorArchivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Opciones;
        private System.Windows.Forms.ProgressBar BarraCarga;
        private System.Windows.Forms.Button ConvertirButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.TextBox FramesTxt;
        private System.Windows.Forms.TextBox ResTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RutaTxt;
        private System.Windows.Forms.Button BuscarButton;
    }
}