
namespace Task02
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
            horizontalUD = new System.Windows.Forms.NumericUpDown();
            verticalUD = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fillModeRB = new System.Windows.Forms.RadioButton();
            lineModeRB = new System.Windows.Forms.RadioButton();
            pointModeRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)horizontalUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalUD).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.DrawingMode = DrawingMode.Fill;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Horizontales = 1;
            renderControl1.Location = new System.Drawing.Point(0, 0);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(465, 325);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            renderControl1.Verticales = 1;
            // 
            // horizontalUD
            // 
            horizontalUD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            horizontalUD.Location = new System.Drawing.Point(572, 37);
            horizontalUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            horizontalUD.Name = "horizontalUD";
            horizontalUD.Size = new System.Drawing.Size(40, 23);
            horizontalUD.TabIndex = 1;
            horizontalUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            horizontalUD.ValueChanged += OnChangeHorizontal;
            // 
            // verticalUD
            // 
            verticalUD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            verticalUD.Location = new System.Drawing.Point(572, 66);
            verticalUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            verticalUD.Name = "verticalUD";
            verticalUD.Size = new System.Drawing.Size(40, 23);
            verticalUD.TabIndex = 2;
            verticalUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            verticalUD.ValueChanged += OnChangeVertical;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            label1.Location = new System.Drawing.Point(496, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 25);
            label1.TabIndex = 3;
            label1.Text = "Tile count:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            label2.Location = new System.Drawing.Point(484, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "horizontal";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            label3.Location = new System.Drawing.Point(484, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "vertical";
            // 
            // fillModeRB
            // 
            fillModeRB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            fillModeRB.AutoSize = true;
            fillModeRB.Checked = true;
            fillModeRB.Location = new System.Drawing.Point(496, 216);
            fillModeRB.Name = "fillModeRB";
            fillModeRB.Size = new System.Drawing.Size(74, 19);
            fillModeRB.TabIndex = 6;
            fillModeRB.TabStop = true;
            fillModeRB.Text = "Fill mode";
            fillModeRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            fillModeRB.UseVisualStyleBackColor = true;
            fillModeRB.CheckedChanged += OnFillModeCheckedChanged;
            // 
            // lineModeRB
            // 
            lineModeRB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lineModeRB.AutoSize = true;
            lineModeRB.Location = new System.Drawing.Point(496, 241);
            lineModeRB.Name = "lineModeRB";
            lineModeRB.Size = new System.Drawing.Size(81, 19);
            lineModeRB.TabIndex = 7;
            lineModeRB.Text = "Line mode";
            lineModeRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lineModeRB.UseVisualStyleBackColor = true;
            lineModeRB.CheckedChanged += OnLineModeCheckedChanged;
            // 
            // pointModeRB
            // 
            pointModeRB.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pointModeRB.AutoSize = true;
            pointModeRB.Location = new System.Drawing.Point(496, 266);
            pointModeRB.Name = "pointModeRB";
            pointModeRB.Size = new System.Drawing.Size(87, 19);
            pointModeRB.TabIndex = 8;
            pointModeRB.Text = "Point mode";
            pointModeRB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            pointModeRB.UseVisualStyleBackColor = true;
            pointModeRB.CheckedChanged += OnPointModeCheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(pointModeRB);
            Controls.Add(lineModeRB);
            Controls.Add(fillModeRB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verticalUD);
            Controls.Add(horizontalUD);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)horizontalUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown horizontalUD;
        private System.Windows.Forms.NumericUpDown verticalUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton fillModeRB;
        private System.Windows.Forms.RadioButton lineModeRB;
        private System.Windows.Forms.RadioButton pointModeRB;
    }
}

