namespace botles
{
    internal class BeerBottles
    {
        static void Main(string[] args)
        {   
           BeerBottles beerBottles = new BeerBottles();
            beerBottles.song();
        }
        // Method to print a verse of the song based on the number of bottles
        public void printVerse(int bottles)
        {
            Console.WriteLine(bottles + " bottles of beer on the wall , " + bottles + " bottles of beer.");
            Console.WriteLine("Take one down and pass it around, ");
            Console.WriteLine();
            // Check if there are more bottles left after taking one down
            if (bottles - 1 > 0)
            {
                bottles = bottles - 1;
              

            }
            else
            {
                Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            }
        }

        // Method to sing the entire song starting from 99 bottles
        public void song()
        {
            // Loop from 99 down to 1 bottle
            for ( int bottles = 99;  bottles > 0; bottles--)
            {
                printVerse(bottles);
            }
           
        }
    }
}
