using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PdfDocxFileConvertToBase64.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string Base64Content { get; set; }
        public DateTime UploadedDateTime { get; set; }
    }

}