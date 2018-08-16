using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    class HtmlParse : SearchItem
    {
        private List<SearchItem> resultList = new List<SearchItem>();
        private string search;
        private HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        public HtmlParse(string search)
        {
            this.search = search;
            web.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36";
            Initialize(search);
        }

        private void Initialize(string search)
        {
            SearchItem item = null;
            doc = getHtmlDoc(search);
            searchIterate(doc, item);
        }
        private HtmlAgilityPack.HtmlDocument getHtmlDoc(string url)
        {
            return web.Load("https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313.TR12.TRC2.A0.H0.X" + System.Uri.EscapeDataString(url) 
                + ".TRS0&_nkw=" + System.Uri.EscapeDataString(url) + "&_sacat=0");
        }

        private HtmlAgilityPack.HtmlDocument getHtmlDoc(HtmlNode url)
        {
            return web.Load(url.Attributes["href"].Value);
        }

        private void searchIterate(HtmlAgilityPack.HtmlDocument doc, SearchItem item)
        {
            //string display = "";
            int count = 0;
            string name;
            string price;
            string img;

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@class='s-item__link']"))
            {
                if (count == 8)
                {
                    return;
                }
                else
                {
                    //display = link.Attributes["href"].Value;
                    doc = getHtmlDoc(link);

                    HtmlNode Name = doc.DocumentNode.SelectSingleNode("//div[@class='sw']//a");
                    HtmlNode Price = doc.DocumentNode.SelectSingleNode("//div[@class='u-flL w29 vi-price ']//span | //span[@id='mm-saleDscPrc']");
                    HtmlNode Img = doc.DocumentNode.SelectSingleNode("//img[@id='icImg']");

                    name = Regex.Replace(Name.Attributes["etafsharetitle"].Value.ToString(), @"\n", "");
                    price = Regex.Replace(Price.InnerText, @"[^.0-9]", "");
                    img = Img.Attributes["src"].Value.ToString();

                    item = new SearchItem(name, "", price, img);
                    resultList.Add(item);
                    count++;
                }
            }
        }

        public List<SearchItem> GetList()
        {
            return resultList;
        }
    }
}
