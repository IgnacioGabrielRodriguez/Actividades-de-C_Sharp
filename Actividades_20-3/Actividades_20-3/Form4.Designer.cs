namespace Actividades_20_3
{
    partial class Form4
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            label2 = new Label();
            txtNota3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblPromedio = new Label();
            btnPromedio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 50);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota 1";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(95, 47);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(160, 23);
            txtNota1.TabIndex = 1;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(95, 87);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(160, 23);
            txtNota2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Nota 2";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(95, 129);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(160, 23);
            txtNota3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 132);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 203);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 6;
            label4.Text = "El promedio es de: ";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(160, 203);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(67, 15);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "PROMEDIO";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(47, 262);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(208, 40);
            btnPromedio.TabIndex = 8;
            btnPromedio.Text = "PROMEDIAR";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 330);
            Controls.Add(btnPromedio);
            Controls.Add(lblPromedio);
            Controls.Add(label4);
            Controls.Add(txtNota3);
            Controls.Add(label3);
            Controls.Add(txtNota2);
            Controls.Add(label2);
            Controls.Add(txtNota1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Label label2;
        private TextBox txtNota3;
        private Label label3;
        private Label label4;
        private Label lblPromedio;
        private Button btnPromedio;
    }
}