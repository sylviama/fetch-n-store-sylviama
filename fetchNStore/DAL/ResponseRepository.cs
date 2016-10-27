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
        public void SaveResponse(dynamic responseData)
        {
            Response res = new Response();
            res.StatusCode = responseData.StatusCode;
            res.ResponseTime = responseData.ResponseTime;
            res.TimeRequest = responseData.TimeRequest;
            res.HttpMethod = responseData.HttpMethod;
            res.URL = responseData.URL;

            Context.response.Add(res);
            Context.SaveChanges();
        }

        //read
        public List<Response> GetResponse()
        {
            return Context.response.ToList();
        }
    }
}