﻿using Musoq.Schema.DataSources;
using Newtonsoft.Json.Linq;

namespace Musoq.Schema.Json
{
    public class DynamicResolver : IObjectResolver
    {
        private JObject _obj;
        private readonly DynamicJsonWrapper _wrapper;

        public DynamicResolver(JObject obj)
        {
            _obj = obj;
            _wrapper = new DynamicJsonWrapper(obj);
        }

        public object Context => _wrapper;

        public object this[string name] => _wrapper;

        public object this[int index] => null;

        public bool HasColumn(string name)
        {
            return false;
        }
    }
}