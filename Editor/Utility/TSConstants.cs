// This file is a collection of constant values used around

using UnityEngine;
using UnityEditor;

namespace Cibbi.ToonyStandard
{
    public static class TSConstants
    {
        public static string Version = "Toony Standard Master Build 20190511";
        public static string LocalShaderFolder;
        public static string LocalShaderAssetsFolder;
        public static string localJSONPath;
        public static string settingsJSONPath;
        public static string oldSettingsJSONPath;

        public static string TSEPInspectorLevel = "TSInspectorLevel";
        public static string TSEPNotFirstTime = "TSNotFirstTime";
        
        public static Texture2D deleteIcon;
        public static Texture2D logo;
        public static Texture2D githubIcon;
        public static Texture2D patreonIcon;
        public static Texture2D defaultRamp;

        public static void InitializeFolderReferences(string assetsPath)
        {
            string path=Application.dataPath+assetsPath.Substring(assetsPath.IndexOf("/"));

            LocalShaderFolder=path;
            LocalShaderAssetsFolder = assetsPath;
            localJSONPath = path + "/version.json";
            settingsJSONPath = path + "/Editor/settings.json";
            oldSettingsJSONPath =path + "/Editor/oldSettings.json";
        
            deleteIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(assetsPath + "/Editor/Resources/DeleteIcon.png");
            logo = AssetDatabase.LoadAssetAtPath<Texture2D>(assetsPath + "/Editor/Resources/ToonyStandardLogo.png");
            githubIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(assetsPath + "/Editor/Resources/GitHubIcon.png");
            patreonIcon = AssetDatabase.LoadAssetAtPath<Texture2D>(assetsPath + "/Editor/Resources/PatreonIcon.png");
            defaultRamp = AssetDatabase.LoadAssetAtPath<Texture2D>(assetsPath + "/Editor/Resources/RampDefault.png");
        }

        public static class TSWindowLabels
        {
            public static GUIContent InspectorLevel = new GUIContent("Inspector level", "Sets the level of features the shader is able to expose \n\nBasic: only basic stuff for new users \n\nNormal: the standard feature sets intended for this shader \n\nExpert: allows access to features meant for experienced users");
            public static GUIContent UpdateStream = new GUIContent("Update stream", "Selects which stream of updates the updater has to look for \n\nRelease: will check the official releases \n\nBeta: will check beta releases");
            public static GUIContent SectionStyle = new GUIContent("Section style", "Selects the appearance of the inspector \n\nBubbles: bubble looking sections \n\nBox: Sections will have A boxed header \n\nFoldoud: simplistic unity-like look");
            public static GUIContent Color = new GUIContent("Color", "Color of the section (may affects different things based on the style)");
            public static GUIContent DisableAutoUpdates = new GUIContent("Disable auto updates", "Disables auto update checks on startup, you can still update manually with the updater");	
        }


        public static class Styles
        {
             private static GUIStyle deleteStyleLocal;
            public static GUIStyle deleteStyle
            {
                get
                {
                    if(deleteStyleLocal==null)
                    {
                        deleteStyleLocal=new GUIStyle();
                        deleteStyleLocal.normal.background=TSConstants.deleteIcon;
                    }
                    return deleteStyleLocal;
                }
            }

            private static GUIStyle sectionTitleCenterLocal;
            public static GUIStyle sectionTitleCenter
            {
                get
                {
                    if(sectionTitleCenterLocal==null)
                    {
                        sectionTitleCenterLocal=new GUIStyle(EditorStyles.boldLabel);
                        sectionTitleCenterLocal.alignment = TextAnchor.MiddleCenter;
                    }
                    return sectionTitleCenterLocal;
                }
            }

            private static GUIStyle sectionTitleLocal;
            public static GUIStyle sectionTitle
            { 
                get
                {
                    if(sectionTitleLocal==null)
                    {
                        sectionTitleLocal=new GUIStyle(EditorStyles.boldLabel);
                        sectionTitleLocal.alignment = TextAnchor.MiddleLeft;
                    }
                    return sectionTitleLocal;
                }
            }

            private static GUIStyle centerLabelLocal;
            public static GUIStyle centerLabel
            {
                get
                {
                    if(centerLabelLocal==null)
                    {
                        centerLabelLocal=new GUIStyle(EditorStyles.label);
                        centerLabelLocal.alignment = TextAnchor.MiddleCenter;
                    }
                    return centerLabelLocal;
                }
            }

            private static GUIStyle multilineLabelCenterLocal;
            public static GUIStyle multilineLabelCenter
            {
                get
                {
                    if(multilineLabelCenterLocal==null)
                    {
                        multilineLabelCenterLocal=new GUIStyle(EditorStyles.label);
                        multilineLabelCenterLocal.alignment = TextAnchor.MiddleCenter;
                        multilineLabelCenterLocal.wordWrap=true;
                    }
                    return multilineLabelCenterLocal;
                }
            }

            private static GUIStyle multilineLabelLocal;
            public static GUIStyle multilineLabel
            {
                get
                {
                    if(multilineLabelLocal==null)
                    {
                        multilineLabelLocal=new GUIStyle(EditorStyles.label);
                        multilineLabelLocal.wordWrap=true;
                    }
                    return multilineLabelLocal;
                }
            }
        }

       
    }
}