using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgresBar : MonoBehaviour
{
    private const int Procents = 100;
    [SerializeField] private float _onePeocent;
    [SerializeField]private List<Transform> _transformList;
    private Transform _player;
    private Slider _bar;
    private GameObject _path;


    private void Start()
    {
        Initiolization();
        
        foreach (Transform t in _path.transform)
        {
            _transformList.Add(t);
        }
        _onePeocent = (_transformList[1].position.z - _transformList[0].position.z) / Procents;
    }


    private void Update()
    {
      _bar.SetValueWithoutNotify((_player.position.z - _transformList[0].position.z) / _onePeocent / Procents);
    }
    
    
    
    private void Initiolization()
    {
        _bar = GetComponent<Slider>();
        _player = GameObject.FindWithTag("Player").transform;
        _path = GameObject.FindGameObjectWithTag("Path");//нахожу дорогу
    }
}
