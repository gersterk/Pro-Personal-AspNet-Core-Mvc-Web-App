using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{


    //contexts are inheriting from DbContext class that EnityFramework Core library prodives
    
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   

            //Building Database
            optionsBuilder.UseSqlServer("server = DESKTOP-TLTN1FO;database = ProPersonalDb; integrated security=true");


        }
    }
}
