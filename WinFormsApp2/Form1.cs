namespace WinFormsApp2
{
    using System.Text;
    using Newtonsoft.Json;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using WinFormsApp2.Model;
    public partial class Form1 : Form
    {
        internal string _coretext = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tabReadFromDatabase_Click(object sender, EventArgs e)
        {

        }

        private async void btnReadFromDatabase_Click(object sender, EventArgs e)
        {
            await this.ReadTextDatabaseAsync();
        }
        public async Task<string> ReadTextDatabaseAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5191/textdetails/getall");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = await response.Content.ReadAsAsync<IEnumerable<Text1>>(); 
                foreach (var d in dataObjects)
                {
                    _coretext = d.TextString.ToString();
                    btnCountWordsNumber.Enabled = true;
                    lblStatusReadTextFromDatabase.Text = "Text successfully loaded from database!";
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            client.Dispose();
            return "0";
        }
        private string CallAPIGetWordCount(TextModel ulaznitekst)
        {
            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(ulaznitekst);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://localhost:5191/textdetails/GetWordCount"),

                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = client.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            return responseInfo.Content.ReadAsStringAsync().Result;
            
        }

        private void btnCountWordsNumber_Click(object sender, EventArgs e)
        {
            var inputtext = new TextModel();
            inputtext.Tekst = _coretext;
            string _wordsnumber = CallAPIGetWordCount(inputtext);
            lblStatusCountWordsNumber.Text = "Total number of words : " + _wordsnumber;
            MessageBox.Show("Total number of words: " + _wordsnumber);
        }
    }
}