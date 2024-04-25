using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager = null;
    private bool isGameOver = false;
    private int spawner;
    // Start is called before the first frame update
    void Awake()
    {
        if (gameManager == null){
            gameManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        spawner = transform.GetChild(0).GetComponent<EnemySpawn>().numberOfSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        spawner = transform.GetChild(0).GetComponent<EnemySpawn>().numberOfSpawns;
        if (spawner <= 0)
        {
            Debug.Log("Finished the spawn");
        }
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}

