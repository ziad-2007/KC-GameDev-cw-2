using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    string heroname = "Asta";
    int heropower = 73;

    string villianname = "Licht";
    int villianpower = 63;

    float playerspeed = 16.5f;

    // Start is called before the first frame update
    void Start()
    {
       if(heropower > villianpower) 
        {
            print("The hero is stronger than the villian");
        } 
       else if(heropower < villianpower) 
        {
            print("The villian is stronger than the hero");
        }
       else
        {
            print("The hero might win with high amount of damage");
        }

        print(playerspeed);
       SetSpeed(2.5f);
        print(playerspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetSpeed(float speed) 
    {
        playerspeed = speed;
    }
}
