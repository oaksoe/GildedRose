namespace app
{
    public class AgedBrieCalculator: ItemCalculator
    {
        public override int CalculateQuality(int sellIn, int quality) {
            return BoundQuality(StepQuality(sellIn, quality, 1));
        } 
    }
}
