using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Notes.DAL;
using Notes.DAL.Entity;
using Notes.DAL.Repository;
using System;
using System.Threading.Tasks;

namespace Notes.WebApi.Controllers
{
    [Route("notes")]
    [ApiController]
    public class NoteController : Controller
    {
        private INoteRepository _noteRepository;

        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }


        [HttpGet]
        public IActionResult GetAllNotes()
        {
            var notes = _noteRepository.GetAllNotesAsync();

            return new OkObjectResult(notes);
        }

        [HttpPost]
        public IActionResult AddNote(Note note)
        {
            if (ModelState.IsValid)
            {
                _noteRepository.CreateNote(note);

                return new OkResult();
            }

            return new BadRequestObjectResult("Model is invalid");
        }

        [HttpPut("{id}")]
        public IActionResult EditNote(int id, Note note)
        {
            if (ModelState.IsValid)
            {
                _noteRepository.EditNote(id, note);

                return new OkResult();
            }

            return new BadRequestObjectResult("Model is invalid");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
            return new OkResult();
        }

        [HttpGet("{id}")]
        public IActionResult GetNoteById(int id)
        {
            var note = _noteRepository.GetNoteById(id);

            return new OkObjectResult(note);
        }
    }
}
