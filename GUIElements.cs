using UnityEngine;
using HS2Wiki_Content;
using System.Reflection;

public static class GUIElements {

    public static void ImgTextListElement(CustomTexture img, string title, string text) {
        GUILayout.BeginHorizontal();
            img.Show();
            TextListElement(title, text);
            GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    public static void TextListElement(string title, string text) {
        GUILayout.Label($"<b><size=15>{title}</size></b>: {text}");
    }

    public static void Title(string title) {
        GUILayout.Label($"<b><size=30>{title}</size></b>");
    }

    public static void Link(string label, string category, string pageName) {
        if (GUILayout.Button(label + "↗")) {
            WikiContent.OpenWikiPage(category, pageName);
        }
    }

    public static void TitleLink(string title, string button_label, string category, string pageName) {
        GUILayout.BeginHorizontal();
            Title(title);
            Link(button_label, category, pageName);
            GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
    }

    public static void TitleText(string title, string text) {
        // HorizontalLine(Color.gray);
        GUILayout.BeginVertical(GUI.skin.box);
            Title(title);
            GUILayout.Label(text);
        GUILayout.EndVertical();
        GUILayout.Space(5);
    }

    public static void Header(string title) {
        GUILayout.Label($"<size=40>{title}</size>");
        GUILayout.Space(5);
    }

    public static void HeaderSubtitle(string title, string subtitle) {
        Header(title);
        GUILayout.Label(subtitle);
        GUILayout.Space(10);
    }


    // draw a horizontal line in GUILayout.Window
    public static void HorizontalLine ( Color color ) {
        var c = GUI.color;
        GUI.color = color;
        GUILayout.Box(GUIContent.none, new GUIStyle { 
            normal = new GUIStyleState { background = Texture2D.whiteTexture },
            margin = new RectOffset(0, 0, 4, 4),
            fixedHeight = 1
        });
        GUI.color = c;
    }

    public static void TitleImage(string title, CustomTexture image) {
            GUILayout.BeginVertical(GUI.skin.box);
                Title(title);
                image.Show();
            GUILayout.EndVertical();
    }
}