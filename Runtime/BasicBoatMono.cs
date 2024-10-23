using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

namespace BeiNico 
{ 
    public class BasicBoatMono : MonoBehaviour
    {
        [ContextMenu("Teleport Forward")]
        public void TeleportForward()
        {
            transform.position += transform.forward * 1;
        }
    }
}
