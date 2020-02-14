using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace ActionControllerExamples.Controllers
{
    public class ResultFilter : ActionFilterAttribute, IResultFilter
    {
        string path = @"C:\Log\dilip.txt";
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            using (StreamWriter writer = File.AppendText(path))
            {
                var ds = (ObjectResult)context.Result;
                writer.WriteLine($"{ds.Value} --resultexecuted");
            }
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            using (StreamWriter writer = File.AppendText(path)) 
            {
                var ds = (ObjectResult)context.Result;
                writer.WriteLine($"{ds.Value} -result");
            }
        }
    }
}