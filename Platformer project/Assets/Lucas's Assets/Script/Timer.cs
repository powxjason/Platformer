using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
    public int Lives;
    public float LevelTimer = 50;
    public Text TimerText;
    public Text TimerText2;
    // Use this for initialization
    void Start () {
        TimerText.GetComponent<Text>().text = "Time; " + LevelTimer;
        TimerText2.GetComponent<Text>().text = "Time; " + LevelTimer;
        Lives = PlayerPrefs.GetInt("Lives");
    }
	
	// Update is called once per frame
	void Update () {
        LevelTimer -= Time.deltaTime;
        TimerText.GetComponent<Text>().text = "Time; " + Mathf.RoundToInt(LevelTimer);
        TimerText2.GetComponent<Text>().text = "Time; " + Mathf.RoundToInt(LevelTimer);

        if (LevelTimer <= 0)
        {
            if (Lives == 0)
            {
                SceneManager.LoadScene("Lose");
            }
            PlayerPrefs.SetInt("Lives", Lives - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
