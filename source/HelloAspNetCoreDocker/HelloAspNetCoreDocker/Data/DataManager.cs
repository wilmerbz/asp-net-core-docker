using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloAspNetCore.Data
{
    public class DataManager
    {

        private static Lazy<DataManager> _instance = new Lazy<DataManager>(() => new DataManager());

        /// <summary>
        /// Singleton instance of the data manager.
        /// </summary>
        public static DataManager Instance => _instance.Value;

        private ConnectionMultiplexer _connection;
        private IDatabase _database;

        private const string ConnectionString = "myredis:6379";

        /// <summary>
        /// Initializes the data manager instance.
        /// </summary>
        private DataManager()
        {
            _connection = ConnectionMultiplexer.Connect(ConnectionString);
            _database = _connection.GetDatabase();
        }


        public bool SetValue(string key, string value)
        {
            var set = _database.StringSet(key, value);
            return set;
        }

        public string GetValue(string key)
        {
            var value = _database.StringGet(key);
            return value;
        }

    }
}
