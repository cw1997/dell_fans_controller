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
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnVisitDellService = new System.Windows.Forms.Button();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.trkBarSpeed = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nbrUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblTip = new System.Windows.Forms.Label();
            this.lnkRepo = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkMyWebsite = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstViewSensor = new System.Windows.Forms.ListView();
            this.colKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWarningThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFaultThresholdMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExtra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nbrUpDownAutoRefresh = new System.Windows.Forms.NumericUpDown();
            this.lblAutoRefresh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshNow = new System.Windows.Forms.Button();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownAutoRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.lblPassword);
            this.grpMain.Controls.Add(this.txtPassword);
            this.grpMain.Controls.Add(this.lblUser);
            this.grpMain.Controls.Add(this.txtUser);
            this.grpMain.Controls.Add(this.btnVisitDellService);
            this.grpMain.Controls.Add(this.lblIp);
            this.grpMain.Controls.Add(this.txtIp);
            this.grpMain.Controls.Add(this.trkBarSpeed);
            this.grpMain.Controls.Add(this.btnReset);
            this.grpMain.Controls.Add(this.btnSet);
            this.grpMain.Controls.Add(this.nbrUpDownSpeed);
            this.grpMain.Location = new System.Drawing.Point(12, 12);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(600, 234);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Fans Speed Control";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(332, 37);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(391, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "root";
            this.txtPassword.LostFocus += new System.EventHandler(this.TxtPassword_LostFocus);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(172, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 12);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(207, 34);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "root";
            this.txtUser.LostFocus += new System.EventHandler(this.TxtUser_LostFocus);
            // 
            // btnVisitDellService
            // 
            this.btnVisitDellService.Location = new System.Drawing.Point(47, 72);
            this.btnVisitDellService.Name = "btnVisitDellService";
            this.btnVisitDellService.Size = new System.Drawing.Size(213, 21);
            this.btnVisitDellService.TabIndex = 7;
            this.btnVisitDellService.Text = "Visit Dell iDRAC WEB Console";
            this.btnVisitDellService.UseVisualStyleBackColor = true;
            this.btnVisitDellService.Click += new System.EventHandler(this.btnVisitDellService_Click);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(15, 37);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(17, 12);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(47, 34);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 21);
            this.txtIp.TabIndex = 5;
            this.txtIp.Text = "192.168.0.1";
            this.txtIp.LostFocus += new System.EventHandler(this.TxtIp_LostFocus);
            // 
            // trkBarSpeed
            // 
            this.trkBarSpeed.Location = new System.Drawing.Point(17, 116);
            this.trkBarSpeed.Maximum = 100;
            this.trkBarSpeed.Name = "trkBarSpeed";
            this.trkBarSpeed.Size = new System.Drawing.Size(500, 45);
            this.trkBarSpeed.TabIndex = 4;
            this.trkBarSpeed.Scroll += new System.EventHandler(this.trkBarSpeed_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(300, 167);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset to Auto Mode";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(41, 167);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(200, 40);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set Speed";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nbrUpDownSpeed
            // 
            this.nbrUpDownSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrUpDownSpeed.Location = new System.Drawing.Point(533, 116);
            this.nbrUpDownSpeed.Name = "nbrUpDownSpeed";
            this.nbrUpDownSpeed.Size = new System.Drawing.Size(50, 21);
            this.nbrUpDownSpeed.TabIndex = 1;
            this.nbrUpDownSpeed.ValueChanged += new System.EventHandler(this.nbrUpDownSpeed_ValueChanged);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(13, 267);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(485, 36);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "拖动上面的滑块为您需要的百分比数值，则服务器风扇转速将会固定为您指定的百分比数值\r\n（注意：风扇实际转速 = 风扇最高转速 * 该百分比数值，\r\n戴尔原厂标配12" +
    "V电压规格的风扇最高转速通常为 12000 RPM）";
            // 
            // lnkRepo
            // 
            this.lnkRepo.AutoSize = true;
            this.lnkRepo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRepo.Location = new System.Drawing.Point(10, 640);
            this.lnkRepo.Name = "lnkRepo";
            this.lnkRepo.Size = new System.Drawing.Size(281, 12);
            this.lnkRepo.TabIndex = 3;
            this.lnkRepo.TabStop = true;
            this.lnkRepo.Text = "https://github.com/cw1997/dell_fans_controller";
            this.lnkRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRepo_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "若需要恢复到自动转速模式，点击上面的“Reset to auto mode”即可\r\n自动转速模式下，由服务器内部的传感器根据温度情况自动调整转速，这也是戴尔服务器" +
    "的出厂默认模式";
            // 
            // lnkMyWebsite
            // 
            this.lnkMyWebsite.AutoSize = true;
            this.lnkMyWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMyWebsite.Location = new System.Drawing.Point(344, 640);
            this.lnkMyWebsite.Name = "lnkMyWebsite";
            this.lnkMyWebsite.Size = new System.Drawing.Size(113, 12);
            this.lnkMyWebsite.TabIndex = 5;
            this.lnkMyWebsite.TabStop = true;
            this.lnkMyWebsite.Text = "http://changwei.me";
            this.lnkMyWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMyWebsite_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 640);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Code By cw1997 V1.0.0";
            // 
            // lstViewSensor
            // 
            this.lstViewSensor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKey,
            this.colValue,
            this.colUnit,
            this.colStatus,
            this.colFaultThresholdMin,
            this.colWarningThresholdMin,
            this.colWarningThresholdMax,
            this.colFaultThresholdMax,
            this.colExtra});
            this.lstViewSensor.FullRowSelect = true;
            this.lstViewSensor.GridLines = true;
            this.lstViewSensor.HideSelection = false;
            this.lstViewSensor.Location = new System.Drawing.Point(12, 395);
            this.lstViewSensor.Name = "lstViewSensor";
            this.lstViewSensor.Size = new System.Drawing.Size(600, 226);
            this.lstViewSensor.TabIndex = 7;
            this.lstViewSensor.UseCompatibleStateImageBehavior = false;
            this.lstViewSensor.View = System.Windows.Forms.View.Details;
            // 
            // colKey
            // 
            this.colKey.Text = "Key";
            this.colKey.Width = 100;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 100;
            // 
            // colUnit
            // 
            this.colUnit.Text = "Unit";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colFaultThresholdMin
            // 
            this.colFaultThresholdMin.Text = "FaultThresholdMin";
            this.colFaultThresholdMin.Width = 78;
            // 
            // colWarningThresholdMin
            // 
            this.colWarningThresholdMin.Text = "WarningThresholdMin";
            this.colWarningThresholdMin.Width = 79;
            // 
            // colWarningThresholdMax
            // 
            this.colWarningThresholdMax.Text = "WarningThresholdMax";
            this.colWarningThresholdMax.Width = 80;
            // 
            // colFaultThresholdMax
            // 
            this.colFaultThresholdMax.Text = "FaultThresholdMax";
            this.colFaultThresholdMax.Width = 74;
            // 
            // colExtra
            // 
            this.colExtra.Text = "Extra";
            // 
            // nbrUpDownAutoRefresh
            // 
            this.nbrUpDownAutoRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbrUpDownAutoRefresh.Location = new System.Drawing.Point(132, 368);
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
            this.lblAutoRefresh.Location = new System.Drawing.Point(13, 370);
            this.lblAutoRefresh.Name = "lblAutoRefresh";
            this.lblAutoRefresh.Size = new System.Drawing.Size(113, 12);
            this.lblAutoRefresh.TabIndex = 12;
            this.lblAutoRefresh.Text = "Auto Refresh Delay";
            this.lblAutoRefresh.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "(second)";
            this.label3.Visible = false;
            // 
            // btnRefreshNow
            // 
            this.btnRefreshNow.Location = new System.Drawing.Point(433, 366);
            this.btnRefreshNow.Name = "btnRefreshNow";
            this.btnRefreshNow.Size = new System.Drawing.Size(179, 21);
            this.btnRefreshNow.TabIndex = 12;
            this.btnRefreshNow.Text = "Refresh Now";
            this.btnRefreshNow.UseVisualStyleBackColor = true;
            this.btnRefreshNow.Click += new System.EventHandler(this.btnRefreshNow_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 661);
            this.Controls.Add(this.btnRefreshNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAutoRefresh);
            this.Controls.Add(this.nbrUpDownAutoRefresh);
            this.Controls.Add(this.lstViewSensor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkMyWebsite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkRepo);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.grpMain);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dell Fans Speed Controller";
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrUpDownAutoRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TrackBar trkBarSpeed;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nbrUpDownSpeed;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.LinkLabel lnkRepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkMyWebsite;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.ColumnHeader colExtra;
        private System.Windows.Forms.Label lblAutoRefresh;
        private System.Windows.Forms.NumericUpDown nbrUpDownAutoRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshNow;
        private System.Windows.Forms.ColumnHeader colKey;
    }
}

