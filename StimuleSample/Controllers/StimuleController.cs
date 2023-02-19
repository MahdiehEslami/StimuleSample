using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Zamin.EndPoints.Web.Controllers;

namespace StimuleSample.Controllers
{
    [Route("api/[controller]")]
    public class StimuleController : BaseController
    {

        #region StimuleModel

        [HttpGet("PrintPdf")]
        public async Task<IActionResult> PrintPdf()
        {
            var report = this.GetReport();
            return (StiNetCoreReportResponse.PrintAsPdf(report));
        }

        private StiReport GetReport()
        {
            var reportPath = StiNetCoreHelper.MapPath(this, "Reports/FactorReport.mrt");
            var report = new StiReport();
            report["name"] = "علی";
            report["family"] = "احمدیان";
            report["date"] = "1401-11-27";
            report["FactorNo"] = "125489";
            report["CompanyName"] = "سروش همراه";
            report.Load(reportPath);
            return report;
        }
        #endregion
    }
}
