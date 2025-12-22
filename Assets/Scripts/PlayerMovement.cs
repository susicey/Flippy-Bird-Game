using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float jumpSpeed = 8f;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource flySXF;
    [SerializeField] private AudioSource pointSFX;




    private Rigidbody2D rb2d;

    private void Start()
    {
        Time.timeScale = 1f;
        deathScreen.SetActive(false);
        rb2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {

            rb2d.velocity = Vector2.up * jumpSpeed;
            flySXF.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            pointSFX.Play();
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Engel")
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            dieSFX.Play();

        }
    }
}
