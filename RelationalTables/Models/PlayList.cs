using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace RelationalTables.Models
{
  public class PlayList
  {

    public int ID { get; set; }
    public string Title { get; set; }
    public virtual ICollection<Video> Videos { get; set; }
    public virtual ICollection<Audio> Audios { get; set; }

  }
 public  class Video
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    //public ICollection<PlayList> playlist { get;set;}
    //public virtual PlayList playlistVideo { get; set; }
  
  
  }
 public class Audio
 {
   public int ID { get; set; }
   public string Title { get; set; }
   public string Description { get; set; }
   //public ICollection<PlayList> playlist { get;set;}
   //public  virtual PlayList playlistAudio { get; set; }

 }






}