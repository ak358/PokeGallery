//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using PokeGallery.Models;
//using System.Linq;
//using static System.Net.Mime.MediaTypeNames;

////コントローラーの作成: Controllersフォルダ内に、PokemonControllerを作成します。
////このコントローラーは、ポケモンデータを取得してビューに渡します。
////HttpGetメソッド内でAPIにGETリクエストを送信し、応答を解析してPokemonオブジェクトを構築します。
////その後、Viewメソッドを使用してビューにデータを渡します。

//namespace PokeGallery.Controllers
//{
//    public class PokemonController : Controller
//    {
//        private readonly IHttpClientFactory _httpClientFactory;
//        private List<PokemonNameAndUrl> _pokemonNameAndUrls = new List<PokemonNameAndUrl>();


//        public PokemonController(IHttpClientFactory httpClientFactory)
//        {
//            _httpClientFactory = httpClientFactory;
//        }

//        public async Task<IActionResult> Index()
//        {

//            //最初のリクエストを送信して、最初のページのポケモンデータと次のページのURLを取得します。
//            //次のページのURLがある場合は、そのURLに新しいリクエストを送信して次のページのポケモンデータと次のページのURLを取得します。
//            //このプロセスを繰り返し、全てのページのポケモンデータを収集します。

//            //ポケモンのリストを取得
//            string apiUrl = $"https://pokeapi.co/api/v2/pokemon/";
//            PokemonList pokemonList = new();
//            int cnt = 0;

//            do
//            {
//                pokemonList = await GetPokemonListFromAPI(apiUrl);
//                apiUrl = pokemonList.Next;
//                cnt++;

//                if(cnt == 2)
//                {
//                    break;
//                }
//            }
//            while (pokemonList.Next != null);


//            //int id = 1;
//            //// Pokemon APIのURL
//            ////GET https://pokeapi.co/api/v2/pokemon/{id or name}/

//            //apiUrl = $"https://pokeapi.co/api/v2/pokemon/{id}/";

//            //responseData = await GetDataFromAPI(apiUrl);

//            //// JSONデータをPokemonオブジェクトにデシリアライズ
//            //Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(responseData);

//            //// ビューにPokemonオブジェクトを渡して表示
//            return View(_pokemonNameAndUrls);
//        }

//        private async Task<string> GetDataFromAPI(string apiUrl)
//        {
//            HttpClient client = _httpClientFactory.CreateClient();
//            HttpResponseMessage response;

//            // APIからデータを取得
//            response = await client.GetAsync(apiUrl);

//            // 取得したデータを文字列として読み取る
//            return await response.Content.ReadAsStringAsync();
//        }

//        private async Task<PokemonList> GetPokemonListFromAPI(string apiUrl)
//        {

//            string responseData = await GetDataFromAPI(apiUrl);
//            PokemonList pokemonList = JsonConvert.DeserializeObject<PokemonList>(responseData);

//            foreach (var result in pokemonList.results)
//            {
//                _pokemonNameAndUrls.Add(new PokemonNameAndUrl
//                {
//                    Name = result.Name,
//                    URL = result.URL
//                });
//            }

//            return pokemonList;
//        }


//    }
//}
