namespace Tyuiu.MitrofanovaPV.Sprint6.Task6.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            bu = new Button();
            but = new Button();
            tb1 = new TextBox();
            tb2 = new TextBox();
            open = new OpenFileDialog();
            grr = new GroupBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // bu
            // 
            bu.Location = new Point(110, 303);
            bu.Name = "bu";
            bu.Size = new Size(94, 29);
            bu.TabIndex = 0;
            bu.Text = "button1";
            bu.UseVisualStyleBackColor = true;
            // 
            // but
            // 
            but.Location = new Point(581, 293);
            but.Name = "but";
            but.Size = new Size(94, 29);
            but.TabIndex = 1;
            but.Text = "button1";
            but.UseVisualStyleBackColor = true;
            // 
            // tb1
            // 
            tb1.Location = new Point(67, 77);
            tb1.Multiline = true;
            tb1.Name = "tb1";
            tb1.Size = new Size(228, 220);
            tb1.TabIndex = 2;
            // 
            // tb2
            // 
            tb2.Location = new Point(535, 52);
            tb2.Multiline = true;
            tb2.Name = "tb2";
            tb2.Size = new Size(228, 220);
            tb2.TabIndex = 3;
            // 
            // open
            // 
            open.FileName = "openFileDialog1";
            // 
            // grr
            // 
            grr.Location = new Point(276, 293);
            grr.Name = "grr";
            grr.Size = new Size(250, 148);
            grr.TabIndex = 4;
            grr.TabStop = false;
            grr.Text = "groupBox1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(418, 136);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(8, 8);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chart1);
            Controls.Add(grr);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Controls.Add(but);
            Controls.Add(bu);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bu;
        private Button but;
        private TextBox tb1;
        private TextBox tb2;
        private OpenFileDialog open;
        private GroupBox grr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
