using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CoreEntityFrameworkDatabaseFirstApproach.Models;

public class DatabaseFirstDbContext : DbContext
{
    public DatabaseFirstDbContext()
    {

    }
  //  public DatabaseFirstDbContext(DbContextOptions<DatabaseFirstDbContext>()) : base(options)   {  } NOT FINISHED

    public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\ButtersDB;Database=DatabaseFirstDB;Integrated Security=true; TrustServerCertificate = true;");
    }


}
