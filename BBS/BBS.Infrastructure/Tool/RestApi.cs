using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
namespace BBS.Infrastructure.Tool
{
    public class RestApi<T> where T : class, new()
    {
        public T Get(string url, object pars)
        {
            var type = Method.POST;
            IRestResponse<T> reval = GetApiInfo(url, pars, type);
            return reval.Data;
        }
        public T Post(string url, object pars)
        {
            var type = Method.POST;
            IRestResponse<T> reval = GetApiInfo(url, pars, type);
            return reval.Data;
        }
        public T Delete(string url, object pars)
        {
            var type = Method.DELETE;
            IRestResponse<T> reval = GetApiInfo(url, pars, type);
            return reval.Data;
        }
        public T Put(string url, object pars)
        {
            var type = Method.PUT;
            IRestResponse<T> reval = GetApiInfo(url, pars, type);
            return reval.Data;
        }

        private static IRestResponse<T> GetApiInfo(string url, object pars, Method type)
        {
            var request = new RestRequest("resource/{id}", type);
            if (pars != null)
                request.AddObject(pars);
            var client = new RestClient(url);
            client.CookieContainer = new System.Net.CookieContainer();
            IRestResponse<T> reval = client.Execute<T>(request);
            return reval;
        }
    }
}
