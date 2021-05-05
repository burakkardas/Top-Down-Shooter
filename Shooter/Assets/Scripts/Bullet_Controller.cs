using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    private Vector2 target; 
    public float speed;

    void Start() {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void Update()
    {  
        transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            speed * Time.deltaTime
        );

        Destroy(gameObject, 2f);
    }
}
