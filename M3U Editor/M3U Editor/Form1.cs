using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace M3U_Editor
{
    public partial class Form1 : Form
    {
        List<ChannelData> Channels = new List<ChannelData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.Filter = "M3U Playlist (*.m3u)|*.m3u|All files (*.*)|*.*";
            ofd.ShowDialog();
            string curFile = ofd.FileName;

            Channels.Clear();
            string[] lines = System.IO.File.ReadAllLines(curFile);

            for (int i = 0; i < lines.Count() - 1; i++)
            {
                // Detect Start, ignore first line
                if (lines[i].StartsWith("#EXTM3U"))
                {
                    // Do nothing
                }
                if (lines[i].StartsWith("#EXTINF:-1"))
                {
                    ProcessLine(lines[i], lines[i + 1]);
                    i = i + 1;
                }
            }

            // Fill groups
            CBGroups.Items.AddRange((from chn in Channels select chn.GroupTitle).Distinct<String>().ToArray<Object>());
        }

        private void ProcessLine(string line1, string line2)
        {
            string processingLine = line1;
            ChannelData data = new ChannelData();

            // ID
            string[] separators = { "tvg-", "group-" };
            string[] subLines = processingLine.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            data.ID = subLines[1].Substring(subLines[1].IndexOf("\"")).Replace("\"", "").Trim();
            data.Name = subLines[2].Substring(subLines[2].IndexOf("\"")).Replace("\"", "").Trim();
            data.LogoURL = subLines[3].Substring(subLines[3].IndexOf("\"")).Replace("\"", "").Trim();
            
            string[] groupSplitted = subLines[4].Substring(subLines[4].IndexOf("\"")).Trim().Split(',');
            data.GroupTitle = groupSplitted[0].Replace("\"","");
            data.VisibleName = groupSplitted[1];
            data.StreamUrl = line2;
            Channels.Add(data);
        }

        private void CBGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbChannels.Items.Clear();
            lbChannels.Items.AddRange((from chn in Channels where chn.GroupTitle == CBGroups.Text  select chn).ToArray<Object>());
        }

        private void lbChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChannelData selectedChannel = (ChannelData)lbChannels.SelectedItem;

            Process p=null ;
            if (IsProcessOpen("vlc",ref p))
            {
                p.Kill();
            }
                p = new Process();
                p.StartInfo.FileName = @"C:\Program Files\VideoLAN\VLC\vlc.exe";
                p.StartInfo.Arguments = selectedChannel.StreamUrl;
                p.Start();
        }

        public bool IsProcessOpen(string name, ref Process proc)
        {
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                //now we're going to see if any of the running processes
                //match the currently running processes. Be sure to not
                //add the .exe to the name you provide, i.e: NOTEPAD,
                //not NOTEPAD.EXE or false is always returned even if
                //notepad is running.
                //Remember, if you have the process running more than once, 
                //say IE open 4 times the loop thr way it is now will close all 4,
                //if you want it to just close the first one it finds
                //then add a return; after the Kill
                if (clsProcess.ProcessName.Contains(name))
                {
                    //if the process is found to be running then we
                    //return a true
                    proc = clsProcess;
                    return true;
                }
            }
            //otherwise we return a false
            return false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void ImportM3UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExportM3UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }



    public class ChannelData
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string LogoURL { get; set; }
        public string GroupTitle { get; set; }
        public string VisibleName { get; set; }
        public string StreamUrl { get; set; }

        public ChannelData()
        {
        }

        public override string ToString()
        {
            return VisibleName ;
        }
    }
}
