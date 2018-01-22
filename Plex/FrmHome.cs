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
using System.IO;

namespace Plex
{
    public partial class FrmHome : Form
    {
        MyPlex plex= new MyPlex();
        List<Server> servers;
        List<PlexAPI.Directory> directories;
        List<string> serverNames = new List<string>();
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
        private void LboxServers_Click(object sender, EventArgs e)
        {
            Server selectedServer = servers[LboxServers.SelectedIndex];
            // Calls method which will return null data but grabs a working JSON object and writes to a text file
            directories = selectedServer.GetLibrarySections();
        }

        private void LboxLibraries_Click(object sender, EventArgs e)
        {
            
        }

        private void LboxServers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
