using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    float yVelocity;
    public Text LivesText;
    public Text LivesText2;
    public int Lives = 10;
    public GameObject PauseMenu;
    public Slider HealthSlider;
    public Slider HealthSlider2;
   // public Text healthText;
    public int health = 10;
    float timer = 0.0f;
    public AudioClip soundToPlay;
    void Start()
    {
        Time.timeScale = 1;
        HealthSlider.GetComponent<Slider>().value = health;
        HealthSlider2.GetComponent<Slider>().value = health;
        //healthText.GetComponent<Text>().text = "Health: " + health;
        // PlayerPrefs.SetInt("Lives", Lives);
        Lives = PlayerPrefs.GetInt("Lives");
        LivesText.GetComponent<Text>().text = "Lives; " + Lives;
        LivesText2.GetComponent<Text>().text = "Lives; " + Lives;

    }
    private void Update()
    {
        yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        timer += Time.deltaTime;
        LivesText.GetComponent<Text>().text = "Lives; " + Lives;
        LivesText2.GetComponent<Text>().text = "Lives; " + Lives;
        HealthSlider.GetComponent<Slider>().value = health;
        HealthSlider2.GetComponent<Slider>().value = health;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && timer > 1.0 && yVelocity >= 0)
        {
            timer = 0;
            health -= 1;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
           // healthText.GetComponent<Text>().text = "Health: " + health;
            HealthSlider.GetComponent<Slider>().value = health;
            HealthSlider2.GetComponent<Slider>().value = health;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 300));
        }
        if (collision.gameObject.tag == "Water")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.SetInt("Lives", Lives - 1);
        }
            if (health <= 0)
        {
            if(Lives == 0)
            {
                SceneManager.LoadScene("Lose");
            }
            PlayerPrefs.SetInt("Lives", Lives - 1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
}
