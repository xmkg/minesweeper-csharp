namespace Mine_Field
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MineField = new System.Windows.Forms.Panel();
            this.topbox = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Label();
            this.imageListBtn1 = new System.Windows.Forms.ImageList(this.components);
            this.mfMineCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mfHeight = new System.Windows.Forms.NumericUpDown();
            this.chbCustom = new System.Windows.Forms.Label();
            this.imageListbtn2 = new System.Windows.Forms.ImageList(this.components);
            this.chbIntermediate = new System.Windows.Forms.Label();
            this.chbExpert = new System.Windows.Forms.Label();
            this.mfWidth = new System.Windows.Forms.NumericUpDown();
            this.chbBeginner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMulti = new System.Windows.Forms.Label();
            this.xxxx = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblMultiSec = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFlags = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tmrElapsed = new System.Windows.Forms.Timer(this.components);
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.imageListSquareBtn = new System.Windows.Forms.ImageList(this.components);
            this.tmrMulti = new System.Windows.Forms.Timer(this.components);
            this.topbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfMineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfWidth)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MineField
            // 
            this.MineField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MineField.BackColor = System.Drawing.Color.Transparent;
            this.MineField.Location = new System.Drawing.Point(407, 262);
            this.MineField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MineField.Name = "MineField";
            this.MineField.Size = new System.Drawing.Size(0, 0);
            this.MineField.TabIndex = 1;
            this.MineField.Visible = false;
            this.MineField.Paint += new System.Windows.Forms.PaintEventHandler(this.MineField_Paint);
            // 
            // topbox
            // 
            this.topbox.BackColor = System.Drawing.Color.Transparent;
            this.topbox.Controls.Add(this.btnNewGame);
            this.topbox.Controls.Add(this.mfMineCount);
            this.topbox.Controls.Add(this.label1);
            this.topbox.Controls.Add(this.mfHeight);
            this.topbox.Controls.Add(this.chbCustom);
            this.topbox.Controls.Add(this.chbIntermediate);
            this.topbox.Controls.Add(this.chbExpert);
            this.topbox.Controls.Add(this.mfWidth);
            this.topbox.Controls.Add(this.chbBeginner);
            this.topbox.Controls.Add(this.label2);
            this.topbox.Controls.Add(this.label3);
            this.topbox.Controls.Add(this.LeftPanel);
            this.topbox.Controls.Add(this.RightPanel);
            this.topbox.Location = new System.Drawing.Point(16, 15);
            this.topbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topbox.Name = "topbox";
            this.topbox.Size = new System.Drawing.Size(667, 160);
            this.topbox.TabIndex = 2;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewGame.ImageIndex = 0;
            this.btnNewGame.ImageList = this.imageListBtn1;
            this.btnNewGame.Location = new System.Drawing.Point(227, 14);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(195, 48);
            this.btnNewGame.TabIndex = 8;
            this.btnNewGame.Tag = "0";
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewGame.Click += new System.EventHandler(this.label5_Click);
            this.btnNewGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDownEvent);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.GeneralMouseEnterEvent);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.GeneralMouseLeaveEvent);
            this.btnNewGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUpEvent);
            // 
            // imageListBtn1
            // 
            this.imageListBtn1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtn1.ImageStream")));
            this.imageListBtn1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtn1.Images.SetKeyName(0, "button1_normal.png");
            this.imageListBtn1.Images.SetKeyName(1, "button1_on.png");
            this.imageListBtn1.Images.SetKeyName(2, "button1_down.png");
            this.imageListBtn1.Images.SetKeyName(3, "button1_flash.png");
            this.imageListBtn1.Images.SetKeyName(4, "button1_flash2.png");
            // 
            // mfMineCount
            // 
            this.mfMineCount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mfMineCount.ForeColor = System.Drawing.Color.Gold;
            this.mfMineCount.Location = new System.Drawing.Point(456, 123);
            this.mfMineCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mfMineCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.mfMineCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mfMineCount.Name = "mfMineCount";
            this.mfMineCount.Size = new System.Drawing.Size(61, 22);
            this.mfMineCount.TabIndex = 5;
            this.mfMineCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mfMineCount.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(264, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mfHeight
            // 
            this.mfHeight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mfHeight.ForeColor = System.Drawing.Color.Gold;
            this.mfHeight.Location = new System.Drawing.Point(191, 123);
            this.mfHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mfHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.mfHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mfHeight.Name = "mfHeight";
            this.mfHeight.Size = new System.Drawing.Size(61, 22);
            this.mfHeight.TabIndex = 3;
            this.mfHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.mfHeight.Visible = false;
            // 
            // chbCustom
            // 
            this.chbCustom.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCustom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbCustom.ImageIndex = 0;
            this.chbCustom.ImageList = this.imageListbtn2;
            this.chbCustom.Location = new System.Drawing.Point(465, 78);
            this.chbCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chbCustom.Name = "chbCustom";
            this.chbCustom.Size = new System.Drawing.Size(123, 37);
            this.chbCustom.TabIndex = 12;
            this.chbCustom.Tag = "0";
            this.chbCustom.Text = "Custom";
            this.chbCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbCustom.Click += new System.EventHandler(this.CheckButtonClickEvent);
            this.chbCustom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDownEvent);
            this.chbCustom.MouseEnter += new System.EventHandler(this.GeneralMouseEnterEvent);
            this.chbCustom.MouseLeave += new System.EventHandler(this.GeneralMouseLeaveEvent);
            this.chbCustom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUpEvent);
            // 
            // imageListbtn2
            // 
            this.imageListbtn2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListbtn2.ImageStream")));
            this.imageListbtn2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListbtn2.Images.SetKeyName(0, "button2.png");
            this.imageListbtn2.Images.SetKeyName(1, "button2_on.png");
            this.imageListbtn2.Images.SetKeyName(2, "button2_down.png");
            this.imageListbtn2.Images.SetKeyName(3, "button2_flash.png");
            this.imageListbtn2.Images.SetKeyName(4, "button2_flash2.png");
            this.imageListbtn2.Images.SetKeyName(5, "button2_normal.png");
            // 
            // chbIntermediate
            // 
            this.chbIntermediate.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIntermediate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbIntermediate.ImageIndex = 0;
            this.chbIntermediate.ImageList = this.imageListbtn2;
            this.chbIntermediate.Location = new System.Drawing.Point(204, 76);
            this.chbIntermediate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chbIntermediate.Name = "chbIntermediate";
            this.chbIntermediate.Size = new System.Drawing.Size(123, 37);
            this.chbIntermediate.TabIndex = 10;
            this.chbIntermediate.Tag = "0";
            this.chbIntermediate.Text = "Intermediate";
            this.chbIntermediate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbIntermediate.Click += new System.EventHandler(this.CheckButtonClickEvent);
            this.chbIntermediate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDownEvent);
            this.chbIntermediate.MouseEnter += new System.EventHandler(this.GeneralMouseEnterEvent);
            this.chbIntermediate.MouseLeave += new System.EventHandler(this.GeneralMouseLeaveEvent);
            this.chbIntermediate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUpEvent);
            // 
            // chbExpert
            // 
            this.chbExpert.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExpert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbExpert.ImageIndex = 0;
            this.chbExpert.ImageList = this.imageListbtn2;
            this.chbExpert.Location = new System.Drawing.Point(335, 76);
            this.chbExpert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chbExpert.Name = "chbExpert";
            this.chbExpert.Size = new System.Drawing.Size(123, 37);
            this.chbExpert.TabIndex = 11;
            this.chbExpert.Tag = "0";
            this.chbExpert.Text = "Expert";
            this.chbExpert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbExpert.Click += new System.EventHandler(this.CheckButtonClickEvent);
            this.chbExpert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDownEvent);
            this.chbExpert.MouseEnter += new System.EventHandler(this.GeneralMouseEnterEvent);
            this.chbExpert.MouseLeave += new System.EventHandler(this.GeneralMouseLeaveEvent);
            this.chbExpert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUpEvent);
            // 
            // mfWidth
            // 
            this.mfWidth.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mfWidth.ForeColor = System.Drawing.Color.Gold;
            this.mfWidth.Location = new System.Drawing.Point(325, 123);
            this.mfWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mfWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.mfWidth.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mfWidth.Name = "mfWidth";
            this.mfWidth.Size = new System.Drawing.Size(61, 22);
            this.mfWidth.TabIndex = 4;
            this.mfWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.mfWidth.Visible = false;
            // 
            // chbBeginner
            // 
            this.chbBeginner.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBeginner.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbBeginner.ImageIndex = 0;
            this.chbBeginner.ImageList = this.imageListbtn2;
            this.chbBeginner.Location = new System.Drawing.Point(69, 76);
            this.chbBeginner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chbBeginner.Name = "chbBeginner";
            this.chbBeginner.Size = new System.Drawing.Size(123, 37);
            this.chbBeginner.TabIndex = 9;
            this.chbBeginner.Tag = "0";
            this.chbBeginner.Text = "Beginner";
            this.chbBeginner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbBeginner.Click += new System.EventHandler(this.CheckButtonClickEvent);
            this.chbBeginner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseDownEvent);
            this.chbBeginner.MouseEnter += new System.EventHandler(this.GeneralMouseEnterEvent);
            this.chbBeginner.MouseLeave += new System.EventHandler(this.GeneralMouseLeaveEvent);
            this.chbBeginner.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GeneralMouseUpEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(129, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(395, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mine";
            this.label3.Visible = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Controls.Add(this.label10);
            this.LeftPanel.Controls.Add(this.lblMulti);
            this.LeftPanel.Controls.Add(this.xxxx);
            this.LeftPanel.Controls.Add(this.lblPoints);
            this.LeftPanel.Controls.Add(this.lblMultiSec);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(243, 160);
            this.LeftPanel.TabIndex = 14;
            this.LeftPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(108, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 44);
            this.label10.TabIndex = 9;
            this.label10.Text = "Multi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMulti
            // 
            this.lblMulti.BackColor = System.Drawing.Color.Transparent;
            this.lblMulti.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMulti.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMulti.Location = new System.Drawing.Point(135, 52);
            this.lblMulti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMulti.Name = "lblMulti";
            this.lblMulti.Size = new System.Drawing.Size(57, 71);
            this.lblMulti.TabIndex = 10;
            this.lblMulti.Text = "x1";
            this.lblMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xxxx
            // 
            this.xxxx.BackColor = System.Drawing.Color.Transparent;
            this.xxxx.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xxxx.ForeColor = System.Drawing.Color.Yellow;
            this.xxxx.Location = new System.Drawing.Point(0, 0);
            this.xxxx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xxxx.Name = "xxxx";
            this.xxxx.Size = new System.Drawing.Size(111, 44);
            this.xxxx.TabIndex = 7;
            this.xxxx.Text = "Points";
            this.xxxx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPoints.Location = new System.Drawing.Point(4, 60);
            this.lblPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(94, 71);
            this.lblPoints.TabIndex = 8;
            this.lblPoints.Text = "123456";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiSec
            // 
            this.lblMultiSec.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiSec.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiSec.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMultiSec.Location = new System.Drawing.Point(141, 52);
            this.lblMultiSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMultiSec.Name = "lblMultiSec";
            this.lblMultiSec.Size = new System.Drawing.Size(111, 71);
            this.lblMultiSec.TabIndex = 15;
            this.lblMultiSec.Text = "0";
            this.lblMultiSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Transparent;
            this.RightPanel.Controls.Add(this.lblTime);
            this.RightPanel.Controls.Add(this.label6);
            this.RightPanel.Controls.Add(this.lblFlags);
            this.RightPanel.Controls.Add(this.label9);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(403, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(264, 160);
            this.RightPanel.TabIndex = 15;
            this.RightPanel.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Cyan;
            this.lblTime.Location = new System.Drawing.Point(35, 68);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(111, 39);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(35, -4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 80);
            this.label6.TabIndex = 3;
            this.label6.Text = "Elapsed Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlags
            // 
            this.lblFlags.BackColor = System.Drawing.Color.Transparent;
            this.lblFlags.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlags.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblFlags.Location = new System.Drawing.Point(153, 57);
            this.lblFlags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlags.Name = "lblFlags";
            this.lblFlags.Size = new System.Drawing.Size(111, 71);
            this.lblFlags.TabIndex = 8;
            this.lblFlags.Text = "0";
            this.lblFlags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(153, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 44);
            this.label9.TabIndex = 7;
            this.label9.Text = "Flags";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrElapsed
            // 
            this.tmrElapsed.Interval = 1000;
            this.tmrElapsed.Tick += new System.EventHandler(this.tmrElapsed_Tick);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "no_dkit_android_bombsquad____334222.png");
            this.images.Images.SetKeyName(1, "Flag-256.png");
            // 
            // imageListSquareBtn
            // 
            this.imageListSquareBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSquareBtn.ImageStream")));
            this.imageListSquareBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSquareBtn.Images.SetKeyName(0, "squarebtn.png");
            this.imageListSquareBtn.Images.SetKeyName(1, "squarebtn_on.png");
            this.imageListSquareBtn.Images.SetKeyName(2, "squarebtn_down.png");
            this.imageListSquareBtn.Images.SetKeyName(3, "squarebtn_disabled.png");
            this.imageListSquareBtn.Images.SetKeyName(4, "squarebtn_flash2.png");
            this.imageListSquareBtn.Images.SetKeyName(5, "squarebtn_fllash.png");
            this.imageListSquareBtn.Images.SetKeyName(6, "squarebtnflag.png");
            this.imageListSquareBtn.Images.SetKeyName(7, "squarebtn_on_flag.png");
            this.imageListSquareBtn.Images.SetKeyName(8, "squarebtn_down_flag.png");
            this.imageListSquareBtn.Images.SetKeyName(9, "squarebtnbomb.png");
            // 
            // tmrMulti
            // 
            this.tmrMulti.Interval = 1000;
            this.tmrMulti.Tick += new System.EventHandler(this.tmrMulti_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Mine_Field.Properties.Resources.subtle_carbon;
            this.ClientSize = new System.Drawing.Size(689, 657);
            this.Controls.Add(this.topbox);
            this.Controls.Add(this.MineField);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper HD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.topbox.ResumeLayout(false);
            this.topbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mfMineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfWidth)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MineField;
        private System.Windows.Forms.Panel topbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown mfMineCount;
        private System.Windows.Forms.NumericUpDown mfWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown mfHeight;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label xxxx;
        private System.Windows.Forms.Timer tmrElapsed;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.Label btnNewGame;
        private System.Windows.Forms.ImageList imageListBtn1;
        private System.Windows.Forms.ImageList imageListbtn2;
        private System.Windows.Forms.Label chbCustom;
        private System.Windows.Forms.Label chbExpert;
        private System.Windows.Forms.Label chbIntermediate;
        private System.Windows.Forms.Label chbBeginner;
        private System.Windows.Forms.ImageList imageListSquareBtn;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMulti;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFlags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmrMulti;
        private System.Windows.Forms.Label lblMultiSec;
    }
}

