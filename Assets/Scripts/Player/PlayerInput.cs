using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Button _upButton;
    [SerializeField] private Button _downButton;

    private PlayerMover _playerMover;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { 
            _playerMover.TryMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.S))
        { 
            _playerMover.TryMoveDown();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D pressed");
            _playerMover.TryMoveRight();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A pressed");
            _playerMover.TryMoveLeft();
        }
    }
}
