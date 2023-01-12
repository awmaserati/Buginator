using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Buginator.Game
{
    public class SpawnPoint : MonoBehaviour
    {
        public Vector3 Position;

        private void Awake()
        {
            Position = transform.position;
        }
    }
}
