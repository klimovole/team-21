using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    public int speed;
    public int normalSpeed;
    private Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rg.velocity = new Vector2(speed, rg.velocity.y);
    }

    public void Froward()
    {
        if (speed <= 0)
        {
            speed = normalSpeed;
        }
    }

    public void BackWard()
    {
        if (speed >= 0)
        {
            speed = -normalSpeed;
        }
    }

    public void Stop()
    {
        speed = 0;
    }
}
