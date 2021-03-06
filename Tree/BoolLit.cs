// BoolLit -- Parse tree node class for representing boolean literals

using System;

namespace Tree
{
    public class BoolLit : Node
    {
        private bool boolVal;

        private static BoolLit trueLit;
        private static BoolLit falseLit;
  
        private BoolLit(bool b)
        {
            boolVal = b;
        }

        public static BoolLit getTrue()
        {
            if(trueLit == null)
                trueLit = new BoolLit(true);
            return trueLit;
        }

        public static BoolLit getFalse()
        {
            if (falseLit == null)
                falseLit = new BoolLit(false);
            return falseLit;
        }
  
        public override void print(int n)
        {
	    // There got to be a more efficient way to print n spaces.
	    for (int i = Console.CursorLeft; i < n; i++)
                Console.Write(" ");

            if (boolVal)
                Console.Write("#t");
            else
                Console.Write("#f");
        }

        public override bool isBool()
        {
            return true;
        }
    }
}
