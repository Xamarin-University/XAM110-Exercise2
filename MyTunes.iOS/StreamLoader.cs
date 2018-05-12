using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using MyTunes.Shared;
using UIKit;

namespace MyTunes
{
    class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return System.IO.File.OpenRead(filename);
        }
    }
}