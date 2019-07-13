using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoInterface
{
    class Arduino
    {
        private string _connectionPort;
        private string _baudRate;
        private char _seperator;
        private List<string> seperatedData = new List<string>();

        public Arduino(string portname, string baudrate, char seperator)
        {
            _connectionPort = portname;
            _baudRate = baudrate;
            _seperator = seperator;
        }

        public string ConnectionPort { get => _connectionPort; set => _connectionPort = value; }
        public string BaudRate { get => _baudRate; set => _baudRate = value; }
        public char Seperator { get => _seperator; set => _seperator = value; }



        public List<string> SplitData(string data)
        {
            seperatedData.Clear();

            string[] str = data.Split(_seperator);

            foreach (string st in str)
            {
                seperatedData.Add(st);
            }

            return seperatedData;
        }
    }
}
