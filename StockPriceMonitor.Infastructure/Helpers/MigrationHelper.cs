using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace StorePriceMonitor.Infastructure.Helpers
{
    public static class MigrationHelper
    {
        public static void CreateStoredProcedgures(this MigrationBuilder migrationBuilder)
        {
            string[] filePaths = Directory.GetFiles(ReturnContentPath(@"Customization/StoredProcedures"), "*.sql");

            foreach (var filePath in filePaths)
            {
                string sql = File.ReadAllText(filePath);
                if (sql.StartsWith("CREATE"))
                    migrationBuilder.Sql(sql);
            }
        }
        public static void CreateViews(this MigrationBuilder migrationBuilder)
        {
            string[] filePaths = Directory.GetFiles(ReturnContentPath(@"Customization/Views"), "*.sql");

            foreach (var filePath in filePaths)
            {
                string sql = File.ReadAllText(filePath);
                if (sql.StartsWith("CREATE"))
                    migrationBuilder.Sql(sql);
            }
        }
        private static string ReturnContentPath(string localPath)
        {
            string basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            return Path.Combine(basePath, localPath);
        }
    }
}
