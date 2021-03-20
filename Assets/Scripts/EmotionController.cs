using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EmotionColor
{
    blue,
    green,
    pink,
    purple,
    yellow,
    none
}

public class Emotion
{
    EmotionColor emotionColor;
    bool isActive = false;

    public Emotion(EmotionColor ec, bool isA)
    {
        emotionColor = ec;
        isActive = isA;
    }
}

public class EmotionController : MonoBehaviour
{
    private PlayerController player;


    private List<Emotion> emotions = new List<Emotion>();
    
    // Start is called before the first frame update
    void Start()
    {
        player = PlayerController.staticController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Handler(EmotionColor ec)
    {
        if (ec != EmotionColor.none)
        {
            if (emotions.Count < 5)
            {
                AddEmotion(ec);
            }
            
        }
        else
        {
            Debug.Log("null emotion");
            if (emotions.Count > 0) //prevent IndexOutOfRangeException for empty list
            {
                RemoveEmotion();
            }
        }
        // AddEmotion
        // RemoveEmotion

    }

    private void AddEmotion(EmotionColor ec)
    {
        var emotionToAdd = new Emotion(ec, true);
        emotions.Add( emotionToAdd );
    }

    private void RemoveEmotion()
    {
        emotions.RemoveAt(emotions.Count - 1);
    }
}
