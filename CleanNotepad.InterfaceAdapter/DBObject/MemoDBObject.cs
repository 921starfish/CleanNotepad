namespace CleanNotepad.InterfaceAdapter.DBObject
{
    public class MemoDBObject
    {
        // Idは、具象であるRDBのために存在する
        public int Id { get; set; }
        public string MemoText { get; set; }

        public MemoDBObject(string memoText)
        {
            MemoText = memoText;
        }
    }
}
