namespace Actividades_20_3
{
    partial class RandomNameGenerate
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
            lblName = new Label();
            btnGenerate = new Button();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 15);
            lblName.TabIndex = 0;
            lblName.Text = "name";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(35, 145);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(131, 91);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generar";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(186, 145);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(131, 91);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copiar";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // RandomNameGenerate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 280);
            Controls.Add(btnCopy);
            Controls.Add(btnGenerate);
            Controls.Add(lblName);
            Name = "RandomNameGenerate";
            Text = "RandomNameGenerate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Button btnGenerate;
        private Button btnCopy;
    }
}