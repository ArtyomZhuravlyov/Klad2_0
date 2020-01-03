using ConsoleApp1.ServiceReference1;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        //https://developer.sberbank.ru/doc/v1/acquiring/webservice-requests1pay информация по документации 

        private MerchantServiceClient _merchantServiceClient;
        private orderParams _orderParams;
        private Cart _cart;
        private ShippingDetails _shippingDetails;
#if DEBUG
        private const string RETURN_URL = "https://kladovayaltay.ru/";//"https://localhost:44338/Home/Feedback";
#else
        private const string RETURN_URL = "https://kladovayaltay.ru/";
#endif
        // private const string LOGIN;
        // private const string PASSWORD;




        public static void Test()
        {
            orderParams orderParams = new orderParams()
            {
                returnUrl = RETURN_URL,
                amount = 15000,
                merchantOrderNumber = "78ds901234567890",//(dbOrders.LastOrDefaultAsync()?.Id + 1).ToString(),
                clientId = "666",
                features = new orderFeature[] { orderFeature.AUTO_PAYMENT }
            };

            //  XmlSerializer serializer = new XmlSerializer(typeof(orderParams));
            //SoapFormatter formatter = new SoapFormatter();
            //string serializedXML;
            //using (StringWriter writer = new StringWriter())
            //{
            //    formatter.Serialize(writer);
            //    //serializer.Serialize(writer, orderParams);
            //     //serializedXML = writer.ToString();
            //}

            BinaryFormatter _formatter = new BinaryFormatter();
            // создаем объект SoapFormatter
            SoapFormatter formatter = new SoapFormatter();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                //_formatter.Serialize(memoryStream, orderParams);
                // получаем поток, куда будем записывать сериализованный объект


                formatter.Serialize(memoryStream, orderParams);

               string url = Encoding.UTF8.GetString(memoryStream.ToArray());
                Console.WriteLine("Объект сериализован");

            }
        }
    }
}
