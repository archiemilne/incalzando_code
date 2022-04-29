using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClick : MonoBehaviour
{
    public bool clicked = false;

    public Material A;
    public Material As;
    public Material B;
    public Material C;
    public Material Cs;
    public Material D;
    public Material Ds;
    public Material E;
    public Material F;
    public Material Fs;
    public Material G;
    public Material Gs;
    public Material white;
    public Material black;

    public AudioSource notePlay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NoteDown(){
        if (clicked == false){
            this.transform.Translate(0, -0.5f, 0);
            this.transform.Rotate(-6.2f, 0, 0);
            clicked = true;
        }
    }

    public void NoteUp(){
        if (clicked == true){
            notePlay.Stop();
            this.transform.Rotate(6.2f, 0, 0);
            this.transform.Translate(0, 0.5f, 0);
            if (gameObject.name == "A3" || gameObject.name == "A4" || gameObject.name == "A5" || gameObject.name == "B3" || gameObject.name == "B4" || gameObject.name == "B5" || gameObject.name == "C3" || gameObject.name == "C4" || gameObject.name == "C5" || gameObject.name == "D3" || gameObject.name == "D4" || gameObject.name == "D5" || gameObject.name == "E3" || gameObject.name == "E4" || gameObject.name == "E5" || gameObject.name == "F3" || gameObject.name == "F4" || gameObject.name == "F5" || gameObject.name == "G3" || gameObject.name == "G4" || gameObject.name == "G5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = white;
            }
            else if (gameObject.name == "A#3" || gameObject.name == "A#4" || gameObject.name == "A#5" || gameObject.name == "C#3" || gameObject.name == "C#4" || gameObject.name == "C#5" || gameObject.name == "D#3" || gameObject.name == "D#4" || gameObject.name == "D#5" || gameObject.name == "F#3" || gameObject.name == "F#4" || gameObject.name == "F#5" || gameObject.name == "G#3" || gameObject.name == "G#4" || gameObject.name == "G#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = black;
            }
            clicked = false;
        }
    }

    void OnMouseDown(){
        if (clicked == false){
            if (GameObject.Find ("Canvas").GetComponent<GameText> ().mute == false){
                notePlay.Play();
            }
            
            if (gameObject.name == "A3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = A;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = true;
            }
            else if (gameObject.name == "A4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = A;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = true;
            }
            else if (gameObject.name == "A5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = A;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = true;
            }
            else if (gameObject.name == "A#3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = As;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = true;
            }
            else if (gameObject.name == "A#4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = As;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = true;
            }
            else if (gameObject.name == "A#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = As;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = true;
            }
            else if (gameObject.name == "B3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = B;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = true;
            }
            else if (gameObject.name == "B4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = B;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = true;
            }
            else if (gameObject.name == "B5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = B;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = true;
            }
            else if (gameObject.name == "C3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = C;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = true;
            }
            else if (gameObject.name == "C4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = C;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = true;
            }
            else if (gameObject.name == "C5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = C;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = true;
            }
            else if (gameObject.name == "C#3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Cs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = true;
            }
            else if (gameObject.name == "C#4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Cs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = true;
            }
            else if (gameObject.name == "C#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Cs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = true;
            }
            else if (gameObject.name == "D3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = D;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = true;
            }
            else if (gameObject.name == "D4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = D;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = true;
            }
            else if (gameObject.name == "D5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = D;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = true;
            }
            else if (gameObject.name == "D#3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Ds;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = true;
            }
            else if (gameObject.name == "D#4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Ds;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = true;
            }
            else if (gameObject.name == "D#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Ds;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = true;
            }
            else if (gameObject.name == "E3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = E;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = true;
            }
            else if (gameObject.name == "E4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = E;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = true;
            }
            else if (gameObject.name == "E5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = E;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = true;
            }
            else if (gameObject.name == "F3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = F;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = true;
            }
            else if (gameObject.name == "F4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = F;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = true;
            }
            else if (gameObject.name == "F5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = F;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = true;
            }
            else if (gameObject.name == "F#3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Fs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = true;
            }
            else if (gameObject.name == "F#4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Fs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = true;
            }
            else if (gameObject.name == "F#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Fs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = true;
            }
            else if (gameObject.name == "G3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = G;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = true;
            }
            else if (gameObject.name == "G4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = G;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = true;
            }
            else if (gameObject.name == "G5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = G;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = true;
            }
            else if (gameObject.name == "G#3"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Gs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = true;
            }
            else if (gameObject.name == "G#4"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Gs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = true;
            }
             else if (gameObject.name == "G#5"){
                this.gameObject.GetComponent<MeshRenderer> ().material = Gs;
                GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = true;
            }
            NoteDown();
        }
        else{
            if (gameObject.name == "A3"){
                if ((GameObject.Find ("A4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = false;
                }
            }
            else if (gameObject.name == "A4"){
                if ((GameObject.Find ("A3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = false;
                }
            }
            else if (gameObject.name == "A5"){
                if ((GameObject.Find ("A4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleA = false;
                }
            }
            else if (gameObject.name == "A#3"){
                if ((GameObject.Find ("A#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = false;
                }
            }
            else if (gameObject.name == "A#4"){
                if ((GameObject.Find ("A#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = false;
                }
            }
            else if (gameObject.name == "A#5"){
                if ((GameObject.Find ("A#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "A#4").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleAs = false;
                }
            }
            else if (gameObject.name == "B3"){
                if ((GameObject.Find ("B4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "B5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = false;
                }
            }
            else if (gameObject.name == "B4"){
                if ((GameObject.Find ("B3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "B5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = false;
                }
            }
            else if (gameObject.name == "B5"){
                if ((GameObject.Find ("B4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "B3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleB = false;
                }
            }
            else if (gameObject.name == "C3"){
                if ((GameObject.Find ("C4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = false;
                }
            }
            else if (gameObject.name == "C4"){
                if ((GameObject.Find ("C3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = false;
                }
            }
            else if (gameObject.name == "C5"){
                if ((GameObject.Find ("C4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleC = false;
                }
            }
            else if (gameObject.name == "C#3"){
                if ((GameObject.Find ("C#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = false;
                }
            }
            else if (gameObject.name == "C#4"){
                if ((GameObject.Find ("C#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = false;
                }
            }
            else if (gameObject.name == "C#5"){
                if ((GameObject.Find ("C#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "C#3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleCs = false;
                }
            }
            else if (gameObject.name == "D3"){
                if ((GameObject.Find ("D4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = false;
                }
            }
            else if (gameObject.name == "D4"){
                if ((GameObject.Find ("D3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = false;
                }
            }
            else if (gameObject.name == "D5"){
                if ((GameObject.Find ("D4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleD = false;
                }
            }
            else if (gameObject.name == "D#3"){
                if ((GameObject.Find ("D#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = false;
                }
            }
            else if (gameObject.name == "D#4"){
                if ((GameObject.Find ("D#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = false;
                }
            }
            else if (gameObject.name == "D#5"){
                if ((GameObject.Find ("D#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "D#3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleDs = false;
                }
            }
            else if (gameObject.name == "E3"){
                if ((GameObject.Find ("E4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "E5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = false;
                }
            }
            else if (gameObject.name == "E4"){
                if ((GameObject.Find ("E3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "E5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = false;
                }
            }
            else if (gameObject.name == "E5"){
                if ((GameObject.Find ("E4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "E3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleE = false;
                }
            }
            else if (gameObject.name == "F3"){
                if ((GameObject.Find ("F4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = false;
                }
            }
            else if (gameObject.name == "F4"){
                if ((GameObject.Find ("F3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = false;
                }
            }
            else if (gameObject.name == "F5"){
                if ((GameObject.Find ("F4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleF = false;
                }
            }
            else if (gameObject.name == "F#3"){
                if ((GameObject.Find ("F#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = false;
                }
            }
            else if (gameObject.name == "F#4"){
                if ((GameObject.Find ("F#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = false;
                }
            }
            else if (gameObject.name == "F#5"){
                if ((GameObject.Find ("F#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "F#3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleFs = false;
                }
            }
            else if (gameObject.name == "G3"){
                if ((GameObject.Find ("G4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = false;
                }
            }
            else if (gameObject.name == "G4"){
                if ((GameObject.Find ("G3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = false;
                }
            }
            else if (gameObject.name == "G5"){
                if ((GameObject.Find ("G4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleG = false;
                }
            }
            else if (gameObject.name == "G#3"){
                if ((GameObject.Find ("G#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = false;
                }
            }
            else if (gameObject.name == "G#4"){
                if ((GameObject.Find ("G#3").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G#5").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = false;
                }
            }
             else if (gameObject.name == "G#5"){
                if ((GameObject.Find ("G#4").GetComponent<NoteClick> ().clicked == false) && (GameObject.Find( "G#3").GetComponent<NoteClick> ().clicked == false)){
                    GameObject.Find ("Piano Base").GetComponent<Game> ().toggleGs = false;
                }
            }
            NoteUp();
        }
    }
}
