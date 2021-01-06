﻿using System.Collections;
using UnityEngine;

namespace NDRSims
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] float panSpeed = 20f;
        [SerializeField] float panBorderThickness = 10f;
        [SerializeField] Vector2 panLimit = new Vector2(20, 20);
        [SerializeField] float scrollSpeed= 20f;
        [SerializeField] Vector2 scrollLimit = new Vector2(20f, 120f);


        void Update()
        {
            Vector3 pos = transform.position;

            if(Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
            {
                pos.z += panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                pos.z -= panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
            {
                pos.x += panSpeed * Time.deltaTime;
            }
            if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                pos.x -= panSpeed * Time.deltaTime;
            }

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

            pos.x = Mathf.Clamp(pos.x, -panLimit.x, +panLimit.x);
            pos.y = Mathf.Clamp(pos.y, scrollLimit.x, scrollLimit.y);
            pos.z = Mathf.Clamp(pos.z, -panLimit.y, +panLimit.y);


            transform.position = pos; 
        }
    }
}