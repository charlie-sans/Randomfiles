using UnityEngine;

public class ActivateScriptOnTouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Get the GameObject that was touched
        GameObject touchedObject = collision.gameObject;

        // Try to get the script to activate on the touched object
        SomeScriptToActivate scriptToActivate = touchedObject.GetComponent<SomeScriptToActivate>();

        // If the script exists, activate it
        if (scriptToActivate != null)
        {
            scriptToActivate.Activate();
        }
    }
}