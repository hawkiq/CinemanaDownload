using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CinemanaDownload
{
    public partial class Form1 : Form
    {
        private ShowInfo _movie;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text) || Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                // Get the URL from the clipboard
                string url = Clipboard.GetText();

                bool isValid = IsValidUrl(url);
                if (isValid)
                {
                    urlBox.Text = url;
                }
               
                
            }
        }

     

        private async void getLinks_Click(object sender, EventArgs e)
        {
            string textUrl = urlBox.Text;
            if (!string.IsNullOrEmpty(textUrl))
            {
                string numberPattern = @"\d+";
                bool isValid = IsValidUrl(textUrl);
                if (!isValid)
                {
                    MessageBox.Show("You must enter correct Link in Box", "Invalid Cinemana Url");
                    urlBox.Text="";
                }
                else
                {
                    MatchCollection matches = Regex.Matches(textUrl, numberPattern);
                    int number;
                    if (matches.Count == 1)
                    {
                        number = Convert.ToInt32(matches[0].Value);
                    }
                    else
                    {
                        number = Convert.ToInt32(matches[matches.Count - 1].Value);
                    }
                    string filesUrl = $"https://cinemana.shabakaty.com/api/android/transcoddedFiles/id/{number}";
                    string subtitlessUrl = $"https://cinemana.shabakaty.com/api/android/translationFiles/id/{number}";
                    string showInfoUrl = $"https://cinemana.shabakaty.com/api/android/allVideoInfo/id/{number}";
                    progressBar1.Visible = true;
                    progressBar1.Style = ProgressBarStyle.Marquee;
                    getLinks.Enabled = false;
                    var data = await getFilesList(filesUrl);
                    var dataSrt = await getSubsList(subtitlessUrl);
                    _movie = await GetInfo(showInfoUrl);

                    movieLabel.Text = _movie.en_title;
                    thumbPic.ImageLocation = _movie.imgMediumThumbObjUrl;
                    movieLabel.Visible = true;
                    thumbPic.Visible = true;

                    List<VideoInfo> videoList = data;
                    //List<SubtitleInfo> subList = dataSrt;
                    filesListView.Visible = true;
                    subListView.Visible = true;
                    filesListView.Items.Clear();
                    filesListView.Columns.Clear();
                    subListView.Items.Clear();
                    subListView.Columns.Clear();
                    filesListView.View = View.Details;
                    subListView.View = View.Details;
                    filesListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                    subListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                    filesListView.FullRowSelect = true;
                    subListView.FullRowSelect = true;
                    filesListView.GridLines = true;
                    subListView.GridLines = true;

                    filesListView.Columns.Add("Resolution", 100, HorizontalAlignment.Center);
                    subListView.Columns.Add("Subtitle", 100, HorizontalAlignment.Center);
                    //filesListView.Columns.Add("Video URL", 200, HorizontalAlignment.Left);

                    if (videoList != null)
                    {
                        foreach (VideoInfo video in videoList)
                        {
                            ListViewItem item = new ListViewItem(video.resolution);
                            item.SubItems.Add(video.videoUrl);
                            filesListView.Items.Add(item);
                        }
                    }

                    List<SubtitleInfo> subtitleInfos = new List<SubtitleInfo>();

                    if (dataSrt != null && dataSrt.Count > 0)
                    {
                        foreach (var item in dataSrt)
                        {
                            if ((string)item["extention"] == "srt")
                            {
                                SubtitleInfo info = new SubtitleInfo
                                {
                                    extention = (string)item["extension"],
                                    name = (string)item["name"],
                                    fileUrl = (string)item["file"]
                                };
                                subtitleInfos.Add(info);
                            }

                        }

                        if (subtitleInfos.Count > 0)
                        {
                            foreach (var subtitleInfo in subtitleInfos)
                            {
                                ListViewItem item = new ListViewItem(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subtitleInfo.name.ToLower()));
                                item.SubItems.Add(subtitleInfo.extention);
                                item.SubItems.Add(subtitleInfo.fileUrl);

                                subListView.Items.Add(item);
                            }
                        }
                        progressBar1.Visible = false;
                        progressBar1.Style = ProgressBarStyle.Blocks;
                        getLinks.Enabled = true;

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Enter the Url","Required Url");
            }
            
        }

        private static async Task<ShowInfo> GetInfo(string showInfoUrl)
        {
            using (var webClient = new HttpClient())
            {
                var json = await webClient.GetStringAsync(showInfoUrl);
                return JsonConvert.DeserializeObject<ShowInfo>(json);
            }
        }

        private static async Task<dynamic> getFilesList(string filesUrl)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(filesUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<VideoInfo>>(content);
            }

            return null;

        }

        private static async Task<dynamic> getSubsList(string subtitlessUrl)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(subtitlessUrl);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(content);
                JArray translations = (JArray)json["translations"];
                return translations;

            }

            return null;

        }

        private void filesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = filesListView.SelectedItems[0];
                string url = item.SubItems[1].Text;
                DownloadFile(url,_movie);
            }
            catch (Exception)
            {
                MessageBox.Show("Please download again","Error");
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            urlBox.Text = string.Empty;
        }
        private void DownloadFile(string url,ShowInfo _movie)
        {
            string IDM_Path = "C:\\Program Files (x86)\\Internet Download Manager\\IDMan.exe";
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads\\Videos");
            string fileName = _movie.en_title.Replace(" ","_") + "_" + _movie.fileFile;
            System.Diagnostics.Process.Start(IDM_Path, "/d " + url + " /p " + downloadPath + " /f " + fileName);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getLinks.PerformClick();
            }
        }

        private void subListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = subListView.SelectedItems[0];
                string url = item.SubItems[2].Text;
                string fileName = _movie.en_title.Replace(" ", "_") + "_ar.srt";
                DownloadSub(url, fileName);
            }
            catch (Exception)
            {

                MessageBox.Show("Please download again","Error");
            }
        }
        private void DownloadSub(string url, string filePath)
        {
            System.Diagnostics.Process.Start(url);
            using (WebClient client = new WebClient())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Subtitle files (*.srt)|*.srt";
                saveFileDialog.FileName = filePath;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    client.DownloadFile(url, saveFileDialog.FileName);
                }
            }
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text) || Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
               
                // Get the URL from the clipboard
                string url = Clipboard.GetText();
                bool isValid = IsValidUrl(url);
                if (isValid)
                {
                    urlBox.Text = url;
                }
            }

        }

        private bool IsValidUrl(string url)
        {
            Uri result;
            return Uri.TryCreate(url, UriKind.Absolute, out result) && result.Host.Contains("cinemana.shabakaty.com");
        }
    }
}
