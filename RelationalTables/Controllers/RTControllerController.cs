using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RelationalTables.Models;
namespace RelationalTables.Controllers
{
    public class RTControllerController : Controller
    {
        //
        // GET: /RTController/

      private static string _videoTitle;
      private static string _videoDesc;
      private static string _playlistTitle;

      RTModel db = new RTModel();


        public ActionResult Index()
        {
            return View();
        }
        public JsonResult CreateDB(string videoTitle,string videoDesc,string audioTitle,string audioDesc,string playlistTitle)
        {
          db.Database.Delete();
          _videoTitle = videoTitle;
          _videoDesc = videoDesc;
          _playlistTitle = playlistTitle;

          Video newVideo = new Video
          {
            Title = videoTitle,
          Description = videoDesc

          };
          Video newVideo2 = new Video
          {
            Title = videoTitle,
            Description = videoDesc

          };
          db.videos.Add(newVideo);
          db.videos.Add(newVideo2);
          Audio newAudio = new Audio
          {
            Title = audioTitle,
            Description = audioDesc

          };
          Audio newAudio2 = new Audio
          {
            Title = audioTitle,
            Description = audioDesc

          };
          db.audio.Add(newAudio);
          db.audio.Add(newAudio2);
          PlayList newPlayList = new PlayList();
          newPlayList.Title = playlistTitle;
          newPlayList.Videos = new List<Video> { newVideo };
          newPlayList.Videos = new List<Video> { newVideo2 };
          newPlayList.Audios = new List<Audio> { newAudio };
          newPlayList.Audios = new List<Audio> { newAudio2 };
          db.playlists.Add(newPlayList);
          db.SaveChanges();
          //var playListVideoDataJsonModel = dbContext.Patients.Select(p => new { p.PatientName, p.PatientId }).ToList();
          var playListVideoDataJsonModel = db.playlists.Select(p => new { p.ID, p.Title, p.Videos,p.Audios }).ToList();

          return Json(playListVideoDataJsonModel, JsonRequestBehavior.AllowGet);

        }

        public JsonResult ReadOnly()
        {
          var playListVideoDataJsonModel = db.playlists.Select(p => new { p.ID, p.Title, p.Videos }).ToList();
          return Json(playListVideoDataJsonModel, JsonRequestBehavior.AllowGet);
        }

    }
}
