using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airbrake.API
{
    public class KeyValuePair
    {
        string _key = null;
        string _value = null;

        public KeyValuePair()
        {
        }

        public KeyValuePair(string key, string value)
        {
            _key = key;
            _value = value;
        }

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}