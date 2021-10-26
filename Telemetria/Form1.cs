using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Telemetria
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
            iniciagrafico();
            inicializatable();
            radioButton1.Checked = true ;
            
            velPB.BackColor = Color.Red;
            velPB.ForeColor = Color.Red;
            cbRPM.Checked = true;
            cbVel.Checked = true;
            rpmPB.Minimum = 0;
        }


        public void inicializatable()
        {
            table.Columns.Add("Tempo", typeof(decimal));
            table.Columns.Add("Velocidade", typeof(decimal));
            table.Columns.Add("RPM", typeof(decimal));
            table.Columns.Add("Marcha", typeof(decimal));
            table.Columns.Add("TPS", typeof(decimal));
            table.Columns.Add("FD", typeof(decimal));
           
        }

        public void iniciagrafico()
        {
            grafico.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(32, 32, 32);
            grafico.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(32, 32, 32);
            grafico.ChartAreas[0].BackColor = Color.FromArgb(32, 32, 32);
            grafico.BackColor = Color.FromArgb(32, 32, 32);
            grafico.ChartAreas[0].BorderColor = Color.Black;
            grafico.ChartAreas[0].AxisX.InterlacedColor = Color.LightGray;
            grafico.ChartAreas[0].AxisY.InterlacedColor = Color.LightGray;
            grafico.ChartAreas[0].CursorX.LineColor = Color.White;
            grafico.ChartAreas[0].AxisX.LineColor = Color.LightGray;
            grafico.ChartAreas[0].AxisY.LineColor = Color.LightGray;
            grafico.ChartAreas[0].AxisX.TitleForeColor = Color.White;
            grafico.ChartAreas[0].AxisY.TitleForeColor = Color.White;
            grafico.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.LightGray;
            grafico.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.LightGray;
            grafico.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.LightGray;
            grafico.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.LightGray;
        }

        public void lerTudo()
        {
            try
            {
                string rawData = File.ReadAllText(openFileDialog1.FileName);

                string[] rows = rawData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);


                foreach (string row in rows)
                {
                    string[] values = row.Split('/');
                    table.Rows.Add(values);
                }
                tmrAtt.Start();
               
                
            }
            catch { }
        }

        public void maxmixVel()
        {
            decimal minAccountLevel = decimal.MaxValue;
            decimal maxAccountLevel = decimal.MinValue;
            foreach (DataRow dr in table.Rows)
            {
                decimal accountLevel = dr.Field<decimal>("Velocidade");
                minAccountLevel = Math.Min(minAccountLevel, accountLevel);
                maxAccountLevel = Math.Max(maxAccountLevel, accountLevel);
            }
            label4.Text = "Min: " + minAccountLevel.ToString() + " km/h";
            label5.Text = "Max: " + maxAccountLevel.ToString() + " km/h";
            velPB.Maximum = (int)maxAccountLevel;
        }
        public void maxminRPM()
        {
            decimal minAccountLevel = decimal.MaxValue;
            decimal maxAccountLevel = decimal.MinValue;
            foreach (DataRow dr in table.Rows)
            {
                decimal accountLevel = dr.Field<decimal>("RPM");
                minAccountLevel = Math.Min(minAccountLevel, accountLevel);
                maxAccountLevel = Math.Max(maxAccountLevel, accountLevel);
            }
            label7.Text = "Min: " + minAccountLevel.ToString();
            label6.Text = "Max: " + maxAccountLevel.ToString();
            
            rpmPB.Maximum = (int)maxAccountLevel;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text|*.txt|All|*.*";
            openFileDialog1.ShowDialog();
            
        }

        private void tmrAtt_Tick(object sender, EventArgs e)
        {
           
            grafico.Series[0].XValueMember = "Tempo";
            grafico.Series[1].XValueMember = "Tempo";
            
            grafico.Series[0].YValueMembers = "Velocidade";
            grafico.Series[1].YValueMembers = "RPM";
            
           
            grafico.DataSource = table;
            grafico.DataBind();
            
        }
        Point? prevPos = null;
        ToolTip tooltip = new ToolTip();
        private void grafico_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
            
                tooltip.Active = true;
                if (e.X < 0 || e.Y < 0 || e.Location == prevPos)
                    return;
                prevPos = e.Location;

                Point p = new Point(e.X, e.Y);

                double searchVal = grafico.ChartAreas[0].AxisX.PixelPositionToValue(e.X);

                foreach (DataPoint dp in grafico.Series[0].Points)
                {
                    if (dp.XValue >= searchVal)
                    {
                        grafico.ChartAreas[0].CursorX.Interval = 0.04;
                        grafico.ChartAreas[0].CursorX.LineWidth = 1;
                        grafico.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Dot;
                        grafico.ChartAreas[0].CursorX.SetCursorPosition(dp.XValue);
                        foreach (double yD in dp.YValues)
                        {
                            lbVel.Text = String.Format("{0:0}", dp.YValues[0]) + " km/h";
                            lbVel.Update();
                            if (dp.YValues[0] >= 0)
                            {
                                velPB.Value = Convert.ToInt32(dp.YValues[0]);
                                velPB.Value = (int)dp.YValues[0];
                                velPB.Update();
                            }
                        }
                        break;
                    }
                }
                foreach (DataPoint dp in grafico.Series[1].Points)
                {
                    if (dp.XValue >= searchVal)
                    {
                        grafico.ChartAreas[0].CursorX.Interval = 0.04;
                        grafico.ChartAreas[0].CursorX.LineWidth = 1;
                        grafico.ChartAreas[0].CursorX.LineDashStyle = ChartDashStyle.Dot;
                        grafico.ChartAreas[0].CursorX.SetCursorPosition(dp.XValue);
                        foreach (double yD in dp.YValues)
                        {
                            segundos.Text = dp.XValue.ToString() + " s";
                            segundos.Update();
                            lbRPM.Text = String.Format("{0:0}", dp.YValues[0]) + " RPM";
                            lbRPM.Update();
                            if (dp.YValues[0] >= 0)
                            {
                                rpmPB.Value = Convert.ToInt32(dp.YValues[0]);
                                rpmPB.Value = (int)dp.YValues[0];
                                rpmPB.Update();
                            }
                        }
                        break;
                    }
                }
            }
            catch { tooltip.Active = false; }
        }

      
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            lerTudo();
            grafico.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            grafico.ChartAreas[0].CursorX.IsUserEnabled = true;
            grafico.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            grafico.Show();
            maxmixVel();
            maxminRPM();
        }
    
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja limpar o conteudo do grafico?", "Limpar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                table.Clear();
                grafico.Hide();
                lbRPM.Text = "-";
                lbVel.Text = "-";
                lbVel.Update();
                lbRPM.Update();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        public void testeLog()
        {
            for (int i = 0; i <5000;i++ )
                grafico.ChartAreas[0].CursorX.SetCursorPosition(i);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                grafico.Series[i].BorderWidth = 1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                grafico.Series[i].BorderWidth = 2;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                grafico.Series[i].BorderWidth = 3;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVel.Checked) grafico.Series[0].Enabled = true;
            else
            {
                grafico.Series[0].Enabled = false;
            }
        }

        private void cbRPM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRPM.Checked) grafico.Series[1].Enabled = true;
            else
            {
                grafico.Series[1].Enabled = false;
            }
        }

        private void grafico_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            try
            {
                if (me.Button == System.Windows.Forms.MouseButtons.Right)
                    grafico.ChartAreas[0].AxisX.ScaleView.ZoomReset(1);
            }
            catch { }
        }
        }
    }
