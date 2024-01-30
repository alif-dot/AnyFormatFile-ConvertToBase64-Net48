using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PdfDocxFileConvertToBase64.Models
{
    public class FileUploadModel
    {
        public HttpPostedFileBase File { get; set; }
    }
}