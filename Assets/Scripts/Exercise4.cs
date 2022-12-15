
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{

    public string [] elementos = { "tierra", "agua", "fuego", "aire" };

    private string random;

    private void Start()
    {

        RandomElement(elementos);


    }

    string RandomElement(string[] x)
    {
       
   
      int Index= Random.Range (0,x.Length);

       random= x[Index];

        Debug.Log($"The random element is {random} ");

        return random;
    
    }



}
