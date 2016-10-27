using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fetchNStore.Models
{
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public int StatusCode { get; set; }
        public string URL { get; set; }
        public string ResponseTime { get; set; }
        public string HttpMethod { get; set; }
        public string TimeRequest { get; set; }
    }
}