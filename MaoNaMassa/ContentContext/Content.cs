﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaoNaMassa.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid(); //SPOF
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
