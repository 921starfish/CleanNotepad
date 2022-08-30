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
                // �ۑ�����
                var memoText = await memoController.SaveMemoAsync(textBox1.Text);

                // �\���̂��߂̋�ۏ���
                label1.Text = "�ۑ����܂����F" + memoText;
            }
            catch (Exception ex)
            {
                // ��O����
                label1.Text = ex.Message;
            }
            finally
            {
                textBox1.Text = string.Empty;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            // �ǂݍ��ݏ���
            var memos = await memoController.LoadMemoAsync();

            // �\���̂��߂̋�ۏ���
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