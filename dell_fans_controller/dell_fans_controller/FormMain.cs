using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace dell_fans_controller
{
    public partial class frmMain : Form
    {
        private static string version = "v1.0.2";

        private static string currentPath = Application.StartupPath; // System.Environment.CurrentDirectory;
        private static string configFileName = "\\config.ini";
        private static string explorer = "explorer";
        private static string ipmitoolPath = currentPath + "\\ipmitool.exe";
        private static string configFilePath = currentPath + configFileName;

        private static string defaultIp = "192.168.1.100";
        private static string defaultUser = "root";
        private static string defaultPassword = "calvin";
        private static string defaultConfigSection = "ipmi";

        private static string execute(string parameter)
        {
            Process process = null;
            string result = string.Empty;
            try
            {
                process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                process.Start();

                process.StandardInput.WriteLine(parameter + "& exit");
                process.StandardInput.AutoFlush = true;
                result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                process.Close();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExceptionOccurred:{ 0},{ 1}", ex.Message, ex.StackTrace.ToString());
                return null;
            }
        }

        private void saveConfig()
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            IniHelper.Write(defaultConfigSection, "ip", ip, configFilePath);
            IniHelper.Write(defaultConfigSection, "user", user, configFilePath);
            IniHelper.Write(defaultConfigSection, "password", password, configFilePath);
        }

        public frmMain()
        {
            InitializeComponent();

            if (File.Exists(configFilePath))
            {
                string ip = IniHelper.Read(defaultConfigSection, "ip", defaultIp, configFilePath);
                string user = IniHelper.Read(defaultConfigSection, "user", defaultUser, configFilePath);
                string password = IniHelper.Read(defaultConfigSection, "password", defaultPassword, configFilePath);
                txtIp.Text = ip;
                txtUser.Text = user;
                txtPassword.Text = password;
            }
            else
            {
                IniHelper.Write(defaultConfigSection, "ip", defaultIp, configFilePath);
                IniHelper.Write(defaultConfigSection, "user", defaultUser, configFilePath);
                IniHelper.Write(defaultConfigSection, "password", defaultPassword, configFilePath);
                txtIp.Text = defaultIp;
                txtUser.Text = defaultUser;
                txtPassword.Text = defaultPassword;
            }
            this.progressBar.Visible = false;
        }

        private void nbrUpDownSpeed_ValueChanged(object sender, EventArgs e)
        {
            trkBarSpeed.Value = (int)nbrUpDownSpeed.Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            string parametersReset = string.Format("-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x01 0x01", ip, user, password);

            string fullExecuteReset = ipmitoolPath + " " + parametersReset;

            execute(fullExecuteReset);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;
            string percent = nbrUpDownSpeed.Text;
            int percentNum = int.Parse(percent);

            // string format = "%s/Dell/SysMgt/bmc/ipmitool.exe -I lanplus -H %s -U %s -P %s raw
            // 0x30 0x30 0x01";
            string formatDisableAutoMode = "-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x01 0x00";
            string parametersDisableAutoMode = string.Format(formatDisableAutoMode, ip, user, password);

            string fullExecuteDisableAutoMode = ipmitoolPath + " " + parametersDisableAutoMode;
            string resultDisableAutoMode = execute(fullExecuteDisableAutoMode);

            // format = "%s/Dell/SysMgt/bmc/ipmitool.exe -I lanplus -H %s -U %s -P %s raw 0x30 0x30
            // 0x02 0xff 0x%02x";
            string formatSetSpeed = "-I lanplus -H {0} -U {1} -P {2} raw 0x30 0x30 0x02 0xff 0x{3:x2}";
            string parametersSetSpeed = string.Format(formatSetSpeed, ip, user, password, percentNum);

            string fullExecuteSetSpeed = ipmitoolPath + " " + parametersSetSpeed;
            string resultSetSpeed = execute(fullExecuteSetSpeed);

            // MessageBox.Show(resultDisableAutoMode + "-" + resultSetSpeed);

            //string cmdFormat = "/k \"{0} {1}\" & \"{2} {3}\"";
            //string cmdParameters = string.Format(cmdFormat, ipmitoolPath, parametersDisableAutoMode,
            //ipmitoolPath, parametersSetSpeed);

            //Process.Start("cmd", cmdParameters);
        }

        private void btnVisitDellService_Click(object sender, EventArgs e)
        {
            Process.Start(explorer, "http://" + txtIp.Text);
        }

        private void trkBarSpeed_Scroll(object sender, EventArgs e)
        {
            nbrUpDownSpeed.Value = trkBarSpeed.Value;
        }

        private void btnRefreshNow_Click(object sender, EventArgs e)
        {
            background_FetchStates.RunWorkerAsync();
        }

        private void TxtIp_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void TxtUser_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void TxtPassword_LostFocus(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += " " + version;
        }

        private void background_FetchStates_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgWorker = sender as BackgroundWorker;

            bgWorker.ReportProgress(0, "start");

            string ip = txtIp.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            string formatSensor = "-I lanplus -H {0} -U {1} -P {2} sensor";
            string parametersSensor = string.Format(formatSensor, ip, user, password);

            string fullExecuteSensor = ipmitoolPath + " " + parametersSensor;
            string result = execute(fullExecuteSensor);

            result = result.Replace("\r\n", "\n");
            string[] sensorList = result.Split('\n', '\r');

            foreach (var item in sensorList)
            {
                if (item.Contains("Temp") || item.Contains("RPM") || item.Contains("Voltage") || item.Contains("Current"))
                {
                    string[] temp = new string[8];
                    var src = item.Split('|');
                    temp[0] = src[0];
                    temp[1] = src[1];
                    temp[2] = src[2];
                    temp[3] = src[3];
                    temp[4] = src[5];
                    temp[5] = src[6];
                    temp[6] = src[7];
                    temp[7] = src[8];

                    bgWorker.ReportProgress(1, temp);
                    //lstViewSensor.Items.Add(new ListViewItem(temp));
                }
            }
            bgWorker.ReportProgress(100, "completed");
        }

        private void background_FetchStates_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int Percentage = e.ProgressPercentage;
            if (Percentage == 0)
            {
                this.progressBar.Visible = true;
                lstViewSensor.Items.Clear();
            }
            else if (Percentage == 1)
            {
                // 在这里更新UI
                string[] message = (string[])e.UserState;
                lstViewSensor.Items.Add(new ListViewItem(message));
            }
            else
            {
                this.progressBar.Visible = false;
            }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code by jiafeng5513, fork from cw1997");
        }
    }
}