using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryProject.Data
{
    public static class Extension
    {
        // config Automatic Generate CreateON Property Value 
        public static void CreatON(this ModelBuilder modelbuilder)
        {
            var ListIDateEntities = typeof(IDateEntity).GetAllClassNames();
            var Entities = modelbuilder.Model.GetEntityTypes()
                .Where(w => ListIDateEntities.Contains(w.ClrType.FullName));
            foreach (var entity in Entities)
            {
                var property = entity.FindProperty("CreateON");
                if (property != null)
                {
                    property.ValueGenerated = ValueGenerated.OnAdd;
                    property.SetDefaultValueSql("GetDate()");
                }
            }
        }
        // config Automatic Generate Column type & MaxLength string Property Value 
        public static void ConfigStringProperty(this ModelBuilder modelbuilder)
        {
            var Entities = modelbuilder.Model.GetEntityTypes();
            foreach (var entity in Entities)
            {
                var propose = entity.GetProperties().Where(p=>p.ClrType == typeof(string));
                foreach (var item in propose)
                {
                    item.SetColumnType("nvarchar");
                    item.SetMaxLength(150);
                }
            }
        }

        // Lists all Classes that Implement a specific Interface
        public static List<string> GetAllClassNames(this Type type)
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => type.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.FullName).ToList();
        }
    }
}
