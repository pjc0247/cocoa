using System;
using System.IO;
using System.Collections.Generic;
using JsonFx.Json;

namespace Cocoand.Utils
{
    partial class Config
    {
        public static Config Open(String path)
        {
            var config = new Config(path);

            return config;
        }

        public Config(String path)
        {
            var reader = new JsonReader();
            var json = File.ReadAllText(path);
            
            data = reader.Read<Dictionary<String, Object>>(json);
        }
        public Config()
        {
            data = new Dictionary<String, Object>();
        }

        public Dictionary<String, Object> data
        {
            get;
            private set;
        }

        private Binder _binder;
        public Binder binder
        {
            get
            {
                if (_binder == null)
                    _binder = new Binder(this);
                return _binder;
            }
            private set
            {
                _binder = value;
            }
        }
    }
}
