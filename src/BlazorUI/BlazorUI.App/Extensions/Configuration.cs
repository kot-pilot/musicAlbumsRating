namespace BlazorUI.App.Extensions
{
    public static class Configuration
    {
        /// <summary>
        /// Uri value from settings can be absolute or relative. This method helps to create Uri object with hosting environment base address if uri is relative.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Uri GetUriValue(this IConfiguration configuration, string key, string baseAddress)
        {
            var settingValue =  configuration.GetValue<string>(key);
            Uri result = Uri.IsWellFormedUriString(settingValue, UriKind.Absolute) ? 
                new Uri(settingValue) : new Uri(new Uri(baseAddress), settingValue);
            return result;

        }

    }
}
