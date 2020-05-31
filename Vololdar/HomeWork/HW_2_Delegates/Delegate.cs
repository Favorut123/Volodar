using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Delegates
{
    public delegate void AddStringToList(string text);
    class InputHandler
    {
        public StringCollector stringcollector;

        public AlphaNumbericCollector alphaNumbericCollector;

        public InputHandler()
        {
            stringcollector = new StringCollector();
            alphaNumbericCollector = new AlphaNumbericCollector();
        }
        public void HandleText(string text)
        {
            AddStringToList addStringToList;

            if (HasDigits(text))
            {
                addStringToList = alphaNumbericCollector.numbericCollector.Add;
                //alphaNumbericCollector.numbericCollector.Add(text);
            }
            else
            {
                addStringToList = stringcollector.listOfStrings.Add;
                //stringcollector.listOfStrings.Add(text);
            }
            addStringToList(text);
        }
        public bool HasDigits(string inputString)
        {
            return inputString.Any(symbol => char.IsDigit(symbol));
        }
    }
}