using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace p2c_cs
{
    public class main : Form
    {


        public string ExecPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        //編集フォーム

        public view Form = new view();
        private void main_Load(System.Object sender, System.EventArgs e)
        {
            //初期化
            Button_Exec.Enabled = false;
            CheckBox_Dat.Checked = Properties.Settings.Default.DAT_Check;
            if (CheckBox_Dat.Checked == false)
            {
                GroupBox_DAT.Enabled = false;
                Button_Exec.Enabled = true;
            }
            CheckBox_Asf.Checked = Properties.Settings.Default.ASF_Check;
            if (CheckBox_Asf.Checked == false)
            {
                GroupBox_Asf.Enabled = false;
                Button_Exec.Enabled = true;
            }
            if (Properties.Settings.Default.ASF_StartTimeRadio == 1)
            {
                RadioButton_StartTimeNum.Checked = true;
                TextBox_StartTimeSet.Enabled = false;
            }
            else
            {
                RadioButton_StartTimeSet.Checked = true;
            }
            if (Properties.Settings.Default.ASF_EndTimeRadio == 1)
            {
                RadioButton_EndTimeSaveTime.Select();
                TextBox_EndTimeSet.Enabled = false;
            }
            else
            {
                RadioButton_EndTimeSet.Select();
            }
            if (Properties.Settings.Default.ASF_ImageRadio == 1)
            {
                RadioButton_ImageNormal.Select();
                TextBox_ImageSetHeight.Enabled = false;
                TextBox_ImageSetWidth.Enabled = false;
            }
            else
            {
                RadioButton_ImageSet.Select();
            }
            TextBox_ImageSetHeight.Text = Properties.Settings.Default.ASF_ImageHeight.ToString();
            TextBox_ImageSetWidth.Text = Properties.Settings.Default.ASF_ImageWidth.ToString();

            TextBox_CoverSetSec.Text = Properties.Settings.Default.ASF_CoverSec;

            TextBox_DatUseNumStart.Text = "1";
            TextBox_DatUseNumEnd.Text = "50";

            DataGridView_Log.RowHeadersVisible = false;

            //編集フォーム
            Form.Visible = true;


        }

        private void TextBox_ImageSetWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!common.IsNumeric(TextBox_ImageSetWidth.Text) || !string.IsNullOrEmpty(TextBox_ImageSetWidth.Text))
            {
                MessageBox.Show("数値のみ入力可能です。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.ASF_ImageWidth = int.Parse(TextBox_ImageSetWidth.Text);
            }

        }

        private void TextBox_ImageSetHeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!common.IsNumeric(TextBox_ImageSetHeight.Text) || !string.IsNullOrEmpty(TextBox_ImageSetHeight.Text))
            {
                MessageBox.Show("数値のみ入力可能です。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.ASF_ImageHeight = int.Parse(TextBox_ImageSetHeight.Text);
            }
        }

        private void TextBox_CoverSetSec_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!common.IsNumeric(TextBox_CoverSetSec.Text) & !string.IsNullOrEmpty(TextBox_CoverSetSec.Text))
            {
                MessageBox.Show("数値のみ入力可能です。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                Properties.Settings.Default.ASF_CoverSec = TextBox_CoverSetSec.Text;
            }
        }

        private void TextBox_DatUseNumStart_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TextBox_DatUseNumStart.Text, "^[0123456789]*$"))
            {
                MessageBox.Show("数値のみ入力可能です。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
        }

        private void RadioButton_StartTimeNum_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_StartTimeNum.Checked)
            {
                Properties.Settings.Default.ASF_StartTimeRadio = 1;
                TextBox_StartTimeSet.Enabled = false;
            }
        }

        private void RadioButton_StartTimeSet_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_StartTimeSet.Checked)
            {
                Properties.Settings.Default.ASF_StartTimeRadio = 2;
                TextBox_StartTimeSet.Enabled = true;
            }
        }

        private void RadioButton_EndTimeSaveTime_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_EndTimeSaveTime.Checked)
            {
                Properties.Settings.Default.ASF_EndTimeRadio = 1;
                TextBox_EndTimeSet.Enabled = false;
            }
        }

        private void RadioButton_EndTimeSet_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_EndTimeSet.Checked)
            {
                Properties.Settings.Default.ASF_EndTimeRadio = 2;
                TextBox_EndTimeSet.Enabled = true;
            }
        }

        private void RadioButton_ImageNormal_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_ImageNormal.Checked)
            {
                Properties.Settings.Default.ASF_ImageRadio = 1;
                TextBox_ImageSetHeight.Enabled = false;
                TextBox_ImageSetWidth.Enabled = false;
            }
        }

        private void RadioButton_ImageSet_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (RadioButton_ImageSet.Checked)
            {
                Properties.Settings.Default.ASF_ImageRadio = 2;
                TextBox_ImageSetHeight.Enabled = true;
                TextBox_ImageSetWidth.Enabled = true;
            }
        }

        private void CheckBox_Dat_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (CheckBox_Dat.Checked)
            {
                Properties.Settings.Default.DAT_Check = true;
                GroupBox_DAT.Enabled = true;
                Button_Exec.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.DAT_Check = false;
                GroupBox_DAT.Enabled = false;
                if (CheckBox_Asf.Checked == false)
                {
                    Button_Exec.Enabled = false;
                }

            }
        }

        private void CheckBox_Asf_CheckedChanged(System.Object sender, System.EventArgs e)
        {
            if (CheckBox_Asf.Checked)
            {
                Properties.Settings.Default.ASF_Check = true;
                GroupBox_Asf.Enabled = true;
                Button_Exec.Enabled = true;
            }
            else
            {
                Properties.Settings.Default.ASF_Check = false;
                GroupBox_Asf.Enabled = false;
                if (CheckBox_Dat.Checked == false)
                {
                    Button_Exec.Enabled = false;
                }
            }
        }


        //Private Sub TextBox_StartTimeSet_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_StartTimeSet.Validating
        //    If Not TimeValidation(TextBox_StartTimeSet.Text) Then
        //        e.Cancel = True
        //        Exit Sub
        //    End If
        //End Sub

        //Private Sub TextBox_EndTimeSet_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox_EndTimeSet.Validating
        //    If Not TimeValidation(TextBox_EndTimeSet.Text) Then
        //        e.Cancel = True
        //        Exit Sub
        //    End If
        //End Sub

        public bool TimeValidation(ref string TimeString)
        {
            string formattedText = null;
            if (string.IsNullOrEmpty(TimeString))
            {
                return true;
            }

            formattedText = System.Text.RegularExpressions.Regex.Replace(TimeString, "^.*?(\\d{4})[-/]?(\\d{2})[-/]?(\\d{2}) ?(\\d{2})[:-]?(\\d{2})[:-]?(\\d{2}).*$", "$1-$2-$3 $4:$5:$6");

            if (!System.Text.RegularExpressions.Regex.IsMatch(formattedText, "^\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}$"))
            {
                MessageBox.Show("yyyy-mm-dd hh:mm:ss形式で入力してください。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            TimeString = formattedText;

            if (!common.IsDate(formattedText))
            {
                MessageBox.Show("日付が不正です。", null,
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        private void Button_DatPathRef_Click(System.Object sender, System.EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                TextBox_DatPath.Text = OpenFileDialog1.FileName;
            }

        }
        private void Button_AsfPath_Click(System.Object sender, System.EventArgs e)
        {
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                TextBox_AsfPath.Text = OpenFileDialog2.FileName;
            }
        }

        private void TextBox_DatPath_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragDrop(sender, ref e);
        }

        private void TextBox_DatPath_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragEnter(ref e);
        }

        private void TextBox_AsfPath_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragDrop(sender, ref e);
        }

        private void TextBox_AsfPath_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragEnter(ref e);
        }
        private void TextBox_OutputTempPath_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragDrop(sender, ref e);
        }

        private void TextBox_OutputTempPath_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            FileDragEnter(ref e);
        }

        public void FileDragDrop(object sender, ref System.EventArgs e)
        {
            System.Windows.Forms.DragEventArgs ev = (DragEventArgs)e;
            string[] fileName = Convert.ToString(ev.Data.GetData(DataFormats.FileDrop, false));
            TextBox tb = (TextBox)sender;
            tb.Text = fileName[0];
        }

        public void FileDragEnter(ref System.EventArgs e)
        {
            System.Windows.Forms.DragEventArgs ev = (DragEventArgs)e;
            if (ev.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                ev.Effect = DragDropEffects.Copy;
            }
            else
            {
                //ファイル以外は受け付けない
                ev.Effect = DragDropEffects.None;
            }
        }

        private void Button_Exec_Click(System.Object sender, System.EventArgs e)
        {
            //Debug.Print("\ffmpeg\ffmpeg.exe", " -i """ & TextBox_AsfPath.Text & _
            //""" -an -ss 00:00:00 -r " & TextBox_CoverSetSec.Text & " """ & _
            //System.Windows.Forms.Application.StartupPath & "\tmp\image%08d.jpg""")

            double i = 0;
            try
            {
                i = double.Parse(TextBox_CoverSetSec.Text);
            }
            catch
            {
                i = 1;
            }
            //画像クリア
            foreach (string tempFile in System.IO.Directory.GetFiles(GetExeAppPath() + "\\tmp"))
            {
                System.IO.File.Delete(tempFile);
            }
            i = 1 / i;

            Process.Start(System.Windows.Forms.Application.StartupPath + "\\ffmpeg\\ffmpeg.exe", " -i \"" + TextBox_AsfPath.Text + "\" -an -ss 00:00:00 -r " + i + " -threads " + Environment.ProcessorCount.ToString() + " \"" + System.Windows.Forms.Application.StartupPath + "\\tmp\\image%08d.jpg\"");
        }

        private void Button1_Click(System.Object sender, System.EventArgs e)
        {
            //ファイル読み込み
            // StreamReader の新しいインスタンスを生成する
            dynamic cReader = null;
            dynamic cReaderH = null;

            try
            {
                cReader = new System.IO.StreamReader(TextBox_DatPath.Text, System.Text.Encoding.Default);
                if (!string.IsNullOrEmpty(TextBox_DatPath_Haven.Text))
                {
                    cReaderH = new System.IO.StreamReader(TextBox_DatPath_Haven.Text, System.Text.Encoding.Default);
                }
            }
            catch
            {
                MessageBox.Show("datファイルが読み込めませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
            }


            // 読み込んだ結果をすべて格納するための変数を宣言する
            string stResult = string.Empty;

            // オブジェクト配列
            List<Response> list = new List<Response>();
            int i = 0;

            //'本スレ
            // 読み込みできる文字がなくなるまで繰り返す
            try
            {
                while ((cReader.Peek() >= 0))
                {
                    i = i + 1;
                    // ファイルを 1 行ずつ読み込む
                    string stBuffer = cReader.ReadLine();
                    if (i < int.Parse((common.IsNumeric(TextBox_DatUseNumStart.Text) ? TextBox_DatUseNumStart.Text : "0")))
                    {
                        continue;
                    }
                    if (i > int.Parse((common.IsNumeric(TextBox_DatUseNumEnd.Text) ? TextBox_DatUseNumEnd.Text : "0")))
                    {
                        break; // TODO: might not be correct. Was : Exit While
                    }

                    string[] stArrayData = Strings.Split(stBuffer, "<>", -1, CompareMethod.Binary);
                    Response res = new Response();
                    res.name = stArrayData[0];
                    res.mail = stArrayData[1];
                    res.res = System.Text.RegularExpressions.Regex.Replace(stArrayData[3], "<br>", "\r\n");
                    res.dateid = stArrayData[2];
                    res.resnum = i;
                    res.havencode = 0;

                    res.datetime = DateTime.Parse(System.Text.RegularExpressions.Regex.Replace(res.dateid, "^(\\d{4}/\\d{2}/\\d{2})\\(.\\) (\\d{2}:\\d{2}:\\d{2}).*$", "$1 $2"));

                    //Debug.Print(res.dateid)

                    //格納
                    list.Add(res);
                }
            }
            catch
            {
                MessageBox.Show("本スレdat読み込みでエラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                // cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
                cReader.Close();
            }

            //'避難所
            int h = 0;
            try
            {
                if (!string.IsNullOrEmpty(TextBox_DatPath_Haven.Text))
                {
                    while ((cReaderH.Peek() >= 0))
                    {
                        h = h + 1;
                        // ファイルを 1 行ずつ読み込む
                        string stBuffer = cReaderH.ReadLine();
                        if (h < int.Parse((common.IsNumeric(TextBox_DatUseNumStart_Haven.Text) ? TextBox_DatUseNumStart_Haven.Text : "0")))
                        {
                            continue;
                        }
                        if (h > int.Parse((common.IsNumeric(TextBox_DatUseNumEnd_Haven.Text) ? TextBox_DatUseNumEnd_Haven.Text : "0")))
                        {
                            break; // TODO: might not be correct. Was : Exit While
                        }

                        string[] stArrayData = stBuffer.Split(new string[] { "<>" }, StringSplitOptions.None);
                        Response res = new Response();
                        res.name = stArrayData[1];
                        res.mail = stArrayData[2];
                        res.res = System.Text.RegularExpressions.Regex.Replace(stArrayData[4], "<br>", "\r\n");
                        res.dateid = stArrayData[3] + " ID:" + stArrayData[6];
                        res.resnum = int.Parse(stArrayData[0]);
                        res.havencode = 1;

                        res.datetime = DateTime.Parse(System.Text.RegularExpressions.Regex.Replace(res.dateid, "^(\\d{4}/\\d{2}/\\d{2})\\(.\\) (\\d{2}:\\d{2}:\\d{2}).*$", "$1 $2"));

                        //Debug.Print(res.dateid)

                        //格納
                        list.Add(res);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("避難所dat読み込みでエラーが発生しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            finally
            {
                // cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
                cReaderH.Close();
            }
            //ソートby dateid
            ResponseComparer comp = new ResponseComparer();
            list.Sort(comp);
            //Debug.Print(list.ToString)

            //tmpフォルダを参照して配列取得
            Singleton singleton = Singleton.GetInstance();
            string[] files = singleton.GetArray();
            bool firstFlag = false;
            long baseTick = 0L;

            //画面表示
            DataGridView DataGridView1 = Form.DataGridView1;
            for (int j = 0; j <= list.Count - 1; j++)
            {
                //---create a row---

                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(DataGridView1);

                //レス時刻を秒に直す
                long tick = list[j].datetime.ToLocalTime().Ticks;

                if (!string.IsNullOrEmpty(TextBox_LiveStartTime.Text))
                {
                    try
                    {
                        baseTick = list[j].datetime.ToLocalTime().Ticks;
                    }
                    catch
                    {
                        baseTick = 0L;
                    }

                }

                if (baseTick == 0 & firstFlag == false)
                {
                    baseTick = tick;
                    firstFlag = true;
                }

                //基準時刻との差分を出す
                dynamic coversec = 1;
                if (!string.IsNullOrEmpty(TextBox_CoverSetSec.Text))
                {
                    try
                    {
                        coversec = int.Parse(TextBox_CoverSetSec.Text);
                    }
                    catch
                    {
                        coversec = 1;
                    }
                }
                long sec = (tick - baseTick) / (10000000 * coversec);

                //配列内の秒に収まれば割り付け、ない場合は最初か最後
                string imgname = string.Empty;
                if (sec < files.Length)
                {
                    imgname = string.Format("image{0:00000000}.jpg", sec + 1);
                }
                else
                {
                    imgname = string.Format("image{0:00000000}.jpg", files.Length);
                }


                var _with1 = item;
                _with1.Cells[(int)common.RowType.ResNum].Value = list[j].resnum;
                _with1.Cells[(int)common.RowType.Image].Value = new Bitmap(common.GetExeAppPath() + "\\tmp\\" + imgname);
                _with1.Cells[(int)common.RowType.ImageAdopt].Value = true;
                _with1.Cells[(int)common.RowType.Res].Value = list[j].name + " " + list[j].dateid + "\r\n" + list[j].res;
                _with1.Cells[(int)common.RowType.ResAdopt].Value = true;
                _with1.Cells[(int)common.RowType.ImageName].Value = imgname;
                _with1.Cells[(int)common.RowType.Timestamp].Value = list[j].datetime;
                _with1.Cells[(int)common.RowType.Name].Value = list[j].name;
                _with1.Cells[(int)common.RowType.Mail].Value = list[j].mail;
                _with1.Cells[(int)common.RowType.DateId].Value = list[j].dateid;
                _with1.Cells[(int)common.RowType.ResRaw].Value = list[j].res;
                _with1.Cells[(int)common.RowType.HavenCode].Value = list[j].havencode;

                //---add the row---
                DataGridView1.Rows.Add(item);
            }


            Form.Focus();

        }


        private void TabPage_Config_Click(System.Object sender, System.EventArgs e)
        {
        }

        private void TextBox_LiveStartTime_Validating(System.Object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox_LiveStartTime.Text))
            {
                e.Cancel = true;
                return;
            }
        }

        private void Button_DatPathRef_Haven_Click(System.Object sender, System.EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき
                //選択されたファイル名を表示する
                TextBox_DatPath_Haven.Text = OpenFileDialog1.FileName;
            }
        }

        //並び替える方法を定義するクラス
        //IComparerインターフェイスを実装する
        public class ResponseComparer : System.Collections.IComparer
        {

            //xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
            public int Compare(object x, object y)
            {

                //Nothingが最も小さいとする
                if (x == null && y == null)
                {
                    return 0;
                }
                if (x == null)
                {
                    return -1;
                }
                if (y == null)
                {
                    return 1;
                }

                //String型以外の比較はエラー
                if (!(x is Response))
                {
                    throw new ArgumentException("Response型でなければなりません。", "x");
                }
                else if (!(y is Response))
                {
                    throw new ArgumentException("Response型でなければなりません。", "y");
                }

                //文字列の長さを比較する
                return ((Response)x).datetime.CompareTo(((Response)y).datetime);
                //または、次のようにもできる
                //Return DirectCast(x, String).Length - DirectCast(y, String).Length
            }
        }
        public main()
        {
            Load += main_Load;
        }

    }


    //Base Design
    //機能設計
    //Form初期化


    //○XML読み込み／設定処理→My.settingsを使う 済
    //・XMLファイルから保存してある設定値を読み込む
    //・値をmainに適用
    //

    //○main初期化 済
    //・Const値設定
    //・ログテーブル初期化 済
    //
    //
    //画面機能
    //○DATチェックボックス選択時処理 済
    //DATボックス選択時（オフ）デフォルトはオン
    //・DATパネル要素をすべて非アクティブにする
    //・PEGチェックがオフの場合、実行ボタンを非アクティブにする
    //
    //DATボックス選択時（オン） 済
    //・DATパネル要素をすべてアクティブにする
    //・実行ボタンをアクティブにする
    //
    //○DATパス入力処理 済
    //・参照ボタン押下時、OpenFileDialogを開いて選択
    //・バリデーションはなし。
    //
    //○DATナンバー入力時処理 済
    //・バリデーション。数値、-,以外は不許可
    //
    //

    //○PEGチェックボックス選択時処理 済
    //PEGボックス選択時（オフ）デフォルトはオン
    //・PEGパネル要素をすべて非アクティブにする
    //・DATチェックがオフの場合、実行ボタンを非アクティブにする
    //
    //PEGボックス選択時（オン） 済
    //・PEGパネル要素をすべてアクティブにする
    //・実行ボタンをアクティブにする
    //
    //○ASFパス入力処理 済
    //・参照ボタン押下時、OpenFileDialogを開いて選択
    //・バリデーションはなし。

    //○StartTimeラジオボタン処理　デフォルトは上 済
    //・選択時、対応項目をアクティブ化。もう一方を非アクティブ化
    //
    //○StartTime入力時処理 済
    //・レス番号入力時バリデーション。数値のみ 済
    //・時刻入力時バリデーション。yyyy-mm-dd hh:mm:ss の形式にフォーマッティング。 済
    //

    //
    //○EndTimeラジオボタン処理　デフォルトは上 済
    //・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済

    //○EndTime入力時処理 済
    //・時刻入力時バリデーション。yyyy-mm-dd hh:mm:ss の形式にフォーマッティング。 済
    //

    //○Imageラジオボタン処理　デフォルトは上 済
    //・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済

    //○Image入力時処理 済
    //・入力時バリデーション。数値のみ 済
    //

    //○Coverラジオボタン処理　デフォルトは上 済
    //・選択時、対応項目をアクティブ化。もう一方を非アクティブ化 済
    //
    //○Cover入力時処理 済 済
    //・入力時バリデーション。数値のみ 済

    //
    //○テンプレパス入力処理 済
    //・参照ボタン押下時、OpenFileDialogを開いて選択
    //・バリデーションはなし。

    //
    //○実行ボタン押下時処理

    //・view初期化処理
    //・DataGridViewとdialog呼び出し
    //・実行時エラーチェック
    //-ffmpeg存在チェック
    //-dat存在チェック
    //-テンプレ存在チェック（worning）

    //・プログレスダイアログ表示
    //
    //・DATチェック時
    //※DAT読み出し処理
    //
    //・PEGチェック時
    //※PEG抽出処理
    //
    //※リスト作成処理
    //
    //
    //・処理結果表示（view呼び出し）
    //-結果リストを入力
    //
    //○終了時処理 済
    //・XML出力→My.settingsを使う
    //

    //○Error
    //
    //個別処理
    //
    //■DAT読み出し処理
    //○read
    //
    //
    //○Parse
    //・抽出対象番号解釈
    //・リスト作成
    //
    //
    //
    //○Error
    //
    //
    //■PEG抽出処理
    //○コマンド作成
    //
    //
    //
    //○コマンド実行（呼び出し）
    //・フォルダなければ作成（result）
    //
    //
    //○リスト作成
    //
    //○Error
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
    //
}
