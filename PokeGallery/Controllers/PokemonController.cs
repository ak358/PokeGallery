using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokeGallery.Models;

//コントローラーの作成: Controllersフォルダ内に、PokemonControllerを作成します。
//このコントローラーは、ポケモンデータを取得してビューに渡します。
//HttpGetメソッド内でAPIにGETリクエストを送信し、応答を解析してPokemonオブジェクトを構築します。
//その後、Viewメソッドを使用してビューにデータを渡します。

namespace PokeGallery.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PokemonController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            int id = 1;
            // Pokemon APIのURL
            //GET https://pokeapi.co/api/v2/pokemon/{id or name}/

            string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{id}/";

            // HttpClientのインスタンスを取得
            var client = _httpClientFactory.CreateClient();

            // APIからデータを取得
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // 取得したデータを文字列として読み取る
            string responseData = await response.Content.ReadAsStringAsync();

            // JSONデータをPokemonオブジェクトにデシリアライズ
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responseData);

            // ビューにPokemonオブジェクトを渡して表示
            return View(pokemon);
        }
    }
}
