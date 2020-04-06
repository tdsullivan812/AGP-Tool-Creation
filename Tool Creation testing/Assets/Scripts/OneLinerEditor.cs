using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class OneLinerEditor : EditorWindow
{

    TypeCache.TypeCollection npcs = TypeCache.GetTypesDerivedFrom<NPC>();
    TextAsset cardSpreadsheet;


    [MenuItem("Window/NPC One Liners")]
    static void Init()
    {
        OneLinerEditor window = (OneLinerEditor)EditorWindow.GetWindow(typeof(OneLinerEditor));
        window.Show();
    }




}
