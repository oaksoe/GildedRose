namespace app
{
    public class ItemCalculatorFactory
    {
        public static ItemCalculator InstantiateItemCalculator(string itemName)
        {
            if (itemName.Contains("Aged Brie")) {
                return new AgedBrieCalculator();
            }

            if (itemName.Contains("Sulfuras")) {
                return new SulfurasCalculator();
            }

            if (itemName.Contains("Backstage passes")) {
                return new BackstagePassesCalculator();
            }

            if (itemName.Contains("Conjured")) {
                return new ConjuredCalculator();
            }

            return new ItemCalculator();
        }  
    }
}