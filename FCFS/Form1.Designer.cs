
namespace FCFS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_GanttChart = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblRSAVGTurnAround = new System.Windows.Forms.Label();
            this.lblRSAVGAwaiting = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelControlResult = new System.Windows.Forms.Panel();
            this.lbl_p1_turnaroundTime = new System.Windows.Forms.Label();
            this.panel_ex_1 = new System.Windows.Forms.Panel();
            this.lbl_turnaroundTime_l = new System.Windows.Forms.Label();
            this.lbl_p1_waitingTime = new System.Windows.Forms.Label();
            this.lbl_waitingTime_l = new System.Windows.Forms.Label();
            this.lbl_p1 = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbSJF_2 = new System.Windows.Forms.RadioButton();
            this.rbSFJ_1 = new System.Windows.Forms.RadioButton();
            this.rbFCFS = new System.Windows.Forms.RadioButton();
            this.btnResult = new System.Windows.Forms.Button();
            this.pProcessDetails = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numP1Brust = new System.Windows.Forms.NumericUpDown();
            this.numP1Arrival = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.numNumberProcess = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_GanttChart.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelControlResult.SuspendLayout();
            this.gbInput.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pProcessDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numP1Brust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP1Arrival)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1255, 2);
            this.panel5.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(722, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FCFS - First Come First Served AND SJF - Shortest Job First";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbResult);
            this.panel2.Controls.Add(this.gbInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1255, 619);
            this.panel2.TabIndex = 1;
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.tabControl1);
            this.gbResult.Controls.Add(this.panel7);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResult.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbResult.Location = new System.Drawing.Point(509, 0);
            this.gbResult.Margin = new System.Windows.Forms.Padding(4);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(4);
            this.gbResult.Size = new System.Drawing.Size(746, 619);
            this.gbResult.TabIndex = 2;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Kết quả trả về";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_GanttChart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(4, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 146);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_GanttChart
            // 
            this.tabPage_GanttChart.AutoScroll = true;
            this.tabPage_GanttChart.Controls.Add(this.label6);
            this.tabPage_GanttChart.Controls.Add(this.label3);
            this.tabPage_GanttChart.Controls.Add(this.label9);
            this.tabPage_GanttChart.Location = new System.Drawing.Point(4, 37);
            this.tabPage_GanttChart.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_GanttChart.Name = "tabPage_GanttChart";
            this.tabPage_GanttChart.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_GanttChart.Size = new System.Drawing.Size(730, 105);
            this.tabPage_GanttChart.TabIndex = 0;
            this.tabPage_GanttChart.Text = "Biểu đồ Gantt";
            this.tabPage_GanttChart.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 23);
            this.label6.TabIndex = 176;
            this.label6.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 23);
            this.label3.TabIndex = 175;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(19, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 28);
            this.label9.TabIndex = 173;
            this.label9.Text = "P1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.UseCompatibleTextRendering = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panelControlResult);
            this.panel7.Location = new System.Drawing.Point(4, 185);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(738, 431);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblRSAVGTurnAround);
            this.panel8.Controls.Add(this.lblRSAVGAwaiting);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 293);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(738, 138);
            this.panel8.TabIndex = 2;
            // 
            // lblRSAVGTurnAround
            // 
            this.lblRSAVGTurnAround.AutoSize = true;
            this.lblRSAVGTurnAround.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSAVGTurnAround.ForeColor = System.Drawing.Color.Red;
            this.lblRSAVGTurnAround.Location = new System.Drawing.Point(227, 49);
            this.lblRSAVGTurnAround.Name = "lblRSAVGTurnAround";
            this.lblRSAVGTurnAround.Size = new System.Drawing.Size(82, 28);
            this.lblRSAVGTurnAround.TabIndex = 1;
            this.lblRSAVGTurnAround.Text = "Kết quả";
            // 
            // lblRSAVGAwaiting
            // 
            this.lblRSAVGAwaiting.AutoSize = true;
            this.lblRSAVGAwaiting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSAVGAwaiting.ForeColor = System.Drawing.Color.Red;
            this.lblRSAVGAwaiting.Location = new System.Drawing.Point(227, 11);
            this.lblRSAVGAwaiting.Name = "lblRSAVGAwaiting";
            this.lblRSAVGAwaiting.Size = new System.Drawing.Size(82, 28);
            this.lblRSAVGAwaiting.TabIndex = 1;
            this.lblRSAVGAwaiting.Text = "Kết quả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(13, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Average Turn around:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(13, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Average waiting time:";
            // 
            // panelControlResult
            // 
            this.panelControlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControlResult.AutoScroll = true;
            this.panelControlResult.BackColor = System.Drawing.SystemColors.Control;
            this.panelControlResult.Controls.Add(this.lbl_p1_turnaroundTime);
            this.panelControlResult.Controls.Add(this.panel_ex_1);
            this.panelControlResult.Controls.Add(this.lbl_turnaroundTime_l);
            this.panelControlResult.Controls.Add(this.lbl_p1_waitingTime);
            this.panelControlResult.Controls.Add(this.lbl_waitingTime_l);
            this.panelControlResult.Controls.Add(this.lbl_p1);
            this.panelControlResult.Location = new System.Drawing.Point(4, 3);
            this.panelControlResult.Name = "panelControlResult";
            this.panelControlResult.Size = new System.Drawing.Size(731, 284);
            this.panelControlResult.TabIndex = 1;
            // 
            // lbl_p1_turnaroundTime
            // 
            this.lbl_p1_turnaroundTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_turnaroundTime.ForeColor = System.Drawing.Color.Gray;
            this.lbl_p1_turnaroundTime.Location = new System.Drawing.Point(356, 38);
            this.lbl_p1_turnaroundTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p1_turnaroundTime.Name = "lbl_p1_turnaroundTime";
            this.lbl_p1_turnaroundTime.Size = new System.Drawing.Size(49, 21);
            this.lbl_p1_turnaroundTime.TabIndex = 177;
            this.lbl_p1_turnaroundTime.Text = "0";
            // 
            // panel_ex_1
            // 
            this.panel_ex_1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_ex_1.Location = new System.Drawing.Point(14, 34);
            this.panel_ex_1.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ex_1.Name = "panel_ex_1";
            this.panel_ex_1.Size = new System.Drawing.Size(27, 25);
            this.panel_ex_1.TabIndex = 178;
            // 
            // lbl_turnaroundTime_l
            // 
            this.lbl_turnaroundTime_l.AutoSize = true;
            this.lbl_turnaroundTime_l.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turnaroundTime_l.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_turnaroundTime_l.Location = new System.Drawing.Point(294, 13);
            this.lbl_turnaroundTime_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_turnaroundTime_l.Name = "lbl_turnaroundTime_l";
            this.lbl_turnaroundTime_l.Size = new System.Drawing.Size(139, 23);
            this.lbl_turnaroundTime_l.TabIndex = 175;
            this.lbl_turnaroundTime_l.Text = "Turnaround time";
            // 
            // lbl_p1_waitingTime
            // 
            this.lbl_p1_waitingTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1_waitingTime.ForeColor = System.Drawing.Color.Gray;
            this.lbl_p1_waitingTime.Location = new System.Drawing.Point(183, 38);
            this.lbl_p1_waitingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p1_waitingTime.Name = "lbl_p1_waitingTime";
            this.lbl_p1_waitingTime.Size = new System.Drawing.Size(51, 21);
            this.lbl_p1_waitingTime.TabIndex = 176;
            this.lbl_p1_waitingTime.Text = "0";
            // 
            // lbl_waitingTime_l
            // 
            this.lbl_waitingTime_l.AutoSize = true;
            this.lbl_waitingTime_l.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_waitingTime_l.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_waitingTime_l.Location = new System.Drawing.Point(151, 13);
            this.lbl_waitingTime_l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_waitingTime_l.Name = "lbl_waitingTime_l";
            this.lbl_waitingTime_l.Size = new System.Drawing.Size(107, 23);
            this.lbl_waitingTime_l.TabIndex = 174;
            this.lbl_waitingTime_l.Text = "Waiting time";
            // 
            // lbl_p1
            // 
            this.lbl_p1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_p1.Location = new System.Drawing.Point(48, 38);
            this.lbl_p1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_p1.Name = "lbl_p1";
            this.lbl_p1.Size = new System.Drawing.Size(105, 21);
            this.lbl_p1.TabIndex = 173;
            this.lbl_p1.Text = "Process 1";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.panel4);
            this.gbInput.Controls.Add(this.pProcessDetails);
            this.gbInput.Controls.Add(this.panel3);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInput.ForeColor = System.Drawing.Color.DarkBlue;
            this.gbInput.Location = new System.Drawing.Point(0, 0);
            this.gbInput.Margin = new System.Windows.Forms.Padding(4);
            this.gbInput.Name = "gbInput";
            this.gbInput.Padding = new System.Windows.Forms.Padding(4);
            this.gbInput.Size = new System.Drawing.Size(509, 619);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Nhập thông tin";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.rbSJF_2);
            this.panel4.Controls.Add(this.rbSFJ_1);
            this.panel4.Controls.Add(this.rbFCFS);
            this.panel4.Controls.Add(this.btnResult);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 480);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(501, 135);
            this.panel4.TabIndex = 5;
            // 
            // rbSJF_2
            // 
            this.rbSJF_2.AutoSize = true;
            this.rbSJF_2.Location = new System.Drawing.Point(12, 86);
            this.rbSJF_2.Name = "rbSJF_2";
            this.rbSJF_2.Size = new System.Drawing.Size(219, 32);
            this.rbSJF_2.TabIndex = 6;
            this.rbSJF_2.TabStop = true;
            this.rbSJF_2.Text = "SJF không độc quyền";
            this.rbSJF_2.UseVisualStyleBackColor = true;
            // 
            // rbSFJ_1
            // 
            this.rbSFJ_1.AutoSize = true;
            this.rbSFJ_1.Location = new System.Drawing.Point(12, 48);
            this.rbSFJ_1.Name = "rbSFJ_1";
            this.rbSFJ_1.Size = new System.Drawing.Size(158, 32);
            this.rbSFJ_1.TabIndex = 5;
            this.rbSFJ_1.TabStop = true;
            this.rbSFJ_1.Text = "SJF độc quyền";
            this.rbSFJ_1.UseVisualStyleBackColor = true;
            // 
            // rbFCFS
            // 
            this.rbFCFS.AutoSize = true;
            this.rbFCFS.Location = new System.Drawing.Point(12, 10);
            this.rbFCFS.Name = "rbFCFS";
            this.rbFCFS.Size = new System.Drawing.Size(76, 32);
            this.rbFCFS.TabIndex = 4;
            this.rbFCFS.TabStop = true;
            this.rbFCFS.Text = "FCFS";
            this.rbFCFS.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.PowderBlue;
            this.btnResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResult.Location = new System.Drawing.Point(264, 7);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(233, 119);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = "Kết quả";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // pProcessDetails
            // 
            this.pProcessDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pProcessDetails.AutoScroll = true;
            this.pProcessDetails.Controls.Add(this.label4);
            this.pProcessDetails.Controls.Add(this.numP1Brust);
            this.pProcessDetails.Controls.Add(this.numP1Arrival);
            this.pProcessDetails.Controls.Add(this.panel6);
            this.pProcessDetails.Controls.Add(this.label5);
            this.pProcessDetails.Controls.Add(this.lblP1);
            this.pProcessDetails.Controls.Add(this.label2);
            this.pProcessDetails.Location = new System.Drawing.Point(4, 143);
            this.pProcessDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pProcessDetails.Name = "pProcessDetails";
            this.pProcessDetails.Size = new System.Drawing.Size(501, 329);
            this.pProcessDetails.TabIndex = 4;
            this.pProcessDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pProcessDetails_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(128, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arrival time (ms)";
            // 
            // numP1Brust
            // 
            this.numP1Brust.BackColor = System.Drawing.Color.PowderBlue;
            this.numP1Brust.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numP1Brust.Location = new System.Drawing.Point(311, 95);
            this.numP1Brust.Margin = new System.Windows.Forms.Padding(4);
            this.numP1Brust.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numP1Brust.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numP1Brust.Name = "numP1Brust";
            this.numP1Brust.ReadOnly = true;
            this.numP1Brust.Size = new System.Drawing.Size(137, 32);
            this.numP1Brust.TabIndex = 5;
            this.numP1Brust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numP1Brust.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numP1Arrival
            // 
            this.numP1Arrival.BackColor = System.Drawing.Color.PowderBlue;
            this.numP1Arrival.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numP1Arrival.Location = new System.Drawing.Point(132, 95);
            this.numP1Arrival.Margin = new System.Windows.Forms.Padding(4);
            this.numP1Arrival.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numP1Arrival.Name = "numP1Arrival";
            this.numP1Arrival.ReadOnly = true;
            this.numP1Arrival.Size = new System.Drawing.Size(137, 32);
            this.numP1Arrival.TabIndex = 4;
            this.numP1Arrival.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(4, 81);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(493, 2);
            this.panel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(305, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Burst time (ms)";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblP1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblP1.Location = new System.Drawing.Point(8, 107);
            this.lblP1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(85, 23);
            this.lblP1.TabIndex = 1;
            this.lblP1.Text = "Process 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết từng tiến trình";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.numNumberProcess);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 112);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng tiến trình:";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(252, 62);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(236, 39);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(12, 62);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(232, 39);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Kế tiếp";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // numNumberProcess
            // 
            this.numNumberProcess.BackColor = System.Drawing.SystemColors.HighlightText;
            this.numNumberProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNumberProcess.Location = new System.Drawing.Point(211, 18);
            this.numNumberProcess.Margin = new System.Windows.Forms.Padding(4);
            this.numNumberProcess.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numNumberProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberProcess.Name = "numNumberProcess";
            this.numNumberProcess.ReadOnly = true;
            this.numNumberProcess.Size = new System.Drawing.Size(275, 34);
            this.numNumberProcess.TabIndex = 1;
            this.numNumberProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNumberProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCFS Tutorials";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_GanttChart.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panelControlResult.ResumeLayout(false);
            this.panelControlResult.PerformLayout();
            this.gbInput.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pProcessDetails.ResumeLayout(false);
            this.pProcessDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numP1Brust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numP1Arrival)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.NumericUpDown numNumberProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pProcessDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown numP1Arrival;
        private System.Windows.Forms.NumericUpDown numP1Brust;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_GanttChart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Panel panelControlResult;
        private System.Windows.Forms.Label lbl_p1_turnaroundTime;
        private System.Windows.Forms.Panel panel_ex_1;
        private System.Windows.Forms.Label lbl_turnaroundTime_l;
        private System.Windows.Forms.Label lbl_p1_waitingTime;
        private System.Windows.Forms.Label lbl_waitingTime_l;
        private System.Windows.Forms.Label lbl_p1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRSAVGTurnAround;
        private System.Windows.Forms.Label lblRSAVGAwaiting;
        private System.Windows.Forms.RadioButton rbSFJ_1;
        private System.Windows.Forms.RadioButton rbFCFS;
        private System.Windows.Forms.RadioButton rbSJF_2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}

