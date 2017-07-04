using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharpProject.Models
{
    public class Entry
    {

        /// <summary>
        /// Bloom season.
        /// </summary>
        public enum BloomSeasonValue
        {
           Early,
           Mid,
           Late
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
        /// <param name="colorName">Color of bloom (include primary and secondary on rebuild and refactoring.</param>
        /// <param name="bloomSeason">When the daylily blooms.</param>
        /// <param name="tetraploid">Tetraploid yes or no.</param>
        /// <param name="height">Height of the daylily (in inches by .25 inch).</param>
        /// <param name="bloomSize">Size of the daylily's bloom (in inches by .25 inch).</param>
        /// <param name="reblooms">Does the daylily rebloom, yes or no?</param>

        public Entry(int id, string name, Color.ColorName colorName, BloomSeasonValue bloomSeason, bool tetraploid, double height, double bloomSize, bool reblooms)
        {
            Id = id;
            Name = name;
            ColorId = (int)colorName;
            BloomSeason = bloomSeason;
            Tetraploid = tetraploid;
            Height = (int)height;
            BloomSize = bloomSize;
            Reblooms = reblooms;

        }

        /// <summary>
        /// The ID of the daylily.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the daylily.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The color ID for the daylily. The ID value should map to an ID in the color collection.
        /// </summary>
        [Display(Name = "Color")]
        public int ColorId { get; set; }

        /// <summary>
        /// The color for the daylily.
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// The bloom season for the daylily.
        /// </summary>
        public BloomSeasonValue BloomSeason { get; set; }

        /// <summary>
        /// Tetraploid true or false.
        /// </summary>
        public bool Tetraploid { get; set; }

        /// <summary>
        /// The height of the daylily.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The bloom size the daylily.
        /// </summary>
        public double BloomSize { get; set; }

        /// <summary>
        /// Does the daylily rebloom, true or false.
        /// </summary>
        public bool Reblooms { get; set; }


    }
}