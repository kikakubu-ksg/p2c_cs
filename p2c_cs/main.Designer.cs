namespace p2c_cs
{
    partial class main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl_Config = new System.Windows.Forms.TabControl();
            this.TabPage_Config = new System.Windows.Forms.TabPage();
            this.GroupBox_Asf = new System.Windows.Forms.GroupBox();
            this.Label_AsfPath = new System.Windows.Forms.Label();
            this.Button_Exec = new System.Windows.Forms.Button();
            this.TextBox_AsfPath = new System.Windows.Forms.TextBox();
            this.Button_AsfPath = new System.Windows.Forms.Button();
            this.GroupBox_EndTime = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox_EndTimeSet = new System.Windows.Forms.TextBox();
            this.RadioButton_EndTimeSet = new System.Windows.Forms.RadioButton();
            this.RadioButton_EndTimeSaveTime = new System.Windows.Forms.RadioButton();
            this.GroupBox_Image = new System.Windows.Forms.GroupBox();
            this.Label_x = new System.Windows.Forms.Label();
            this.TextBox_ImageSetHeight = new System.Windows.Forms.TextBox();
            this.TextBox_ImageSetWidth = new System.Windows.Forms.TextBox();
            this.RadioButton_ImageSet = new System.Windows.Forms.RadioButton();
            this.RadioButton_ImageNormal = new System.Windows.Forms.RadioButton();
            this.GroupBox_Cover = new System.Windows.Forms.GroupBox();
            this.Label_sec = new System.Windows.Forms.Label();
            this.TextBox_CoverSetSec = new System.Windows.Forms.TextBox();
            this.GroupBox_StartTime = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox_StartTimeSet = new System.Windows.Forms.TextBox();
            this.RadioButton_StartTimeSet = new System.Windows.Forms.RadioButton();
            this.RadioButton_StartTimeNum = new System.Windows.Forms.RadioButton();
            this.Tabpage_Haven = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_DatUseNumEnd_Haven = new System.Windows.Forms.TextBox();
            this.TextBox_DatPath_Haven = new System.Windows.Forms.TextBox();
            this.TextBox_DatUseNumStart_Haven = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button_DatPathRef_Haven = new System.Windows.Forms.Button();
            this.TabPage_Log = new System.Windows.Forms.TabPage();
            this.DataGridView_Log = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox_DAT = new System.Windows.Forms.GroupBox();
            this.TextBox_DatUseNumEnd = new System.Windows.Forms.TextBox();
            this.TextBox_DatPath = new System.Windows.Forms.TextBox();
            this.TextBox_DatUseNumStart = new System.Windows.Forms.TextBox();
            this.Label_DatUseNumExp = new System.Windows.Forms.Label();
            this.Label_DatUseNum = new System.Windows.Forms.Label();
            this.Label_DatPath = new System.Windows.Forms.Label();
            this.Button_DatPathRef = new System.Windows.Forms.Button();
            this.groupBox_ffmpeg = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_FFmpegPath = new System.Windows.Forms.TextBox();
            this.Button_FFmpegPath = new System.Windows.Forms.Button();
            this.Button_GetLiveStartTime = new System.Windows.Forms.Button();
            this.Label_LiveStartTime = new System.Windows.Forms.Label();
            this.DateTimePicker_LiveStartTime = new System.Windows.Forms.DateTimePicker();
            this.TabControl_Config.SuspendLayout();
            this.TabPage_Config.SuspendLayout();
            this.GroupBox_Asf.SuspendLayout();
            this.GroupBox_EndTime.SuspendLayout();
            this.GroupBox_Image.SuspendLayout();
            this.GroupBox_Cover.SuspendLayout();
            this.GroupBox_StartTime.SuspendLayout();
            this.Tabpage_Haven.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.TabPage_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Log)).BeginInit();
            this.GroupBox_DAT.SuspendLayout();
            this.groupBox_ffmpeg.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl_Config
            // 
            this.TabControl_Config.Controls.Add(this.TabPage_Config);
            this.TabControl_Config.Controls.Add(this.Tabpage_Haven);
            this.TabControl_Config.Controls.Add(this.TabPage_Log);
            this.TabControl_Config.Location = new System.Drawing.Point(2, 2);
            this.TabControl_Config.Name = "TabControl_Config";
            this.TabControl_Config.SelectedIndex = 0;
            this.TabControl_Config.Size = new System.Drawing.Size(491, 427);
            this.TabControl_Config.TabIndex = 26;
            // 
            // TabPage_Config
            // 
            this.TabPage_Config.Controls.Add(this.groupBox_ffmpeg);
            this.TabPage_Config.Controls.Add(this.GroupBox_Asf);
            this.TabPage_Config.Controls.Add(this.Button_Exec);
            this.TabPage_Config.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Config.Name = "TabPage_Config";
            this.TabPage_Config.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Config.Size = new System.Drawing.Size(483, 401);
            this.TabPage_Config.TabIndex = 0;
            this.TabPage_Config.Text = "画像抽出";
            this.TabPage_Config.UseVisualStyleBackColor = true;
            // 
            // GroupBox_Asf
            // 
            this.GroupBox_Asf.Controls.Add(this.Label_AsfPath);
            this.GroupBox_Asf.Controls.Add(this.TextBox_AsfPath);
            this.GroupBox_Asf.Controls.Add(this.Button_AsfPath);
            this.GroupBox_Asf.Controls.Add(this.GroupBox_EndTime);
            this.GroupBox_Asf.Controls.Add(this.GroupBox_Image);
            this.GroupBox_Asf.Controls.Add(this.GroupBox_Cover);
            this.GroupBox_Asf.Controls.Add(this.GroupBox_StartTime);
            this.GroupBox_Asf.Location = new System.Drawing.Point(10, 73);
            this.GroupBox_Asf.Name = "GroupBox_Asf";
            this.GroupBox_Asf.Size = new System.Drawing.Size(465, 199);
            this.GroupBox_Asf.TabIndex = 5;
            this.GroupBox_Asf.TabStop = false;
            this.GroupBox_Asf.Text = "動画ファイル";
            // 
            // Label_AsfPath
            // 
            this.Label_AsfPath.AutoSize = true;
            this.Label_AsfPath.Location = new System.Drawing.Point(15, 21);
            this.Label_AsfPath.Margin = new System.Windows.Forms.Padding(3);
            this.Label_AsfPath.Name = "Label_AsfPath";
            this.Label_AsfPath.Size = new System.Drawing.Size(58, 12);
            this.Label_AsfPath.TabIndex = 10;
            this.Label_AsfPath.Text = "ファイルパス";
            // 
            // Button_Exec
            // 
            this.Button_Exec.Location = new System.Drawing.Point(388, 278);
            this.Button_Exec.Name = "Button_Exec";
            this.Button_Exec.Size = new System.Drawing.Size(89, 23);
            this.Button_Exec.TabIndex = 24;
            this.Button_Exec.Text = "画像抽出実行";
            this.Button_Exec.UseVisualStyleBackColor = true;
            this.Button_Exec.Click += new System.EventHandler(this.Button_Exec_Click);
            // 
            // TextBox_AsfPath
            // 
            this.TextBox_AsfPath.AllowDrop = true;
            this.TextBox_AsfPath.Location = new System.Drawing.Point(79, 18);
            this.TextBox_AsfPath.Name = "TextBox_AsfPath";
            this.TextBox_AsfPath.Size = new System.Drawing.Size(327, 19);
            this.TextBox_AsfPath.TabIndex = 6;
            this.TextBox_AsfPath.TextChanged += new System.EventHandler(this.TextBox_AsfPath_TextChanged);
            this.TextBox_AsfPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_AsfPath_DragDrop);
            this.TextBox_AsfPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_AsfPath_DragEnter);
            // 
            // Button_AsfPath
            // 
            this.Button_AsfPath.Location = new System.Drawing.Point(413, 17);
            this.Button_AsfPath.Name = "Button_AsfPath";
            this.Button_AsfPath.Size = new System.Drawing.Size(37, 23);
            this.Button_AsfPath.TabIndex = 7;
            this.Button_AsfPath.Text = "参照";
            this.Button_AsfPath.UseVisualStyleBackColor = true;
            this.Button_AsfPath.Click += new System.EventHandler(this.Button_AsfPath_Click);
            // 
            // GroupBox_EndTime
            // 
            this.GroupBox_EndTime.Controls.Add(this.Label2);
            this.GroupBox_EndTime.Controls.Add(this.TextBox_EndTimeSet);
            this.GroupBox_EndTime.Controls.Add(this.RadioButton_EndTimeSet);
            this.GroupBox_EndTime.Controls.Add(this.RadioButton_EndTimeSaveTime);
            this.GroupBox_EndTime.Location = new System.Drawing.Point(235, 46);
            this.GroupBox_EndTime.Name = "GroupBox_EndTime";
            this.GroupBox_EndTime.Size = new System.Drawing.Size(220, 68);
            this.GroupBox_EndTime.TabIndex = 1;
            this.GroupBox_EndTime.TabStop = false;
            this.GroupBox_EndTime.Text = "終了時間";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(107, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 12);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "秒後まで";
            // 
            // TextBox_EndTimeSet
            // 
            this.TextBox_EndTimeSet.Location = new System.Drawing.Point(78, 40);
            this.TextBox_EndTimeSet.Name = "TextBox_EndTimeSet";
            this.TextBox_EndTimeSet.Size = new System.Drawing.Size(23, 19);
            this.TextBox_EndTimeSet.TabIndex = 14;
            // 
            // RadioButton_EndTimeSet
            // 
            this.RadioButton_EndTimeSet.AutoSize = true;
            this.RadioButton_EndTimeSet.Location = new System.Drawing.Point(6, 40);
            this.RadioButton_EndTimeSet.Name = "RadioButton_EndTimeSet";
            this.RadioButton_EndTimeSet.Size = new System.Drawing.Size(47, 16);
            this.RadioButton_EndTimeSet.TabIndex = 13;
            this.RadioButton_EndTimeSet.Text = "指定";
            this.RadioButton_EndTimeSet.UseVisualStyleBackColor = true;
            this.RadioButton_EndTimeSet.CheckedChanged += new System.EventHandler(this.RadioButton_EndTimeSet_CheckedChanged);
            // 
            // RadioButton_EndTimeSaveTime
            // 
            this.RadioButton_EndTimeSaveTime.AutoSize = true;
            this.RadioButton_EndTimeSaveTime.Location = new System.Drawing.Point(6, 18);
            this.RadioButton_EndTimeSaveTime.Name = "RadioButton_EndTimeSaveTime";
            this.RadioButton_EndTimeSaveTime.Size = new System.Drawing.Size(66, 16);
            this.RadioButton_EndTimeSaveTime.TabIndex = 12;
            this.RadioButton_EndTimeSaveTime.Text = "最後まで";
            this.RadioButton_EndTimeSaveTime.UseVisualStyleBackColor = true;
            this.RadioButton_EndTimeSaveTime.CheckedChanged += new System.EventHandler(this.RadioButton_EndTimeSaveTime_CheckedChanged);
            // 
            // GroupBox_Image
            // 
            this.GroupBox_Image.Controls.Add(this.Label_x);
            this.GroupBox_Image.Controls.Add(this.TextBox_ImageSetHeight);
            this.GroupBox_Image.Controls.Add(this.TextBox_ImageSetWidth);
            this.GroupBox_Image.Controls.Add(this.RadioButton_ImageSet);
            this.GroupBox_Image.Controls.Add(this.RadioButton_ImageNormal);
            this.GroupBox_Image.Location = new System.Drawing.Point(9, 117);
            this.GroupBox_Image.Name = "GroupBox_Image";
            this.GroupBox_Image.Size = new System.Drawing.Size(220, 68);
            this.GroupBox_Image.TabIndex = 1;
            this.GroupBox_Image.TabStop = false;
            this.GroupBox_Image.Text = "画像抽出";
            // 
            // Label_x
            // 
            this.Label_x.AutoSize = true;
            this.Label_x.Location = new System.Drawing.Point(127, 45);
            this.Label_x.Name = "Label_x";
            this.Label_x.Size = new System.Drawing.Size(11, 12);
            this.Label_x.TabIndex = 8;
            this.Label_x.Text = "x";
            // 
            // TextBox_ImageSetHeight
            // 
            this.TextBox_ImageSetHeight.Location = new System.Drawing.Point(144, 39);
            this.TextBox_ImageSetHeight.Name = "TextBox_ImageSetHeight";
            this.TextBox_ImageSetHeight.Size = new System.Drawing.Size(40, 19);
            this.TextBox_ImageSetHeight.TabIndex = 18;
            this.TextBox_ImageSetHeight.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_ImageSetHeight_Validating);
            // 
            // TextBox_ImageSetWidth
            // 
            this.TextBox_ImageSetWidth.Location = new System.Drawing.Point(82, 39);
            this.TextBox_ImageSetWidth.Name = "TextBox_ImageSetWidth";
            this.TextBox_ImageSetWidth.Size = new System.Drawing.Size(40, 19);
            this.TextBox_ImageSetWidth.TabIndex = 17;
            this.TextBox_ImageSetWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_ImageSetWidth_Validating);
            // 
            // RadioButton_ImageSet
            // 
            this.RadioButton_ImageSet.AutoSize = true;
            this.RadioButton_ImageSet.Location = new System.Drawing.Point(10, 39);
            this.RadioButton_ImageSet.Name = "RadioButton_ImageSet";
            this.RadioButton_ImageSet.Size = new System.Drawing.Size(76, 16);
            this.RadioButton_ImageSet.TabIndex = 16;
            this.RadioButton_ImageSet.Text = "サイズ指定";
            this.RadioButton_ImageSet.UseVisualStyleBackColor = true;
            this.RadioButton_ImageSet.CheckedChanged += new System.EventHandler(this.RadioButton_ImageSet_CheckedChanged);
            // 
            // RadioButton_ImageNormal
            // 
            this.RadioButton_ImageNormal.AutoSize = true;
            this.RadioButton_ImageNormal.Location = new System.Drawing.Point(10, 17);
            this.RadioButton_ImageNormal.Name = "RadioButton_ImageNormal";
            this.RadioButton_ImageNormal.Size = new System.Drawing.Size(70, 16);
            this.RadioButton_ImageNormal.TabIndex = 15;
            this.RadioButton_ImageNormal.Text = "フルサイズ";
            this.RadioButton_ImageNormal.UseVisualStyleBackColor = true;
            this.RadioButton_ImageNormal.CheckedChanged += new System.EventHandler(this.RadioButton_ImageNormal_CheckedChanged);
            // 
            // GroupBox_Cover
            // 
            this.GroupBox_Cover.Controls.Add(this.Label_sec);
            this.GroupBox_Cover.Controls.Add(this.TextBox_CoverSetSec);
            this.GroupBox_Cover.Location = new System.Drawing.Point(238, 117);
            this.GroupBox_Cover.Name = "GroupBox_Cover";
            this.GroupBox_Cover.Size = new System.Drawing.Size(220, 68);
            this.GroupBox_Cover.TabIndex = 2;
            this.GroupBox_Cover.TabStop = false;
            this.GroupBox_Cover.Text = "抽出間隔";
            // 
            // Label_sec
            // 
            this.Label_sec.AutoSize = true;
            this.Label_sec.Location = new System.Drawing.Point(56, 20);
            this.Label_sec.Name = "Label_sec";
            this.Label_sec.Size = new System.Drawing.Size(17, 12);
            this.Label_sec.TabIndex = 8;
            this.Label_sec.Text = "秒";
            // 
            // TextBox_CoverSetSec
            // 
            this.TextBox_CoverSetSec.Location = new System.Drawing.Point(10, 15);
            this.TextBox_CoverSetSec.Name = "TextBox_CoverSetSec";
            this.TextBox_CoverSetSec.Size = new System.Drawing.Size(40, 19);
            this.TextBox_CoverSetSec.TabIndex = 21;
            this.TextBox_CoverSetSec.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_CoverSetSec_Validating);
            // 
            // GroupBox_StartTime
            // 
            this.GroupBox_StartTime.Controls.Add(this.Label1);
            this.GroupBox_StartTime.Controls.Add(this.TextBox_StartTimeSet);
            this.GroupBox_StartTime.Controls.Add(this.RadioButton_StartTimeSet);
            this.GroupBox_StartTime.Controls.Add(this.RadioButton_StartTimeNum);
            this.GroupBox_StartTime.Location = new System.Drawing.Point(9, 46);
            this.GroupBox_StartTime.Name = "GroupBox_StartTime";
            this.GroupBox_StartTime.Size = new System.Drawing.Size(220, 68);
            this.GroupBox_StartTime.TabIndex = 0;
            this.GroupBox_StartTime.TabStop = false;
            this.GroupBox_StartTime.Text = "開始時間";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(107, 43);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 12);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "秒後から";
            // 
            // TextBox_StartTimeSet
            // 
            this.TextBox_StartTimeSet.Location = new System.Drawing.Point(78, 40);
            this.TextBox_StartTimeSet.Name = "TextBox_StartTimeSet";
            this.TextBox_StartTimeSet.Size = new System.Drawing.Size(23, 19);
            this.TextBox_StartTimeSet.TabIndex = 11;
            // 
            // RadioButton_StartTimeSet
            // 
            this.RadioButton_StartTimeSet.AutoSize = true;
            this.RadioButton_StartTimeSet.Location = new System.Drawing.Point(6, 40);
            this.RadioButton_StartTimeSet.Name = "RadioButton_StartTimeSet";
            this.RadioButton_StartTimeSet.Size = new System.Drawing.Size(47, 16);
            this.RadioButton_StartTimeSet.TabIndex = 9;
            this.RadioButton_StartTimeSet.Text = "指定";
            this.RadioButton_StartTimeSet.UseVisualStyleBackColor = true;
            this.RadioButton_StartTimeSet.CheckedChanged += new System.EventHandler(this.RadioButton_StartTimeSet_CheckedChanged);
            // 
            // RadioButton_StartTimeNum
            // 
            this.RadioButton_StartTimeNum.AutoSize = true;
            this.RadioButton_StartTimeNum.Location = new System.Drawing.Point(6, 18);
            this.RadioButton_StartTimeNum.Name = "RadioButton_StartTimeNum";
            this.RadioButton_StartTimeNum.Size = new System.Drawing.Size(65, 16);
            this.RadioButton_StartTimeNum.TabIndex = 8;
            this.RadioButton_StartTimeNum.Text = "最初から";
            this.RadioButton_StartTimeNum.UseVisualStyleBackColor = true;
            this.RadioButton_StartTimeNum.CheckedChanged += new System.EventHandler(this.RadioButton_StartTimeNum_CheckedChanged);
            // 
            // Tabpage_Haven
            // 
            this.Tabpage_Haven.Controls.Add(this.DateTimePicker_LiveStartTime);
            this.Tabpage_Haven.Controls.Add(this.Button_GetLiveStartTime);
            this.Tabpage_Haven.Controls.Add(this.Label_LiveStartTime);
            this.Tabpage_Haven.Controls.Add(this.GroupBox_DAT);
            this.Tabpage_Haven.Controls.Add(this.Button1);
            this.Tabpage_Haven.Controls.Add(this.GroupBox1);
            this.Tabpage_Haven.Location = new System.Drawing.Point(4, 22);
            this.Tabpage_Haven.Name = "Tabpage_Haven";
            this.Tabpage_Haven.Padding = new System.Windows.Forms.Padding(3);
            this.Tabpage_Haven.Size = new System.Drawing.Size(483, 401);
            this.Tabpage_Haven.TabIndex = 2;
            this.Tabpage_Haven.Text = "DAT解析";
            this.Tabpage_Haven.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.TextBox_DatUseNumEnd_Haven);
            this.GroupBox1.Controls.Add(this.TextBox_DatPath_Haven);
            this.GroupBox1.Controls.Add(this.TextBox_DatUseNumStart_Haven);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Button_DatPathRef_Haven);
            this.GroupBox1.Location = new System.Drawing.Point(13, 105);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(462, 71);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "したらば";
            // 
            // TextBox_DatUseNumEnd_Haven
            // 
            this.TextBox_DatUseNumEnd_Haven.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatUseNumEnd_Haven.Location = new System.Drawing.Point(143, 44);
            this.TextBox_DatUseNumEnd_Haven.Name = "TextBox_DatUseNumEnd_Haven";
            this.TextBox_DatUseNumEnd_Haven.Size = new System.Drawing.Size(31, 19);
            this.TextBox_DatUseNumEnd_Haven.TabIndex = 8;
            // 
            // TextBox_DatPath_Haven
            // 
            this.TextBox_DatPath_Haven.AllowDrop = true;
            this.TextBox_DatPath_Haven.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatPath_Haven.Location = new System.Drawing.Point(76, 18);
            this.TextBox_DatPath_Haven.Name = "TextBox_DatPath_Haven";
            this.TextBox_DatPath_Haven.Size = new System.Drawing.Size(327, 19);
            this.TextBox_DatPath_Haven.TabIndex = 1;
            this.TextBox_DatPath_Haven.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_DatPath_Haven_DragDrop);
            this.TextBox_DatPath_Haven.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DatPath_Haven_DragEnter);
            // 
            // TextBox_DatUseNumStart_Haven
            // 
            this.TextBox_DatUseNumStart_Haven.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatUseNumStart_Haven.Location = new System.Drawing.Point(76, 44);
            this.TextBox_DatUseNumStart_Haven.Name = "TextBox_DatUseNumStart_Haven";
            this.TextBox_DatUseNumStart_Haven.Size = new System.Drawing.Size(31, 19);
            this.TextBox_DatUseNumStart_Haven.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(113, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(23, 12);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "から";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 46);
            this.Label4.Margin = new System.Windows.Forms.Padding(3);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 12);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "レス番号";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 18);
            this.Label5.Margin = new System.Windows.Forms.Padding(3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 12);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "datファイル";
            // 
            // Button_DatPathRef_Haven
            // 
            this.Button_DatPathRef_Haven.Location = new System.Drawing.Point(410, 16);
            this.Button_DatPathRef_Haven.Name = "Button_DatPathRef_Haven";
            this.Button_DatPathRef_Haven.Size = new System.Drawing.Size(37, 23);
            this.Button_DatPathRef_Haven.TabIndex = 3;
            this.Button_DatPathRef_Haven.Text = "参照";
            this.Button_DatPathRef_Haven.UseVisualStyleBackColor = true;
            // 
            // TabPage_Log
            // 
            this.TabPage_Log.Controls.Add(this.DataGridView_Log);
            this.TabPage_Log.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Log.Name = "TabPage_Log";
            this.TabPage_Log.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Log.Size = new System.Drawing.Size(483, 401);
            this.TabPage_Log.TabIndex = 1;
            this.TabPage_Log.Text = "ログ";
            this.TabPage_Log.UseVisualStyleBackColor = true;
            // 
            // DataGridView_Log
            // 
            this.DataGridView_Log.AllowUserToAddRows = false;
            this.DataGridView_Log.AllowUserToDeleteRows = false;
            this.DataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGridView_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView_Log.Location = new System.Drawing.Point(3, 3);
            this.DataGridView_Log.Name = "DataGridView_Log";
            this.DataGridView_Log.ReadOnly = true;
            this.DataGridView_Log.RowTemplate.Height = 21;
            this.DataGridView_Log.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DataGridView_Log.Size = new System.Drawing.Size(477, 395);
            this.DataGridView_Log.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "body";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 360;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.Filter = "datファイル(*.dat)|*.dat|すべてのファイル(*.*)|*.*";
            // 
            // OpenFileDialog2
            // 
            this.OpenFileDialog2.Filter = "メディアファイル(*.asf;*wmv;*.mpg;*.flv)|*.asf;*wmv;*.mpg;*.flv|すべてのファイル(*.*)|*.*";
            // 
            // OpenFileDialog3
            // 
            this.OpenFileDialog3.Filter = "テンプレートファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(376, 372);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(99, 23);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "dat解析実行";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox_DAT
            // 
            this.GroupBox_DAT.Controls.Add(this.TextBox_DatUseNumEnd);
            this.GroupBox_DAT.Controls.Add(this.TextBox_DatPath);
            this.GroupBox_DAT.Controls.Add(this.TextBox_DatUseNumStart);
            this.GroupBox_DAT.Controls.Add(this.Label_DatUseNumExp);
            this.GroupBox_DAT.Controls.Add(this.Label_DatUseNum);
            this.GroupBox_DAT.Controls.Add(this.Label_DatPath);
            this.GroupBox_DAT.Controls.Add(this.Button_DatPathRef);
            this.GroupBox_DAT.Location = new System.Drawing.Point(14, 28);
            this.GroupBox_DAT.Name = "GroupBox_DAT";
            this.GroupBox_DAT.Size = new System.Drawing.Size(462, 71);
            this.GroupBox_DAT.TabIndex = 3;
            this.GroupBox_DAT.TabStop = false;
            this.GroupBox_DAT.Text = "2ch";
            // 
            // TextBox_DatUseNumEnd
            // 
            this.TextBox_DatUseNumEnd.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatUseNumEnd.Location = new System.Drawing.Point(143, 44);
            this.TextBox_DatUseNumEnd.Name = "TextBox_DatUseNumEnd";
            this.TextBox_DatUseNumEnd.Size = new System.Drawing.Size(31, 19);
            this.TextBox_DatUseNumEnd.TabIndex = 8;
            // 
            // TextBox_DatPath
            // 
            this.TextBox_DatPath.AllowDrop = true;
            this.TextBox_DatPath.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatPath.Location = new System.Drawing.Point(76, 18);
            this.TextBox_DatPath.Name = "TextBox_DatPath";
            this.TextBox_DatPath.Size = new System.Drawing.Size(327, 19);
            this.TextBox_DatPath.TabIndex = 1;
            // 
            // TextBox_DatUseNumStart
            // 
            this.TextBox_DatUseNumStart.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox_DatUseNumStart.Location = new System.Drawing.Point(76, 44);
            this.TextBox_DatUseNumStart.Name = "TextBox_DatUseNumStart";
            this.TextBox_DatUseNumStart.Size = new System.Drawing.Size(31, 19);
            this.TextBox_DatUseNumStart.TabIndex = 4;
            // 
            // Label_DatUseNumExp
            // 
            this.Label_DatUseNumExp.AutoSize = true;
            this.Label_DatUseNumExp.Location = new System.Drawing.Point(113, 48);
            this.Label_DatUseNumExp.Name = "Label_DatUseNumExp";
            this.Label_DatUseNumExp.Size = new System.Drawing.Size(23, 12);
            this.Label_DatUseNumExp.TabIndex = 7;
            this.Label_DatUseNumExp.Text = "から";
            // 
            // Label_DatUseNum
            // 
            this.Label_DatUseNum.AutoSize = true;
            this.Label_DatUseNum.Location = new System.Drawing.Point(12, 46);
            this.Label_DatUseNum.Margin = new System.Windows.Forms.Padding(3);
            this.Label_DatUseNum.Name = "Label_DatUseNum";
            this.Label_DatUseNum.Size = new System.Drawing.Size(47, 12);
            this.Label_DatUseNum.TabIndex = 6;
            this.Label_DatUseNum.Text = "レス番号";
            // 
            // Label_DatPath
            // 
            this.Label_DatPath.AutoSize = true;
            this.Label_DatPath.Location = new System.Drawing.Point(12, 18);
            this.Label_DatPath.Margin = new System.Windows.Forms.Padding(3);
            this.Label_DatPath.Name = "Label_DatPath";
            this.Label_DatPath.Size = new System.Drawing.Size(55, 12);
            this.Label_DatPath.TabIndex = 4;
            this.Label_DatPath.Text = "datファイル";
            // 
            // Button_DatPathRef
            // 
            this.Button_DatPathRef.Location = new System.Drawing.Point(410, 16);
            this.Button_DatPathRef.Name = "Button_DatPathRef";
            this.Button_DatPathRef.Size = new System.Drawing.Size(37, 23);
            this.Button_DatPathRef.TabIndex = 3;
            this.Button_DatPathRef.Text = "参照";
            this.Button_DatPathRef.UseVisualStyleBackColor = true;
            // 
            // groupBox_ffmpeg
            // 
            this.groupBox_ffmpeg.Controls.Add(this.label6);
            this.groupBox_ffmpeg.Controls.Add(this.TextBox_FFmpegPath);
            this.groupBox_ffmpeg.Controls.Add(this.Button_FFmpegPath);
            this.groupBox_ffmpeg.Location = new System.Drawing.Point(10, 7);
            this.groupBox_ffmpeg.Name = "groupBox_ffmpeg";
            this.groupBox_ffmpeg.Size = new System.Drawing.Size(465, 60);
            this.groupBox_ffmpeg.TabIndex = 25;
            this.groupBox_ffmpeg.TabStop = false;
            this.groupBox_ffmpeg.Text = "FFMPEG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "ファイルパス";
            // 
            // TextBox_FFmpegPath
            // 
            this.TextBox_FFmpegPath.AllowDrop = true;
            this.TextBox_FFmpegPath.Location = new System.Drawing.Point(79, 18);
            this.TextBox_FFmpegPath.Name = "TextBox_FFmpegPath";
            this.TextBox_FFmpegPath.Size = new System.Drawing.Size(327, 19);
            this.TextBox_FFmpegPath.TabIndex = 28;
            this.TextBox_FFmpegPath.TextChanged += new System.EventHandler(this.TextBox_FFmpegPath_TextChanged);
            this.TextBox_FFmpegPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_FFmpegPath_DragDrop);
            this.TextBox_FFmpegPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_FFmpegPath_DragEnter);
            // 
            // Button_FFmpegPath
            // 
            this.Button_FFmpegPath.Location = new System.Drawing.Point(413, 17);
            this.Button_FFmpegPath.Name = "Button_FFmpegPath";
            this.Button_FFmpegPath.Size = new System.Drawing.Size(37, 23);
            this.Button_FFmpegPath.TabIndex = 29;
            this.Button_FFmpegPath.Text = "参照";
            this.Button_FFmpegPath.UseVisualStyleBackColor = true;
            // 
            // Button_GetLiveStartTime
            // 
            this.Button_GetLiveStartTime.Location = new System.Drawing.Point(353, 189);
            this.Button_GetLiveStartTime.Name = "Button_GetLiveStartTime";
            this.Button_GetLiveStartTime.Size = new System.Drawing.Size(111, 23);
            this.Button_GetLiveStartTime.TabIndex = 30;
            this.Button_GetLiveStartTime.Text = "ファイル名から取得";
            this.Button_GetLiveStartTime.UseVisualStyleBackColor = true;
            // 
            // Label_LiveStartTime
            // 
            this.Label_LiveStartTime.AutoSize = true;
            this.Label_LiveStartTime.Location = new System.Drawing.Point(18, 194);
            this.Label_LiveStartTime.Name = "Label_LiveStartTime";
            this.Label_LiveStartTime.Size = new System.Drawing.Size(77, 12);
            this.Label_LiveStartTime.TabIndex = 28;
            this.Label_LiveStartTime.Text = "配信開始時刻";
            // 
            // DateTimePicker_LiveStartTime
            // 
            this.DateTimePicker_LiveStartTime.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.DateTimePicker_LiveStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_LiveStartTime.Location = new System.Drawing.Point(101, 191);
            this.DateTimePicker_LiveStartTime.Name = "DateTimePicker_LiveStartTime";
            this.DateTimePicker_LiveStartTime.Size = new System.Drawing.Size(246, 19);
            this.DateTimePicker_LiveStartTime.TabIndex = 31;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 339);
            this.Controls.Add(this.TabControl_Config);
            this.Name = "main";
            this.Text = "p2c";
            this.Load += new System.EventHandler(this.main_Load);
            this.TabControl_Config.ResumeLayout(false);
            this.TabPage_Config.ResumeLayout(false);
            this.GroupBox_Asf.ResumeLayout(false);
            this.GroupBox_Asf.PerformLayout();
            this.GroupBox_EndTime.ResumeLayout(false);
            this.GroupBox_EndTime.PerformLayout();
            this.GroupBox_Image.ResumeLayout(false);
            this.GroupBox_Image.PerformLayout();
            this.GroupBox_Cover.ResumeLayout(false);
            this.GroupBox_Cover.PerformLayout();
            this.GroupBox_StartTime.ResumeLayout(false);
            this.GroupBox_StartTime.PerformLayout();
            this.Tabpage_Haven.ResumeLayout(false);
            this.Tabpage_Haven.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.TabPage_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Log)).EndInit();
            this.GroupBox_DAT.ResumeLayout(false);
            this.GroupBox_DAT.PerformLayout();
            this.groupBox_ffmpeg.ResumeLayout(false);
            this.groupBox_ffmpeg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl_Config;
        internal System.Windows.Forms.TabPage TabPage_Config;
        internal System.Windows.Forms.GroupBox GroupBox_Asf;
        internal System.Windows.Forms.Label Label_AsfPath;
        internal System.Windows.Forms.Button Button_Exec;
        internal System.Windows.Forms.TextBox TextBox_AsfPath;
        internal System.Windows.Forms.Button Button_AsfPath;
        internal System.Windows.Forms.GroupBox GroupBox_EndTime;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBox_EndTimeSet;
        internal System.Windows.Forms.RadioButton RadioButton_EndTimeSet;
        internal System.Windows.Forms.RadioButton RadioButton_EndTimeSaveTime;
        internal System.Windows.Forms.GroupBox GroupBox_Image;
        internal System.Windows.Forms.Label Label_x;
        internal System.Windows.Forms.TextBox TextBox_ImageSetHeight;
        internal System.Windows.Forms.TextBox TextBox_ImageSetWidth;
        internal System.Windows.Forms.RadioButton RadioButton_ImageSet;
        internal System.Windows.Forms.RadioButton RadioButton_ImageNormal;
        internal System.Windows.Forms.GroupBox GroupBox_Cover;
        internal System.Windows.Forms.Label Label_sec;
        internal System.Windows.Forms.TextBox TextBox_CoverSetSec;
        internal System.Windows.Forms.GroupBox GroupBox_StartTime;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBox_StartTimeSet;
        internal System.Windows.Forms.RadioButton RadioButton_StartTimeSet;
        internal System.Windows.Forms.RadioButton RadioButton_StartTimeNum;
        internal System.Windows.Forms.TabPage Tabpage_Haven;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TextBox_DatUseNumEnd_Haven;
        internal System.Windows.Forms.TextBox TextBox_DatPath_Haven;
        internal System.Windows.Forms.TextBox TextBox_DatUseNumStart_Haven;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button_DatPathRef_Haven;
        internal System.Windows.Forms.TabPage TabPage_Log;
        internal System.Windows.Forms.DataGridView DataGridView_Log;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog2;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox GroupBox_DAT;
        internal System.Windows.Forms.TextBox TextBox_DatUseNumEnd;
        internal System.Windows.Forms.TextBox TextBox_DatPath;
        internal System.Windows.Forms.TextBox TextBox_DatUseNumStart;
        internal System.Windows.Forms.Label Label_DatUseNumExp;
        internal System.Windows.Forms.Label Label_DatUseNum;
        internal System.Windows.Forms.Label Label_DatPath;
        internal System.Windows.Forms.Button Button_DatPathRef;
        private System.Windows.Forms.GroupBox groupBox_ffmpeg;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox TextBox_FFmpegPath;
        internal System.Windows.Forms.Button Button_FFmpegPath;
        internal System.Windows.Forms.Button Button_GetLiveStartTime;
        internal System.Windows.Forms.Label Label_LiveStartTime;
        private System.Windows.Forms.DateTimePicker DateTimePicker_LiveStartTime;
    }
}

