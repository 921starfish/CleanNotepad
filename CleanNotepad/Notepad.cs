using CleanNotepad.UseCase;

namespace CleanNotepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
            saveNote = new SaveNote(null);
        }

        private SaveNote saveNote;

        private void button1_Click(object sender, EventArgs e)
        {
            saveNote.Save(new Entity.MemoEntity(textBox1.Text));

            // ï`âÊÇÃÇΩÇﬂÇÃãÔè€Ç»èàóù
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
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