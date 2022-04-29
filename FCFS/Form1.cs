using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCFS
{
    public partial class Form1 : Form
    {
        private NumericUpDown[] arrival;
        private NumericUpDown[] brust;

        //
        private int[] cpuBrustTime;
        private int[] arrivalTime;
        private int[] priority;

        // tính toán kết quả
        int[] waitingTime_c;
        int[] turnaroundTime_c;
        int[] start_c;
        int[] end_c;
        int[] proc_c;
        //
        float avg_waiting_c;
        float avg_turnaround_c;
        int lastValid_c;

        Color[] colors;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int numberProcess = (int)numNumberProcess.Value;
                if (numberProcess >= 1)
                {
                    arrival = new NumericUpDown[numberProcess];
                    brust = new NumericUpDown[numberProcess];

                    //
                    cpuBrustTime = new int[numberProcess + 1];
                    arrivalTime = new int[numberProcess + 1];
                    priority = new int[numberProcess + 1];
                    this.pProcessDetails.AutoScroll = true;
                    names();
                    arrivals();
                    brusts();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng làm mới lại tiến trình và thực thi lại!", "Lỗi thực thi FCFS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReset.Focus();
            }

        }

        public void names()
        {
            /* Chú thích: loop và sinh ra cách label tương ứng với tiếng trình
             * VD: input: 3 tiến trình
             * output: 
             * Process 1:
             * Process 2:
             * Process 3:
            */
            Label oldLb = new Label();
            oldLb = this.lblP1;
            oldLb.Visible = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value;i++)
            {
                Label newLb = new Label();
                newLb.Size = oldLb.Size;
                newLb.Location = new Point(oldLb.Location.X, oldLb.Location.Y + y);
                int x = i + 1;
                newLb.Text = "Process " + x+":";
                newLb.Font = oldLb.Font;
                newLb.BackColor = oldLb.BackColor;
                newLb.TextAlign = oldLb.TextAlign;
                newLb.ForeColor = oldLb.ForeColor;
                newLb.AutoSize = true;
                newLb.Visible = true;
                this.pProcessDetails.Controls.Add(newLb);
                y = y + 35;
            }
        }

        public void arrivals()
        {
            /* Chú thích: Hàm có chức năng tương tự như hàm trên
             * Nhưng sinh ra NumericUpDown (Tgian đến)
            */
            NumericUpDown numOld = new NumericUpDown();
            numOld = this.numP1Arrival;
            arrival[0] = this.numP1Arrival;
            numOld.Enabled = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = numOld.Size;
                num.Minimum = numOld.Minimum;
                num.Maximum = numOld.Maximum;
                num.TextAlign = numOld.TextAlign;
                num.Location = new Point(numOld.Location.X, numOld.Location.Y + y);
                num.Enabled = numOld.Enabled;
                num.Name = "ProcessArrivalTime" + (i).ToString();
                num.BackColor = numOld.BackColor;
                num.Font = numOld.Font;
                num.ReadOnly = true;
                arrival[i] = num;
                this.pProcessDetails.Controls.Add(num);
                y = y + 35;
            }

        }

        public void brusts()
        {
            /* Chú thích: Hàm có chức năng tương tự như hàm trên
             * Nhưng sinh ra NumericUpDown (Tgian sử dụng CPU)
            */
            NumericUpDown numOld = new NumericUpDown();
            numOld = this.numP1Brust;
            brust[0] = this.numP1Brust;
            numOld.Enabled = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value; i++)
            {
                NumericUpDown num = new NumericUpDown();
                num.Size = numOld.Size;
                num.Minimum = numOld.Minimum;
                num.Maximum = numOld.Maximum;
                num.TextAlign = numOld.TextAlign;
                num.Location = new Point(numOld.Location.X, numOld.Location.Y + y);
                num.Enabled = numOld.Enabled;
                num.Name = "ProcessBrust" + (i + 1).ToString();
                num.BackColor = numOld.BackColor;
                num.Font = numOld.Font;
                num.ReadOnly = true;
                brust[i] = num;
                this.pProcessDetails.Controls.Add(num);
                y = y + 35;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                // khởi tạo mảng khi tính toán kết quả
                waitingTime_c = new int[2000];
                turnaroundTime_c = new int[2000];
                start_c = new int[2000];
                end_c = new int[2000];
                proc_c = new int[2000];

                for (int i = 0; i < (int)numNumberProcess.Value; i++)
                {
                    arrivalTime[i] = (int)arrival[i].Value;
                    cpuBrustTime[i] = (int)brust[i].Value;
                    priority[i] = -1;
                }

                //
                ChangeName();
                SetColor();
                SetNames();
                SetTurns();
                SetWaits();
                GeneralGantt();
                ResultAVG();

            }
            catch
            {
                MessageBox.Show("Vui lòng làm mới lại tiến trình và thực thi lại!", "Lỗi thực thi FCFS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnReset.Focus();
            }
            
        }

        #region Method 
        public void ChangeName()
        {
            FCFS_Algorithm sch = new FCFS_Algorithm(arrivalTime, cpuBrustTime, priority, (int)numNumberProcess.Value);
            sch.ComputeFCFS();
            lastValid_c = sch.lastValid;
            avg_turnaround_c = sch.avg_turnaround;
            avg_waiting_c = sch.avg_waiting;
            for (int i = 0; i < sch.lastValid; i++)
            {
                start_c[i] = sch.start[i];
                end_c[i] = sch.end[i];
                proc_c[i] = sch.proc[i];
            }
            //
            for (int i = 0; i < (int)numNumberProcess.Value; i++)
            {
                waitingTime_c[i] = sch.waitingTime[i];
                turnaroundTime_c[i] = sch.turnaroundTime[i];
            }
        }

        public void SetWaits()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1_waitingTime;
            this.lbl_p1_waitingTime.Text = waitingTime_c[0].ToString();
            old_lb.Visible = true;
            int y = 35;
            for(int i=1; i< (int)numNumberProcess.Value; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Name = $"lbl_p{x}_waitingTime";
                new_lb.Text = waitingTime_c[i].ToString();
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Size = old_lb.Size;
                new_lb.Visible = true;
                this.panelControlResult.Controls.Add(new_lb);
                y = y + 35;

            }
        }

        public void SetNames()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1;
            old_lb.Visible = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Text = "Process " + x;
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Visible = true;
                this.panelControlResult.Controls.Add(new_lb);
                y = y + 35;
            }

        }

        public void SetTurns()
        {
            Label old_lb = new Label();
            old_lb = this.lbl_p1_turnaroundTime;
            this.lbl_p1_turnaroundTime.Text = turnaroundTime_c[0].ToString();
            old_lb.Visible = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value; i++)
            {
                Label new_lb = new Label();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.Name = "lbl_p" + x + "_turnaroundTime";
                new_lb.Text = turnaroundTime_c[i].ToString();
                new_lb.Font = old_lb.Font;
                new_lb.BackColor = old_lb.BackColor;
                new_lb.TextAlign = old_lb.TextAlign;
                new_lb.Size = old_lb.Size;
                new_lb.Visible = true;
                this.panelControlResult.Controls.Add(new_lb);
                y = y + 35;
            }
        }

        public void SetColor()
        {
            colors = new Color[15];
            colors[0] = Color.Red;
            colors[1] = Color.Yellow;
            colors[2] = Color.Violet;
            colors[3] = Color.Blue;
            colors[4] = Color.Lime;
            colors[5] = Color.Chocolate;
            colors[6] = Color.Aqua;
            colors[7] = Color.DarkGreen;
            colors[8] = Color.Maroon;
            colors[9] = Color.Pink;
            colors[10] = Color.Silver;
            colors[11] = Color.BlanchedAlmond;
            colors[12] = Color.Cyan;
            colors[13] = Color.Fuchsia;
            colors[14] = Color.Gold;
            Panel old_lb = new Panel();
            old_lb = this.panel_ex_1;
            old_lb.Visible = true;
            int y = 35;
            for (int i = 1; i < (int)numNumberProcess.Value; i++)
            {
                Panel new_lb = new Panel();
                new_lb.Size = old_lb.Size;
                new_lb.Location = new Point(old_lb.Location.X, old_lb.Location.Y + y);
                int x = i + 1;
                new_lb.BackColor = colors[i % 15];
                new_lb.Visible = true;
                this.panelControlResult.Controls.Add(new_lb);
                y = y + 35;
            }
        }

        public void GeneralGantt()
        {
            int p;
            Label lb = new Label();
            int x = this.label9.Location.X;
            int y = this.label9.Location.Y;
            int leng = (end_c[0] - start_c[0]) * 35;
            this.label9.Size = new System.Drawing.Size(leng, 26);
            p = proc_c[0];
            //==============
            Label flag = new Label();
            flag = this.label8;
            flag.Location = new Point(this.label8.Location.X - 41 + leng, this.label8.Location.Y);
            flag.Visible = true;
            this.tabPage_GanttChart.Controls.Add(flag);

            Label n = new Label();
            n = this.label3;
            n.Location = new Point(this.label3.Location.X - 41 + leng, this.label3.Location.Y);
            n.Visible = true;
            n.Text = end_c[0].ToString();
            this.tabPage_GanttChart.Controls.Add(n);

            //============
            string name = 'P' + (p + 1).ToString();
            if (p == -1)
            {
                this.label9.BackColor = Color.Gray;
                this.label9.Text = " ";
            }
            else
            {
                // canh chinhr lai cho nay
                this.label9.BackColor = colors[p % 15];
                this.label9.Text = name;
            }

            // xu ly voi n Process
            lb = this.label9;
            x = x + leng;
            lb.Font = this.label9.Font;
            lb.ForeColor = this.label9.ForeColor;
            this.tabPage_GanttChart.Controls.Add(lb);
            for (int i = 1; i <= lastValid_c; i++)
            {
                Label lb2 = new Label();
                lb2.TextAlign = lb2.TextAlign;
                lb2.Location = new Point(x, y);
                leng = (end_c[i] - start_c[i]) * 35;
                p = proc_c[i];
                lb2.Size = new Size(leng, 26);
                name = "P" + (p + 1).ToString();
                if (p == -1)
                {
                    lb2.Text = " ";
                    lb2.BackColor = Color.Gray;
                }
                else
                {
                    lb2.Text = name;
                    lb2.BackColor = colors[p % 15];
                }
                lb2.TextAlign = this.label9.TextAlign;
                lb2.ForeColor = this.label9.ForeColor;
                x = x + leng;
                this.tabPage_GanttChart.Controls.Add(lb2);

                //==========
                Label flag2 = new Label();
                Label n2 = new Label();
                flag2.BackColor = Color.Black;
                flag2.Size = this.label8.Size;
                flag2.Location = new Point(flag.Location.X + leng, flag.Location.Y);
                flag2.Visible = true;

                n2.Size = this.label5.Size;
                n2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); ;
                n2.Location = new Point(n.Location.X + leng, n.Location.Y);
                n2.ForeColor = System.Drawing.Color.Gray;
                n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                n2.Visible = true;
                n2.Text = end_c[i].ToString();
                this.tabPage_GanttChart.Controls.Add(flag2);
                this.tabPage_GanttChart.Controls.Add(n2);
                //=================================================
                lb = lb2;
                n = n2;
                flag = flag2;
            }
        }


        public void ResultAVG()
        {
            this.lblRSAVGAwaiting.Text = avg_waiting_c.ToString() +" ms";
            this.lblRSAVGTurnAround.Text = avg_turnaround_c.ToString()+" ms";
        }
        #endregion









        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
