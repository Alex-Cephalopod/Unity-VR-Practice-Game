using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimAction;
    public InputActionProperty gripAnimAction;

    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerVal = pinchAnimAction.action.ReadValue<float>(); //bool if simple button press, anything else if axis or sensitive buttons like triggers or grip
        float gripVal = gripAnimAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerVal);
        handAnimator.SetFloat("Grip", gripVal);
        //Debug.Log(triggerVal);
    }
}
