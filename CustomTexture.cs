using System.IO;
using BepInEx;
using UnityEngine;

public class CustomTexture
{
    public readonly Texture2D texture;
    public readonly string path;
    public readonly int width;
    public readonly int height;

    public CustomTexture(string path)
    {
        string imagePath = Path.Combine(Paths.PluginPath, "HS2Wiki", path);
        texture = null;
        width = 0;
        height = 0;
        if (File.Exists(imagePath))
        {
            byte[] data = File.ReadAllBytes(imagePath);
            texture = new Texture2D(2, 2);
            texture.LoadImage(data);
            width = texture.width;
            height = texture.height;
        }
        this.path = imagePath;
    }
}