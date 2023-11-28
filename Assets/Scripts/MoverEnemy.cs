using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxPositionX;

    private Vector3 _target;
    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
        _target = new Vector3(_maxPositionX, transform.position.y, 0);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        
        if (transform.position.x == _target.x)
        {
            Vector3 temporaryVector = _target;
            _target = _startPosition;
            _startPosition = temporaryVector;
            transform.Rotate(0, 180, 0);
        }
    }
}
