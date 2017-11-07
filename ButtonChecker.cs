//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using System.Collections;

//public class ButtonChecker : MonoBehaviour
//{

//    public Button add, subtract, multiply, divide, checker;
//    string val;
//    int temp;
//    bool endOfCalc;
//    public int lives;
//    float number;

//    // Use this for initialization
//    void Start()
//    {
//        number = Random.Range(100, 999);

//        add = new Rect(10, 30, 20, 20); //rand_co-ord for just now
//        subtract = new Rect(30, 30, 20, 20);
//        multiply = new Rect(50, 30, 20, 20);
//        divide = new Rect(70, 30, 20, 20);
//        checker = new Rect(90, 30, 20, 20);
//    }

//    // Update is called once per frame
//    void OnGUI()
//    {
//        OnGUI.TextFeild(text, val);
//        OnGUI.Button(Rect(10, 50, 100, 30), "Lives:  " + Lives);
//        GUI.Label(Rect(10, 10, 100, 30), "The number that was generated was: " + number);

//        if (OnGUI.Button(add, "+"))
//        {
//            CalculationDisplay("+");
//            temp += int.Parse(val);
//            val = "";
//        }

//        if (OnGUI.Button(subtract, "-"))
//        {
//            CalculationDisplay("-");
//            temp -= int.Parse(val);
//            val = "";
//        }

//        if (OnGUI.Button(multiply, "*"))
//        {
//            CalculationDisplay("*");
//            temp *= int.Parse(val); // temp = temp*(int.Parse(val))?
//            val = "";
//        }

//        if (OnGUI.Button(divide, "/"))
//        {
//            CalculationDisplay("/");
//            temp /= int.Parse(val); // temp = temp/(int.Parse(val))?
//            val = "";
//        }

//        if (OnGUI.Button(checker, "Check"))  //checks if calculation is correct - pressed at end of sum by player
//        {
//            temp += int.Parse(val);
//            val = temp.ToString();
//            endOfCalc = true;
//        }
//    }


//    void CalculationDisplay(string str)
//    {
//        if (!endOfCalcOfCalc)
//            val += str;
//        else
//        {
//            checkAnswer();
//            val = "";
//            val += str;
//            endOfCalc = false;
//            temp = 0;
//        }
//    }

//    void checkAnswer()
//    {
//        if (sum == number)
//            correctAnswerDisplay;
//        else
//        {
//            incorrectAnswerDisplay;
//            lives = lives - 1;
//        }
//        newNumber(); // restart game
//    }
//}
