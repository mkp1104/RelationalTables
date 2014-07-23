using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace RelationalTables.Models
{
  public class RTModel : DbContext
  {
    public DbSet<Video> videos { get; set; }
    public DbSet<Audio> audio { get; set; }
    public DbSet<PlayList> playlists { get; set; }


    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{

    //  //modelBuilder.Entity<PlayList>().HasRequired(p => p.Videos).WithRequiredDependent(o=>o.Videos);
    //  modelBuilder.Entity<PlayList>().HasRequired(p => p.Audios).WithRequiredDependent();

    //}
  
  
  
  
  }

 
  //public class RtDBContext 
}