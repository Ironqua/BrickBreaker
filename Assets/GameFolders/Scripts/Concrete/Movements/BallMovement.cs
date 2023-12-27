using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    bool ýsPlaying;
    public Rigidbody2D _ballRigidbody;
    GameObject  _playerTransform;
    
    private void Start()
    {
        _playerTransform= GameObject.FindObjectOfType<PlayerController>().gameObject;
        _ballRigidbody =GetComponent<Rigidbody2D>();
      

    }


    private void Update()
    {
        if (!ýsPlaying)
        {
           transform.position = new Vector3(_playerTransform.transform.position.x, transform.position.y, transform.position.z);
            if (Input.GetMouseButton(0))
            {

                _ballRigidbody.velocity = new Vector2(2f, 10f);
                ýsPlaying = true;
            }


        }
    }




    //void BallMove()
    //{

    //    if (!ýsPlaying)
    //    {
    //        transform.position = new Vector3(_playerTransform.transform.position.x, transform.position.y, transform.position.z);
    //    if (Input.GetMouseButton(0))
    //    {

    //        _ballRigidbody.velocity = new Vector2(2f, 10f);
    //            ýsPlaying = true;
    //    }


    //    }

    //}



}
