using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries.Report
{
    public class GetReportQueryHandler : IQueryHandler<GetReportQuery, Core.Entities.Report>
    {
        private readonly PharmacyContext _context;

        public GetReportQueryHandler(PharmacyContext context)
        {
            _context = context;
        }

        public async Task<Core.Entities.Report> HandleAsync(GetReportQuery query, CancellationToken cancellationToken = default)
        {
            var report = new Core.Entities.Report();
            report.StartDate = query.StartDate;
            report.EndDate = query.EndDate;

            var anullatedOrderStartDate = query.StartDate.HasValue ? query.StartDate.Value : await _context.AnullatedOrders.MinAsync(o => o.CreateDate, cancellationToken);
            var anullatedOrderEndDate = query.EndDate.HasValue ? query.EndDate.Value : await _context.AnullatedOrders.MaxAsync(o => o.CreateDate, cancellationToken);
            report.AnullatedOrders = _context.AnullatedOrders.Where(o => o.CreateDate >= anullatedOrderStartDate && o.CreateDate <= anullatedOrderEndDate);

            var orderStartDate = query.StartDate.HasValue ? query.StartDate.Value : await _context.Orders.MinAsync(o => o.CreateDate, cancellationToken);
            var orderEndDate = query.EndDate.HasValue ? query.EndDate.Value : await _context.Orders.MaxAsync(o => o.CreateDate, cancellationToken);
            report.Orders = _context.Orders.Where(o => o.CreateDate >= orderStartDate && o.CreateDate <= orderEndDate);

            return report;
        }
    }
