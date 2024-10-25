using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class Clima{

    private static readonly string apiKey ="6435f170d1e32b0207d70f26598e16dd";
    public static async Task<ServerResult> ObtenerClima(string coordenadas){

        try{
            var partes = coordenadas.Split(',');
            if (partes.Length != 2) return new ServerResult(false, "Error al obtener datos del clima");

            var latitud = partes[0].Trim();
            var longitud = partes[1].Trim();

            var url = $"https://api.openweathermap.org/data/2.5/weather?lat={latitud}&lon={longitud}&appid={apiKey}&units=metric";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return new ServerResult(false, "Error al obtener datos del clima");
            }

            var json = await response.Content.ReadAsStringAsync();
            var climaData = JsonSerializer.Deserialize<WeatherResponse>(json);

            var datosClima = new
            {
                Temperatura = climaData.Main.Temp,
                Descripcion = climaData.Weather[0].Description,
                Humedad = climaData.Main.Humidity
            };

            return new ServerResult(true, "Clima obtenido correctamente", datosClima);
        
        
        }
        catch (Exception ex)
        {
            return new ServerResult(false, ex.Message);
        }



        
    }
}

public class WeatherResponse
{
    public MainData Main { get; set; }
    public List<WeatherInfo> Weather { get; set; }
}

public class MainData
{
    public double Temp { get; set; }
    public int Humidity { get; set; }
}

public class WeatherInfo
{
    public string Description { get; set; }
}