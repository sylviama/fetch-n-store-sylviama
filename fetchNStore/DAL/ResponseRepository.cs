using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using fetchNStore.Models;

namespace fetchNStore.DAL
{
    public class ResponseRepository
    {
        public ResponseContext Context { get; set; }

        public ResponseRepository()
        {
            Context = new ResponseContext();
        }

        public ResponseRepository(ResponseContext context)
        {
            Context = context;
        }
        //save
        public void SaveResponse(Response response)
        {
            Context.response.Add(response);
            Context.SaveChanges();
        }

        //read
        public List<Response> GetResponse()
        {
            return Context.response.ToList();
        }
    }
}