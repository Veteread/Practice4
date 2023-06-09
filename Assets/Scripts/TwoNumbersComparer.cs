using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    public InputField nomber1;
    public InputField nomber2;
    public Text resultCom;
    private float a;
    private float b;
   
    public void onPressCom()
    {
        if (nomber1.text == "" || nomber2.text == "")
    	{
    		resultCom.text = "Введите число";    		   		
    	}
    	else 
    	{ 
    	a = float.Parse(nomber1.text);
    	b = float.Parse(nomber2.text);
    	 if (a > b)
    	 {
    	 	resultCom.text = $"Наибольшее число {a}";
    	 }
    	 else
    	  {
    	  	if (a < b)
    	  	{
    	  		resultCom.text = $"Наибольшее число {b}";    	  		
    	  	}
    	  	else 
    	  	 if (a == b)
    	  	 {
    	  	 	resultCom.text = "Числа равны";
    	  	 }
    	  }
    	}

    }

    public void onPressClearCom()
    {
    	a = 0;
    	b = 0;
    	nomber1.text = "";
    	nomber2.text = "";
    	resultCom.text = "";
    }
}
