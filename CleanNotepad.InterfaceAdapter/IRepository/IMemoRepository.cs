using CleanNotepad.Entity;

namespace CleanNotepad.InterfaceAdapter.IRepository
{
    public interface IMemoRepository
    {
        public Task<bool> SaveMemoAsync(MemoEntity note);
    }
}