﻿using Microsoft.EntityFrameworkCore;
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


        public static DbContextOptions<DbAppContext> OptionsOfDbContext()
        {

            /*
            DbContextOptions<DbAppContext> dbContextOptions = new DbContextOptionsBuilder<DbAppContext>();

            return new DbContextOptionsBuilder<DbAppContext>().UseSqlServer(GetConnectionString()).Options;

            */
            throw new NotImplementedException();
        }

    }

    public class DbAppContext :  DbContext
    {
        public DbAppContext()
        {
            ;
        }
    }
}
