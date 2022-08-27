using CleanNotepad.Entity;
using CleanNotepad.InterfaceAdapter.DBObject;
using CleanNotepad.UseCase.IRepository;
using System.Security.Cryptography.X509Certificates;

namespace CleanNotepad.InterfaceAdapter.Repository
{
    public class MemoRepository : IMemoRepository
    {

        private ApplicationDbContext context;

        public MemoRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> SaveMemoEntityAsync(MemoEntity memoEntity)
        {
            // インターフェイスアダプターは、エンティティをDBに都合のよいオブジェクトに変換する
            // 処理を切り出してもよい
            var memoDBObject = new MemoDBObject(memoEntity.MemoText);

            // ここに具象保存処理
            try
            {
                var result = await context.MemoDBObjects.AddAsync(memoDBObject);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<MemoEntity>> LoadMemoEntityAsync()
        {
            return context.MemoDBObjects.Select(x => new MemoEntity(x.MemoText));
        }
    }
}