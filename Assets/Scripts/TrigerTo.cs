
using UnityEngine;

public class TrigerTo: MonoBehaviour
{
    private IInteractible IObject;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.GetComponent(typeof(IInteractible)))
        {
            IObject = (IInteractible)other.transform.GetComponent(typeof(IInteractible));
            IObject.Action();
           
        }
    }



}
