
namespace PR5_Petrenko_program
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            gbViewMode = new System.Windows.Forms.GroupBox();
            rbPerspective = new System.Windows.Forms.RadioButton();
            rbOrtho = new System.Windows.Forms.RadioButton();
            gbFillMode = new System.Windows.Forms.GroupBox();
            rbFillMode = new System.Windows.Forms.RadioButton();
            rbLineMode = new System.Windows.Forms.RadioButton();
            cbClip = new System.Windows.Forms.CheckBox();
            cbLight = new System.Windows.Forms.CheckBox();
            gbOptions = new System.Windows.Forms.GroupBox();
            cbDrawList = new System.Windows.Forms.CheckBox();
            gbViewMode.SuspendLayout();
            gbFillMode.SuspendLayout();
            gbOptions.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.clipPlane = false;
            renderControl1.fillMode = 6913U;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.isLight = false;
            renderControl1.Location = new System.Drawing.Point(7, 6);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(350, 350);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            renderControl1.useDrawList = false;
            renderControl1.ViewMode = 0;
            // 
            // gbViewMode
            // 
            gbViewMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbViewMode.Controls.Add(rbPerspective);
            gbViewMode.Controls.Add(rbOrtho);
            gbViewMode.Location = new System.Drawing.Point(363, 179);
            gbViewMode.Name = "gbViewMode";
            gbViewMode.Size = new System.Drawing.Size(159, 72);
            gbViewMode.TabIndex = 1;
            gbViewMode.TabStop = false;
            gbViewMode.Text = "View Mode";
            // 
            // rbPerspective
            // 
            rbPerspective.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbPerspective.AutoSize = true;
            rbPerspective.Enabled = false;
            rbPerspective.Location = new System.Drawing.Point(6, 47);
            rbPerspective.Name = "rbPerspective";
            rbPerspective.Size = new System.Drawing.Size(85, 19);
            rbPerspective.TabIndex = 3;
            rbPerspective.Text = "Perspective";
            rbPerspective.UseVisualStyleBackColor = true;
            rbPerspective.Visible = false;
            rbPerspective.CheckedChanged += rbPerspective_CheckedChanged;
            // 
            // rbOrtho
            // 
            rbOrtho.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbOrtho.AutoSize = true;
            rbOrtho.Checked = true;
            rbOrtho.Location = new System.Drawing.Point(6, 22);
            rbOrtho.Name = "rbOrtho";
            rbOrtho.Size = new System.Drawing.Size(56, 19);
            rbOrtho.TabIndex = 2;
            rbOrtho.TabStop = true;
            rbOrtho.Text = "Ortho";
            rbOrtho.UseVisualStyleBackColor = true;
            rbOrtho.CheckedChanged += rbOrtho_CheckedChanged;
            // 
            // gbFillMode
            // 
            gbFillMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbFillMode.Controls.Add(rbFillMode);
            gbFillMode.Controls.Add(rbLineMode);
            gbFillMode.Location = new System.Drawing.Point(369, 270);
            gbFillMode.Name = "gbFillMode";
            gbFillMode.Size = new System.Drawing.Size(153, 79);
            gbFillMode.TabIndex = 2;
            gbFillMode.TabStop = false;
            gbFillMode.Text = "Fill Mode";
            // 
            // rbFillMode
            // 
            rbFillMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbFillMode.AutoSize = true;
            rbFillMode.Location = new System.Drawing.Point(6, 47);
            rbFillMode.Name = "rbFillMode";
            rbFillMode.Size = new System.Drawing.Size(65, 19);
            rbFillMode.TabIndex = 4;
            rbFillMode.Text = "GL_FILL";
            rbFillMode.UseVisualStyleBackColor = true;
            rbFillMode.CheckedChanged += rbFillMode_CheckedChanged;
            // 
            // rbLineMode
            // 
            rbLineMode.AutoSize = true;
            rbLineMode.Checked = true;
            rbLineMode.Location = new System.Drawing.Point(6, 22);
            rbLineMode.Name = "rbLineMode";
            rbLineMode.Size = new System.Drawing.Size(68, 19);
            rbLineMode.TabIndex = 3;
            rbLineMode.TabStop = true;
            rbLineMode.Text = "GL_LINE";
            rbLineMode.UseVisualStyleBackColor = true;
            rbLineMode.CheckedChanged += rbLineMode_CheckedChanged;
            // 
            // cbClip
            // 
            cbClip.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbClip.AutoSize = true;
            cbClip.Location = new System.Drawing.Point(6, 22);
            cbClip.Name = "cbClip";
            cbClip.Size = new System.Drawing.Size(79, 19);
            cbClip.TabIndex = 3;
            cbClip.Text = "Clip Plane";
            cbClip.UseVisualStyleBackColor = true;
            cbClip.CheckedChanged += cbClip_CheckedChanged;
            // 
            // cbLight
            // 
            cbLight.Anchor = System.Windows.Forms.AnchorStyles.None;
            cbLight.AutoSize = true;
            cbLight.Location = new System.Drawing.Point(6, 47);
            cbLight.Name = "cbLight";
            cbLight.Size = new System.Drawing.Size(53, 19);
            cbLight.TabIndex = 4;
            cbLight.Text = "Light";
            cbLight.UseVisualStyleBackColor = true;
            cbLight.CheckedChanged += cbLight_CheckedChanged;
            // 
            // gbOptions
            // 
            gbOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbOptions.Controls.Add(cbDrawList);
            gbOptions.Controls.Add(cbClip);
            gbOptions.Controls.Add(cbLight);
            gbOptions.Location = new System.Drawing.Point(363, 22);
            gbOptions.Name = "gbOptions";
            gbOptions.Size = new System.Drawing.Size(159, 102);
            gbOptions.TabIndex = 5;
            gbOptions.TabStop = false;
            gbOptions.Text = "Options";
            // 
            // cbDrawList
            // 
            cbDrawList.AutoSize = true;
            cbDrawList.Location = new System.Drawing.Point(6, 72);
            cbDrawList.Name = "cbDrawList";
            cbDrawList.Size = new System.Drawing.Size(103, 19);
            cbDrawList.TabIndex = 5;
            cbDrawList.Text = "Use glDrawList";
            cbDrawList.UseVisualStyleBackColor = true;
            cbDrawList.CheckedChanged += cbDrawList_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(534, 361);
            Controls.Add(gbOptions);
            Controls.Add(gbFillMode);
            Controls.Add(gbViewMode);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            gbViewMode.ResumeLayout(false);
            gbViewMode.PerformLayout();
            gbFillMode.ResumeLayout(false);
            gbFillMode.PerformLayout();
            gbOptions.ResumeLayout(false);
            gbOptions.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.GroupBox gbViewMode;
        private System.Windows.Forms.RadioButton rbOrtho;
        private System.Windows.Forms.RadioButton rbPerspective;
        private System.Windows.Forms.GroupBox gbFillMode;
        private System.Windows.Forms.RadioButton rbFillMode;
        private System.Windows.Forms.RadioButton rbLineMode;
        private System.Windows.Forms.CheckBox cbClip;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.CheckBox cbDrawList;
    }
}

