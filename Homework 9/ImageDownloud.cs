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

        public event ImageStarted? onImageStarted;
        public event ImageCompleted? onImageCompleted;

        public async Task<bool> Download(string remoteUri, string fileName)
        {
            try
            {
                OnImageStarted();

                using (var myWebClient = new WebClient())
                {
                    await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);
                }

                OnImageCompleted();
                return true;
            }
            catch
            {
                return false;
            }
        }
        protected virtual void OnImageStarted()
        {
            ImageStarted?.Invoke();
        }

        protected virtual void OnImageCompleted()
        {
            ImageCompleted?.Invoke();
        }
    }
}
