using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionDemoScript : MonoBehaviour
{

    public Transform nullTransform;//null
    public GameObject nullGameObject;
    private void Awake()
    {
        Debug.Log("The exceptions in this component");
        ExceptionHandler.CheckExceptionsInComponent(gameObject, this);
        
        Debug.Log("The exceptions in this gameobject");
        ExceptionHandler.CheckExceptionsInGameObject(gameObject);

        Debug.Log("The exceptions in CheckT function");
        CheckT();
    }
    public void CheckT()
    {
        GameObject _nullGameObject = null;
        Transform _nullTransform = null;
       var checkException = ExceptionHandler.CheckExceptionsInComponent(gameObject, this, _nullGameObject,_nullTransform);
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
