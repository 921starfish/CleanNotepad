namespace CleanNotepad.Entity.Test
{
    public class UnitTest
    {
        [Fact]
        public void ��̃����͑��݂��Ȃ��r�W�l�X���[���̃e�X�g()
        {
            Assert.Throws<Exception>(() => new MemoEntity(string.Empty));
        }
    }
}