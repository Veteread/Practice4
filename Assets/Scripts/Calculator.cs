using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
	public InputField firstNomber;
    public InputField secondNomber;
    public Text result;
  
	private float a;
    private float b;
    private float c;

    private void check()
    {
        
        if (firstNomber.text == "" || secondNomber.text == "")
        {
            result.text = "Введите число";
        }
    }
      public void onPressPlus()
    {
        check();
        a = float.Parse(firstNomber.text);
        b = float.Parse(secondNomber.text);
        c = a + b;
        result.text = $"{c}";

    }
    public void onPressMinus()
    {
        check(); 
        a = float.Parse(firstNomber.text);
        b = float.Parse(secondNomber.text);
        c = a - b;
        result.text = $"{c}";

    }
    public void onPressMultiplication()
    {
        check();
        a = float.Parse(firstNomber.text);
        b = float.Parse(secondNomber.text);
        c = a * b;
        result.text = $"{c}";
    }
    public void onPressDevision()
    {
        check();
        a = float.Parse(firstNomber.text);
        b = float.Parse(secondNomber.text);
        c = a / b;
        result.text = $"{c}";
    }
    public void onPressClear()
    {
    	a = 0;
    	b = 0;
    	c = 0;
    	firstNomber.text = "";
    	secondNomber.text = "";
    	result.text = "Результат";
    }

   
}
