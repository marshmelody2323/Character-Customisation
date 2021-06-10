using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteChanger : MonoBehaviour
{

    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0; //Makes it so it just resets and cycles through again
        }

        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1; //Makes it so it just resets and cycles through again but the other way around
        }

        bodyPart.sprite = options[currentOption];
    }
  


    public void Submit()
    {
        SceneManager.LoadScene(1);
    }
}
