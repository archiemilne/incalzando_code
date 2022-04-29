using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameText : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI chordText;
    public TextMeshProUGUI scoreText2;
    public TextMeshProUGUI hintAndMistakeText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI hintText;

    public bool mute = false;
    public Sprite muteImg;
    public Sprite unmuteImg;
    public Button muteToggle;
    public GameObject hintButton;
    public GameObject hintDisplay;
    public GameObject gameDisplay;

    public Sprite hintOne;
    public Sprite hintTwo;
    public Sprite hintThree;
    public Sprite hintFour;
    public Sprite hintFive;
    public Sprite hintSix;
    public Sprite hintSeven;
    public Sprite hintEight;
    public Sprite hintNine;
    public Sprite hintTen;
    public Sprite hintEleven;
    public Sprite hintTwelve;
    public Sprite hintThirteen;
    public Sprite hintFourteen;
    public Sprite hintFifteen;
    public Sprite hintSixteen;
    public Sprite hintSeventeen;
    public Sprite hintEighteen;
    public Sprite hintNinteen;
    public Sprite hintTwenty;
    public Sprite hintTwentyOne;
    public Sprite hintTwentyTwo;
    public Sprite hintTwentyThree;

    // Start is called before the first frame update
    void Start()
    {
        hintButton.SetActive(false);
        hintDisplay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+Game.score;
        if (Game.gameModeNumber == 1){
            chordText.text = "Current Note: "+Game.currentNote;
        }
        if (Game.gameModeNumber == 2){
            chordText.text = "Current Chord: "+Game.currentNote;
        }
        if (Game.gameModeNumber == 3){
            chordText.text = "Current Chord: "+Game.currentNote+"m";
        }
        if (Game.gameModeNumber == 4){
            chordText.text = "Current Chord: "+Game.currentNote+"5";
        }
        if (Game.gameModeNumber == 5){
            chordText.text = "Current Chord: "+Game.currentNote+"7";
        }
        if (Game.gameModeNumber == 6){
            chordText.text = "Current Chord: "+Game.currentNote+"maj7";
        }
        if (Game.gameModeNumber == 7){
            chordText.text = "Current Chord: "+Game.currentNote+"m7";
        }
        if (Game.gameModeNumber == 8){
            chordText.text = "Current Chord: "+Game.currentNote+"sus2";
        }
        if (Game.gameModeNumber == 9){
            chordText.text = "Current Chord: "+Game.currentNote+"sus4";
        }
        if (Game.gameModeNumber == 10){
            chordText.text = "Current Chord: "+Game.currentNote+"6";
        }
        if (Game.gameModeNumber == 11){
            chordText.text = "Current Chord: "+Game.currentNote+"m6";
        }
        if (Game.gameModeNumber == 12){
            chordText.text = "Current Chord: "+Game.currentNote+"9";
        }
        if (Game.gameModeNumber == 13){
            chordText.text = "Current Chord: "+Game.currentNote+"maj9";
        }
        if (Game.gameModeNumber == 14){
            chordText.text = "Current Chord: "+Game.currentNote+"m9";
        }
        if (Game.gameModeNumber == 15){
            chordText.text = "Current Chord: "+Game.currentNote+"dim";
        }
        if (Game.gameModeNumber == 16){
            chordText.text = "Current Chord: "+Game.currentNote+"dim7";
        }
        if (Game.gameModeNumber == 17){
            chordText.text = "Current Chord: "+Game.currentNote+"aug";
        }
        if (Game.gameModeNumber == 18){
            chordText.text = "Current Chord: "+Game.currentNote+"aug7";
        }
        if (Game.gameModeNumber == 19){
            chordText.text = "Current Chord: "+Game.currentNote+"11";
        }
        if (Game.gameModeNumber == 20){
            chordText.text = "Current Chord: "+Game.currentNote+"m11";
        }
        if (Game.gameModeNumber == 21){
            chordText.text = "Current Chord: "+Game.currentNote+"13";
        }
        if (Game.gameModeNumber == 22){
            chordText.text = "Current Chord: "+Game.currentNote+"maj13";
        }
        if (Game.gameModeNumber == 23){
            chordText.text = "Current Chord: "+Game.currentNote+"m13";
        }

        if (Game.mistakeCount > 2){
            hintButton.SetActive(true);
        }
    }

    public void endScore(){
        scoreText2.text = "Score: "+Game.score;
        if (Game.score == 100){
            hintAndMistakeText.text = "You used "+Game.hintCount+" hints and made "+Game.mistakeCount+" mistakes, well done!";
        }
        else{
            hintAndMistakeText.text = "You used "+Game.hintCount+" hints and made "+Game.mistakeCount+" mistakes, try again!";
        }
    }

    public void Back(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("DifficultyMenu"); 
    }

    public GameObject highscoreObject;
    public void highscoreTextDisplay(){
        if (Game.score == 100){
                highscoreText.text = "Perfect Level!";
            }
            else {
                highscoreText.text = "New Highscore!";
            }
    }

    public void MuteButton(){
        if (mute == false){
            mute = true;
            muteToggle.image.sprite = muteImg;
        }
        else{
            mute = false;
            muteToggle.image.sprite = unmuteImg;
        }
    }

    public void Hint(){
        hintDisplay.SetActive(true);
        gameDisplay.SetActive(false);
        Image img =  GameObject.Find("hintPanel").GetComponent<Image>();
        if (Game.gameModeNumber == 1){
            img.sprite = hintOne;
        }
        if (Game.gameModeNumber == 2){
            img.sprite = hintTwo;
        }
        if (Game.gameModeNumber == 3){
            img.sprite = hintThree;
        }
        if (Game.gameModeNumber == 4){
            img.sprite = hintFour;
        }
        if (Game.gameModeNumber == 5){
            img.sprite = hintFive;
        }
        if (Game.gameModeNumber == 6){
            img.sprite = hintSix;
        }
        if (Game.gameModeNumber == 7){
            img.sprite = hintSeven;
        }
        if (Game.gameModeNumber == 8){
            img.sprite = hintEight;
        }
        if (Game.gameModeNumber == 9){
            img.sprite = hintNine;
        }
        if (Game.gameModeNumber == 10){
            img.sprite = hintTen;
        }
        if (Game.gameModeNumber == 11){
            img.sprite = hintEleven;
        }
        if (Game.gameModeNumber == 12){
            img.sprite = hintTwelve;
        }
        if (Game.gameModeNumber == 13){
            img.sprite = hintThirteen;
        }
        if (Game.gameModeNumber == 14){
            img.sprite = hintFourteen;
        }
        if (Game.gameModeNumber == 15){
            img.sprite = hintFifteen;
        }
        if (Game.gameModeNumber == 16){
            img.sprite = hintSixteen;
        }
        if (Game.gameModeNumber == 17){
            img.sprite = hintSeventeen;
        }
        if (Game.gameModeNumber == 18){
            img.sprite = hintEighteen;
        }
        if (Game.gameModeNumber == 19){
            img.sprite = hintNinteen;
        }
        if (Game.gameModeNumber == 20){
            img.sprite = hintTwenty;
        }
        if (Game.gameModeNumber == 21){
            img.sprite = hintTwentyOne;
        }
        if (Game.gameModeNumber == 22){
            img.sprite = hintTwentyTwo;
        }
        if (Game.gameModeNumber == 23){
            img.sprite = hintTwentyThree;
        }
        Game.score -= 5;
        Game.hintCount ++;
    }

    public void HintBackButton(){
        gameDisplay.SetActive(true);
        hintDisplay.SetActive(false);
    }
}
