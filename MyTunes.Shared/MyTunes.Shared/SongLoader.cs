using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;

namespace MyTunes.Shared
{
	public static class SongLoader
	{
		const string Filename = "songs.json";

        // add a public static property named Loader of type IStreamLoader.
        public static IStreamLoader Loader;

		public static async Task<IEnumerable<Song>> Load()
		{
			using (var reader = new StreamReader(OpenData())) {
				return JsonConvert.DeserializeObject<List<Song>>(await reader.ReadToEndAsync());
			}
		}

		private static Stream OpenData()
		{
            // Edit the OpenData method to test the property for null and then use it to open the passed filename.
            if (Loader != null)
                return Loader.GetStreamForFilename(Filename);
            else
                throw new Exception("Must set platform Loader before calling Load.");
        }
    }
	}
}

