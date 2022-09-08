using System.Collections;
using System.Collections.Generic;
using Game.Concretes.Combat;
using Game.Concretes.Movements;
using UnityEngine;


namespace Game.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        bool _isMouseClicked, _isSpaceKeyDown;
        Rigidbody2D _rigidbody;
        PcInputController _input;
        Jump _jump;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;

        private void Awake() {
            _rigidbody = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _input = new PcInputController();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _audioSource = GetComponent<AudioSource>();
        }

        private void Update() {
            if(_input.SpaceKeyDown){
                _isSpaceKeyDown = true;
            }
            if(_input.LeftMouseClickDown){
                _isMouseClicked = true;
            }
        }

        private void FixedUpdate() {
            if(_isSpaceKeyDown){
                _jump.JumpAction(_rigidbody);
                _audioSource.Play();
                _isSpaceKeyDown = false;
            }
            if(_isMouseClicked){
                _launchProjectile.LaunchAction();
                _isMouseClicked = false;
            }
        }

    
    }
}

