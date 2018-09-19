using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlexAPI;
using System.Threading;
using Newtonsoft.Json;

namespace Plex
{
    public partial class FrmHome : Form
    {
        MyPlex plex= new MyPlex();
        Server selectedServer;
        PlexItem selectedLibrary;
        List<Server> servers;
        List<PlexItem> libraries;
        List<string> serverNames = new List<string>();

        public FrmHome(User user)
        {
            InitializeComponent();
            this.Text = "Welcome, " + user.username;
            servers = plex.GetServers(user);

			if(servers.Count > 0)
			{
				// Populate list of servers
				for (int x = 0; x < servers.Count; x++)
				{
					serverNames.Add(servers[x].name);
				}
				// Set combo box data to list of servers
				cbServers.BeginUpdate();
				cbServers.DataSource = serverNames;
				cbServers.EndUpdate();
				selectedServer = servers[0];
				UpdateLibraries(selectedServer);
			}
            
        }

		// Set selected server to match combo box index on selected index changed
		private void cbServers_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedServer = servers[cbServers.SelectedIndex];
			UpdateLibraries(selectedServer);
		}

		private void LBoxLibraries_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedLibrary = libraries[LBoxLibraries.SelectedIndex];
			switch (selectedLibrary.type)
			{
				case "movie":
					lblSub1.Text = "Movie";
					break;
				case "artist":
					lblSub1.Text = "Artist";
					break;
				case "show":
					lblSub1.Text = "Series";
					break;
				default:
					lblSub1.Text = "Sub-Category 1";
					break;
			}

			List<string> subcollection1 = new List<string>();
			foreach(PlexItem pi in selectedLibrary.GetChildren<PlexItem>())
			{
				if(pi.title != null)
				{
					subcollection1.Add(pi.title);
					Console.WriteLine(pi.title);
				}
			}

			Console.WriteLine("length: " + subcollection1.Count);

			if(subcollection1.Count > 0)
			{
				LBoxSub1.BeginUpdate();
				LBoxSub1.DataSource = subcollection1;
				LBoxSub1.EndUpdate();
				LBoxSub1.Enabled = true;
			}
			else
			{
				subcollection1.Add("No items found");
				LBoxSub1.BeginUpdate();
				LBoxSub1.DataSource = subcollection1;
				LBoxSub1.EndUpdate();
				LBoxSub1.Enabled = false;
			}
			panelSub1.Visible = true;
		}

		private void UpdateLibraries(Server server)
		{
			List<string> libraryTitles = new List<string>();
			libraries = server.GetLibrarySections();
			foreach (PlexItem pi in libraries)
			{
				libraryTitles.Add(pi.title);
				Console.WriteLine(pi.type);
			}

			LBoxLibraries.BeginUpdate();
			LBoxLibraries.DataSource = libraryTitles;
			LBoxLibraries.EndUpdate();
		}

		private void LBoxSub1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
