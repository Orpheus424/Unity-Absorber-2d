using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableBehaviour : MonoBehaviour
{
    public Sprite deadSprite;
    // Start is called before the first frame update

    private void Start()
    {

    }

    public void Kill()
    {
        GetComponent<SpriteRenderer>().sprite = deadSprite;
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<BoxCollider2D>().enabled = false;
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAA!!!");
    }
}
