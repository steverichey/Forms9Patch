﻿
namespace Forms9Patch
{
    /// <summary>
    /// Interface for the state of a button
    /// </summary>
    public interface IButtonState : IBackground, ILabel
    {
        /// <summary>
        /// gets/sets Forms9Patch.Image used for the button's icon
        /// </summary>
        Forms9Patch.Image IconImage { get; set; }
        /// <summary>
        /// gets/sets HtmlText used to create the button's icon
        /// </summary>
        string IconText { get; set; }

        /// <summary>
        /// controls if the button's icon is before or after the button's text
        /// </summary>
        bool TrailingIcon { get; set; }
        /// <summary>
        /// controls if the button's icon is tinted to match the button's TextColor
        /// </summary>
        bool TintIcon { get; set; }

        /// <summary>
        /// controls if the button's icon will be justified to the edge of the button (false) or to be next to the button's text (true)
        /// </summary>
        bool HasTightSpacing { get; set; }
        /// <summary>
        /// controls the pixels between the button's icon and text (if HasTightSpacing is true)
        /// </summary>
        double Spacing { get; set; }

        /// <summary>
        /// controls if the button's text and icon are arranged horizontally or vertically
        /// </summary>
        Xamarin.Forms.StackOrientation Orientation { get; set; }
    }
}
