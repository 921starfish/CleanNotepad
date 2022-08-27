namespace CleanNotepad.Entity
{
    public class MemoEntity
    {
        // メモの最重要ビジネスルールは、文章
        public string MemoText { get; set; }

        // 空文字のメモは存在しない。これも最重要ビジネスルール
        public bool IsNullOrEmpty(string rawString) => string.IsNullOrEmpty(rawString);

        // エンティティはふるまいを持てる
        // ふるまいを切り出して、別のクラスに分離してもよい。（ふるまいの分離のメリデメの話は、本筋からそれるので割愛。）

        public MemoEntity(string memoText)
        {
            if (!IsNullOrEmpty(memoText))
            {
                MemoText = memoText;
            }
            else
            {
                throw new Exception("ビジネスルール違反");
            }
        }
    }
}