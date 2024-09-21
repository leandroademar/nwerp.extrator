using Hangfire.Dashboard;

namespace nwErp.Api.Configuration;
using Hangfire.Dashboard.BasicAuthorization;


public class HangFireDashboard
{
    public class MyAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            return true; 
        }
    }
}