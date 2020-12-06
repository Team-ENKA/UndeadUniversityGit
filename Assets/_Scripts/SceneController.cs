using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{

    public GameObject volumeSlider;
    public float volumeSliderValue;
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

        int sceneNum = SceneManager.GetActiveScene().buildIndex;

            Destroy(GameObject.FindGameObjectWithTag("Canvas"));
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("MainCamera"));
            Destroy(GameObject.FindGameObjectWithTag("ShootingDir"));
            Destroy(GameObject.FindGameObjectWithTag("EventController"));

        SceneManager.LoadScene(0);

    }

    private void Update()
    {

        GameObject[] AudioSourcesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        mainCamAudio = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        volumeSliderValue = volumeSlider.GetComponent<Slider>().value;

        foreach (GameObject element in AudioSourcesInScene)
        {
            element.GetComponent<AudioSource>().volume = volumeSliderValue;
        }

        mainCamAudio.volume = volumeSliderValue;

    }

}
