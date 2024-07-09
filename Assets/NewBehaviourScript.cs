using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour


{
    public static Vector3 center = new Vector3(0, 0, -0.5f);
    public float angle = 0f;
    public int balldir = 1;
    public static float radius = 0.5f;
    public float angularSpeed = 10f;  //ball speed in degree

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            // this only works in editor view
            UnityEditor.EditorApplication.isPlaying = false;
            // this only works for built programs
            // Application.Quit();
        }

        float x = Mathf.Sin(angle) * radius + center.x;
        float z = Mathf.Cos(angle) * radius + center.z;

        transform.position = new Vector3(x, center.y, z);

        angle += angularSpeed * Mathf.Deg2Rad *Time.deltaTime* balldir;

        //dirChangeTime -= Time.deltaTime;// this line counts down the randomly generated number thats 2-3. 

        if (angle > 0.436 || angle < -0.436) //if time is reached or ball is about to go off screen
        //if (angle > maxRad || angle < -maxRad)
        {
            balldir *= -1; //change x direction
           // dirChangeTime = (float)((rnd.NextDouble() * (time_max - time_min)) + time_min); //the random next double gives a random number between 0-1. This line will give a number between 2-3.
            //timeOffset = Time.time;

            //dirChange = true;
        }

    }
}
