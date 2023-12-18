using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;


public class ProgresBar : MonoBehaviour
{
    private Slider _bar;
    private Transform _transform;
    private MyPath _path;

  
    
    [Inject]
    private void Construct(MyPath path, Mover _player)
    {
        
        _transform = _player.transform;
        _path = path;

    }
    
    
    private void Start()
    {
        
        _bar = GetComponent<Slider>();
       
    }



    private void Update()
    {
        Drow((_transform.position.z - _path.start )/ _path.GetDistans());
    }
    public void Drow(float percent)
    {
        _bar.value = percent;
    }

   
}
