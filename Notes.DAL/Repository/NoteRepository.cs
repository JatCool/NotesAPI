using Notes.DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Notes.DAL.Repository
{
    public class NoteRepository : INoteRepository
    {
        private INoteContext _context;

        public NoteRepository(INoteContext context)
        {
            _context = context;
        }

        public void CreateNote(Note newNote)
        {
            Note note = _context.Notes.LastOrDefault();
            if (note is null)
            {
                newNote.Id = 1;
            }
            else
            {
                newNote.Id = note.Id + 1;
            }
            _context.Notes.Add(newNote);
            _context.SaveChanges();
        }

        public void DeleteNote(int noteId)
        {
            Note note = _context.Notes.Find(noteId);
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }


        public void EditNote(int id, Note note)
        {
            var newNote = _context.Notes.Find(id);
            newNote.Text = note.Text;
            _context.SaveChanges();
        }

        public IEnumerable<Note> GetAllNotesAsync()
        {
            return _context.Notes.OrderByDescending(i => i.Id).ToList();
        }

        public Note GetNoteById(int noteId)
        {
            return _context.Notes.Find(noteId);
        }
    }
}
