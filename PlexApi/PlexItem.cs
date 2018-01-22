using RestSharp;
using System;
using System.Collections.Generic;

namespace PlexAPI
{
	public class PlexItem : PlexRest
	{
		public string uri { get; set; }

		public string key { get; set; }
		public string title { get; set; }
		public string type { get; set; }
		public string thumb { get; set; }
		public string banner { get; set; }
		public string art { get; set; }
		public string createdAt { get; set; }
		public string updatedAt { get; set; }
		public int index { get; set; }
        public string location { get; set; }
		public Server server { get; set; }
		public User user { get; set; }

		public PlexItem()
		{
		}

		public PlexItem(User user, Server server, String uri)
		{
			this.user = user;
			this.server = server;
			this.uri = uri;
		}

		public PlexItem (PlexItem item)
		{
			Utils.CopyFrom<PlexItem, PlexItem>(this, item);
		}

        public PlexItem (User user, Server server, string title, string type)
        {
            this.user = user;
            this.server = server;
            this.title = title;
            this.type = type;
        }

        public List<T> GetChildren<T>() where T : PlexItem
        {
            var request = new RestRequest();
            request.Resource = uri;

            var items = Execute<List<T>>(request, user);
            for (var i = 0; i < items.Count; i++)
            {
                items[i].user = user;
                items[i].server = server;
                if (items[i].key.StartsWith("/"))
                {
                    items[i].uri = items[i].key;
                }
                else
                {
                    items[i].uri = uri + "/" + items[i].key;
                }

            }
            return items;
        }

        // TODO test connection and determine response accordingly
        protected override string GetBaseUrl()
		{
            return "http://" + server.address + ":" + server.port;
        }
	}
}

