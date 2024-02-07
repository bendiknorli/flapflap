using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public Vector2 upForce = new Vector2(0, 1);

    public Animator playerAnimator;

    public ParticleSystem wingParticleSystem;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameHasStarted)
        {
            gameObject.transform.position = new Vector3(0, Mathf.Sin(2 * Time.time), 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameManager.gameHasStarted = true;

            rb.velocity = upForce;

            playerAnimator.SetTrigger("WingFlap");

            wingParticleSystem.Play();
        }
    }
}
