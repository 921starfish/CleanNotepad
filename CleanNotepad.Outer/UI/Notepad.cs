using CleanNotepad.Entity;
using CleanNotepad.InterfaceAdapterForUI;
using CleanNotepad.UseCase;
using System.Windows.Forms;

namespace CleanNotepad.Outer.UI
{
    public partial class Notepad : Form
    {
        private MemoController memoController;

        public Notepad(MemoController _memoController)
        {
            InitializeComponent();
            memoController = _memoController;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 保存処理
                var memoText = await memoController.SaveMemoAsync(textBox1.Text);

                // 表示のための具象処理
                label1.Text = "保存しました：" + memoText;
            }
            catch (Exception ex)
            {
                // 例外処理
                label1.Text = ex.Message;
            }
            finally
            {
                textBox1.Text = string.Empty;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            // 読み込み処理
            var memos = await memoController.LoadMemoAsync();

            // 表示のための具象処理
            listBox1.Items.Clear();
            listBox1.Items.AddRange(memos);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}