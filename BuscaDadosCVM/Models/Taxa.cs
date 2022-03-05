﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Models
{
    public class Taxa
    {
        public int id { get; set; }
        public string CNPJ_FUNDO { get; set; }
        public DateTime DT_COMPTC { get; set; }
        public decimal VL_TOTAL { get; set; }
        public decimal VL_QUOTA { get; set; }
        public decimal VL_PATRIM_LIQ { get; set; }
        public decimal CAPTC_DIA { get; set; }
        public decimal RESG_DIA { get; set; }
        public decimal NR_COTST { get; set; }
    }
}
