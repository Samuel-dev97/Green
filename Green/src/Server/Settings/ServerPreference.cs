using System.Linq;
using Green.Shared.Constants.Localization;
using Green.Shared.Settings;

namespace Green.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}