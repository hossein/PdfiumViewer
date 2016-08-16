namespace PdfiumViewer
{
    /// <summary>
    /// Page zoom modes.
    /// </summary>
    public enum PdfViewerZoomMode
    {
        /// <summary>Fits the page height to the height of the control.</summary>
        FitHeight,

        /// <summary>Fits the page width to the width of the control.</summary>
        FitWidth,

        /// <summary>Fits the entire page in the control. This is also known as 'Whole Page' zoom.</summary>
        FitBest,

        /// <summary>Maintains a fixed size for the page that doesn't change when the control is resized.</summary>
        FixedSize,
    }
}
