using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Movements
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 100f;

        public void JumpAction(Rigidbody2D rigidbody){
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * jumpForce);
        }
    }
}
