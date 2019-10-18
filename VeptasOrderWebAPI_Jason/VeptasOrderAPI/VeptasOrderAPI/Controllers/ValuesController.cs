using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VeptasOrderAPI.VeptasOrderAPIService;

namespace VeptasOrderAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpPost]
        public VeptasOrderResponse CreateOrder(VeptasOrderRequest objVeptasOrderRequest)
        {
            VeptasOrderResponse objVeptasOrderResponse = new VeptasOrderResponse();
            VeptasIntegratorServiceClient objClient = new VeptasIntegratorServiceClient();
            objVeptasOrderResponse = objClient.CreateOrder(objVeptasOrderRequest);
            return objVeptasOrderResponse;
        }


        [HttpPost]
        public Status RateAcceptReject(RateAcceptReject objRateAcceptReject)
        {
            Status status = new Status();
            VeptasIntegratorServiceClient objClient = new VeptasIntegratorServiceClient();
            status = objClient.RateAcceptReject(objRateAcceptReject);
            return status;
        }

        [HttpPost]
        public Status SendMessage(MessageRequest objMessageRequest)
        {
            Status status = new Status();
            VeptasIntegratorServiceClient objClient = new VeptasIntegratorServiceClient();
            status = objClient.SendMessage(objMessageRequest);
            return status;
        }



        [HttpPost]
        public OrderStatus GetOrderStatus(OrderStatusRequest objOrderStatusRequest)
        {
            OrderStatus objOrderStatus = new OrderStatus();
            VeptasIntegratorServiceClient objClient = new VeptasIntegratorServiceClient();
            objOrderStatus = objClient.GetOrderStatus(objOrderStatusRequest);
            return objOrderStatus;
        }






        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}