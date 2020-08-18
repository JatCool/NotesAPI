using Notes.DAL.Entity;
using System.Data.Entity;

namespace Notes.DAL
{
    public class NotesContext: DbContext, INoteContext
    {
        public IDbSet<Note> Notes { get; set; }
    }
}
