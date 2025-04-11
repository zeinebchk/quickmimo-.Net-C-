using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using quickmimo.context;
using quickmimo.Entities;

namespace quickmimo.Repositories
{
    public class TaskRepository
    {
        private readonly DBMimoContext _context;
        public TaskRepository(DBMimoContext context)
        {
            _context = context;
        }
        public List<MYTask> GetAllTasksByUser(int id)
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
        public void updateTask(MYTask task)
        {
            var old_task = _context.tasks.FirstOrDefault(e => e.Id == task.Id);
            _context.Entry(old_task).CurrentValues.SetValues(task);
            _context.SaveChanges();

        }
        public List<MYTask> getTodoTasks(int id)
        {
            var AllTasksByUser = this.GetAllTasksByUser(id);

            return AllTasksByUser.Where(t => t.status == "todo").ToList();
        }
        public List<MYTask> getInProgressTasks(int id)
        {
            var AllTasksByUser = this.GetAllTasksByUser(id);

            return AllTasksByUser.Where(t => t.status == "inProgress").ToList();
        }
        public List<MYTask> getDoneTasks(int id)
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
