using System.Text.Json;
using Green.Application.Interfaces.Serialization.Options;

namespace Green.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}