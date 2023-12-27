using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{

    [SerializeField] AudioClip _wallAudio;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Ball"))
        {
            GameManager.Instance.ActivePanel();
            AudioSource.PlayClipAtPoint(_wallAudio, transform.position);
            Time.timeScale = 0f;
        }
    }
}
