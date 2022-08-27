using CleanNotepad.Entity;
using CleanNotepad.UseCase.IRepository;

namespace CleanNotepad.UseCase
{
    public class SaveNote
    {

        private IMemoRepository memoRepository;

        public SaveNote(IMemoRepository _memoRepository)
        {
            memoRepository = _memoRepository;
        }

        // 「保存する」のはアプリケーション固有のロジック → ユースケース
        public async Task<bool> SaveAsync(MemoEntity note)
        {
            // 「保存」には具象の知識（例：DB、フォルダ、etc）が必要だが、ユースケースが具象を知ってはならない。
            // InterfaceAdapterレイヤーに、インターフェース経由でアクセスする
            return await memoRepository.SaveMemoEntityAsync(note);
        }
    }
}