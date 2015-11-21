using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataProviderFactory
    {
        public static IDataProvider getTestDataProvider()
        {
            return new TestDataProvider();
        }

        // TODO
        /*public IDataProvider getDBDataProvider()
        {
            return new DBDataProvider();
        }*/
    }
}
