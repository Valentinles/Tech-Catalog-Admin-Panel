using System;
using System.Collections.Generic;
using System.Text;
using TechCatalogAdminPanel.Data;

namespace TechCatalogAdminPanel.Services.Implementations
{
    public class DataService
    {
        protected readonly TechCatalogDbContext context;
        public DataService(TechCatalogDbContext context)
        {
            this.context = context;
        }
    }
}
