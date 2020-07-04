using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Bot.Builder;
using Microsoft.Net.Http.Headers;

namespace AWBot_Cloud.Helpers
{
    public static class LuisParser
    {
        public static string GetEntityValue(RecognizerResult result, string intent = "")
        {
            foreach (var entity in result.Entities)
            {
                var product = string.Empty;
                var productName = string.Empty;
                var email = string.Empty;
                var number = string.Empty;

                var value = entity.Value.First.ToString();

                switch(entity.Key)
                {
                    case Constants.ProductLabel:
                        product = value;
                        break;
                    case Constants.ProductNameLabel:
                        productName = value;
                        return $"{Constants.ProductNameLabel}_{productName}";
                        break;
                    case Constants.EmailLabel:
                        email = value;
                        return $"{Constants.EmailLabel}_{email}";
                        break;
                    case Constants.NumberLabel:
                        number = value;
                        return $"{Constants.NumberLabel}_{number}";
                        break;
                }

                if (number != null && intent == Constants.NumberLabel)
                {
                    dynamic val = JsonConvert.DeserializeObject<dynamic>(entity.Value.ToString());
                }

                if (!string.IsNullOrEmpty(product))
                    return $"{Constants.ProductLabel}_";

                if (!string.IsNullOrEmpty(productName))
                {
                    dynamic val = JsonConvert.DeserializeObject<dynamic>(entity.Value.ToString());
                }

                if (!string.IsNullOrEmpty(email))
                {
                    dynamic val = JsonConvert.DeserializeObject<dynamic>(entity.Value.ToString());
                }
            }

            return "_";
        }
    }
}