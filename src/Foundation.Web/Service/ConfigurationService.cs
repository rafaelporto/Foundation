namespace Foundation.Web.Service;

public class ConfigurationService
{
    private readonly IConfiguration configuration;

    public ConfigurationService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Task<IEnumerable<KeyValuePair<string, string>>> GetConfigurationsAsync()
    {
        return Task.FromResult(configuration.AsEnumerable());
    }
}
