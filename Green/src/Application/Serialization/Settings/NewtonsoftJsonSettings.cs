
using Green.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace Green.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}