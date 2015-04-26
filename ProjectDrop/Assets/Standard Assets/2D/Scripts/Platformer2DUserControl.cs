using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;



namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
		public float startSpeed = 1;
		public float speedUp = 0.01f;
		private Text txtScore;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
			//InvokeRepeating ("GetFaster", 0, 1);
			txtScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		
        }
	




        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);
            // Pass all parameters to the character control script.
			startSpeed = startSpeed + speedUp;

			txtScore.text = ((int)(startSpeed*100)).ToString();
			m_Character.Move(startSpeed, crouch, m_Jump);

            m_Jump = false;
        }
    }
}
