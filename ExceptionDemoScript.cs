using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionDemoScript : MonoBehaviour
{
    // It's null
    public Transform NullTransform;
    // It's null
    public GameObject NullGameObject;
    private void Awake()
    {
        Debug.Log("Check exceptions in this component");

        ExceptionHandler.CheckExceptionsInComponent(gameObject, this); // There is currently 2 exceptions in this component
        Debug.Log("Check exceptions in this gameobject");

        ExceptionHandler.CheckExceptionsInGameObject(gameObject); // There is currently 2 or more exceptions in this gameobject
        Debug.Log("Check exceptions in this function");
        DoSomething();
    }
    public void DoSomething()
    {
        
       var checkException = ExceptionHandler.CheckExceptionsInComponent(gameObject, this);
        if (checkException.Count == 0)
        {
            Debug.Log("There is no exception in this component");
        }
        else
        {
            Debug.Log("There is " + checkException.Count + " exceptions in this component");
        }
    }
}
