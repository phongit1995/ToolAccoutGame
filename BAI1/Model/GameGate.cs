using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI1.Model
{
    public class GameGate
    {
        public string Name { get; set; } = "";
        public string Domain { get; set; } = "";
        public string Schema { get; set; } = "";
        public string SubDomainLogin { get; set; } = "";

        public string LoginApi { get; set; } = "";
        public string GetStockApi { get; set; } = "";
    }
}
