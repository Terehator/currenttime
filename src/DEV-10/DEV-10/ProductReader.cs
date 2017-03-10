using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class ProductReader
    {
        public Dictionary<Product, int> Read(StreamReader reader, JSONParser parser)
        {
            Dictionary<Product, int> result = new Dictionary<Product, int>();
            string tempLine = reader.ReadLine();
            while (!parser.IsEndOfEnum(tempLine))
            {
                while (!parser.IsObjectStart(tempLine) && !parser.IsEndOfEnum(tempLine))
                    tempLine = reader.ReadLine();
                if (!parser.IsEndOfEnum(tempLine))
                {
                    Product product = new Product();
                    int quantity = 0;
                    tempLine = reader.ReadLine();
                    while (!parser.IsObjectFinish(tempLine))
                    {
                        if (parser.IsEndOfEnum(tempLine) || reader.EndOfStream)
                            throw new FormatException("Wrong format of product");
                        else
                        {
                            if (parser.IsCurrentParametr(tempLine, "productID"))
                            {
                                product.ProductID = int.Parse(parser.GetValueByParametr(tempLine, "productID"));
                            }
                            if (parser.IsCurrentParametr(tempLine, "productName"))
                            {
                                product.ProductName = parser.GetValueByParametr(tempLine, "productName");
                            }
                            if (parser.IsCurrentParametr(tempLine, "quantity"))
                            {
                                quantity = int.Parse(parser.GetValueByParametr(tempLine, "quantity"));
                            }
                        }
                        tempLine = reader.ReadLine();
                    }
                    result.Add(product, quantity);
                }
            }
            return result;
        }
    }
}
