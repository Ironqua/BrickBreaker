using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    
    public Sprite[] _brickSprite;

    int hitvaluemax;
    int hitvalue;

    

    private void Start()
    {
        Time.timeScale = 1;
        hitvaluemax = _brickSprite.Length + 1;
        GameManager.Instance.UpdateBrickCount(1);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Ball"))
        {
            hitvalue++;
                GameManager.Instance.Score();
            if (hitvalue >= hitvaluemax)
            {
                GameManager.Instance.UpdateBrickCount(-1);
                if (GameManager.Instance.GetCurrentBrickCount() <= 0)
                {
                    GameManager.Instance.ActivePanel();
                    Time.timeScale = 0;
                }
               Destroy(this.gameObject);
              
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = _brickSprite[hitvalue-1];
            }
           
            
        }

    }
}
