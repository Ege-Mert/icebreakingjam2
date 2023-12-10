using UnityEngine;
using UnityEngine.SceneManagement;

public class YourClassName : MonoBehaviour
{
    [SerializeField]
    private int sceneIndexToLoad = 1; // Set the default scene index here

    public void Play()
    {
        SceneManager.LoadScene(sceneIndexToLoad);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
