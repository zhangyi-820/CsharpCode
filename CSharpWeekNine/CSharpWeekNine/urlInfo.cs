using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWeekNine
{
    class UrlInfo
    {
        private string url;
        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }

        private string success;
        public string Success
        {
            get
            {
                return this.success;
            }
            set
            {
                this.success = value;
            }
        }

        public UrlInfo(string url)
        {
            this.Url = url;
        }

        public UrlInfo(string url,string success)
        {
            this.Url = url;
            this.Success = success;
        }

    }
}
