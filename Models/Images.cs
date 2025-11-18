public class Images
{
    public ImageFormat Jpg { get; set; } = new ImageFormat();
    public ImageFormat Webp { get; set; } = new ImageFormat();
}

public class ImageFormat
{
    public string Image_Url { get; set; } = string.Empty;       // immagine normale
    public string Small_Image_Url { get; set; } = string.Empty; // miniatura
    public string Large_Image_Url { get; set; } = string.Empty; // grande
}
