using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// C# example
using UnityEditor;
public static class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/Game.unity" };
        BuildPipeline.BuildPlayer(scenes, "C:\\Users\\toz\\Desktop\\asd\\tGame", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}