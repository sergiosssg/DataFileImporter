using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFileImporter
{
    public class DataBaseFacilities
    {

        public static string GetConnectionString()
        {
            DbConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder["Data Source"] = "localhost";
            ///builder["Data Source"] = @"localhost\SQLExpress";

            builder["Database"] = "sampd_cexs";

            builder["integrated Security"] = "true";

            return builder.ConnectionString;
        }


        public static DbContextOptions<DbAppContext> OptionsOfDbContext() => new DbContextOptionsBuilder<DbAppContext>().UseSqlServer(GetConnectionString()).Options;

    }

    public class DbAppContext :  DbContext
    {

        public DbSet<PO_TEL_VID_CONNECT> pO_TEL_VID_CONNECTs { get; set; }

        public DbSet<PO_TEL_OPERATOR> pO_TEL_OPERATORs { get; set; }

        public DbAppContext()
        {
            ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PO_TEL_OPERATOR>().HasMany( )
        }
    }
}
