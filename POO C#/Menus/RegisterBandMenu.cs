using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using POO_C_.Models;

namespace POO_C_.Menus;

internal class RegisterBandMenu : Menu
{
    public override void Exe(Dictionary<string, Band> bandsList)
    {
        base.Exe(bandsList);
        DisplayOptionTitle("Register a band");
        Console.Write("Enter band name: ");
        string bandName = Console.ReadLine()!;
        Band band = new Band(bandName);
        bandsList.Add(bandName, band);

        var apiKey = "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";
        var url = "https://openrouter.ai/api/v1/chat/completions";

        HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        var requestBody = new
        {
            model = "openrouter/auto",
            messages = new[]
            {
        new {
            role = "user", content = $"Resuma a banda {bandName} em um pequeno parágrafo."
        }
    },
            max_tokens = 500
        };

        var json = JsonConvert.SerializeObject(requestBody);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).GetAwaiter().GetResult();
        var responseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        var jsonResponse = JObject.Parse(responseString);
        var answerDeepSeek = jsonResponse["choices"]?[0]["message"]?["content"]?.ToString();
        band.Resume = answerDeepSeek;


        Console.WriteLine($"The band {bandName} has been successfully registered!");
        Console.Write("\nPress a key to return to the menu\n");
        Console.ReadKey();
        Console.Clear();
    }
}
