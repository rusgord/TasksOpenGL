using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace test1
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            chkbxCustomFigure.Checked = Properties.Settings.Default.IsCustomFigure;
            nudCx.Value = Properties.Settings.Default.CxValue;
            nudCy.Value = Properties.Settings.Default.CyValue;
            chkbxFloatFigure.Checked = Properties.Settings.Default.IsFloatingFigure;
            trbarSpeed.Value = Properties.Settings.Default.SpeedValue;
            trbarSize.Value = Properties.Settings.Default.SizeValue;

            Debug.WriteLine("Load screen saver's settings.");
        }

        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.IsCustomFigure = chkbxCustomFigure.Checked;
            Properties.Settings.Default.CxValue = nudCx.Value;
            Properties.Settings.Default.CyValue = nudCy.Value;
            Properties.Settings.Default.IsFloatingFigure = chkbxFloatFigure.Checked;
            Properties.Settings.Default.SpeedValue = trbarSpeed.Value;
            Properties.Settings.Default.SizeValue = trbarSize.Value;
            Properties.Settings.Default.Save();
            Debug.WriteLine("Save screen saver's settings.");
        }

        private void OnChangedCustom(object sender, EventArgs e)
        {
            if (chkbxCustomFigure.Checked)
            {
                nudCx.Enabled = true;
                nudCy.Enabled = true;
            }
            else
            {
                nudCx.Enabled = false;
                nudCy.Enabled = false;
            }
        }

        private void OnChangedFloating(object sender, EventArgs e)
        {
            if (chkbxFloatFigure.Checked)
            {
                trbarSpeed.Enabled = true;
            }
            else
            {
                trbarSpeed.Enabled = false;
            }
        }

        private void OnClickOkBtn(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsCustomFigure = chkbxCustomFigure.Checked;
            Properties.Settings.Default.CxValue = nudCx.Value;
            Properties.Settings.Default.CyValue = nudCy.Value;
            Properties.Settings.Default.IsFloatingFigure = chkbxFloatFigure.Checked;
            Properties.Settings.Default.SpeedValue = trbarSpeed.Value;
            Properties.Settings.Default.SizeValue = trbarSize.Value;
            Properties.Settings.Default.Save();
        }

        private void OnClickCancelBtn(object sender, EventArgs e)
        {
            chkbxCustomFigure.Checked = Properties.Settings.Default.IsCustomFigure;
            nudCx.Value = Properties.Settings.Default.CxValue;
            nudCy.Value = Properties.Settings.Default.CyValue;
            chkbxFloatFigure.Checked = Properties.Settings.Default.IsFloatingFigure;
            trbarSpeed.Value = Properties.Settings.Default.SpeedValue;
            trbarSize.Value = Properties.Settings.Default.SizeValue;
        }
    }
}
