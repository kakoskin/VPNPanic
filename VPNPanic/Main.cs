using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPNPanic
{
    public partial class Main : Form
    {
        private System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private IPDetector detector;
        private ShutdownController shutdownController;

        private const string IpRangePattern = @"^[0-9]{1,3}\.[0-9]{1,3}\.([0-9]{1,3}|\*)\.([0-9]{1,3}|\*)$";
        private byte?[] ipRange = new byte?[4];

        public Main()
        {
            InitializeComponent();
            this.detector = new IPDetector();
            this.shutdownController = new ShutdownController();
            this.Load += Main_Load;
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (!AdminRightsHelper.ThisProcessHasAdminRights())
                {
                    MessageBox.Show("This app needs to run with admin rights in order to be able to disable network adapters or shutdown computer if needed!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }

                for (int i = 0; i < this.checkedListBoxActions.Items.Count; i++)
                {
                    if(i != 1)
                        this.checkedListBoxActions.SetItemChecked(i, true);

                    if(i == 3)
                    {
                        this.checkedListBoxActions.SetItemChecked(i, this.shutdownController.CanShutdown());
                    }
                }

                var ip = await this.detector.DetectPublicIP(5000);
                this.tbCurrentPublicIP.Text = ip.ToString();
                if (!string.IsNullOrEmpty(this.Text))
                {
                    this.cbActivate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                Application.Exit();
            }

        }

        private void timerRedAlert_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = SystemColors.Control;
            }
            else
            {
                this.BackColor = Color.Red;
            }

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void PlaySoundAlarm()
        {
            try
            {
                this.player.SoundLocation = "IndustrialAlarm.wav";
                this.player.PlayLooping();
            }
            finally
            {
            }
        }

        private void cbActivate_Click(object sender, EventArgs e)
        {
            try
            {
                bool rangeOk = System.Text.RegularExpressions.Regex.IsMatch(this.tbIPRange.Text, IpRangePattern);
                if (!rangeOk)
                {
                    MessageBox.Show("Fix range");
                    return;
                }

                var parts = this.tbIPRange.Text.Split('.');
                if (parts.Length != 4)
                {
                    MessageBox.Show("Invalid range");
                    return;
                }

                for(int i = 0; i < this.ipRange.Length; i++)
                {
                    if(parts[i] != "*")
                    {
                        this.ipRange[i] = byte.Parse(parts[i]);
                    }
                }

                this.timerPoll.Enabled = true;
                this.cbActivate.Visible = false;
                this.cbDeactivate.Visible = true;
                this.Log("Action-Activate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void timerPoll_Tick(object sender, EventArgs e)
        {
            try
            {
                var ip = await this.detector.DetectPublicIP(2000);
                this.tbCurrentPublicIP.Text = ip.ToString();

                if(IPDetector.IsInRange(ip,this.ipRange))
                {
                    this.Log("IP in valid range");
                }
                else
                {
                    this.timerPoll.Enabled = false;
                    this.Log("IP not in valid range!");
                    this.LaunchPanicProcedure();
                }
                
            }
            catch (Exception ex)
            {
                this.timerPoll.Enabled = false;
                this.Log("Error " + ex.Message);
                this.LaunchPanicProcedure();
            }            
        }

        private void LaunchPanicProcedure()
        {
            this.cbDeactivate.Enabled = false;

            try
            {
                this.Log("Action-PanicProcedure");
                if (this.checkedListBoxActions.GetItemChecked(0))
                {
                    this.timerRedAlert.Enabled = true;
                }

                if (this.checkedListBoxActions.GetItemChecked(1))
                {
                    this.PlaySoundAlarm();
                }

                if (this.checkedListBoxActions.GetItemChecked(2))
                {
                    new NetworkConnectionController().DisableNetworkConnections();
                    return;
                }

                if (this.checkedListBoxActions.GetItemChecked(3))
                {
                    new ShutdownController().ShutdownComputer();
                }

            }
            catch
            {
                if (this.checkedListBoxActions.GetItemChecked(3))
                {
                    new ShutdownController().ShutdownComputer();
                }
            }            
        }

        private void Log(string message)
        {
            this.lbLog.Items.Insert(0, DateTime.Now.ToLongTimeString() + " " + message);
            if(this.lbLog.Items.Count > 20)
            {
                this.lbLog.Items.RemoveAt(this.lbLog.Items.Count - 1);
            }
        }

        private void cbDeactivate_Click(object sender, EventArgs e)
        {
            this.timerPoll.Enabled = false;
            this.cbActivate.Visible = true;
            this.cbDeactivate.Visible = false;
            this.Log("Action-Deactivate");
        }

        private void disableNetworkConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Log("Test-DisableNetworkconnections");
            new NetworkConnectionController().DisableNetworkConnections();
        }

        private void shutdownComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Log("Test-ShutdownComputer");
            if(!this.shutdownController.CanShutdown())
            {
                MessageBox.Show("Cannot shutdown computer, shutdown.exe not found");
                return;
            }

            this.shutdownController.ShutdownComputer();
        }
    }
}
