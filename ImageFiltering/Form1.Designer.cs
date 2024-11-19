namespace ImageFiltering
{
    partial class Form1
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
            Canvas = new PictureBox();
            groupBoxArea = new GroupBox();
            BrushSizeVal = new Label();
            buttonClear = new Button();
            radioButtonPolygon = new RadioButton();
            trackBarBrushSize = new TrackBar();
            radioButtonBrush = new RadioButton();
            radioButtonWholePicture = new RadioButton();
            menuStrip = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            groupBoxFilter = new GroupBox();
            checkBoxAutoDivisor = new CheckBox();
            labelDzielnik = new Label();
            labelPrzesuniecie = new Label();
            numericUpDownShift = new NumericUpDown();
            numericUpDownDivisor = new NumericUpDown();
            numericUpDown9 = new NumericUpDown();
            numericUpDown8 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            radioButtonCustom = new RadioButton();
            radioButtonEdgeDetect = new RadioButton();
            radioButtonRelief = new RadioButton();
            radioButtonSharpen = new RadioButton();
            radioButtonBlur = new RadioButton();
            radioButtonIdentity = new RadioButton();
            buttonApply = new Button();
            ChartTable = new TableLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            groupBoxArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrushSize).BeginInit();
            menuStrip.SuspendLayout();
            groupBoxFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDivisor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.AppWorkspace;
            Canvas.Dock = DockStyle.Fill;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(665, 648);
            Canvas.SizeMode = PictureBoxSizeMode.AutoSize;
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            // 
            // groupBoxArea
            // 
            groupBoxArea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxArea.Controls.Add(BrushSizeVal);
            groupBoxArea.Controls.Add(buttonClear);
            groupBoxArea.Controls.Add(radioButtonPolygon);
            groupBoxArea.Controls.Add(trackBarBrushSize);
            groupBoxArea.Controls.Add(radioButtonBrush);
            groupBoxArea.Controls.Add(radioButtonWholePicture);
            groupBoxArea.Location = new Point(967, 31);
            groupBoxArea.Name = "groupBoxArea";
            groupBoxArea.Size = new Size(276, 185);
            groupBoxArea.TabIndex = 1;
            groupBoxArea.TabStop = false;
            groupBoxArea.Text = "Obszar zastosowania filtra";
            // 
            // BrushSizeVal
            // 
            BrushSizeVal.AutoSize = true;
            BrushSizeVal.Location = new Point(240, 83);
            BrushSizeVal.Name = "BrushSizeVal";
            BrushSizeVal.Size = new Size(17, 20);
            BrushSizeVal.TabIndex = 4;
            BrushSizeVal.Text = "1";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(149, 145);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(112, 29);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Wyczyść";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // radioButtonPolygon
            // 
            radioButtonPolygon.AutoSize = true;
            radioButtonPolygon.Location = new Point(3, 145);
            radioButtonPolygon.Name = "radioButtonPolygon";
            radioButtonPolygon.Size = new Size(89, 24);
            radioButtonPolygon.TabIndex = 3;
            radioButtonPolygon.TabStop = true;
            radioButtonPolygon.Text = "Wielokąt";
            radioButtonPolygon.UseVisualStyleBackColor = true;
            // 
            // trackBarBrushSize
            // 
            trackBarBrushSize.Location = new Point(6, 83);
            trackBarBrushSize.Name = "trackBarBrushSize";
            trackBarBrushSize.Size = new Size(228, 56);
            trackBarBrushSize.TabIndex = 2;
            // 
            // radioButtonBrush
            // 
            radioButtonBrush.AutoSize = true;
            radioButtonBrush.Location = new Point(3, 53);
            radioButtonBrush.Name = "radioButtonBrush";
            radioButtonBrush.Size = new Size(124, 24);
            radioButtonBrush.TabIndex = 1;
            radioButtonBrush.TabStop = true;
            radioButtonBrush.Text = "Pędzel kołowy";
            radioButtonBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonWholePicture
            // 
            radioButtonWholePicture.AutoSize = true;
            radioButtonWholePicture.Location = new Point(3, 23);
            radioButtonWholePicture.Name = "radioButtonWholePicture";
            radioButtonWholePicture.Size = new Size(100, 24);
            radioButtonWholePicture.TabIndex = 0;
            radioButtonWholePicture.TabStop = true;
            radioButtonWholePicture.Text = "Cały obraz";
            radioButtonWholePicture.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1251, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            plikToolStripMenuItem.Click += plikToolStripMenuItem_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(checkBoxAutoDivisor);
            groupBoxFilter.Controls.Add(labelDzielnik);
            groupBoxFilter.Controls.Add(labelPrzesuniecie);
            groupBoxFilter.Controls.Add(numericUpDownShift);
            groupBoxFilter.Controls.Add(numericUpDownDivisor);
            groupBoxFilter.Controls.Add(numericUpDown9);
            groupBoxFilter.Controls.Add(numericUpDown8);
            groupBoxFilter.Controls.Add(numericUpDown7);
            groupBoxFilter.Controls.Add(numericUpDown6);
            groupBoxFilter.Controls.Add(numericUpDown5);
            groupBoxFilter.Controls.Add(numericUpDown4);
            groupBoxFilter.Controls.Add(numericUpDown3);
            groupBoxFilter.Controls.Add(numericUpDown2);
            groupBoxFilter.Controls.Add(numericUpDown1);
            groupBoxFilter.Controls.Add(radioButtonCustom);
            groupBoxFilter.Controls.Add(radioButtonEdgeDetect);
            groupBoxFilter.Controls.Add(radioButtonRelief);
            groupBoxFilter.Controls.Add(radioButtonSharpen);
            groupBoxFilter.Controls.Add(radioButtonBlur);
            groupBoxFilter.Controls.Add(radioButtonIdentity);
            groupBoxFilter.Location = new Point(967, 222);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(276, 415);
            groupBoxFilter.TabIndex = 3;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Wybór filtra macierzowego";
            // 
            // checkBoxAutoDivisor
            // 
            checkBoxAutoDivisor.AutoSize = true;
            checkBoxAutoDivisor.Location = new Point(6, 386);
            checkBoxAutoDivisor.Name = "checkBoxAutoDivisor";
            checkBoxAutoDivisor.Size = new Size(276, 24);
            checkBoxAutoDivisor.TabIndex = 4;
            checkBoxAutoDivisor.Text = "Automatyczne wyznaczanie dzielnika";
            checkBoxAutoDivisor.UseVisualStyleBackColor = true;
            // 
            // labelDzielnik
            // 
            labelDzielnik.AutoSize = true;
            labelDzielnik.Location = new Point(6, 355);
            labelDzielnik.Name = "labelDzielnik";
            labelDzielnik.Size = new Size(62, 20);
            labelDzielnik.TabIndex = 14;
            labelDzielnik.Text = "Dzielnik";
            // 
            // labelPrzesuniecie
            // 
            labelPrzesuniecie.AutoSize = true;
            labelPrzesuniecie.Location = new Point(6, 322);
            labelPrzesuniecie.Name = "labelPrzesuniecie";
            labelPrzesuniecie.Size = new Size(90, 20);
            labelPrzesuniecie.TabIndex = 4;
            labelPrzesuniecie.Text = "Przesunięcie";
            // 
            // numericUpDownShift
            // 
            numericUpDownShift.Location = new Point(111, 320);
            numericUpDownShift.Name = "numericUpDownShift";
            numericUpDownShift.Size = new Size(150, 27);
            numericUpDownShift.TabIndex = 4;
            // 
            // numericUpDownDivisor
            // 
            numericUpDownDivisor.Location = new Point(111, 353);
            numericUpDownDivisor.Name = "numericUpDownDivisor";
            numericUpDownDivisor.Size = new Size(150, 27);
            numericUpDownDivisor.TabIndex = 5;
            // 
            // numericUpDown9
            // 
            numericUpDown9.DecimalPlaces = 4;
            numericUpDown9.Location = new Point(180, 272);
            numericUpDown9.Name = "numericUpDown9";
            numericUpDown9.Size = new Size(81, 27);
            numericUpDown9.TabIndex = 13;
            // 
            // numericUpDown8
            // 
            numericUpDown8.DecimalPlaces = 4;
            numericUpDown8.Location = new Point(93, 272);
            numericUpDown8.Name = "numericUpDown8";
            numericUpDown8.Size = new Size(81, 27);
            numericUpDown8.TabIndex = 12;
            // 
            // numericUpDown7
            // 
            numericUpDown7.DecimalPlaces = 4;
            numericUpDown7.Location = new Point(6, 272);
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(81, 27);
            numericUpDown7.TabIndex = 11;
            // 
            // numericUpDown6
            // 
            numericUpDown6.DecimalPlaces = 4;
            numericUpDown6.Location = new Point(180, 239);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(81, 27);
            numericUpDown6.TabIndex = 10;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 4;
            numericUpDown5.Location = new Point(93, 239);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(81, 27);
            numericUpDown5.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 4;
            numericUpDown4.Location = new Point(6, 239);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(81, 27);
            numericUpDown4.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 4;
            numericUpDown3.Location = new Point(180, 206);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(81, 27);
            numericUpDown3.TabIndex = 7;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 4;
            numericUpDown2.Location = new Point(93, 206);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(81, 27);
            numericUpDown2.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 4;
            numericUpDown1.Location = new Point(6, 206);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(81, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(3, 176);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(77, 24);
            radioButtonCustom.TabIndex = 5;
            radioButtonCustom.TabStop = true;
            radioButtonCustom.Text = "Własny";
            radioButtonCustom.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdgeDetect
            // 
            radioButtonEdgeDetect.AutoSize = true;
            radioButtonEdgeDetect.Location = new Point(3, 146);
            radioButtonEdgeDetect.Name = "radioButtonEdgeDetect";
            radioButtonEdgeDetect.Size = new Size(174, 24);
            radioButtonEdgeDetect.TabIndex = 4;
            radioButtonEdgeDetect.TabStop = true;
            radioButtonEdgeDetect.Text = "Wykrywanie Krawędzi";
            radioButtonEdgeDetect.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelief
            // 
            radioButtonRelief.AutoSize = true;
            radioButtonRelief.Location = new Point(3, 116);
            radioButtonRelief.Name = "radioButtonRelief";
            radioButtonRelief.Size = new Size(116, 24);
            radioButtonRelief.TabIndex = 3;
            radioButtonRelief.TabStop = true;
            radioButtonRelief.Text = "Płaskorzeźba";
            radioButtonRelief.UseVisualStyleBackColor = true;
            // 
            // radioButtonSharpen
            // 
            radioButtonSharpen.AutoSize = true;
            radioButtonSharpen.Location = new Point(3, 86);
            radioButtonSharpen.Name = "radioButtonSharpen";
            radioButtonSharpen.Size = new Size(111, 24);
            radioButtonSharpen.TabIndex = 2;
            radioButtonSharpen.TabStop = true;
            radioButtonSharpen.Text = "Wyostrzanie";
            radioButtonSharpen.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlur
            // 
            radioButtonBlur.AutoSize = true;
            radioButtonBlur.Location = new Point(3, 56);
            radioButtonBlur.Name = "radioButtonBlur";
            radioButtonBlur.Size = new Size(94, 24);
            radioButtonBlur.TabIndex = 1;
            radioButtonBlur.TabStop = true;
            radioButtonBlur.Text = "Rozmycie";
            radioButtonBlur.UseVisualStyleBackColor = true;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Location = new Point(3, 26);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(115, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "Identyczność";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonApply.Location = new Point(967, 643);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(276, 29);
            buttonApply.TabIndex = 15;
            buttonApply.Text = "Zastosuj";
            buttonApply.UseVisualStyleBackColor = true;
            // 
            // ChartTable
            // 
            ChartTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ChartTable.Location = new Point(671, 31);
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 3;
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            ChartTable.Size = new Size(290, 648);
            ChartTable.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(Canvas);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 648);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 679);
            Controls.Add(panel1);
            Controls.Add(ChartTable);
            Controls.Add(buttonApply);
            Controls.Add(groupBoxFilter);
            Controls.Add(groupBoxArea);
            Controls.Add(menuStrip);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            groupBoxArea.ResumeLayout(false);
            groupBoxArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarBrushSize).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            groupBoxFilter.ResumeLayout(false);
            groupBoxFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDivisor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown9).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown8).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Canvas;
        private GroupBox groupBoxArea;
        private TrackBar trackBarBrushSize;
        private RadioButton radioButtonBrush;
        private RadioButton radioButtonWholePicture;
        private Label BrushSizeVal;
        private Button buttonClear;
        private RadioButton radioButtonPolygon;
        private MenuStrip menuStrip;
        private ToolStripMenuItem plikToolStripMenuItem;
        private GroupBox groupBoxFilter;
        private RadioButton radioButtonCustom;
        private RadioButton radioButtonEdgeDetect;
        private RadioButton radioButtonRelief;
        private RadioButton radioButtonSharpen;
        private RadioButton radioButtonBlur;
        private RadioButton radioButtonIdentity;
        private Label labelDzielnik;
        private Label labelPrzesuniecie;
        private NumericUpDown numericUpDownShift;
        private NumericUpDown numericUpDownDivisor;
        private NumericUpDown numericUpDown9;
        private NumericUpDown numericUpDown8;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBoxAutoDivisor;
        private Button buttonApply;
        private TableLayoutPanel ChartTable;
        private Panel panel1;
    }
}
