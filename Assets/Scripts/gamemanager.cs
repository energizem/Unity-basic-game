using UnityEngine.SceneManagement;
using UnityEngine;

public class gamemanager : MonoBehaviour {
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void gameComplete()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("game completed");
    }
 public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("gameover");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
