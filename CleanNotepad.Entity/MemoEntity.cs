namespace CleanNotepad.Entity
{
    public class MemoEntity
    {
        // メモの最重要ビジネスルールは、文章
        public string MemoText { get; }

        // 空文字のメモは存在しない。これも最重要ビジネスルール
        private static bool IsNotMemo(string rawString) => string.IsNullOrEmpty(rawString);

        // エンティティはふるまいを持てる
        // ふるまいを切り出して、別のクラスに分離してもよい。（ふるまいの分離のメリデメの話は、本筋からそれるので割愛。）

        public MemoEntity(string memoText)
        {
            if (!IsNotMemo(memoText))
            {
                MemoText = memoText;
            }
            else
            {
                throw new Exception("ビジネスルール違反");
            }
        }

        // public MemoEntity(string memoText) => MemoText = IsNotMemo(memoText) ? throw new Exception("ビジネスルール違反") : memoText;
    }
}