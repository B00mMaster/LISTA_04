using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{   
    //no se como hacer para actualizar money durante la ejecucci�n
    
    
    
    //moneyBox sera el valor que le demos a money m�s el antiguo valor dde moneyBox
    private int moneyBox;
   
    public int money=2;


    private void Start()
    {
        //el nuevo valor de moneybox pasa a la funci�n
       IncreaseMoney(money);

        Debug.Log($"You have inserted {money}$. You have {moneyBox}$ on your money box");
    
    }
    
  void IncreaseMoney(int anynumber)
    {
        moneyBox += anynumber;
        //devuelve la suma de los valores moneybox + money
   
    }
    


    
    
    

    
    

}
