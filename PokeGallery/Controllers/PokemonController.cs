using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokeGallery.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokeGallery.Controllers
{
    public class PokemonController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PokemonController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int pokemonId)
        {
            // Pokemon APIのURLを構築
            string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemonId}/";

            // HttpClientのインスタンスを取得
            var client = _httpClientFactory.CreateClient();

            // APIからデータを取得
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            // APIからの応答を確認
            if (response.IsSuccessStatusCode)
            {
                // 取得したデータを文字列として読み取る
                string responseData = await response.Content.ReadAsStringAsync();

                // JSONデータからPokemonオブジェクトにデシリアライズ
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responseData);

                // ビューにPokemonの名前を渡して表示
                return View(pokemon);
            }
            else
            {
                // Pokemonが見つからない場合はPokemonNotFoundページにリダイレクト
                return RedirectToAction("PokemonNotFound");
            }
        }

        public IActionResult PokemonNotFound()
        {
            return View();
        }
    }
}
