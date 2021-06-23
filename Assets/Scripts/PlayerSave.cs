using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSave : MonoBehaviour
{
    public SpriteRenderer bodyPart;
    public List<Sprite> options = new List<Sprite>();
    public string itemName;

    private void Start()
    {
        SetOption();
    }
    private void Update()
    {
        SetOption();
    }

    public void SetOption()
    {
        int loadedOption = PlayerPrefs.GetInt(itemName, 0);

        bodyPart.sprite = options[loadedOption];


    }
}
