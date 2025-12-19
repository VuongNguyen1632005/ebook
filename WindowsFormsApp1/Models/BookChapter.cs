using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1.Models
{

    public class BookChapter : IDisposable
    {
        public int ChapterNumber { get; set; }
        public string ChapterTitle { get; set; }
        public string Content { get; set; }
        
        
        public Dictionary<string, Image> Images { get; set; } = new Dictionary<string, Image>();

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (Images != null)
                    {
                        foreach (var img in Images.Values)
                        {
                            img?.Dispose();
                        }
                        Images.Clear();
                    }
                }
                _disposed = true;
            }
        }

        ~BookChapter()
        {
            Dispose(false);
        }
    }
}
