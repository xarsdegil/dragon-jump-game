using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Concretes.Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
        public bool SpaceKeyDown => Input.GetKeyDown(KeyCode.Space);
    }
}