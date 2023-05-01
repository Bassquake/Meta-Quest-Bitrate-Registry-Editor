using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FormBitrateEditor
{

    public partial class FormEditor : Form
    {
        private const string OculusRegKey = "HKEY_CURRENT_USER\\SOFTWARE\\Oculus\\RemoteHeadset";
        private const string OdtCli = "C:\\Program Files\\Oculus\\Support\\oculus-diagnostics\\OculusDebugToolCLI.exe\"";
        private const string BitrateMbpsValueName = "BitrateMbps";
        private const string HevcValueName = "HEVC";
        private const string DbrValueName = "DBR";
        private const string DbrMaxValueName = "DBRMax";
        private const string NumSlicesValueName = "numSlices";
        private const string LinkSharpeningValueName = "LinkSharpeningEnabled";

        private Boolean hevcToggle;
        private Boolean dbrToggle;
        private Boolean sharpenToggle;

        public FormEditor()
        {
            InitializeComponent();

            Object bitrateValue = Registry.GetValue(OculusRegKey, BitrateMbpsValueName, null);
            if (bitrateValue != null && bitrateValue is int)
            {
                bitrateTextBox.Text = bitrateValue.ToString();
            }

            Object dbrMaxValue = Registry.GetValue(OculusRegKey, DbrMaxValueName, null);
            if (dbrMaxValue != null && dbrMaxValue is int)
            {
                dbmTextBox.Text = dbrMaxValue.ToString();
            }

            Object numSlicesValue = Registry.GetValue(OculusRegKey, NumSlicesValueName, null);
            if (numSlicesValue != null && numSlicesValue is int)
            {
                numslicesTextBox.Text = numSlicesValue.ToString();
            }

            Object sharpenValue = Registry.GetValue(OculusRegKey, LinkSharpeningValueName, null);
            if (sharpenValue != null && sharpenValue is int && int.Parse(sharpenValue.ToString()) == 0)
            {
                sharpenToggle = false;
                sharpenBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            }
            else
            {
                sharpenToggle = true;
                sharpenBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            }

            Object hevcValue = Registry.GetValue(OculusRegKey, HevcValueName, null);
            if (hevcValue != null && hevcValue is int && int.Parse(hevcValue.ToString()) == 0)
            {
                hevcToggle = false;
                hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            }            

            else
            {
                hevcToggle = true;
                hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            }            

            Object dbrValue = Registry.GetValue(OculusRegKey, DbrValueName, null);
            if (dbrValue != null && dbrValue is int && int.Parse(dbrValue.ToString()) == 1)
            {
                dbrValue = true;
                dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            }
            else
            {
                dbrValue = false;
                dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            }
        }

        private void FormEditor_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = null;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters and control characters (such as backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bitrateTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bitrateTextBox.Text))
            {
                Registry.SetValue(OculusRegKey, BitrateMbpsValueName, int.Parse(bitrateTextBox.Text));
            }            
        }

        private void dbmTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dbmTextBox.Text))
            {
                Registry.SetValue(OculusRegKey, DbrMaxValueName, int.Parse(dbmTextBox.Text));
            }
        }

        private void numslicesTextBox_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(numslicesTextBox.Text))
            {
                Registry.SetValue(OculusRegKey, NumSlicesValueName, int.Parse(numslicesTextBox.Text));
            }
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {

        }

        private void sharpenBtn_Click(object sender, EventArgs e)
        {
            sharpenToggle = !sharpenToggle;
            sharpenBtn.BackgroundImage = sharpenToggle ? MetaQuestBitrateRegistryEditor.Properties.Resources.on_button
                : MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            Registry.SetValue(OculusRegKey, LinkSharpeningValueName, sharpenToggle ? 1 : 0);
        }

        private void hevcBtn_Click(object sender, EventArgs e)
        {
            hevcToggle = !hevcToggle;
            hevcBtn.BackgroundImage = hevcToggle ? MetaQuestBitrateRegistryEditor.Properties.Resources.on_button
                : MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            Registry.SetValue(OculusRegKey, HevcValueName, hevcToggle ? 1 : 0);
        }

        private void dbrBtn_Click(object sender, EventArgs e)
        {
            dbrToggle = !dbrToggle;
            dbrBtn.BackgroundImage = dbrToggle ? MetaQuestBitrateRegistryEditor.Properties.Resources.on_button
                : MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            Registry.SetValue(OculusRegKey, DbrValueName, dbrToggle ? 1 : 0);
        }

        private void perfHudOffBtn_Click(object sender, EventArgs e)
        {
            string command = "echo perfhud reset | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }

        private void perfHudOnBtn_Click(object sender, EventArgs e)
        {
            string command = "echo perfhud set-mode 7 | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\Oculus\\RemoteHeadset", true);

            if (key == null)
            {
                return;
            }

            if (key.GetValue(BitrateMbpsValueName) != null)
            {
                key.DeleteValue(BitrateMbpsValueName);
            }

            if (key.GetValue(HevcValueName) != null)
            {
                key.DeleteValue(HevcValueName);
            }

            if (key.GetValue(DbrValueName) != null)
            {
                key.DeleteValue(DbrValueName);
            }

            if (key.GetValue(DbrMaxValueName) != null)
            {
                key.DeleteValue(DbrMaxValueName);
            }

            if (key.GetValue(NumSlicesValueName) != null)
            {
                key.DeleteValue(NumSlicesValueName);
            }

            if (key.GetValue(LinkSharpeningValueName) != null)
            {
                key.DeleteValue(LinkSharpeningValueName);
            }

            key?.Close();

            bitrateTextBox.Text = "";
            dbmTextBox.Text = "";
            hevcToggle = true;
            hevcBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
            dbrToggle = false;
            dbrBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.off_button;
            numslicesTextBox.Text = "";
            sharpenToggle = true;
            sharpenBtn.BackgroundImage = MetaQuestBitrateRegistryEditor.Properties.Resources.on_button;
        }

        private void aswOffBtn_Click(object sender, EventArgs e)
        {
            string command = "echo server:asw.Off | \"" + OdtCli;

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c " + command; // "/c" flag tells cmd to execute the command and exit
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;

            Process.Start(startInfo);
        }
    }
}
