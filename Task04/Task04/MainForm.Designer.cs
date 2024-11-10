
namespace Task04
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
            ControlBox = new System.Windows.Forms.GroupBox();
            btnClearLine = new System.Windows.Forms.Button();
            figureBox = new System.Windows.Forms.GroupBox();
            numB = new System.Windows.Forms.NumericUpDown();
            numA = new System.Windows.Forms.NumericUpDown();
            rbtn2 = new System.Windows.Forms.RadioButton();
            rbtn1 = new System.Windows.Forms.RadioButton();
            ControlBox.SuspendLayout();
            figureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numA).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.A = 1D;
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.B = 0.7D;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ChosedFigure = false;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.IsUp = true;
            renderControl1.Length = 1.5D;
            renderControl1.LineExist = false;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(379, 300);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.Xle = 0D;
            renderControl1.Xls = 0D;
            renderControl1.Yle = 0D;
            renderControl1.Yls = 0D;
            renderControl1.MouseDown += OnDown;
            renderControl1.MouseMove += OnMove;
            renderControl1.MouseUp += OnUp;
            // 
            // ControlBox
            // 
            ControlBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ControlBox.Controls.Add(btnClearLine);
            ControlBox.Location = new System.Drawing.Point(407, 12);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new System.Drawing.Size(205, 67);
            ControlBox.TabIndex = 1;
            ControlBox.TabStop = false;
            ControlBox.Text = "Control";
            // 
            // btnClearLine
            // 
            btnClearLine.Enabled = false;
            btnClearLine.Location = new System.Drawing.Point(13, 22);
            btnClearLine.Name = "btnClearLine";
            btnClearLine.Size = new System.Drawing.Size(186, 26);
            btnClearLine.TabIndex = 0;
            btnClearLine.Text = "Clear Line";
            btnClearLine.UseVisualStyleBackColor = true;
            btnClearLine.Click += btnClearLine_Click;
            // 
            // figureBox
            // 
            figureBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            figureBox.Controls.Add(numB);
            figureBox.Controls.Add(numA);
            figureBox.Controls.Add(rbtn2);
            figureBox.Controls.Add(rbtn1);
            figureBox.Location = new System.Drawing.Point(407, 85);
            figureBox.Name = "figureBox";
            figureBox.Size = new System.Drawing.Size(205, 152);
            figureBox.TabIndex = 2;
            figureBox.TabStop = false;
            figureBox.Text = "Figure";
            // 
            // numB
            // 
            numB.DecimalPlaces = 1;
            numB.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numB.Location = new System.Drawing.Point(13, 102);
            numB.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numB.Name = "numB";
            numB.Size = new System.Drawing.Size(120, 23);
            numB.TabIndex = 4;
            numB.Value = new decimal(new int[] { 7, 0, 0, 65536 });
            numB.ValueChanged += OnChangedB;
            // 
            // numA
            // 
            numA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            numA.DecimalPlaces = 1;
            numA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numA.Location = new System.Drawing.Point(13, 73);
            numA.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numA.Name = "numA";
            numA.Size = new System.Drawing.Size(120, 23);
            numA.TabIndex = 3;
            numA.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numA.ValueChanged += OnChangedA;
            // 
            // rbtn2
            // 
            rbtn2.AutoSize = true;
            rbtn2.Location = new System.Drawing.Point(11, 48);
            rbtn2.Name = "rbtn2";
            rbtn2.Size = new System.Drawing.Size(71, 19);
            rbtn2.TabIndex = 1;
            rbtn2.Text = "Parabola";
            rbtn2.UseVisualStyleBackColor = true;
            rbtn2.CheckedChanged += OnCheckedParabola;
            // 
            // rbtn1
            // 
            rbtn1.AutoSize = true;
            rbtn1.Checked = true;
            rbtn1.Location = new System.Drawing.Point(11, 23);
            rbtn1.Name = "rbtn1";
            rbtn1.Size = new System.Drawing.Size(55, 19);
            rbtn1.TabIndex = 0;
            rbtn1.TabStop = true;
            rbtn1.Text = "Elipse";
            rbtn1.UseVisualStyleBackColor = true;
            rbtn1.CheckedChanged += OnCheckedElipse;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 324);
            Controls.Add(figureBox);
            Controls.Add(ControlBox);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ControlBox.ResumeLayout(false);
            figureBox.ResumeLayout(false);
            figureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.GroupBox ControlBox;
        private System.Windows.Forms.Button btnClearLine;
        private System.Windows.Forms.GroupBox figureBox;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numB;
    }
}

