using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				SoundController.instance.playGameOver();
                Application.LoadLevel(Application.loadedLevelName);
            }
        }
    }
}
