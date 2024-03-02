namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edEuro = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.edDollar = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edEuro);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edDollar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 83);
            this.panel1.TabIndex = 0;
            // 
            // edEuro
            // 
            this.edEuro.DecimalPlaces = 2;
            this.edEuro.Location = new System.Drawing.Point(367, 37);
            this.edEuro.Name = "edEuro";
            this.edEuro.Size = new System.Drawing.Size(90, 22);
            this.edEuro.TabIndex = 5;
            this.edEuro.Value = new decimal(new int[] {
            9913,
            0,
            0,
            131072});
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btStart.Location = new System.Drawing.Point(681, 30);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(131, 35);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start/Stop";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Start_Click);
            // 
            // edDollar
            // 
            this.edDollar.DecimalPlaces = 2;
            this.edDollar.Location = new System.Drawing.Point(235, 37);
            this.edDollar.Name = "edDollar";
            this.edDollar.Size = new System.Drawing.Size(90, 22);
            this.edDollar.TabIndex = 1;
            this.edDollar.Value = new decimal(new int[] {
            915,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial prices:";
            // 
            // chart1
            // 
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY.IsStartedFromZero = false;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea6.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea6.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.Silver;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowColor = System.Drawing.Color.DarkGray;
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(0, 83);
            this.chart1.Name = "chart1";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.OliveDrab;
            series11.IsValueShownAsLabel = true;
            series11.LabelFormat = "f4";
            series11.Legend = "Legend1";
            series11.Name = "$";
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series12.IsValueShownAsLabel = true;
            series12.LabelFormat = "F4";
            series12.Legend = "Legend1";
            series12.Name = "Euro";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(970, 543);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 626);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edDollar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown edEuro;
    }
}

