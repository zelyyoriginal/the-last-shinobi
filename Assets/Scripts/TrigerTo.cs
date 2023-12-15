
using UnityEngine;

public class TrigerTo: MonoBehaviour
{
    public IneractibleObject IObject;
   
    private void OnTriggerEnter(Collider other)
    {
        if(IObject = other.gameObject.GetComponent<IneractibleObject>())
        {
          
            IObject.Action(gameObject);
           
        }
    }



}
