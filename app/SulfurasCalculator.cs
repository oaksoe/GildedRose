namespace app
{
    public class SulfurasCalculator: ItemCalculator
    {
        protected const int SULFURUS_QUALITY = 80;

        public override int CalculateQuality(int sellIn, int quality) {
            return SULFURUS_QUALITY;
        } 

        public override int CalculateSellIn(int sellIn) {
            return sellIn;
        }
    }
}
