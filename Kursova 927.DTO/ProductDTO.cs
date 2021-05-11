﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_927.DTO
{
    public class ProductDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAviable { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }

        public List<string> ImagesURL { get; set; }

    }
}
