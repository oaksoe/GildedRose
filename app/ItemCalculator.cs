namespace app
{
    public class ItemCalculator: ICalculateQuality, ICalculateSellIn
    {
        protected const int LOWERBOUND_QUALITY = 0;
        protected const int UPPERBOUND_QUALITY = 50;

        public virtual int CalculateQuality(int sellIn, int quality) {
            return BoundQuality(StepQuality(sellIn, quality, -1));
        } 

        public virtual int CalculateSellIn(int sellIn) {
            return sellIn - 1;
        }

        protected int StepQuality(int sellIn, int quality, int step) {
            if (sellIn <= 0) {
                return quality + (step * 2);
            } 
            
            return quality + step;
        }

        protected int BoundQuality(int quality) {
            if (quality < LOWERBOUND_QUALITY) {
                return LOWERBOUND_QUALITY;
            }

            if (quality > UPPERBOUND_QUALITY) {
                return UPPERBOUND_QUALITY;
            }

            return quality;
        }
    }
}
