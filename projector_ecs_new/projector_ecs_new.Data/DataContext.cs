using Microsoft.EntityFrameworkCore;
using projector_ecs_new.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Data
{
    //public class DataContext : DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public DbSet<Request> Requests { get; set; }
            
    //    public DataContext(DbContextOptions<DataContext> options) : base(options)
    //    {
    //    }
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        // מפה את ה-DbSet<User> לטבלה הקיימת במסד הנתונים
    //        //modelBuilder.Entity<User>().ToTable("sys_user");
    //        //modelBuilder.Entity<User>().Property(u => u.ContactName).HasColumnName("username");
    //        //modelBuilder.Entity<User>().Property(u => u.Passwors).HasColumnName("password");
    //        //modelBuilder.Entity<Request>().ToTable("auth_request");
    //    }
    //}
}
