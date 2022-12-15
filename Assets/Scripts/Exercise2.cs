using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public int cm;

    private float inches;


    private void Start()
    {
        Convert(cm);
    }




    private float Convert(int x)
    {
        inches = x*0.39f;

        Debug.Log($"{x}cm equals {inches} inches");

        return inches;
    }



 







}
