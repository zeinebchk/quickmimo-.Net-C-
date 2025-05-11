using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickmimo.context;
using quickmimo.Entities;
using Microsoft.EntityFrameworkCore;
namespace quickmimo.Repositories
{
    public class NoteRepository
    {
        private readonly DBMimoContext _context;

        public NoteRepository(DBMimoContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetAllAsync() =>
            await _context.Notes.ToListAsync();

        public async Task<Note?> GetByIdAsync(int id) =>
            await _context.Notes.FindAsync(id);

        public async Task AddAsync(Note note)
        {
            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }
    }
}

