using UnityEngine.SceneManagement;
using UnityEngine;

public class loadNextScene : MonoBehaviour {

    public void loadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
