using System.Collections.Generic;
using Newtonsoft.Json;

namespace PokeGallery.Models
{
    //�|�P�����ꗗ
    public class PokemonList
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public List<PokemonNameAndUrl> Results { get; set; }
    }

    // �|�P�����̖��O��URL
    public class PokemonNameAndUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    // �|�P�����f�[�^��\���N���X
    public class Pokemon
    {
        // �|�P�����̑���
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_experience")]
        public int BaseExperience { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("abilities")]
        public List<PokemonAbility> Abilities { get; set; }

        [JsonProperty("forms")]
        public List<NamedAPIResource> Forms { get; set; }

        [JsonProperty("game_indices")]
        public List<VersionGameIndex> GameIndices { get; set; }

        [JsonProperty("held_items")]
        public List<PokemonHeldItem> HeldItems { get; set; }

        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }

        [JsonProperty("moves")]
        public List<PokemonMove> Moves { get; set; }

        [JsonProperty("species")]
        public NamedAPIResource Species { get; set; }

        [JsonProperty("sprites")]
        public PokemonSprites Sprites { get; set; }

        [JsonProperty("cries")]
        public PokemonCries Cries { get; set; }

        [JsonProperty("stats")]
        public List<PokemonStat> Stats { get; set; }

        [JsonProperty("types")]
        public List<PokemonType> Types { get; set; }

        [JsonProperty("past_types")]
        public List<PokemonTypePast> PastTypes { get; set; }
    }

    // �|�P�����̓�����\���N���X
    public class PokemonAbility
    {
        [JsonProperty("is_hidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("ability")]
        public NamedAPIResource Ability { get; set; }
    }

    // ���O��URL�������\�[�X��\���N���X
    public class NamedAPIResource
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    // �o�[�W�����Ƃ��̃C���f�b�N�X�����N���X
    public class VersionGameIndex
    {
        [JsonProperty("game_index")]
        public int GameIndex { get; set; }

        [JsonProperty("version")]
        public NamedAPIResource Version { get; set; }
    }

    // �|�P�����������Ă���A�C�e���Ƃ��̃o�[�W�����̏ڍׂ����N���X
    public class PokemonHeldItem
    {
        [JsonProperty("item")]
        public NamedAPIResource Item { get; set; }

        [JsonProperty("version_details")]
        public List<VersionDetails> VersionDetails { get; set; }
    }

    // �A�C�e���̃��A���e�B�ƃo�[�W�����̏ڍׂ����N���X
    public class VersionDetails
    {
        [JsonProperty("rarity")]
        public int Rarity { get; set; }

        [JsonProperty("version")]
        public NamedAPIResource Version { get; set; }
    }

    // �Z�Ƃ��̃o�[�W�����̏ڍׂ����N���X
    public class PokemonMove
    {
        [JsonProperty("move")]
        public NamedAPIResource Move { get; set; }

        [JsonProperty("version_group_details")]
        public List<VersionGroupDetail> VersionGroupDetails { get; set; }
    }

    // �o�[�W�����O���[�v�Ƃ��̏ڍׂ����N���X
    public class VersionGroupDetail
    {
        [JsonProperty("level_learned_at")]
        public int LevelLearnedAt { get; set; }

        [JsonProperty("move_learn_method")]
        public NamedAPIResource MoveLearnMethod { get; set; }

        [JsonProperty("version_group")]
        public NamedAPIResource VersionGroup { get; set; }
    }

    // �|�P�����̃X�v���C�g�摜�����N���X
    public class PokemonSprites
    {
        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }

        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }
    }

    // �|�P�����̖��������N���X
    public class PokemonCries
    {
        [JsonProperty("cry")]
        public string Cry { get; set; }
    }

    // �|�P�����̃X�e�[�^�X�����N���X
    public class PokemonStat
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }

        [JsonProperty("effort")]
        public int Effort { get; set; }

        [JsonProperty("stat")]
        public NamedAPIResource Stat { get; set; }
    }

    // �|�P�����̃^�C�v�����N���X
    public class PokemonType
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public NamedAPIResource Type { get; set; }
    }

    // �ߋ��̃|�P�����̃^�C�v�����N���X
    public class PokemonTypePast
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("type")]
        public NamedAPIResource Type { get; set; }
    }
}
