using CleanNotepad.Entity;
using CleanNotepad.UseCase.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotepad.UseCase
{
    public class LoadNote
    {
        private IMemoRepository memoRepository;

        public LoadNote(IMemoRepository _memoRepository)
        {
            memoRepository = _memoRepository;
        }

        // 「読み込み」はアプリケーション固有のロジック → ユースケース
        public async Task<IEnumerable<MemoEntity>> LoadAsync()
        {
            // 「読み込み」には具象の知識（例：DB、フォルダ、etc）が必要だが、ユースケースが具象を知ってはならない。
            // InterfaceAdapterレイヤーに、インターフェース経由でアクセスする
            return await memoRepository.LoadMemoEntityAsync();
        }
    }

}
