using Core.Queries;

namespace DAL.Queries.Report
{
    public class GetReportQuery : IQuery<Core.Entities.Report>
    {
        public GetReportQuery(DateTime? startDate, DateTime? endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime? StartDate { get; }

        public DateTime? EndDate { get; }
    }
}
