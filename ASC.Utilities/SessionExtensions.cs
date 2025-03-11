using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Extensions;  // 🔹 Ensure this is included
using Newtonsoft.Json;
using System.Text;

namespace ASC.Utilities
{
    public static class SessionExtensions
    {
        public static void SetSession<T>(this ISession session, string key, T value)
        {
            if (value == null) return; // Avoid storing null values
            string serializedValue = JsonConvert.SerializeObject(value);
            session.SetString(key, serializedValue); // 🔹 Use SetString
        }

        public static T GetSession<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
