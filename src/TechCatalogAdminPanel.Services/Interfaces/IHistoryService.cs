using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechCatalogAdminPanel.Models;

namespace TechCatalogAdminPanel.Services.Interfaces
{
    public interface IHistoryService
    {
        Task<IEnumerable<History>> GetAllHistories();
    }
}
