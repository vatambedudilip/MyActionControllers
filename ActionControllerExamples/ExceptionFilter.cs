using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace ActionControllerExamples
{
    public class ExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string path = @"C:\Log\dilip.txt";

            using (StreamWriter stream = File.AppendText(path))
            {
                stream.WriteLine(context.Exception.Message);
                stream.WriteLine(context.Exception.StackTrace);
            }
        }
    }
}
