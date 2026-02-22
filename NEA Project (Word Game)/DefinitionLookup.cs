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
        public async Task<string> GetDefinitionAsync(string query)
        {
            using var response = await client.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{query}");
            try
            {
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(json);
                var root = doc.RootElement[0];
                string definition = string.Empty;

                for (int i = 0; i < root.GetProperty("meanings").GetArrayLength(); i++)
                    // Ensuring more areas of the definition list get covered
                {
                    definition += $"{root.GetProperty("meanings")[i].GetProperty("partOfSpeech").GetString()}\n";

                    for (int j = 0; j < root.GetProperty("meanings")[i].GetProperty("definitions").GetArrayLength(); j++)
                    {
                        definition += $"- {root.GetProperty("meanings")[i].GetProperty("definitions")[j].GetProperty("definition").GetString()}\n";
                        // Append definition

                        try
                        {
                            definition += $"     • {root.GetProperty("meanings")[i].GetProperty("definitions")[j].GetProperty("example").GetString()}\n";
                            // Append example
                        }
                        catch { } // Do nothing if no example is found
                    }
                    definition += "\n";
                }
                if (definition.Length == 0) // Return error if no definitions are found for that word
                {
                    return "No definitions found!";
                }
                else
                {
                    return definition; // Return concatenised definition
                }
            }
            catch // Return error message if connection fails for whatever reason
            {
                return "No definitions found!";
            }
        }
    }
}
