﻿
namespace Forms9Patch
{
    /// <summary>
    /// Interface for Forms9Patch.Segment elements
    /// </summary>
    public interface ISegment 
    {
        /// <summary>
        /// Image for segment's icon (alternative to IconText)
        /// </summary>
        Forms9Patch.Image IconImage { get; set; }

        /// <summary>
        /// HtmlText for segment's icon (alternative to IconImage)
        /// </summary>
        string IconText { get; set; }

        /// <summary>
        /// Segment's text
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Segment's text with Html markup
        /// </summary>
        string HtmlText { get; set; }

        /// <summary>
        /// TextColor
        /// </summary>
        Xamarin.Forms.Color TextColor { get; set; }

        /// <summary>
        /// Segment's label's font attributes
        /// </summary>
        Xamarin.Forms.FontAttributes FontAttributes { get; set; }

        /// <summary>
        /// Is segment enabled?
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Is segment selected
        /// </summary>
        bool IsSelected { get; set; }

        /// <summary>
        /// Orientation of Segemnt's icon to its text
        /// </summary>
        Xamarin.Forms.StackOrientation Orientation { get; set; }

        /// <summary>
        /// Command to be invoked upon segment being clicked
        /// </summary>
        System.Windows.Input.ICommand Command { get; set; }

        /// <summary>
        /// Parameter passed with command that is invoked when segment is clicked
        /// </summary>
        object CommandParameter { get; set; }

        /// <summary>
        /// Gets the VisualElement used for the Segment
        /// </summary>
        Xamarin.Forms.VisualElement VisualElement { get; }



    }

}
