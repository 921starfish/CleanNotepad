using CleanNotepad.Entity;
using CleanNotepad.InterfaceAdapter.DBObject;
using CleanNotepad.UseCase.IRepository;

namespace CleanNotepad.InterfaceAdapter.Repository
{
    public class MemoRepository : IMemoRepository
    {
        public bool SaveMemoEntity(MemoEntity memoEntity)
        {
            // インターフェイスアダプターは、エンティティをDBに都合のよいオブジェクトに変換する
            // 処理を切り出してもよい
            var memoDBObject = new MemoDBObject(memoEntity.MemoText);

            // ここに具象保存処理
            return true;
        }
    }
}