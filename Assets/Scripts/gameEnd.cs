using UnityEngine;

public class gameEnd : MonoBehaviour {

    public gamemanager gamemanager;

    private void OnTriggerEnter()
    {
        gamemanager.gameComplete();
    }

}
