namespace Telemetria
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbVel = new System.Windows.Forms.CheckBox();
            this.cbRPM = new System.Windows.Forms.CheckBox();
            this.tmrAtt = new System.Windows.Forms.Timer(this.components);
            this.lbVel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.segundos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbRPM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rpmPB = new Telemetria.VerticalProgressBar();
            this.velPB = new Telemetria.VerticalProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(17, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 42);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Abrir";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(90, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 42);
            this.btnClear.TabIndex = 2;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(95, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limpar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grafico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 636);
            this.panel1.TabIndex = 4;
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            this.grafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafico.Location = new System.Drawing.Point(0, 0);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Firebrick;
            series2.Name = "Series2";
            this.grafico.Series.Add(series1);
            this.grafico.Series.Add(series2);
            this.grafico.Size = new System.Drawing.Size(1225, 636);
            this.grafico.TabIndex = 0;
            this.grafico.Text = "chart1";
            this.grafico.Click += new System.EventHandler(this.grafico_Click);
            this.grafico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.grafico_MouseMove);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(77, 23);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(3, 70);
            this.panel9.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(155, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 70);
            this.panel2.TabIndex = 16;
            // 
            // cbVel
            // 
            this.cbVel.AutoSize = true;
            this.cbVel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVel.ForeColor = System.Drawing.Color.Lime;
            this.cbVel.Location = new System.Drawing.Point(287, 37);
            this.cbVel.Name = "cbVel";
            this.cbVel.Size = new System.Drawing.Size(89, 17);
            this.cbVel.TabIndex = 17;
            this.cbVel.Text = "Velocidade";
            this.cbVel.UseVisualStyleBackColor = false;
            this.cbVel.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbRPM
            // 
            this.cbRPM.AutoSize = true;
            this.cbRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRPM.ForeColor = System.Drawing.Color.Firebrick;
            this.cbRPM.Location = new System.Drawing.Point(467, 37);
            this.cbRPM.Name = "cbRPM";
            this.cbRPM.Size = new System.Drawing.Size(53, 17);
            this.cbRPM.TabIndex = 18;
            this.cbRPM.Text = "RPM";
            this.cbRPM.UseVisualStyleBackColor = true;
            this.cbRPM.CheckedChanged += new System.EventHandler(this.cbRPM_CheckedChanged);
            // 
            // tmrAtt
            // 
            this.tmrAtt.Interval = 10;
            this.tmrAtt.Tick += new System.EventHandler(this.tmrAtt_Tick);
            // 
            // lbVel
            // 
            this.lbVel.ForeColor = System.Drawing.Color.Snow;
            this.lbVel.Location = new System.Drawing.Point(382, 82);
            this.lbVel.Name = "lbVel";
            this.lbVel.Size = new System.Drawing.Size(58, 16);
            this.lbVel.TabIndex = 20;
            this.lbVel.Text = "-";
            this.lbVel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.rpmPB);
            this.panel3.Controls.Add(this.velPB);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbRPM);
            this.panel3.Controls.Add(this.lbVel);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnOpen);
            this.panel3.Controls.Add(this.cbRPM);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbVel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 101);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.segundos);
            this.panel4.Location = new System.Drawing.Point(175, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 101);
            this.panel4.TabIndex = 28;
            // 
            // segundos
            // 
            this.segundos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.Location = new System.Drawing.Point(0, 0);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(95, 101);
            this.segundos.TabIndex = 27;
            this.segundos.Text = "- s";
            this.segundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(1061, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Largura";
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Snow;
            this.radioButton3.Location = new System.Drawing.Point(1058, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 px";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Snow;
            this.radioButton2.Location = new System.Drawing.Point(1058, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 px";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Snow;
            this.radioButton1.Location = new System.Drawing.Point(1058, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 px";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1125, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lbRPM
            // 
            this.lbRPM.ForeColor = System.Drawing.Color.Snow;
            this.lbRPM.Location = new System.Drawing.Point(519, 82);
            this.lbRPM.Name = "lbRPM";
            this.lbRPM.Size = new System.Drawing.Size(70, 19);
            this.lbRPM.TabIndex = 21;
            this.lbRPM.Text = "-";
            this.lbRPM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(284, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(284, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Max:";
            // 
            // rpmPB
            // 
            this.rpmPB.ForeColor = System.Drawing.Color.DarkRed;
            this.rpmPB.Location = new System.Drawing.Point(526, 4);
            this.rpmPB.MarqueeAnimationSpeed = 0;
            this.rpmPB.Name = "rpmPB";
            this.rpmPB.Size = new System.Drawing.Size(58, 78);
            this.rpmPB.TabIndex = 30;
            // 
            // velPB
            // 
            this.velPB.ForeColor = System.Drawing.Color.DarkRed;
            this.velPB.Location = new System.Drawing.Point(382, 4);
            this.velPB.MarqueeAnimationSpeed = 0;
            this.velPB.Name = "velPB";
            this.velPB.Size = new System.Drawing.Size(58, 78);
            this.velPB.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(464, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(464, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Min:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1225, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Telemetria Coyotes Moto Racing";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbVel;
        private System.Windows.Forms.CheckBox cbRPM;
        private System.Windows.Forms.Timer tmrAtt;
        private System.Windows.Forms.Label lbVel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbRPM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label segundos;
        private VerticalProgressBar velPB;
        private VerticalProgressBar rpmPB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

