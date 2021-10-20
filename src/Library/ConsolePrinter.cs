using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipe result)
        {
            Console.WriteLine(result.GetTextToPrint());
        }
    }
}