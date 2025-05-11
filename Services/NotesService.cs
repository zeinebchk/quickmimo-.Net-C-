using Microsoft.EntityFrameworkCore;
using quickmimo.context;
using quickmimo.Entities;
using quickmimo.Services;

public class NotesService 
{
    private readonly DBMimoContext _context;

    public NotesService(DBMimoContext context)
    {
        _context = context;
    }

    public void AddNote(Note note)
    {
        note.Title = note.Title?.Trim() ?? throw new ArgumentNullException(nameof(note.Title));
        _context.Notes.Add(note);
        _context.SaveChanges();
    }

    public void UpdateNote(Note note)
    {
        try
        {
            var existingNote = _context.Notes.Find(note.Id);
            if (existingNote == null) return;

            // Mise à jour sélective pour optimiser les performances
            _context.Entry(existingNote).CurrentValues.SetValues(note);
            _context.Entry(existingNote).Property(x => x.DateCreated).IsModified = false;

            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            throw new ApplicationException("Conflit de mise à jour détecté", ex);
        }
    }

    public void DeleteNote(int id)
    {
        try
        {
            var note = _context.Notes
    .FirstOrDefault(n => n.Id == id);


            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
            }
        }
        catch (DbUpdateException ex)
        {
            throw new ApplicationException("Erreur lors de la suppression", ex);
        }
    }

    // Implémentation de la méthode GetNotes
    public List<Note> GetNotes()
    {
        return _context.Notes.ToList(); // Si tu veux récupérer toutes les notes.
    }
}
