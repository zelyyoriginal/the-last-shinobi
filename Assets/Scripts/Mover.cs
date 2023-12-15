using UnityEngine.AI;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class Mover : MonoBehaviour
{
    private NavMeshAgent _agent;
    private float _ofsetX = 0;
    private float _ofsetSet {
        get { return _ofsetX; }
        set {
            if (_ofsetX + value > 1 || _ofsetX + value < -1)
            {
               
            }
            else _ofsetX += value;
        } 
    }

    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        StandartMove();
    }

    private void StandartMove()
    {
        _agent.SetDestination(new Vector3(_ofsetX, 3, transform.position.z + 1));
    }



    public void MetTheEnemy()
    {
        _agent.isStopped = true;
       
    }
    public void keepGoing()
    {
        _agent.isStopped = false;
    }





    public void Ofseting(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started) 
        {
          _ofsetSet = callbackContext.ReadValue<float>();
        
        }
    }
}
