namespace MapleStoryFinal0605.Models.ViewModel
{
    public class MonsterSearchViewModel
    {
        private readonly List<AreaOptions> _areaOptions = new List<AreaOptions>
        {
            new AreaOptions(){DisplayText = "維多利亞港", OptionValue = "1"},
            new AreaOptions(){DisplayText = "弓箭手村", OptionValue = "2"},
            new AreaOptions(){DisplayText = "魔法森林", OptionValue = "3"},
            new AreaOptions(){DisplayText = "勇士之村", OptionValue = "4"},
            new AreaOptions(){DisplayText = "墮落城市", OptionValue = "5"}
        };
        //搜尋條件
        public MonsterSearchParams SearchParams { get; set; }
        //搜尋結果
        public List<TblMonster> Monster { get; set; }
        //下拉選單選項
        
        public MonsterSearchViewModel()
        {
            SearchParams = new MonsterSearchParams();
            Monster = new List<TblMonster>();
            
        }
    }

    public class MonsterSearchParams
    {
        public int? MinLevel { get; set; }
        public int? MaxLevel { get; set; }
        public int? MinHp { get; set; }
        public int? MaxHp { get; set; }
        public string? Area { get; set; }
    }

    public class AreaOptions
    {
        public string OptionValue { get; set; }
        public string DisplayText { get; set; }
    }

}
