using System;
using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Enums;
using UnityEngine;

namespace Game.Concretes.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float _moveSpeed;
        Rigidbody2D _rigidBody2D;
        [SerializeField] DirectionEnum direction;

        private void Awake() {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void OnEnable() {
            _rigidBody2D.velocity = SelectDirection() * _moveSpeed;
        }

        private Vector2 SelectDirection()
        {
            Vector2 dir;
            if(direction == DirectionEnum.Left){
                dir = Vector2.left;
            }else{
                dir = Vector2.right;
            }

            return dir;
        }
    }
}
