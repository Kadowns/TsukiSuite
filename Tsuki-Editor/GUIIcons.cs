using System;
using UnityEditor;
using UnityEngine;

namespace Lunari.Tsuki.Editor {
    public static class GUIIcons {
        public static Texture GetIcon(string key) {
            return EditorGUIUtility.IconContent(key).image;
        }

        public static Texture FindUnityIcon(this Type type, string defaultIcon = dll_Script_Icon) {
            var tex = EditorGUIUtility.ObjectContent(null, type).image;
            if (tex == null) {
                tex = EditorGUIUtility.IconContent(defaultIcon).image;
            }

            return tex;
        }

        public const string ScriptableObject_Icon = "ScriptableObject Icon";
        public const string Clipboard = "Clipboard";
        public const string SocialNetworks_UDNOpen = "SocialNetworks.UDNOpen";
        public const string SocialNetworks_Tweet = "SocialNetworks.Tweet";
        public const string SocialNetworks_FacebookShare = "SocialNetworks.FacebookShare";
        public const string SocialNetworks_LinkedInShare = "SocialNetworks.LinkedInShare";
        public const string SocialNetworks_UDNLogo = "SocialNetworks.UDNLogo";
        public const string animationvisibilitytoggleoff = "animationvisibilitytoggleoff";
        public const string animationvisibilitytoggleon = "animationvisibilitytoggleon";
        public const string tree_icon = "tree_icon";
        public const string tree_icon_leaf = "tree_icon_leaf";
        public const string tree_icon_frond = "tree_icon_frond";
        public const string tree_icon_branch = "tree_icon_branch";
        public const string tree_icon_branch_frond = "tree_icon_branch_frond";
        public const string editicon_sml = "editicon.sml";
        public const string TreeEditor_Refresh = "TreeEditor.Refresh";
        public const string TreeEditor_Duplicate = "TreeEditor.Duplicate";
        public const string TreeEditor_Trash = "TreeEditor.Trash";
        public const string TreeEditor_AddBranches = "TreeEditor.AddBranches";
        public const string TreeEditor_AddLeaves = "TreeEditor.AddLeaves";
        public const string RightFingersIk = "RightFingersIk";
        public const string LeftFingersIk = "LeftFingersIk";
        public const string RightFeetIk = "RightFeetIk";
        public const string LeftFeetIk = "LeftFeetIk";
        public const string MaskEditor_Root = "MaskEditor_Root";
        public const string BodyPartPicker = "BodyPartPicker";
        public const string BodySIlhouette = "BodySIlhouette";
        public const string Mirror = "Mirror";
        public const string Toolbar_Minus = "Toolbar Minus";
        public const string Toolbar_Plus_More = "Toolbar Plus More";
        public const string Toolbar_Plus = "Toolbar Plus";
        public const string AnimatorController_Icon = "AnimatorController Icon";
        public const string TextAsset_Icon = "TextAsset Icon";
        public const string Shader_Icon = "Shader Icon";
        public const string boo_Script_Icon = "boo Script Icon";
        public const string dll_Script_Icon = "dll Script Icon";
        public const string cs_Script_Icon = "cs Script Icon";
        public const string js_Script_Icon = "js Script Icon";
        public const string Prefab_Icon = "Prefab Icon";
        public const string Profiler_NextFrame = "Profiler.NextFrame";
        public const string Profiler_PrevFrame = "Profiler.PrevFrame";
        public const string ColorPicker_CycleSlider = "ColorPicker.CycleSlider";
        public const string ColorPicker_CycleColor = "ColorPicker.CycleColor";
        public const string EyeDropper_Large = "EyeDropper.Large";
        public const string ClothInspector_PaintValue = "ClothInspector.PaintValue";
        public const string ClothInspector_ViewValue = "ClothInspector.ViewValue";
        public const string ClothInspector_SettingsTool = "ClothInspector.SettingsTool";
        public const string ClothInspector_PaintTool = "ClothInspector.PaintTool";
        public const string ClothInspector_SelectTool = "ClothInspector.SelectTool";
        public const string WelcomeScreen_AssetStoreLogo = "WelcomeScreen.AssetStoreLogo";
        public const string AboutWindow_MainHeader = "AboutWindow.MainHeader";
        public const string AgeiaLogo = "AgeiaLogo";
        public const string MonoLogo = "MonoLogo";
        public const string PlayButtonProfile_Anim = "PlayButtonProfile Anim";
        public const string StepButton_Anim = "StepButton Anim";
        public const string PauseButton_Anim = "PauseButton Anim";
        public const string PlayButton_Anim = "PlayButton Anim";
        public const string PlayButtonProfile_On = "PlayButtonProfile On";
        public const string StepButton_On = "StepButton On";
        public const string PauseButton_On = "PauseButton On";
        public const string PlayButton_On = "PlayButton On";
        public const string PlayButtonProfile = "PlayButtonProfile";
        public const string StepButton = "StepButton";
        public const string ViewToolOrbit_On = "ViewToolOrbit On";
        public const string ViewToolZoom_On = "ViewToolZoom On";
        public const string ViewToolMove_On = "ViewToolMove On";
        public const string ViewToolZoom = "ViewToolZoom";
        public const string ViewToolMove = "ViewToolMove";
        public const string ViewToolOrbit = "ViewToolOrbit";
        public const string ScaleTool_On = "ScaleTool On";
        public const string RotateTool_On = "RotateTool On";
        public const string MoveTool_On = "MoveTool On";
        public const string ScaleTool = "ScaleTool";
        public const string RotateTool = "RotateTool";
        public const string MoveTool = "MoveTool";
        public const string _Help = "_Help";
        public const string _Popup = "_Popup";
        public const string Icon_Dropdown = "Icon Dropdown";
        public const string Avatar_Icon = "Avatar Icon";
        public const string AvatarPivot = "AvatarPivot";
        public const string SpeedScale = "SpeedScale";
        public const string DotSelection = "DotSelection";
        public const string DotFrameDotted = "DotFrameDotted";
        public const string DotFrame = "DotFrame";
        public const string DotFill = "DotFill";
        public const string RightHandZoom = "RightHandZoom";
        public const string LeftHandZoom = "LeftHandZoom";
        public const string HeadZoom = "HeadZoom";
        public const string RightLeg = "RightLeg";
        public const string LeftLeg = "LeftLeg";
        public const string RightFingers = "RightFingers";
        public const string RightArm = "RightArm";
        public const string LeftFingers = "LeftFingers";
        public const string LeftArm = "LeftArm";
        public const string Head = "Head";
        public const string Torso = "Torso";
        public const string RightHandZoomSilhouette = "RightHandZoomSilhouette";
        public const string LeftHandZoomSilhouette = "LeftHandZoomSilhouette";
        public const string HeadZoomSilhouette = "HeadZoomSilhouette";
        public const string AvatarInspector = "AvatarInspector";
        public const string BodySilhouette = "BodySilhouette";
        public const string Animation_AddKeyframe = "Animation.AddKeyframe";
        public const string Animation_NextKey = "Animation.NextKey";
        public const string Animation_PrevKey = "Animation.PrevKey";
        public const string redLight = "redLight";
        public const string orangeLight = "orangeLight";
        public const string lightRim = "lightRim";
        public const string greenLight = "greenLight";
        public const string Animation_AddEvent = "Animation.AddEvent";
        public const string SceneviewAudio = "SceneviewAudio";
        public const string SceneviewLighting = "SceneviewLighting";
        public const string MeshRenderer_Icon = "MeshRenderer Icon";
        public const string Terrain_Icon = "Terrain Icon";
        public const string BuildSettings_SelectedIcon = "BuildSettings.SelectedIcon";
        public const string Animation_Record = "Animation.Record";
        public const string Animation_Play = "Animation.Play";
        public const string TerrainInspector_TerrainToolSettings = "TerrainInspector.TerrainToolSettings";
        public const string TerrainInspector_TerrainToolPlants = "TerrainInspector.TerrainToolPlants";
        public const string TerrainInspector_TerrainToolTrees = "TerrainInspector.TerrainToolTrees";
        public const string TerrainInspector_TerrainToolSplat = "TerrainInspector.TerrainToolSplat";
        public const string TerrainInspector_TerrainToolSmoothHeight = "TerrainInspector.TerrainToolSmoothHeight";
        public const string TerrainInspector_TerrainToolSetHeight = "TerrainInspector.TerrainToolSetHeight";
        public const string TerrainInspector_TerrainToolRaise = "TerrainInspector.TerrainToolRaise";
        public const string SettingsIcon = "SettingsIcon";
        public const string PauseButton = "PauseButton";
        public const string PlayButton = "PlayButton";
        public const string Camera_Icon = "Camera Icon";
        public const string Animation_EventMarker = "Animation.EventMarker";
        public const string AS_Badge_New = "AS Badge New";
        public const string AS_Badge_Move = "AS Badge Move";
        public const string AS_Badge_Delete = "AS Badge Delete";
        public const string WaitSpin00 = "WaitSpin00";
        public const string WaitSpin01 = "WaitSpin01";
        public const string WaitSpin02 = "WaitSpin02";
        public const string WaitSpin03 = "WaitSpin03";
        public const string WaitSpin04 = "WaitSpin04";
        public const string WaitSpin05 = "WaitSpin05";
        public const string WaitSpin06 = "WaitSpin06";
        public const string WaitSpin07 = "WaitSpin07";
        public const string WaitSpin08 = "WaitSpin08";
        public const string WaitSpin09 = "WaitSpin09";
        public const string WaitSpin10 = "WaitSpin10";
        public const string WaitSpin11 = "WaitSpin11";
        public const string WelcomeScreen_UnityAnswersLogo = "WelcomeScreen.UnityAnswersLogo";
        public const string WelcomeScreen_UnityForumLogo = "WelcomeScreen.UnityForumLogo";
        public const string WelcomeScreen_UnityBasicsLogo = "WelcomeScreen.UnityBasicsLogo";
        public const string WelcomeScreen_VideoTutLogo = "WelcomeScreen.VideoTutLogo";
        public const string WelcomeScreen_MainHeader = "WelcomeScreen.MainHeader";
        public const string UnityLogo = "UnityLogo";
        public const string PreMatLight1 = "PreMatLight1";
        public const string PreMatLight0 = "PreMatLight0";
        public const string PreMatTorus = "PreMatTorus";
        public const string PreMatCylinder = "PreMatCylinder";
        public const string PreMatCube = "PreMatCube";
        public const string PreMatSphere = "PreMatSphere";
        public const string PreTextureMipMapHigh = "PreTextureMipMapHigh";
        public const string PreTextureMipMapLow = "PreTextureMipMapLow";
        public const string PreTextureRGB = "PreTextureRGB";
        public const string PreTextureAlpha = "PreTextureAlpha";
        public const string VerticalSplit = "VerticalSplit";
        public const string HorizontalSplit = "HorizontalSplit";
        public const string PrefabNormal_Icon = "PrefabNormal Icon";
        public const string PrefabModel_Icon = "PrefabModel Icon";
        public const string GameObject_Icon = "GameObject Icon";
        public const string preAudioLoopOn = "preAudioLoopOn";
        public const string preAudioLoopOff = "preAudioLoopOff";
        public const string preAudioPlayOn = "preAudioPlayOn";
        public const string preAudioPlayOff = "preAudioPlayOff";
        public const string preAudioAutoPlayOn = "preAudioAutoPlayOn";
        public const string preAudioAutoPlayOff = "preAudioAutoPlayOff";
        public const string BuildSettings_Web_Small = "BuildSettings.Web.Small";
        public const string BuildSettings_Standalone_Small = "BuildSettings.Standalone.Small";
        public const string BuildSettings_iPhone_Small = "BuildSettings.iPhone.Small";
        public const string BuildSettings_Android_Small = "BuildSettings.Android.Small";
        public const string BuildSettings_BlackBerry_Small = "BuildSettings.BlackBerry.Small";
        public const string BuildSettings_Tizen_Small = "BuildSettings.Tizen.Small";
        public const string BuildSettings_XBox360_Small = "BuildSettings.XBox360.Small";
        public const string BuildSettings_XboxOne_Small = "BuildSettings.XboxOne.Small";
        public const string BuildSettings_PS3_Small = "BuildSettings.PS3.Small";
        public const string BuildSettings_PSP2_Small = "BuildSettings.PSP2.Small";
        public const string BuildSettings_PS4_Small = "BuildSettings.PS4.Small";
        public const string BuildSettings_PSM_Small = "BuildSettings.PSM.Small";
        public const string BuildSettings_FlashPlayer_Small = "BuildSettings.FlashPlayer.Small";
        public const string BuildSettings_Metro_Small = "BuildSettings.Metro.Small";
        public const string BuildSettings_WP8_Small = "BuildSettings.WP8.Small";
        public const string BuildSettings_SamsungTV_Small = "BuildSettings.SamsungTV.Small";
        public const string BuildSettings_Web = "BuildSettings.Web";
        public const string BuildSettings_Standalone = "BuildSettings.Standalone";
        public const string BuildSettings_iPhone = "BuildSettings.iPhone";
        public const string BuildSettings_Android = "BuildSettings.Android";
        public const string BuildSettings_BlackBerry = "BuildSettings.BlackBerry";
        public const string BuildSettings_Tizen = "BuildSettings.Tizen";
        public const string BuildSettings_XBox360 = "BuildSettings.XBox360";
        public const string BuildSettings_XboxOne = "BuildSettings.XboxOne";
        public const string BuildSettings_PS3 = "BuildSettings.PS3";
        public const string BuildSettings_PSP2 = "BuildSettings.PSP2";
        public const string BuildSettings_PS4 = "BuildSettings.PS4";
        public const string BuildSettings_PSM = "BuildSettings.PSM";
        public const string BuildSettings_FlashPlayer = "BuildSettings.FlashPlayer";
        public const string BuildSettings_Metro = "BuildSettings.Metro";
        public const string BuildSettings_WP8 = "BuildSettings.WP8";
        public const string BuildSettings_SamsungTV = "BuildSettings.SamsungTV";
        public const string TreeEditor_BranchTranslate = "TreeEditor.BranchTranslate";
        public const string TreeEditor_BranchRotate = "TreeEditor.BranchRotate";
        public const string TreeEditor_BranchFreeHand = "TreeEditor.BranchFreeHand";
        public const string TreeEditor_LeafTranslate_On = "TreeEditor.LeafTranslate On";
        public const string TreeEditor_LeafRotate_On = "TreeEditor.LeafRotate On";
        public const string sv_icon_dot15_pix16_gizmo = "sv_icon_dot15_pix16_gizmo";
        public const string sv_icon_dot1_sml = "sv_icon_dot1_sml";
        public const string sv_icon_dot4_sml = "sv_icon_dot4_sml";
        public const string sv_icon_dot7_sml = "sv_icon_dot7_sml";
        public const string sv_icon_dot5_pix16_gizmo = "sv_icon_dot5_pix16_gizmo";
        public const string sv_icon_dot11_pix16_gizmo = "sv_icon_dot11_pix16_gizmo";
        public const string sv_icon_dot12_sml = "sv_icon_dot12_sml";
        public const string sv_icon_dot15_sml = "sv_icon_dot15_sml";
        public const string sv_icon_dot9_pix16_gizmo = "sv_icon_dot9_pix16_gizmo";
        public const string sv_icon_name6 = "sv_icon_name6";
        public const string sv_icon_name3 = "sv_icon_name3";
        public const string sv_icon_name4 = "sv_icon_name4";
        public const string sv_icon_name0 = "sv_icon_name0";
        public const string sv_icon_name1 = "sv_icon_name1";
        public const string sv_icon_name2 = "sv_icon_name2";
        public const string sv_icon_name5 = "sv_icon_name5";
        public const string sv_icon_name7 = "sv_icon_name7";
        public const string sv_icon_dot1_pix16_gizmo = "sv_icon_dot1_pix16_gizmo";
        public const string sv_icon_dot8_pix16_gizmo = "sv_icon_dot8_pix16_gizmo";
        public const string sv_icon_dot2_pix16_gizmo = "sv_icon_dot2_pix16_gizmo";
        public const string sv_icon_dot6_pix16_gizmo = "sv_icon_dot6_pix16_gizmo";
        public const string sv_icon_dot0_sml = "sv_icon_dot0_sml";
        public const string sv_icon_dot3_sml = "sv_icon_dot3_sml";
        public const string sv_icon_dot6_sml = "sv_icon_dot6_sml";
        public const string sv_icon_dot9_sml = "sv_icon_dot9_sml";
        public const string sv_icon_dot11_sml = "sv_icon_dot11_sml";
        public const string sv_icon_dot14_sml = "sv_icon_dot14_sml";
        public const string sv_label_0 = "sv_label_0";
        public const string sv_label_1 = "sv_label_1";
        public const string sv_label_2 = "sv_label_2";
        public const string sv_label_3 = "sv_label_3";
        public const string sv_label_5 = "sv_label_5";
        public const string sv_label_6 = "sv_label_6";
        public const string sv_label_7 = "sv_label_7";
        public const string sv_icon_none = "sv_icon_none";
        public const string sv_icon_dot14_pix16_gizmo = "sv_icon_dot14_pix16_gizmo";
        public const string sv_icon_dot7_pix16_gizmo = "sv_icon_dot7_pix16_gizmo";
        public const string sv_icon_dot3_pix16_gizmo = "sv_icon_dot3_pix16_gizmo";
        public const string sv_icon_dot0_pix16_gizmo = "sv_icon_dot0_pix16_gizmo";
        public const string sv_icon_dot2_sml = "sv_icon_dot2_sml";
        public const string sv_icon_dot5_sml = "sv_icon_dot5_sml";
        public const string sv_icon_dot8_sml = "sv_icon_dot8_sml";
        public const string sv_icon_dot10_pix16_gizmo = "sv_icon_dot10_pix16_gizmo";
        public const string sv_icon_dot12_pix16_gizmo = "sv_icon_dot12_pix16_gizmo";
        public const string sv_icon_dot10_sml = "sv_icon_dot10_sml";
        public const string sv_icon_dot13_sml = "sv_icon_dot13_sml";
        public const string sv_icon_dot4_pix16_gizmo = "sv_icon_dot4_pix16_gizmo";
        public const string sv_label_4 = "sv_label_4";
        public const string sv_icon_dot13_pix16_gizmo = "sv_icon_dot13_pix16_gizmo";
    }
}