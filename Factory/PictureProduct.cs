﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PictureProduct
    {
        public int Id { get; set; }
        public int PictureID {  get; set; }
        public Picture  Picture { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
