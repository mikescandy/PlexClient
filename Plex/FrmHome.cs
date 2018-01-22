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
        List<PlexItem> libraries, libraryItems;
        List<string> serverNames = new List<string>();
        List<string> directoryTitles = new List<string>();

        public FrmHome(User user)
        {
            InitializeComponent();
            this.Text = "Welcome, " + user.username;
            servers = plex.GetServers(user);
            for(int x = 0; x < servers.Count;x++)
            {
                serverNames.Add(servers[x].name);
            }

            LboxServers.BeginUpdate();
            LboxServers.DataSource = serverNames;
            LboxServers.EndUpdate();

        }

        private void BtnServerSelect_Click(object sender, EventArgs e)
        {
            // TODO kill default selection
            selectedServer = servers[LboxServers.SelectedIndex];
            libraries = selectedServer.GetLibrarySections();

            foreach (PlexItem p in libraries)
            {
                directoryTitles.Add(p.title);
            }

            LboxLibraries.BeginUpdate();
            LboxLibraries.DataSource = directoryTitles;
            LboxLibraries.EndUpdate();
            GbLibraries.Visible = true;
            BtnLibraryBackToServer.Visible = true;
            BtnServerSelect.Visible = false;
        }

        private void BtnLibraryBackToServer_Click(object sender, EventArgs e)
        {
            GbLibraries.Visible = false;
            BtnLibraryBackToServer.Visible = false;
            BtnServerSelect.Visible = true;
        }

        private void BtnLibrarySelect_Click(object sender, EventArgs e)
        {
            selectedLibrary = libraries[LboxLibraries.SelectedIndex];
            libraryItems = selectedLibrary.GetChildren<PlexItem>();

            int x = 0;
            foreach (PlexItem p in libraryItems)
            {
                x++;
                Console.WriteLine("Item {0}: {1}", x, p.title);
            }
            BtnLibrarySelect.Visible = false;
        }

    }
}
