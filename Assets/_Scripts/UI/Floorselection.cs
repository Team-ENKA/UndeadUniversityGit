using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Floorselection : MonoBehaviour
{
    Rect windowRect = new Rect(20, 20, 120, 120);
    public float f;

    void OnGUI()
    {
        // Register the window. Notice the 3rd parameter
        if (f == 1)
        {
            windowRect = GUILayout.Window(0, windowRect, Elevatorbutton, "Floor selection");
        }
    }

    // Make the contents of the window
    void Elevatorbutton(int windowID)
    {
        if (GUILayout.Button("Basement"))
        {
            SceneManager.LoadScene("Basement", LoadSceneMode.Single);
            //when button for basement is pressed, scene "Basement" loads.
        }
        if (GUILayout.Button("Floor 1"))
        {
            SceneManager.LoadScene("Level 3 (floor 1)", LoadSceneMode.Single);
            //when button for floor 1 is pressed, scene "Floor 1" loads.
        }
        if (GUILayout.Button("Floor 2"))
        {
            SceneManager.LoadScene("Level 2 (floor 2)", LoadSceneMode.Single);
            //when button for floor 2 is pressed, scene "Floor 2" loads.
        }
        if (GUILayout.Button("Floor 3"))
        {
            SceneManager.LoadScene("Level 1 (floor 3)", LoadSceneMode.Single);
            //when button for floor 3 is pressed, scene "Floor 3" loads.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            f = 1;
        }

    }
}