using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaDadosCVM.Models
{
    public class ImportacaoTaxa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImportacaoTaxaId { get; set; }
        public DateTime DataImportacao { get; set; }
        public string StatusImportacao { get; set; }
        public string ArquivoImportado { get; set; }
        public int DataDivulgacaoArquivo { get; set; }
    }
}
