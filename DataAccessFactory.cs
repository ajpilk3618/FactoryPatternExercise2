using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                    return new ListDataAccess();

                case "mysql":
                case "sql":
                    return new SQLDataAccess();

                case "mongo":
                case "mongodb":
                    return new MongaDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}
