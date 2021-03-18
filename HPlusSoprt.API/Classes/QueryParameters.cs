﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSoprt.API.Classes
{
    public class QueryParameters
    {
        const int maxSize = 100;
        private int size = 50;

        public int Page { get; set; }

        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = Math.Min(maxSize, value);
            }
        }
    }
}
