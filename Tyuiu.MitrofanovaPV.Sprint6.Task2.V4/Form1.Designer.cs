namespace Tyuiu.MitrofanovaPV.Sprint6.Task2.V4
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
            knopka = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            boxstop = new TextBox();
            boxstart = new TextBox();
            result = new TextBox();
            SuspendLayout();
            // 
            // knopka
            // 
            knopka.Location = new Point(450, 318);
            knopka.Name = "knopka";
            knopka.Size = new Size(94, 29);
            knopka.TabIndex = 0;
            knopka.Text = "button1";
            knopka.UseVisualStyleBackColor = true;
            // 
            // boxstop
            // 
            boxstop.Location = new Point(382, 236);
            boxstop.Name = "boxstop";
            boxstop.Size = new Size(125, 27);
            boxstop.TabIndex = 1;
            // 
            // boxstart
            // 
            boxstart.Location = new Point(376, 156);
            boxstart.Name = "boxstart";
            boxstart.Size = new Size(125, 27);
            boxstart.TabIndex = 2;
            // 
            // result
            // 
            result.Location = new Point(582, 77);
            result.Multiline = true;
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(198, 284);
            result.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(boxstart);
            Controls.Add(boxstop);
            Controls.Add(knopka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button knopka;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TextBox boxstop;
        private TextBox boxstart;
        private TextBox result;
    }
}
