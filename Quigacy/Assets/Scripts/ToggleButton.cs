using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public Sprite onSprite;
    public Sprite offSprite;

    public Sprite VolSpriteOff;
    public Sprite VolSpriteOn;

    public Image VolImage;  
    private Image imageComponent;

    void Start()
    {
        imageComponent = GetComponent<Image>();

        imageComponent.GetComponent<Button>().onClick.AddListener(OnImageClick);
    }
    void OnImageClick()
    {
        if (imageComponent.sprite == offSprite)
        {
            imageComponent.sprite = onSprite;
            VolImage.sprite = VolSpriteOn;
        }
        else
        {
            imageComponent.sprite = offSprite;
            VolImage.sprite = VolSpriteOff;
        }
    }
}
