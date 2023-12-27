using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] AudioClip _audioClip;


    private void FixedUpdate()
    {
        MoveHandle();
    }

    void MoveHandle()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        float newPos = Mathf.Clamp(pos.x, -4f, 4f);
        transform.position = new Vector3(newPos, transform.position.y, transform.position.z);
      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(_audioClip, transform.position);
    }
}
