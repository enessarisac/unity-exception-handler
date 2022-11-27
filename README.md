# Unity Exception Handler
When this script is called, it finds the objects that are null and prints them as logs.

Using

(It's returns exceptions in component)
var checkException = ExceptionHandler.CheckExceptionsInComponent(gameObject, Component);

(It's also checks the params variables)
var checkException = ExceptionHandler.CheckExceptionsInComponent(gameObject, Component, var1,var2,var3);

(It's just log the exceptions in component)
ExceptionHandler.CheckExceptionsInComponent(gameObject, Component);

(It's just log the exceptions in component and checks the variables)
ExceptionHandler.CheckExceptionsInComponent(gameObject, Component, var1, var2, var3);

(It's log the all exceptions in gameobject ("Currently just null references"))
ExceptionHandler.CheckExceptionsInGameObject(gameObject);
