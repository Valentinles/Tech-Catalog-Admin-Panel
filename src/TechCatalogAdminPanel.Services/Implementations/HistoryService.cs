using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechCatalogAdminPanel.Data;
using TechCatalogAdminPanel.Models;
using TechCatalogAdminPanel.Services.Interfaces;

namespace TechCatalogAdminPanel.Services.Implementations
{
    public class HistoryService : DataService, IHistoryService
    {
        public readonly IMapper mapper;
        public HistoryService(IMapper mapper, TechCatalogDbContext context) : base(context)
        {
            this.mapper = mapper;
        }

        public async Task<IEnumerable<History>> GetAllHistories()
        {
            var histories = await this.context.Histories
                .OrderByDescending(h=>h.CreatedOn)
                .ToListAsync();

            return histories;
        }
    }
}
