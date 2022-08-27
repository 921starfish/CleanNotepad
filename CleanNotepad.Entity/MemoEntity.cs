namespace CleanNotepad.Entity
{
    public class MemoEntity
    {
        // メモの最重要ビジネスルールは、メモそのもの
        public string MemoText { get; set; }

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

        // 空文字のメモは存在しえない（最重要ビジネスルール）
        // エンティティはふるまいを持てる
        public bool IsNullOrEmpty(string rawString) => string.IsNullOrEmpty(rawString);

        // ふるまいを切り出して、別のクラスに分離してもよい。（ふるまいの分離のメリデメの話は、本筋からそれるので割愛。）
    }
}