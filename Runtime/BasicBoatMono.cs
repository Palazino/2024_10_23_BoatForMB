using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

namespace BeiNico
{
    public class BasicBoatMono : MonoBehaviour
    {

        [Range(-1f, 1f)]
        [SerializeField] public float m_percentHorizontalAxis;
        [Range(-1f, 1f)]
        [SerializeField] public float m_percentVerticalAxis;

        public float moveSpeed = 10f; 
        public float turnSpeed = 5f; 

        void Update()
        {
            MOVE();
        }

        public void SetHorizontal(float percent)
        {
            percent = Mathf.Clamp(percent, -1, 1);
            m_percentHorizontalAxis = percent;
        }
        public void SetVertical(float percent)
        {
            percent = Mathf.Clamp(percent, -1, 1);
            m_percentVerticalAxis = percent;

        }

        private void MOVE()
        {
            
            float moveDirection = m_percentVerticalAxis * moveSpeed * Time.deltaTime;
            transform.Translate(Vector3.forward * moveDirection);

           
            float turnDirection = m_percentHorizontalAxis * turnSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * turnDirection);
        }



        [ContextMenu("Teleport Forward")]
        public void TeleportForward()
        {
            transform.position += transform.forward * 1;
        }

    }
}
