using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public GameController gameController; 

    public void OnGUI()
    {
        //First button = 100 
        //Second button = 200
        //Third button = 300 

        if (GUILayout.Button("50 little guys"))
        {
            gameController.numberOfSoldiers = 50;
            Debug.Log("We have spawned in 50 little guys");
        }

        if (GUILayout.Button("200 little guys"))
        {
            gameController.numberOfSoldiers = 200;
            Debug.Log("We have spawned in 200 little guys");
        }

        if (GUILayout.Button("500 little guys"))
        {
            gameController.numberOfSoldiers = 500;
            Debug.Log("We have spawned in 500 little guys");
        }
    }
}
