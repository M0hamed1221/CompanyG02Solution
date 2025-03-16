using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext northwindContext = new NorthwindContext();

            int count = 3;
            var reult = northwindContext.Categories.FromSqlRaw("Select top(3) from Categories ");
            var reultinter = northwindContext.Categories.FromSqlInterpolated($"Select top({count}) from Categories ");
            var ID = 1;
            northwindContext.Database.ExecuteSqlInterpolated($"update Categories set CatergroyName = 'Mohamed' where CategoryID = {ID}");

            NorthwindContextProcedures northwindContextProcedures = new NorthwindContextProcedures(northwindContext);
         var relut=   northwindContextProcedures.SalesByCategoryAsync("Mohamed","2024").Result;
        }
    }
}
