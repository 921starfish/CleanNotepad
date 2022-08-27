using CleanNotepad.Entity;
using CleanNotepad.UseCase;

namespace CleanNotepad
{
    public partial class Notepad : Form
    {
        private SaveNote saveNote;
        private LoadNote loadNote;

        public Notepad(SaveNote _saveNote, LoadNote _loadNote)
        {
            InitializeComponent();
            saveNote = _saveNote;
            loadNote = _loadNote;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var memo = new MemoEntity(textBox1.Text);
                saveNote.Save(memo);

                // 表示のための具象処理
                label1.Text = "保存しました：" + memo.MemoText;
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
        private void button2_Click(object sender, EventArgs e)
        {
            var memos = loadNote.Load();
            listBox1.Items.AddRange(memos.Select(x => x.MemoText).ToArray());
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