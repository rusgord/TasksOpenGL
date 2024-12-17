
namespace test1
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
            this.rc = new test1.RenderControl();
            this.SuspendLayout();
            // 
            // rc
            // 
            this.rc.BackColor = System.Drawing.Color.SlateGray;
            this.rc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rc.ForeColor = System.Drawing.Color.White;
            this.rc.Location = new System.Drawing.Point(0, 0);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(624, 324);
            this.rc.TabIndex = 0;
            this.rc.TextCodePage = 1251;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 324);
            this.Controls.Add(this.rc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private RenderControl rc;
    }
}

