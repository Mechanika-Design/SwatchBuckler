
namespace SwatchBuckler
{
    // Swatch Buckler palette library
    // Copyright © 2014-2015 Mechanika Design.
    // http://www.mechanikadesign.com/swatchbuckler

    // Licensed under the MIT License. See swatchbuckler-license.txt for the full text.

    // If you use this code in your application, acknowledgment is kindly appreciated

  /// <summary>
  /// Determines how the selected cell in a <see cref="ColorGrid" /> control is rendered.
  /// </summary>
  public enum ColorGridSelectedCellStyle
  {
    /// <summary>
    /// The selected cell is drawn no differently to any other cell.
    /// </summary>
    None,

    /// <summary>
    /// The selected cell displays a basic outline and focus rectangle.
    /// </summary>
    Standard,

    /// <summary>
    /// The selected cell is displayed larger than other cells
    /// </summary>
    Zoomed
  }
}
