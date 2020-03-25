using CFBRisk;
using CFBRisk.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;

namespace CFBRisks
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient();
            var path = "/players?team=Nebraska";
            var response = client.GetAsync(path);
            var responseString = response.Content.ReadAsStringAsync().Result;

            List<TeamPlayer> test = JsonConvert.DeserializeObject<List<TeamPlayer>>(responseString);
            var seasonTwoPlayers = test.Where(x => x.LastTurn.Season == 2 && x.LastTurn.Day == 1).ToList();
            var y = 5;
        }
    }
}
