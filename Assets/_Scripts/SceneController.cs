using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    public GameObject mainCam;
    public GameObject volumeSlider;
    public Slider volumeSliderValue;
    public AudioSource mainCamAudio;

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

    public void Audio()
    {

        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        mainCamAudio = mainCam.GetComponent<AudioSource>();
        volumeSliderValue = volumeSlider.GetComponent<Slider>();
        mainCamAudio.volume = volumeSliderValue.value;

    }

}
