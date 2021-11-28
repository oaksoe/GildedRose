namespace app
{
    public class ConjuredCalculator: ItemCalculator
    {
        public override int CalculateQuality(int sellIn, int quality) {
            return BoundQuality(StepQuality(sellIn, quality, -2));
        } 
    }
}
