using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    //Quits the game when the quit game button is pressed
    public void Quit()
    {

        Application.Quit();

    }

    public void Respawn()
    {

        int sceneNum = SceneManager.GetActiveScene().buildIndex;

        if (sceneNum == 1)
        {

            Destroy(GameObject.FindGameObjectWithTag("Canvas"));
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
            Destroy(GameObject.FindGameObjectWithTag("ShootingDir"));
            Destroy(GameObject.FindGameObjectWithTag("EventController"));

        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void MainMenu()
    {

        SceneManager.LoadScene(0);

    }

}
