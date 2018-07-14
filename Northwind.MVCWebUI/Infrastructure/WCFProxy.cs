using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Northwind.MVCWebUI.Infrastructure
{
   public  static class WCFProxy<T>
   {
      public static T CreateChannel()
      {
         string address = String.Format("http://localhost:3795/{0}.svc?wsdl", typeof(T).Name.Substring(1));
         //string address = String.Format("https://localhost:3905/{0}.svc?wsdl", typeof(T).Name.Substring(1));

         
         var binding = new BasicHttpBinding();
         var channel = new ChannelFactory<T>(binding, address);
         return channel.CreateChannel();
      }
   }
}