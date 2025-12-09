namespace Tyuiu.MitrofanovaPV.Sprint6.Task0.V25
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
            textBox1 = new TextBox();
            var = new Button();
            result = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 194);
            textBox1.TabIndex = 0;
            textBox1.Text = "drtdty";
            // 
            // var
            // 
            var.Location = new Point(102, 342);
            var.Name = "var";
            var.Size = new Size(94, 29);
            var.TabIndex = 1;
            var.Text = "button1";
            var.UseVisualStyleBackColor = true;
            var.Click += var_Click;
            // 
            // result
            // 
            result.Location = new Point(649, 301);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(125, 27);
            result.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(var);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Click += var_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button var;
        private TextBox result;
    }
}
