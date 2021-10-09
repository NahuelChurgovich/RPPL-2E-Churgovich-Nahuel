
namespace Formularios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.chkHarcode = new System.Windows.Forms.CheckedListBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.Location = new System.Drawing.Point(117, 111);
            this.btnSalir.Size = new System.Drawing.Size(90, 32);
            this.btnSalir.TabIndex = 5;
            // 
            // lblTema
            // 
            this.lblTema.Location = new System.Drawing.Point(172, -2);
            this.lblTema.TabIndex = 8;
            // 
            // chkNocturno
            // 
            this.chkNocturno.Location = new System.Drawing.Point(172, 12);
            this.chkNocturno.TabIndex = 0;
            this.chkNocturno.CheckedChanged += new System.EventHandler(this.chkNocturno_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImage = global::Formularios.Properties.Resources.boton2;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("EngraversGothic BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(11, 111);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 32);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Lilex", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(12, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 14);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(12, 28);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 17);
            this.txtUsuario.TabIndex = 2;
            // 
            // chkHarcode
            // 
            this.chkHarcode.BackColor = System.Drawing.Color.RoyalBlue;
            this.chkHarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkHarcode.CausesValidation = false;
            this.chkHarcode.CheckOnClick = true;
            this.chkHarcode.Font = new System.Drawing.Font("Lilex", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkHarcode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chkHarcode.FormattingEnabled = true;
            this.chkHarcode.Items.AddRange(new object[] {
            "SuperUsuario",
            "Administrador",
            "Empleado"});
            this.chkHarcode.Location = new System.Drawing.Point(50, 153);
            this.chkHarcode.Name = "chkHarcode";
            this.chkHarcode.Size = new System.Drawing.Size(121, 54);
            this.chkHarcode.TabIndex = 7;
            this.chkHarcode.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkHarcode_ItemCheck);
            this.chkHarcode.SelectedIndexChanged += new System.EventHandler(this.chkHarcode_SelectedIndexChanged);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.ForeColor = System.Drawing.Color.Black;
            this.txtContrasenia.Location = new System.Drawing.Point(12, 78);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(195, 17);
            this.txtContrasenia.TabIndex = 4;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Lilex", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContrasenia.Location = new System.Drawing.Point(12, 57);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(77, 14);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 219);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.chkHarcode);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "FormLogin";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.lblTema, 0);
            this.Controls.SetChildIndex(this.chkNocturno, 0);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.chkHarcode, 0);
            this.Controls.SetChildIndex(this.lblContrasenia, 0);
            this.Controls.SetChildIndex(this.txtContrasenia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.CheckedListBox chkHarcode;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
    }
}

