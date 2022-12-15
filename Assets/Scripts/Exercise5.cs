
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public string[] elementos = { "tierra", "agua", "fuego", "aire" };

    private int position;


    private void Start()
    {
        position = Random.Range(0,8);
        IsOutOfBounds(position);
    }

    void IsOutOfBounds(int x)
    {

        if (x >= 0 && x <= elementos.Length)
        {//x >= 0 && x <= elementos. para que cumpla ambas condiciones

            Debug.Log($"{x} is not out of Bonds");

        }
        else
        {

            Debug.Log($"{x} is out of Bonds");

        }
    } 
}
