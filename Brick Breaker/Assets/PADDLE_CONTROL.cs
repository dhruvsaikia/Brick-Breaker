using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PADDLE_CONTROL : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;

    public int xVel=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveL))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-5-xVel,0);
        }
        if (Input.GetKey(moveR))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(5+xVel,0);
        }
        if ((!Input.GetKey(moveR)) && (!Input.GetKey(moveL)))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name=="power_expand(Clone)")
        {
            gameflow.player_score_m=1;
            GetComponent<Transform>().localScale=new Vector2(0.4f,.4f);
            xVel=0;
        }
        if(other.gameObject.name=="power_shrink(Clone)")
        {
            gameflow.player_score_m=1;
            GetComponent<Transform>().localScale=new Vector2(0.2f,.4f);
            xVel=0;
        }
        if(other.gameObject.name=="power_speed(Clone)")
        {
            gameflow.player_score_m=1;
            GetComponent<Transform>().localScale=new Vector2(0.3f,.4f);
            xVel = 3;
        }
        if(other.gameObject.name=="power_speed_slow(Clone)")
        {
            gameflow.player_score_m=1;
            GetComponent<Transform>().localScale=new Vector2(0.3f,.4f);
            xVel = -2;
        }
        if(other.gameObject.name=="power_multiplier(Clone)")
        {
            gameflow.player_score_m=2;
            GetComponent<Transform>().localScale=new Vector2(0.3f,.4f);
            xVel = 0;
        }
    }

}
