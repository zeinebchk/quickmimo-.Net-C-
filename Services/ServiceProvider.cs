using Microsoft.EntityFrameworkCore;
using quickmimo.context;


public static class ServiceProvider
{
    public static NotesService GetNotesService()
    {
        var optionsBuilder = new DbContextOptionsBuilder<DBMimoContext>();
        optionsBuilder.UseSqlite("Data Source=app.db");

        DBMimoContext context = new DBMimoContext(optionsBuilder.Options);
        return new NotesService(context);
    }
}
