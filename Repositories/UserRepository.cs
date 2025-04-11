using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quickmimo.context;
using quickmimo.Entities;

namespace quickmimo.Repositories
{
    public class UserRepository
    {
        private readonly DBMimoContext _context;
        public UserRepository(DBMimoContext context)
        {
            _context = context;
        }
        public User GetUserById(int id)
        {
            return _context.users.FirstOrDefault(c => c.Id == id);
        }
        public User GetUserByEmail(string email)
        {
            return _context.users.FirstOrDefault(c => c.email.Equals(email));
        }

        public void Add(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var task = _context.users.Find(id);
            if (task != null)
            {
                _context.users.Remove(task);
                _context.SaveChanges();
            }
        }
       
    }
}
