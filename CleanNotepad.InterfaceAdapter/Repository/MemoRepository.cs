using CleanNotepad.Entity;
using CleanNotepad.InterfaceAdapter.DBObject;
using CleanNotepad.UseCase.IRepository;
using System.Security.Cryptography.X509Certificates;

namespace CleanNotepad.InterfaceAdapter.Repository
{
    public class MemoRepository : IMemoRepository
    {

        public ApplicationDbContext context;

        public MemoRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public bool SaveMemoEntity(MemoEntity memoEntity)
        {
            // インターフェイスアダプターは、エンティティをDBに都合のよいオブジェクトに変換する
            // 処理を切り出してもよい
            var memoDBObject = new MemoDBObject(memoEntity.MemoText);

            // ここに具象保存処理
            try
            {
                var result = context.MemoDBObjects.Add(memoDBObject);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<MemoEntity> LoadMemoEntity()
        {
            return context.MemoDBObjects.Select(x => new MemoEntity(x.MemoText));
        }
    }
}