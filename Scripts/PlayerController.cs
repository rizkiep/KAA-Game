using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public int score=0;
    public AudioSource benar;
    public AudioSource salah;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag=="KAA"){
            benar=GetComponent<AudioSource>();
            score++;
            benar.Play();
            scoreText.text=score.ToString();
        }
        else if(collision.tag=="NonKAA"){
            salah=GetComponent<AudioSource>();
            score--;
            salah.Play();
            scoreText.text=score.ToString();
        }
    }
}
