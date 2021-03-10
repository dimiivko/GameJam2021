using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement1 : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;

    public float moveSpeed = 3f;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("HorizontalPlayer2");
        movement.y = Input.GetAxisRaw("VerticalPlayer2");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (PlayerPrefs.GetInt("Player1Score") == 9)
        {
            PlayerPrefs.SetString("Winner", "Player1");
            PlayerPrefs.SetInt("go", 0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            PlayerPrefs.SetInt("Player1Score", PlayerPrefs.GetInt("Player1Score") + 1);
            PlayerPrefs.SetInt("go", 0);
            SceneManager.LoadScene(1);
        }

    }
}
