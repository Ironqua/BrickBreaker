using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    bool �sPlaying;
    public Rigidbody2D _ballRigidbody;
    GameObject  _playerTransform;
    
    private void Start()
    {
        _playerTransform= GameObject.FindObjectOfType<PlayerController>().gameObject;
        _ballRigidbody =GetComponent<Rigidbody2D>();
      

    }


    private void Update()
    {
        if (!�sPlaying)
        {
           transform.position = new Vector3(_playerTransform.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetMouseButton(0))
            {

                _ballRigidbody.velocity = new Vector2(2f, 10f);
                �sPlaying = true;
            }


        }
    }




    //void BallMove()
    //{

    //    if (!�sPlaying)
    //    {
    //        transform.position = new Vector3(_playerTransform.transform.position.x, transform.position.y, transform.position.z);
    //    if (Input.GetMouseButton(0))
    //    {

    //        _ballRigidbody.velocity = new Vector2(2f, 10f);
    //            �sPlaying = true;
    //    }


    //    }

    //}



}
