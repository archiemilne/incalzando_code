using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void back(){  
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu"); 
    }

    public void singleNotes(){
        Game.gameModeNumber = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void majors(){
        Game.gameModeNumber = 2;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void minors(){
        Game.gameModeNumber = 3;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void fifths(){
        Game.gameModeNumber = 4;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void domSevenths(){
        Game.gameModeNumber = 5;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void majSevenths(){
        Game.gameModeNumber = 6;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void minSevenths(){
        Game.gameModeNumber = 7;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void susSecs(){
        Game.gameModeNumber = 8;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void susFourths(){
        Game.gameModeNumber = 9;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void sixths(){
        Game.gameModeNumber = 10;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void minSixths(){
        Game.gameModeNumber = 11;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void domNines(){
        Game.gameModeNumber = 12;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void majNines(){
        Game.gameModeNumber = 13;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void minNines(){
        Game.gameModeNumber = 14;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void dims(){
        Game.gameModeNumber = 15;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void dimSevens(){
        Game.gameModeNumber = 16;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void augs(){
        Game.gameModeNumber = 17;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void augSevens(){
        Game.gameModeNumber = 18;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void elevenths(){
        Game.gameModeNumber = 19;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void minElvenths(){
        Game.gameModeNumber = 20;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void domThirteens(){
        Game.gameModeNumber = 21;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void majThirteens(){
        Game.gameModeNumber = 22;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    
    public void minThirteens(){
        Game.gameModeNumber = 23;
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
