namespace CleanNotepad.InterfaceAdapterForDB.DBObject
{
    internal class MemoDBObject
    {
        // Idは、具象であるRDBのために存在する
        internal int Id { get; set; }
        internal string MemoText { get; set; }

        internal MemoDBObject(string memoText)
        {
            MemoText = memoText;
        }
    }
}
