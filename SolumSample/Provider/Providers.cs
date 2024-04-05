using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static SolumSample.Provider.Solus;

namespace SolumSample.Provider
{
    public interface IProvider
    {
        string URL { get; set; }
        string URL2 { get; set; }
        string Login { get; set; }
        string Password { get; set; }

        Task<(string accessToken, string refreshToken)> GetToken();
        Task<string> SendNewItem(Article articleData, string company, string store, string URL);
        Task<string> SendAllItems(string jsonArticles, string company, string store, string URL);
    }

    public class Solus : IProvider
    {
        public string URL { get; set; }
        public string URL2 { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        private HttpClient _httpClient = new HttpClient();

        public Solus(string url, string url2, string login, string password)
        {
            URL = url;
            URL2 = url2;
            Login = login;
            Password = password;
        }

        public async Task<string> SendAllItems(string jsonArticles, string company, string store, string URL)
        {
            var token = await GetToken();
            if (token.accessToken != null && token.refreshToken != null)
            {
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.accessToken}");

                var content = new StringContent(jsonArticles, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _httpClient.PutAsync(URL2 + $"?company={company}&store={store}", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody;
                }
                else
                {
                    string msgError = $"Failed to submit article. Status code: {response.StatusCode}";
                    return msgError;
                }

            }
            catch (HttpRequestException ex)
            {
                string msgError = $"HTTP request error: {ex.Message}";
                return msgError;
            }
        }
            else
            {
                string msgError = $"Failed to obtain token.";
                return msgError;
            }

        }

            public async Task<string> SendNewItem(Article articleData, string company, string store, string URL)
            {
            var token = await GetToken();


            if (token.accessToken != null && token.refreshToken != null)
            {
                Console.WriteLine($"Access Token: {token.accessToken}");
                Console.WriteLine($"Update Token: {token.refreshToken}");

                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token.accessToken}");

                var requestData = new
                {

                    articleId = articleData.SKU,
                    ITEM_ID = articleData.ITEM_ID,
                    articleName = articleData.ITEM_NAME,
                    nfcUrl = "http://www.solum.com/p/B100001",
                    data = new
                    {
                        SKU = articleData.SKU,
                        ITEM_ID = articleData.ITEM_ID,
                        ITEM_NAME = articleData.ITEM_NAME,
                        ITEM_DESCRIPTION = articleData.ITEM_DESCRIPTION,
                        BARCODE = articleData.BARCODE,
                        SALE_PRICE = articleData.SALE_PRICE,
                        WEIGHT = articleData.WEIGHT,
                        AISLE_LOCATION = articleData.AISLE_LOCATION,
                        COUNTRY_OF_ORIGIN = articleData.COUNTRY_OF_ORIGIN,
                        LIST_PRICE = articleData.LIST_PRICE,
                        CLEARANCE_PRICE = articleData.CLEARANCE_PRICE,
                        UNIT_PRICE = articleData.UNIT_PRICE,
                        UNIT_PRICE_UNIT = articleData.UNIT_PRICE_UNIT,
                        PACK_QUANTITY = articleData.PACK_QUANTITY,
                        WEIGHT_UNIT = articleData.WEIGHT_UNIT,
                        DEPARTMENT = articleData.DEPARTMENT,
                        MANUFACTURER = articleData.MANUFACTURER,
                        ITEM_DIMENSIONS = articleData.ITEM_DIMENSIONS,
                        BRAND = articleData.BRAND,
                        MODEL = articleData.MODEL,
                        COLOR = articleData.COLOR,
                        INVENTORY = articleData.INVENTORY,
                        START_DATE = articleData.START_DATE,
                        END_DATE = articleData.END_DATE,
                        LANGUAGE = articleData.LANGUAGE,
                        CATEGORY_01 = articleData.CATEGORY_01,
                        CATEGORY_02 = articleData.CATEGORY_02,
                        CATEGORY_03 = articleData.CATEGORY_03,
                        MISC_01 = articleData.MISC_01,
                        MISC_02 = articleData.MISC_02,
                        MISC_03 = articleData.MISC_03,
                        DISPLAY_PAGE_1 = articleData.DISPLAY_PAGE_1,
                        DISPLAY_PAGE_2 = articleData.DISPLAY_PAGE_2,
                        DISPLAY_PAGE_3 = articleData.DISPLAY_PAGE_3,
                        DISPLAY_PAGE_4 = articleData.DISPLAY_PAGE_4,
                        DISPLAY_PAGE_5 = articleData.DISPLAY_PAGE_5,
                        DISPLAY_PAGE_6 = articleData.DISPLAY_PAGE_6,
                        DISPLAY_PAGE_7 = articleData.DISPLAY_PAGE_7,
                        NFC_DATA = articleData.NFC_DATA,
                    }

                };


                string jsonRequestData = "[" + JsonConvert.SerializeObject(requestData, Formatting.Indented) + "]";

                var content = new StringContent(jsonRequestData, Encoding.UTF8, "application/json");


                try
                {
                    HttpResponseMessage response = await _httpClient.PostAsync(URL2 + $"?company={company}&store={store}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        return responseBody;
                    }
                    else
                    {
                        string msgError = $"Failed to submit article. status code: {response.StatusCode}";
                        return msgError;
                    }

                }
                catch (HttpRequestException ex)
                {
                    string msgError = $"HTTP request error: {ex.Message}";
                    return msgError;
                }
            }
            else
            {
                string msgError = $"Failed to obtain token.";
                return msgError;
            }
        }

        public async Task<(string accessToken, string refreshToken)> GetToken()
        {
            var requestData = new
            {
                username = Login,
                password = Password,
            };

            var content = new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(URL, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var authResponse = JsonConvert.DeserializeObject<AuthResponse>(responseBody);

                    if (authResponse?.responseMessage != null)
                    {
                        return (authResponse.responseMessage.access_token, authResponse.responseMessage.refresh_token);
                    }
                }
                else
                {
                    return ("ERROR",response.StatusCode.ToString());
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"HTTP request error: {ex.Message}");
            }

            return (null, null);
        }
        
        public class Article
        {
            public string SKU { get; set; }
            public string ITEM_NAME { get; set; }
            public string ITEM_ID { get; set; }
            public string ITEM_DESCRIPTION { get; set; }
            public string BARCODE { get; set; }
            public string SALE_PRICE { get; set; }
            public string WEIGHT { get; set; }
            public string AISLE_LOCATION { get; set; }
            public string COUNTRY_OF_ORIGIN { get; set; }
            public string LIST_PRICE { get; set; }
            public string CLEARANCE_PRICE { get; set; }
            public string UNIT_PRICE { get; set; }
            public string UNIT_PRICE_UNIT { get; set; }
            public string PACK_QUANTITY { get; set; }
            public string WEIGHT_UNIT { get; set; }
            public string DEPARTMENT { get; set; }
            public string MANUFACTURER { get; set; }
            public string ITEM_DIMENSIONS { get; set; }
            public string BRAND { get; set; }
            public string MODEL { get; set; }
            public string COLOR { get; set; }
            public string INVENTORY { get; set; }
            public string START_DATE { get; set; }
            public string END_DATE { get; set; }
            public string LANGUAGE { get; set; }
            public string CATEGORY_01 { get; set; }
            public string CATEGORY_02 { get; set; }
            public string CATEGORY_03 { get; set; }
            public string MISC_01 { get; set; }
            public string MISC_02 { get; set; }
            public string MISC_03 { get; set; }
            public string DISPLAY_PAGE_1 { get; set; }
            public string DISPLAY_PAGE_2 { get; set; }
            public string DISPLAY_PAGE_3 { get; set; }
            public string DISPLAY_PAGE_4 { get; set; }
            public string DISPLAY_PAGE_5 { get; set; }
            public string DISPLAY_PAGE_6 { get; set; }
            public string DISPLAY_PAGE_7 { get; set; }
            public string NFC_DATA { get; set; }

        }

        private class AuthResponse
        {
            public ResponseMessage responseMessage { get; set; }
        }

        private class ResponseMessage
        {
            public string access_token { get; set; }
            public string refresh_token { get; set; }
        }
    }
}
