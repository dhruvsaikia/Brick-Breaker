using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BALL_CONTROL : MonoBehaviour
{

    public Vector2 currentVel;
    public Vector2 ballVel;
    public float time = 3;

    // Start is called before the first frame update
    void Start()
    {
        ballVel=new Vector2(3,-3);
        GetComponent<Rigidbody2D>().velocity=ballVel;
    }

    // Update is called once per frame
    void Update()
    {
        currentVel=GetComponent<Rigidbody2D>().velocity;
        if(currentVel.y>5)
        GetComponent<Rigidbody2D>().velocity=new Vector2(currentVel.x,5);
        if(currentVel.y<-5)
        GetComponent<Rigidbody2D>().velocity=new Vector2(currentVel.x,-5);
        if(currentVel.x>5)
        GetComponent<Rigidbody2D>().velocity=new Vector2(5,currentVel.y);
        if(currentVel.x<-5)
        GetComponent<Rigidbody2D>().velocity=new Vector2(-5,currentVel.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name=="border-left")
        GetComponent<Rigidbody2D>().velocity = new Vector2(currentVel.x*-1,currentVel.y);
        if(other.gameObject.name=="border-right")
        GetComponent<Rigidbody2D>().velocity = new Vector2(currentVel.x*-1,currentVel.y);
        if(other.gameObject.name=="border-top")
        GetComponent<Rigidbody2D>().velocity = new Vector2(currentVel.x,currentVel.y*-1);
    
        if(other.gameObject.name=="border-bottom")
        {
            gameflow.player_score=0;
            SceneManager.LoadScene("GameScene");
        }
    }

}
