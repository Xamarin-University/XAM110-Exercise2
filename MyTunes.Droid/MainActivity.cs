﻿using System.Linq;
using Android.App;
using Android.OS;
using MyTunes.Shared;

namespace MyTunes
{
	[Activity(Label = "My Tunes", MainLauncher = true)]
	public class MainActivity : ListActivity
	{
		protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);


            // inject the dependency
            SongLoader.Loader = new StreamLoader(this);

            // Load Data
			var data = await SongLoader.Load();

			ListAdapter = new ListAdapter<Song>() {
				DataSource = data.ToList(),
				TextProc = s => s.Name,
				DetailTextProc = s => s.Artist + " - " + s.Album
			};
		}
	}
}


