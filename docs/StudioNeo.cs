using HS2Wiki_Content;
using UnityEngine;

using static UnityEngine.GUILayout;
using static GUIElements;

namespace docs {
    public class StudioNeo {
        private const int IMAGE_COUNT = 151;
        private static CustomTexture[] images;

        public static void Init() {
            images = new CustomTexture[IMAGE_COUNT];
            for (int i = 0; i < IMAGE_COUNT; i++) {
                images[i] = new CustomTexture("StudioNeo/" + (i + 1) + ".png");
            }

            WikiContent.RegisterWikiPage("StudioNeo", "Basics", Basics);
            WikiContent.RegisterWikiPage("StudioNeo", "Game Screen", GameScreen);
            WikiContent.RegisterWikiPage("StudioNeo/Menu", "Menu", Menu);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Add", "Base", MenuAdd);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Add", "Loading characters", MenuAddCharacter);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Add", "Loading items", MenuAddItem);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Add", "Loading maps", MenuAddMap);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Add", "Loading lights", MenuAddLight);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "Character operations", MenuAnimCharacter);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "States", MenuAnimCharacterStates);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "Animation", MenuAnimCharacterAnimation);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character/Kinematic", "Base operations", MenuAnimCharacterKinematic);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character/Kinematic", "FK", MenuAnimCharacterKinematicFK);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character/Kinematic", "IK", MenuAnimCharacterKinematicIK);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "Voice", MenuAnimCharacterVoice);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "Costume", MenuAnimCharacterCostume);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Character", "Joint Correction", MenuAnimCharacterJoint);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Item", "Item Settings", MenuAnimItemSettings);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Light", "Types of Lights", MenuAnimLightTypes);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Light", "Whole Light", MenuAnimLightWhole);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Light", "Point Light", MenuAnimLightPoint);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Anim/Light", "Spotlight", MenuAnimLightSpot);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/Sound", "Sound", MenuSound);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "System", MenuSystem);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Config", MenuSystemConfig);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Option", MenuSystemOption);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Character light", MenuSystemLight);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Screen effect", MenuSystemEffect);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Save/Load", MenuSystemSaveLoad);
            WikiContent.RegisterWikiPage("StudioNeo/Menu/System", "Scene initialization, studio closure", MenuSystemClose);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Workspace", Workspace);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Rename Folder", WorkspaceFolder);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Item Camera", WorkspaceCamera);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Multiple selection", WorkspaceMultiple);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Range selection", WorkspaceRange);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "Copy", WorkspaceCopy);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace/Relation", "Parent-Child relationship", WorkspaceRelation);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace/Relation", "Example with Button", WorkspaceRelationButton);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace/Relation", "Example with Key", WorkspaceRelationKey);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace/Route", "Route", WorkspaceRoute);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace/Route", "Example", WorkspaceRouteExample);
            WikiContent.RegisterWikiPage("StudioNeo/Workspace", "H Scene", HScene);

        }   

        /// <summary>
        /// Basic operations
        /// Windows Basic Operations
        /// </summary>
        public static void Basics() {
            Label("<size=30>Basic Operations</size>");
            Label("<size=20><b>Windows Basic Operations</b></size>");
            
            Label("This program uses the following basic Windows operations.\n");
            Label("<b>①Left click:</b> Press the left mouse button. <b>②Left button drag:</b> Hold down the left mouse button and move the mouse.\n");
            Label("In this manual, there is an expression \"Please select ~\".");
            Label("If there is any information here, move the mouse cursor to the \"~\" part and click the left mouse button.");
            Label("(Example: If it says \"Select the OK button\", move the mouse cursor to the OK button and click the left mouse button.)\n");
            Label("<i>*In some cases, you may need to perform operations such as copying, moving, or deleting files. If you are unsure about this, please contact your computer manufacturer.</i>\n");
            Label("<b>Japanese input:</b>If you want to enter Japanese in the input field, click the input field, hold down the \"Alt\" key on your keyboard, press the \"Half-width/Full-width\" key, and then enter the characters.");
            Label("<i>*Once this operation is performed, Japanese input will be required until the game is restarted or the same operation is performed again.</i>");

            Space(10);

            Label("<size=30>Camera operation</size>");
            Label("You can operate the camera in a place where there are no menus or buttons.");

            BeginHorizontal();
                images.Show(0);
                images.Show(1);
                images.Show(2);
                FlexibleSpace();
            EndHorizontal();
            BeginHorizontal();
                images.Show(3);
                images.Show(4);
                FlexibleSpace();
            EndHorizontal();

            Space(10);

            Label("<size=30>Move/rotate/reduce operations (move panel)</size>");
            Label("You can move, rotate, expand or contract the target axis or by inputting numerical values.\n" +
                "<i>*If you operate the parallel plate on the moving axis, you can operate the two axes on the parallel plate side at the same time.</i>");

            BeginHorizontal();
                images.Show(5);
                images.Show(6);
                images.Show(7);
                FlexibleSpace();
            EndHorizontal();
            BeginHorizontal();
                images.Show(8);
                images.Show(9);
                images.Show(10);
                FlexibleSpace();
            EndHorizontal();

            Space(10);

            Label("<size=30>Slider/color operation</size>");
            Label("You can adjust the numerical value by operating the slider with the mouse or select a color from the \"Color Panel\".\n" +
                "<i>*If there is no transparency item when selecting a color, it does not support transparency operations.</i>");

            BeginHorizontal();
                images.Show(11);
                images.Show(12);
                images.Show(13);
                images.Show(14);
                FlexibleSpace();
            EndHorizontal();
            Space(10);

            Label("<size=30>Options panel</size>");

            BeginHorizontal();
                images.Show(15);
                Label("You can move objects indirectly using panels instead of operating axes.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(16);
                Label("<b>map</b> If it is loaded, you can perform map operations.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(17);
                Label("Toggles the display of the viewpoint of interest (camera reference point).");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(18);
                Label("Toggles the display of operation axes used for movement and IK/FK.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(19);
                Label("Toggles the camera lock function ON/OFF.\n" +
                    "<i>*If turned on, camera operations will no longer be accepted unless you hold down the \"Alt\" key on your keyboard while performing camera operations.</i>");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(20);
                Label("Toggles the display of the \"parallel plate\" used for movement operations.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(21);
                Label("Toggles the display of the \"center point\" displayed on characters and items.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(22);
                Label("Undo: Undoes the previous operation.");
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(23);
                BeginVertical();
                    Label("Redo: redo operations undone with \"undo\".\n" +
                        "<i>*Loading the scene, loading characters, loading items, and delete character items\n" + 
                        "Doing so will delete the operation history and prevent undoing.</i>");
                EndVertical();
                FlexibleSpace();
            EndHorizontal();

            Space(10);

            Label("<size=30>Checkbox</size>");
            BeginHorizontal();
                images.Show(24);
                Label("If you select the checkbox, you can switch ON/OFF.");
                FlexibleSpace();
            EndHorizontal();
        }
    
        /// <summary>
        /// Game Screen
        /// </summary>
        public static void GameScreen() {
            Label("<size=30>Game Screen</size>");
            Space(10);
            images.Show(25);
            
            BeginVertical(GUI.skin.box);
            Label("<b><size=15>1. Game Screen</size></b>\n" +
                "Performs various main operations such as loading, system operation, save and load.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>2. View</size></b>\n" +
                "The results of each operation will be displayed.\n" +
                "Camera operation with mouse or Shortcuts you can perform operations with.");
            EndVertical();
            Space(5);
            
            BeginVertical(GUI.skin.box);
            Label("<b><size=15>3. Camera registration</size></b>\n" +
                "Camera information (position, orientation, bank perspective) can be saved and read in 10 locations.\n" +
                "If you select \"SAVE\" above the \"number button\", save the current camera information to that \"number button\".\n" +
                "Selecting the \"Number button\" will load the camera information stored in that \"Number button\".\n" +
                "<i>*Saved camera information will be saved in the scene itself.</i>");
            EndVertical();
            Space(5);
            
            BeginVertical(GUI.skin.box);
            Label("<b><size=15>4. Camera switching</size></b>\n" +
                "Item camera: If it is loaded, you can switch from here.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>5. Panel management</size></b>\n" +
                "You can show or hide each panel.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>6. Workspace</size></b>\n" +
                "You can manage the currently loaded character items.\n" +
                "<i>*You can move the window name part using the left button drag.</i>");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>7. Character/Item/Map/Scene</size></b>\n" +
                "You can load the character, item, map, and scene.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>8. Operating axis</size></b>\n" +
                "You can move, rotate, expand, and contract the items selected in the \"Workspace\".");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>9. Move panel</size></b>\n" +
                "You can control numerical input for movement, rotation, expansion and contraction, and switch operation axes.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            Label("<b><size=15>10. Options panel</size></b>\n" +
                "You can switch the display of the viewpoint and axis of interest, fix the camera, and perform undo and redo operations.");
            EndVertical();
        }

        /// <summary>
        /// Menu
        /// </summary>
        public static void Menu() {
            Label("<size=40>Menu</size>");
            Space(10);
            images.Show(26);
            
            BeginVertical(GUI.skin.box);
            TitleLink("1. Add", "", "StudioNeo/Menu/Add", "Base");
            Label("Used to load main content such as characters, items, maps, etc.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            TitleLink("2. Anim", "", "StudioNeo/Menu/Anim", "Character operations");
            Label("Used for Character operations, Change item color and pattern for selected Workspace Items/Characters.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            TitleLink("3. Sound", "", "StudioNeo/Menu/Sound", "Sound");
            Label("Used for BGM, selection and playback of external sounds.");
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
            TitleLink("4. Settings", "", "StudioNeo/Menu/Settings", "Settings");
            Label("Changes in Config, Options, Character light, Screen effect.\n" +
                "You can Save, Load, Scene initialization, Quit StudioNeoV2.\n" +
                "<i>*Character light and screen effetc settings are saved in the scene itself.</i>");
            EndVertical();
        }

        #region Add

        /// <summary>
        /// Add
        /// Used to load main content such as characters, items, maps, etc.
        /// </summary>
        public static void MenuAdd() {

            HeaderSubtitle("Add", "Used to load main content such as characters, items, maps, etc.");

            BeginHorizontal();
                images.Show(27);

                BeginVertical();
                    TitleText("Female Character, Male Character", "Load the character created with the character maker.");
                    Space(5);
                    TitleText("Item", "Load item.");
                    Space(5);
                    TitleText("Map", "Load map.");
                    Space(5);
                    TitleText("Light", "You can add new light sources within the game.");
                    Space(5);
                    TitleText("Background", "BG-Images stored in the 'bg' folder can be loaded as a background.\n" +
                        "<i>*Please select a transparent background map or None</i>");
                    Space(5);
                    TitleText("Frame", "Image stored in the 'frame' folder can be displayed at the front of the screen.\n" +
                        "<i>*Please not that if you do not perform transparency processing, the view screen will not be visible.</i>\n" +
                        "<i>*Only 'png' images can be used for background frame. 16:9 ratio images are recommended." +
                        "Also please note that loading large images may make the operation slow.</i>");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Loading characters
        /// You can load the character created with the character maker.
        /// </summary>
        public static void MenuAddCharacter() {
            HeaderSubtitle("Loading characters", "You can load the character created with the character maker.");

            BeginHorizontal();
                images.Show(28);
                
                BeginVertical();
                    TitleText("1. Add", "Once selected, a list of types will be displayed.");
                    Space(5);
                    TitleText("2. Type list", "Select \"Female Character\" from the type list.\n" +
                        "<i>*If you want to read male characters, please select \"Male Character\" here.</i>");
                    Space(5);
                    TitleText("3. Character list", "This is a list of characters created and saved through character creation in the main game. Select the character you want to load.\n" +
                        "<b>Name:</b> Sort the list by name.\n" +
                        "<b>Date:</b> Sort the list by date.");
                    Space(5);
                    TitleText("4. Character image", "This is an image of the character you hovered over in the character list.\n" +
                        "<i>*Please not that this is not an image of the selected character.</i>");
                    Space(5);
                    TitleText("5. Load", "When selected, the character selected in the character list will be loaded.");
                    Space(5);
                    TitleText("6. Character change", "If a character is selected in the Workspace, replace it with the character selected in the character list." +
                        "<i>*Only characters of the same gender can be replaced.\n" +
                        "*Hair's FK is not carried over.</i>");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Loading items
        /// The game can be loaded with a variety of items.
        /// </summary>
        public static void MenuAddItem() {
            HeaderSubtitle("Loading items", "The game can be loaded with a variety of items.");

            BeginHorizontal();
                images.Show(55);
                BeginVertical();
                    TitleText("1. Add", "When selected, \"2. Type list\" will be displayed.");
                    TitleText("2. Type list", "Select \"Item\" from the list of types. <i>* \"3. Item Category 1\" will be displayed.</i>");
                    TitleText("3. Item Category 1", "When an item is selected, \"4. Item Category 2\" will be displayed.");
                    TitleText("4. Item Category 2", "When an item is selected, \"5. Item Category 3\" will be displayed.");
                    TitleText("5. Item Category 3", "When an item is selected, \"6. Item List\" will appear.");
                    TitleText("6. Item List", "Select the item you wish to load and it will be loaded into the game.\n" +
                        "<i>*Red letters can be changed to one color, blue letters to two colors, green letters to three colors, and yellow letters to four colors.</i>");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Loading maps
        /// </summary>
        public static void MenuAddMap() {
            Header("Loading maps");

            BeginHorizontal();
                images.Show(58);
                BeginVertical();
                    TitleText("1. Add", "When selected, a list of types is displayed.");
                    TitleText("2. Type list", "Select \"Map\" from the list of types.");
                    TitleText("3. Map List", "Select the map you want to load and it will load.");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Loading light
        /// New light sources can be added to the game.
        /// </summary>
        public static void MenuAddLight() {
            HeaderSubtitle("Loading light", "New light sources can be added to the game.");

            BeginHorizontal();
                images.Show(59);
                BeginVertical();
                    TitleText("1. Add", "When selected, a list of types is displayed.");
                    TitleText("2. Type list", "Select \"Light\" from the list of types.");

                    BeginVertical(GUI.skin.box);
                        Title("3. Light List");
                        Label("Select the light you wish to add and the light source will be added.");
                        TextListElement("Whole Light", "The light will affect the entire scene.");
                        TextListElement("Point Light", "The light will illuminate a fixed area like a light bulb.");
                        TextListElement("Spotlight", "The light illuminates only in the direction you are facing.");
                    EndVertical();
                EndVertical();
            EndHorizontal();
            
            Space(5);

            Label("<i>*Expansion and contract operations cannot be performed.</i>");
            Label("<i>*Lights marked (character only) (map only) affect only the target.</i>");
        }

        #endregion Add

        #region Anim

            #region Character

        /// <summary>
        /// Character operations
        /// You can change the character's state and pose.
        /// </summary>
        public static void MenuAnimCharacter() {
            HeaderSubtitle("Character operations", "You can change the character's state and pose.");

            BeginHorizontal();
                images.Show(29);
                BeginVertical();
                    TitleText("1. Character selection", "Select the character you want to control in the Workspace.");
                    Space(5);
                    TitleText("2. Anim", "If you select \"Anim\" with a character selected, a list of types will be displayed.");
                    Space(5);

                    BeginVertical(GUI.skin.box);
                    Title("3. Type list");
                    TextListElement("States", "You can half-remove and remove clothes, manipulate juice, thears, red cheeks, nipples and skin luster.");
                    TextListElement("Anim", "You can change the character's pose.");
                    TextListElement("Kinematic", "You can use IK FK to manipulate poses, gaze, neck, eyes, mouth and hands.");
                    TextListElement("Animation", "You can select poses, animations and change speed.");
                    TextListElement("Voice", "You can select the voice you want to speak.");
                    TextListElement("Outfit", "You can dress up your character using costume cards.");
                    TextListElement("Joint correction", "Joint correction can be turned on/off.");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// States
        /// You can change the status of characters selected in the Workspace.
        /// </summary>
        public static void MenuAnimCharacterStates() {
            HeaderSubtitle("States", "You can change the status of characters selected in the Workspace.\n" +
                "<i>*Items displayed for men and women are different.</i>");
            BeginHorizontal();
                images.Show(30);
                BeginVertical();

                    BeginVertical(GUI.skin.box);
                        Title("Clothing");
                        TextListElement("Bulk", "Half-Remove and remove clothes all at once");
                        TextListElement("Tops ~ Shoes", "Half-Remove and remove the selected part.");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("Accessories");
                        TextListElement("Slot 01~20", "Remove accessories");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("Juice");
                        TextListElement("Tears", "You can set the display of tears.");
                        TextListElement("Red Cheek", "You can adjust the intensity of the red cheeks.");
                        TextListElement("Nipples", "You can adjust the erection of the nipples.");
                        TextListElement("Skin Luster", "You can adjust the gloss of the skin.");
                        TextListElement("Wet", "You can adjust the wetness of characters and clothes.");
                        TextListElement("Monochromatic", "If checked, characters will be displayed in silhouettes of the color selected in \"Color\". <i>*Hair, clothing, etc. will be hidden.</i>");
                        TextListElement("Color", "You can set the color when monochromatic is checked.");
                        TextListElement("Phallus", "Toggle phallic display. <i>*Works also for female characters.</i>");
                        TextListElement("Phallus Size", "You can adjust the size of the phallus.");
                    EndVertical();
                EndVertical();
                FlexibleSpace();
            EndHorizontal();
        }

        /// <summary>
        /// Animation
        /// You can have the character selected in the workspace animate or pose.
        /// </summary>
        public static void MenuAnimCharacterAnimation() {
            HeaderSubtitle("Animation", "You can have the character selected in the workspace animate or pose.\n" +
                "<i>*Also used to control some items.</i>");

            BeginHorizontal();
                images.Show(31);
                BeginVertical();
                    TitleText("1. Anime category", "Selecting toggles <b>2. Type</b>.");
                    TitleText("2. Type", "List of poses, acts. Selecting toggles <b>3. Motion</b>.");
                    TitleText("3. Motion", "List of motions to choose from. Once selected, the character will animate.");

                    BeginVertical(GUI.skin.box);
                        Title("4. Animation controller");
                        Label("Control the animation.");
                        TextListElement("Speed", "You can adjust the speed of the animation.");
                        TextListElement("Pattern", "You can change the animation pattern.");
                        TextListElement("Auxiliary 1", "You can adjust the position of the animation that affects your height.");
                        TextListElement("Auxiliary 2", "You can adjust the position of the animation that uses breasts.");
                        TextListElement("Attached items", "You can switch the display of options included in the animation, such as the vibrator and camera.");
                        TextListElement("Forced loop", "\"ON\" will loop the animation.");
                        TextListElement("Re", "Play the animation that the current character is doing from the beginning.");
                        TextListElement("ReaAll", "Play all the characters animations from the beginning");
                        TextListElement("Copy", "Copy the animation type that the current character si doing.");
                        TextListElement("Paste", "Paste the anymation type copied with \"Copy\" into the current character. <i>*Animation Speed and Pattern will not be pasted.</i>");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Kinematic
        /// You can perform poses, gaze, facial expressions and hand operations of the selected character.
        /// </summary>
        public static void MenuAnimCharacterKinematic() {
            HeaderSubtitle("Kinematic", "You can perform poses, gaze, facial expressions and hand operations of the selected character.");

            BeginHorizontal();
                images.Show(32);

                BeginVertical();
                    TitleText("1. FK", "You can create and edit poses by rotating each part.");
                    TitleText("2. IK", "You can create and poses by moving each part.");

                    BeginVertical(GUI.skin.box);
                        Title("3. Gaze");
                        Label("Set the direction of your gaze.");
                        TextListElement("Front", "Face forward.");
                        TextListElement("Camera", "It will turn towards the camera and follow you.");
                        TextListElement("Divert", "It will be diverted from the camera."); 
                        TextListElement("Fixed", "Fix to the current state. <i>*Effective when changing from the initial state using camera/distraction/operation</i>");
                        TextListElement("Operation", "Look towards the \"Gaze Manipulation target\". <i>*\"Gaze manipulation target\" will be displayed.</i>");
                        TextListElement("Size", "You can adjust the size of the gaze.");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("4. Neck manipulation");
                        Label("Set the neck orientation.\n" +
                            "<i>*If you turn on Neck inside the FK operation, this manipulation cannot be used, because those settings take precedence.</i>");
                        TextListElement("Front", "Face forward.");
                        TextListElement("Camera", "It will turn towards the camera and follow you.");
                        TextListElement("Divert", "It will be diverted from the camera.");
                        TextListElement("Fixed", "Fix to current state.");
                        TextListElement("Effective", "<i>*Effective when changing from the initial state using Camera/Divert.</i>");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("5. Eyebrows/Eyes/Mouth");
                        Label("Set facial expressions.");
                        TextListElement("Type", "Change the pattern with the buttons (◀/▶).");
                        TextListElement("Open", "You can adjust the opening using the slider. <i>*Depending on the type, it may not be possible to use it.</i>");
                        TextListElement("Blink", "Check to turn blinking ON/OFF.");
                        TextListElement("Lip sync", "Wen you set it to \"ON\", Voice will be synchronized with the mouth.");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("6. Hand");
                        Label("Set the shape of your hands.");
                        TextListElement("Right/Left hand", "Change the pattern with the buttons (◀/▶).");
                        TextListElement("Effective", "<i>*If you urn your right/left hand in FK Operation, those settings will take precedence.</i>");
                    EndVertical();

                    BeginVertical(GUI.skin.box);
                        Title("7. Save pose");
                        Label("You can save and load poses created with FK/IK");
                        TextListElement("Name", "This is the name input field used for saving.");
                        TextListElement("Save", "Saves information about the current pose with the name you entered. <i>*You cannot save unless you enter a name.</i>");
                        TextListElement("Load", "Loads the information selected in the \"Save List\". <i>*The current pose will be overwritten.</i>");
                        TextListElement("Save List", "List of saved positions.");
                        TextListElement("Delete", "If selected, the information selected in the \"Save List\" will be deleted.");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// FK
        /// You can create and edit poses by rotating each part of the selected character.
        /// </summary>
        public static void MenuAnimCharacterKinematicFK() {
            HeaderSubtitle("FK", "You can create and edit poses by rotating each part of the selected character.");

            BeginHorizontal();
            images.Show(33);

            BeginVertical();
            TextListElement("Function", "When turned on, FK operations are enabled. <i>*The IK function will be turned off.</i>");
            TextListElement("Animation position", "If selected, you can edit the pose based on the anime pose you used before enabling FK operations.");
            TextListElement("Pose to IK", "Move the IK operation target to match the current pose. <i>*If you want to switch to IK operation, select this button first.</i>");
            TextListElement("Display", "You can perform FK operations on the turned on part. *Hair, chest, and skirt can only be controlled by female characters. Enabling these three items will eliminate fluctuations due to calculations.");
            TextListElement("Size", "You can adjust the size of the FK operation target and operation axis.");
            TextListElement("Initialization", "Initialize FK for the selected item. <i>*Only hair and skirts can be used.</i>");
            TextListElement("Individual reference", "You can partially load information about the original pose");
            EndVertical();
            EndHorizontal();

            Space(20);

            HeaderSubtitle("FK operation procedure", "Use rotation operation of the operation axis. For more details, please take a look at basic operations.");

            BeginHorizontal();
                TitleImage("1. Select FK operation target (ball).", images[34]);
                Space(5);
                TitleImage("2. The selected target changes to the operating axis", images[35]);
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("3. You can change the pose by rotating.", images[36]);
                FlexibleSpace();
            EndHorizontal();

        }

        /// <summary>
        /// IK
        /// You can create and edit poses by moving each part of the character selected in.
        /// </summary>
        public static void MenuAnimCharacterKinematicIK() {
            HeaderSubtitle("IK", "You can create and edit poses by moving each part of the character selected in.");

            BeginHorizontal();
                images.Show(37);
                BeginVertical();

                    TextListElement("Function", "When turned on, IK operations are enabled. <i>*The FK function will be turned off.</i>");
                    TextListElement("Animation position", "If selected, you can edit the pose based on the anime pose you used before enabling IK operations.");
                    TextListElement("Pose to FK", "Move the FK operation target to match the current pose. <i>*If you want to switch to FK operation, select this button first.</i>");
                    TextListElement("Display", "You can perform IK operations on the turned on part. *Hair, chest, and skirt can only be controlled by female characters. Enabling these three items will eliminate fluctuations due to calculations.");
                    TextListElement("Size", "You can adjust the size of the IK operation target and operation axis.");
                    TextListElement("Initialization", "Initialize IK for the selected item. <i>*Only hair and skirts can be used.</i>");
                    TextListElement("Individual reference", "You can partially load information about the original pose");

                EndVertical();
            EndHorizontal();

            Space(20);

            HeaderSubtitle("IK operation procedure", "Use operation to move the operation axis. For more details, please take a look at basic operations.");
            
            BeginHorizontal();
                TitleImage("1. Select IK operation target (red ball, blue ball).", images[38]);
                Space(5);
                TitleImage("2. The selected target changes to the operating axis", images[39]);
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("3. You can change the pose by operating.", images[40]);
                FlexibleSpace();
            EndHorizontal();
            Label("<i>*You can change the direction of your elbows and knees by manipulating the blue IK operation target.</i>");
        }

        /// <summary>
        /// Voice
        /// You can choose the lines you want the selected character to speak in the Workspace
        /// </summary>
        public static void MenuAnimCharacterVoice() {
            HeaderSubtitle("Voice", "You can choose the lines you want the selected character to speak in the Workspace");

            BeginHorizontal();
                images.Show(41);
                BeginVertical();
                    Label("If you want to match the mouth movement with the dialogue, go to \"Kinema\" > \"Eyebrows, Eyes, and Mouth\" and set \"Mouthquake\" to \"ON\".\n" + 
                        "<i>*The destination of data saved in \"Voice Registration\" is This way (direction close to the speaker or towards the speaker)for more information.</i>");
                EndVertical();
                FlexibleSpace();

                BeginVertical();
                    Space(10);

                    TitleText("1. Character (often in a manga, anime, game, etc.)", "This is a list of personalities. When you select one, \"2. Kind\" switches.");
                    TitleText("2. Type", "Selecting this item toggles the \"3. Serifs\".");
                    TitleText("3. Serifs", "Here is a list of lines to choose from.\n" +
                        "<i>*To the right of the lines.</i>");

                    BeginVertical(GUI.skin.box);
                        Title("4. Playlist");
                        Label("Playback control can be performed.");
                        ImgTextListElement(images[43], "Playback", "When selected, the lines of \"Registration List\". The lines of the \"Registration List\" will be played from the beginning.");
                        ImgTextListElement(images[44], "Cessation", "Selecting stops the dialogue.");
                        ImgTextListElement(images[45], "Repeat Registration List", "When the playback of \"Registration List\" is finished, the playback starts from the beginning. <i>*Selecting this option allows you to switch settings.</i>");
                        ImgTextListElement(images[46], "No repeat Registration List", "The \"Register List\" does not repeat after the playback of the \"Register List\" is finished.");
                        ImgTextListElement(images[47], "1 repeat", "Repeats only the currently playing line.");
                        ImgTextListElement(images[48], "Simultaneous playback", "When selected, the lines of the character selected in the workspace are played simultaneously.");
                        ImgTextListElement(images[49], "Stop Workspace", "When selected, workspace stops the dialogue of the selected character.");
                        TextListElement("Registration List", "Here is a list of the lines to be played back.");

                        BeginHorizontal();
                            Label("    <i>*Select \"</i>");
                            images.Show(50);
                            Label("<i>\" to the right of the lines to remove them from the list.</i>");
                            FlexibleSpace();
                        EndHorizontal();

                        TextListElement("Clear All Lists", "Selecting this option deletes all lines in the \"Registration List\".");
                        ImgTextListElement(images[51], "Registration", "When selected, \"(5) Voice Registration\" and \"(6) Voice Registration\" display is toggled.");
                    EndVertical();

                    Space(5);

                    BeginVertical(GUI.skin.box);
                        Title("5. Voice registration");
                        Label("You can save, load, and add to the \"Registration List\".");
                        TextListElement("Name", "This is the input field for the name used to save the file.");
                        TextListElement("Save", "Saves the information in the \"Registration List\" under the name of \"Name\". If you do not enter a name, you will not be able to save the information.");
                        TextListElement("Load", "Loads the information selected in the \"Save List\". The \"Registration List\" will be overwritten.");
                        TextListElement("Import", "The information selected in the \"Save List\" is additionally loaded in the \"Registration List\".");
                        TextListElement("Saved Lists", "List of saved \"Registration Lists\".");
                        TextListElement("Delete", "When selected, the information selected in the \"Save List\" is deleted.");
                        ImgTextListElement(images[50], "Close", "When selected, \"(5) Voice Registration\" is hidden.");
                    EndVertical();
                EndVertical();
            
            EndHorizontal();
        }

        /// <summary>
        /// Costume
        /// The costume card created by character maker. The selected character can be selected in Workspace.
        /// </summary>
        public static void MenuAnimCharacterCostume() {
            HeaderSubtitle("Costume", "The costume card created by character maker. The selected character can be selected in Workspace.");

            BeginHorizontal();
                images.Show(52);

                BeginVertical();
                    BeginVertical(GUI.skin.box);
                        Title("1. Costume List");
                        Label("List of costume cards created and saved in the main game's character makeup.");
                        TextListElement("Name", "Sort the list by name");
                        TextListElement("Date", "Sort the list by date");
                    EndVertical();

                    TitleText("2. Costume image", "This is an image of the outfit you have cursed in the costume list\n" +
                        "<i>*Please note that this is not an image of the outfit you have selected.</i>");

                    TitleText("3. Dress Code", "If you selected from the Workspace, it changes the costume of the character selected in (1) Costume List to the costume selected in (2) Costume List.");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Joint Correction
        /// You can adjust the position of the selected character's joints.
        /// </summary>
        public static void MenuAnimCharacterJoint() {
            HeaderSubtitle("Joint Correction", "You can adjust the position of the selected character's joints.");

            BeginHorizontal();
                TitleImage("Joint compensation: None", images[53]);
                Space(5);
                TitleImage("Joint compensation: Yes", images[54]);
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            Label("<i>*If extreme poses are made, the correction may not be complete.</i>");
        }
        
            #endregion Character

            #region Item

        /// <summary>
        /// Item Settings
        /// Some items can be changed in color, pattern, etc.
        /// </summary>
        public static void MenuAnimItemSettings() {
            HeaderSubtitle("Item Settings", "Some items can be changed in color, pattern, etc.");
            
            BeginHorizontal();
                images.Show(56);
                images.Show(57);
                FlexibleSpace();
            EndHorizontal();

            Space(5);

            TitleText("1. Select an Item from the Workspace", "Select an Item from the Workspace");
            TitleText("2. Item Settings", "When \"anim\" is selected with the changeable items selected, \"Item Settings\" will appear.");

            BeginVertical(GUI.skin.box);
                Title("3. Item Settings");
                Label("Various settings can be changed.\nThe items displayed will vary depending on the item selected.");
                TextListElement("Color 1-4", "If you select, the color can be changed with the Color panel.");
                TextListElement("Texture", "Texture can be set.");
                TextListElement("Smoothness", "The light reflection can be set. <i>*If \"Texture\" and \"Smoothness\" are set to a high level, the texture will be close to that of metal.</i>");
                TextListElement("Impact of light", "You can set the impact of the light.");
                TextListElement("Pattern, Color", "You can select the type of pattern and change the color. <i>* Pattern: You can also load images that are stored in a folder called \"Image\" folder.</i>");
                TextListElement("Repeat", "When turned ON, the pattern is displayed repeatedly.");
                TextListElement("Horizontal and vertical movement", "The handle can be moved.");
                TextListElement("Horizontal and vertical scales", "The size of the pattern can be changed.");
                TextListElement("Rotation", "The handle can be rotated.");
                TextListElement("Shadow", "You can change the color of the shadow that appears on the item.");
                TextListElement("Alpha", "You can change the transparency of the item.");
                TextListElement("ImageBase", "Used for image boards. You can load images from the \"bg\" folder.\n");
            EndVertical();

            Space(5);

            Label("Some items can be adjusted with sliders.\n" +
                "<i>*Items with numbers can be adjusted by directly entering numerical values.\n" +
                "*Select \"def\" to return to standard values.</i>");
        }

            #endregion Item

            #region Light

        /// <summary>
        /// Types of Lights
        /// </summary>
        public static void MenuAnimLightTypes() {
            Header("Types of Lights");

            BeginHorizontal();
                TitleImage("Without Light", images[60]);
                TitleImage("Whole Light", images[61]);
                TitleImage("Point Light", images[62]);
                TitleImage("Spotlight", images[63]);
                FlexibleSpace();
            EndHorizontal();
        }

        /// <summary>
        /// Whole Light
        /// </summary>
        public static void MenuAnimLightWhole() {
            Header("Whole Light");

            BeginHorizontal();
                images.Show(64);
                BeginVertical();
                    TitleText("1.", "Select a light from the Workspace");
                    TitleText("2.", "Select \"anim\" to display the light setting screen.");

                BeginVertical(GUI.skin.box);
                    Title("3.");
                    Label("You can make changes to the settings.");
                    TextListElement("Color", "The light color can be changed in the color panel.");
                    TextListElement("Light ON/OFF", "The light can be switched on and off.");
                    TextListElement("Display of Targets", "The display of the operating axis can be switched.");
                    TextListElement("Self Shadow", "Switches the shadows produced by the lights.");
                    TextListElement("Strength", "The intensity of the light can be adjusted.");
                EndVertical();
                Label("<i>*The entire light is not affected by the moving operation.</i>");
            EndVertical();
        }

        /// <summary>
        /// Point Light
        /// </summary>
        public static void MenuAnimLightPoint() {
            Header("Point Light");

            BeginHorizontal();
            images.Show(65);

            BeginVertical();
                TitleText("1.", "Select a light from the workspace.");
                TitleText("2.", "Select \"anim\" to display the light setting screen.");

                BeginVertical(GUI.skin.box);
                    Title("3.");
                    Label("You can make changes to the settings.");
                    TextListElement("Color", "The light color can be changed with the Color panel.");
                    TextListElement("Light ON/OFF", "The light can be switched on and off.");
                    TextListElement("Display of Targets", "The display of the operating axis can be toggled between the two.");
                    TextListElement("Self Shadow", "Switches the shadows produced by the lights.");
                    TextListElement("Strength", "The intensity of the light can be adjusted.");
                    TextListElement("Range", "You can adjust the range of the light's influence.");
                EndVertical();
            EndVertical();
        }

        /// <summary>
        /// Spotlight
        /// </summary>
        public static void MenuAnimLightSpot() {
            Header("Spotlight");

            BeginHorizontal();
            images.Show(66);


            BeginVertical();
                TitleText("1.", "Select a light from the workspace.");
                TitleText("2.", "Select \"anim\" to display the light settings screen.");

                BeginVertical(GUI.skin.box);
                    Title("3.");
                    Label("You can change settings.");
                    TextListElement("Color", "You can change the light color with the Color panel.");
                    TextListElement("Light ON/OFF", "You can turn the light on/off.");
                    TextListElement("Display target", "You can switch the display.");
                    TextListElement("Self shadow", "Switch the shadows created by the light.");
                    TextListElement("Strength", "You can adjust the strength of the light.");
                    TextListElement("Range", "You can adjust the area affected by the light.");
                    TextListElement("Spot angle", "The illumination angle can be adjusted up to 180 degrees.");
                EndVertical();
            EndVertical();

        }

            #endregion Light

        #endregion Anim

        #region Sound

        /// <summary>
        /// Sound
        /// BGM and external read playback settings can be made.
        /// </summary>
        public static void MenuSound() {
            HeaderSubtitle("Sound", "BGM and external read playback settings can be made.");

            BeginHorizontal();
                images.Show(67);
                BeginVertical();
                    TitleText("1. Sound", "Once selected, a list of types will be displayed.");
                    BeginVertical(GUI.skin.box);
                        Title("2. Type list");
                        Label("Select the item you want to play to display the player.");
                        TextListElement("BGM", "BGM can be selected from the installed data. *Cannot be played at the same time as \"external read\".");
                        TextListElement("External read", "You can play wav format files in the folder in-game.");
                        Label("<i>*Cannot be played at the same time as \"BGM\". The wav format files that can be used are only 8bit and 16bit.</i>");
                        Label("<i>*We cannot answer questions regarding wav format files.");
                    EndVertical();
                    BeginVertical(GUI.skin.box);
                        Title("3. Player");
                        Label("This is the screen for selecting, playing, and stopping. The operation method is the same for BGM and external reading.");
                        TextListElement("List", "List of music to choose from.");
                        ImgTextListElement(images[68], "Playback", "Play the music you have selected in the list.");
                        ImgTextListElement(images[69], "Stop", "Stop playing music.");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        #endregion Sound
    
        #region System

        /// <summary>
        /// System
        /// You can perform system operations such as changing settings and saving.
        /// </summary>
        public static void MenuSystem() {
            HeaderSubtitle("System", "You can perform system operations such as changing settings and saving.");

            BeginHorizontal();
                images.Show(70);
                BeginVertical();
                    TitleText("config", "You can change display and volume settings.");
                    TitleText("option", "You can change items related to operations.");
                    TitleText("logo", "You can change the type of logo displayed on the captured image.");
                    TitleText("light", "You can change the color, strength, and orientation of the light source applied to characters, etc.");
                    TitleText("Screen effect", "You can turn on/off and adjust the effects displayed on the screen.");
                    TitleText("Save/load", "You can save and load the created scene.");
                    TitleText("Initialize/Exit", "You can initialize the scene and end the game.");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// config
        /// You can change settings related to display and volume.
        /// </summary>
        public static void MenuSystemConfig() {
            HeaderSubtitle("config", "You can change settings related to display and volume.");

            BeginHorizontal();
                images.Show(71);
                BeginVertical();
                    TitleText("1. config", "Select \"config\" to display the settings.");

                    BeginVertical(GUI.skin.box);
                        Title("2. Settings item");
                        Label("You can change display and volume settings.\n" +
                            "<i>*This setting will be shared with the main game. Please note that the changed items will be reflected in the main game.</i>");
                        TextListElement("Background color", "You can set the background color of the scene. When selectedColor panelYou can change the color with.");
                        TextListElement("Map shielding processing", "If ON puts a part of the map between the gaze point and the camera, it hides that part.\n" +
                            "<i>*Some parts cannot be hidden.</i>");
                        TextListElement("Image size", "Change texture size. If you feel that the operation is heavy, select \"1/2\" or \"1/4\".");
                        TextListElement("Audio settings", "You can adjust each volume.");
                    EndVertical();
                    Space(5);
                    Label("<i>*You can turn the display and sound ON/OFF using the checkboxes.</i>");
                    Label("<i>*You can adjust the volume with the slider. The left side is small and the right side is large.</i>");
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// option
        /// You can change items related to operations.
        /// </summary>
        public static void MenuSystemOption() {
            HeaderSubtitle("option", "You can change items related to operations.");

            BeginHorizontal();
                images.Show(72);
                BeginVertical();
                    TitleText("1. Options", "Select \"Option\" to display the settings.");

                    BeginVertical(GUI.skin.box);
                        Title("2. Settings item");
                        Label("You can make settings related to operation.\n" +
                            "<i>*Speed and size can be adjusted using the slider. The left side is slow and small, and the right side is fast and large.</i>");
                        Title("Camera settings");
                        TextListElement("├ Camera speed X axis", "You can adjust the speed when the camera rotates on the X axis (vertical rotation).");
                        TextListElement("├ Camera speed Y axis", "You can adjust the speed when the camera rotates on the Y axis (horizontal rotation).");
                        TextListElement("└ Camera movement speed", "You can adjust the speed when moving.");
                        Title("Setting the operating axis");
                        TextListElement("├ SpeedOperation shaft", "The speed when performing the movement operation can be adjusted.");
                        TextListElement("├ SizeOperation shaft", "The size can be adjusted.");
                        TextListElement("└ Snap travel width", "If you perform a movement operation while holding down the V key on your keyboard, it will move by the number you set in one movement.");
                        Title("Object settings");
                        TextListElement("├ Additional position", "The initial position when loading character items is the origin.");
                        TextListElement("│ ├ Origin", "The initial position when loading character items is the origin.");
                        TextListElement("│ └ gaze point", "Initial position when loading character itemsViewpointIt becomes.");
                        TextListElement("├ Display type", "AllOperation shaftDisplay.");
                        TextListElement("│ └ Select display", "Workspaceof the character item selected inOperation shaftShow only.");
                        TextListElement("├ Automatic display when added", "Redisplays the import menu when loading character items.");
                        TextListElement("│ ├ do", "Redisplays the import menu when loading character items.");
                        TextListElement("│ └ do not", "Hide the import menu when loading character items.");
                        TextListElement("└ Automatic selection when added", "When loading a character item, the loaded itemWorkspaceMake it the state selected in.");
                        TextListElement("  ├ do", "When loading a character item, the loaded itemWorkspaceMake it the state selected in.");
                        TextListElement("  └ do not", "Even if you load a character itemWorkspaceThe selection situation in remains unchanged.");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Character light
        /// You can change the color, strength, and orientation of the initial light source.
        /// </summary>
        public static void MenuSystemLight() {
            HeaderSubtitle("Character light", "You can change the color, strength, and orientation of the initial light source.");

            BeginHorizontal();
                images.Show(73);
                BeginVertical();
                    TitleText("1. Character light", "Select \"Character Light\" to display \"Light Controller\".");

                    BeginVertical(GUI.skin.box);
                        Title("2. controller");
                        Label("You can adjust the light source.");
                        TextListElement("Color", "When selectedColor panelYou can change the color of the light.");
                        TextListElement("Self shadow", "You can switch the display of shadows generated by lights.");
                        TextListElement("Strength", "Set the intensity of the light.");
                        TextListElement("Light vertical", "Set the vertical direction of the light.");
                        TextListElement("Light horizontal", "Set the horizontal direction of the light.");
                        Label("<i>*Strength and orientation can be adjusted using the slider.\n" +
                            "*You can adjust it by directly entering the numerical value.\n" +
                            "*If \"def\" is selected, the value will be returned to the standard value.</i>");
                    EndVertical();
                EndVertical();
            EndHorizontal();
        }

        /// <summary>
        /// Screen effect
        /// You can turn on/off and adjust the effects displayed on the screen.
        /// </summary>
        public static void MenuSystemEffect() {
            HeaderSubtitle("Screen effect", "You can turn on/off and adjust the effects displayed on the screen.");

            TitleText("1. Screen effect", "Select \"Screen Effects\" to display a list of effects.");

            BeginVertical(GUI.skin.box);
                Title("2. List of effects");
                Label("Effects can be turned on/off and adjusted.");
                TextListElement("Drawing", "Once selected, you can switch ON/OFF.");
                TextListElement("Slider", "You can adjust the strength and range with the slider.");
                TextListElement("Color", "When selectedColor panelYou can change the color with.");
            EndVertical();

            BeginHorizontal();
                images.Show(74);
                BeginVertical();
                    TitleText("color adjustment", "You can change the atmosphere of the world with \"color\".");
                    TitleText("ambient occlusion", "Change the representation of shading.");
                    TitleText("Depth of field", "Things that are far from the viewpoint of interest will now be blurred out.");
                    TitleText("Vignette settings", "Darken the screen perimeter.");
                    TitleText("Screen space reflection", "Change the \"reflection\" representation.");
                    TitleText("reflection", "You can set characters, items, and environments that will be reflected on the map.\n" +
                        "<i>*Things with higher \"texture and smoothness\" are more strongly affected.</i>");
                    TitleText("Fog", "Set fog representation.");
                    TitleText("Bloom", "You can change the settings for blurring due to light.");
                    TitleText("Sunshaft", "Set the sunlight filtering through the light. If you select \"None\" for \"Light Source\" while the item is selected, the selected item will be placed at the sunshaft light source position.\n" +
                        "<i>*If you select a character or folder and select it again, it will be canceled.</i>");
                    TitleText("Self shadow", "Enable shadow representation.");
                    TitleText("Environmental light", "You can specify the color of ambient light that affects each.\n" +
                        "<i>*The set items will be saved in the scene itself.</i>");
                    TitleText("Background sky", "Draws the specified sky.");

                    Space(5);
                    Label("<i>*The set items will be saved in the scene itself.</i>");
                EndVertical();
            EndHorizontal();

            Space(20);
            Header("Reflection samples");

            BeginHorizontal();
                TitleImage("Default", images[75]);
                Space(5);
                TitleImage("In the forest", images[76]);
                Space(5);
                TitleImage("On the cliff", images[77]);
                Space(5);
                TitleImage("Seaside", images[78]);
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("Iwaba", images[79]);
                Space(5);
                TitleImage("Snowy landscape", images[80]);
                Space(5);
                TitleImage("Warm color", images[81]);
                Space(5);
                TitleImage("In the room", images[82]);
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("A room with sunlight", images[83]);
                Space(5);
                TitleImage("A luxurious space", images[84]);
                Space(5);
                TitleImage("Blue laboratory", images[85]);
                Space(5);
                TitleImage("Red laboratory", images[86]);
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("Yellow laboratory", images[87]);
                Space(5);
                TitleImage("Spooky light", images[88]);
                Space(5);
                TitleImage("Warm light", images[89]);
                Space(5);
                TitleImage("Light from above", images[90]);
                FlexibleSpace();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                TitleImage("Lighting", images[91]);
                FlexibleSpace();
            EndHorizontal();
        }

        /// <summary>
        /// Save/load
        /// You can save and load the created scene.
        /// </summary>
        public static void MenuSystemSaveLoad() {
            HeaderSubtitle("Save/load", "You can save and load the created scene.");

            BeginHorizontal();
                images.Show(92);
                BeginVertical();
                    TitleText("1. Save", "Select \"Save\" to save the current state. Data is automatically created with date and time as file names.");
                    TitleText("2. Load", "You can load saved scene data. When selected Load screen is displayed.");
                EndVertical();
            EndHorizontal();

            Header("Load screen");

            BeginHorizontal();
                images.Show(93);
                BeginVertical();
                    TitleText("1. Scene data list", "List of saved scene data. If selected, the corresponding load confirmation screen will open.");
                    TitleText("2. [1]～ (number of pages)", "Switch the scene data list.");
                    TitleText("3. X", "Close the loading screen.");
                EndVertical();
            EndHorizontal();

            BeginHorizontal();
                images.Show(94);
                BeginVertical();
                TitleText("4. Load", "Loads the selected scene data. *Please note that the current scene will be discarded.");
                TitleText("5. Import", "Adds characters and items from the selected scene data to the current scene.");
                TitleText("6. Cancel", "It does not load selected scene data and closes the load confirmation screen.");
                TitleText("7. Delete", "Delete selected scene data. *Please note that data will be deleted from the computer itself.");
                EndVertical();
            EndHorizontal();
        }

        public static void MenuSystemClose() {
            HeaderSubtitle("Scene initialization, studio closure", "<i>	*Please note that the current scene will be discarded</i>.");

            BeginHorizontal();
                images.Show(95);
                BeginVertical();
                    TitleText("1. Initialization", "Initialize the scene");
                    TitleText("2. End", "Exit Studio.");
                EndVertical();
            EndHorizontal();
        }

        #endregion System

        #region Workspace

        public static void Workspace() {
            HeaderSubtitle("Workspace", "You can select, delete, and parent and child loaded character items. <i>*You can move the window name part using the left button drag.</i>");

            images.Show(96);

            BeginVertical(GUI.skin.box);
                Title("1. List");
                Label("This is a list of characters and items currently being loaded.");
                BeginHorizontal();
                    Label("<i>*Some items have </i>");
                    images.Show(97);
                    Label("<i>. You can switch the display of the items by selecting it.</i>");
                    FlexibleSpace();
                EndHorizontal();
            EndVertical();
            Space(5);

            BeginVertical(GUI.skin.box);
                Title("2. Function button");
                ImgTextListElement(images[98], "obj copy", "Create a duplicate of the character or item selected in the list.\n" +
                    "<i>*What is being replicated will also be replicated with the same configuration.\n" +
                    "*You can perform the same operation by holding down the \"Ctrl\" key and pressing the \"D\" key on your keyboard.</i>");
                ImgTextListElement(images[99], "Move copy", "You can select multiple when using this. Copies the location of the main selected item to the sub-selected item.");
                ImgTextListElement(images[100], "Parent", "You can select multiple when using this. It create a partent-child relationship between the selected items.");
                ImgTextListElement(images[101], "Release", "It can be used when the selected item is a child of another item. It will be released from the parent.");
                ImgTextListElement(images[102], "Delete", "Delete the item selected in the list." +
                    "<i>*Please note that if you delete it, you will not be able to return it.</i>");
                ImgTextListElement(images[103], "Create Fodler", "Create transparent item \"folders\". You can parent-child relationships with them as with regular items.\n" +
                    "<i>*The named part is displayed in yellow. The name can be changed with the Anim Menu.</i>");
                ImgTextListElement(images[104], "Camera", "Create items with limited camera functionality.\n" +
                    "<i>*The named part is displayed in blue. The name can be changed with the Anim Menu.</i>");
                ImgTextListElement(images[105], "Route", "You can set the movement route of characters and items.");
            EndVertical();

            TitleText("3. Hide Button", "Hide Workspace.");
        }

        public static void WorkspaceFolder() {
            Header("Rename Folder");

            BeginHorizontal();
                images.Show(106);
                BeginVertical();
                    TitleText("1.", "Select Folder from Workspace.");
                    TitleText("2.", "Select \"anim\" to display the \"folder name\".");
                    TitleText("3.", "it will be changed to the name you entered.");
                EndVertical();
            EndHorizontal();
        }

        public static void WorkspaceCamera() {
            HeaderSubtitle("Item Camera", "If \"Item camera\" is enabled, the view will be switched using the \"lens plane\" of \"Item camera\" as the viewpoint.");

            BeginHorizontal();
                images.Show(107);
                BeginVertical();
                    TitleText("1.", "Create an \"Item camera\".");
                    TitleText("2.", "Select camera from the Workspace.");
                    TitleText("3.", "Use Operation Shaft or Move Panel to move/rotate the camera.");
                    TitleText("4.", "Select \"anim\" to display \"Camera settings\".");
                    TitleText("5.", "Setting \"Operation\" to \"ON\" switches the vview to the \"Item Camera\" viewpoint.\n" +
                        "When in operation, the item listed in the workspace is displayed in red.\n" +
                        "<i> *While the \"Item Camera\" is running, normal \"move, rotate, expand, contract, bank, and parse\" operations cannot be performed.\n" +
                        "*While the \"Item Camera\" is running Camera registration is not available.\n" +
                        "*You can directly switch cameras from the Workspace.</i>");
                EndVertical();
            EndHorizontal();
        }

        public static void WorkspaceMultiple() {
            HeaderSubtitle("Multiple selection", "You can select multiple characters and items and operate them all at once.");

            BeginHorizontal();
                images.Show(108);
                Label("If you select the main item in the workspace and then hold down the \"Ctrl\" key on your keyboard and select another item, you can select it as a sub.\n" +
                    "Items selected as sub are the main ones \"Operation shaft\". You can operate them at the same time.\n" +
                    "<i>*If you perform a rotation operation, it will rotate on the spot around each starting point. If you want to rotate the sub around the main item, create a parent-child relationship and rotate the parent.\n" +
                    "It will be canceled if you select other items again.</i>");
                FlexibleSpace();
            EndHorizontal();

            Space(5);

            Title("Below is an example opf making \"Lamp\" in the main selection.");
            Space(5);
            BeginHorizontal();
                TitleImage("1. Workspace\"lamp\" selection (main selection)", images[109]);
                Space(5);
                TitleImage("2. \"Plural selection\" (sub-selection) for \"Phonograph\"", images[110]);
                FlexibleSpace();
            EndHorizontal();
            BeginHorizontal();
                TitleImage("<i>*If rotation is performed, each item will be rotated around their starting point.</i>", images[111]);
                FlexibleSpace();
            EndHorizontal();
        }

        public static void WorkspaceRange() {
            Header("Range selection");

            BeginHorizontal();
                images.Show(112);
                Label("If you select the main item and then hold down the \"Shift\" key on your keyboard and select another item, you can select all the items in between as subs.");
                FlexibleSpace();
            EndHorizontal();

            Space(5);
            BeginHorizontal();
                TitleImage("1. Select the main item in your workspace", images[113]);
                Space(5);
                TitleImage("2. \"Range Select\" another item", images[114]);
                FlexibleSpace();
            EndHorizontal();
            BeginHorizontal();
                TitleImage("3. The items in between will be selected", images[115]);
                FlexibleSpace();
            EndHorizontal();
        }

        public static void WorkspaceCopy() {
            HeaderSubtitle("Copy location information", "You can copy the location and orientation information of the selected character or item to other characters or items.");

            Label("After selecting the main and sub using \"Multiple Selection\", select \"move copy\" to copy the main position and orientation information to the sub.");
            Label("<i>*You can use Keyboard shortcuts. After selecting the main one, press the \"Ctrl\" and \"x\" key while selecting the sub-MenuAnimItemSettings to copy the location.</i>");

            Space(5);
            Label("Below is an example of copying the location information of \"wooden chair\" to another character and item.");
            BeginHorizontal();
                TitleImage("1. Select \"Wooden Chair\" in the workspace (main selection)", images[116]);
                Space(5);
                TitleImage("2. Select multiple other items (sub-selection)", images[117]);
                FlexibleSpace();
            EndHorizontal();
            BeginHorizontal();
                TitleImage("3. Select \"Move copy\" to copy the location information", images[118]);
                FlexibleSpace();
            EndHorizontal();
        }

        public static void WorkspaceRelation() {
            HeaderSubtitle("Parent-child relationship", "When you add \"parent and child\", when you move the \"parent\" character or item, the character or item set as \"child\" will automatically move according to the \"parent\".");
            Label("Example: If you place \"earrings\" in your ears and \"parent-child attachment\" on your \"head\", the \"earrings\" will remain in your ears even if you move or dance your character.\n" +
                "<i>*When using a character as a parent, only items marked as \"parts\" are allowed.\n" +
                "*Please note that if you delete the \"parent\" character or item, the item set as \"child\" will also be deleted.</i>");
        }

        public static void WorkspaceRelationButton() {
            Header("This is an example of using \"cuby head\" as a child to \"head\" as a parent using the \"Parent\" button.");

            BeginHorizontal();
                images.Show(119);
                BeginVertical();
                    TitleText("1.", "Select \"Cubyhead\" in the workspace");
                    TitleText("2.", "Use \"Operation shaft\" or \"Move panel\" to move the \"Cubyhead\"");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(120);
                BeginVertical();
                    TitleText("3.", "Select \"▶\" next to the character name to display the group list. *Select \"▼\" to close.");
                    TitleText("4.", "Select \"▶\" for the group to display a list of sites. *Select \"▼\" to close.");
                    TitleText("5.", "Select \"Part: Head\" to be \"Parent\".");
                    TitleText("6.", "Hold down the \"Ctrl\" key on your keyboard and select \"Cuby Head\".");
                    TitleText("7.", "Select the \"Parent\" Button.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(121);
                BeginVertical();
                    TitleText("8.", "A \"cuby head\" is stored in the \"part: head\", and even if the pose is changed, the \"cuby head\" moves automatically according to the movement of the \"part: head\".\n" +
                        "<i>*If items are parent-child, the \"child\" item will be stored in the \"parent\" item.</i>");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);
            BeginHorizontal();
                images.Show(122);
                BeginVertical();
                    TitleText("9.", "Select \"Cuby Head\" where \"Location: Head Center\" is stored.");
                    TitleText("10.", "Select the \"Release\" button to remove the parentage.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
        }

        public static void WorkspaceRelationKey() {
            Header("This is an example of using \"cuby head\" as a child to \"head\" as a parent using the keyboard shortcut.");

            BeginHorizontal();
                images.Show(123);
                BeginVertical();
                    TitleText("1.", "Select \"Cubyhead\" in the workspace");
                    TitleText("2.", "Use \"Operation shaft\" or \"Move panel\" to move the \"Cubyhead\"");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(124);
                BeginVertical();
                    TitleText("3.", "Select \"▶\" next to the character name to display the group list. *Select \"▼\" to close.");
                    TitleText("4.", "Select \"▶\" for the group to display a list of sites. *Select \"▼\" to close.");
                    TitleText("5.", "Select \"Part: Head\" to be \"Parent\".");
                    TitleText("6.", "Hold down the \"P\" key on your keyboard and select \"Part: Head\".");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
            Space(5);
            BeginHorizontal();
                images.Show(125);
                BeginVertical();
                    TitleText("7.", "A \"cuby head\" is stored in the \"part: head\", and even if the pose is changed, the \"cuby head\" moves automatically according to the movement of the \"part: head\".\n" +
                        "<i>*If items are parent-child, the \"child\" item will be stored in the \"parent\" item.</i>");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);
            BeginHorizontal();
                images.Show(126);
                BeginVertical();
                    TitleText("8.", "Parentage is canceled by holding down the \"O (letter O)\" key on the keyboard and selecting \"Cuby head\" where \"Part:head\" is stored.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
        }

        public static void WorkspaceRoute() {
            HeaderSubtitle("Route movement", "You can set the route (movement route) of characters and items. When you set a route, characters and items with parent and child will move based on the route.");
            Header("Route movement screen description");

            BeginVertical();
                images.Show(127);
                images.Show(128);
                images.Show(129);
                images.Show(130);
            EndVertical();

            TitleText("1. Create route button", "Create a \"root\".\n" +
                "A \"root\" folder is created with \"child connection destination\" andf \"start\" attached to the workspace.");

            BeginVertical(GUI.skin.box);
                Title("2. Route created");
                Label("At the time of creation, only \"child connection destination\" and \"start\" are created, but when \"point\" is added, it will be created under \"start\".\n" +
                    "<i>*Parenthood of \"child connection destination\", \"start\", and \"point\" cannot be canceled.</i>");
                TextListElement("Child connection destination", "If it does, it chooses this as its parent.\n" +
                    "<i>*\"Start\" and \"Points\" cannot be set for the parent.</i>");
                TextListElement("Start", "This is the starting point for movement. *It will be displayed as \"S\" on the view.\n" +
                    "<i>*Individual movements are not possible, so when moving, you will need to move the \"routes\" all at once.</i>");
                TextListElement("Point", "This is the destination from the start. Move in the order of the displayed numbers.\n" +
                    "<i>*Up to 10 \"points\" can be added. \"Line\" is created automatically.</i>");    
            EndVertical();
            
            Space(5);

            BeginVertical(GUI.skin.box);
                Title("3. Route settings");
                Label("You can configure settings for the entire \"route\" selected in \"Workspace\".");
                TextListElement("Name", "You can rename \"Route\".");
                TextListElement("Addition", "Add a point to the \"root\". *Up to 10 \"points\" can be added.");
                TextListElement("Orientation correction", "Orientation correction can be set when playing the \"root\".");
                TextListElement("├ None", "Does not correct orientation.");
                TextListElement("├ XY", "When played, it will now point to the next point, and angle correction will also be included.");
                TextListElement("└ Y", "When played, it will face the next point.\n" +
                    "*When setting \"XY\" and \"Y\", we recommend initializing the rotation of the target character or item.");
                TextListElement("loop", "");
                TextListElement("├ ON", "A line connects the \"start\" and the last \"point\", and movement loops.");
                TextListElement("└ OFF", "If it moves to the last \"point\" position, it will stop there.");
                TextListElement("Line drawing", "Toggles the display ON/OFF of \"Line\". *The movement will continue even if it is \"OFF\".");
                TextListElement("Line color", "You can change the color of the \"line\".");
            EndVertical();

            Space(5);

            BeginVertical(GUI.skin.box);
                Title("4. Route point settings");
                Label("Displayed when \"Start\" or \"Point\" is selected in \"Workspace\".\n" +
                    "You can set the behavior from the selected item to the next \"point\".");
                TextListElement("Speed", "Adjust movement speed between \"0.1～30.0\". The smaller the number, the slower it is, and the larger the number, the faster it is.");
                TextListElement("Behaviour", "Select the behavior when moving.");
                TextListElement("Shape", "You can set the shape of the \"line\".");
                TextListElement("├ straight line", "Create a \"line\" with a straight line to the next point.");
                TextListElement("└ Curve", "An \"operation target\" appears on the \"line\" and changes to the \"operation axis\" when selected.\n" +
                    "When the operation axis is moved, the \"line\" changes to the curve with the operation axis as the vertex.\n" +
                    "Valid if the \"point\" before the currently selected \"point\" is \"Shape: Curve\" selected.");
                TextListElement("Connection", "Corrects the \"line\" that connects the \"points\" into a smooth curve.");
            EndVertical();

            Space(5);

            BeginVertical(GUI.skin.box);
                Title("5. Route controller");
                Label("The \"Route\" in the \"Workspace\" will be displayed in the \"Route List\". You can control the playback of each \"route\".\n" +
                    "<i>*Settings cannot be changed for \"route\" during playback. *If \"stopped\", it will return to its initial position.</i>");
                ImgTextListElement(images[131], "Playback", "It will be displayed to the right of the stopped \"route\". Play Root when selected.");
                ImgTextListElement(images[132], "Stop", "It will be displayed to the right of the \"root\" that is playing. Stop \"root\" if selected.");
                ImgTextListElement(images[133], "Stop (end)", "Displayed when the \"root\" set to \"Loop: OFF\" moves to the last \"point\" position.");
                ImgTextListElement(images[134], "Full playback", "Plays all stopped \"roots\". *Does not affect the \"root\" being played.");
                ImgTextListElement(images[135], "Synchronous playback", "Plays all \"roots\" from the beginning, whether playing or stopping.");
                ImgTextListElement(images[136], "Total stop", "Stop all \"routes\".");
            EndVertical();
        }

        public static void WorkspaceRouteExample() {
            HeaderSubtitle("Example of route movement", "<i>*This is an example of creating a scene where you climb stairs and turn.</i>");

            BeginHorizontal();
                images.Show(137);
                BeginVertical();
                    TitleText("1.", "Select \"Route\" in Workspace.");
                    TitleText("2.", "A \"root\" will be created, so select \"Route\".");
                    TitleText("3.", "Move it with \"Operation shaft\" or \"Move Panel\" to determine the starting point.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(138);
                BeginVertical();
                    TitleText("4.", "Select \"anim\" to display a menu for route movement.");
                    TitleText("5.", "Select \"Add:add\" under \"Route Settings\".");
                    TitleText("6.", "A new \"point\" will be added under \"Route\" → \"Start\" in \"Workspace\", so select this.");
                    TitleText("7.", "Move \"Point\".");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(139);
                TitleText("8.", "Create a route by repeating (5.)～(7.).");
                    FlexibleSpace();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(140);
                BeginVertical();
                    TitleText("9.", "Curve the route for turns. In the example, the corner will be entered from \"Point 1\", so select \"Workspace\" → \"Route\" → \"Point 1\".");
                    TitleText("10.", "Select \"Shape: Curve\" from \"Route Point Settings\".");
                    TitleText("11.", "\"Operation target\" will be displayed on \"Line\", so select it.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(141);
                BeginVertical();
                    TitleText("12.", "The \"operation target\" changes to the \"operation axis\", so if you move it, it will change to a curve with the \"operation axis\" as the vertex.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(142);
                BeginVertical();
                    TitleText("13.", "<i>*In preparation, \"Loading characters\" → \"Anime changeDo\".\n" +
                        "Select \"Child connection destination\" under \"Route\".</i>");
                    TitleText("14.", "Hold down the \"Ctrl\" key on your keyboard and select \"Character\".");
                    TitleText("15.", "Use \"Parent-Child relationship\" by pressing the \"Parent\" button.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();

            Space(5);

            BeginHorizontal();
                images.Show(143);
                BeginVertical();
                    TitleText("16.", "If this is the case, it will continue backwards, so select \"Orientation correction:Y\" from \"Root settings\".");
                    TitleText("17.", "If you select \"Play\" from the \"Route Controller\", the character will move based on the route you set.");
                    FlexibleSpace();
                EndVertical();
            EndHorizontal();
        }

        #endregion Workspace

        #region HScene

        public static void HScene() {
            Header("How to make an H scene");
            Header("This is an example procedure for a scene in which \"missionary position\" is performed.");

            BeginHorizontal();
                BeginVertical(GUI.skin.box);
                    Title("1. Character loading and anime selection");
                    images.Show(144);
                    Label("Select the position in \"Missionary\" → \"Strong piston\" animation.");
                EndVertical();

                Space(5);

                BeginVertical(GUI.skin.box);
                    Title("2. Copy and align location information");
                    images.Show(145);
                    Label("Choose female characters as the main character. Align with \"Location copy\".");
                EndVertical();
                FlexibleSpace();
            EndHorizontal();

            BeginHorizontal();
                BeginVertical(GUI.skin.box);
                    Title("3. Animation sync");
                    images.Show(146);
                    Label("Since the timing is off, select male and female characters using \"Multiple selection\" to synchronize the animation by selecting \"Re\" in the \"Animation controller\".");
                EndVertical();
                FlexibleSpace();
            EndHorizontal();

            Space(20);

            Header("Auxiliary functions");

            BeginHorizontal(GUI.skin.box);
                TitleImage("If your waist height or grip position does not match.", images[147]);
                Space(5);
                TitleImage("Adjust with animation controller \"Auxiliary 1\"", images[148]);
                FlexibleSpace();
            EndHorizontal();

            BeginHorizontal(GUI.skin.box);
                TitleImage("If the position of your hands does not match due to H using your chest.", images[149]);
                Space(5);
                TitleImage("Adjust with animation controller \"Auxiliary 2\"", images[150]);
                FlexibleSpace();
            EndHorizontal();
        }

        #endregion HScene

    }

}
