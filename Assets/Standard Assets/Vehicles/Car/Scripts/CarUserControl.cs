using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
	{
        public Enums.Team team;

	    private string horizontal;
        private string vertical;
        private string jump;
        private string nitro;

        private CarController m_Car; // the car controller we want to use

		private void Awake()
		{
            // get the car controller
            m_Car = GetComponent<CarController>();

            if (team == Enums.Team.A)
            {
                horizontal = "Horizontal_P1";
                vertical = "Vertical_P1";
                jump = "Jump_P1";
                nitro = "Nitro_P1";
            }
            else
            {
                horizontal = "Horizontal_P2";
                vertical = "Vertical_P2";
                jump = "Jump_P2";
                nitro = "Nitro_P2";
            }
		}


		private void FixedUpdate()
		{
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis(horizontal);
            float v = CrossPlatformInputManager.GetAxis(vertical);
            float j = CrossPlatformInputManager.GetAxis(jump);
            float n = CrossPlatformInputManager.GetAxis(nitro);
            
            m_Car.Move(h, v, v, 0f);
            m_Car.Jump(j);
            m_Car.Nitro(n, v);
		}
	}
}
