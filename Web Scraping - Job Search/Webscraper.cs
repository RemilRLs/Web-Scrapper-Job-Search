using System.Net;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using JobSearchTool;
using DatabaseMySQL;


namespace WebScrapper
{
    public class URLDataFinder
    {
        

        public string inputUserURL; // Final result of the URL;
        private string jobSearchWebsite; // The site where the user wants to scrap the jobs. 
        public string categoryJob;
        public string locationJob;


        private async Task<string> CallUrl()
        {
            // We instantiate a new HTTP Client.

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(inputUserURL);


            return response;
        }
         
        public HtmlAgilityPack.HtmlDocument GetHTMLData()
        {
            Task<string> response = CallUrl();

            // Creation of an instance.

            HtmlWeb web = new HtmlWeb();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HtmlAgilityPack.HtmlDocument document = web.Load(inputUserURL);


            return document;
        }

        public void SearchInformationJob()
        {
            JobSearchInformation jobSearch = new JobSearchInformation();

            // Extraction of data ! Let's go.

            HtmlAgilityPack.HtmlDocument document = GetHTMLData();

            jobSearch.GetJobInformation(document);
        }


        public HtmlAgilityPack.HtmlDocument SearchApplyJob()
        {
            JobSearchInformation jobSearch = new JobSearchInformation();

            HtmlAgilityPack.HtmlDocument document = GetHTMLData();

            return document;
        }

       
    }

}
