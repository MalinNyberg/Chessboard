namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Välkommen till Schackbrädet!");
            Console.WriteLine("Uppge ett nummer för att bestämma storleken på brädet:");
            int size = int.Parse(Console.ReadLine()); // this first part asks the user to decide the size of the chessboard



            for (int row = 0; row < size; row++) // Loop for rows
            {
                for (int col = 0; col < size; col++) //loop for coloumns
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("◼︎");
                    }
                    else
                    {
                        Console.Write("◻︎");
                    }
                    //This for-loop checks if the statement is "true or false" to make sure it will end up every other black and every other white square



                }

                Console.WriteLine();
            }




        }
    }
}
      