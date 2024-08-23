namespace TrocaValores
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
            BtmClicar = new Button();
            LblValor1 = new Label();
            LblValor2 = new Label();
            TxtValor2 = new TextBox();
            TxtValor1 = new TextBox();
            SuspendLayout();
            // 
            // BtmClicar
            // 
            BtmClicar.Image = Properties.Resources.troquinha;
            BtmClicar.Location = new Point(314, 158);
            BtmClicar.Name = "BtmClicar";
            BtmClicar.Size = new Size(75, 51);
            BtmClicar.TabIndex = 0;
            BtmClicar.UseVisualStyleBackColor = true;
            BtmClicar.Click += BtmClicar_Click;
            BtmClicar.MouseHover += BtmClicar_MouseHover;
            // 
            // LblValor1
            // 
            LblValor1.AutoSize = true;
            LblValor1.Location = new Point(120, 85);
            LblValor1.Name = "LblValor1";
            LblValor1.Size = new Size(42, 15);
            LblValor1.TabIndex = 1;
            LblValor1.Text = "Valor1:";
            LblValor1.Click += label1_Click;
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.Location = new Point(405, 88);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(42, 15);
            LblValor2.TabIndex = 2;
            LblValor2.Text = "Valor2:";
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(453, 85);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 23);
            TxtValor2.TabIndex = 3;
            TxtValor2.TextChanged += TxtValor2_TextChanged;
            // 
            // TxtValor1
            // 
            TxtValor1.Location = new Point(168, 85);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(100, 23);
            TxtValor1.TabIndex = 4;
            TxtValor1.TextChanged += TxtValor1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 259);
            Controls.Add(TxtValor1);
            Controls.Add(TxtValor2);
            Controls.Add(LblValor2);
            Controls.Add(LblValor1);
            Controls.Add(BtmClicar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtmClicar;
        private Label LblValor1;
        private Label LblValor2;
        private TextBox TxtValor2;
        private TextBox TxtValor1;
    }
}
