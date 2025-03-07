using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public bool playing;
    private float timer;

    private void Awake()
    {
        playing = true;
    }
    private void Update()
    {
        if(playing == true)
        {
            timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60f);
            int seconds = Mathf.FloorToInt(timer % 60f);
            timerText.text = "Timer: " + minutes.ToString ("00") + ":" + seconds.ToString ("00");
        }
    }
}
