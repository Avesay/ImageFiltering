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
            trackBarBrushSize = new TrackBar();
            radioButtonBrush = new RadioButton();
            radioButtonWholePicture = new RadioButton();
            menuStrip = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            wybierzObrazToolStripMenuItem = new ToolStripMenuItem();
            zapiszObrazToolStripMenuItem = new ToolStripMenuItem();
            groupBoxFilter = new GroupBox();
            checkBoxAutoDivisor = new CheckBox();
            labelDzielnik = new Label();
            labelPrzesuniecie = new Label();
            numericUpDownShift = new NumericUpDown();
            numericUpDownDivisor = new NumericUpDown();
            numericUpDown22 = new NumericUpDown();
            numericUpDown21 = new NumericUpDown();
            numericUpDown20 = new NumericUpDown();
            numericUpDown12 = new NumericUpDown();
            numericUpDown11 = new NumericUpDown();
            numericUpDown10 = new NumericUpDown();
            numericUpDown02 = new NumericUpDown();
            numericUpDown01 = new NumericUpDown();
            numericUpDown00 = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown02).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown01).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown00).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = SystemColors.AppWorkspace;
            Canvas.Location = new Point(0, 0);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(665, 648);
            Canvas.SizeMode = PictureBoxSizeMode.AutoSize;
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.Paint += Canvas_Paint;
            // 
            // groupBoxArea
            // 
            groupBoxArea.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxArea.Controls.Add(BrushSizeVal);
            groupBoxArea.Controls.Add(buttonClear);
            groupBoxArea.Controls.Add(trackBarBrushSize);
            groupBoxArea.Controls.Add(radioButtonBrush);
            groupBoxArea.Controls.Add(radioButtonWholePicture);
            groupBoxArea.Location = new Point(977, 31);
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
            buttonClear.Click += buttonClear_Click;
            // 
            // trackBarBrushSize
            // 
            trackBarBrushSize.Location = new Point(6, 83);
            trackBarBrushSize.Maximum = 100;
            trackBarBrushSize.Name = "trackBarBrushSize";
            trackBarBrushSize.Size = new Size(228, 56);
            trackBarBrushSize.TabIndex = 2;
            trackBarBrushSize.Value = 10;
            trackBarBrushSize.Scroll += trackBarBrushSize_Scroll;
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
            radioButtonWholePicture.Checked = true;
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
            menuStrip.Size = new Size(1261, 28);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wybierzObrazToolStripMenuItem, zapiszObrazToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // wybierzObrazToolStripMenuItem
            // 
            wybierzObrazToolStripMenuItem.Name = "wybierzObrazToolStripMenuItem";
            wybierzObrazToolStripMenuItem.Size = new Size(188, 26);
            wybierzObrazToolStripMenuItem.Text = "Wybierz obraz";
            wybierzObrazToolStripMenuItem.Click += plikToolStripMenuItem_Click;
            // 
            // zapiszObrazToolStripMenuItem
            // 
            zapiszObrazToolStripMenuItem.Name = "zapiszObrazToolStripMenuItem";
            zapiszObrazToolStripMenuItem.Size = new Size(188, 26);
            zapiszObrazToolStripMenuItem.Text = "Zapisz Obraz";
            zapiszObrazToolStripMenuItem.Click += zapiszObrazToolStripMenuItem_Click;
            // 
            // groupBoxFilter
            // 
            groupBoxFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFilter.Controls.Add(checkBoxAutoDivisor);
            groupBoxFilter.Controls.Add(labelDzielnik);
            groupBoxFilter.Controls.Add(labelPrzesuniecie);
            groupBoxFilter.Controls.Add(numericUpDownShift);
            groupBoxFilter.Controls.Add(numericUpDownDivisor);
            groupBoxFilter.Controls.Add(numericUpDown22);
            groupBoxFilter.Controls.Add(numericUpDown21);
            groupBoxFilter.Controls.Add(numericUpDown20);
            groupBoxFilter.Controls.Add(numericUpDown12);
            groupBoxFilter.Controls.Add(numericUpDown11);
            groupBoxFilter.Controls.Add(numericUpDown10);
            groupBoxFilter.Controls.Add(numericUpDown02);
            groupBoxFilter.Controls.Add(numericUpDown01);
            groupBoxFilter.Controls.Add(numericUpDown00);
            groupBoxFilter.Controls.Add(radioButtonCustom);
            groupBoxFilter.Controls.Add(radioButtonEdgeDetect);
            groupBoxFilter.Controls.Add(radioButtonRelief);
            groupBoxFilter.Controls.Add(radioButtonSharpen);
            groupBoxFilter.Controls.Add(radioButtonBlur);
            groupBoxFilter.Controls.Add(radioButtonIdentity);
            groupBoxFilter.Location = new Point(977, 222);
            groupBoxFilter.Name = "groupBoxFilter";
            groupBoxFilter.Size = new Size(276, 415);
            groupBoxFilter.TabIndex = 3;
            groupBoxFilter.TabStop = false;
            groupBoxFilter.Text = "Wybór filtra macierzowego";
            // 
            // checkBoxAutoDivisor
            // 
            checkBoxAutoDivisor.AutoSize = true;
            checkBoxAutoDivisor.Checked = true;
            checkBoxAutoDivisor.CheckState = CheckState.Checked;
            checkBoxAutoDivisor.Location = new Point(6, 386);
            checkBoxAutoDivisor.Name = "checkBoxAutoDivisor";
            checkBoxAutoDivisor.Size = new Size(276, 24);
            checkBoxAutoDivisor.TabIndex = 4;
            checkBoxAutoDivisor.Text = "Automatyczne wyznaczanie dzielnika";
            checkBoxAutoDivisor.UseVisualStyleBackColor = true;
            checkBoxAutoDivisor.CheckedChanged += checkBoxAutoDivisor_CheckedChanged;
            // 
            // labelDzielnik
            // 
            labelDzielnik.AutoSize = true;
            labelDzielnik.Enabled = false;
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
            numericUpDownDivisor.DecimalPlaces = 6;
            numericUpDownDivisor.Enabled = false;
            numericUpDownDivisor.Location = new Point(111, 353);
            numericUpDownDivisor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDivisor.Name = "numericUpDownDivisor";
            numericUpDownDivisor.Size = new Size(150, 27);
            numericUpDownDivisor.TabIndex = 5;
            numericUpDownDivisor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown22
            // 
            numericUpDown22.DecimalPlaces = 4;
            numericUpDown22.Enabled = false;
            numericUpDown22.Location = new Point(180, 272);
            numericUpDown22.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown22.Name = "numericUpDown22";
            numericUpDown22.Size = new Size(81, 27);
            numericUpDown22.TabIndex = 13;
            numericUpDown22.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown21
            // 
            numericUpDown21.DecimalPlaces = 4;
            numericUpDown21.Enabled = false;
            numericUpDown21.Location = new Point(93, 272);
            numericUpDown21.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown21.Name = "numericUpDown21";
            numericUpDown21.Size = new Size(81, 27);
            numericUpDown21.TabIndex = 12;
            numericUpDown21.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown20
            // 
            numericUpDown20.DecimalPlaces = 4;
            numericUpDown20.Enabled = false;
            numericUpDown20.Location = new Point(6, 272);
            numericUpDown20.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown20.Name = "numericUpDown20";
            numericUpDown20.Size = new Size(81, 27);
            numericUpDown20.TabIndex = 11;
            numericUpDown20.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown12
            // 
            numericUpDown12.DecimalPlaces = 4;
            numericUpDown12.Enabled = false;
            numericUpDown12.Location = new Point(180, 239);
            numericUpDown12.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown12.Name = "numericUpDown12";
            numericUpDown12.Size = new Size(81, 27);
            numericUpDown12.TabIndex = 10;
            numericUpDown12.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown11
            // 
            numericUpDown11.DecimalPlaces = 4;
            numericUpDown11.Enabled = false;
            numericUpDown11.Location = new Point(93, 239);
            numericUpDown11.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown11.Name = "numericUpDown11";
            numericUpDown11.Size = new Size(81, 27);
            numericUpDown11.TabIndex = 9;
            numericUpDown11.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown10
            // 
            numericUpDown10.DecimalPlaces = 4;
            numericUpDown10.Enabled = false;
            numericUpDown10.Location = new Point(6, 239);
            numericUpDown10.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown10.Name = "numericUpDown10";
            numericUpDown10.Size = new Size(81, 27);
            numericUpDown10.TabIndex = 8;
            numericUpDown10.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown02
            // 
            numericUpDown02.DecimalPlaces = 4;
            numericUpDown02.Enabled = false;
            numericUpDown02.Location = new Point(180, 206);
            numericUpDown02.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown02.Name = "numericUpDown02";
            numericUpDown02.Size = new Size(81, 27);
            numericUpDown02.TabIndex = 7;
            numericUpDown02.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown01
            // 
            numericUpDown01.DecimalPlaces = 4;
            numericUpDown01.Enabled = false;
            numericUpDown01.Location = new Point(93, 206);
            numericUpDown01.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown01.Name = "numericUpDown01";
            numericUpDown01.Size = new Size(81, 27);
            numericUpDown01.TabIndex = 6;
            numericUpDown01.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown00
            // 
            numericUpDown00.DecimalPlaces = 4;
            numericUpDown00.Enabled = false;
            numericUpDown00.Location = new Point(6, 206);
            numericUpDown00.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown00.Name = "numericUpDown00";
            numericUpDown00.Size = new Size(81, 27);
            numericUpDown00.TabIndex = 4;
            numericUpDown00.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radioButtonCustom
            // 
            radioButtonCustom.AutoSize = true;
            radioButtonCustom.Location = new Point(3, 176);
            radioButtonCustom.Name = "radioButtonCustom";
            radioButtonCustom.Size = new Size(77, 24);
            radioButtonCustom.TabIndex = 5;
            radioButtonCustom.Text = "Własny";
            radioButtonCustom.UseVisualStyleBackColor = true;
            radioButtonCustom.CheckedChanged += radioButtonCustom_CheckedChanged;
            // 
            // radioButtonEdgeDetect
            // 
            radioButtonEdgeDetect.AutoSize = true;
            radioButtonEdgeDetect.Location = new Point(3, 146);
            radioButtonEdgeDetect.Name = "radioButtonEdgeDetect";
            radioButtonEdgeDetect.Size = new Size(174, 24);
            radioButtonEdgeDetect.TabIndex = 4;
            radioButtonEdgeDetect.Text = "Wykrywanie Krawędzi";
            radioButtonEdgeDetect.UseVisualStyleBackColor = true;
            radioButtonEdgeDetect.CheckedChanged += radioButtonEdgeDetect_CheckedChanged;
            // 
            // radioButtonRelief
            // 
            radioButtonRelief.AutoSize = true;
            radioButtonRelief.Location = new Point(3, 116);
            radioButtonRelief.Name = "radioButtonRelief";
            radioButtonRelief.Size = new Size(116, 24);
            radioButtonRelief.TabIndex = 3;
            radioButtonRelief.Text = "Płaskorzeźba";
            radioButtonRelief.UseVisualStyleBackColor = true;
            radioButtonRelief.CheckedChanged += radioButtonRelief_CheckedChanged;
            // 
            // radioButtonSharpen
            // 
            radioButtonSharpen.AutoSize = true;
            radioButtonSharpen.Location = new Point(3, 86);
            radioButtonSharpen.Name = "radioButtonSharpen";
            radioButtonSharpen.Size = new Size(111, 24);
            radioButtonSharpen.TabIndex = 2;
            radioButtonSharpen.Text = "Wyostrzanie";
            radioButtonSharpen.UseVisualStyleBackColor = true;
            radioButtonSharpen.CheckedChanged += radioButtonSharpen_CheckedChanged;
            // 
            // radioButtonBlur
            // 
            radioButtonBlur.AutoSize = true;
            radioButtonBlur.Location = new Point(3, 56);
            radioButtonBlur.Name = "radioButtonBlur";
            radioButtonBlur.Size = new Size(94, 24);
            radioButtonBlur.TabIndex = 1;
            radioButtonBlur.Text = "Rozmycie";
            radioButtonBlur.UseVisualStyleBackColor = true;
            radioButtonBlur.CheckedChanged += radioButtonBlur_CheckedChanged;
            // 
            // radioButtonIdentity
            // 
            radioButtonIdentity.AutoSize = true;
            radioButtonIdentity.Checked = true;
            radioButtonIdentity.Location = new Point(3, 26);
            radioButtonIdentity.Name = "radioButtonIdentity";
            radioButtonIdentity.Size = new Size(115, 24);
            radioButtonIdentity.TabIndex = 0;
            radioButtonIdentity.TabStop = true;
            radioButtonIdentity.Text = "Identyczność";
            radioButtonIdentity.UseVisualStyleBackColor = true;
            radioButtonIdentity.CheckedChanged += radioButtonIdentity_CheckedChanged;
            // 
            // buttonApply
            // 
            buttonApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonApply.Location = new Point(977, 643);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(276, 29);
            buttonApply.TabIndex = 15;
            buttonApply.Text = "Zastosuj";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // ChartTable
            // 
            ChartTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChartTable.ColumnCount = 1;
            ChartTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ChartTable.Location = new Point(700, 31);
            ChartTable.Name = "ChartTable";
            ChartTable.RowCount = 3;
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            ChartTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            ChartTable.Size = new Size(271, 648);
            ChartTable.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(Canvas);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 648);
            panel1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 679);
            Controls.Add(panel1);
            Controls.Add(ChartTable);
            Controls.Add(buttonApply);
            Controls.Add(groupBoxFilter);
            Controls.Add(groupBoxArea);
            Controls.Add(menuStrip);
            DoubleBuffered = true;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown22).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown21).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown20).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown12).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown11).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown10).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown02).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown01).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown00).EndInit();
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
        private NumericUpDown numericUpDown22;
        private NumericUpDown numericUpDown21;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown10;
        private NumericUpDown numericUpDown02;
        private NumericUpDown numericUpDown01;
        private NumericUpDown numericUpDown00;
        private CheckBox checkBoxAutoDivisor;
        private Button buttonApply;
        private TableLayoutPanel ChartTable;
        private Panel panel1;
        private ToolStripMenuItem wybierzObrazToolStripMenuItem;
        private ToolStripMenuItem zapiszObrazToolStripMenuItem;
    }
}
