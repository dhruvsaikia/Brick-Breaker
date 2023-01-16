using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_brick : MonoBehaviour
{
    private Sprite brick11;
    private Sprite brick12;

    public Transform powerSpeed;
    public Transform powerSpeedSlow;
    public Transform powerSize;
    public Transform powerSizeShrink;
    public Transform powerMultiplier;

    public int whichPower;

    public bool isHit;

    // Start is called before the first frame update
    void Start()
    {
     isHit = false;   
     brick11 = Resources.Load<Sprite>("brick-11");
     brick12 = Resources.Load<Sprite>("brick-12");
     this.gameObject.GetComponent<SpriteRenderer>().sprite = brick11;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if(isHit){
        whichPower = Random.Range(1,9);

        if(whichPower == 1)
        Instantiate(powerSize,transform.position,powerSize.rotation);
        if(whichPower == 2)
        Instantiate(powerSpeed,transform.position,powerSpeed.rotation);
        if(whichPower == 3)
        Instantiate(powerMultiplier,transform.position,powerMultiplier.rotation);
        if(whichPower == 4)
        Instantiate(powerSpeedSlow,transform.position,powerMultiplier.rotation);
        if(whichPower == 5)
        Instantiate(powerSizeShrink,transform.position,powerMultiplier.rotation);

        gameflow.player_score=gameflow.player_score+10*gameflow.player_score_m;
        Destroy(gameObject,0.05f);
        }else{
        isHit = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = brick12;
        }
    }
}
