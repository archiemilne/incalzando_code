using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonCompColour : MonoBehaviour
{
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    public Button level9;
    public Button level10;
    public Button level11;
    public Button level12;
    public Button level13;
    public Button level14;
    public Button level15;
    public Button level16;
    public Button level17;
    public Button level18;
    public Button level19;
    public Button level20;
    public Button level21;
    public Button level22;
    public Button level23;

    // Start is called before the first frame update
    void Start()
    {
        level1.GetComponent<Image>().color = setColour("1");
        level2.GetComponent<Image>().color = setColour("2");
        level3.GetComponent<Image>().color = setColour("3");
        level4.GetComponent<Image>().color = setColour("4");
        level5.GetComponent<Image>().color = setColour("5");
        level6.GetComponent<Image>().color = setColour("6");
        level7.GetComponent<Image>().color = setColour("7");
        level8.GetComponent<Image>().color = setColour("8");
        level9.GetComponent<Image>().color = setColour("9");
        level10.GetComponent<Image>().color = setColour("10");
        level11.GetComponent<Image>().color = setColour("11");
        level12.GetComponent<Image>().color = setColour("12");
        level13.GetComponent<Image>().color = setColour("13");
        level14.GetComponent<Image>().color = setColour("14");
        level15.GetComponent<Image>().color = setColour("15");
        level16.GetComponent<Image>().color = setColour("16");
        level17.GetComponent<Image>().color = setColour("17");
        level18.GetComponent<Image>().color = setColour("18");
        level19.GetComponent<Image>().color = setColour("19");
        level20.GetComponent<Image>().color = setColour("20");
        level21.GetComponent<Image>().color = setColour("21");
        level22.GetComponent<Image>().color = setColour("22");
        level23.GetComponent<Image>().color = setColour("23");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector4 setColour(string levelNum){
        if (PlayerPrefs.GetInt(levelNum) > 0 && (PlayerPrefs.GetInt(levelNum)) < 34){
            return Color.red;
        }
        else if (PlayerPrefs.GetInt(levelNum) > 33 && (PlayerPrefs.GetInt(levelNum)) < 67){
            return Color.yellow;
        }
        else if (PlayerPrefs.GetInt(levelNum) > 66 && (PlayerPrefs.GetInt(levelNum)) < 100){
            return Color.green;
        }
        else if (PlayerPrefs.GetInt(levelNum) == 100){
            return Color.blue;
        }
        else{
            return Color.white;
        }
    }
}
