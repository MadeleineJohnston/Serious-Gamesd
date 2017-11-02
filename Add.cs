using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Add : MonoBehaviour
{

    public Button add;

    // Use this for initialization
    void Start()
    {
        Button btn = add.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("Clicked the button");
        //addition sum added to the equation
    }
}
