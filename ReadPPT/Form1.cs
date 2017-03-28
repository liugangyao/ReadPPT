using liugyOfficeUtl;
using System;
using System.Windows.Forms;

namespace ReadPPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            if (txtBoxPath.Text.Length == 0)
            {
                MessageBox.Show("Please select a path!!!!");

            }
            else
            {
                string folderPath = txtBoxPath.Text;

                this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                //read PPT to text file by calling common method.
                LiugyPPT.readPPT2txt(folderPath, folderPath);

                this.Cursor = System.Windows.Forms.Cursors.Default;

                MessageBox.Show("END!!!!");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtBoxPath.Focus();
        }

         private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.Description = "Read PPT content to Text file!";

            folderBrowserDialog1.RootFolder =System.Environment.SpecialFolder.MyComputer;

            folderBrowserDialog1.SelectedPath = @"E:\仕事\Project\SRM推進部\00_見積書作成\06_提案書";

            folderBrowserDialog1.ShowNewFolderButton = false;

            // Show the dialog
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }

            folderBrowserDialog1.Dispose();
        }
    }
}
