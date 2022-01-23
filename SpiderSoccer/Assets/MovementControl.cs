using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    enum Controller
    {
        Type1,Type2,Type3
    }
    [SerializeField] Controller controllerType;

    List<List<UnityEngine.KeyCode>> controllers;

    // Start is called before the first frame update
    void Start()
    {
        controllers = new List<List<UnityEngine.KeyCode>>();
        List<UnityEngine.KeyCode> controller1 = new List<UnityEngine.KeyCode>();
        controller1.Add(KeyCode.W);
        controller1.Add(KeyCode.S);
        controller1.Add(KeyCode.A);
        controller1.Add(KeyCode.D);
        controllers.Add(controller1);

        List<UnityEngine.KeyCode> controller2 = new List<UnityEngine.KeyCode>();
        controller2.Add(KeyCode.UpArrow);
        controller2.Add(KeyCode.DownArrow);
        controller2.Add(KeyCode.LeftArrow);
        controller2.Add(KeyCode.RightArrow);
        controllers.Add(controller2);
    }

    // Update is called once per frame
    void Update()
    {
        var currentController = controllers[(int)controllerType];
        if (Input.GetKeyDown(currentController[0]))
        {
            Debug.Log("Up is pressed");
        }

        if (Input.GetKeyDown(currentController[1]))
        {
            Debug.Log("Down is pressed");
        }
    }
}
