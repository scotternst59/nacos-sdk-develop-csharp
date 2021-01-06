﻿namespace Nacos.V2.Config.FilterImpl
{
    public class ConfigContext : IConfigContext
    {
        private System.Collections.Generic.Dictionary<string, object> param = new System.Collections.Generic.Dictionary<string, object>();

        public object GetParameter(string key)
        {
            return param[key];
        }

        public void SetParameter(string key, object value)
        {
            param[key] = value;
        }
    }
}
