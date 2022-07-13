using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    float horizontal;
    public Animator animator;
    bool fachright=true;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal=Input.GetAxis("Horizontal");
        // rb.velocity=new Vector2(horizontal*7.5f,rb.velocity.y);
        // transform.Translate(Vector2.right*horizontal*Time.deltaTime*7.5f);
        animator.SetFloat("jalan",Mathf.Abs(horizontal));
    }
    void FixedUpdate(){
            
        Vector2 position=rb.position;
        position.x=position.x+6.0f*horizontal*Time.deltaTime;
        // // // position.y=position.x+3.0f*vertical*Time.deltaTime;
        rb.MovePosition(position);
        if(horizontal<0f && fachright){
            flip(-180,false);
        }
        else if(horizontal>0f && !fachright){
            flip(180,true);
        }
    }
    void flip(float rotate,bool right){
        fachright=right;
        transform.Rotate(0f,rotate,0f);
    }
}
