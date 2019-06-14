//-----------------------------------------------------------------------
// <copyright file="Config.cs">
//     Copyright (c) 2019 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Configuration;

namespace Faker
{
    /// <summary>
    /// Static config class
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Gets a value from the config
        /// </summary>
        /// <param name="key">Key to look for</param>
        /// <returns>A <see cref="string"/></returns>
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key] == null || ConfigurationManager.AppSettings[key].Equals(string.Empty) ? string.Empty : ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Gets a value from the config
        /// </summary>
        /// <param name="key">Key to look for</param>
        /// <param name="defaultValue">Default value if it isn't present in the config</param>
        /// <returns>A <see cref="string"/></returns>
        public static string GetValue(string key, string defaultValue)
        {
            return ConfigurationManager.AppSettings[key] == null || ConfigurationManager.AppSettings[key].Equals(string.Empty) ? defaultValue : ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Does the key exist
        /// </summary>
        /// <param name="key">Key to look for</param>
        /// <returns>A <see cref="bool"/></returns>
        public static bool DoesKeyExist(string key)
        {
            return !(ConfigurationManager.AppSettings[key] == null);
        }

        /// <summary>
        /// Checks to see if a value exists on a key
        /// </summary>
        /// <param name="key">A key value</param>
        /// <returns>A <see cref="bool"/></returns>
        public static bool DoesValueExist(string key)
        {
            return ConfigurationManager.AppSettings[key] == null || ConfigurationManager.AppSettings[key].Equals(string.Empty) ? false : true;
        }
    }
}
