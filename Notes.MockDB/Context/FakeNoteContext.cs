using Notes.DAL;
using Notes.DAL.Entity;
using Notes.MockDB.Set;
using System.Data.Entity;

namespace Notes.MockDB.Context
{
    public class FakeNoteContext : INoteContext
    {
        public FakeNoteContext()
        {
            this.Notes = new FakeNoteSet();
        }

        public IDbSet<Note> Notes { get; private set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}
