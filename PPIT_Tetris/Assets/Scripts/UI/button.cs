using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    [SerializeField]public Sprite newButtonSprite;
    [SerializeField] public Sprite oldButtonSprite;
    [SerializeField]public Button bt;
    private bool isMutedImageChanged = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void isMuted()
    {
       
        if(isMutedImageChanged == false)
        {
            bt.image.sprite = newButtonSprite;
            isMutedImageChanged = true;
        }
        else
        {
            bt.image.sprite = oldButtonSprite;
            isMutedImageChanged = false;
            print("unmute");
        }
        
    }
}
