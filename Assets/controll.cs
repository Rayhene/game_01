using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    public KeyCode moveLeft;
    public KeyCode moveRight;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveUp))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 3, 0);

        if (Input.GetKeyDown(moveDown))
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -3, 0);

        if (Input.GetKeyDown(moveLeft))
            GetComponent<Rigidbody2D>().velocity = new Vector3(-3, 0, 0);

        if (Input.GetKeyDown(moveRight))
            GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        points += 1;
        Debug.Log(points);
    }

}
