using UnityEngine;
using UnityEngine.SceneManagement;

public class GamManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 4f;

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER HAHA");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
