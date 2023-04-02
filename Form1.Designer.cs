namespace GrEditor
{
    partial class FrmGrEditor
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsCursorCoordinations = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbColorBorder = new System.Windows.Forms.PictureBox();
            this.pbColorBackground = new System.Windows.Forms.PictureBox();
            this.pbColorSelectRed = new System.Windows.Forms.PictureBox();
            this.pbColorSelectBlue = new System.Windows.Forms.PictureBox();
            this.pbColorSelectGreen = new System.Windows.Forms.PictureBox();
            this.pbColorSelectYellow = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbColorSelectWhite = new System.Windows.Forms.PictureBox();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.rbCurve = new System.Windows.Forms.RadioButton();
            this.rbRightAngleTriangle = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbColorSelectGrey = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectWhite)).BeginInit();
            this.gbTools.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectGrey)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.White;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCanvas.Location = new System.Drawing.Point(242, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(1161, 665);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseDown);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            this.pbCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseUp);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(12, 614);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(224, 63);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCursorCoordinations});
            this.statusStrip.Location = new System.Drawing.Point(0, 690);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1319, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsCursorCoordinations
            // 
            this.tsCursorCoordinations.Name = "tsCursorCoordinations";
            this.tsCursorCoordinations.Size = new System.Drawing.Size(58, 17);
            this.tsCursorCoordinations.Text = "x: 0     y: 0";
            // 
            // pbColorBorder
            // 
            this.pbColorBorder.BackColor = System.Drawing.Color.Black;
            this.pbColorBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorBorder.Location = new System.Drawing.Point(12, 12);
            this.pbColorBorder.Name = "pbColorBorder";
            this.pbColorBorder.Size = new System.Drawing.Size(44, 42);
            this.pbColorBorder.TabIndex = 4;
            this.pbColorBorder.TabStop = false;
            // 
            // pbColorBackground
            // 
            this.pbColorBackground.BackColor = System.Drawing.Color.White;
            this.pbColorBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorBackground.Location = new System.Drawing.Point(62, 12);
            this.pbColorBackground.Name = "pbColorBackground";
            this.pbColorBackground.Size = new System.Drawing.Size(44, 42);
            this.pbColorBackground.TabIndex = 5;
            this.pbColorBackground.TabStop = false;
            // 
            // pbColorSelectRed
            // 
            this.pbColorSelectRed.BackColor = System.Drawing.Color.Red;
            this.pbColorSelectRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectRed.Location = new System.Drawing.Point(139, 12);
            this.pbColorSelectRed.Name = "pbColorSelectRed";
            this.pbColorSelectRed.Size = new System.Drawing.Size(21, 21);
            this.pbColorSelectRed.TabIndex = 6;
            this.pbColorSelectRed.TabStop = false;
            this.pbColorSelectRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // pbColorSelectBlue
            // 
            this.pbColorSelectBlue.BackColor = System.Drawing.Color.Blue;
            this.pbColorSelectBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectBlue.Location = new System.Drawing.Point(139, 33);
            this.pbColorSelectBlue.Name = "pbColorSelectBlue";
            this.pbColorSelectBlue.Size = new System.Drawing.Size(21, 21);
            this.pbColorSelectBlue.TabIndex = 7;
            this.pbColorSelectBlue.TabStop = false;
            this.pbColorSelectBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // pbColorSelectGreen
            // 
            this.pbColorSelectGreen.BackColor = System.Drawing.Color.Green;
            this.pbColorSelectGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectGreen.Location = new System.Drawing.Point(166, 12);
            this.pbColorSelectGreen.Name = "pbColorSelectGreen";
            this.pbColorSelectGreen.Size = new System.Drawing.Size(21, 21);
            this.pbColorSelectGreen.TabIndex = 8;
            this.pbColorSelectGreen.TabStop = false;
            this.pbColorSelectGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // pbColorSelectYellow
            // 
            this.pbColorSelectYellow.BackColor = System.Drawing.Color.Yellow;
            this.pbColorSelectYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectYellow.Location = new System.Drawing.Point(166, 33);
            this.pbColorSelectYellow.Name = "pbColorSelectYellow";
            this.pbColorSelectYellow.Size = new System.Drawing.Size(21, 21);
            this.pbColorSelectYellow.TabIndex = 9;
            this.pbColorSelectYellow.TabStop = false;
            this.pbColorSelectYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Location = new System.Drawing.Point(193, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 21);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // pbColorSelectWhite
            // 
            this.pbColorSelectWhite.BackColor = System.Drawing.Color.White;
            this.pbColorSelectWhite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectWhite.Location = new System.Drawing.Point(193, 33);
            this.pbColorSelectWhite.Name = "pbColorSelectWhite";
            this.pbColorSelectWhite.Size = new System.Drawing.Size(21, 21);
            this.pbColorSelectWhite.TabIndex = 11;
            this.pbColorSelectWhite.TabStop = false;
            this.pbColorSelectWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.rbCurve);
            this.gbTools.Controls.Add(this.rbRightAngleTriangle);
            this.gbTools.Controls.Add(this.rbTriangle);
            this.gbTools.Controls.Add(this.rbEllipse);
            this.gbTools.Controls.Add(this.rbRectangle);
            this.gbTools.Controls.Add(this.rbLine);
            this.gbTools.Location = new System.Drawing.Point(0, 61);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(236, 97);
            this.gbTools.TabIndex = 12;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tool select";
            // 
            // rbCurve
            // 
            this.rbCurve.AutoSize = true;
            this.rbCurve.Location = new System.Drawing.Point(129, 66);
            this.rbCurve.Name = "rbCurve";
            this.rbCurve.Size = new System.Drawing.Size(53, 17);
            this.rbCurve.TabIndex = 5;
            this.rbCurve.Text = "Curve";
            this.rbCurve.UseVisualStyleBackColor = true;
            this.rbCurve.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbRightAngleTriangle
            // 
            this.rbRightAngleTriangle.AutoSize = true;
            this.rbRightAngleTriangle.Location = new System.Drawing.Point(12, 66);
            this.rbRightAngleTriangle.Name = "rbRightAngleTriangle";
            this.rbRightAngleTriangle.Size = new System.Drawing.Size(116, 17);
            this.rbRightAngleTriangle.TabIndex = 4;
            this.rbRightAngleTriangle.Text = "Right angle triangle";
            this.rbRightAngleTriangle.UseVisualStyleBackColor = true;
            this.rbRightAngleTriangle.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(129, 43);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbTriangle.TabIndex = 3;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(12, 43);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 2;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            this.rbEllipse.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(129, 20);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(13, 20);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            this.rbLine.Click += new System.EventHandler(this.rbLine_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSave,
            this.tsmLoad,
            this.tsmEnd});
            this.menuStrip1.Location = new System.Drawing.Point(1319, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(51, 712);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSave
            // 
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(38, 19);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // tsmLoad
            // 
            this.tsmLoad.Name = "tsmLoad";
            this.tsmLoad.Size = new System.Drawing.Size(38, 19);
            this.tsmLoad.Text = "Load";
            this.tsmLoad.Click += new System.EventHandler(this.tsmLoad_Click);
            // 
            // tsmEnd
            // 
            this.tsmEnd.Name = "tsmEnd";
            this.tsmEnd.Size = new System.Drawing.Size(38, 19);
            this.tsmEnd.Text = "End";
            this.tsmEnd.Click += new System.EventHandler(this.tsmEnd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFD";
            // 
            // pbColorSelectGrey
            // 
            this.pbColorSelectGrey.BackColor = System.Drawing.Color.Transparent;
            this.pbColorSelectGrey.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbColorSelectGrey.Location = new System.Drawing.Point(112, 12);
            this.pbColorSelectGrey.Name = "pbColorSelectGrey";
            this.pbColorSelectGrey.Size = new System.Drawing.Size(21, 42);
            this.pbColorSelectGrey.TabIndex = 14;
            this.pbColorSelectGrey.TabStop = false;
            this.pbColorSelectGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbColorSelectRed_MouseDown);
            // 
            // FrmGrEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.Controls.Add(this.pbColorSelectGrey);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.pbColorSelectWhite);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pbColorSelectYellow);
            this.Controls.Add(this.pbColorSelectGreen);
            this.Controls.Add(this.pbColorSelectBlue);
            this.Controls.Add(this.pbColorSelectRed);
            this.Controls.Add(this.pbColorBackground);
            this.Controls.Add(this.pbColorBorder);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.pbCanvas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGrEditor";
            this.Text = "Grafický Editor - GrEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectWhite)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorSelectGrey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsCursorCoordinations;
        private System.Windows.Forms.PictureBox pbColorBorder;
        private System.Windows.Forms.PictureBox pbColorBackground;
        private System.Windows.Forms.PictureBox pbColorSelectRed;
        private System.Windows.Forms.PictureBox pbColorSelectBlue;
        private System.Windows.Forms.PictureBox pbColorSelectGreen;
        private System.Windows.Forms.PictureBox pbColorSelectYellow;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbColorSelectWhite;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.RadioButton rbCurve;
        private System.Windows.Forms.RadioButton rbRightAngleTriangle;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmEnd;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbColorSelectGrey;
    }
}

