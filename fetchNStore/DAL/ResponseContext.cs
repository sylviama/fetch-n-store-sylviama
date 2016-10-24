using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using fetchNStore.Models;

namespace fetchNStore.DAL
{
    public class ResponseContext:DbContext
    {
        public virtual DbSet<Response> response { get; set; }
    }

}