using UnityEngine;
using System.Collections;

public class GUILayoutOptionMinWidth : MonoBehaviour {

    private Rect windowRect = new Rect(10, 10, 100, 100);
    private bool scaling = false;
    void OnGUI()
    {
        windowRect = GUILayout.Window(0, windowRect, ScalingWindow, "resizeable", GUILayout.MinWidth(80), GUILayout.MaxWidth(200));
    }
    void ScalingWindow(int windowID)
    {
        GUILayout.Box("", GUILayout.Width(20), GUILayout.Height(20));
        if (Event.current.type == EventType.MouseUp)
            scaling = false;
        else
            if (Event.current.type == EventType.MouseDown && GUILayoutUtility.GetLastRect().Contains(Event.current.mousePosition))
            scaling = true;

        if (scaling)
            windowRect = new Rect(windowRect.x, windowRect.y, windowRect.width + Event.current.delta.x, windowRect.height + Event.current.delta.y);

    }
}
