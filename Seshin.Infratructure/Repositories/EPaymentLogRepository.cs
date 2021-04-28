using Seshin.Core.Models;
using Seshin.Infrastructure;
using Seshin.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seshin.Infrastructure.Repositories
{
    public class EPaymentLogRepository : BaseRepository<EPaymentLog, MyDbContext>
    {
        private readonly MyDbContext _context;
        private readonly LogsRepository _logger;
        public EPaymentLogRepository(MyDbContext context, LogsRepository logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
