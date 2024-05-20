using henry;
using RestSharp;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");


string search = "2";
Console.WriteLine("Enter a number");

search = Console.ReadLine();

Console.Clear();

RestRequest request = new($"planets/{search}/");

RestResponse response = client.GetAsync(request).Result;

File.WriteAllText("pokemon.json", response.Content);

Planet planet = JsonSerializer.Deserialize<Planet>(response.Content);

Console.WriteLine("Name: " + planet.name);
Console.WriteLine("Population: " + planet.population);
Console.WriteLine("Terrain: " + planet.terrain);
Console.WriteLine("Rotation Period: " + planet.rotation_period);
Console.WriteLine("Orbital Period: " + planet.orbital_period);

Console.ReadLine();