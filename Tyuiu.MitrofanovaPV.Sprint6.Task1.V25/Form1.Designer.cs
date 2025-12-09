namespace Tyuiu.MitrofanovaPV.Sprint6.Task1.V25
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
            groupBox1 = new GroupBox();
            boxstart = new TextBox();
            boxstop = new TextBox();
            result = new TextBox();
            knopka = new Button();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(520, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 52);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // boxstart
            // 
            boxstart.Location = new Point(68, 368);
            boxstart.Name = "boxstart";
            boxstart.Size = new Size(125, 27);
            boxstart.TabIndex = 1;
            // 
            // boxstop
            // 
            boxstop.Location = new Point(237, 368);
            boxstop.Name = "boxstop";
            boxstop.Size = new Size(125, 27);
            boxstop.TabIndex = 2;
            // 
            // result
            // 
            result.Location = new Point(548, 93);
            result.Multiline = true;
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(222, 327);
            result.TabIndex = 3;
            // 
            // knopka
            // 
            knopka.Location = new Point(408, 368);
            knopka.Name = "knopka";
            knopka.Size = new Size(94, 29);
            knopka.TabIndex = 4;
            knopka.Text = "button1";
            knopka.UseVisualStyleBackColor = true;
            knopka.Click += knopka_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(knopka);
            Controls.Add(result);
            Controls.Add(boxstop);
            Controls.Add(boxstart);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox boxstart;
        private TextBox boxstop;
        private TextBox result;
        private Button knopka;
    }
}
