using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSharpProject.Models;

namespace CSharpProject.Data
{
    public class Data
    {
    
        /// <summary>
        /// The collection of entries.
        /// </summary>
        public static List<Entry> Entries { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of activities first
            // so we can reference them when creating the entries collection.

            var entries = new List<Entry>()
            {
                new Entry(1, "Big Top", Entry.ColorValue.Red, Entry.BloomSeasonValue.Mid, Entry.TetraploidValue.Yes, 28.0, 8.0, Entry.RebloomsValue.No),
                new Entry(2, "Byzantine Emperor", Entry.ColorValue.Red, Entry.BloomSeasonValue.Early, Entry.TetraploidValue.Yes, 30.0, 6.0, Entry.RebloomsValue.Yes),
                new Entry(3, "Double Daffy", Entry.ColorValue.Yellow, Entry.BloomSeasonValue.Mid, Entry.TetraploidValue.No, 28.0, 4.0, Entry.RebloomsValue.No),
                new Entry(4, "Little Business", Entry.ColorValue.Red, Entry.BloomSeasonValue.Early, Entry.TetraploidValue.Yes, 15.0, 3.0, Entry.RebloomsValue.Yes),
                new Entry(5, "Mauna Loa", Entry.ColorValue.Orange, Entry.BloomSeasonValue.Mid, Entry.TetraploidValue.No, 22.0, 5.0, Entry.RebloomsValue.No),
                new Entry(6, "Plum Candy", Entry.ColorValue.Purple, Entry.BloomSeasonValue.Mid, Entry.TetraploidValue.No, 24.0, 4.0, Entry.RebloomsValue.No)
            };

            Entries = entries;
        }



    }
}