namespace dell_fans_controller
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.about_button = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.btnVisitDellService = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.trkBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nbrUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.lstViewSensor = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nbrUpDownAutoRefresh = new System.Windows.Forms.NumericUpDown();
            this.lblAutoRefresh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshNow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.background_FetchStates = new System.ComponentModel.BackgroundWorker();
            this.grpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownAutoRefresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMain.Controls.Add(this.tableLayoutPanel1);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(959, 63);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "iDRAC";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.Controls.Add(this.about_button, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVisitDellService, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUser, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 43);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // about_button
            // 
            this.about_button.Location = new System.Drawing.Point(657, 3);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(91, 27);
            this.about_button.TabIndex = 13;
            this.about_button.Text = "About";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(3, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(17, 12);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP";
            // 
            // btnVisitDellService
            // 
            this.btnVisitDellService.Location = new System.Drawing.Point(438, 3);
            this.btnVisitDellService.Name = "btnVisitDellService";
            this.btnVisitDellService.Size = new System.Drawing.Size(213, 27);
            this.btnVisitDellService.TabIndex = 7;
            this.btnVisitDellService.Text = "Visit Dell iDRAC WEB Console";
            this.btnVisitDellService.UseVisualStyleBackColor = true;
            this.btnVisitDellService.Click += new System.EventHandler(this.btnVisitDellService_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(332, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "root";
            this.txtPassword.LostFocus += new System.EventHandler(this.TxtPassword_LostFocus);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(273, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(26, 3);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 5;
            this.txtIp.Text = "192.168.0.1";
            this.txtIp.LostFocus += new System.EventHandler(this.TxtIp_LostFocus);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(132, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 12);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(167, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            this.txtUser.LostFocus += new System.EventHandler(this.TxtUser_LostFocus);
            // 
            // trkBarSpeed
            // 
            this.trkBarSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trkBarSpeed.Location = new System.Drawing.Point(8, 20);
            this.trkBarSpeed.Maximum = 100;
            this.trkBarSpeed.Minimum = 10;
            this.trkBarSpeed.Name = "trkBarSpeed";
            this.trkBarSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trkBarSpeed.Size = new System.Drawing.Size(584, 45);
            this.trkBarSpeed.SmallChange = 5;
            this.trkBarSpeed.TabIndex = 4;
            this.trkBarSpeed.TickFrequency = 5;
            this.trkBarSpeed.Value = 20;
            this.trkBarSpeed.Scroll += new System.EventHandler(this.trkBarSpeed_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(812, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 22);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset to Auto Mode";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(675, 22);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(131, 22);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set Speed";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nbrUpDownSpeed
            // 
            this.nbrUpDownSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrUpDownSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nbrUpDownSpeed.Location = new System.Drawing.Point(599, 23);
            this.nbrUpDownSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nbrUpDownSpeed.Name = "nbrUpDownSpeed";
            this.nbrUpDownSpeed.Size = new System.Drawing.Size(55, 21);
            this.nbrUpDownSpeed.TabIndex = 1;
            this.nbrUpDownSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbrUpDownSpeed.ValueChanged += new System.EventHandler(this.nbrUpDownSpeed_ValueChanged);
            // 
            // lstViewSensor
            // 
            this.lstViewSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewSensor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colValue,
            this.colUnit,
            this.colStatus,
            this.colFaultThresholdMin,
            this.colWarningThresholdMin,
            this.colWarningThresholdMax,
            this.colFaultThresholdMax});
            this.lstViewSensor.FullRowSelect = true;
            this.lstViewSensor.GridLines = true;
            this.lstViewSensor.HideSelection = false;
            this.lstViewSensor.Location = new System.Drawing.Point(6, 42);
            this.lstViewSensor.Name = "lstViewSensor";
            this.lstViewSensor.Size = new System.Drawing.Size(945, 229);
            this.lstViewSensor.TabIndex = 7;
            this.lstViewSensor.UseCompatibleStateImageBehavior = false;
            this.lstViewSensor.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "探测器";
            this.colKey.Width = 120;
            // 
            // colValue
            // 
            this.colValue.Text = "读数";
            this.colValue.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.Text = "单位";
            this.colUnit.Width = 100;
            // 
            // colStatus
            // 
            this.colStatus.Text = "状态";
            // 
            // colFaultThresholdMin
            // 
            this.colFaultThresholdMin.Text = "Fault下限";
            this.colFaultThresholdMin.Width = 78;
            // 
            // colWarningThresholdMin
            // 
            this.colWarningThresholdMin.Text = "警告下限";
            this.colWarningThresholdMin.Width = 79;
            // 
            // colWarningThresholdMax
            // 
            this.colWarningThresholdMax.Text = "警告上限";
            this.colWarningThresholdMax.Width = 80;
            // 
            // colFaultThresholdMax
            // 
            this.colFaultThresholdMax.Text = "Fault上限";
            this.colFaultThresholdMax.Width = 74;
            // 
            // nbrUpDownAutoRefresh
            // 
            this.nbrUpDownAutoRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrUpDownAutoRefresh.Location = new System.Drawing.Point(230, 17);
            this.nbrUpDownAutoRefresh.Name = "nbrUpDownAutoRefresh";
            this.nbrUpDownAutoRefresh.Size = new System.Drawing.Size(50, 21);
            this.nbrUpDownAutoRefresh.TabIndex = 12;
            this.nbrUpDownAutoRefresh.Tag = " TODO: by cw1997 2020-06-24 22:58:37";
            this.nbrUpDownAutoRefresh.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nbrUpDownAutoRefresh.Visible = false;
            // 
            // lblAutoRefresh
            // 
            this.lblAutoRefresh.AutoSize = true;
            this.lblAutoRefresh.Location = new System.Drawing.Point(111, 19);
            this.lblAutoRefresh.Name = "lblAutoRefresh";
            this.lblAutoRefresh.Size = new System.Drawing.Size(113, 12);
            this.lblAutoRefresh.TabIndex = 12;
            this.lblAutoRefresh.Text = "Auto Refresh Delay";
            this.lblAutoRefresh.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "(second)";
            this.label3.Visible = false;
            // 
            // btnRefreshNow
            // 
            this.btnRefreshNow.Location = new System.Drawing.Point(6, 15);
            this.btnRefreshNow.Name = "btnRefreshNow";
            this.btnRefreshNow.Size = new System.Drawing.Size(99, 21);
            this.btnRefreshNow.TabIndex = 12;
            this.btnRefreshNow.Text = "Refresh Now";
            this.btnRefreshNow.UseVisualStyleBackColor = true;
            this.btnRefreshNow.Click += new System.EventHandler(this.btnRefreshNow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trkBarSpeed);
            this.groupBox1.Controls.Add(this.nbrUpDownSpeed);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Location = new System.Drawing.Point(12, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 68);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fans Speed Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Controls.Add(this.btnRefreshNow);
            this.groupBox2.Controls.Add(this.lstViewSensor);
            this.groupBox2.Controls.Add(this.nbrUpDownAutoRefresh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblAutoRefresh);
            this.groupBox2.Location = new System.Drawing.Point(13, 634);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 277);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "States";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(542, 17);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 24;
            // 
            // background_FetchStates
            // 
            this.background_FetchStates.WorkerReportsProgress = true;
            this.background_FetchStates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.background_FetchStates_DoWork);
            this.background_FetchStates.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.background_FetchStates_ProgressChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 923);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpMain);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dell Fans Speed Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownAutoRefresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TrackBar trkBarSpeed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nbrUpDownSpeed;
        private System.Windows.Forms.Button btnVisitDellService;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ListView lstViewSensor;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.ColumnHeader colUnit;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colFaultThresholdMin;
        private System.Windows.Forms.ColumnHeader colWarningThresholdMin;
        private System.Windows.Forms.ColumnHeader colWarningThresholdMax;
        private System.Windows.Forms.ColumnHeader colFaultThresholdMax;
        private System.Windows.Forms.Label lblAutoRefresh;
        private System.Windows.Forms.NumericUpDown nbrUpDownAutoRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshNow;
        private System.Windows.Forms.ColumnHeader colKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.ComponentModel.BackgroundWorker background_FetchStates;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button about_button;
    }
}

