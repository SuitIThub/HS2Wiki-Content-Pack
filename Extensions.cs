using System.IO;
using BepInEx;
using UnityEngine;

namespace HS2Wiki_Content
{
    public static class Extensions
    {
        public static void Show(this CustomTexture[] images, int index) {
            if (images.Length > index)
                Show(images[index]);
        }

        public static void Show(this CustomTexture image) {
            if (image != null && image.texture != null)
            {
                if (GUILayout.Button(image.texture, GUI.skin.box, GUILayout.Width(image.width), GUILayout.Height(image.height)))
                    WikiContent.OpenImagePage(image.path);
            }
        }
    }
}