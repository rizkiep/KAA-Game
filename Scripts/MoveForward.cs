using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float minSpeed=1.5f;
    public float maxSpeed=3.0f;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed=Random.Range(minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*speed);
    }
}
