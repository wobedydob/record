using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Record.Classes;

public class RecordConfig
{

    private string Api { get; set; }

    public RecordConfig(IConfigurationRoot config)
    {
        this.Api = config.GetSection("Api").Value;
    }

}