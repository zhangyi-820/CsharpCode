using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpWeekNine
{
    class SimpleCrawler
    {
        private BindingSource urlInfoBindingSource;
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private string startUrl;
        private List<UrlInfo> urlinfoList = new List<UrlInfo>();
        public List<UrlInfo> UrlInfos
        {
            get
            {
                return this.urlinfoList;
            }
        }


        /*
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            myCrawler.startUrl = "https://www.cnblogs.com/dstang2000/";
            UrlInfo temp=new UrlInfo("")
            if (args.Length >= 1)
                myCrawler.startUrl = args[0];
            myCrawler.urls.Add(myCrawler.startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();

        }
        */
        public void Begin(string startUrl,BindingSource bd)
        {
            this.urlInfoBindingSource = bd;
            this.startUrl = startUrl;
            UrlInfo temp = new UrlInfo(this.startUrl, "成功");
            this.urlinfoList.Add(temp);
            this.urls.Add(this.startUrl, false);
            this.Crawl();
        }

        public List<UrlInfo> Query(bool isSuccess)
        {
            if (isSuccess)
            {
                var query = from urlinfo in urlinfoList
                            where (urlinfo.Success == "成功")
                            select urlinfo;
                return query.ToList();
            }
            else
            {
                var query = from urlinfo in urlinfoList
                            where (urlinfo.Success == "失败")
                            select urlinfo;
                return query.ToList();
            }

        }


        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url])
                    {
                        continue;
                    }
                    current = url;
                }

                if (current == null || count > 10)
                    break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                UrlInfo temp=new UrlInfo(strRef.ToString(),"失败");
                
                if (!strRef.Contains("https:"))
                {
                    temp.Url = "https://www.cnblogs.com/dstang2000/" + strRef;
                }
                if (strRef.Contains(".html") && (strRef.Contains(this.startUrl))&&(urls[strRef]==null))
                {
                    urls[strRef] = false;
                    temp.Success = "成功";
                }
                this.urlinfoList.Add(temp);
                this.urlInfoBindingSource.ResetBindings(true);
            }
        }
    }
}
