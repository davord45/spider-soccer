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

    [System.Serializable]
    public struct controllerInput {
        public UnityEngine.KeyCode[] keycode;
    }

    public List<controllerInput> controllerInputs;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var currentController = controllerInputs[(int)controllerType];
        if (Input.GetKeyDown(currentController.keycode[0]))
        {
            Debug.Log("Up is pressed");
        }

        if (Input.GetKeyDown(currentController.keycode[1]))
        {
            Debug.Log("Down is pressed");
        }
    }
}
