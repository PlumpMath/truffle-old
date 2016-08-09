﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blacksink.Blackboard
{
    public class CrawlableURL
    {
        public string URL { get; set; }
        public string Subfolder { get; set; }
        public string UnitCode { get; set; }

        public CrawlableURL(string unitcode, string subfolder, string url) {
            URL = url;
            UnitCode = unitcode;
            Subfolder = subfolder;
        }
    }
}
