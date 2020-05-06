﻿using UnityEngine;
using System;

public class PlayerColliderController : MonoBehaviour
{
    public event Action OnEnemyCollided;
    protected void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            OnEnemyCollided?.Invoke();
        }
    }
}
