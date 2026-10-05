using Green.Shared.Settings;
using System.Threading.Tasks;
using Green.Shared.Wrapper;

namespace Green.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}