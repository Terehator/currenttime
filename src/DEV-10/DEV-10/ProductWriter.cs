using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class ProductWriter
    {
        StreamWriter writer;
        JSONBuilder builder;
        int tabCount;
        int TAB_STEP;
        public ProductWriter(StreamWriter writer, JSONBuilder builder, int tabCount, int TAB_STEP)
        {
            this.writer = writer;
            this.builder = builder;
            this.tabCount = tabCount;
            this.TAB_STEP = TAB_STEP;
        }
        private void Write(Product product, int quantity, bool isLast)
        {
            writer.WriteLine(builder.StartObjectToLine(tabCount));
            tabCount += TAB_STEP;
            writer.WriteLine(builder.PropertyToLine("productID", product.ProductID, tabCount, false));
            writer.WriteLine(builder.PropertyToLine("productName", product.ProductName, tabCount, false));
            writer.WriteLine(builder.PropertyToLine("quantity", quantity, tabCount, true));
            tabCount -= TAB_STEP;
            writer.WriteLine(builder.FinishObjectToLine(tabCount, isLast));
        }
        public void Write(Dictionary<Product, int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Write(list.ElementAt(i).Key, list.ElementAt(i).Value, false);
            }
            Write(list.ElementAt(list.Count - 1).Key, list.ElementAt(list.Count - 1).Value, true);
        }
    }
}
