using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace StripeIntegration.Plugins.StripeModel
{
    [DataContract]
    public class PluginConfiguration
    {
        [DataMember]
        public string ApiKey { get; set; }
    }

    [DataContract]
    public class StripeResponseModel
    {
        [DataMember]
        public bool IsSuccess { get; set; }
        [DataMember]
        public string Message { get; set; }
    }

}
