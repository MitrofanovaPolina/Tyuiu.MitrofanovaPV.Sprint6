namespace Tyuiu.MitrofanovaPV.Sprint6.Task3.V30
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
            dg = new DataGridView();
            button1 = new Button();
            res = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)res).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(160, 189);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.Size = new Size(300, 188);
            dg.TabIndex = 1;
            dg.CellContentClick += dg_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(396, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // res
            // 
            res.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            res.Location = new Point(488, 42);
            res.Name = "res";
            res.RowHeadersWidth = 51;
            res.Size = new Size(300, 188);
            res.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(res);
            Controls.Add(button1);
            Controls.Add(dg);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ((System.ComponentModel.ISupportInitialize)res).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dg;
        private Button button1;
        private DataGridView res;
    }
}
            