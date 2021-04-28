using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seshin.Core.Models;
using Seshin.Infrastructure;
using Seshin.Infrastructure.Repositories;

namespace Seshin.Infratructure.Repositories
{
    public class PartnersRepository : BaseRepository<Partner, MyDbContext>
    {
        private readonly MyDbContext _context;
        private readonly LogsRepository _logger;
        public PartnersRepository(MyDbContext context, LogsRepository logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
