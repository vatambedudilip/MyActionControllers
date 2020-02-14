using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ActionControllerExamples
{
    public class LogFilterAttribute : ActionFilterAttribute, IActionFilter
    {
        string path = @"C:\Log\dilip.txt";
        public void OnActionExecuted(ActionExecutedContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{ context.HttpContext.Request.Path.Value} --Executed");
            }

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{ context.HttpContext.Request.Path.Value} --Executing");
            }
            
        }
    }
}
