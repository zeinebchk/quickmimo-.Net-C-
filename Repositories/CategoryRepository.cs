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
   
    public class CategoryRepository
    {
        private readonly DBMimoContext _context;
        //private readonly AppDbContext _context;
        private readonly List<Category> _categories;
        public CategoryRepository(DBMimoContext context)
        {
            _context = context;
        }

        public async Task<Category> GetByNameAsync(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                throw new ArgumentNullException(nameof(categoryName), "Le nom de la catégorie ne peut pas être vide ou nul.");
            }

            // Convertir les deux côtés de la comparaison en minuscules (ou majuscules)
            return await _context.Categories
                                 .FirstOrDefaultAsync(c => c.Nom.ToLower() == categoryName.ToLower());
        }


        public async Task<List<Category>> GetAllAsync() =>
            await _context.Categories.ToListAsync();

        public async Task<Category?> GetByIdAsync(int id) =>
            await _context.Categories.FindAsync(id);

        public async Task AddAsync(Category category)
        {
            if (category == null) throw new ArgumentNullException(nameof(category));

            await _context.Categories.AddAsync(category); // Ajouter la catégorie au DbContext
            await _context.SaveChangesAsync(); // Sauvegarder les changements
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync(); // Sauvegarder les changements
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync(); // Sauvegarder les changements
            }
        }
    }
}

