﻿using UnityEngine;

namespace GridPath.Example
{
    public class CamDriver : MonoBehaviour
    {
        private const int Speed = 4;
        private const int ScrollBoundary = 5;
        private float _newXCoordinate;
        private float _newYCoordinate;
        private float _newZCoordinate;
        private float _horizontal;
        private float _vertical;

        public void LateUpdate()
        {
            _vertical = Input.GetAxis("Vertical");
            _horizontal = Input.GetAxis("Horizontal");
            _newXCoordinate = transform.position.x;
            _newYCoordinate = transform.position.y;
            _newZCoordinate = transform.position.z;

            if (Input.mousePosition.x > Screen.width - ScrollBoundary || _horizontal > 0.0f)
            {
                _newXCoordinate += Speed * Time.deltaTime;
            }

            if (Input.mousePosition.x < 0 + ScrollBoundary || _horizontal < 0.0f)
            {
                _newXCoordinate -= Speed * Time.deltaTime;
            }

            if (Input.mousePosition.y > Screen.height - ScrollBoundary || _vertical > 0.0f)
            {
                _newYCoordinate += Speed * Time.deltaTime;
            }

            if (Input.mousePosition.y < 0 + ScrollBoundary || _vertical < 0.0f)
            {
                _newYCoordinate -= Speed * Time.deltaTime;
            }
            transform.position = new Vector3(_newXCoordinate, _newYCoordinate, _newZCoordinate);
        }

    }
}
