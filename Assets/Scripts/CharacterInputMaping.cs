using UnityEngine;

namespace Assets.Scripts
{
    class CharacterInputMaping
    {
        private readonly JoystickId joystickId;

        public CharacterInputMaping(JoystickId joystickId)
        {
            this.joystickId = joystickId;
        }

        public Vector3 Movement => new Vector3(Input.GetAxis(joystickId + "Horizontal"), 0.0f, Input.GetAxis(joystickId + "Vertical"));

        public bool Jump => Input.GetButton(joystickId + "Jump");

        public bool Action1 => Input.GetButton(joystickId + "Fire1");

        public bool Action2 => Input.GetButton(joystickId + "Fire2");

        public bool Action3 => Input.GetButton(joystickId + "Fire3");
    }
}
