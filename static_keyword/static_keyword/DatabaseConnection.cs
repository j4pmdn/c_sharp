using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal class DatabaseConnection
    {
        private static DatabaseConnection? instance = null;
        private  static object _lock = new();
        
        public static DatabaseConnection GetInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                    instance.Connect();
                }
            }
          
            return instance;
        }

        private void Connect()
        {
            throw new NotImplementedException();
        }
    }
