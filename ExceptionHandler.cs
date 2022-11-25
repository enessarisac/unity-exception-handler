using UnityEngine;
using System.Collections.Generic;

public class ExceptionHandler
{
    //It's debug only, please remove it in release version
    public static List<System.Exception> CheckExceptionsInComponent(GameObject gameObject, Component component)
    {
        List<System.Exception> exceptions = new List<System.Exception>();

        object Variable = null;

        object[] variablesOnComponent = component.GetType().GetFields();

        foreach (var variable in variablesOnComponent)
        {

            try
            {
                Variable = variable.GetType().GetField(variable.ToString()).GetValue(variable);
            }
            catch (System.Exception e)
            {

                Debug.LogError("There is a NullReferenceException in this gameobject " + gameObject.name + ". The component is :" + component + ".  The null variable is " + variable + "  --------  " + e, gameObject);
                exceptions.Add(e);

            }

        }
           return exceptions;

    }
    public static void CheckExceptionsInGameObject(GameObject gameObject)
    {

        foreach (var component in gameObject.GetComponents<Component>())
        {

            CheckExceptionsInComponent(gameObject, component);

        }
        
    }
}


