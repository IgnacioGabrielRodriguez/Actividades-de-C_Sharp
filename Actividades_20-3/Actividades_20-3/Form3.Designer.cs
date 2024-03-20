namespace Actividades_20_3
{
    partial class Form3
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
            txtVel = new TextBox();
            label2 = new Label();
            txtTime = new TextBox();
            label3 = new Label();
            lblDistancia = new Label();
            btnCalculo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "VELOCIDAD";
            // 
            // txtVel
            // 
            txtVel.Location = new Point(103, 35);
            txtVel.Name = "txtVel";
            txtVel.Size = new Size(240, 23);
            txtVel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "TIEMPO";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(82, 78);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(261, 23);
            txtTime.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 162);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "El distancia es de: ";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(224, 162);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(39, 15);
            lblDistancia.TabIndex = 5;
            lblDistancia.Text = "TOTAL";
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(121, 217);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(132, 28);
            btnCalculo.TabIndex = 6;
            btnCalculo.Text = "CALCULAR";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 279);
            Controls.Add(btnCalculo);
            Controls.Add(lblDistancia);
            Controls.Add(label3);
            Controls.Add(txtTime);
            Controls.Add(label2);
            Controls.Add(txtVel);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVel;
        private Label label2;
        private TextBox txtTime;
        private Label label3;
        private Label lblDistancia;
        private Button btnCalculo;
    }
}