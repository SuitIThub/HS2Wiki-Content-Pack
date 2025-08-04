using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using docs;
using KKAPI;
using KKAPI.Utilities;
using UnityEngine;

namespace HS2Wiki_Content;

[BepInPlugin("com.suit.hs2wiki_content", "HS2 Wiki - Content Pack", "1.0.0")]
[BepInDependency("com.suit.hs2wiki", BepInDependency.DependencyFlags.HardDependency)]
public class WikiContent : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        StudioNeo.Init();
        BetterPenetration.Init();
        VNGE.Init();
    }

    public static void RegisterWikiPage(string category, string pageName, Action drawPageAction)
    {
        Type wikiPluginType = Type.GetType("HS2Wiki.WikiPlugin, HS2Wiki");
        if (wikiPluginType == null)
        {
            Logger.LogWarning("Wiki plugin not found - registration skipped.");
            return;
        }

        // Try to find the PublicAPI field
        FieldInfo apiField = wikiPluginType.GetField("PublicAPI", BindingFlags.Public | BindingFlags.Static);
        if (apiField == null)
        {
            Logger.LogWarning("Wiki API field not found - registration skipped.");
            return;
        }

        object apiInstance = apiField.GetValue(null);
        if (apiInstance == null)
        {
            Logger.LogWarning("Wiki API is null - registration skipped.");
            return;
        }

        // Try to find the RegisterPage method
        MethodInfo registerPageMethod = apiInstance.GetType().GetMethod("RegisterPage", new[] {
            typeof(string), typeof(string), typeof(Action)
        });

        if (registerPageMethod == null)
        {
            Logger.LogWarning("RegisterPage method not found.");
            return;
        }

        // Call up RegisterPage
        registerPageMethod.Invoke(apiInstance, new object[] {
            category,
            pageName,
            drawPageAction
        });

        Logger.LogInfo("Page successfully registered with the wiki.");
    }
}