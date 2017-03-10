using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class OrderWriter
    {
        const int TAB_STEP = 2;
        private void Write(Order order, StreamWriter writer, JSONBuilder builder, bool isLast)
        {
            int tabCounter = 0;
            writer.WriteLine(builder.StartObjectToLine(tabCounter));
            tabCounter += TAB_STEP;
            writer.WriteLine(builder.PropertyToLine("orderID", order.OrderID, tabCounter, false));
            writer.WriteLine(builder.PropertyToLine("shopperName", order.ShopperName, tabCounter, false));
            writer.WriteLine(builder.PropertyToLine("shopperEmail", order.ShopperMail, tabCounter, false));
            writer.WriteLine(builder.EnumToLine("contents", tabCounter));
            tabCounter += TAB_STEP;
            ProductWriter prWriter = new ProductWriter(writer, builder, tabCounter, TAB_STEP);
            prWriter.Write(order.Contents);
            writer.WriteLine(builder.PropertyToLine("orderComplited", order.OrderCompleted, tabCounter, true));
            tabCounter -= TAB_STEP;
            writer.WriteLine(builder.FinishObjectToLine(tabCounter, isLast));
        }
        public void Write(List<Order> list, string outputFilepath, JSONBuilder builder)
        {
            using (StreamWriter writer = new StreamWriter(outputFilepath))
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    Write(list[i], writer, builder, false);
                }
                Write(list[list.Count - 1], writer, builder, true);
            }
        }
    }
}
