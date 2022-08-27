using CleanNotepad.Entity;
using CleanNotepad.UseCase;

namespace CleanNotepad
{
    public partial class Notepad : Form
    {
        private SaveNote saveNote;

        public Notepad(SaveNote _saveNote)
        {
            InitializeComponent();
            saveNote = _saveNote;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var memo = new MemoEntity(textBox1.Text);
                saveNote.Save(memo);
                // 描画のための具象処理はUIレイヤーに出るかも
                listBox1.Items.Add(textBox1.Text);
            }
            catch(Exception ex)
            {
                // 例外処理
                label1.Text = ex.Message;
            }
            finally
            {
                textBox1.Text = string.Empty;
            }
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