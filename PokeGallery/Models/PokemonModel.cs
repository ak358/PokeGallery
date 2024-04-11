namespace PokeGallery.Models
{
    // ポケモンデータを表すクラス
    public class Pokemon
    {
        // ポケモンの属性
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }  // ポケモンの特性
        public List<NamedAPIResource> Forms { get; set; }  // ポケモンのフォーム
        public List<VersionGameIndex> GameIndices { get; set; }  // ポケモンが登場したゲームのインデックス
        public List<PokemonHeldItem> HeldItems { get; set; }  // ポケモンが持っているアイテム
        public string LocationAreaEncounters { get; set; }  // ポケモンの出現場所
        public List<PokemonMove> Moves { get; set; }  // ポケモンが覚える技
        public NamedAPIResource Species { get; set; }  // ポケモンの種類
        public PokemonSprites Sprites { get; set; }  // ポケモンのスプライト画像
        public PokemonCries Cries { get; set; }  // ポケモンの鳴き声
        public List<PokemonStat> Stats { get; set; }  // ポケモンのステータス
        public List<PokemonType> Types { get; set; }  // ポケモンのタイプ
        public List<PokemonTypePast> PastTypes { get; set; }  // 過去の世代でのポケモンのタイプ
    }

    // ポケモンの特性を表すクラス
    public class PokemonAbility
    {
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedAPIResource Ability { get; set; }
    }

    // 名前とURLを持つリソースを表すクラス
    public class NamedAPIResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    // バージョンとそのインデックスを持つクラス
    public class VersionGameIndex
    {
        public int GameIndex { get; set; }
        public NamedAPIResource Version { get; set; }
    }

    // ポケモンが持っているアイテムとそのバージョンの詳細を持つクラス
    public class PokemonHeldItem
    {
        public NamedAPIResource Item { get; set; }
        public List<VersionDetails> VersionDetails { get; set; }
    }

    // アイテムのレアリティとバージョンの詳細を持つクラス
    public class VersionDetails
    {
        public int Rarity { get; set; }
        public NamedAPIResource Version { get; set; }
    }

    // 技とそのバージョンの詳細を持つクラス
    public class PokemonMove
    {
        public NamedAPIResource Move { get; set; }
        public List<VersionGroupDetails> VersionGroupDetails { get; set; }
    }

    // レベルや覚える方法などの技の詳細を持つクラス
    public class VersionGroupDetails
    {
        public int LevelLearnedAt { get; set; }
        public NamedAPIResource VersionGroup { get; set; }
        public NamedAPIResource MoveLearnMethod { get; set; }
    }

    // ポケモンのスプライト画像を表すクラス
    public class PokemonSprites
    {
        public string BackDefault { get; set; }
        public string BackFemale { get; set; }
        public string BackShiny { get; set; }
        public string BackShinyFemale { get; set; }
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShiny { get; set; }
        public string FrontShinyFemale { get; set; }
        public OtherSprites Other { get; set; }
        public VersionSprites Versions { get; set; }
    }

    // 他のスプライト画像の詳細を持つクラス
    public class OtherSprites
    {
        public DreamWorldSprites DreamWorld { get; set; }
        public HomeSprites Home { get; set; }
        public OfficialArtworkSprites OfficialArtwork { get; set; }
        public ShowdownSprites Showdown { get; set; }
    }

    // 夢の世界のスプライト画像の詳細を持つクラス
    public class DreamWorldSprites
    {
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
    }

    // 自宅のスプライト画像の詳細を持つクラス
    public class HomeSprites
    {
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShiny { get; set; }
        public string FrontShinyFemale { get; set; }
    }

    // 公式アートワークのスプライト画像の詳細を持つクラス
    public class OfficialArtworkSprites
    {
        public string FrontDefault { get; set; }
        public string FrontShiny { get; set; }
    }

    // 対戦画像のスプライト画像の詳細を持つクラス
    public class ShowdownSprites
    {
        public string BackDefault { get; set; }
        public string BackFemale { get; set; }
        public string BackShiny { get; set; }
        public string BackShinyFemale { get; set; }
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShiny { get; set; }
        public string FrontShinyFemale { get; set; }
    }

    // バージョンごとのスプライト画像の詳細を持つクラス
    public class VersionSprites
    {
        public GenerationISprites GenerationI { get; set; }
        public GenerationIISprites GenerationII { get; set; }
        //public GenerationIIISprites GenerationIII { get; set; }
        //public GenerationIVSprites GenerationIV { get; set; }
        //public GenerationVSprites GenerationV { get; set; }
        //public GenerationVISprites GenerationVI { get; set; }
        //public GenerationVIISprites GenerationVII { get; set; }
        //public GenerationVIIISprites GenerationVIII { get; set; }
    }

    // 各世代ごとのスプライト画像の詳細を持つクラス（以下同様）
    // 各世代ごとのスプライト画像の詳細を持つクラス
    public class GenerationISprites
    {
        // Generation Iのスプライト画像詳細を表すプロパティ
        public string BackDefault { get; set; } // デフォルト背面画像
        public string BackGray { get; set; }    // グレー背面画像
        public string FrontDefault { get; set; }// デフォルト正面画像
        public string FrontGray { get; set; }   // グレー正面画像
    }
    // その他の世代のスプライト画像の詳細を持つクラス（以下同様）
    public class GenerationIISprites
    {
        // Generation IIのスプライト画像詳細を表すプロパティ
        public string BackDefault { get; set; } // デフォルト背面画像
        public string BackShiny { get; set; }   // シャイニー背面画像
        public string FrontDefault { get; set; }// デフォルト正面画像
        public string FrontShiny { get; set; }  // シャイニー正面画像
    }

    // ポケモンの鳴き声を表すクラス
    public class PokemonCries
    {
        public string Latest { get; set; }
        public string Legacy { get; set; }
    }

    // ポケモンのステータスを表すクラス
    public class PokemonStat
    {
        public int BaseStat { get; set; }
        public int Effort { get; set; }
        public NamedAPIResource Stat { get; set; }
    }

    // ポケモンのタイプを表すクラス
    public class PokemonType
    {
        public int Slot { get; set; }
        public NamedAPIResource Type { get; set; }
    }

    // 過去の世代でのポケモンのタイプを表すクラス
    public class PokemonTypePast
    {
        public NamedAPIResource Generation { get; set; }
        public List<PokemonType> Types { get; set; }
    }
}
