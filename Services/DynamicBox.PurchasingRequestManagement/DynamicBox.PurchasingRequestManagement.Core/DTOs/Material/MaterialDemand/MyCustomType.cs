using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBox.PurchasingRequestManagement.Core.DTOs.Material.MaterialDemand
{
    public class MyCustomType
    {
        public int TotalAccount { get; set; }
        //public List<Models.MaterialDemand.MaterialDemand> MaterialDemands { get; set; }
        public List<Models.MaterialDemand.MaterialDemand> MaterialDemands { get; set; }
    }
}
