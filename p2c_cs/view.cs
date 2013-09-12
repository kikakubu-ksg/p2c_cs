using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p2c_cs
{
    public partial class view : Form
    {

        private void DataGridView1_CellContentClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns(e.ColumnIndex).Name == "Button")
            {
                //一行上に移動
                if (e.RowIndex == 0)
                {
                    return;
                }


                DataGridViewRow item1 = new DataGridViewRow();
                item1.CreateCells(DataGridView1);
                var _with1 = item1;
                for (int i = 0; i <= _with1.Cells.Count - 1; i++)
                {
                    _with1.Cells(i).Value = dgv.Rows(e.RowIndex).Cells(i).Value;
                }



                dgv.Rows.Insert(e.RowIndex - 1, item1);
                dgv.Rows.Remove(dgv.Rows(e.RowIndex + 1));


                //MessageBox.Show((e.RowIndex.ToString() + _
                //    "行のボタンがクリックされました。"))
            }

            if (dgv.Columns(e.ColumnIndex).Name == "Button2")
            {
                //一行下に移動
                if (e.RowIndex >= dgv.Rows.Count - 2)
                {
                    return;
                }

                DataGridViewRow item1 = new DataGridViewRow();
                item1.CreateCells(DataGridView1);
                var _with2 = item1;
                for (int i = 0; i <= _with2.Cells.Count - 1; i++)
                {
                    _with2.Cells(i).Value = dgv.Rows(e.RowIndex).Cells(i).Value;
                }


                dgv.Rows.Insert(e.RowIndex + 2, item1);
                dgv.Rows.Remove(dgv.Rows(e.RowIndex));

            }

        }



        private void view_Load(System.Object sender, System.EventArgs e)
        {

            //     Dim students() As CStudent = _
            //{New CStudent("123-456-789", "John"), _
            // New CStudent("456-123-789", "Mary")}
            //     DataGridView1.DataSource = students

            //---add columns to the DataGridView control---
            DataGridView1.Columns(RowType.ResNum).HeaderText = "レス番";
            //DataGridView1.Columns.Add("ID", "ID")
            //DataGridViewImageColumnの作成
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            //列の名前を設定
            column.Name = "画像";
            //Icon型ではなく、Image型のデータを表示する
            //デフォルトでFalseなので、変更する必要はない
            column.ValuesAreIcons = false;
            //値の設定されていないセルに表示するイメージを設定する
            //column.Image = New Bitmap("C:\null.gif")
            //イメージを縦横の比率を維持して拡大、縮小表示する
            column.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //イメージの説明
            //セルをクリップボードにコピーした時に使用される
            column.Description = "画像";
            //デフォルト画像を表示せず
            column.DefaultCellStyle.NullValue = null;

            //DataGridViewに追加する
            DataGridView1.Columns.Add(column);

            //DataGridView1.Columns.Add("ga1", "画像選択")
            DataGridViewCheckBoxColumn imageAdoptColumn = new DataGridViewCheckBoxColumn();
            imageAdoptColumn.Name = "画像採用";
            DataGridView1.Columns.Add(imageAdoptColumn);
            //DataGridView1.Columns.Add("ga2", "画像採用")
            DataGridView1.Columns.Add("Comment", "コメント");
            DataGridView1.Columns.Add("Res", "レス");
            DataGridViewCheckBoxColumn resAdoptColumn = new DataGridViewCheckBoxColumn();
            resAdoptColumn.Name = "レス採用";
            DataGridView1.Columns.Add(resAdoptColumn);
            //DataGridView1.Columns.Add("res2", "レス採用")

            //hidden
            DataGridView1.Columns.Add("h1", "画像ファイル名");
            DataGridView1.Columns.Add("h2", "timestamp");
            DataGridView1.Columns.Add("h3", "name");
            DataGridView1.Columns.Add("h4", "mail");
            DataGridView1.Columns.Add("h5", "dateid");
            DataGridView1.Columns.Add("h6", "レス");
            DataGridView1.Columns.Add("h7", "予備２");
            DataGridView1.Columns.Add("h8", "予備３");

            DataGridView1.Columns(RowType.ResNum).Width = 20;
            DataGridView1.Columns(RowType.Image).Width = 200;
            DataGridView1.Columns(RowType.ImageAdopt).Width = 20;
            DataGridView1.Columns(RowType.Comment).Width = 200;
            DataGridView1.Columns(RowType.Res).Width = 200;
            DataGridView1.Columns(RowType.ResAdopt).Width = 20;



            //'---create a new bindingsource control---
            //Dim bindingsource As New BindingSource

            //'---add the items into the control---
            //bindingsource.Add("Type A")
            //bindingsource.Add("Type B")
            //bindingsource.Add("Type C")


            //'---create a combobox column---
            //Dim comboBoxCol As New DataGridViewComboBoxColumn

            //'---set the header---
            //comboBoxCol.HeaderText = "Types"

            //'---data bind it---

            //comboBoxCol.DataSource = bindingsource

            //'---add a combobox column to the DataGridView control---
            //DataGridView1.Columns.Add(comboBoxCol)


            //For i As Integer = 0 To 30
            //    '---create a row---

            //    Dim item As New DataGridViewRow
            //    item.CreateCells(DataGridView1)
            //    With item
            //        .Cells(0).Value = i
            //        .Cells(1).Value = "Product " & i
            //        .Cells(2).Value = "Description of " & vbCrLf & vbCrLf & "Product " & i
            //        '.Cells(3).Value = "99.99"

            //    End With
            //    '---add the row---
            //    DataGridView1.Rows.Add(item)
            //Next

            //DataGridViewButtonColumnの作成
            //Dim column As New DataGridViewButtonColumn()
            //'列の名前を設定
            //column.Name = "Button"
            //'全てのボタンに"詳細閲覧"と表示する
            //column.UseColumnTextForButtonValue = True
            //column.Text = "△"
            //'DataGridViewに追加する
            //DataGridView1.Columns.Add(column)

            //DataGridView1.Columns(6).Width = 30


            //'DataGridViewButtonColumnの作成
            //Dim column2 As New DataGridViewButtonColumn()
            //'列の名前を設定
            //column2.Name = "Button2"
            //'全てのボタンに"詳細閲覧"と表示する
            //column2.UseColumnTextForButtonValue = True
            //column2.Text = "▽"
            //'DataGridViewに追加する
            //DataGridView1.Columns.Add(column2)

            //DataGridView1.Columns(7).Width = 30

            //全ての列の背景色を水色にする
            DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            //奇数行を黄色にする
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


            // セル内で文字列を折り返す
            DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // 文字列全体が表示されるように行の高さを自動調節する
            DataGridView1.AutoResizeRows();

            //DataGridView1にユーザーが新しい行を追加できないようにする
            DataGridView1.AllowUserToAddRows = false;

            DataGridView1.RowTemplate.HeaderCell = new myDataGridViewRowHeaderCell();

        }



        private void DataGridView1_CellPainting(object sender, System.Windows.Forms.DataGridViewCellPaintingEventArgs e)
        {
            //'列ヘッダーかどうか調べる
            //If e.ColumnIndex < 0 And e.RowIndex >= 0 Then
            //    'セルを描画する
            //    e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

            //    '行番号を描画する範囲を決定する
            //    'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
            //    Dim indexRect As Rectangle = e.CellBounds
            //    indexRect.Inflate(-2, -2)
            //    '行番号を描画する
            //    TextRenderer.DrawText(e.Graphics, _
            //        (e.RowIndex + 1).ToString(), _
            //        e.CellStyle.Font, _
            //        indexRect, _
            //        e.CellStyle.ForeColor, _
            //        TextFormatFlags.Right Or TextFormatFlags.VerticalCenter)
            //    '描画が完了したことを知らせる
            //    e.Handled = True
            //End If

            //'ヘッダー以外のセルで、背景を描画する時
            //If e.ColumnIndex = 0 AndAlso e.RowIndex = 0 AndAlso _
            //    (e.PaintParts And DataGridViewPaintParts.Background) = _
            //        DataGridViewPaintParts.Background Then
            //    '背景だけを描画する
            //    Dim backParts As DataGridViewPaintParts = _
            //        e.PaintParts And (DataGridViewPaintParts.Background Or _
            //            DataGridViewPaintParts.SelectionBackground)
            //    e.Paint(e.ClipBounds, backParts)

            //    '画像をセルの範囲いっぱいに表示する
            //    'e.Graphics.DrawImage(cellBackImage, e.CellBounds)
            //    e.Graphics.DrawImage(cellBackImage, e.CellBounds.Left, e.CellBounds.Top, cellBackImage.Width, cellBackImage.Height)

            //    DataGridView1.Columns(0).MinimumWidth = cellBackImage.Width
            //    DataGridView1.Rows(e.RowIndex).MinimumHeight = cellBackImage.Height



            //    '背景以外が描画されるようにする
            //    Dim paintParts As DataGridViewPaintParts = _
            //        e.PaintParts And Not backParts
            //    'セルを描画する
            //    e.Paint(e.ClipBounds, paintParts)

            //    '描画が完了したことを知らせる
            //    e.Handled = True
            //End If


        }


        /// <summary>
        /// 選択しているセルをひとつ上にあげる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>

        private void UpButton_Click(System.Object sender, System.EventArgs e)
        {
            DataGridView dgv = DataGridView1;
            DataGridViewCell cel = dgv.CurrentCell;

            //一行上に移動
            if (cel == null)
            {
                MessageBox.Show("セルが選択されていません。");
                return;
            }
            if (cel.RowIndex == 0 & dgv.SelectedCells.Count > 0)
            {
                return;
            }

            DataGridViewRow item1 = new DataGridViewRow();
            item1.CreateCells(DataGridView1);
            var _with3 = item1;
            for (int i = 0; i <= _with3.Cells.Count - 1; i++)
            {
                _with3.Cells(i).Value = dgv.Rows(cel.RowIndex).Cells(i).Value;
            }

            dgv.Rows.Insert(cel.RowIndex - 1, item1);
            dgv.Rows.Remove(dgv.Rows(cel.RowIndex));

            dgv.ClearSelection();
            dgv.CurrentCell = DataGridView1(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex - 2);

        }

        /// <summary>
        /// 選択しているセルをひとつ下にさげる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks></remarks>

        private void DownButton_Click(System.Object sender, System.EventArgs e)
        {
            DataGridView dgv = DataGridView1;
            DataGridViewCell cel = dgv.CurrentCell;

            //一行下に移動
            if (cel == null)
            {
                MessageBox.Show("セルが選択されていません。");
                return;
            }
            if (cel.RowIndex >= dgv.Rows.Count - 1 & dgv.SelectedCells.Count > 0)
            {
                return;
            }

            DataGridViewRow item1 = new DataGridViewRow();
            item1.CreateCells(DataGridView1);
            var _with4 = item1;
            for (int i = 0; i <= _with4.Cells.Count - 1; i++)
            {
                _with4.Cells(i).Value = dgv.Rows(cel.RowIndex).Cells(i).Value;
            }

            dgv.Rows.Insert(cel.RowIndex + 2, item1);
            dgv.Rows.Remove(dgv.Rows(cel.RowIndex));

            dgv.ClearSelection();
            dgv.CurrentCell = DataGridView1(dgv.CurrentCell.ColumnIndex, dgv.CurrentCell.RowIndex + 1);
        }


        private void RightButton_Click(System.Object sender, System.EventArgs e)
        {
            //行追加
            //カレント行取得
            DataGridView dgv = DataGridView1;
            try
            {
                DataGridViewCell dgvc = dgv.SelectedCells.Item(0);
                dgv.Rows.Insert(dgvc.RowIndex, 1);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("行を追加できません。" + Constants.vbCrLf + ex.Message);
            }



        }


        private void RightButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //表示する文字列
            string s = "▲";

            //ワールド変換行列を45度回転する
            e.Graphics.RotateTransform(90f);
            e.Graphics.TranslateTransform(4, -20);

            //文字列を描画
            e.Graphics.DrawString(s, this.Font, Brushes.Black, 0, 0);

        }

        private void LeftButton_Click(System.Object sender, System.EventArgs e)
        {
            //行削除
            DataGridView dgv = DataGridView1;
            try
            {
                DataGridViewCell dgvc = dgv.SelectedCells.Item(0);
                dgv.Rows.RemoveAt(dgvc.RowIndex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("行を削除できません。" + Constants.vbCrLf + ex.Message);
            }

        }

        private void LeftButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            //表示する文字列
            string s = "▼";

            //ワールド変換行列を45度回転する
            e.Graphics.RotateTransform(90f);
            e.Graphics.TranslateTransform(4, -20);

            //文字列を描画
            e.Graphics.DrawString(s, this.Font, Brushes.Black, 0, 0);

        }

        private void PreviousImage_Click(System.Object sender, System.EventArgs e)
        {
            //カレント行取得
            DataGridView dgv = DataGridView1;
            DataGridViewCell dgvc = default(DataGridViewCell);
            try
            {
                dgvc = dgv.SelectedCells.Item(0);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("行がありません。" + Constants.vbCrLf + ex.Message);
                return;
            }
            string currentStr = dgv(RowType.ImageName, dgvc.RowIndex).Value;

            Singleton singleton = singleton.GetInstance();
            string pi = singleton.GetPreviousImage(GetExeAppPath() + "\\tmp\\" + currentStr);

            if (pi == null)
                return;

            //画像変更
            dgv(RowType.Image, dgvc.RowIndex).Value = new Bitmap(pi);
            //ファイル名変更
            dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() + "\\tmp\\", "");

        }

        private void NextImage_Click(System.Object sender, System.EventArgs e)
        {
            //カレント行取得
            DataGridView dgv = DataGridView1;
            DataGridViewCell dgvc = default(DataGridViewCell);
            try
            {
                dgvc = dgv.SelectedCells.Item(0);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("行がありません。" + Constants.vbCrLf + ex.Message);
                return;
            }
            string currentStr = dgv(RowType.ImageName, dgvc.RowIndex).Value;

            Singleton singleton = singleton.GetInstance();
            string pi = singleton.GetNextImage(GetExeAppPath() + "\\tmp\\" + currentStr);

            if (pi == null)
                return;

            //画像変更
            dgv(RowType.Image, dgvc.RowIndex).Value = new Bitmap(pi);
            //ファイル名変更
            dgv(RowType.ImageName, dgvc.RowIndex).Value = pi.Replace(GetExeAppPath() + "\\tmp\\", "");
        }


        private void htmloutput_Click(System.Object sender, System.EventArgs e)
        {
            //テキスト構築
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string imageDir = TextBox_ImageDir.Text;
            ///をとる
            imageDir = System.Text.RegularExpressions.Regex.Replace(imageDir, "/$", "");
            //画像クリア
            foreach (string tempFile in System.IO.Directory.GetFiles(GetExeAppPath() + "\\htmlimg"))
            {
                System.IO.File.Delete(tempFile);
            }
            foreach (DataGridViewRow dgvr in DataGridView1.Rows)
            {
                string comClass = "<DIV class='_comment_no_image";
                if (dgvr.Cells.Item(RowType.ImageAdopt).Value == true)
                {
                    //ファイルコピー
                    System.IO.File.Copy(GetExeAppPath() + "\\tmp\\" + dgvr.Cells.Item(RowType.ImageName).Value, GetExeAppPath() + "\\htmlimg\\" + dgvr.Cells.Item(RowType.ImageName).Value, true);
                    //image
                    sb.Append("<DIV class='_image'><IMG SRC='").Append(imageDir).Append("/").Append(dgvr.Cells.Item(RowType.ImageName).Value).Append("' /></DIV>").Append(Constants.vbCrLf);
                    comClass = "<DIV class='_comment_with_image";
                }
                //comment
                if (!string.IsNullOrEmpty(dgvr.Cells.Item(RowType.Comment).Value))
                {
                    sb.Append(comClass).Append(" " + dgvr.Cells.Item(RowType.Comment).Tag + "'>").Append(dgvr.Cells.Item(RowType.Comment).Value).Append("</DIV>").Append(Constants.vbCrLf);
                }
                if (dgvr.Cells.Item(RowType.ResAdopt).Value == true)
                {
                    //ress
                    sb.Append("<DIV class='_reshead'><span class='_resnum " + dgvr.Cells.Item(RowType.ResNum).Tag + "'>").Append((RowType.HavenCode == 1 ? "<span class='_havenmark'>避</span>" : "")).Append(dgvr.Cells.Item(RowType.ResNum).Value).Append("</span>").Append("<span class='_name " + dgvr.Cells.Item(RowType.Name).Tag + "'>").Append(dgvr.Cells.Item(RowType.Name).Value).Append("</span>").Append("<span class='_dateid " + dgvr.Cells.Item(RowType.DateId).Tag + "'>").Append(dgvr.Cells.Item(RowType.DateId).Value).Append("</span>").Append("</DIV>").Append(Constants.vbCrLf);
                    string t = dgvr.Cells.Item(RowType.ResRaw).Value;
                    sb.Append("<DIV class='_res " + dgvr.Cells.Item(RowType.ResRaw).Tag + "'>").Append(t.Replace(Constants.vbCrLf, "<br />")).Append("</DIV>").Append(Constants.vbCrLf);
                }

            }

            //テキスト出力
            System.IO.StreamWriter sw = new System.IO.StreamWriter(GetExeAppPath() + "\\hoge.html", false, System.Text.Encoding.GetEncoding("utf-8"));
            sw.Write(sb.ToString());
            //閉じる
            sw.Close();

            //htmlを開く
            System.Diagnostics.Process.Start(GetExeAppPath() + "\\hoge.html");

        }

        private void PreviousImageAll_Click(System.Object sender, System.EventArgs e)
        {
            DataGridView dgv = DataGridView1;
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                string currentStr = dgv(common.RowType.ImageName, dgvr.Index).Value;

                Singleton singleton = singleton.GetInstance();
                string pi = singleton.GetPreviousImage(GetExeAppPath() + "\\tmp\\" + currentStr);

                if ((pi != null))
                {
                    //画像変更
                    dgv(RowType.Image, dgvr.Index).Value = new Bitmap(pi);
                    //ファイル名変更
                    dgv(RowType.ImageName, dgvr.Index).Value = pi.Replace(GetExeAppPath() + "\\tmp\\", "");
                }
            }
        }

        private void NextImageAll_Click(System.Object sender, System.EventArgs e)
        {
            DataGridView dgv = DataGridView1;
            foreach (DataGridViewRow dgvr in dgv.Rows)
            {
                string currentStr = dgv(RowType.ImageName, dgvr.Index).Value;

                Singleton singleton = singleton.GetInstance();
                string pi = singleton.GetNextImage(GetExeAppPath() + "\\tmp\\" + currentStr);

                if ((pi != null))
                {
                    //画像変更
                    dgv(RowType.Image, dgvr.Index).Value = new Bitmap(pi);
                    //ファイル名変更
                    dgv(RowType.ImageName, dgvr.Index).Value = pi.Replace(GetExeAppPath() + "\\tmp\\", "");
                }
            }
        }

        private void Button_Normal_Click(System.Object sender, System.EventArgs e)
        {
            foreach (DataGridViewCell c in DataGridView1.SelectedCells)
            {
                c.Tag = "";
                c.Style.BackColor = SystemColors.Control;
            }

        }

        private void Button_EX1_Click(System.Object sender, System.EventArgs e)
        {
            foreach (DataGridViewCell c in DataGridView1.SelectedCells)
            {
                c.Tag = "ex1";
                c.Style.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void Button_EX2_Click(System.Object sender, System.EventArgs e)
        {
            foreach (DataGridViewCell c in DataGridView1.SelectedCells)
            {
                c.Tag = "ex2";
                c.Style.BackColor = Color.FromArgb(128, 128, 255);
            }
        }

        private void Button_EX3_Click(System.Object sender, System.EventArgs e)
        {
            foreach (DataGridViewCell c in DataGridView1.SelectedCells)
            {
                c.Tag = "ex3";
                c.Style.BackColor = Color.Yellow;
            }
        }
        public view()
        {
            Load += view_Load;
        }

    }

    //Public Class CStudent
    //    Private _name As String
    //    Private _ID As String

    //    Public Sub New(ByVal id As String, ByVal name As String)
    //        _ID = id
    //        _name = name
    //    End Sub

    //    Public Property Name() As String
    //        Get
    //            Return _name
    //        End Get

    //        Set(ByVal value As String)
    //            _name = value
    //        End Set
    //    End Property

    //    Public Property ID() As String
    //        Get
    //            Return _ID
    //        End Get

    //        Set(ByVal value As String)
    //            _ID = value
    //        End Set
    //    End Property

    //End Class


    //Public Class CStringItem
    //    Private _str As String
    //    Public Sub New(ByVal str As String)
    //        _str = str
    //    End Sub

    //    Public Property Name() As String
    //        Get
    //            Return _str
    //        End Get

    //        Set(ByVal value As String)
    //            _str = value
    //        End Set
    //    End Property

    //End Class



    public class myDataGridViewRowHeaderCell : DataGridViewRowHeaderCell
    {

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle,
            paintParts & !DataGridViewPaintParts.ContentBackground);
        }

    }

    public class Singleton
    {

        private static Singleton _singleton = new Singleton();

        private string[] files;
        // コンストラクタです。(外部からのアクセス不可)
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
            //ファイル配列取得
            files = System.IO.Directory.GetFiles(GetExeAppPath() + "\\tmp", "*");
            //ソート
            Array.Sort(files);
        }

        // 唯一のインスタンスを取得します。
        public static Singleton GetInstance()
        {
            // Console.WriteLine("return singleton.")
            return _singleton;
        }

        //配列を返却
        public string[] GetArray()
        {
            return files;
        }

        //前画像
        public string GetPreviousImage(string currentStr)
        {
            //インデックスを探す
            dynamic index = Array.IndexOf(files, currentStr);

            if (index > 0)
            {
                //前画像返却
                return files[index - 1];
            }
            else
            {
                return null;
            }

        }

        //後画像
        public string GetNextImage(string currentStr)
        {
            //インデックスを探す
            dynamic index = Array.IndexOf(files, currentStr);

            if (index != -1 & index < files.Length - 1)
            {
                //前画像返却
                return files[index + 1];
            }
            else
            {
                return null;
            }
        }

        //再取得
        public static Singleton ReGetInstance()
        {
            _singleton = new Singleton();
            Console.WriteLine("インスタンスを生成しました。");
            //ファイル配列取得
            _singleton.files = System.IO.Directory.GetFiles(GetExeAppPath() + "\\tmp", "*");
            //ソート
            Array.Sort(_singleton.files);
            return _singleton;
        }

    }

    //memo
    //IMG行かTXT行かで上下移動の処理を変える。
    //行コピー機能が必要？
    //ソース直修モードもほしい

    //
    //
    //
    //
}
