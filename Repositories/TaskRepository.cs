using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quickmimo.context;
using quickmimo.Entities;

namespace quickmimo.Repositories
{
    internal class TaskRepository
    {
        private readonly DBMimoContext _context;
        public TaskRepository(DBMimoContext context)
        {
            _context = context;
        }
        public IEnumerable<MYTask> GetAllTasksByUser(int id)
        {
            return _context.tasks.Where(t=>t.userId==id). ToList();
        }
        public MYTask GetMYTaskById(int id)
        {
            return _context.tasks.FirstOrDefault(c => c.Id == id);
        }
        public void Add(MYTask task)
        {
            _context.tasks.Add(task);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var task = _context.tasks.Find(id);
            if (task != null)
            {
                _context.tasks.Remove(task);
                _context.SaveChanges();
            }
        }
        public void UpdateStatus(MYTask task)
        {
            _context.tasks.Update(task);
            _context.SaveChanges();
        }
        public IEnumerable<MYTask> getTodoTasks(int id)
        {
            var AllTasksByUser = this.GetAllTasksByUser(id);

            return AllTasksByUser.Where(t => t.status == "todo").ToList();
        }
        public IEnumerable<MYTask> getInProgressTasks(int id)
        {
            var AllTasksByUser = this.GetAllTasksByUser(id);

            return AllTasksByUser.Where(t => t.status == "inProgress").ToList();
        }
        public IEnumerable<MYTask> getDoneTasks(int id)
        {
           var  AllTasksByUser = this.GetAllTasksByUser(id);

            return AllTasksByUser.Where(t => t.status == "done").ToList();
                //_context.tasks.Where(t => t.status == "done").ToList();
        }
        public void UpdateTaskStatus(int taskId, string newStatus)
        {
            var task = this.GetMYTaskById(taskId);
            if (task != null)
            {
                task.status = newStatus; 
                _context.SaveChanges();  
            }
        }


    }
}
