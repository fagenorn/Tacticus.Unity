using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHealth : MonoBehaviour
{
    [SerializeField] private float _health = 100;

    private bool _isDead;

    public bool IsDead => _isDead;

    void Update()
    {
        if (_isDead) return;

        if (_health <= 0)
        {
            _isDead = true;
        }
    }
}
