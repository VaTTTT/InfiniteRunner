using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _increasingRate;
    
    private void Start()
    {
        StartCoroutine("IncreaseSpeed");
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    public IEnumerator IncreaseSpeed()
    {
        for (; ; )
        {
            _speed += _increasingRate;
            yield return new WaitForSeconds(1);
        }
    }
}
