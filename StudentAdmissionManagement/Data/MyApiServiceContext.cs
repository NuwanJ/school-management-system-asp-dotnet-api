namespace StudentAdmissionManagement.Data;
using Microsoft.EntityFrameworkCore;

public class MyApiServiceContext : DbContext
{
    public MyApiServiceContext(DbContextOptions<MyApiServiceContext> options) : base(options) { }

    public DbSet<StudentAdmissionDetailsModel> Admissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Map the table name
        modelBuilder.Entity<StudentAdmissionDetailsModel>().ToTable("admissions");
    }
}