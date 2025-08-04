using HS2Wiki_Content;
using UnityEngine;

namespace docs
{
    public class StudioNeo
    {
        private const int IMAGE_COUNT = 25;
        private static Texture2D[] images;

        public static void Init() {
            images = new Texture2D[IMAGE_COUNT];
            for (int i = 0; i < IMAGE_COUNT; i++) {
                images[i] = ("StudioNeo/" + (i + 1) + ".png").LoadTexture();
            }

            WikiContent.RegisterWikiPage("StudioNeo", "Basics", Basics);
        }   

        public static void Basics() {
            GUILayout.Label("<size=30>Basic Operations</size>");
            GUILayout.Label("<size=20><b>Windows Basic Operations</b></size>");
            
            GUILayout.Label("This program uses the following basic Windows operations.\n");
            GUILayout.Label("<b>①Left click:</b> Press the left mouse button. <b>②Left button drag:</b> Hold down the left mouse button and move the mouse.\n");
            GUILayout.Label("In this manual, there is an expression \"Please select ~\".");
            GUILayout.Label("If there is any information here, move the mouse cursor to the \"~\" part and click the left mouse button.");
            GUILayout.Label("(Example: If it says \"Select the OK button\", move the mouse cursor to the OK button and click the left mouse button.)\n");
            GUILayout.Label("<b>*In some cases, you may need to perform operations such as copying, moving, or deleting files. If you are unsure about this, please contact your computer manufacturer.</b>\n");
            GUILayout.Label("<b>Japanese input:</b>If you want to enter Japanese in the input field, click the input field, hold down the \"Alt\" key on your keyboard, press the \"Half-width/Full-width\" key, and then enter the characters.");
            GUILayout.Label("<b>*Once this operation is performed, Japanese input will be required until the game is restarted or the same operation is performed again.</b>");

            GUILayout.Space(10);

            GUILayout.Label("<size=30>Camera operation</size>");
            GUILayout.Label("You can operate the camera in a place where there are no menus or buttons.");

            GUILayout.BeginHorizontal();
                if (images[0] != null)
                    GUILayout.Box(images[0], GUILayout.Width(240), GUILayout.Height(210));
                if (images[1] != null)
                    GUILayout.Box(images[1], GUILayout.Width(240), GUILayout.Height(210));
                if (images[2] != null)
                    GUILayout.Box(images[2], GUILayout.Width(240), GUILayout.Height(210));
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
                if (images[3] != null)
                    GUILayout.Box(images[3], GUILayout.Width(240), GUILayout.Height(210));
                if (images[4] != null)
                    GUILayout.Box(images[4], GUILayout.Width(240), GUILayout.Height(210));
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            GUILayout.Space(10);

            GUILayout.Label("<size=30>Move/rotate/reduce operations (move panel)</size>");
            GUILayout.Label("You can move, rotate, expand or contract the target axis or by inputting numerical values.\n" +
                "<b>*If you operate the parallel plate on the moving axis, you can operate the two axes on the parallel plate side at the same time.</b>");

            GUILayout.BeginHorizontal();
                if (images[5] != null)
                    GUILayout.Box(images[5], GUILayout.Width(240), GUILayout.Height(210));
                if (images[6] != null)
                    GUILayout.Box(images[6], GUILayout.Width(240), GUILayout.Height(210));
                if (images[7] != null)
                    GUILayout.Box(images[7], GUILayout.Width(240), GUILayout.Height(210));
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
                if (images[8] != null)
                    GUILayout.Box(images[8], GUILayout.Width(240), GUILayout.Height(210));
                if (images[9] != null)
                    GUILayout.Box(images[9], GUILayout.Width(240), GUILayout.Height(210));
                if (images[10] != null)
                    GUILayout.Box(images[10], GUILayout.Width(240), GUILayout.Height(210));
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            GUILayout.Space(10);

            GUILayout.Label("<size=30>Slider/color operation</size>");
            GUILayout.Label("You can adjust the numerical value by operating the slider with the mouse or select a color from the \"Color Panel\".\n" +
                "<b>*If there is no transparency item when selecting a color, it does not support transparency operations.</b>");

            GUILayout.BeginHorizontal();
                if (images[11] != null)
                    GUILayout.Box(images[11], GUILayout.Width(240), GUILayout.Height(210));
                if (images[12] != null)
                    GUILayout.Box(images[12], GUILayout.Width(240), GUILayout.Height(210));
                if (images[13] != null)
                    GUILayout.Box(images[13], GUILayout.Width(240), GUILayout.Height(210));
                if (images[14] != null)
                    GUILayout.Box(images[14], GUILayout.Width(240), GUILayout.Height(210));
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(10);

            GUILayout.Label("<size=30>Options panel</size>");

            GUILayout.BeginHorizontal();
                if (images[15] != null)
                    GUILayout.Box(images[15], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("You can move objects indirectly using panels instead of operating axes.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[16] != null)
                    GUILayout.Box(images[16], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("<b>map</b> If it is loaded, you can perform map operations.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[17] != null)
                    GUILayout.Box(images[17], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Toggles the display of the viewpoint of interest (camera reference point).");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[18] != null)
                    GUILayout.Box(images[18], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Toggles the display of operation axes used for movement and IK/FK.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[19] != null)
                    GUILayout.Box(images[19], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Toggles the camera lock function ON/OFF.\n" +
                    "<b>*If turned on, camera operations will no longer be accepted unless you hold down the \"Alt\" key on your keyboard while performing camera operations.</b>");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[20] != null)
                    GUILayout.Box(images[20], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Toggles the display of the \"parallel plate\" used for movement operations.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[21] != null)
                    GUILayout.Box(images[21], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Toggles the display of the \"center point\" displayed on characters and items.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[22] != null)
                    GUILayout.Box(images[22], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.Label("Undo: Undoes the previous operation.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[23] != null)
                    GUILayout.Box(images[23], GUILayout.Width(35), GUILayout.Height(35));
                GUILayout.BeginVertical();
                    GUILayout.Label("Redo: redo operations undone with \"undo\".\n" +
                        "<b>*Loading the scene, loading characters, loading items, and delete character items\n" + 
                        "Doing so will delete the operation history and prevent undoing.</b>");
                GUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();

            GUILayout.Space(10);

            GUILayout.Label("<size=30>Checkbox</size>");
            GUILayout.BeginHorizontal();
                if (images[24] != null)
                    GUILayout.Box(images[24], GUILayout.Width(250), GUILayout.Height(70));
                GUILayout.Label("If you select the checkbox, you can switch ON/OFF.");
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
    
    }

}
