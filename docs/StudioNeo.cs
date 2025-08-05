using HS2Wiki_Content;
using UnityEngine;

namespace docs
{
    public class StudioNeo
    {
        private const int IMAGE_COUNT = 41;
        private static Texture2D[] images;

        public static void Init() {
            images = new Texture2D[IMAGE_COUNT];
            for (int i = 0; i < IMAGE_COUNT; i++) {
                images[i] = ("StudioNeo/" + (i + 1) + ".png").LoadTexture();
            }

            WikiContent.RegisterWikiPage("StudioNeo", "Basics", Basics);
            WikiContent.RegisterWikiPage("StudioNeo", "Game Screen", GameScreen);
            WikiContent.RegisterWikiPage("StudioNeo", "Menu", Menu);
            WikiContent.RegisterWikiPage("StudioNeo/Menu", "Add", MenuAdd);
            WikiContent.RegisterWikiPage("StudioNeo/Menu", "Anim", MenuAnim);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim", "States", MenuAnimStates);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim", "Animation", MenuAnimAnimation);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim", "Kinematic", MenuAnimKinematic);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Kinematic", "FK", MenuAnimKinematicFK);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Kinematic", "IK", MenuAnimKinematicIK);
        }   

        public static void Basics() {
            GUILayout.Label("<size=30>Basic Operations</size>");
            GUILayout.Label("<size=20><b>Windows Basic Operations</b></size>");
            
            GUILayout.Label("This program uses the following basic Windows operations.\n");
            GUILayout.Label("<b>①Left click:</b> Press the left mouse button. <b>②Left button drag:</b> Hold down the left mouse button and move the mouse.\n");
            GUILayout.Label("In this manual, there is an expression \"Please select ~\".");
            GUILayout.Label("If there is any information here, move the mouse cursor to the \"~\" part and click the left mouse button.");
            GUILayout.Label("(Example: If it says \"Select the OK button\", move the mouse cursor to the OK button and click the left mouse button.)\n");
            GUILayout.Label("<i>*In some cases, you may need to perform operations such as copying, moving, or deleting files. If you are unsure about this, please contact your computer manufacturer.</i>\n");
            GUILayout.Label("<b>Japanese input:</b>If you want to enter Japanese in the input field, click the input field, hold down the \"Alt\" key on your keyboard, press the \"Half-width/Full-width\" key, and then enter the characters.");
            GUILayout.Label("<i>*Once this operation is performed, Japanese input will be required until the game is restarted or the same operation is performed again.</i>");

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
                "<i>*If you operate the parallel plate on the moving axis, you can operate the two axes on the parallel plate side at the same time.</i>");

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
                "<i>*If there is no transparency item when selecting a color, it does not support transparency operations.</i>");

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
                    "<i>*If turned on, camera operations will no longer be accepted unless you hold down the \"Alt\" key on your keyboard while performing camera operations.</i>");
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
                        "<i>*Loading the scene, loading characters, loading items, and delete character items\n" + 
                        "Doing so will delete the operation history and prevent undoing.</i>");
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
    
        public static void GameScreen() {
            GUILayout.Label("<size=30>Game Screen</size>");
            GUILayout.Space(10);
            if (images[25] != null)
                GUILayout.Box(images[25], GUILayout.Width(860), GUILayout.Height(490));
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. Game Screen</size></b>\n" +
                "Performs various main operations such as loading, system operation, save and load.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. View</size></b>\n" +
                "The results of each operation will be displayed.\n" +
                "Camera operation with mouse or Shortcuts you can perform operations with.");
            GUILayout.EndVertical();
            GUILayout.Space(5);
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Camera registration</size></b>\n" +
                "Camera information (position, orientation, bank perspective) can be saved and read in 10 locations.\n" +
                "If you select \"SAVE\" above the \"number button\", save the current camera information to that \"number button\".\n" +
                "Selecting the \"Number button\" will load the camera information stored in that \"Number button\".\n" +
                "<i>*Saved camera information will be saved in the scene itself.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>4. Camera switching</size></b>\n" +
                "Item camera: If it is loaded, you can switch from here.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>5. Panel management</size></b>\n" +
                "You can show or hide each panel.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>6. Workspace</size></b>\n" +
                "You can manage the currently loaded character items.\n" +
                "<i>*You can move the window name part using the left button drag.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>7. Character/Item/Map/Scene</size></b>\n" +
                "You can load the character, item, map, and scene.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>8. Operating axis</size></b>\n" +
                "You can move, rotate, expand, and contract the items selected in the \"Workspace\".");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>9. Move panel</size></b>\n" +
                "You can control numerical input for movement, rotation, expansion and contraction, and switch operation axes.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>10. Options panel</size></b>\n" +
                "You can switch the display of the viewpoint and axis of interest, fix the camera, and perform undo and redo operations.");
            GUILayout.EndVertical();
        }

        public static void Menu() {
            GUILayout.Label("<size=40>Menu</size>");
            GUILayout.Space(10);
            if (images[26] != null)
                GUILayout.Box(images[26], GUILayout.Width(480), GUILayout.Height(350));
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. Add</size></b>\n" +
                "Used to load main content such as characters, items, maps, etc.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. Anim</size></b>\n" +
                "Used for Character operations, Change item color and pattern for selected Workspace Items/Characters.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Sound</size></b>\n" +
                "Used for BGM, selection and playback of external sounds.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>4. Map</size></b>\n" +
                "Changes in Config, Options, Character light, Screen effect.\n" +
                "You can Save, Load, Scene initialization, Quit StudioNeoV2.\n" +
                "<i>*Character light and screen effetc settings are saved in the scene itself.</i>");
            GUILayout.EndVertical();
        }

        public static void MenuAdd() {

            GUILayout.Label("<size=30>Add</size>");
            GUILayout.Space(10);
            GUILayout.Label("Used to load main content such as characters, items, maps, etc.");
            if (images[27] != null)
                GUILayout.Box(images[27], GUILayout.Width(480), GUILayout.Height(350));

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Female Character, Male Character</size></b>\n" +
                "Load the character created with the character maker.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Item</size></b>\n" +
                "Load item.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Map</size></b>\n" +
                "Load map.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Light</size></b>\n" +
                "You can add new light sources within the game.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Background</size></b>\n" +
                "BG-Images stored in the 'bg' folder can be loaded as a background.\n" +
                "<i>*Please select a transparent background map or None</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>Frame</size></b>\n" +
                "Image stored in the 'frame' folder can be displayed at the front of the screen.\n" +
                "<i>*Please not that if you do not perform transparency processing, the view screen will not be visible.</i>\n" +
                "<i>*Only 'png' images can be used for background frame. 16:9 ratio images are recommended." +
                "Also please note that loading large images may make the operation slow.</i>");
            GUILayout.EndVertical();

            GUILayout.Label("<size=30>Loading characters</size>");
            GUILayout.Space(10);
            GUILayout.Label("<b>You can load the character created with the character maker.</b>");
            if (images[28] != null)
                GUILayout.Box(images[28], GUILayout.Width(480), GUILayout.Height(350));
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. Add</size></b>\n" +
                "Once selected, a list of types will be displayed.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. Type list</size></b>\n" +
                "Select \"Female Character\" from the type list.\n" +
                "<i>*If you want to read male characters, please select \"Male Character\" here.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Character list</size></b>\n" +
                "This is a list of characters created and saved through character creation in the main game. Select the character you want to load.\n" +
                "<b>Name:</b> Sort the list by name.\n" +
                "<b>Date:</b> Sort the list by date.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>4. Character image</size></b>\n" +
                "This is an image of the character you hovered over in the character list.\n" +
                "<i>*Please not that this is not an image of the selected character.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>5. Load</size></b>\n" +
                "hen selected, the character selected in the character list will be loaded.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>6. Character change</size></b>\n" +
                "If a character is selected in the Workspace, replace it with the character selected in the character list." +
                "<i>*Only characters of the same gender can be replaced.\n" +
                "*Hair's FK is not carried over.</i>");
            GUILayout.EndVertical();

        }

        public static void MenuAnim() {
            GUILayout.Label("<size=30>Character operations</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can change the character's state and pose.");
            if (images[29] != null)
                GUILayout.Box(images[29], GUILayout.Width(480), GUILayout.Height(350));

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. Character selection</size></b>\n" +
                "Select the character you want to control in the Workspace.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. Anim</size></b>\n" +
                "If you select \"Anim\" with a character selected, a list of types will be displayed.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Type list</size></b>\n" +
                "<b>- States:</b> You can half-remove and remove clothes, manipulate juice, thears, red cheeks, nipples and skin luster.\n" +
                "<b>- Anim:</b> You can change the character's pose.\n" +
                "<b>- Kinematic:</b> You can use IK FK to manipulate poses, gaze, neck, eyes, mouth and hands.\n" +
                "<b>- Animation:</b> You can select poses, animations and change speed.\n" +
                "<b>- Voice:</b> You can select the voice you want to speak.\n" +
                "<b>- Outfit:</b> You can dress up your character using costume cards.\n" +
                "<b>- Joint correction:</b> Joint correction can be turned on/off.");
            GUILayout.EndVertical();
            GUILayout.Space(10);
        }

        public static void MenuAnimStates() {
            GUILayout.Label("<size=30>States</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can change the status of characters selected in the Workspace.\n" +
                "<i>*Items displayed for men and women are different.</i>");
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
                if (images[30] != null)
                    GUILayout.Box(images[30], GUILayout.Width(230), GUILayout.Height(630));
                GUILayout.BeginVertical();

                    GUILayout.BeginVertical(GUI.skin.box);
                    GUILayout.Label("<b><size=15>Clothing</size></b>");
                    GUILayout.Label("<b>- Bulk:</b> Half-Remove and remove clothes all at once");
                    GUILayout.EndVertical();

                    GUILayout.Space(5);

                    GUILayout.BeginVertical(GUI.skin.box);
                    GUILayout.Label("<b><size=15>Clothing Details</size></b>");
                    GUILayout.Label("<b>- Tops ~ Shoes:</b> Half-Remove and remove the selected part.");
                    GUILayout.EndVertical();

                    GUILayout.Space(5);

                    GUILayout.BeginVertical(GUI.skin.box);
                    GUILayout.Label("<b><size=15>Accessories</size></b>");
                    GUILayout.Label("<b>- Slot 01~20:</b> Remove accessories");
                    GUILayout.EndVertical();

                    GUILayout.Space(5);

                    GUILayout.BeginVertical(GUI.skin.box);
                    GUILayout.Label("<b><size=15>Juice</size></b>");
                    GUILayout.Label("<b>- Tears:</b> You can set the display of tears.");
                    GUILayout.Label("<b>- Red Cheek:</b> You can adjust the intensity of the red cheeks.");
                    GUILayout.Label("<b>- Nipples:</b> You can adjust the erection of the nipples.");
                    GUILayout.Label("<b>- Skin Luster:</b> You can adjust the gloss of the skin.");
                    GUILayout.Label("<b>- Wet:</b> You can adjust the wetness of characters and clothes.");
                    GUILayout.Label("<b>- Monochromatic:</b> If checked, characters will be displayed in silhouettes of the color selected in \"Color\". <i>*Hair, clothing, etc. will be hidden.</i>");
                    GUILayout.Label("<b>- Color:</b> You can set the color when monochromatic is checked.");
                    GUILayout.Label("<b>- Phallus:</b> Toggle phallic display. <i>*Works also for female characters.</i>");
                    GUILayout.Label("<b>- Phallus Size:</b> You can adjust the size of the phallus.");
                    GUILayout.EndVertical();
                GUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }

        public static void MenuAnimAnimation() {
            GUILayout.Label("<size=30>Animation</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can have the character selected in the workspace animate or pose.\n" +
                "<i>*Also used to control some items.</i>");
            if (images[31] != null)
                GUILayout.Box(images[31], GUILayout.Width(480), GUILayout.Height(350));

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. Anime category</size></b>");
            GUILayout.Label("Selecting toggles <b>2. Type</b>.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. Type</size></b>");
            GUILayout.Label("List of poses, acts. Selecting toggles <b>3. Motion</b>.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Motion</size></b>");
            GUILayout.Label("List of motions to choose from. Once selected, the character will animate.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>4. Animation controller</size></b>");
            GUILayout.Label("Controll the animation.\n" +
                "<b>- Speed:</b> You can adjust the speed of the animation.\n" +
                "<b>- Pattern:</b> You can change the animation pattern.\n" +
                "<b>- Auxiliary 1:</b> You can adjust the position of the animation that affects your height.\n" +
                "<b>- Auxiliary 2:</b> You can adjust the position of the animation that uses breasts.\n" +
                "<b>- Attached items:</b> You can switch the display of options included in the animation, such as the vibrator and camera.\n" +
                "<b>- Forced loop:</b> \"ON\" will loop the animation.\n" +
                "<b>- Re:</b> Play the animation that the current character is doing from the beginning.\n" +
                "<b>- ReaAll:</b> Play all the characters animations from the beginning\n" +
                "<b>- Copy:</b> Copy the animation type that the current character si doing.\n" +
                "<b>- Paste:</b> Paste the anymation type copied with \"Copy\" into the current character. <i>*Animation Speed and Pattern will not be pasted.</i>\n");
            GUILayout.EndVertical();
            GUILayout.Space(10);
        }

        public static void MenuAnimKinematic() {
            GUILayout.Label("<size=30>Kinematic</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can perform poses, gaze, facial expressions and hand operations of the selected character.");
            if (images[32] != null)
                GUILayout.Box(images[32], GUILayout.Width(480), GUILayout.Height(805));

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>1. FK</size></b>");
            GUILayout.Label("You can create and edit poses by rotating each part.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>2. IK</size></b>");
            GUILayout.Label("You can create and poses by moving each part.");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>3. Gaze</size></b>");
            GUILayout.Label("Set the direction of your gaze.\n" +
                "<b>- Front:</b> Face forward.\n" +
                "<b>- Camera:</b> It will turn towards the camera and follow you.\n" +
                "<b>- Divert:</b> It will be diverted from the camera.\n" +
                "<b>- Fixed:</b> Fix to the current state. <i>*Effective when changing from the initial state using camera/distraction/operation</i>\n" +
                "<b>- Operation:</b> Look towards the \"Gaze Manipulation target\". <i>*\"Gaze manipulation target\" will be displayed.</i>\n" +
                "<b>- Size:</b> You can adjust the size of the gaze.\n");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>4. Neck manipulation</size></b>");
            GUILayout.Label("Set the neck orientation.\n" +
                "<i>*If you turn on Neck inside the FK operation, this manipulation cannot be used, because those settings take precedence.</i>" +
                "<b>- Front:</b> Face forward.\n" +
                "<b>- Camera:</b> It will turn towards the camera and follow you.\n" +
                "<b>- Divert:</b> It will be diverted from the camera.\n" +
                "<b>- Fixed:</b> Fix to current state.\n" +
                "<i>*Effective when changing from the initial state using Camera/Divert.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>5. Eyebrows/Eyes/Mouth</size></b>");
            GUILayout.Label("Set facial expressions.\n" +
                "<b>- Type:</b> Change the pattern with the buttons (◀/▶).\n" +
                "<b>- Open:</b> You can adjust the opening using the slider. <i>*Depending on the type, it may not be possible to use it.</i>\n" +
                "<b>- Blink:</b> Check to turn blinking ON/OFF.\n" +
                "<b>- Lip sync:</b> Wen you set it to \"ON\", Voice will be synchronized with the mouth.\n");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>6. Hand</size></b>");
            GUILayout.Label("Set the shape of your hands.\n" +
                "<b>- Right/Left hand:</b> Change the pattern with the buttons (◀/▶).\n" +
                "<i>*If you urn your right/left hand in FK Operation, those settings will take precedence.</i>");
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("<b><size=15>7. Save pose</size></b>");
            GUILayout.Label("You can save and load poses created with FK/IK\n" +
                "<b>- Name:</b> This is the name input field used for saving.\n" +
                "<b>- Save:</b> Saves information about the current pose with the name you entered. <i>*You cannot save unless you enter a name.</i>\n" +
                "<b>- Load:</b> Loads the information selected in the \"Save List\". <i>*The current pose will be overwritten.</i>\n" +
                "<b>- Save List:</b> List of saved positions.\n" +
                "<b>- Delete:</b> If selected, the information selected in the \"Save List\" will be deleted.\n");
            GUILayout.EndVertical();
            GUILayout.Space(20);
        }

        public static void MenuAnimKinematicFK() {
            GUILayout.Label("<size=30>FK</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can create and edit poses by rotating each part of the selected character.");
            if (images[33] != null)
                GUILayout.Box(images[33], GUILayout.Width(480), GUILayout.Height(350));

            GUILayout.Label("<b>- Function:</b> When turned on, FK operations are enabled. <i>*The IK function will be turned off.</i>\n" +
                "<b>- Animation position:</b> If selected, you can edit the pose based on the anime pose you used before enabling FK operations.\n" +
                "<b>- Pose to IK:</b> Move the IK operation target to match the current pose. <i>*If you want to switch to IK operation, select this button first.</i>\n" +
                "<b>- Display:</b> You can perform FK operations on the turned on part. *Hair, chest, and skirt can only be controlled by female characters. Enabling these three items will eliminate fluctuations due to calculations.\n" +
                "<b>- Size:</b> You can adjust the size of the FK operation target and operation axis.\n" +
                "<b>- Initialization:</b> Initialize FK for the selected item. <i>*Only hair and skirts can be used.</i>\n" +
                "<b>- Individual reference:</b> You can partially load information about the original pose\n");

            GUILayout.Space(20);

            GUILayout.Label("<size=30>FK operation procedure</size>");
            GUILayout.Space(10);
            GUILayout.Label("<i>*Use rotation operation of the operation axis. For more details, please take a look at basic operations.</i>");
            GUILayout.Space(5);
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("1. Select FK operation target (ball).");
            if (images[34] != null)
                GUILayout.Box(images[34], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.EndVertical();
            GUILayout.Space(5);
    
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("2. The selected target changes to the operating axis");
            if (images[35] != null)
                GUILayout.Box(images[35], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("3. You can change the pose by rotating.");
            if (images[36] != null)
                GUILayout.Box(images[36], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.EndVertical();
            GUILayout.Space(20);
        }

        public static void MenuAnimKinematicIK() {
            GUILayout.Label("<size=30>IK</size>");
            GUILayout.Space(10);
            GUILayout.Label("You can create and edit poses by moving each part of the character selected in.");
            if (images[37] != null)
                GUILayout.Box(images[37], GUILayout.Width(480), GUILayout.Height(350));

            GUILayout.Label("<b>- Function:</b> When turned on, IK operations are enabled. <i>*The FK function will be turned off.</i>\n" +
                "<b>- Animation position:</b> If selected, you can edit the pose based on the anime pose you used before enabling IK operations.\n" +
                "<b>- Pose to FK:</b> Move the FK operation target to match the current pose. <i>*If you want to switch to FK operation, select this button first.</i>\n" +
                "<b>- Display:</b> You can perform IK operations on the turned on part. *Hair, chest, and skirt can only be controlled by female characters. Enabling these three items will eliminate fluctuations due to calculations.\n" +
                "<b>- Size:</b> You can adjust the size of the IK operation target and operation axis.\n" +
                "<b>- Initialization:</b> Initialize IK for the selected item. <i>*Only hair and skirts can be used.</i>\n" +
                "<b>- Individual reference:</b> You can partially load information about the original pose\n");

            GUILayout.Space(20);

            GUILayout.Label("<size=30>IK operation procedure</size>");
            GUILayout.Space(10);
            GUILayout.Label("<i>*Use operation to move the operation axis. For more details, please take a look at basic operations.</i>");
            GUILayout.Space(5);
            
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("1. Select IK operation target (red ball, blue ball).");
            if (images[38] != null)
                GUILayout.Box(images[38], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.EndVertical();
            GUILayout.Space(5);
    
            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("2. The selected target changes to the operating axis");
            if (images[39] != null)
                GUILayout.Box(images[39], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.EndVertical();
            GUILayout.Space(5);

            GUILayout.BeginVertical(GUI.skin.box);
            GUILayout.Label("3. You can change the pose by operating.");
            if (images[40] != null)
                GUILayout.Box(images[40], GUILayout.Width(560), GUILayout.Height(350));
            GUILayout.Space(5);
            GUILayout.Label("<i>*You can change the direction of your elbows and knees by manipulating the blue IK operation target.</i>");
            GUILayout.EndVertical();
            
            GUILayout.Space(20);
        }
    }

}
