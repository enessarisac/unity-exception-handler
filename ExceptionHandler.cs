using UnityEngine;
using System.Collections.Generic;

public class ExceptionHandler
{
    //It's debug only, please remove it in release version
    public static List<System.Exception> CheckExceptionsInComponent(GameObject gameObject, Component component, params object[] variables)
    {
        List<System.Exception> exceptions = new List<System.Exception>();
        for (int i = 0; i < variables.Length; i++)
        {
            if (variables[i] == null)
            {
                var exception = new System.Exception($"variable number {i} is null. And it's called function from " + component.GetType().Name + " in " + gameObject.name);
                Debug.LogException(exception, gameObject);
                exceptions.Add(exception);
            }
        }

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

                Debug.LogError($"There is a {e.GetType()} in " + gameObject.name + ". The component is : " + component + ".  The null variable is : " + variable , gameObject);
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


