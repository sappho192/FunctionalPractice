using System;
using System.Globalization;

namespace Processor
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                //var values = Enum.GetNames(typeof(Command)).Select(
                //    (value, key) =>
                //    new { value, key }).ToDictionary(vk => vk.value, vk => vk.key);
                //Console.WriteLine($"[Command, index]");
                //Console.WriteLine($"{string.Join(", ", values)}");
                Console.WriteLine($"Commands: {string.Join(", ", Enum.GetNames(typeof(Command)))}");

                Console.Write("Command: ");
                var input = Console.ReadLine();
                if(!Enum.IsDefined(typeof(Command), input))
                {
                    break;
                }

                var command = (Command)Enum.Parse(typeof(Command), input);
                Console.Write("x: ");
                var x = int.Parse(Console.ReadLine(),
                    NumberStyles.Integer, CultureInfo.CurrentCulture);

                Console.Write("y: ");
                var y = int.Parse(Console.ReadLine(),
                    NumberStyles.Integer, CultureInfo.CurrentCulture);

                var result = CommandProcessor.Process(command, x, y);
                if (result != null)
                {
                    Console.WriteLine($"Result: {result}");
                } else
                {
                    break;
                }
            }
        }
    }
}
