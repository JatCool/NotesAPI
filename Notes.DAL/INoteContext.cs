using Notes.DAL.Entity;
using System.Data.Entity;

namespace Notes.DAL
{
    public interface INoteContext
    {
        IDbSet<Note> Notes { get; }

        int SaveChanges();
    }
}
