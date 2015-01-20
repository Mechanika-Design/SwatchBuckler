using System;
using System.Drawing;

namespace SwatchBuckler
{
    // Swatch Buckler palette library
    // Copyright © 2014-2015 Mechanika Design.
    // http://www.mechanikadesign.com/swatchbuckler

    // Licensed under the MIT License. See swatchbuckler-license.txt for the full text.

    // If you use this code in your application, acknowledgment is kindly appreciated

  /// <summary>
  /// Provides functionality required by color editors that are bindable
  /// </summary>
  public interface IColorEditor
  {
    #region Events

    /// <summary>
    /// Occurs when the <see cref="Color"/> property is changed.
    /// </summary>
    event EventHandler ColorChanged;

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the component color.
    /// </summary>
    /// <value>The component color.</value>
    Color Color { get; set; }

    #endregion
  }
}
