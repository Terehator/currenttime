using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WordPressTestProject
{
    class LoginTestCaseContext : DbContext
    {
        public LoginTestCaseContext()
            :base("DBConnection")
        { }
          
        public DbSet<LoginTestCase> LoginTestCases { get; set; }
    }
}
