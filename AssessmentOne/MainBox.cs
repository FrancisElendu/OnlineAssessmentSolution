using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentOne
{
    public class MainBox
    {
        private readonly MainBox containedBox;

        public MainBox()
        {
        }

        public MainBox(MainBox containedBox)
        {
            this.containedBox = containedBox;
        }

        public int NumberOfSmallerBoxes
        {
            get
            {
                //int count = 0;
                //MainBox current = containedBox;

                //while (current != null)
                //{
                //    count++;
                //    current = current.containedBox;
                //}

                //return count;

                // If there is no contained box, count is 0
                if (containedBox == null)
                    return 0;

                // Count the contained box + its contained boxes
                return 1 + containedBox.NumberOfSmallerBoxes;
            }
        }
    }
}
