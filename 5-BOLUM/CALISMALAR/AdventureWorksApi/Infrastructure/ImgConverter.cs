public static class ImgConverter
{
    public static string ConvertImageToBase64(byte[] imageBytes)
    {
        if (imageBytes == null || imageBytes.Length == 0)
        {
            return string.Empty;
        }

        return "data:image/png;base64," + Convert.ToBase64String(imageBytes);
    }
}