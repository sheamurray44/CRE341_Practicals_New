using StarterAssets;
using Unity.VisualScripting;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public StarterAssetsInputs starterAssetsInputs;
    public GameObject pausedUI;
    private bool isPaused = false;

    void Awake()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    private void Pause()
    {
        Debug.Log("Game Paused.");
        pausedUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        starterAssetsInputs.cursorInputForLook = false;
    }

    private void Resume()
    {
        Debug.Log("Game Resumed.");
        pausedUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        starterAssetsInputs.cursorInputForLook = true;
    }
}
