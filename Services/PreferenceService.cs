using Com.Kingdee.App.Models;

namespace Com.Kingdee.App.Services;

public class PreferenceService
{
    public async Task<List<Preference>> GetPreferences()
    {
        return await GetPreferencesMock();
    }

    private async Task<List<Preference>> GetPreferencesMock()
    {
        return  new List<Preference>()
        {
            new Preference()
            {
                PreferencePrompt = "Preference 1",
                PreferenceValue = "Description 1"
            },
            new Preference()
            {
                PreferencePrompt = "Preference 2",
                PreferenceValue = "Description 2"
            },
            new Preference()
            {
                PreferencePrompt = "Preference 3",
                PreferenceValue = "Description 3"
            }
        };
    }
}