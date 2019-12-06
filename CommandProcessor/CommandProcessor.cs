using System;
using System.Collections.Generic;
using System.Text;
using Processor.Functions;

namespace Processor
{
    /// <summary>
    /// Calls each command function without branch approach like switch/if-else.
    /// Instead, this design uses key-value container 
    ///   which has command enum as key and command function as value.
    /// To show my idea in easy way, I've unified each function's return/parameter format.
    /// </summary>
    public static class CommandProcessor
    {
        private static readonly Function2<int, int> add = (x, y) => { return x + y; };
        private static readonly Function2<int, int> sub = (x, y) => { return x - y; };
        private static readonly Function2<int, int> mul = (x, y) => { return x * y; };
        private static readonly Function2<int, int> div = (x, y) => { return x / y; };

        private static readonly Dictionary<Command, Function2<int, int>> commandDict = 
            new Dictionary<Command, Function2<int, int>> { 
                {Command.Add, add }, 
                {Command.Sub, sub }, 
                {Command.Mul, mul }, 
                {Command.Div, div } 
            };

        public static int? Process(Command command, int x, int y)
        {
            if (commandDict.ContainsKey(command))
            {
                var result = commandDict[command](x, y);
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
