namespace CleanNotepad.Entity.Test
{
    public class UnitTest
    {
        [Fact]
        public void 空のメモは存在しないビジネスルールのテスト()
        {
            Assert.Throws<Exception>(() => new MemoEntity(string.Empty));
        }
    }
}