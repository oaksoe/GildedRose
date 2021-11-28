namespace app
{
    public class BackstagePassesCalculator: ItemCalculator
    {
        public override int CalculateQuality(int sellIn, int quality) {
            if (sellIn <= 0) {
                return 0;
            }

            if (sellIn <= 5) {
                return BoundQuality(quality + 3);
            }

            if (sellIn <= 10) {
                return BoundQuality(quality + 2);
            }

            return BoundQuality(quality + 1);
        } 
    }
}
