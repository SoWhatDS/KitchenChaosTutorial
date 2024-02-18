using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player _player;
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();

        if (_player == null)
        {
            return;
        }

        _animator.SetBool(IS_WALKING, _player.IsWalking());

    }

    private void Update()
    {
        if (_player == null)
        {
            return;
        }
        _animator.SetBool(IS_WALKING, _player.IsWalking());
    }
}
