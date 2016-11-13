using UnityEngine;
using System.Collections;

public class AutomaticLayoutHVGroups : MonoBehaviour {

    private float sliderValue = 1.0f;
    private float maxSliderValue = 10.0f;

    void OnGUI()
    {
        // Wrap everything in the designated GUI Area
        GUILayout.BeginArea(new Rect(0, 0, 200, 60));

            // Begin the singular Horizontal Group
            GUILayout.BeginHorizontal();

            // Place a Button normally
            if (GUILayout.RepeatButton("Increase max\nSlider Value"))
            {
                maxSliderValue += 3.0f * Time.deltaTime;
            }

                // Arrange two more Controls vertically beside the Button
                GUILayout.BeginVertical();
                GUILayout.Box("Slider Value: " + Mathf.Round(sliderValue));
                sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, maxSliderValue);
                sliderValue = GUILayout.HorizontalSlider(sliderValue, 0.0f, maxSliderValue);
        // End the Groups and Area
        GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
}
