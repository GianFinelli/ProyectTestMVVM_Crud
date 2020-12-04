using Java.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Android.Graphics;
using Android.Util;
using System.IO;

namespace MVVM_Crud
{
    class ImagenesSqlite
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static UriImageSource uriImageSoucre(string uri)
        {
            return new UriImageSource { Uri = new Uri(uri) };
        }

        public static Bitmap ArrayToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Bitmap image = (Bitmap)BitmapFactory.FromArray(imageBytes);
                return image;
            }
        }

        //public Image Base64ToImage(string base64String)
        //{
        //    // Convert Base64 String to byte[]
        //    byte[] imageBytes = Convert.FromBase64String(base64String);
        //    MemoryStream ms = new MemoryStream(imageBytes, 0,
        //      imageBytes.Length);

        //    // Convert byte[] to Image
        //    ms.Write(imageBytes, 0, imageBytes.Length);
        //    Image image = Image.FromStream(ms, true);
        //    return image;
        //}
    }
}
