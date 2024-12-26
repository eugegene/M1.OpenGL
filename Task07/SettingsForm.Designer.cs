namespace PR7_Petrenko_program
{
    partial class SettingsForm
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
            nudOffsetX = new System.Windows.Forms.NumericUpDown();
            nudOffsetY = new System.Windows.Forms.NumericUpDown();
            lblOffsetX = new System.Windows.Forms.Label();
            lblOffsetY = new System.Windows.Forms.Label();
            lblZoom = new System.Windows.Forms.Label();
            nudZoom = new System.Windows.Forms.NumericUpDown();
            lblMorphFactor = new System.Windows.Forms.Label();
            lblMorphSpeed = new System.Windows.Forms.Label();
            nudMorphFactor = new System.Windows.Forms.NumericUpDown();
            nudMorphSpeed = new System.Windows.Forms.NumericUpDown();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnDefaults = new System.Windows.Forms.Button();
            lblResolution = new System.Windows.Forms.Label();
            nudResolution = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudOffsetX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudOffsetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMorphFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMorphSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            SuspendLayout();
            // 
            // nudOffsetX
            // 
            nudOffsetX.Location = new System.Drawing.Point(67, 38);
            nudOffsetX.Name = "nudOffsetX";
            nudOffsetX.Size = new System.Drawing.Size(68, 23);
            nudOffsetX.TabIndex = 0;
            // 
            // nudOffsetY
            // 
            nudOffsetY.Location = new System.Drawing.Point(67, 67);
            nudOffsetY.Name = "nudOffsetY";
            nudOffsetY.Size = new System.Drawing.Size(68, 23);
            nudOffsetY.TabIndex = 1;
            // 
            // lblOffsetX
            // 
            lblOffsetX.AutoSize = true;
            lblOffsetX.Location = new System.Drawing.Point(12, 40);
            lblOffsetX.Name = "lblOffsetX";
            lblOffsetX.Size = new System.Drawing.Size(49, 15);
            lblOffsetX.TabIndex = 2;
            lblOffsetX.Text = "Offset X";
            // 
            // lblOffsetY
            // 
            lblOffsetY.AutoSize = true;
            lblOffsetY.Location = new System.Drawing.Point(12, 69);
            lblOffsetY.Name = "lblOffsetY";
            lblOffsetY.Size = new System.Drawing.Size(49, 15);
            lblOffsetY.TabIndex = 3;
            lblOffsetY.Text = "Offset Y";
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new System.Drawing.Point(12, 98);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new System.Drawing.Size(39, 15);
            lblZoom.TabIndex = 4;
            lblZoom.Text = "Zoom";
            // 
            // nudZoom
            // 
            nudZoom.DecimalPlaces = 1;
            nudZoom.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudZoom.Location = new System.Drawing.Point(67, 96);
            nudZoom.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudZoom.Minimum = new decimal(new int[] { 5, 0, 0, int.MinValue });
            nudZoom.Name = "nudZoom";
            nudZoom.Size = new System.Drawing.Size(68, 23);
            nudZoom.TabIndex = 5;
            nudZoom.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // lblMorphFactor
            // 
            lblMorphFactor.AutoSize = true;
            lblMorphFactor.Location = new System.Drawing.Point(176, 40);
            lblMorphFactor.Name = "lblMorphFactor";
            lblMorphFactor.Size = new System.Drawing.Size(76, 15);
            lblMorphFactor.TabIndex = 6;
            lblMorphFactor.Text = "MorphFactor";
            // 
            // lblMorphSpeed
            // 
            lblMorphSpeed.AutoSize = true;
            lblMorphSpeed.Location = new System.Drawing.Point(176, 69);
            lblMorphSpeed.Name = "lblMorphSpeed";
            lblMorphSpeed.Size = new System.Drawing.Size(75, 15);
            lblMorphSpeed.TabIndex = 7;
            lblMorphSpeed.Text = "MorphSpeed";
            // 
            // nudMorphFactor
            // 
            nudMorphFactor.Location = new System.Drawing.Point(258, 38);
            nudMorphFactor.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMorphFactor.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nudMorphFactor.Name = "nudMorphFactor";
            nudMorphFactor.Size = new System.Drawing.Size(68, 23);
            nudMorphFactor.TabIndex = 8;
            nudMorphFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudMorphSpeed
            // 
            nudMorphSpeed.DecimalPlaces = 2;
            nudMorphSpeed.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudMorphSpeed.Location = new System.Drawing.Point(258, 67);
            nudMorphSpeed.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMorphSpeed.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nudMorphSpeed.Name = "nudMorphSpeed";
            nudMorphSpeed.Size = new System.Drawing.Size(68, 23);
            nudMorphSpeed.TabIndex = 9;
            nudMorphSpeed.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(374, 39);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(374, 69);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDefaults
            // 
            btnDefaults.Location = new System.Drawing.Point(374, 98);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new System.Drawing.Size(75, 23);
            btnDefaults.TabIndex = 12;
            btnDefaults.Text = "Reset";
            btnDefaults.UseVisualStyleBackColor = true;
            btnDefaults.Click += btnDefaults_Click;
            // 
            // lblResolution
            // 
            lblResolution.AutoSize = true;
            lblResolution.Location = new System.Drawing.Point(176, 96);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new System.Drawing.Size(63, 15);
            lblResolution.TabIndex = 13;
            lblResolution.Text = "Resolution";
            // 
            // nudResolution
            // 
            nudResolution.Location = new System.Drawing.Point(258, 94);
            nudResolution.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new System.Drawing.Size(68, 23);
            nudResolution.TabIndex = 14;
            nudResolution.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 148);
            Controls.Add(nudResolution);
            Controls.Add(lblResolution);
            Controls.Add(btnDefaults);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(nudMorphSpeed);
            Controls.Add(nudMorphFactor);
            Controls.Add(lblMorphSpeed);
            Controls.Add(lblMorphFactor);
            Controls.Add(nudZoom);
            Controls.Add(lblZoom);
            Controls.Add(lblOffsetY);
            Controls.Add(lblOffsetX);
            Controls.Add(nudOffsetY);
            Controls.Add(nudOffsetX);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += SettingsFormClosed;
            Load += SettingsFormLoad;
            ((System.ComponentModel.ISupportInitialize)nudOffsetX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudOffsetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudZoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMorphFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMorphSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudOffsetX;
        private System.Windows.Forms.NumericUpDown nudOffsetY;
        private System.Windows.Forms.Label lblOffsetX;
        private System.Windows.Forms.Label lblOffsetY;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.Label lblMorphFactor;
        private System.Windows.Forms.Label lblMorphSpeed;
        private System.Windows.Forms.NumericUpDown nudMorphFactor;
        private System.Windows.Forms.NumericUpDown nudMorphSpeed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.NumericUpDown nudResolution;
    }
}