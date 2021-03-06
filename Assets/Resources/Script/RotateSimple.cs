﻿using UnityEngine;
using System.Collections;

public class RotateSimple : MonoBehaviour {

    public float Speed = 25;
    public bool RotateSideways = true;

    public bool ShouldCheckInput = true;

    private bool Stop = false;
	
	// Update is called once per frame
	void Update ()
	{
	    float multiplier;


	    if (ShouldCheckInput)
	    {
            if (Input.GetButtonDown("Space"))
                Stop = !Stop;

            multiplier = -Input.GetAxis("Horizontal");

            if (!Stop)
            {
                if (multiplier == 0)
                    multiplier = 0.2f;
            }
        }
	    else
	    {
	        multiplier = 0.2f;
	    }


        float sideWays = 0.0f;
	    if (RotateSideways) sideWays = Speed*multiplier/4;

        transform.Rotate(Time.deltaTime * sideWays, Time.deltaTime * Speed * multiplier, 0);
    }
}
