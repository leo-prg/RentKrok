using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Вспомогательные функции

namespace RentKrok.Common
{
    public class Transform
    {
        //Из базы в картинку
        public static Image ByteToImage(byte[] bytesArr)
        {

            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        //Из картинки в базу
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static void PointsToDimensions(int x1, int y1, int x2, int y2, out int width, out int height)
        {

            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2-y1);
            
        }

    }
}
