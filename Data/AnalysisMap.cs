using CsvHelper.Configuration;

namespace EM
{
    public class AnalysisMap : ClassMap<Analysis>
    {
        public AnalysisMap()
        {
            Map(x => x.Numbers).Index(0);
            Map(x => x.Stars).Index(1);
            Map(x => x.HitsZeroPercentage).Index(2);
            Map(x => x.HitsOnePercentage).Index(3);
            Map(x => x.HitsTwoPercentage).Index(4);
            Map(x => x.HitsThreePercentage).Index(5);
            Map(x => x.HitsFourPercentage).Index(6);
            Map(x => x.HitsFivePercentage).Index(7);
            Map(x => x.StarsZeroPercentage).Index(8);
            Map(x => x.StarsOnePercentage).Index(9);
            Map(x => x.StarsTwoPercentage).Index(10);
        }
    }
}