using System;
using System.Collections.Generic;
using RestSharp;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace PlexAPI
{
    public class MediaContainer : PlexItem
    {
        public List<Directory> directories { get; set; }
        public List<DirectoryTypes.Show> showDirectories { get; set; }
        public List<PlexItem> items { get; set; }

        public int size { get; set; }
        public bool allowSync { get; set; }
        public string identifier { get; set; }
        public int librarySectionID { get; set; }
        public string librarySectionUUID { get; set; }
        public string mediaTagPrefix { get; set; }
        public long mediaTagVersion { get; set; }
        public bool nocache { get; set; }
        public bool sortAsc { get; set; }
        public string title1 { get; set; }
        public string title2 { get; set; }
        public string viewGroup { get; set; }
        public int viewMode { get; set; }
        public string friendlyName { get; set; }
        public string machineIdentifier { get; set; }
        public string mediaAnalysisVersion { get; set; }
        public bool myPlex { get; set; }
        public string myPlexMappingState { get; set; }
        public string myPlexSigninState { get; set; }
        public string myPlexUsername { get; set; }
        public string platform { get; set; }
        public string platformVersion { get; set; }
        public bool requestParametersInCookie { get; set; }
        public bool sync { get; set; }
        public int transcroderActiveVideoSessions { get; set; }
        public bool transcoderAudio { get; set; }
        public bool transcoderVideo { get; set; }
        public string transcoderVideoBitrates { get; set; }
        public string transcoderVideoQualities { get; set; }
        public string transcoderVideoResolutions { get; set; }
        public string version { get; set; }
        public string content { get; set; }
        public bool mixedParents { get; set; }
        public int parentIndex { get; set; }
        public string parentTitle { get; set; }
        public int parentYear { get; set; }
        public string summary { get; set; }
        public string theme { get; set; }
        public string grandparentContentRating { get; set; }
        public string grandparentStudio { get; set; }
        public string grandparentTheme { get; set; }
        public string grandparentTitle { get; set; }

        public List<Video> videos { get; set; }
        public List<Track> tracks { get; set; }
        public List<Photo> photos { get; set; }

        public MediaContainer() { }

        public MediaContainer(User user, Server server, String uri) : base(user, server, uri) {
            Load();
        }
        
        public void Load()
        {
            JObject response;
            var request = new RestRequest();
            request.Resource = uri;

            showDirectories = new List<DirectoryTypes.Show>();
            response = ParseJsonString(Execute(request, user));
            if(response != null)
            {
                GetDirectories(response);
            }
            else
            {
                Console.WriteLine("[MediaContainer:98] - Response is null");
            }

        }

        // Clear list and populate with directories
        public void GetDirectories(JObject response)
        {
            items = new List<PlexItem>();
            JObject library;
            string title, type;
            JArray libraries = JArray.Parse(response.GetValue("Directory").ToString());

            // For each library item in the array
            for (int x = 0; x < int.Parse(response.GetValue("size").ToString()); x++)
            {
                library = JObject.Parse(libraries[x].ToString());
                title = library.GetValue("title").ToString();
                type = library.GetValue("type").ToString();

                items.Add(new PlexItem(user, server, title, type));
            }
        }

        public JObject ParseJsonString(string jsonResponse)
        {
            // Response text > JSON Object
            JObject jsonObject = JObject.Parse(jsonResponse);
            // JSON Object only has one child component, MediaContainer, so shed that top level
            return JObject.Parse(jsonObject.GetValue("MediaContainer").ToString());
        }

        protected void ProcessDirectory(Directory item, int i)
		{
			item.user = user;
			item.server = server;
			if (item.key.StartsWith ("/")) {
				item.uri = item.key;
			} else {
				item.uri = uri + "/" + item.key;
			}

			switch (item.type) {
			case "show":
				showDirectories.Add (new DirectoryTypes.Show(item));
				break;
			}

			directories [i] = item;
		}
	}
}

