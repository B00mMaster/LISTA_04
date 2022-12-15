using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public float lower;

    public float upper;

    private float Vector;
   
    private void Start()
    {
       Vector= RandomVector(lower, upper);
        
        
        
        Debug.Log($"The random number between {lower} and {upper} is {Vector} ");
    }

    float RandomVector(float x,float y)
    {

        

        return Random.Range (x,y);
    }





}
