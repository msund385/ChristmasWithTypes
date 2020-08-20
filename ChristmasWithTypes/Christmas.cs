using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } // Done TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
       public enum Day { Sunday, Monday, Tuesday, Wedesday, Thursday, Friday, Saturday };

    }
}
