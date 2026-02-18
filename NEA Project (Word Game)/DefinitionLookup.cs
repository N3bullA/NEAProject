using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA_Project__Word_Game_
{
    public class DefinitionLookup
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<string> GetDefinitionAsync(string word, int index)
        {
            using var response = await client.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");

            if (response.IsSuccessStatusCode == false)
            {
                return "error";
            }
            else
            {
                response.EnsureSuccessStatusCode();
            }

            string json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement[0];
            string definition;

            if (root.GetProperty("meanings")[0].GetProperty("definitions").GetArrayLength() <= index)
            {
                return "error";
            }
            else
            {
                definition = root.GetProperty("meanings")[0].GetProperty("definitions")[index].GetProperty("definition").GetString();
            }

            return definition;
        }
    }
}
