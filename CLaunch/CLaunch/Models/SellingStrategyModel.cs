namespace CLaunch.Models
{
    public class SellingStrategyModel
    {
        public string Name { get; set; }
        public List<SellingDateModel> SellingDates { get; set; }
        public List<SellingMultiplikatorModel> SellingMultiplikators { get; set; }
    }

    public abstract class SellingModel
    {
        public int VolumeInPercent { get; set; }
    }


    public class SellingMultiplikatorModel : SellingModel
    {
        public int SellingPointMultiplikator { get; set; }
    }

    public class SellingDateModel : SellingModel
    {
        public DateTime SellingDate { get; set; }
    }
}
