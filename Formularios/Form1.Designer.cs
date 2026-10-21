namespace CrudCSharp
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(210, 265);
            button1.Name = "button1";
            button1.Size = new Size(202, 88);
            button1.TabIndex = 0;
            button1.Text = "MySql";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 27);
            textBox1.TabIndex = 1;
            textBox1.Tag = "col=descricao";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(96, 27);
            textBox2.TabIndex = 2;
            textBox2.Tag = "col=quantidade";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(406, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 27);
            textBox3.TabIndex = 3;
            textBox3.Tag = "col=validade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 83);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Descrição do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 172);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 4;
            label2.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 172);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "Validade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 365);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
