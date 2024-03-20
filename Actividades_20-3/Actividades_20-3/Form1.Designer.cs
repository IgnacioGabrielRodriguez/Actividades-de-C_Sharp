namespace Actividades_20_3
{
    partial class Form1
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
            btnOk = new Button();
            btnCerrar = new Button();
            txtName = new TextBox();
            lblName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(34, 141);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(146, 104);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK\r\n";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(234, 141);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 104);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(346, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(116, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 15);
            lblName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 5;
            label1.Text = "BIEMBENIDO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 291);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnCerrar);
            Controls.Add(btnOk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOk;
        private Button btnCerrar;
        private TextBox txtName;
        private Label lblName;
        private Label label1;
    }
}