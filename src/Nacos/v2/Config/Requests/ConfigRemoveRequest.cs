﻿namespace Nacos.Config.Requests
{
    public class ConfigRemoveRequest
    {
        public ConfigRemoveRequest(string dataId, string group, string tenant, string tag)
        {
            this.Tenant = tenant;
            this.DataId = dataId;
            this.Group = group;
            this.Tag = tag;
        }

        /// <summary>
        /// The tenant, corresponding to the namespace field of Nacos
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tenant")]
        public string Tenant { get; private set; }

        /// <summary>
        /// Configuration ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dataId")]
        public string DataId { get; private set; }

        /// <summary>
        /// Configuration group
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group")]
        public string Group { get; private set; }

        /// <summary>
        /// Configuration content
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        public string Tag { get; private set; }
    }
}