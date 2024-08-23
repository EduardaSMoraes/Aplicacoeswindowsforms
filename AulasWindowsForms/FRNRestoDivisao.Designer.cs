namespace AulasWindowsForms
{
    partial class frmRestoDaDivisao
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
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            txtResto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRestoDaDivisao = new Button();
            SuspendLayout();
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(219, 70);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 1;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(447, 70);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 2;
            // 
            // txtResto
            // 
            txtResto.Enabled = false;
            txtResto.Location = new Point(447, 173);
            txtResto.Name = "txtResto";
            txtResto.ReadOnly = true;
            txtResto.Size = new Size(100, 23);
            txtResto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 70);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Dividendo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 73);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 5;
            label2.Text = "Divisor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 176);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Resto";
            // 
            // btnRestoDaDivisao
            // 
            btnRestoDaDivisao.Location = new Point(149, 159);
            btnRestoDaDivisao.Name = "btnRestoDaDivisao";
            btnRestoDaDivisao.Size = new Size(170, 36);
            btnRestoDaDivisao.TabIndex = 7;
            btnRestoDaDivisao.Text = "Resto de Divisão";
            btnRestoDaDivisao.UseVisualStyleBackColor = true;
            btnRestoDaDivisao.Click += btnRestoDaDivisao_Click;
            // 
            // frmRestoDaDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestoDaDivisao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResto);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmRestoDaDivisao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resto da Divisao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private TextBox txtResto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRestoDaDivisao;
    }
}