using ScopeARJobApplication.ConsoleShape;
using System;

namespace ScopeARJobApplication
{
    /// <summary>
    /// Main class, takes user input and calls parameters on Console Shape Factory. 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function, initilizes input loop. 
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Welcome to the amazing drawing program.");
            RunMainLoop();
        }

        private static void RunMainLoop()
        {
            var shapeType = 1;
            while (shapeType != 0)
            {
                shapeType = GetShapeType();
                if (shapeType == 0)
                {
                    break;
                }
                var shapeSize = GetShapeSize();
                PrintShape(shapeType, shapeSize);
            }
        }

        private static int GetShapeType()
        {
            AskShapeInputMessage();
            var type = -1;
            while (type < 0)
            {
                type = ValidateShapeInput(Console.ReadLine());
            }
            return type;
        }

        private static void AskShapeInputMessage()
        {
            Console.WriteLine("Enter 1 to see the outstanding ascii christmas tree.");
            Console.WriteLine("Enter 2 to see the salacious x pattern");
            Console.WriteLine("Enter 0 if you're too amazed to continue");
        }
        private static int ValidateShapeInput(string shapeInput)
        {
            var isNumeric = int.TryParse(shapeInput, out int shapeType);
            if (!isNumeric || shapeType > 2 || shapeType < 0)
            {
                InvalidInput();
                return -1;
            }
            return shapeType;
        }

        private static void PrintShape(int shapeType, int shapeSize)
        {
            var consoleFactory = new ConsoleShapeFactory();
            var shape = consoleFactory.GetConsoleShape((ConsoleShapeEnum)shapeType, shapeSize).GetShape();
            Console.WriteLine(shape);
            Console.WriteLine();
        }

        private static void InvalidInput()
        {
            Console.WriteLine("Please enter valid input");
        }

        private static int GetShapeSize()
        {
            Console.WriteLine("Enter pattern size:");

            var size = -1;
            while (size < 0 || size >20000)
            {
                size = ValidateshapeSize(Console.ReadLine());
            }
            return size;
        }

        private static int ValidateshapeSize(string sizeInput)
        {
            var isNumeric = int.TryParse(sizeInput, out int size);
            if (!isNumeric || size < 0 || size > 20000)
            {
                if (size > 20000)
                {
                    Console.WriteLine("Pattern size too big for memory");
                }
                InvalidInput();
                return -1;
            }
            return size;
        }

    }
}
