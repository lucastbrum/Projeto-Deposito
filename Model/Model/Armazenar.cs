﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Armazenar
    {
        public int ArmazenarID { get; set; }

        public int ClienteID { get; set; }
        public virtual Cliente _Cliente { get; set; }

        public int ProdutoID { get; set; }
        public virtual Produto _Produto { get; set; }
    }
}
