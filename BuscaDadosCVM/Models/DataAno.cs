using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Models
{
    public class DataAno
    {
        public int DataAnoId { get; set; }
        public string Mes { get; set; }
        public string Ano { get; set; }

    }
}
