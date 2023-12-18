using UnityEngine.AI;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class Mover : MonoBehaviour
{
    [SerializeField]private NavMeshAgent _agent;
    private float _ofsetX = 0;
    private float _step=1;

    private float _ofsetSet {
        get { return _ofsetX; }
        set {
            if (_ofsetX + value > 1 || _ofsetX + value < -1)
            {
               
            }
            else _ofsetX += value;
        } 
    }

    private void Update()
    {
        StandartMove();
    }

    private void StandartMove()
    {
        _agent.SetDestination(new Vector3(_ofsetX, 3, transform.position.z+ _step));
    }



   

    public void MoveState(bool isStoped)
    {
        _agent.isStopped = isStoped;
    }



    public void Ofseting(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started) 
        {
          _ofsetSet = callbackContext.ReadValue<float>();
        
        }
    }
}
