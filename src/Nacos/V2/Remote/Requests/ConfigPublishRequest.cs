namespace Nacos.V2.Remote.Requests
{
    using System.Collections.Generic;

    public class ConfigPublishRequest : CommonRequest
    {
        public ConfigPublishRequest(string dataId, string group, string tenant, string content)
        {
            this.Tenant = tenant;
            this.DataId = dataId;
            this.Group = group;
            this.Content = content;
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
        [Newtonsoft.Json.JsonProperty("content")]
        public string Content { get; private set; }


        [Newtonsoft.Json.JsonProperty("additionMap")]
        public Dictionary<string, string> AdditionMap { get; set; } = new Dictionary<string, string>();

        public void PutAdditonalParam(string key, string value)
        {
            AdditionMap[key] = value;
        }

        public override string GetRemoteType() => RemoteRequestType.Req_Config_Publish;
    }
}
