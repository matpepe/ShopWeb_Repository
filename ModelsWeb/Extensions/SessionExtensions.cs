using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ModelWeb.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJson
            (this ISession session, string key, object value)
        {
            // Primjer postavljanje serijaliziranog objekt u sesiju
            var serializedString = JsonConvert.SerializeObject(value);
            session.SetString(key, serializedString);
        }

        public static T GetObjectAsJson<T>(this ISession session, string key)
        {
            // Izvlačenje postavljanje serijaliziranog objekt u sesiju
            var value = session.GetString(key);

            if (value == null) return default(T);

            return JsonConvert.DeserializeObject<T>(value);

        }

    }
}
