using System.Net;
using System.Text.Json;

namespace _02._09_WF
{
    public partial class PixabayImageSaver : Form
    {
        private string _path { get; set; }
        private string _urlBase { get; set; }
        private string _key { get; set; }
        private string _query { get; set; }
        private int _count { get; set; }
        private WebClient _web { get; set; }
        public PixabayImageSaver()
        {
            InitializeComponent();
            _path = @"D:\test\";
            _key = "39206396-a3d0261b98314ee7c13677bfd";
            _query = "yellow flowers";
            _count = 20;
            _urlBase = $@"https://pixabay.com/api/?key{_key}=&q={_query}&image_type=photo&per_page={_count}";
            this.Search_tb.Text = _query;
            this.PicCounter_num.Value = _count;
            this.SavePath_tb.Text = @"D:\test\";
            _web = new WebClient();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            List<string> list = this.Search_tb.Text.Split(' ').ToList();
            _query = string.Empty;
            _query = string.Join('+', list);
            _count = (int)this.PicCounter_num.Value;
            _path = this.SavePath_tb.Text;
            _urlBase = $@"https://pixabay.com/api/?key={_key}&q={_query}&image_type=photo&per_page={_count}";
            string s = _web.DownloadString(_urlBase);
            HitsCollection t = JsonSerializer.Deserialize<HitsCollection>(s);
            foreach (Hit item in t.hits)
            {
                _web.DownloadFile(new Uri(item.largeImageURL), $@"{_path}{item.id}.jpg");
            }
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            this.Search_tb.Text = "yellow flowers";
            this.PicCounter_num.Value = 20;
            this.SavePath_tb.Text = @"D:\test\";
        }

        private void OnPickPathClick(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.SavePath_tb.Text = $@"{fbd.SelectedPath}\";
                }
            }
        }
    }
}