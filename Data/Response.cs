using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class Response<T>
    {

        public Response() { }

        public Response(T response)
        {
            Data = response;
        }

        public T Data { get; set; }
    }
}
