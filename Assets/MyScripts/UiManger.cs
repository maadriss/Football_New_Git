using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManger : MonoBehaviour
{
    public GameObject header;
    public GameObject footer;
    public GameObject mainCanvas;

    public GameObject gameStartCanvas;
    public GameObject randomMatch;

    public GameObject menuChoise;

    public GameObject[] mainMenuPanel=new GameObject[5];//From Left To Right 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onstart()
    {
        mainCanvas.SetActive(false);
        footer.SetActive(false);
        gameStartCanvas.SetActive(true);
    }

    public void OnRandomMatch()
    {
        gameStartCanvas.SetActive(false);
        randomMatch.SetActive(true);

    }
    public void OnShop()
    {
        PaneDeactivtor(4);

        TransformTheMenuChoise(89.5f);
    }
    public void OnClub()
    {
        PaneDeactivtor(3);

      TransformTheMenuChoise(48.9f);
       
    }

    public void OnStartPanel()
    {
        PaneDeactivtor(2);
        TransformTheMenuChoise(0.5f);
    }
   

    public void CreateQuestion()
    {
        PaneDeactivtor(1);

        TransformTheMenuChoise(-51.2f);
    }

    public void OnSetting()
    {
        PaneDeactivtor(0);
        TransformTheMenuChoise(-91.6f);

    }

    public void TransformTheMenuChoise(float x )
    {
        menuChoise.GetComponent<RectTransform>().anchoredPosition = new Vector3(x, -3.1f);
    }

    public void PaneDeactivtor(int index)
    {
        mainMenuPanel[index].SetActive(true);
        for (int i = 0; i < mainMenuPanel.Length; i++)
        {
            if (i != index)
            {
                mainMenuPanel[i].SetActive(false);
            }
        }   
    }
}
