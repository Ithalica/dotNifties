using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace dotNifties.Mvc.Results
{
    public class InlineFileResult : FileContentResult
    {
        public InlineFileResult(byte[] fileContents, string contentType) : base(fileContents, contentType)
        {
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = ContentType;
            if (!string.IsNullOrEmpty(FileDownloadName))
            {
                string str = new ContentDisposition { FileName = this.FileDownloadName, Inline = true }.ToString();
                context.HttpContext.Response.AddHeader("Content-Disposition", str);
            }
            WriteFile(response);
        }
    }
}
