using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
using YoutubeSearch;

namespace Video_Downloader
{
    public partial class frmMain : MaterialForm
    {
        List<Video> list = new List<Video>();
        Video video = new Video();
        ListViewItem lvi = new ListViewItem();
        int [] indexThread = new int[Environment.ProcessorCount];
        Thread[] threads = new Thread[Environment.ProcessorCount];

        public frmMain()
        {
            
            InitializeComponent();
            activityListView.DoubleBuffering(true);
            uiDesign();
            //searchBackgroundWorker.RunWorkerAsync();
            //searchBackgroundWorker.WorkerReportsProgress = true;
            //searchBackgroundWorker.DoWork += new DoWorkEventHandler(btnSearch_Click);
            //searchBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(searchBackgroundWorker_ProgressChanged);
        }
        private void uiDesign()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green800, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void searchBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                if (searchProgressBar.Value < 100)
                {
                    searchProgressBar.Value = (int)e.ProgressPercentage;
                    searchProgressBar.Update();
                }
            }));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            searchListView.Clear();
            list.Clear();
            VideoSearch items = new VideoSearch();
            ImageList ilist = new ImageList();
            foreach (var item in items.SearchQuery(searchTextField.Text, 1))
            {
                cnt++;
                Video video = new Video();
                video.Title = item.Title;
                video.Author = item.Author;
                video.Duration = item.Duration;
                video.Url = item.Url;
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                    ilist.Images.Add(Image.FromStream(ms));
                }
                list.Add(video);
                
            }
            searchListView.View = View.LargeIcon;
            ilist.ColorDepth = ColorDepth.Depth32Bit;
            ilist.ImageSize = new Size(256, 175);

            searchListView.LargeImageList = ilist;

            for (int i = 0; i < ilist.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = list[i].Title;
                searchListView.Items.Add(lvi);
            }
            //searchBackgroundWorker.ReportProgress(cnt);
            //Thread.Sleep(100);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(tabPage: playTabPage);
            if (searchListView.SelectedItems.Count > 0)
            {
                int i = searchListView.FocusedItem.Index;
                video = list[i];

                var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(video.Url);
                if (ytMatch.Success)
                {
                    string regexUrl = ytMatch.Groups[1].Value; 
                    axShockwaveFlash.Movie = $"http://youtube.com/v/{regexUrl}?version=3";
                }

            }

        }
        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(tabPage: downloadTabPage);
            int i = searchListView.FocusedItem.Index;
            video = list[i];
            downloadUrlTextField.Text = video.Url;

        }
        private void addToActivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = searchListView.FocusedItem.Index;
            video = list[i];
            string strSize = video.Size.ToString();
            DateTime dt = DateTime.Now;
            DateTime dt2 = DateTime.MinValue;
            string completed = dt2.ToString();
            string added = dt.ToString();
            video.Location = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] str = new string[7] { video.Title,strSize, completed,"0%",added, video.Url,video.Location};
            lvi = new ListViewItem(str);
            activityListView.Items.Add(lvi);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (searchListView.SelectedItems.Count > 0)
            {
                downloadProgressBar.Minimum = 0;
                downloadProgressBar.Maximum = 100;
                resolutionComboBox.SelectedValue = 360;
                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(downloadUrlTextField.Text);
                try
                {
                    VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(resolutionComboBox.Text));
                    if (video.RequiresDecryption)
                        DownloadUrlResolver.DecryptDownloadUrl(video);
                    VideoDownloader downloader = new VideoDownloader(video, Path.Combine(saveToTextField.Text + "\\", video.Title + video.VideoExtension));
                    downloader.DownloadProgressChanged += downloader_DownloadProgressChanged;
                    Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
                    thread.Start();
                    downloader.DownloadFinished += downloader_DownloadFinshed;
                }
                catch
                {
                    MessageBox.Show("Error! Either download is not allowed or resolution is not supported");
                }
            }
            else if(!string.IsNullOrWhiteSpace(downloadUrlTextField.Text))
            {
                downloadProgressBar.Minimum = 0;
                downloadProgressBar.Maximum = 100;
                IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(downloadUrlTextField.Text);
                VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(resolutionComboBox.Text));
                if (video.RequiresDecryption)
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                VideoDownloader downloader = new VideoDownloader(video, Path.Combine(saveToTextField.Text + "\\", video.Title + video.VideoExtension));
                downloader.DownloadProgressChanged += downloader_DownloadProgressChanged;
                Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
                thread.Start();
                downloader.DownloadFinished += downloader_DownloadFinshed;
                
            }
            else
            {
                MessageBox.Show("Enter Url!");
            }
        }

        private void downloader_DownloadFinshed(object sender, EventArgs e)
        {
            Downloader downloader = sender as Downloader;
            FileInfo fi = new FileInfo(downloader.SavePath);
            float size = (fi.Length / 1024f) / 1024f;
            video.Size = size;
            video.Location = downloader.SavePath;
        }
        private void downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                downloadProgressBar.Value = (int)e.ProgressPercentage;
                downloadProgressBar.Update();

            }));
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                saveToTextField.Text = fbd.SelectedPath;
        }
        private void btnLoadTo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                fileLoadTextField.Text = ofd.FileName;
        }
        private void btnSaveTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)  
                fileSaveTextField.Text = fbd.SelectedPath;  
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fileLoadTextField.Text))
            {

                if (!string.IsNullOrEmpty(typeComboBox.Text))
                {
                    string fullFilename = Path.GetFileName(fileLoadTextField.Text);
                    string loadDir = Path.GetDirectoryName(fileLoadTextField.Text);
                    string filename = Path.GetFileNameWithoutExtension(fileLoadTextField.Text);
                    string saveDir = fileSaveTextField.Text;
                    string type = typeComboBox.Text;
                    string quality = qualityComboBox.Text;

                    string ffmpegpath = Environment.CurrentDirectory + "\\ffmpeg\\ffmpeg.exe";
                    string loadArg = "\"" + loadDir + "\\" + fullFilename + "\"";
                    string saveArg = "\"" + saveDir + "\\" + filename + type + "\"";

                    Process process = new Process();
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.FileName = ffmpegpath;
                    process.StartInfo.Arguments = "-i " + loadArg + " " + saveArg;

                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();
                }
                else
                {
                    MessageBox.Show("Select format to convert!");
                }  
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }
        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] auidoQuality = { "320k", "256k", "192k", "128k" };
            string[] videoQuality = { "1080k", "720k", "480k", "360k" };
            string[] audioFormats = { ".mp3", ".acc", ".ogg", ".wma", ".wav" };
            string[] videoFormats = { ".mp4", ".mov", ".avi", ".flv", ".wmv" };

            bool isAudio = false;
            qualityComboBox.Items.Clear();
            string format = typeComboBox.Text;

            foreach(string other in audioFormats)
            {
                if (format.Equals(other))
                {
                    isAudio = true;
                    qualityComboBox.Items.AddRange(auidoQuality);
                }
                    
            }
            if (isAudio == false) qualityComboBox.Items.AddRange(videoQuality);
        }
        private void toolStart_Click(object sender, EventArgs e)
        {
            if(activityListView.SelectedItems.Count == 1)
            {
                lvi = new ListViewItem();
                lvi = activityListView.SelectedItems[0];
                int index = activityListView.SelectedIndices[0];
                indexThread[index] = index;
                
                if (!string.IsNullOrEmpty(lvi.SubItems[6].Text))
                {
                    if (lvi.SubItems[3].Text.ToString() != "0%")
                    {

                        for (int i = 0; i < indexThread.Length; i++)
                        {
                            if (threads[i] != null && activityListView.SelectedIndices[0] == indexThread[i] && threads[i].IsAlive)
                            {
                                threads[i].Resume();
                            }
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("The default save location is on Desktop if you want to change press Yes", "", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FolderBrowserDialog fbd = new FolderBrowserDialog();
                            if (fbd.ShowDialog() == DialogResult.OK)
                                lvi.SubItems[6].Text = fbd.SelectedPath;
                        }
                        else if (dialogResult == DialogResult.No) { }
                        IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(lvi.SubItems[5].Text);
                        VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4);
                        if (video.RequiresDecryption)
                            DownloadUrlResolver.DecryptDownloadUrl(video);
                        VideoDownloader downloader = new VideoDownloader(video, Path.Combine(lvi.SubItems[6].Text + "\\", video.Title + video.VideoExtension));
                        downloader.DownloadProgressChanged += downloader_DownloadProgressChangedTag;
                        threads[index] = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
                        threads[index].Start();
                        downloader.DownloadFinished += downloader_DownloadFinshedTag;
                    }

                }
            }
            
        }
        private void downloader_DownloadFinshedTag(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                DateTime dt = DateTime.Now;
                lvi.SubItems[2].Text = dt.ToString();
                
                Downloader downloader = sender as Downloader;
                FileInfo fi = new FileInfo(downloader.SavePath);
                float size = (fi.Length / 1024f) / 1024f;
                video.Size = size;
                lvi.SubItems[1].Text = size.ToString("0.00 Mb");
            }));
            
        }

        private void downloader_DownloadProgressChangedTag(object sender, ProgressEventArgs e)
        {
            
            Invoke(new MethodInvoker(delegate ()
            {
                activityListView.BeginUpdate();
                try
                {
                    lvi.SubItems[3].Text = $"{ string.Format("{0:0.##}", e.ProgressPercentage) }%";
                }
                finally
                {
                    activityListView.EndUpdate();
                }
            }));

        }
        private void toolPause_Click(object sender, EventArgs e)
        {
            if (activityListView.SelectedItems.Count == 1)
            {
               for(int i = 0; i < indexThread.Length; i++)
                {
                    if(threads[i] != null && activityListView.SelectedIndices[0] == indexThread[i] && threads[i].IsAlive)
                    {
                        threads[i].Suspend();
                    }
                }
            }
        }
        private void toolRemove_Click(object sender, EventArgs e)
        {
            if (activityListView.SelectedItems.Count == 1)
            {
                foreach (ListViewItem item in activityListView.SelectedItems)
                {
                    activityListView.Items.Remove(item);
                }
            }
        }
        private void toolRemoveCompleted_Click(object sender, EventArgs e)
        {
            
            if (activityListView.SelectedItems.Count == 1 )
            {
                lvi = new ListViewItem();
                lvi = activityListView.SelectedItems[0];
                if (lvi.SubItems[3].Text.ToString() == "100%")
                {
                    foreach (ListViewItem item in activityListView.SelectedItems)
                        activityListView.Items.Remove(item);
                } 
            }
        }

        private void toolStartAll_Click(object sender, EventArgs e)
        {
            if(activityListView.Items.Contains(lvi))
            {

                for (int i = 0; i < activityListView.Items.Count; i++)
                {
                    lvi = activityListView.Items[i];
                    if (threads[i] != null)
                    {
                        if (threads[i].ThreadState == System.Threading.ThreadState.Background)
                        {
                            if (threads[i].ThreadState == System.Threading.ThreadState.Suspended)
                                threads[i].Resume();
                        }
                    }
                    else
                    {
                        foreach (ListViewItem lvi in activityListView.Items)
                        {
                            MessageBox.Show(lvi.Text);
                            download(lvi);
                        }
                    }
                }
            }
        }
        private void download(ListViewItem lvi)
        {
            int i = lvi.Index;
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(lvi.SubItems[5].Text);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4);
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(lvi.SubItems[6].Text + "\\", video.Title + video.VideoExtension));
            downloader.DownloadProgressChanged += downloader_DownloadProgressChangedTag;
            threads[i] = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            threads[i].Start();
            downloader.DownloadFinished += downloader_DownloadFinshedTag;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(tabPage: downloadTabPage);
        }

        private void toolMoveSelectionsUp_Click(object sender, EventArgs e)
        {
            int selCount = activityListView.SelectedItems.Count;

            if (selCount > 0)
            {
                try
                {
                    activityListView.BeginUpdate();

                    ListViewItem tmp = null;
                    for (int i = 0; i < selCount; i++)
                    {
                        tmp = activityListView.SelectedItems[i];

                        if (tmp.Index > 0
                            && !activityListView.Items[tmp.Index - 1].Selected)
                        {
                            SwapElements(tmp.Index);
                        }
                    }
                    activityListView.SelectedItems[0].EnsureVisible();
                }
                finally
                {
                    activityListView.EndUpdate();
                }
            }
        }

        private void toolMoveSelectionsDown_Click(object sender, EventArgs e)
        {
            int selCount = activityListView.SelectedItems.Count;
            if (selCount > 0)
            {
                try
                {
                    activityListView.BeginUpdate();

                    ListViewItem tmp = null;
                    for (int i = selCount - 1; i >= 0; i--)
                    {
                        tmp = activityListView.SelectedItems[i];

                        if (tmp.Index < activityListView.Items.Count - 1
                            && !activityListView.Items[tmp.Index + 1].Selected)
                        {
                            SwapElements(tmp.Index + 1);
                        }
                    }
                    activityListView.SelectedItems[selCount - 1].EnsureVisible();
                }
                finally
                {
                    activityListView.EndUpdate();
                }
            }
        }

        private void SwapElements(int idx)
        {
            ListViewItem it1 = activityListView.Items[idx];
            ListViewItem it2 = activityListView.Items[idx - 1];

            activityListView.Items.RemoveAt(idx);
            activityListView.Items.RemoveAt(idx - 1);

            activityListView.Items.Insert(idx - 1, it1);
            activityListView.Items.Insert(idx, it2);
        }
    }
}
