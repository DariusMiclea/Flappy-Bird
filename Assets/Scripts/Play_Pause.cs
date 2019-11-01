using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Play_Pause : MonoBehaviour
{
    public Button button;
    
    public Sprite play;
    public Sprite pause;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnClick()
    {
        
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            button.image.sprite = play;
        }
        else
        {
            Time.timeScale = 1;
            button.image.sprite = pause;
        }
        
    }
   
}
