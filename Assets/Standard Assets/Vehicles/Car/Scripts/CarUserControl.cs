using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {	
		public string horizontal = "Horizontal_P1";
		public string vertical = "Vertical_P1";

        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
			float h = CrossPlatformInputManager.GetAxis(horizontal);
			float v = CrossPlatformInputManager.GetAxis(vertical);
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump_P1");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
