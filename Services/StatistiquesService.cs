using System.Data;
using Microsoft.EntityFrameworkCore;
using quickmimo.context;

public class StatistiquesService 
{
    private readonly DBMimoContext _context;

    public StatistiquesService(DBMimoContext context)
    {
        _context = context;
    }

    public int GetTotalTaches()
    {
        return _context.tasks.Count();
    }

    public int GetTachesTerminees()
    {
        return _context.tasks.Count(t => t.status.Equals("done"));  // Utilisation de la propriété IsCompleted basée sur le Status
    }

    public int GetTachesRetard()
    {
        return _context.tasks.Count(t => t.deadline < DateTime.Now && !t.Equals("done"));  // Tâches en retard mais non terminées
    }

    public Dictionary<string, int> GetTachesParCategorie()
    {
        // Par exemple, pour les catégories, si vous avez une logique sur la base du titre de la tâche, vous pouvez adapter ici.
        var categories = _context.tasks
            .GroupBy(t => t.title)  // Si vous souhaitez grouper par le titre de la tâche
            .Select(group => new { Category = group.Key, Count = group.Count() })
            .ToList();

        Dictionary<string, int> result = categories.ToDictionary(c => c.Category, c => c.Count);
        return result;
    }

    public DataTable ObtenirListeTaches()
    {
        DataTable table = new DataTable();
        table.Columns.Add("Tâche", typeof(string));
        table.Columns.Add("Statut", typeof(string));
        table.Columns.Add("Échéance", typeof(DateTime));

        var tasks = _context.tasks.ToList();

        foreach (var task in tasks)
        {
            table.Rows.Add(task.title, task.status, task.deadline);
        }

        return table;
    }
}
