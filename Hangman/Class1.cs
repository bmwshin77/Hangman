using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    public class Rectangle
    {
        public float height;
        public float width;

        public float giveArea()
        {
            return height * width;
        }
    }
}
