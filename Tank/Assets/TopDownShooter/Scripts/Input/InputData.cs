using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "TopDownShooter/Settings/ Input Settings")]
    public class InputData : ScriptableObject
    {
        public float Vertical;
        public float Horizontal;

        [Header("Axis Base Controller")]
        [SerializeField] private bool axisactive;
        [SerializeField] private string axisnamehorizontal;
        [SerializeField] private string axisnamevertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _KeybaseHorizontalactive;
        [SerializeField] private KeyCode PositiveHorizontalKeycode;
        [SerializeField] private KeyCode NegativeHorizontalKeycode;

        [SerializeField] private bool _KeybaseVerticaltalactive;
        [SerializeField] private KeyCode PositiveVerticalKeycode;
        [SerializeField] private KeyCode NegativeVerticalKeycode;
        [SerializeField] private float _increaseamount = 1;

        public void processinput()
        {
            if (axisactive)
            {
                Horizontal = Input.GetAxis(axisnamehorizontal);
                Vertical = Input.GetAxis(axisnamevertical);
            }
            else
            {
                if (_KeybaseHorizontalactive)
                {
                    KeybaseAxisControl(ref Horizontal, PositiveHorizontalKeycode, NegativeHorizontalKeycode);
                }
                if (_KeybaseVerticaltalactive)
                {
                    KeybaseAxisControl(ref Vertical, PositiveVerticalKeycode, NegativeVerticalKeycode);
                }
            }
        }

        public void KeybaseAxisControl(ref float value, KeyCode positive, KeyCode Negative)
        {
            bool positiveactive = Input.GetKey(positive);
            bool negativeactive = Input.GetKey(Negative);

            if (positiveactive && !negativeactive)
            {
                value = Mathf.Lerp(value, 1, Time.time * _increaseamount);
            }
            else if (!positiveactive && negativeactive)
            {
                value = Mathf.Lerp(value, -1, Time.time * _increaseamount);
            }
            else
            {
                value = Mathf.Lerp(value, 0, Time.time * _increaseamount);
            }
        }
    }
}