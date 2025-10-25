namespace Units_Converter
{
    internal class Program
    {
        private static int _userChoice;
        private static int _unitsChoice;
        private static double _unit;

        static void Main(string[] args)
        {
            Start();

        }
        public static void Start()
        {

            Console.WriteLine("========Units Converter========");
            OperationChoice();
            Console.Clear();
            UnitsChoice();
            Console.Clear();
            Units();
            Converter();
        }
        public static void OperationChoice()
        {
            int[] choices = { 1, 2, 3 };
            Console.WriteLine("Choice ur operation");
            Console.WriteLine("1. Temperature");
            Console.WriteLine("2. Length");
            Console.WriteLine("3. Weight");

            string userInput = Console.ReadLine();
            bool isValidChoice = int.TryParse(userInput, out _userChoice);
            while (!isValidChoice || !choices.Contains(_userChoice))
            {
                Console.WriteLine("Invalid number!!! try again!!!");
                userInput = Console.ReadLine();
                isValidChoice = int.TryParse(userInput, out _userChoice);
            }
        }
        public static void UnitsChoice()
        {
            int[] choices = { 1, 2 };
            string[] messages =
            {
                "1.°C => °F | 2.°F => °C",
                "1.Meters => Kilometers | 2.Kilometers => Meters",
                "1.Gram => Kg | 2.Kg => Gram"
            };

            Console.WriteLine("Choice unit that you will be operating:");
            Console.WriteLine(messages[_userChoice - 1]);

            string userInput = Console.ReadLine();
            bool isValidNum = int.TryParse(userInput, out _unitsChoice);
            while (!isValidNum || !choices.Contains(_unitsChoice))
            {
                Console.WriteLine("Invalid Number! Try Again");
                userInput = Console.ReadLine();
                isValidNum = int.TryParse(userInput, out _unitsChoice);
            }
        }

        public static void Units()
        {
            Console.Write("Enter Unit:");
            string firstNum = Console.ReadLine();
            bool isValidFirstNum = double.TryParse(firstNum, out _unit);
            while (!isValidFirstNum)
            {
                Console.WriteLine("Invalid Number! Try Again!");
                firstNum = Console.ReadLine();
                isValidFirstNum = double.TryParse(firstNum, out _unit);
            }
            Console.Clear();

        }

        public static void Converter()
        {
            switch (_userChoice)
            {
                case 1:
                    if (_unitsChoice == 1)
                    {
                        double result = (_unit * (9 / 5)) + 32;

                        Console.WriteLine($"{_unit}°C => {result}°F");
                    }
                    else
                    {
                        double result = (_unit - 32) * 5 / 9;

                        Console.WriteLine($"{_unit}°F => {result}°C");
                    }
                    break;

                case 2:
                    if (_unitsChoice == 1)
                    {
                        double result = _unit / 1000;

                        Console.WriteLine($"{_unit}m => {result}km");
                    }
                    else
                    {
                        double result = _unit * 1000;

                        Console.WriteLine($"{_unit}km => {result}m");
                    }
                    break;

                case 3:
                    if (_unitsChoice == 1)
                    {
                        double result = _unit / 1000;

                        Console.WriteLine($"{_unit}gram => {result}kg");
                    }
                    else
                    {
                        double result = _unit * 1000;

                        Console.WriteLine($"{_unit}kg => {result}gram");
                    }
                    break;
            }

        }


    }
}
