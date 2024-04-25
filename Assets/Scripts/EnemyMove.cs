using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0.5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += Vector3.down * Time.deltaTime * speed;
        rb.velocity = Vector2.down * Time.deltaTime * speed;
        if (GameManager._GameManager.IsGameOver)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(this.gameObject);
        Debug.Log("collided in base");
    }
}
