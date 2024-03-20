namespace Actividades_20_3
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            btnOK = new Button();
            btnCerrar = new Button();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "CONTRACEÑA";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(44, 134);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(150, 103);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(225, 134);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 103);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(106, 46);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(269, 23);
            txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(135, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 23);
            txtPassword.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 272);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(btnCerrar);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnOK;
        private Button btnCerrar;
        private TextBox txtUser;
        private TextBox txtPassword;
    }
}