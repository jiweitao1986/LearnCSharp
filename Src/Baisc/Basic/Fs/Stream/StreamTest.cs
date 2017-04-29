using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Basic.Fs.Stream
{
    public static class StreamTest
    {
        public static void Run()
        {

            //获取图片列表
            var photos = GetPhotos();
            
            //转换为二进制
            foreach (var photo in photos)
            {
                //获取二进制
                byte[] photoBytes = new byte[photo.ContentLength];
                photo.InputStream.Read(photoBytes, 0, photo.ContentLength);

                //var newPhotoStream = System.IO.File.OpenWrite(photo.FileName);
                //newPhotoStream.Write(photoBytes, 0, photoBytes.Count());

                //保存为图片
                System.IO.MemoryStream ms = new System.IO.MemoryStream(photoBytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                img.Save(photo.FileName);

                //输出base64编码
                //Console.WriteLine(Convert.ToBase64String(photoBytes));
            }

        }


        public static List<Photo> GetPhotos()
        {
            var photoList = new List<Photo>();

            string photosDir = @"../../File/Photos";
            string[] photoNames = Directory.GetFiles(photosDir);
            foreach (string photoName in photoNames)
            {
                if (System.IO.File.Exists(photoName))
                {
                    var photoInfo = new FileInfo(photoName);
                    var photo = new Photo()
                    {
                        FileName = photoInfo.Name,
                        ContentLength = (int) photoInfo.Length,
                        InputStream = photoInfo.Open(FileMode.Open)
                    };
                    photoList.Add(photo);

                    //Console.WriteLine(photoInfo.Name　+ "-" + photoInfo.Length + "-" + photo.InputStream.Length);
                }
            }
            return photoList;
        }
    }




    public class Photo
    {
        public int ContentLength { get; set; }

        public string FileName { get; set; }

        public System.IO.Stream InputStream { get; set; }
    }

}



