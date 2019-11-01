using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force;
    public Text text;
    private int score;
    public Canvas gameOver;
    public Button playPause;


    private void Start()
    {
        gameOver.enabled = false;
        
    }
    void Update()
    {
        text.text = "Score" + '\n' + score.ToString();
        if ((Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject(-1)) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * force;
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.enabled = true;
        Time.timeScale = 0;
        playPause.enabled = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Checkpoint")
        {
            score++;
        }
    }
}
