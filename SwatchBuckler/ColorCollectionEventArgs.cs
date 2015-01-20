using System;
using System.Drawing;

namespace SwatchBuckler
{
    // Swatch Buckler palette library
    // Copyright © 2014-2015 Mechanika Design.
    // http://www.mechanikadesign.com/swatchbuckler

    // Licensed under the MIT License. See swatchbuckler-license.txt for the full text.

    // If you use this code in your application, acknowledgment is kindly appreciated

    /// <summary>Provides data for the <see cref="ColorCollection.CollectionChanged"/> event of a <see cref="ColorCollection"/> instance.</summary>
    public class ColorCollectionEventArgs : EventArgs
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorCollectionEventArgs"/> class for the specified color.
        /// </summary>
        /// <param name="index">The color index that the event is responding to.</param>
        /// <param name="color">The %Color% that the event is responding to.</param>
        public ColorCollectionEventArgs(int index, Color color)
        {
            this.Index = index;
            this.Color = color;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorCollectionEventArgs"/> class.
        /// </summary>
        protected ColorCollectionEventArgs()
        { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the color that raised the event.
        /// </summary>
        /// <value>The color that raised the event.</value>
        public Color Color { get; protected set; }

        /// <summary>
        /// Gets the color index that raised the event.
        /// </summary>
        /// <value>The color index that raised the event.</value>
        public int Index { get; protected set; }

        #endregion
    }
}