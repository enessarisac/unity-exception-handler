# Unity Exception Handler
When this script is called, it finds the objects that are null and prints them as logs.

Using

(It's returns exceptions in component)
var checkException = ExceptionHandler.CheckExceptionsInComponent(gameObject, Component);

(It's just log the exceptions in component)
ExceptionHandler.CheckExceptionsInComponent(gameObject, Component);

(It's log the all exceptions in gameobject ("Currently just null references"))
ExceptionHandler.CheckExceptionsInGameObject(gameObject);
