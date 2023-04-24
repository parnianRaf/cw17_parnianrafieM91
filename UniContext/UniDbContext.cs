<<<<<<< HEAD
﻿using AppCore.Entities;
=======
﻿using AppCore.Entities;
>>>>>>> 025fcf748e3ea192e10b0286c53b67a8e929d44d
using Microsoft.EntityFrameworkCore;

namespace UniContext;
public class UniDbContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
<<<<<<< HEAD
        modelBuilder.Entity<StudentCourse>(b =>
        {
            b.HasKey(key => new { key.StudentId, key.CourseId });
            b.HasOne(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(s => s.StudentId);
            b.HasOne(sc => sc.Course).WithMany(s => s.StudentCourses).HasForeignKey(s => s.CourseId);
        });
        modelBuilder.Entity<StudentContactInfo>(sc =>
        {
            sc.HasKey(s => s.StudentId);

        });
        modelBuilder.Entity<TeacherContactInfo>(tc =>
        {
            tc.HasKey(s => s.TeacherId);

        });

=======
>>>>>>> 025fcf748e3ea192e10b0286c53b67a8e929d44d
    }


    public UniDbContext(DbContextOptions<UniDbContext> options)
      : base(options)
    {
    }


    public DbSet<Course> Course { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<StudentContactInfo> StudentContactInfo { get; set; }
    public DbSet<StudentCourse> StudentCourse { get; set; }
    public DbSet<Teacher> Teacher { get; set; }
    public DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }
}




