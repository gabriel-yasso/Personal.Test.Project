using System.Threading.Tasks;

namespace Personal.Test.Project.Data;

public interface IProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
