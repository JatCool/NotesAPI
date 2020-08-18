using Notes.DAL.Entity;
using System.Linq;

namespace Notes.MockDB.Set
{
    public class FakeNoteSet : FakeDbSet<Note>
    {
        public override Note Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.SingleOrDefault());
        }
    }
}
