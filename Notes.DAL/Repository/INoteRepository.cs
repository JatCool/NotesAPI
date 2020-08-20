using Notes.DAL.Entity;
using System.Collections.Generic;

namespace Notes.DAL.Repository
{
    public interface INoteRepository
    {
        public IEnumerable<Note> GetAllNotesAsync();

        public Note GetNoteById(int noteId);

        public void EditNote(int id, Note note);

        public void DeleteNote(int noteId);

        public void CreateNote(Note newNote);
    }
}
