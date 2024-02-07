using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float secondsUntilPipes;

    float secondsSinceLastPipes;

    public GameObject pipes;

    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.gameHasEnded || !gameManager.gameHasStarted)
        {
            return;
        }

        secondsSinceLastPipes += Time.deltaTime;

        if (secondsSinceLastPipes >= secondsUntilPipes)
        {
            // spawn pipes

            Vector3 randomYPostition = new Vector3(0, Random.Range(-1, 2), 0);

            Instantiate(pipes, transform.position + randomYPostition, transform.rotation);

            secondsSinceLastPipes = 0;
        }
    }
}
