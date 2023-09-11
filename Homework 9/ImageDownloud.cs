using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Homework_9.ImageDownloud;

namespace Homework_9
{
    public class ImageDownloud
    {
        public delegate void ImageStarted();
        public delegate void ImageCompleted();

        public event ImageStarted onImageStarted;
        public event ImageCompleted onImageCompleted;

        public void Download()
        {
            // Откуда будем качать
            string remoteUri = "https://stsci-opo.org/STScI-01H7TESNNSX9CH4EQ29C919C4M.png";
            // Как назовем файл на диске
            string fileName = "bigimage.png";

            // Качаем картинку в текущую директорию
            var myWebClient = new WebClient();
            onImageStarted?.Invoke();

            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);

            myWebClient.DownloadFile(remoteUri, fileName);
            onImageCompleted?.Invoke();
        }
    }
}
