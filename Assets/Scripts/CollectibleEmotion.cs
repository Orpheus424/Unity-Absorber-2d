using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleEmotion : MonoBehaviour
{
    EmotionController emotionController;

    public EmotionColor emotionColor;

    private void Start() 
    {
        emotionController = PlayerController.staticController.transform.GetComponent<EmotionController>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Debug.Log("CollectEmotion");
            switch (emotionColor)
            {
                case EmotionColor.blue: emotionController.SetEmotionWorld(this.gameObject); emotionController.Handle(EmotionColor.blue);    break;
                case EmotionColor.green: emotionController.SetEmotionWorld(this.gameObject); emotionController.Handle(EmotionColor.green);  break;
                case EmotionColor.pink: emotionController.SetEmotionWorld(this.gameObject); emotionController.Handle(EmotionColor.pink);  break;
                case EmotionColor.purple: emotionController.SetEmotionWorld(this.gameObject); emotionController.Handle(EmotionColor.purple);  break;
                case EmotionColor.yellow: emotionController.SetEmotionWorld(this.gameObject); emotionController.Handle(EmotionColor.yellow);  break;
                default: break;
            }
        }
    }
}
