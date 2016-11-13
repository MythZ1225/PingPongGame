using UnityEngine;
using System.Collections;

public class AutomaticLayoutAreas : MonoBehaviour {
    
    void OnGUI()
    {
        GUILayout.Button("I am not inside an Area");
        GUILayout.BeginArea(new Rect(Screen.width / 2, Screen.height / 2, 300, 300));
        GUILayout.Button("I am completely inside an Area");
        GUILayout.EndArea();
    }

}
