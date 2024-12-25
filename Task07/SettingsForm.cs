using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PR7_Petrenko_program
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            nudOffsetX.Value = Properties.Settings.Default.OffsetX;
            nudOffsetY.Value = Properties.Settings.Default.OffsetY;
            nudZoom.Value = Properties.Settings.Default.Zoom;
            nudMorphFactor.Value = Properties.Settings.Default.MorphFactor;
            nudMorphSpeed.Value = Properties.Settings.Default.MorphSpeed;
            nudResolution.Value = Properties.Settings.Default.Resolution;

            Debug.WriteLine("Load screen saver's settings.");
        }

        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.OffsetX = nudOffsetX.Value;
            Properties.Settings.Default.OffsetX = nudOffsetX.Value;
            Properties.Settings.Default.Zoom = nudZoom.Value;
            Properties.Settings.Default.MorphFactor = nudMorphFactor.Value;
            Properties.Settings.Default.MorphSpeed = nudMorphSpeed.Value;
            Properties.Settings.Default.Resolution = (int)nudResolution.Value;

            Debug.WriteLine("Save screen saver's settings.");
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetX = nudOffsetX.Value;
            Properties.Settings.Default.OffsetX = nudOffsetX.Value;
            Properties.Settings.Default.Zoom = nudZoom.Value;
            Properties.Settings.Default.MorphFactor = nudMorphFactor.Value;
            Properties.Settings.Default.MorphSpeed = nudMorphSpeed.Value;
            Properties.Settings.Default.Resolution = (int)nudResolution.Value;
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nudOffsetX.Value = Properties.Settings.Default.OffsetX;
            nudOffsetY.Value = Properties.Settings.Default.OffsetY;
            nudZoom.Value = Properties.Settings.Default.Zoom;
            nudMorphFactor.Value = Properties.Settings.Default.MorphFactor;
            nudMorphSpeed.Value = Properties.Settings.Default.MorphSpeed;
            nudResolution.Value = Properties.Settings.Default.Resolution;
            Environment.Exit(0);
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OffsetX = 0.0m;
            Properties.Settings.Default.OffsetX = 0.0m;
            Properties.Settings.Default.Zoom = 0.5m;
            Properties.Settings.Default.MorphFactor = 0.9m;
            Properties.Settings.Default.MorphSpeed = 0.01m;
            Properties.Settings.Default.Resolution = 150;
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }
    }
}