using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    public SpriteRenderer bodyPart;
    public List<Sprite> options = new List<Sprite>();
    public string name;

    private void Start()
    {
        SetOption();
    }

    public void SetOption()
    {
        int loadedOption = PlayerPrefs.GetInt(name, 0);

        bodyPart.sprite = options[loadedOption];


    }
}
