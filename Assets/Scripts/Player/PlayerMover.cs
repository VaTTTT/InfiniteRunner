using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
//using TMPro.EditorUtilities;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _verticalStepSize;
    [SerializeField] private float _horizontalStepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxWidth;
    [SerializeField] private float _minWidth;
    [SerializeField] private Animator animator;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _movementSpeed * Time.deltaTime);
        }
    }

    public void TryMoveUp()
    {
        if (_targetPosition.y < _maxHeight)
        { 
            SetNextVerticalPosition(_verticalStepSize);
            animator.SetTrigger("Jump");
        }
    }

    public void TryMoveDown()
    {
        if (_targetPosition.y > _minHeight)
        {
            SetNextVerticalPosition(-_verticalStepSize);
            animator.SetTrigger("Fall");
        }
    }

    public void TryMoveLeft()
    {
        if (_targetPosition.x > _minWidth)
        {
            SetNextHorizontalPosition(-_horizontalStepSize);
            //animator.SetTrigger("Jump");
        }
    }

    public void TryMoveRight()
    {
        if (_targetPosition.x < _maxWidth)
        {
            SetNextHorizontalPosition(_horizontalStepSize);
            //animator.SetTrigger("Fall");
        }
    }

    private void SetNextVerticalPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
    }

    private void SetNextHorizontalPosition(float stepSize)
    {
        _targetPosition = new Vector2(_targetPosition.x + stepSize, _targetPosition.y);
    }
}
