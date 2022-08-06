using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    string heroName = "jimmyjohn";

        int heroPower = 45;

    string villainName = "pepperjack";

    int villainPower = 60;

    float playerspeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        setSpeed(2.5f);

        if (villainPower > heroPower) 
        {
            print (" pepperjack is stronger ");
            
        }
        else if (heroPower > villainPower) 
        {
            print(" jimmyjohn is stronger");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setSpeed(float newspeed)
    {
        print("the old speed is " + playerspeed);
        playerspeed = newspeed;
        print("the new speed is " + playerspeed);
    }

}