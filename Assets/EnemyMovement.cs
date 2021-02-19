using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    public bool enemyOneMoveRight;
    public bool enemyOneMoveLeft;

    // Update is called once per frame
    void Update()
    {
        if (enemyOneMoveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
        }
        else if (enemyOneMoveLeft)
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "CollWallLeft")
        {
            enemyOneMoveRight = true;
            enemyOneMoveLeft = false;
        }
        else if (other.gameObject.name == "CollWallRight")
        {
            enemyOneMoveRight = false;
            enemyOneMoveLeft = true;
        }
    }
}
