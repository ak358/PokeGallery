namespace PokeGallery.Models
{
    // �|�P�����f�[�^��\���N���X
    public class Pokemon
    {
        // �|�P�����̑���
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }  // �|�P�����̓���
        public List<NamedAPIResource> Forms { get; set; }  // �|�P�����̃t�H�[��
        public List<VersionGameIndex> GameIndices { get; set; }  // �|�P�������o�ꂵ���Q�[���̃C���f�b�N�X
        public List<PokemonHeldItem> HeldItems { get; set; }  // �|�P�����������Ă���A�C�e��
        public string LocationAreaEncounters { get; set; }  // �|�P�����̏o���ꏊ
        public List<PokemonMove> Moves { get; set; }  // �|�P�������o����Z
        public NamedAPIResource Species { get; set; }  // �|�P�����̎��
        public PokemonSprites Sprites { get; set; }  // �|�P�����̃X�v���C�g�摜
        public PokemonCries Cries { get; set; }  // �|�P�����̖���
        public List<PokemonStat> Stats { get; set; }  // �|�P�����̃X�e�[�^�X
        public List<PokemonType> Types { get; set; }  // �|�P�����̃^�C�v
        public List<PokemonTypePast> PastTypes { get; set; }  // �ߋ��̐���ł̃|�P�����̃^�C�v
    }

    // �|�P�����̓�����\���N���X
    public class PokemonAbility
    {
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
        public NamedAPIResource Ability { get; set; }
    }

    // ���O��URL�������\�[�X��\���N���X
    public class NamedAPIResource
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    // �o�[�W�����Ƃ��̃C���f�b�N�X�����N���X
    public class VersionGameIndex
    {
        public int GameIndex { get; set; }
        public NamedAPIResource Version { get; set; }
    }

    // �|�P�����������Ă���A�C�e���Ƃ��̃o�[�W�����̏ڍׂ����N���X
    public class PokemonHeldItem
    {
        public NamedAPIResource Item { get; set; }
        public List<VersionDetails> VersionDetails { get; set; }
    }

    // �A�C�e���̃��A���e�B�ƃo�[�W�����̏ڍׂ����N���X
    public class VersionDetails
    {
        public int Rarity { get; set; }
        public NamedAPIResource Version { get; set; }
    }

    // �Z�Ƃ��̃o�[�W�����̏ڍׂ����N���X
    public class PokemonMove
    {
        public NamedAPIResource Move { get; set; }
        public List<VersionGroupDetails> VersionGroupDetails { get; set; }
    }

    // ���x����o������@�Ȃǂ̋Z�̏ڍׂ����N���X
    public class VersionGroupDetails
    {
        public int LevelLearnedAt { get; set; }
        public NamedAPIResource VersionGroup { get; set; }
        public NamedAPIResource MoveLearnMethod { get; set; }
    }

    // �|�P�����̃X�v���C�g�摜��\���N���X
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

    // ���̃X�v���C�g�摜�̏ڍׂ����N���X
    public class OtherSprites
    {
        public DreamWorldSprites DreamWorld { get; set; }
        public HomeSprites Home { get; set; }
        public OfficialArtworkSprites OfficialArtwork { get; set; }
        public ShowdownSprites Showdown { get; set; }
    }

    // ���̐��E�̃X�v���C�g�摜�̏ڍׂ����N���X
    public class DreamWorldSprites
    {
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
    }

    // ����̃X�v���C�g�摜�̏ڍׂ����N���X
    public class HomeSprites
    {
        public string FrontDefault { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShiny { get; set; }
        public string FrontShinyFemale { get; set; }
    }

    // �����A�[�g���[�N�̃X�v���C�g�摜�̏ڍׂ����N���X
    public class OfficialArtworkSprites
    {
        public string FrontDefault { get; set; }
        public string FrontShiny { get; set; }
    }

    // �ΐ�摜�̃X�v���C�g�摜�̏ڍׂ����N���X
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

    // �o�[�W�������Ƃ̃X�v���C�g�摜�̏ڍׂ����N���X
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

    // �e���ゲ�Ƃ̃X�v���C�g�摜�̏ڍׂ����N���X�i�ȉ����l�j
    // �e���ゲ�Ƃ̃X�v���C�g�摜�̏ڍׂ����N���X
    public class GenerationISprites
    {
        // Generation I�̃X�v���C�g�摜�ڍׂ�\���v���p�e�B
        public string BackDefault { get; set; } // �f�t�H���g�w�ʉ摜
        public string BackGray { get; set; }    // �O���[�w�ʉ摜
        public string FrontDefault { get; set; }// �f�t�H���g���ʉ摜
        public string FrontGray { get; set; }   // �O���[���ʉ摜
    }
    // ���̑��̐���̃X�v���C�g�摜�̏ڍׂ����N���X�i�ȉ����l�j
    public class GenerationIISprites
    {
        // Generation II�̃X�v���C�g�摜�ڍׂ�\���v���p�e�B
        public string BackDefault { get; set; } // �f�t�H���g�w�ʉ摜
        public string BackShiny { get; set; }   // �V���C�j�[�w�ʉ摜
        public string FrontDefault { get; set; }// �f�t�H���g���ʉ摜
        public string FrontShiny { get; set; }  // �V���C�j�[���ʉ摜
    }

    // �|�P�����̖�����\���N���X
    public class PokemonCries
    {
        public string Latest { get; set; }
        public string Legacy { get; set; }
    }

    // �|�P�����̃X�e�[�^�X��\���N���X
    public class PokemonStat
    {
        public int BaseStat { get; set; }
        public int Effort { get; set; }
        public NamedAPIResource Stat { get; set; }
    }

    // �|�P�����̃^�C�v��\���N���X
    public class PokemonType
    {
        public int Slot { get; set; }
        public NamedAPIResource Type { get; set; }
    }

    // �ߋ��̐���ł̃|�P�����̃^�C�v��\���N���X
    public class PokemonTypePast
    {
        public NamedAPIResource Generation { get; set; }
        public List<PokemonType> Types { get; set; }
    }
}
