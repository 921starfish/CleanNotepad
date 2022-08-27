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

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var memo = new MemoEntity(textBox1.Text);
                await saveNote.SaveAsync(memo);

                // •\Ž¦‚Ì‚½‚ß‚Ì‹ïÛˆ—
                label1.Text = "•Û‘¶‚µ‚Ü‚µ‚½F" + memo.MemoText;
            }
            catch (Exception ex)
            {
                // —áŠOˆ—
                label1.Text = ex.Message;
            }
            finally
            {
                textBox1.Text = string.Empty;
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            var memos = await loadNote.LoadAsync();
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