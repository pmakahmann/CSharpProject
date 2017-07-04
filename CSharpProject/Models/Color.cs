using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpProject.Models
{

    /// <summary>
    /// Represents color options
    /// </summary>
    public class Color
    {

        public enum ColorName
        {
            Yellow = 1,
            Red = 2,
            Orange = 3,
            Purple = 4,
            Green = 5,
            Brown = 6,
            White = 7,
            Offwhite = 8
        }

        /// <summary>
        /// Constructs a color for the provided color type and name.
        /// </summary>
        /// <param name="activityType">The activity type for the activity.</param>
        /// <param name="name">The name for the activity.</param>
        public Color(ColorName colorName, string name = null)
        {
            Id = (int)colorName;

            // If we don't have a name argument, 
            // then use the string representation of the activity type for the name.
            Name = name ?? colorName.ToString();
        }

        /// <summary>
        /// The ID of the color.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the color.
        /// </summary>
        public string Name { get; set; }
    }
}