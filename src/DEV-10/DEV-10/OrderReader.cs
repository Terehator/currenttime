using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    /// <summary>
    /// Read orders
    /// </summary>
    class OrderReader
    {
        public List<Order> Read(string inputFilepath, JSONParser parser)
        {
            List<Order> list = new List<Order>();
            using (StreamReader reader = new StreamReader(inputFilepath))
            {
                while (!reader.EndOfStream)
                {
                    string tempLine = reader.ReadLine();
                    while (!parser.IsObjectStart(tempLine) && !reader.EndOfStream)
                        tempLine = reader.ReadLine();
                    if (!reader.EndOfStream)
                    {
                        Order order = new Order();
                        tempLine = reader.ReadLine();
                        while (!parser.IsObjectFinish(tempLine))
                        {
                            if (reader.EndOfStream)
                                throw new FormatException("Wrong format of order");
                            if (parser.IsCurrentParametr(tempLine, "orderID"))
                            {
                                order.OrderID = int.Parse(parser.GetValueByParametr(tempLine, "orderID"));
                            }
                            if (parser.IsCurrentParametr(tempLine, "shopperName"))
                            {
                                order.ShopperName = parser.GetValueByParametr(tempLine, "shopperName");
                            }
                            if (parser.IsCurrentParametr(tempLine, "shopperEmail"))
                            {
                                order.ShopperMail = parser.GetValueByParametr(tempLine, "shopperEmail");
                            }
                            if (parser.IsCurrentParametr(tempLine, "orderCompleted"))
                            {
                                order.OrderCompleted = bool.Parse(parser.GetValueByParametr(tempLine, "orderCompleted"));
                            }
                            if (parser.IsCurrentEnum(tempLine, "contents"))
                            {
                                ProductReader prReader = new ProductReader();
                                order.Contents = prReader.Read(reader, parser);
                            }
                            tempLine = reader.ReadLine();
                        }
                        list.Add(order);
                    }
                }
            }
            return list;
        }
    }
}
