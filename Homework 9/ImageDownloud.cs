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

        public async Task Download()
        {
            Uri remoteUri = new Uri("https://stsci-opo.org/STScI-01H7TG7ZX0PHJ2F5S7P4ND2DT0.png");
            string fileName = "bigimage.png";

            var myWebClient = new WebClient();
      
            onImageStarted?.Invoke();
            myWebClient.DownloadFileAsync(remoteUri, fileName);
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
            
            onImageCompleted?.Invoke();
        }
    }
}
