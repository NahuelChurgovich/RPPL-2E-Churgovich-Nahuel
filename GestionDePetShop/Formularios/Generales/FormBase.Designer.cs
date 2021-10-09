
namespace Formularios.Generales
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkNocturno = new Formularios.Botones.ControlEncendido();
            this.lblTema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(12, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 35);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkNocturno
            // 
            this.chkNocturno.AutoSize = true;
            this.chkNocturno.Location = new System.Drawing.Point(132, 35);
            this.chkNocturno.MinimumSize = new System.Drawing.Size(45, 22);
            this.chkNocturno.Name = "chkNocturno";
            this.chkNocturno.OffBackColor = System.Drawing.Color.MidnightBlue;
            this.chkNocturno.OffToggleColor = System.Drawing.Color.Silver;
            this.chkNocturno.OnBackColor = System.Drawing.Color.SandyBrown;
            this.chkNocturno.OnToggleColor = System.Drawing.Color.Gray;
            this.chkNocturno.Size = new System.Drawing.Size(45, 22);
            this.chkNocturno.TabIndex = 1;
            this.chkNocturno.UseVisualStyleBackColor = true;
            this.chkNocturno.CheckedChanged += new System.EventHandler(this.chkNocturno_CheckedChanged);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Lilex", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTema.Location = new System.Drawing.Point(132, 18);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(49, 14);
            this.lblTema.TabIndex = 2;
            this.lblTema.Text = "Oscuro";
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(311, 283);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.chkNocturno);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Lilex", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBase";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBase_FormClosing);
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnSalir;
        protected Botones.ControlEncendido chkNocturno;
        private System.Windows.Forms.Label lblTema;
    }
}