using System;
using UnityEngine;

namespace _app.Scripts.TriggerExamples
{
    public class TriggerBox : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            Debug.Log(message:other.name + "Entered Trigger");
        }

        public void OnTriggerExit(Collider other)
        {
            Debug.Log(message:other.name + "Exited Trigger");

        }
    }
}