using CleanNotepad.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotepad.UseCase.IRepository
{
    public interface IMemoRepository
    {
        public bool SaveMemoEntity(MemoEntity note);
    }
}
