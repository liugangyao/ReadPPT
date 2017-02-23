using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiugyCommon;

namespace ReadPPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            // FolderBrowserDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            // ダイアログの説明を設定する
            folderBrowserDialog1.Description = "ここに説明を書いてください";

            // ルートになる特殊フォルダを設定する (初期値 SpecialFolder.Desktop)
            folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // 初期選択するパスを設定する
            folderBrowserDialog1.SelectedPath = @"E:\仕事\Project\SRM推進部\00_見積書作成\06_提案書";

            // [新しいフォルダ] ボタンを表示する (初期値 true)
            folderBrowserDialog1.ShowNewFolderButton = false;

            // ダイアログを表示し、戻り値が [OK] の場合は、選択したディレクトリを表示する
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
            }

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            folderBrowserDialog1.Dispose();

            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            LiugyPPT.readPPT2txt(folderPath, folderPath);

            this.Cursor = System.Windows.Forms.Cursors.Default;

            MessageBox.Show("END!!!!");

        }
    }
}
