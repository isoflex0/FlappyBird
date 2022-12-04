using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1;
    private Rigidbody2D rigidbody;
    public GameManager managerGame;
    public GameObject Death;
    public AudioSource wing;
    public AudioSource point;
    public AudioSource die;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * velocity;

            if (managerGame.SoundOff == false)

                wing.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Score")
        {
            managerGame.UpdateScore();

            if (managerGame.SoundOff == false)
                point.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Death")
        {
            isDead = true;
            Time.timeScale = 0;

            Death.SetActive(true);

            if (managerGame.SoundOff == false)
                die.Play();
        }
    }
}