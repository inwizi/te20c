using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //We will move our wencile here
        transform.Translate(0, 0, 1);
    }
}
