using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Models
{
    public class DataAno
    {
        public int DataAnoId { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }

    public enum Meses
    {
        Janeiro,
        Fevereiro,
        Março,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }
}
