namespace botles
{
    internal class BeerBottles
    {
        static void Main(string[] args)
        {   
           BeerBottles beerBottles = new BeerBottles();
            beerBottles.song();
        }
        // Method to print a verse of the song 
        public void printVerse(int bottles)
        {
           
            // Check if there are more bottles left after taking one down
           
            if (bottles == 1)
            {
                Console.WriteLine();
                Console.WriteLine(bottles + " bottle of beer on the wall , " + bottles + " bottle of beer.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(bottles + " bottles of beer on the wall , " + bottles + " bottles of beer.");
                Console.WriteLine("Take one down and pass it around, ");
                bottles = bottles - 1;


            }
        }

        // Method to sing  
        public void song()
        {
          
            for ( int bottles = 99;  bottles > 0; bottles--)
            {
                printVerse(bottles);
            }
           
        }
    }
}
