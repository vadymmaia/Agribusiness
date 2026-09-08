using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Agribusiness
    {
        public class AgroProduct
        {
            public Guid Id { get; set; } = Guid.NewGuid();
            public string Category { get; set; } = string.Empty;
            public string ProductName { get; set; } = string.Empty;
            public double QuantityInTons { get; set; }
            public double PricePerTon { get; set; }
            public string WarehouseLocation { get; set; } = string.Empty;
            public DateTime HarvestDate { get; set; } = DateTime.Now;

            // Додайте цей рядок:
            public string ImagePath { get; set; } = string.Empty;
        }
    }

