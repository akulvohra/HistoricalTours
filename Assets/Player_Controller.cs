

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player_Motor))]
[RequireComponent(typeof(ConfigurableJoint))]


public class Player_Controller : MonoBehaviour
{

    
     void Start()
     {
     }
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    [SerializeField]
    private float thrusterForce = 1000f;
    [SerializeField]
    private float timer;


    private Player_Motor motor;
        private ConfigurableJoint joint;
   

    void Update() {
        motor = GetComponent<Player_Motor>();
        
        float _xMov = Input.GetAxisRaw("Horizontal");
        float _zMov = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _xMov;
        Vector3 _movVertical = transform.forward * _zMov;

        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        motor.Move(_velocity);

        //calculate rotation as a 3D vector(turing around)
        float _yRot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        //Apply Rotation
        motor.Rotate(_rotation);

        //calculate rotation as a 3D vector(turing around)
        float _xRot = Input.GetAxisRaw("Mouse Y");

        float _cameraRotation = _xRot * lookSensitivity;

        //Apply Rotation
        motor.RotateCamera(_cameraRotation);


        //Thruster
        Vector3 _thrusterForce = Vector3.zero;
        if (Input.GetButton("Jump"))
        {
            _thrusterForce = Vector3.up * thrusterForce;
        }

        motor.ApplyThruster(_thrusterForce);
        if(speed == 0f)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                speed = 5f;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Fact")
        {
            speed = 0f;
            timer = 27f;
        }

        if (collision.gameObject.tag == "WallTag")
        {
            speed = 0f;
            timer = 20f;
        }

        if (collision.gameObject.tag == "ChurchTag")
        {
            speed = 0f;
            timer = 31f;
        }

        if (collision.gameObject.tag == "PortTag")
        {
            speed = 0f;
            timer = 12f;
        }

        if (collision.gameObject.tag == "StoreTag")
        {
            speed = 0f;
            timer = 13f;
        }

        if (collision.gameObject.tag == "StreetTag")
        {
            speed = 0f;
            timer = 13f;
        }

        if (collision.gameObject.tag == "WarTag")
        {
            speed = 0f;
            timer = 16f;
        }

        if (collision.gameObject.tag == "DeckTag")
        {
            speed = 0f;
            timer = 8f;
        }

        if (collision.gameObject.tag == "MosqueTag")
        {
            speed = 0f;
            timer = 34f;
        }

        if (collision.gameObject.tag == "FinishTag")
        {
            speed = 0f;
        }
    }
}

