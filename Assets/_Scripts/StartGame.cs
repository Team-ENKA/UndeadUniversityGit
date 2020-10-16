using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void Begin()
    {

        Debug.Log("start");
        SceneManager.LoadScene("Level 1 (floor 3)", LoadSceneMode.Single);

    }

}
