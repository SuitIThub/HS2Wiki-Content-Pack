using UnityEngine;
using HS2Wiki_Content;

namespace docs
{
    public class VNGE
    {
        private const int IMAGE_COUNT = 3;
        private static CustomTexture[] images;

        public static void Init() {
            images = new CustomTexture[IMAGE_COUNT];
            for (int i = 0; i < IMAGE_COUNT; i++) {
                images[i] = new CustomTexture("VNGE/" + (i + 1) + ".png");
            }

            WikiContent.RegisterWikiPage("VNGE", "Installation", Installation);
            WikiContent.RegisterWikiPage("VNGE", "Troubleshooting", Troubleshooting);
            WikiContent.RegisterWikiPage("VNGE", "Bugs", Bugs);
        }   

        public static void Installation() {
            GUILayout.Label("<size=30>VNGE Installation</size>");
            GUILayout.Label("<size=20><b>To install:</b></size>");
            GUILayout.Label("    1. Download corresponding archive (KK, AI, HS2 etc. from Mega folder)\n" +
                "    2. Unpack it to game root folder\n" +
                "    3. Run Studio. If you correctly installed you'll see VNGE button in toolbar. Press it to start.");

            images.Show(0);

            GUILayout.Space(10);
        }
    
        public static void Troubleshooting() {
            GUILayout.Label("<size=30>VNGE Troubleshooting</size>");
            GUILayout.Label("<size=20>(Installation) After Studio run I don't see VNGE window / VNGE toolbar button." +
                "(KK,AI,HS2,PH) In Bep5 config window there are UnityConsole plugin.</size>");
            GUILayout.Label("Seems window doesn't load, and plugin can't read Config.ini.\n\n" +
                "Check there is ONLY LATIN LETTERS in game path. No spaces, punctuation, and another alphabets.");
        
            GUILayout.Space(10);

            GUILayout.Label("<size=20>Other troubleshooting</size>");
            GUILayout.Label("If you experience other problem or errors, please, toggle on Console to see detailed information.\n\n" +
                "To toggle on change settings:");

            images.Show(1);

            GUILayout.Label("or\n" +
                "    1. In Console/Lib/vngameengine.ini:\n" +
                "       a. HideConsoleAfterStart=0\n" +
                "   2. In Console/Console.ini\n" +
                "       a. ShowAtStartup=1\n\n" +
                "After start you must see something like this:");

            images.Show(2);

            GUILayout.Label("Additional error information will be shown in Console.");

        }

        public static void Bugs() {
            GUILayout.Label("<size=30>VNGE Bugs</size>");
            GUILayout.Label("<size=20>(HS2, may be all engines) I can't use any letters or symbols like ñ or á, é, etc. in VN texts (Polish/Spanish symbols etc.) - data doesn't saved.</size>");
            GUILayout.Label("Sorry, known problem. Try to avoid such symbols.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(HS2, AI, KK) Saving clothes with ExportChara_CurClothesCoord=1 stop work after studio restart - old saved clothes just disappeared.</size>");
            GUILayout.Label("Sorry, well-known problem with clothes from Sideloader zipmods. Sideloader changes ID every restart (instead of keep them like native clothes), so VNGE can't load it next time.\n\n" +
                "Only way: try to avoid tracking clothes, use several similar characters with different clothes instead.\n\n" +
                "Clothes in HS/PH with hardmods must work correct.");
            GUILayout.Label("<size=20>(KK,AI) Message during Studio start “Plugin [UnityConsole] targets a wrong version of BepInEx (3.2.0.0) and might not work until you update”</size>");
            GUILayout.Label("Update to latest version - this is fixed.\n\n" +
                "Or just ignore this warning. All must work (in this case)");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(KK,AI) If load scene using VN Scenes or at other Python game/mod, map seems to be moved</size>");
            GUILayout.Label("Internal load_scene call load scene, but it seems not correct loading Pos and Rot of scene due to Studio limitations, and set it back to 0,0.\n\n" +
                "So, please, don't make scenes to load in games with adjusted maps.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(PH) Neck position isn't saved in Fixed state</size>");
            GUILayout.Label("Sorry, known problem.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(All engines) Eyes position isn't saved in Fixed state</size>");
            GUILayout.Label("Sorry, known problem.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(AI, KK) During save/load/copy/paste clothes with VNGE functions, Overlays is skipped/don't load.</size>");
            GUILayout.Label("Sorry, known problem.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(All engines) KKPE/AIPE/HSPE plugins advanced params not saved</size>");
            GUILayout.Label("Sorry, known problem.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(KK,HS) NodesConstraints plugin saves fail to load.</size>");
            GUILayout.Label("Please, upgrade to NodesConstraints 1.2.0 and above. VNGE will work only with higher versions.");

            GUILayout.Space(10);

            GUILayout.Label("<size=20>(HS, may be all engines) If make a lot of scenes in SSS, seems to be microfreezes and lower FPS</size>");
            GUILayout.Label("It depends not on scenes, but on saving in folders. Multiple folders affect negatively on HS Studio NEO performance.\n\n" +
                "Try to save SSS scenes in file; save in folders only if you wanna share scene to others.\n\n" +
                "Or use VNGE 30.0+ - it saves SSS and VN data just in PNG file, not in folders.");

        }
    }

}
