using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpProject.Models
{
    public class Entry
    {
        /// <summary>
        /// Tetraploid true or false.
        /// </summary>
        public enum Tetraploid
        {
           Yes,
           No
        }

        /// <summary>
        /// Reblooms true or false.
        /// </summary>
        public enum Reblooms
        {
           Yes,
           No
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Entry()
        {
        }

        /// <summary>
        /// Constructor for easily creating entries.
        /// </summary>
        /// <param name="id">The ID for the entry.</param>
        /// <param name="name">String name of the daylily.</param>
        /// <param name="primaryColor">Main color of the daylily.</param>
        /// <param name="secondaryColor">Any secondary color contained on the daylily.</param>
        /// <param name="bloomSeason">When the daylily blooms.</param>
        /// <param name="height">Height of the daylily (in inches by .25 inch).</param>
        /// <param name="bloomSize">Size of the daylily's bloom (in inches by .25 inch).</param>

        //public Entry(int id, string name, Color.primaryColor primaryColor, Color.secondaryColor secondaryColor, bloomSeason bloomSeason, height height, bloomSize bloomSize)
        //{
        //    Id = id;
        //    Name = name;
        //    PrimaryColor = (int)primaryColor;
        //    SecondaryColor = (int)secondaryColor;
        //    BloomSeason= (int)bloomSeason;
        //    Height = (int)height;
        //    BloomSize = bloomSize;

        //}

        /// <summary>
        /// The ID of the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The date of the entry. Should not include a time portion.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The activity ID for the entry. The ID value should map to an ID in the activities collection.
        /// </summary>
        //[Display(Name = "Activity")]
        //public int ActivityId { get; set; }

        /// <summary>
        /// The activity for the entry.
        /// </summary>
        //public Activity Activity { get; set; }

        /// <summary>
        /// The duration for the entry (in minutes).
        /// </summary>
        public double Duration { get; set; }

        /// <summary>
        /// The level of intensity for the entry.
        /// </summary>
        //public IntensityLevel Intensity { get; set; }

    }
}