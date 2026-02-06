using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AppConfigs
{
    public class WhisperSettings
    {
        public string BaseUrl { get; set; } = "http://127.0.0.1:8001";
        public string ApiVersion { get; set; } = "v1";
        public int TimeoutMinutes { get; set; } = 5;
    }
}
