// IntLit -- Parse tree node class for representing integer literals

using System;

namespace Tree
{
    public class IntLit : Node
    {
        private int intVal;

        public IntLit(int i)
        {
            intVal = i;
        }

        public override void print(int n)
        {
	    // There got to be a more efficient way to print n spaces.
	    for (int i = Console.CursorLeft; i < n; i++)
                Console.Write(" ");

            Console.Write(intVal);
        }

        public override bool isNumber()
        {
            return true;
        }
    }
}
