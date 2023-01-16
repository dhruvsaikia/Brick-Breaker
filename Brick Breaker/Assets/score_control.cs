using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text="Score : "+gameflow.player_score.ToString();   
    }
}
