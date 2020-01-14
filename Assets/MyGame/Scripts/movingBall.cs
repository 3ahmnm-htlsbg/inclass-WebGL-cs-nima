using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movingBall : MonoBehaviour
{

    public GameObject ball;
    
    [SerializeField]private GameObject[] ballPositions;


    private int RandomNum()
    {
        return Random.Range(0, 4);
    }
 

    public void BallPos()
    { 
        ball.transform.position = ballPositions[RandomNum()].transform.position;
    }

}
