using CleanNotepad.Entity;
using CleanNotepad.UseCase;

namespace CleanNotepad.InterfaceAdapterForUI
{
    public class MemoController
    {
        private SaveNote saveNote;
        private LoadNote loadNote;

        public MemoController(SaveNote _saveNote, LoadNote _loadNote)
        {
            saveNote = _saveNote;
            loadNote = _loadNote;
        }

        public async Task<string> SaveMemoAsync(string rawString)
        {
            // UIに都合のいいstringを
            // Entityに変換
            var memo = new MemoEntity(rawString);

            // 保存はユースケースが担う
            await saveNote.SaveAsync(memo);
            return memo.MemoText;
        }

        public async Task<string[]> loadMemoAsync()
        {
            // 読み込みはユースケースが担う
            var memos = await loadNote.LoadAsync();

            // EntityのIEnumerableを
            // UIに都合のいいstring[]に変換
            return memos.Select(x => x.MemoText).ToArray();
        }
    }
}