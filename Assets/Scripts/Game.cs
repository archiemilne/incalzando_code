using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    //Notes
    public bool toggleA;
    public bool toggleAs;
    public bool toggleB;
    public bool toggleC;
    public bool toggleCs;
    public bool toggleD;
    public bool toggleDs;
    public bool toggleE;
    public bool toggleF;
    public bool toggleFs;
    public bool toggleG;
    public bool toggleGs;

    //Majors (e.g. 'C')
    public bool A = false;
    public bool As = false;
    public bool B = false;
    public bool C = false;
    public bool Cs = false;
    public bool D = false;
    public bool Ds = false;
    public bool E = false;
    public bool F = false;
    public bool Fs = false;
    public bool G = false;
    public bool Gs = false;

    //Minors (e.g. 'Cm')
    public bool Am = false;
    public bool Asm = false;
    public bool Bm = false;
    public bool Cm = false;
    public bool Csm = false;
    public bool Dm = false;
    public bool Dsm = false;
    public bool Em = false;
    public bool Fm = false;
    public bool Fsm = false;
    public bool Gm = false;
    public bool Gsm = false;

    //Fifths (e.g. 'C5')
    public bool A5 = false;
    public bool As5 = false;
    public bool B5 = false;
    public bool C5 = false;
    public bool Cs5 = false;
    public bool D5 = false;
    public bool Ds5 = false;
    public bool E5 = false;
    public bool F5 = false;
    public bool Fs5 = false;
    public bool G5 = false;
    public bool Gs5 = false;

    //Sixths (e.g. 'C6')
    public bool A6 = false;
    public bool As6 = false;
    public bool B6 = false;
    public bool C6 = false;
    public bool Cs6 = false;
    public bool D6 = false;
    public bool Ds6 = false;
    public bool E6 = false;
    public bool F6 = false;
    public bool Fs6 = false;
    public bool G6 = false;
    public bool Gs6 = false;

    //Minor Sixths (e.g. 'Cm6')
    public bool Am6 = false;
    public bool Asm6 = false;
    public bool Bm6 = false;
    public bool Cm6 = false;
    public bool Csm6 = false;
    public bool Dm6 = false;
    public bool Dsm6 = false;
    public bool Em6 = false;
    public bool Fm6 = false;
    public bool Fsm6 = false;
    public bool Gm6 = false;
    public bool Gsm6 = false;

    //Dominant Sevenths (e.g. 'C7')
    public bool A7 = false;
    public bool As7 = false;
    public bool B7 = false;
    public bool C7 = false;
    public bool Cs7 = false;
    public bool D7 = false;
    public bool Ds7 = false;
    public bool E7 = false;
    public bool F7 = false;
    public bool Fs7 = false;
    public bool G7 = false;
    public bool Gs7 = false;

    //Major Sevenths (e.g. 'Cmaj7')
    public bool Amaj7 = false;
    public bool Asmaj7 = false;
    public bool Bmaj7 = false;
    public bool Cmaj7 = false;
    public bool Csmaj7 = false;
    public bool Dmaj7 = false;
    public bool Dsmaj7 = false;
    public bool Emaj7 = false;
    public bool Fmaj7 = false;
    public bool Fsmaj7 = false;
    public bool Gmaj7 = false;
    public bool Gsmaj7 = false;

    //Minor Sevenths (e.g. 'Cm7')
    public bool Am7 = false;
    public bool Asm7 = false;
    public bool Bm7 = false;
    public bool Cm7 = false;
    public bool Csm7 = false;
    public bool Dm7 = false;
    public bool Dsm7 = false;
    public bool Em7 = false;
    public bool Fm7 = false;
    public bool Fsm7 = false;
    public bool Gm7 = false;
    public bool Gsm7 = false;

    //Dominant Ninths (e.g. 'C9')
    public bool A9 = false;
    public bool As9 = false;
    public bool B9 = false;
    public bool C9 = false;
    public bool Cs9 = false;
    public bool D9 = false;
    public bool Ds9 = false;
    public bool E9 = false;
    public bool F9 = false;
    public bool Fs9 = false;
    public bool G9 = false;
    public bool Gs9 = false;

    //Major Ninths (e.g. 'Cmaj9')
    public bool Amaj9 = false;
    public bool Asmaj9 = false;
    public bool Bmaj9 = false;
    public bool Cmaj9 = false;
    public bool Csmaj9 = false;
    public bool Dmaj9 = false;
    public bool Dsmaj9 = false;
    public bool Emaj9 = false;
    public bool Fmaj9 = false;
    public bool Fsmaj9 = false;
    public bool Gmaj9 = false;
    public bool Gsmaj9 = false;

    //Minor Ninths (e.g. 'Cm9')
    public bool Am9 = false;
    public bool Asm9 = false;
    public bool Bm9 = false;
    public bool Cm9 = false;
    public bool Csm9 = false;
    public bool Dm9 = false;
    public bool Dsm9 = false;
    public bool Em9 = false;
    public bool Fm9 = false;
    public bool Fsm9 = false;
    public bool Gm9 = false;
    public bool Gsm9 = false;

    //Elevenths (e.g. 'C11')
    public bool A11 = false;
    public bool As11 = false;
    public bool B11 = false;
    public bool C11 = false;
    public bool Cs11 = false;
    public bool D11 = false;
    public bool Ds11 = false;
    public bool E11 = false;
    public bool F11 = false;
    public bool Fs11 = false;
    public bool G11 = false;
    public bool Gs11 = false;

    //Minor Elevenths (e.g. 'Cm11')
    public bool Am11 = false;
    public bool Asm11 = false;
    public bool Bm11 = false;
    public bool Cm11 = false;
    public bool Csm11 = false;
    public bool Dm11 = false;
    public bool Dsm11 = false;
    public bool Em11 = false;
    public bool Fm11 = false;
    public bool Fsm11 = false;
    public bool Gm11 = false;
    public bool Gsm11 = false;

    //Dominant Thirteenths (e.g. 'C13')
    public bool A13 = false;
    public bool As13 = false;
    public bool B13 = false;
    public bool C13 = false;
    public bool Cs13 = false;
    public bool D13 = false;
    public bool Ds13 = false;
    public bool E13 = false;
    public bool F13 = false;
    public bool Fs13 = false;
    public bool G13 = false;
    public bool Gs13 = false;

    //Major Thirteenths (e.g. 'Cmaj13')
    public bool Amaj13 = false;
    public bool Asmaj13 = false;
    public bool Bmaj13 = false;
    public bool Cmaj13 = false;
    public bool Csmaj13 = false;
    public bool Dmaj13 = false;
    public bool Dsmaj13 = false;
    public bool Emaj13 = false;
    public bool Fmaj13 = false;
    public bool Fsmaj13 = false;
    public bool Gmaj13 = false;
    public bool Gsmaj13 = false;

    //Minor Thirteenths (e.g. 'Cm13')
    public bool Am13 = false;
    public bool Asm13 = false;
    public bool Bm13 = false;
    public bool Cm13 = false;
    public bool Csm13 = false;
    public bool Dm13 = false;
    public bool Dsm13 = false;
    public bool Em13 = false;
    public bool Fm13 = false;
    public bool Fsm13 = false;
    public bool Gm13 = false;
    public bool Gsm13 = false;

    //Diminisheds (e.g. 'Cdim')
    public bool Adim = false;
    public bool Asdim = false;
    public bool Bdim = false;
    public bool Cdim = false;
    public bool Csdim = false;
    public bool Ddim = false;
    public bool Dsdim = false;
    public bool Edim = false;
    public bool Fdim = false;
    public bool Fsdim = false;
    public bool Gdim = false;
    public bool Gsdim = false;

    //Diminished Sevenths (e.g. 'Cdim7')
    public bool Adim7 = false;
    public bool Asdim7 = false;
    public bool Bdim7 = false;
    public bool Cdim7 = false;
    public bool Csdim7 = false;
    public bool Ddim7 = false;
    public bool Dsdim7 = false;
    public bool Edim7 = false;
    public bool Fdim7 = false;
    public bool Fsdim7 = false;
    public bool Gdim7 = false;
    public bool Gsdim7 = false;

    //Sustained Seconds (e.g. 'Csus2')
    public bool Asus2 = false;
    public bool Assus2 = false;
    public bool Bsus2 = false;
    public bool Csus2 = false;
    public bool Cssus2 = false;
    public bool Dsus2 = false;
    public bool Dssus2 = false;
    public bool Esus2 = false;
    public bool Fsus2 = false;
    public bool Fssus2 = false;
    public bool Gsus2 = false;
    public bool Gssus2 = false;

    //Sustained Fourths (e.g. 'Csus4')
    public bool Asus4 = false;
    public bool Assus4 = false;
    public bool Bsus4 = false;
    public bool Csus4 = false;
    public bool Cssus4 = false;
    public bool Dsus4 = false;
    public bool Dssus4 = false;
    public bool Esus4 = false;
    public bool Fsus4 = false;
    public bool Fssus4 = false;
    public bool Gsus4 = false;
    public bool Gssus4 = false;

    //Augmenteds (e.g. 'Caug')
    public bool Aaug = false;
    public bool Asaug = false;
    public bool Baug = false;
    public bool Caug = false;
    public bool Csaug = false;
    public bool Daug = false;
    public bool Dsaug = false;
    public bool Eaug = false;
    public bool Faug = false;
    public bool Fsaug = false;
    public bool Gaug = false;
    public bool Gsaug = false;

    //Augmented Sevenths (e.g. 'Caug7')
    public bool Aaug7 = false;
    public bool Asaug7 = false;
    public bool Baug7 = false;
    public bool Caug7 = false;
    public bool Csaug7 = false;
    public bool Daug7 = false;
    public bool Dsaug7 = false;
    public bool Eaug7 = false;
    public bool Faug7 = false;
    public bool Fsaug7 = false;
    public bool Gaug7 = false;
    public bool Gsaug7 = false;

    public static int gameModeNumber;
    int levelCount = 12;
    static public string currentNote;
    int currentNoteNumber;
    static public int score;
    static public int mistakeCount;
    static public int hintCount;

    bool doneA = false;
    bool doneAs = false;
    bool doneB = false;
    bool doneC = false;
    bool doneCs = false;
    bool doneD = false;
    bool doneDs = false;
    bool doneE = false;
    bool doneF = false;
    bool doneFs = false;
    bool doneG = false;
    bool doneGs = false;

    // Start is called before the first frame update
    void Start()
    {
        score = 100;
        mistakeCount = 0;
        hintCount = 0;

        //Notes on startup
        ClearNoteToggle();
        end.SetActive(false);
        currentNote = RandomNote();

        correct.SetActive(false);
        incorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Majors (e.g. 'C')
        //A Major
        if (toggleA == true && toggleCs == true && toggleE == true && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            A = true;
        }
        else {
            A = false;
        }
        //A Sharp / B Flat Major
        if(toggleAs == true && toggleD == true && toggleF == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            As = true;
        }
        else{
            As = false;
        }
        //B Major
        if(toggleB == true && toggleDs == true && toggleFs == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            B = true;
        }
        else{
            B = false;
        }
        //C Major
        if(toggleC == true && toggleE == true && toggleG == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleGs == false){
            C = true;
        }
        else{
            C = false;
        }
        //C Sharp / D Flat Major
        if(toggleCs == true && toggleF == true && toggleGs == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false){
            Cs= true;
        }
        else{
            Cs= false;
        }
        //D Major
        if(toggleD == true && toggleFs == true && toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            D = true;
        }
        else{
            D = false;
        }
        //D Sharp / E Flat Major
        if(toggleDs == true && toggleG == true && toggleAs == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            Ds = true;
        }
        else{
            Ds = false;
        }
        //E Major
        if(toggleE == true && toggleGs == true && toggleB == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false){
            E = true;
        }
        else{
            E = false;
        }
        //F Major
        if(toggleF == true && toggleA == true && toggleC == true && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            F = true;
        }
        else{
            F = false;
        }
        //F Sharp / G Flat Major
        if(toggleFs == true && toggleAs == true && toggleCs == true && toggleA == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Fs = true;
        }
        else{
            Fs = false;
        }
        //G Major
        if(toggleG == true && toggleB == true && toggleD == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            G = true;
        }
        else{
            G = false;
        }
        //G Sharp / A Flat Major
        if(toggleGs == true && toggleC == true && toggleDs == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false){
            Gs = true;
        }
        else{
            Gs = false;
        }

        //Minors (e.g. 'Cm')
        //A Minor
        if(toggleA == true && toggleC == true && toggleE == true && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Am = true;
        }
        else{
            Am = false;
        }
        //A Sharp / B Flat Minor
        if(toggleAs == true && toggleCs == true && toggleF == true && toggleA == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            Asm = true;
        }
        else{
            Asm = false;
        }
        //B Minor
        if(toggleB == true && toggleD == true && toggleFs == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Bm = true;
        }
        else{
            Bm = false;
        }
        //C Minor
        if(toggleC == true && toggleDs == true && toggleG == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            Cm = true;
        }
        else{
            Cm = false;
        }
        //C Sharp / D Flat Minor
        if(toggleCs == true && toggleE == true && toggleGs == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false){
            Csm = true;
        }
        else{
            Csm = false;
        }
        //D Minor
        if(toggleD == true && toggleF == true && toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            Dm = true;
        }
        else{
            Dm = false;
        }
        //D Sharp / E Flat Minor
        if(toggleDs == true && toggleFs == true && toggleAs == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Dsm = true;
        }
        else{
            Dsm = false;
        }
        //E Minor
        if(toggleE == true && toggleG == true && toggleB == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleGs == false){
            Em = true;
        }
        else{
            Em = false;
        }
        //F Minor
        if(toggleF == true && toggleGs == true && toggleC == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false){
            Fm = true;
        }
        else{
            Fm = false;
        }
        //F Sharp / G Flat Minor
        if(toggleFs == true && toggleA == true && toggleCs == true && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Fsm = true;
        }
        else{
            Fsm = false;
        }
        //G Minor
        if(toggleG == true && toggleAs == true && toggleD == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            Gm = true;
        }
        else{
            Gm = false;
        }
        //G Sharp / A Flat Minor
        if(toggleGs == true && toggleB == true && toggleDs == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false){
            Gsm = true;
        }
        else{
            Gsm = false;
        }

        //Fifths (e.g. 'C5')
        //A Fifth
        if(toggleA == true && toggleE == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            A5 = true;
        }
        else{
            A5 = false;
        }
        //A Sharp / B Flat Fifth
        if(toggleAs == true && toggleF == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            As5 = true;
        }
        else{
            As5 = false;
        }
        //B Fifth
        if(toggleB == true && toggleFs == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            B5 = true;
        }
        else{
            B5 = false;
        }
        //C Fifth
        if(toggleC == true && toggleG == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            C5 = true;
        }
        else{
            C5 = false;
        }
        //C Sharp / D Flat Fifth
        if(toggleCs == true && toggleGs == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false){
            Cs5 = true;
        }
        else{
            Cs5 = false;
        }
        //D Fifth
        if(toggleD == true && toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            D5 = true;
        }
        else{
            D5 = false;
        }
        //D Sharp / E Flat Fifth
        if(toggleDs == true && toggleAs == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Ds5 = true;
        }
        else{
            Ds5 = false;
        }
        //E Fifth
        if(toggleE == true && toggleB == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            E5 = true;
        }
        else{
            E5 = false;
        }
        //F Fifth
        if(toggleF == true && toggleC == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            F5 = true;
        }
        else{
            F5 = false;
        }
        //F Sharp / G Flat Fifth
        if(toggleFs == true && toggleCs == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Fs5 = true;
        }
        else{
            Fs5 = false;
        }
        //G Fifth
        if(toggleG == true && toggleD == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            G5 = true;
        }
        else{
            G5 = false;
        }
        //G Sharp / A Flat Fifth
        if(toggleGs == true && toggleDs == true && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false){
            Gs5 = true;
        }
        else{
            Gs5 = false;
        }

        //Sixths (e.g. 'C6')
        //A Sixth
        if(toggleA == true && toggleCs == true && toggleE == true && toggleFs == true && toggleAs == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleF == false && toggleG == false && toggleGs == false){
            A6 = true;
        }
        else{
            A6 = false;
        }
        //A Sharp / B Flat Sixth
        if(toggleAs == true && toggleD == true && toggleF == true && toggleG == true && toggleA == false && toggleB == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleFs == false && toggleGs == false){
            As6 = true;
        }
        else{
            As6 = false;
        }
        //B Sixth
        if(toggleB == true && toggleDs == true && toggleFs == true && toggleGs == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleG == false){
            B6 = true;
        }
        else{
            B6 = false;
        }
        //C Sixth
        if(toggleC == true && toggleE == true && toggleG == true && toggleA == true && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleGs == false){
            C6 = true;
        }
        else{
            C6 = false;
        }
        //C Sharp / D Flat Sixth
        if(toggleCs == true && toggleF == true && toggleGs == true && toggleAs == true && toggleA == false && toggleB == false && toggleC == false && toggleD == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false){
            Cs6 = true;
        }
        else{
            Cs6 = false;
        }
        //D Sixth
        if(toggleD == true && toggleFs == true && toggleA == true && toggleB == true && toggleAs == false && toggleC == false && toggleCs == false && toggleDs == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            D6 = true;
        }
        else{
            D6 = false;
        }
        //D Sharp / E Flat Sixth
        if(toggleDs == true && toggleG == true && toggleAs == true && toggleC == true && toggleA == false && toggleB == false && toggleCs == false && toggleD == false && toggleE == false && toggleF == false && toggleFs == false && toggleGs == false){
            Ds6 = true;
        }
        else{
            Ds6 = false;
        }
        //E Sixth
        if(toggleE == true && toggleGs == true && toggleB == true && toggleCs == true && toggleA == false && toggleAs == false && toggleC == false && toggleD == false && toggleDs == false && toggleF == false && toggleFs == false && toggleG == false){
            E6 = true;
        }
        else{
            E6 = false;
        }
        //F Sixth
        if(toggleF == true && toggleA == true && toggleC == true && toggleD == true && toggleAs == false && toggleB == false && toggleCs == false && toggleDs == false && toggleE == false && toggleFs == false && toggleG == false && toggleGs == false){
            F6 = true;
        }
        else{
            F6 = false;
        }
        //F Sharp / G Flat Sixth
        if(toggleFs == true && toggleAs == true && toggleCs == true && toggleDs == true && toggleA == false && toggleB == false && toggleC == false && toggleD == false && toggleE == false && toggleF == false && toggleG == false && toggleGs == false){
            Fs6 = true;
        }
        else{
            Fs6 = false;
        }
        //G Sixth
        if(toggleG == true && toggleB == true && toggleD == true && toggleE == true && toggleA == false && toggleAs == false && toggleC == false && toggleCs == false && toggleDs == false && toggleF == false && toggleFs == false && toggleGs == false){
            G6 = true;
        }
        else{
            G6 = false;
        }
        //G Sharp / A Flat Sixth
        if(toggleGs == true && toggleC == true && toggleDs == true && toggleF == true && toggleA == false && toggleAs == false && toggleB == false && toggleCs == false && toggleD == false && toggleE == false && toggleFs == false && toggleG == false){
            Gs6 = true;
        }
        else{
            Gs6 = false;
        }

        //Minor Sixths (e.g. 'Cm6')
        //A Minor Sixth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Am6 = true;
        }
        else{
            Am6 = false;
        }
        //A Sharp / B Flat Minor Sixth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Asm6 = true;
        }
        else{
            Asm6 = false;
        }
        //B Minor Sixth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Bm6 = true;
        }
        else{
            Bm6 = false;
        }
        //C Minor Sixth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cm6 = true;
        }
        else{
            Cm6 = false;
        }
        //C Sharp / D Flat Minor Sixth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Csm6 = true;
        }
        else{
            Csm6 = false;
        }
        //D Minor Sixth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Dm6 = true;
        }
        else{
            Dm6 = false;
        }
        //D Sharp / E Flat Minor Sixth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dsm6 = true;
        }
        else{
            Dsm6 = false;
        }
        //E Minor Sixth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Em6 = true;
        }
        else{
            Em6 = false;
        }
        //F Minor Sixth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Fm6 = true;
        }
        else{
            Fm6 = false;
        }
        //F Sharp / G Flat Minor Sixth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsm6 = true;
        }
        else{
            Fsm6 = false;
        }
        //G Minor Sixth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gm6 = true;
        }
        else{
            Gm6 = false;
        }
        //G Sharp / A Flat Minor Sixth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Gsm6 = true;
        }
        else{
            Gsm6 = false;
        }

        //Dominant Sevenths (e.g. 'C7')
        //A Dominant Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            A7 = true;
        }
        else{
            A7 = false;
        }
        //A Sharp / B Flat Dominant Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            As7 = true;
        }
        else{
            As7 = false;
        }
        //B Dominant Seventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            B7 = true;
        }
        else{
            B7 = false;
        }
        //C Dominant Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            C7 = true;
        }
        else{
            C7 = false;
        }
        //C Sharp / D Flat Dominant Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Cs7 = true;
        }
        else{
            Cs7 = false;
        }
        //D Dominant Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            D7 = true;
        }
        else{
            D7 = false;
        }
        //D Sharp / E Flat Dominant Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Ds7 = true;
        }
        else{
            Ds7 = false;
        }
        //E Dominant Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            E7 = true;
        }
        else{
            E7 = false;
        }
        //F Dominant Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            F7 = true;
        }
        else{
            F7 = false;
        }
        //F Sharp / G Flat Dominant Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fs7 = true;
        }
        else{
            Fs7 = false;
        }
        //G Dominant Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            G7 = true;
        }
        else{
            G7 = false;
        }
        //G Sharp / A Flat Dominant Seventh
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gs7 = true;
        }
        else{
            Gs7 = false;
        }

        //Major Sevenths (e.g. 'Cmaj7')
        //A Major Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Amaj7 = true;
        }
        else{
            Amaj7= false;
        }
        //A Sharp / B Flat Major Seventh
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Asmaj7 = true;
        }
        else{
            Asmaj7= false;
        }
        //B Major Seventh
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bmaj7 = true;
        }
        else{
            Bmaj7= false;
        }
        //C Major Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cmaj7 = true;
        }
        else{
            Cmaj7= false;
        }
        //C Sharp / D Flat Major Seventh
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Csmaj7 = true;
        }
        else{
            Csmaj7= false;
        }
        //D Major Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dmaj7 = true;
        }
        else{
            Dmaj7= false;
        }
        //D Sharp / E Flat Major Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Dsmaj7 = true;
        }
        else{
            Dsmaj7= false;
        }
        //E Major Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Emaj7 = true;
        }
        else{
            Emaj7= false;
        }
        //F Major Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Fmaj7 = true;
        }
        else{
            Fmaj7= false;
        }
        //F Sharp / G Flat Major Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == false){
            Fsmaj7 = true;
        }
        else{
            Fsmaj7= false;
        }
        //G Major Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Gmaj7 = true;
        }
        else{
            Gmaj7= false;
        }
        //G Sharp / A Flat Major Seventh
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == true){
            Gsmaj7 = true;
        }
        else{
            Gsmaj7= false;
        }

        //Minor Sevenths (e.g. 'Cm7')
        //A Minor Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Am7 = true;
        }
        else{
            Am7 = false;
        }
        //A Sharp / B Flat Minor Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Asm7 = true;
        }
        else{
            Asm7 = false;
        }
        //B Minor Seventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bm7 = true;
        }
        else{
            Bm7 = false;
        }
        //C Minor Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cm7 = true;
        }
        else{
            Cm7 = false;
        }
        //C Sharp / D Flat Minor Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Csm7 = true;
        }
        else{
            Csm7 = false;
        }
        //D Minor Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Dm7 = true;
        }
        else{
            Dm7 = false;
        }
        //D Sharp / E Flat Minor Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dsm7 = true;
        }
        else{
            Dsm7 = false;
        }
        //E Minor Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Em7 = true;
        }
        else{
            Em7 = false;
        }
        //F Minor Seventh
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Fm7 = true;
        }
        else{
            Fm7 = false;
        }
        //F Sharp / G Flat Minor Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsm7 = true;
        }
        else{
            Fsm7 = false;
        }
        //G Minor Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Gm7 = true;
        }
        else{
            Gm7 = false;
        }
        //G Sharp / A Flat Minor Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gsm7 = true;
        }
        else{
            Gsm7 = false;
        }

        //Dominant Ninths (e.g. 'C9')
        //A Dominant Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            A9 = true;
        }
        else{
            A9 = false;
        }
        //A Sharp / B Flat Dominant Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            As9 = true;
        }
        else{
            As9 = false;
        }
        //B Dominant Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            B9 = true;
        }
        else{
            B9 = false;
        }
        //C Dominant Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            C9 = true;
        }
        else{
            C9 = false;
        }
        //C Sharp / D Flat Dominant Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Cs9 = true;
        }
        else{
            Cs9 = false;
        }
        //D Dominant Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            D9 = true;
        }
        else{
            D9 = false;
        }
        //D Sharp / E Flat Dominant Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Ds9 = true;
        }
        else{
            Ds9 = false;
        }
        //E Dominant Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            E9 = true;
        }
        else{
            E9 = false;
        }
        //F Dominant Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            F9 = true;
        }
        else{
            F9 = false;
        }
        //F Sharp / G Flat Dominant Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fs9 = true;
        }
        else{
            Fs9 = false;
        }
        //G Dominant Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            G9 = true;
        }
        else{
            G9 = false;
        }
        //G Sharp / A Flat Dominant Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gs9 = true;
        }
        else{
            Gs9 = false;
        }

        //Major Ninths (e.g. 'Cmaj9')
        //A Major Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Amaj9 = true;
        }
        else{
            Amaj9 = false;
        }
        //A Sharp / B Flat Major Ninth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Asmaj9 = true;
        }
        else{
            Asmaj9 = false;
        }
        //B Major Ninth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bmaj9 = true;
        }
        else{
            Bmaj9 = false;
        }
        //C Major Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cmaj9 = true;
        }
        else{
            Cmaj9 = false;
        }
        //C Sharp / D Flat Major Ninth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Csmaj9 = true;
        }
        else{
            Csmaj9 = false;
        }
        //D Major Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dmaj9 = true;
        }
        else{
            Dmaj9 = false;
        }
        //D Sharp / E Flat Major Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Dsmaj9 = true;
        }
        else{
            Dsmaj9 = false;
        }
        //E Major Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Emaj9 = true;
        }
        else{
            Emaj9 = false;
        }
        //F Major Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Fmaj9 = true;
        }
        else{
            Fmaj9 = false;
        }
        //F Sharp / G Flat Major Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Fsmaj9 = true;
        }
        else{
            Fsmaj9 = false;
        }
        //G Major Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Gmaj9 = true;
        }
        else{
            Gmaj9 = false;
        }
        //G Sharp / A Flat Major Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == true){
            Gsmaj9 = true;
        }
        else{
            Gsmaj9 = false;
        }

        //Minor Ninths (e.g. 'Cm9')
        //A Minor Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Am9 = true;
        }
        else{
            Am9= false;
        }
        //A Sharp / B Flat Minor Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Asm9 = true;
        }
        else{
            Asm9= false;
        }
        //B Minor Ninth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bm9 = true;
        }
        else{
            Bm9= false;
        }
        //C Minor Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cm9 = true;
        }
        else{
            Cm9= false;
        }
        //C Sharp / D Flat Minor Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Csm9 = true;
        }
        else{
            Csm9= false;
        }
        //D Minor Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Dm9 = true;
        }
        else{
            Dm9= false;
        }
        //D Sharp / E Flat Minor Ninth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == false){
            Dsm9 = true;
        }
        else{
            Dsm9= false;
        }
        //E Minor Ninth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Em9 = true;
        }
        else{
            Em9= false;
        }
        //F Minor Ninth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Fm9 = true;
        }
        else{
            Fm9= false;
        }
        //F Sharp / G Flat Minor Ninth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fsm9 = true;
        }
        else{
            Fsm9= false;
        }
        //G Minor Ninth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Gm9 = true;
        }
        else{
            Gm9= false;
        }
        //G Sharp / A Flat Minor Ninth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gsm9 = true;
        }
        else{
            Gsm9= false;
        }

        //Elevenths (e.g. 'C11')
        //A Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            A11 = true;
        }
        else{
            A11 = false;
        }
        //A Sharp / B Flat Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            As11 = true;
        }
        else{
            As11 = false;
        }
        //B Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            B11 = true;
        }
        else{
            B11 = false;
        }
        //C Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            C11 = true;
        }
        else{
            C11 = false;
        }
        //C Sharp / D Flat Eleventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Cs11 = true;
        }
        else{
            Cs11 = false;
        }
        //D Eleventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            D11 = true;
        }
        else{
            D11 = false;
        }
        //D Sharp / E Flat Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Ds11 = true;
        }
        else{
            Ds11 = false;
        }
        //E Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            E11 = true;
        }
        else{
            E11 = false;
        }
        //F Eleventh
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            F11 = true;
        }
        else{
            F11 = false;
        }
        //F Sharp / G Flat Eleventh
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fs11 = true;
        }
        else{
            Fs11 = false;
        }
        //G Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            G11 = true;
        }
        else{
            G11 = false;
        }
        //G Sharp / A Flat Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gs11 = true;
        }
        else{
            Gs11 = false;
        }

        //Minor Elevenths (e.g. 'Cm11')
        //A Minor Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Am11 = true;
        }
        else{
            Am11 = false;
        }
        //A Sharp / B Flat Minor Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Asm11 = true;
        }
        else{
            Asm11 = false;
        }
        //B Minor Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bm11 = true;
        }
        else{
            Bm11 = false;
        }
        //C Minor Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Cm11 = true;
        }
        else{
            Cm11 = false;
        }
        //C Sharp / D Flat Minor Eleventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Csm11 = true;
        }
        else{
            Csm11 = false;
        }
        //D Minor Eleventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Dm11 = true;
        }
        else{
            Dm11 = false;
        }
        //D Sharp / E Flat Minor Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Dsm11 = true;
        }
        else{
            Dsm11 = false;
        }
        //E Minor Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Em11 = true;
        }
        else{
            Em11 = false;
        }
        //F Minor Eleventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Fm11 = true;
        }
        else{
            Fm11 = false;
        }
        //F Sharp / G Flat Minor Eleventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fsm11 = true;
        }
        else{
            Fsm11 = false;
        }
        //G Minor Eleventh
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Gm11 = true;
        }
        else{
            Gm11 = false;
        }
        //G Sharp / A Flat Minor Eleventh
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gsm11 = true;
        }
        else{
            Gsm11 = false;
        }

        //Dominant Thirteenths (e.g. 'C13')
        //A Dominant Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            A13 = true;
        }
        else{
            A13 = false;
        }
        //A Sharp / B Flat Dominant Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            As13 = true;
        }
        else{
            As13 = false;
        }
        //B Dominant Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            B13 = true;
        }
        else{
            B13 = false;
        }
        //C Dominant Thirteenth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            C13 = true;
        }
        else{
            C13 = false;
        }
        //C Sharp / D Flat Dominant Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Cs13 = true;
        }
        else{
            Cs13 = false;
        }
        //D Dominant Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            D13 = true;
        }
        else{
            D13 = false;
        }
        //D Sharp / E Flat Dominant Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Ds13 = true;
        }
        else{
            Ds13 = false;
        }
        //E Dominant Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            E13 = true;
        }
        else{
            E13 = false;
        }
        //F Dominant Thirteenth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            F13 = true;
        }
        else{
            F13 = false;
        }
        //F Sharp / G Flat Dominant Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fs13 = true;
        }
        else{
            Fs13 = false;
        }
        //G Dominant Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            G13 = true;
        }
        else{
            G13 = false;
        }
        //G Sharp / A Flat Dominant Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Gs13 = true;
        }
        else{
            Gs13 = false;
        }

        //Major Thirteenths (e.g. 'Cmaj13')
        //A Major Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Amaj13 = true;
        }
        else{
            Amaj13 = false;
        }
        //A Sharp / B Flat Major Thirteenth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Asmaj13 = true;
        }
        else{
            Asmaj13 = false;
        }
        //B Major Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Bmaj13 = true;
        }
        else{
            Bmaj13 = false;
        }
        //C Major Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Cmaj13 = true;
        }
        else{
            Cmaj13 = false;
        }
        //C Sharp / D Flat Major Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Csmaj13 = true;
        }
        else{
            Csmaj13 = false;
        }
        //D Major Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dmaj13 = true;
        }
        else{
            Dmaj13 = false;
        }
        //D Sharp / E Flat Major Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Dsmaj13 = true;
        }
        else{
            Dsmaj13 = false;
        }
        //E Major Thirteenth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Emaj13 = true;
        }
        else{
            Emaj13 = false;
        }
        //F Major Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Fmaj13 = true;
        }
        else{
            Fmaj13 = false;
        }
        //F Sharp / G Flat Major Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Fsmaj13 = true;
        }
        else{
            Fsmaj13 = false;
        }
        //G Major Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Gmaj13 = true;
        }
        else{
            Gmaj13 = false;
        }
        //G Sharp / A Flat Major Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Gsmaj13 = true;
        }
        else{
            Gsmaj13 = false;
        }

        //Minor Thirteenths (e.g. 'Cm13')
        //A Minor Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Am13 = true;
        }
        else{
            Am13 = false;
        }
        //A Sharp / B Flat Minor Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Asm13 = true;
        }
        else{
            Asm13 = false;
        }
        //B Minor Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Bm13 = true;
        }
        else{
            Bm13 = false;
        }
        //C Minor Thirteenth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Cm13 = true;
        }
        else{
            Cm13 = false;
        }
        //C Sharp / D Flat Minor Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Csm13 = true;
        }
        else{
            Csm13 = false;
        }
        //D Minor Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Dm13 = true;
        }
        else{
            Dm13 = false;
        }
        //D Sharp / E Flat Minor Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Dsm13 = true;
        }
        else{
            Dsm13 = false;
        }
        //E Minor Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == true && toggleGs == false){
            Em13 = true;
        }
        else{
            Em13 = false;
        }
        //F Minor Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == true){
            Fm13 = true;
        }
        else{
            Fm13 = false;
        }
        //F Sharp / G Flat Minor Thirteenth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fsm13 = true;
        }
        else{
            Fsm13 = false;
        }
        //G Minor Thirteenth
        if(toggleA == true && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Gm13 = true;
        }
        else{
            Gm13 = false;
        }
        //G Sharp / A Flat Minor Thirteenth
        if(toggleA == false && toggleAs == true && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == true && toggleG == false && toggleGs == true){
            Gsm13 = true;
        }
        else{
            Gsm13 = false;
        }

        //Diminisheds (e.g. 'Cdim')
        //A Diminished
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Adim = true;
        }
        else{
            Adim = false;
        }
        //A Sharp / B Flat Diminished
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Asdim = true;
        }
        else{
            Asdim = false;
        }
        //B Diminished
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Bdim = true;
        }
        else{
            Bdim = false;
        }
        //C Diminished
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Cdim = true;
        }
        else{
            Cdim = false;
        }
        //C Sharp / D Flat Diminished
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Csdim = true;
        }
        else{
            Csdim = false;
        }
        //D Diminished
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Ddim = true;
        }
        else{
            Ddim = false;
        }
        //D Sharp / E Flat Diminished
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dsdim = true;
        }
        else{
            Dsdim = false;
        }
        //E Diminished
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Edim = true;
        }
        else{
            Edim = false;
        }
        //F Diminished
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Fdim = true;
        }
        else{
            Fdim = false;
        }
        //F Sharp / G Flat Diminished
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsdim = true;
        }
        else{
            Fsdim = false;
        }
        //G Diminished
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gdim = true;
        }
        else{
            Gdim = false;
        }
        //G Sharp / A Flat Diminished
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Gsdim = true;
        }
        else{
            Gsdim = false;
        }

        //Diminished Sevenths (e.g. 'Cdim7')
        //A Diminished Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Adim7 = true;
        }
        else{
            Adim7 = false;
        }
        //A Sharp / B Flat Diminished Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Asdim7 = true;
        }
        else{
            Asdim7 = false;
        }
        //B Diminished Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Bdim7 = true;
        }
        else{
            Bdim7 = false;
        }
        //C Diminished Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Cdim7 = true;
        }
        else{
            Cdim7 = false;
        }
        //C Sharp / D Flat Diminished Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Csdim7 = true;
        }
        else{
            Csdim7 = false;
        }
        //D Diminished Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Ddim7 = true;
        }
        else{
            Ddim7 = false;
        }
        //D Sharp / E Flat Diminished Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Dsdim7 = true;
        }
        else{
            Dsdim7 = false;
        }
        //E Diminished Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Edim7 = true;
        }
        else{
            Edim7 = false;
        }
        //F Diminished Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Fdim7 = true;
        }
        else{
            Fdim7 = false;
        }
        //F Sharp / G Flat Diminished Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsdim7 = true;
        }
        else{
            Fsdim7 = false;
        }
        //G Diminished Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gdim7 = true;
        }
        else{
            Gdim7 = false;
        }
        //G Sharp / A Flat Diminished Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == true){
            Gsdim7 = true;
        }
        else{
            Gsdim7 = false;
        }

        //Sustained Seconds (e.g. 'Csus2')
        //A Sustained Second
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Asus2 = true;
        }
        else{
            Asus2 = false;
        }
        //A Sharp / B Flat Sustained Second
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Assus2 = true;
        }
        else{
            Assus2 = false;
        }
        //B Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bsus2 = true;
        }
        else{
            Bsus2 = false;
        }
        //C Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Csus2 = true;
        }
        else{
            Csus2 = false;
        }
        //C Sharp / D Flat Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Cssus2 = true;
        }
        else{
            Cssus2 = false;
        }
        //D Sustained Second
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Dsus2 = true;
        }
        else{
            Dsus2 = false;
        }
        //D Sharp / E Flat Sustained Second
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Dssus2 = true;
        }
        else{
            Dssus2 = false;
        }
        //E Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Esus2 = true;
        }
        else{
            Esus2 = false;
        }
        //F Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Fsus2 = true;
        }
        else{
            Fsus2 = false;
        }
        //F Sharp / G Flat Sustained Second
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Fssus2 = true;
        }
        else{
            Fssus2 = false;
        }
        //G Sustained Second
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gsus2 = true;
        }
        else{
            Gsus2 = false;
        }
        //G Sharp / A Flat Sustained Second
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Gssus2 = true;
        }
        else{
            Gssus2 = false;
        }

        //Sustained Fourths (e.g. 'Csus4')
        //A Sustained Fourth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Asus4 = true;
        }
        else{
            Asus4 = false;
        }
        //A Sharp / B Flat Sustained Fourth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Assus4 = true;
        }
        else{
            Assus4 = false;
        }
        //B Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Bsus4 = true;
        }
        else{
            Bsus4 = false;
        }
        //C Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Csus4 = true;
        }
        else{
            Csus4 = false;
        }
        //C Sharp / D Flat Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Cssus4 = true;
        }
        else{
            Cssus4 = false;
        }
        //D Sustained Fourth
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Dsus4 = true;
        }
        else{
            Dsus4 = false;
        }
        //D Sharp / E Flat Sustained Fourth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Dssus4 = true;
        }
        else{
            Dssus4 = false;
        }
        //E Sustained Fourth
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
            Esus4 = true;
        }
        else{
            Esus4 = false;
        }
        //F Sustained Fourth
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Fsus4 = true;
        }
        else{
            Fsus4 = false;
        }
        //F Sharp / G Flat Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fssus4 = true;
        }
        else{
            Fssus4 = false;
        }
        //G Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gsus4 = true;
        }
        else{
            Gsus4 = false;
        }
        //G Sharp / A Flat Sustained Fourth
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Gssus4 = true;
        }
        else{
            Gssus4 = false;
        }

        //Augmenteds (e.g. 'Caug')
        //A Augmented
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Aaug = true;
        }
        else{
            Aaug = false;
        }
        //A Sharp / B Flat Augmented
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Asaug = true;
        }
        else{
            Asaug = false;
        }
        //B Augmented
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Baug = true;
        }
        else{
            Baug = false;
        }
        //C Augmented
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Caug = true;
        }
        else{
            Caug = false;
        }
        //C Sharp / D Flat Augmented
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Csaug = true;
        }
        else{
            Csaug = false;
        }
        //D Augmented
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Daug = true;
        }
        else{
            Daug = false;
        }
        //D Sharp / E Flat Augmented
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Dsaug = true;
        }
        else{
            Dsaug = false;
        }
        //E Augmented
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Eaug = true;
        }
        else{
            Eaug = false;
        }
        //F Augmented
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Faug = true;
        }
        else{
            Faug = false;
        }
        //F Sharp / G Flat Augmented
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsaug = true;
        }
        else{
            Fsaug = false;
        }
        //G Augmented
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Gaug = true;
        }
        else{
            Gaug = false;
        }
        //G Sharp / A Flat Augmented
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Gsaug = true;
        }
        else{
            Gsaug = false;
        }

        //Augmented Sevenths (e.g. 'Caug7')
        //A Augmented Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Aaug7 = true;
        }
        else{
            Aaug7 = false;
        }
        //A Sharp / B Flat Augmented Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Asaug7 = true;
        }
        else{
            Asaug7 = false;
        }
        //B Augmented Seventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Baug7 = true;
        }
        else{
            Baug7 = false;
        }
        //C Augmented Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Caug7 = true;
        }
        else{
            Caug7 = false;
        }
        //C Sharp / D Flat Augmented Seventh
        if(toggleA == true && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Csaug7 = true;
        }
        else{
            Csaug7 = false;
        }
        //D Augmented Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Daug7 = true;
        }
        else{
            Daug7 = false;
        }
        //D Sharp / E Flat Augmented Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
            Dsaug7 = true;
        }
        else{
            Dsaug7 = false;
        }
        //E Augmented Seventh 
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
            Eaug7 = true;
        }
        else{
            Eaug7 = false;
        }
        //F Augmented Seventh
        if(toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
            Faug7 = true;
        }
        else{
            Faug7 = false;
        }
        //F Sharp / G Flat Augmented Seventh
        if(toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
            Fsaug7 = true;
        }
        else{
            Fsaug7 = false;
        }
        //G Augmented Seventh
        if(toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == true && toggleFs == false && toggleG == true && toggleGs == false){
            Gaug7 = true;
        }
        else{
            Gaug7 = false;
        }
        //G Sharp / A Flat Augmented Seventh
        if(toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == true && toggleG == false && toggleGs == true){
            Gsaug7 = true;
        }
        else{
            Gsaug7 = false;
        }

        //debug
        if (A == true){
            Debug.Log("A");
        }
        if (As == true){
            Debug.Log("A#");
        }
        if (B == true){
            Debug.Log("B");
        }
        if (C == true){
            Debug.Log("C");
        }
        if (Cs == true){
            Debug.Log("C#");
        }
        if (D == true){
            Debug.Log("D");
        }
        if (Ds == true){
            Debug.Log("D#");
        }
        if (E == true){
            Debug.Log("E");
        }
        if (F == true){
            Debug.Log("F");
        }
        if (Fs == true){
            Debug.Log("F#");
        }
        if (G == true){
            Debug.Log("G");
        }
        if (Gs == true){
            Debug.Log("G#");
        }

        if (Am == true){
            Debug.Log("Am");
        }
        if (Asm == true){
            Debug.Log("A#m");
        }
        if (Bm == true){
            Debug.Log("Bm");
        }
        if (Cm == true){
            Debug.Log("Cm");
        }
        if (Csm == true){
            Debug.Log("C#m");
        }
        if (Dm == true){
            Debug.Log("Dm");
        }
        if (Dsm == true){
            Debug.Log("D#m");
        }
        if (Em == true){
            Debug.Log("Em");
        }
        if (Fm == true){
            Debug.Log("Fm");
        }
        if (Fsm == true){
            Debug.Log("F#m");
        }
        if (Gm == true){
            Debug.Log("Gm");
        }
        if (Gsm == true){
            Debug.Log("G#m");
        }

        if (A5 == true){
            Debug.Log("A5");
        }
        if (As5 == true){
            Debug.Log("A#5");
        }
        if (B5 == true){
            Debug.Log("B5");
        }
        if (C5 == true){
            Debug.Log("C5");
        }
        if (Cs5 == true){
            Debug.Log("C#5");
        }
        if (D5 == true){
            Debug.Log("D5");
        }
        if (Ds5 == true){
            Debug.Log("D#5");
        }
        if (E5 == true){
            Debug.Log("E5");
        }
        if (F5 == true){
            Debug.Log("F5");
        }
        if (Fs5 == true){
            Debug.Log("F#5");
        }
        if (G5 == true){
            Debug.Log("G5");
        }
        if (Gs5 == true){
            Debug.Log("G#5");
        }

        if (A6 == true){
            Debug.Log("A6");
        }
        if (As6 == true){
            Debug.Log("A#6");
        }
        if (B6 == true){
            Debug.Log("B6");
        }
        if (C6 == true){
            Debug.Log("C6");
        }
        if (Cs6 == true){
            Debug.Log("C#6");
        }
        if (D6 == true){
            Debug.Log("D6");
        }
        if (Ds6 == true){
            Debug.Log("D#6");
        }
        if (E6 == true){
            Debug.Log("E6");
        }
        if (F6 == true){
            Debug.Log("F6");
        }
        if (Fs6 == true){
            Debug.Log("F#6");
        }
        if (G6 == true){
            Debug.Log("G6");
        }
        if (Gs6 == true){
            Debug.Log("G#6");
        }

        if (Am6 == true){
            Debug.Log("Am6");
        }
        if (Asm6 == true){
            Debug.Log("A#m6");
        }
        if (Bm6 == true){
            Debug.Log("Bm6");
        }
        if (Cm6 == true){
            Debug.Log("Cm6");
        }
        if (Csm6 == true){
            Debug.Log("C#m6");
        }
        if (Dm6 == true){
            Debug.Log("Dm6");
        }
        if (Dsm6 == true){
            Debug.Log("D#m6");
        }
        if (Em6 == true){
            Debug.Log("Em6");
        }
        if (Fm6 == true){
            Debug.Log("Fm6");
        }
        if (Fsm6 == true){
            Debug.Log("F#m6");
        }
        if (Gm6 == true){
            Debug.Log("Gm6");
        }
        if (Gsm6 == true){
            Debug.Log("G#m6");
        }

        if (A7 == true){
            Debug.Log("A7");
        }
        if (As7 == true){
            Debug.Log("A#7");
        }
        if (B7 == true){
            Debug.Log("B7");
        }
        if (C7 == true){
            Debug.Log("C7");
        }
        if (Cs7 == true){
            Debug.Log("C#7");
        }
        if (D7 == true){
            Debug.Log("D7");
        }
        if (Ds7 == true){
            Debug.Log("D#7");
        }
        if (E7 == true){
            Debug.Log("E7");
        }
        if (F7 == true){
            Debug.Log("F7");
        }
        if (Fs7 == true){
            Debug.Log("F#7");
        }
        if (G7 == true){
            Debug.Log("G7");
        }
        if (Gs7 == true){
            Debug.Log("G#7");
        }

        if (Amaj7 == true){
            Debug.Log("Amaj7");
        }
        if (Asmaj7 == true){
            Debug.Log("A#maj7");
        }
        if (Bmaj7 == true){
            Debug.Log("Bmaj7");
        }
        if (Cmaj7 == true){
            Debug.Log("Cmaj7");
        }
        if (Csmaj7 == true){
            Debug.Log("C#maj7");
        }
        if (Dmaj7 == true){
            Debug.Log("Dmaj7");
        }
        if (Dsmaj7 == true){
            Debug.Log("D#maj7");
        }
        if (Emaj7 == true){
            Debug.Log("Emaj7");
        }
        if (Fmaj7 == true){
            Debug.Log("Fmaj7");
        }
        if (Fsmaj7 == true){
            Debug.Log("F#maj7");
        }
        if (Gmaj7 == true){
            Debug.Log("Gmaj7");
        }
        if (Gsmaj7 == true){
            Debug.Log("G#maj7");
        }

        if (Am7 == true){
            Debug.Log("Am7");
        }
        if (Asm7 == true){
            Debug.Log("A#m7");
        }
        if (Bm7 == true){
            Debug.Log("Bm7");
        }
        if (Cm7 == true){
            Debug.Log("Cm7");
        }
        if (Csm7 == true){
            Debug.Log("C#m7");
        }
        if (Dm7 == true){
            Debug.Log("Dm7");
        }
        if (Dsm7 == true){
            Debug.Log("D#m7");
        }
        if (Em7 == true){
            Debug.Log("Em7");
        }
        if (Fm7 == true){
            Debug.Log("Fm7");
        }
        if (Fsm7 == true){
            Debug.Log("F#m7");
        }
        if (Gm7 == true){
            Debug.Log("Gm7");
        }
        if (Gsm7 == true){
            Debug.Log("G#m7");
        }

        if (A9 == true){
            Debug.Log("A9");
        }
        if (As9 == true){
            Debug.Log("A#9");
        }
        if (B9 == true){
            Debug.Log("B9");
        }
        if (C9 == true){
            Debug.Log("C9");
        }
        if (Cs9 == true){
            Debug.Log("C#9");
        }
        if (D9 == true){
            Debug.Log("D9");
        }
        if (Ds9 == true){
            Debug.Log("D#9");
        }
        if (E9 == true){
            Debug.Log("E9");
        }
        if (F9 == true){
            Debug.Log("F9");
        }
        if (Fs9 == true){
            Debug.Log("F#9");
        }
        if (G9 == true){
            Debug.Log("G9");
        }
        if (Gs9 == true){
            Debug.Log("G#9");
        }

        if (Amaj9 == true){
            Debug.Log("Amaj9");
        }
        if (Asmaj9 == true){
            Debug.Log("A#maj9");
        }
        if (Bmaj9 == true){
            Debug.Log("Bmaj9");
        }
        if (Cmaj9 == true){
            Debug.Log("Cmaj9");
        }
        if (Csmaj9 == true){
            Debug.Log("C#maj9");
        }
        if (Dmaj9 == true){
            Debug.Log("Dmaj9");
        }
        if (Dsmaj9 == true){
            Debug.Log("D#maj9");
        }
        if (Emaj9 == true){
            Debug.Log("Emaj9");
        }
        if (Fmaj9 == true){
            Debug.Log("Fmaj9");
        }
        if (Fsmaj9 == true){
            Debug.Log("F#maj9");
        }
        if (Gmaj9 == true){
            Debug.Log("Gmaj9");
        }
        if (Gsmaj9 == true){
            Debug.Log("G#maj9");
        }

        if (Am9 == true){
            Debug.Log("Am9");
        }
        if (Asm9 == true){
            Debug.Log("A#m9");
        }
        if (Bm9 == true){
            Debug.Log("Bm9");
        }
        if (Cm9 == true){
            Debug.Log("Cm9");
        }
        if (Csm9 == true){
            Debug.Log("C#m9");
        }
        if (Dm9 == true){
            Debug.Log("Dm9");
        }
        if (Dsm9 == true){
            Debug.Log("D#m9");
        }
        if (Em9 == true){
            Debug.Log("Em9");
        }
        if (Fm9 == true){
            Debug.Log("Fm9");
        }
        if (Fsm9 == true){
            Debug.Log("F#m9");
        }
        if (Gm9 == true){
            Debug.Log("Gm9");
        }
        if (Gsm9 == true){
            Debug.Log("G#m9");
        }

        if (A11 == true){
            Debug.Log("A11");
        }
        if (As11 == true){
            Debug.Log("A#11");
        }
        if (B11 == true){
            Debug.Log("B11");
        }
        if (C11 == true){
            Debug.Log("C11");
        }
        if (Cs11 == true){
            Debug.Log("C#11");
        }
        if (D11 == true){
            Debug.Log("D11");
        }
        if (Ds11 == true){
            Debug.Log("D#11");
        }
        if (E11 == true){
            Debug.Log("E11");
        }
        if (F11 == true){
            Debug.Log("F11");
        }
        if (Fs11 == true){
            Debug.Log("F#11");
        }
        if (G11 == true){
            Debug.Log("G11");
        }
        if (Gs11 == true){
            Debug.Log("G#11");
        }

        if (Am11 == true){
            Debug.Log("Am11");
        }
        if (Asm11 == true){
            Debug.Log("A#m11");
        }
        if (Bm11 == true){
            Debug.Log("Bm11");
        }
        if (Cm11 == true){
            Debug.Log("Cm11");
        }
        if (Csm11 == true){
            Debug.Log("C#m11");
        }
        if (Dm11 == true){
            Debug.Log("Dm11");
        }
        if (Dsm11 == true){
            Debug.Log("D#m11");
        }
        if (Em11 == true){
            Debug.Log("Em11");
        }
        if (Fm11 == true){
            Debug.Log("Fm11");
        }
        if (Fsm11 == true){
            Debug.Log("F#m11");
        }
        if (Gm11 == true){
            Debug.Log("Gm11");
        }
        if (Gsm11 == true){
            Debug.Log("G#m11");
        }

        if (A13 == true){
            Debug.Log("A13");
        }
        if (As13 == true){
            Debug.Log("A#13");
        }
        if (B13 == true){
            Debug.Log("B13");
        }
        if (C13 == true){
            Debug.Log("C13");
        }
        if (Cs13 == true){
            Debug.Log("C#13");
        }
        if (D13 == true){
            Debug.Log("D13");
        }
        if (Ds13 == true){
            Debug.Log("D#13");
        }
        if (E13 == true){
            Debug.Log("E13");
        }
        if (F13 == true){
            Debug.Log("F13");
        }
        if (Fs13 == true){
            Debug.Log("F#13");
        }
        if (G13 == true){
            Debug.Log("G13");
        }
        if (Gs13 == true){
            Debug.Log("G#13");
        }

        if (Amaj13 == true){
            Debug.Log("Amaj13");
        }
        if (Asmaj13 == true){
            Debug.Log("A#maj13");
        }
        if (Bmaj13 == true){
            Debug.Log("Bmaj13");
        }
        if (Cmaj13 == true){
            Debug.Log("Cmaj13");
        }
        if (Csmaj13 == true){
            Debug.Log("C#maj13");
        }
        if (Dmaj13 == true){
            Debug.Log("Dmaj13");
        }
        if (Dsmaj13 == true){
            Debug.Log("D#maj13");
        }
        if (Emaj13 == true){
            Debug.Log("Emaj13");
        }
        if (Fmaj13 == true){
            Debug.Log("Fmaj13");
        }
        if (Fsmaj13 == true){
            Debug.Log("F#maj13");
        }
        if (Gmaj13 == true){
            Debug.Log("Gmaj13");
        }
        if (Gsmaj13 == true){
            Debug.Log("G#maj13");
        }

        if (Am13 == true){
            Debug.Log("Am13");
        }
        if (Asm13 == true){
            Debug.Log("A#m13");
        }
        if (Bm13 == true){
            Debug.Log("Bm13");
        }
        if (Cm13 == true){
            Debug.Log("Cm13");
        }
        if (Csm13 == true){
            Debug.Log("C#m13");
        }
        if (Dm13 == true){
            Debug.Log("Dm13");
        }
        if (Dsm13 == true){
            Debug.Log("D#m13");
        }
        if (Em13 == true){
            Debug.Log("Em13");
        }
        if (Fm13 == true){
            Debug.Log("Fm13");
        }
        if (Fsm13 == true){
            Debug.Log("F#m13");
        }
        if (Gm13 == true){
            Debug.Log("Gm13");
        }
        if (Gsm13 == true){
            Debug.Log("G#m13");
        }

        if (Adim == true){
            Debug.Log("Adim");
        }
        if (Asdim == true){
            Debug.Log("A#dim");
        }
        if (Bdim == true){
            Debug.Log("Bdim");
        }
        if (Cdim == true){
            Debug.Log("Cdim");
        }
        if (Csdim == true){
            Debug.Log("C#dim");
        }
        if (Ddim == true){
            Debug.Log("Ddim");
        }
        if (Dsdim == true){
            Debug.Log("D#dim");
        }
        if (Edim == true){
            Debug.Log("Edim");
        }
        if (Fdim == true){
            Debug.Log("Fdim");
        }
        if (Fsdim == true){
            Debug.Log("F#dim");
        }
        if (Gdim == true){
            Debug.Log("Gdim");
        }
        if (Gsdim == true){
            Debug.Log("G#dim");
        }

        if (Adim7 == true){
            Debug.Log("Adim7");
        }
        if (Asdim7 == true){
            Debug.Log("A#dim7");
        }
        if (Bdim7 == true){
            Debug.Log("Bdim7");
        }
        if (Cdim7 == true){
            Debug.Log("Cdim7");
        }
        if (Csdim7 == true){
            Debug.Log("C#dim7");
        }
        if (Ddim7 == true){
            Debug.Log("Ddim7");
        }
        if (Dsdim7 == true){
            Debug.Log("D#dim7");
        }
        if (Edim7 == true){
            Debug.Log("Edim7");
        }
        if (Fdim7 == true){
            Debug.Log("Fdim7");
        }
        if (Fsdim7 == true){
            Debug.Log("F#dim7");
        }
        if (Gdim7 == true){
            Debug.Log("Gdim7");
        }
        if (Gsdim7 == true){
            Debug.Log("G#dim7");
        }

        if (Asus2 == true){
            Debug.Log("Asus2");
        }
        if (Assus2 == true){
            Debug.Log("A#sus2");
        }
        if (Bsus2 == true){
            Debug.Log("Bsus2");
        }
        if (Csus2 == true){
            Debug.Log("Csus2");
        }
        if (Cssus2 == true){
            Debug.Log("C#sus2");
        }
        if (Dsus2 == true){
            Debug.Log("Dsus2");
        }
        if (Dssus2 == true){
            Debug.Log("D#sus2");
        }
        if (Esus2 == true){
            Debug.Log("Esus2");
        }
        if (Fsus2 == true){
            Debug.Log("Fsus2");
        }
        if (Fssus2 == true){
            Debug.Log("F#sus2");
        }
        if (Gsus2 == true){
            Debug.Log("Gsus2");
        }
        if (Gssus2 == true){
            Debug.Log("G#sus2");
        }

        if (Asus4 == true){
            Debug.Log("Asus4");
        }
        if (Assus4 == true){
            Debug.Log("A#sus4");
        }
        if (Bsus4 == true){
            Debug.Log("Bsus4");
        }
        if (Csus4 == true){
            Debug.Log("Csus4");
        }
        if (Cssus4 == true){
            Debug.Log("C#sus4");
        }
        if (Dsus4 == true){
            Debug.Log("Dsus4");
        }
        if (Dssus4 == true){
            Debug.Log("D#sus4");
        }
        if (Esus4 == true){
            Debug.Log("Esus4");
        }
        if (Fsus4 == true){
            Debug.Log("Fsus4");
        }
        if (Fssus4 == true){
            Debug.Log("F#sus4");
        }
        if (Gsus4 == true){
            Debug.Log("Gsus4");
        }
        if (Gssus4 == true){
            Debug.Log("G#sus4");
        }

        if (Aaug == true){
            Debug.Log("Aaug");
        }
        if (Asaug == true){
            Debug.Log("A#aug");
        }
        if (Baug == true){
            Debug.Log("Baug");
        }
        if (Caug == true){
            Debug.Log("Caug");
        }
        if (Csaug == true){
            Debug.Log("C#aug");
        }
        if (Daug == true){
            Debug.Log("Daug");
        }
        if (Dsaug == true){
            Debug.Log("D#aug");
        }
        if (Eaug == true){
            Debug.Log("Eaug");
        }
        if (Faug == true){
            Debug.Log("Faug");
        }
        if (Fsaug == true){
            Debug.Log("F#aug");
        }
        if (Gaug == true){
            Debug.Log("Gaug");
        }
        if (Gsaug == true){
            Debug.Log("G#aug");
        }

        if (Aaug7 == true){
            Debug.Log("Aaug7");
        }
        if (Asaug7 == true){
            Debug.Log("A#aug7");
        }
        if (Baug7 == true){
            Debug.Log("Baug7");
        }
        if (Caug7 == true){
            Debug.Log("Caug7");
        }
        if (Csaug7 == true){
            Debug.Log("C#aug7");
        }
        if (Daug7 == true){
            Debug.Log("Daug7");
        }
        if (Dsaug7 == true){
            Debug.Log("D#aug7");
        }
        if (Eaug7 == true){
            Debug.Log("Eaug7");
        }
        if (Faug7 == true){
            Debug.Log("Faug7");
        }
        if (Fsaug7 == true){
            Debug.Log("F#aug7");
        }
        if (Gaug7 == true){
            Debug.Log("Gaug7");
        }
        if (Gsaug7 == true){
            Debug.Log("G#aug7");
        }

        if (gameModeNumber == 0){
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        if (gameModeNumber == 1){
            Debug.Log("Number "+gameModeNumber+" is Notes");
            if (levelCount > 0){
                //Debug.Log("The current note is: "+currentNote);
                if (submitAns == true){
                    if (currentNote == "A" && toggleA == true && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && toggleA == false && toggleAs == true && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "B" && toggleA == false && toggleAs == false && toggleB == true && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "C" && toggleA == false && toggleAs == false && toggleB == false && toggleC == true && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == true && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "D" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == true && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == true && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "E" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == true && toggleF == false && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "F" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == true && toggleFs == false && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == true && toggleG == false && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "G" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == true && toggleGs == false){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && toggleA == false && toggleAs == false && toggleB == false && toggleC == false && toggleCs == false && toggleD == false && toggleDs == false && toggleE == false && toggleF == false && toggleFs == false && toggleG == false && toggleGs == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 2){
            Debug.Log("Number "+gameModeNumber+" is Majors (e.g. 'C')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 3){
            Debug.Log("Number "+gameModeNumber+" is Minors (e.g. 'Cm')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 4){
            Debug.Log("Number "+gameModeNumber+" is Fifths (e.g. 'C5')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G5 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs5 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 5){
            Debug.Log("Number "+gameModeNumber+" is Dominant Sevenths (e.g. 'C7')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs7 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 6){
            Debug.Log("Number "+gameModeNumber+" is Major Sevenths (e.g. 'Cmaj7')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Amaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Emaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gmaj7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsmaj7 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 7){
            Debug.Log("Number "+gameModeNumber+" is Minor Sevenths (e.g. 'Cm7')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm7 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 8){
            Debug.Log("Number "+gameModeNumber+" is Sustained Seconds (e.g. 'Csus2')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Asus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Assus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bsus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Csus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cssus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dsus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dssus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Esus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fsus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fssus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gsus2 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gssus2 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 9){
            Debug.Log("Number "+gameModeNumber+" is Sustained Fourths (e.g. 'Csus4')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Asus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Assus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bsus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Csus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cssus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dsus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dssus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Esus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fsus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fssus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gsus4 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gssus4 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 10){
            Debug.Log("Number "+gameModeNumber+" is Sixths (e.g. 'C6')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs6 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 11){
            Debug.Log("Number "+gameModeNumber+" is Minor Sixths (e.g. 'Cm6')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm6 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm6 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 12){
            Debug.Log("Number "+gameModeNumber+" is Dominant Ninths (e.g. 'C9')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs9 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 13){
            Debug.Log("Number "+gameModeNumber+" is Major Ninths (e.g. 'Cmaj9')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Amaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Emaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gmaj9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsmaj9 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 14){
            Debug.Log("Number "+gameModeNumber+" is Minor Ninths (e.g. 'Cm9')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm9 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm9 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 15){
            Debug.Log("Number "+gameModeNumber+" is Diminisheds (e.g. 'Cdim')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Adim == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Ddim == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Edim == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gdim == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsdim == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 16){
            Debug.Log("Number "+gameModeNumber+" is Diminished Sevenths (e.g. 'Cdim7')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Adim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Ddim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Edim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gdim7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsdim7 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 17){
            Debug.Log("Number "+gameModeNumber+" is Augmenteds (e.g. 'Caug')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Aaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Baug == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Caug == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Daug == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Eaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Faug == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gaug == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsaug == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 18){
            Debug.Log("Number "+gameModeNumber+" is Augmented Sevenths (e.g. 'Caug7')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Aaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Baug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Caug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Daug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Eaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Faug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gaug7 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsaug7 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 19){
            Debug.Log("Number "+gameModeNumber+" is Elevenths (e.g. 'C11')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs11 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 20){
            Debug.Log("Number "+gameModeNumber+" is Minor Elevenths (e.g. 'Cm11')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm11 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm11 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 21){
            Debug.Log("Number "+gameModeNumber+" is Dominant Thirteenths (e.g. 'C13')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && A13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && As13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && B13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && C13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Cs13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && D13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Ds13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && E13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && F13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fs13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && G13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gs13 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 22){
            Debug.Log("Number "+gameModeNumber+" is Major Thirteenths (e.g. 'Cmaj13')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Amaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Emaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gmaj13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsmaj13 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
        if (gameModeNumber == 23){
            Debug.Log("Number "+gameModeNumber+" is Minor Thirteenths (e.g. 'Cm13')");
            if (levelCount > 0){
                if (submitAns == true){
                    if (currentNote == "A" && Am13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "A# or Bb" && Asm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "B" && Bm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C" && Cm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "C# or Db" && Csm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D" && Dm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "D# or Eb" && Dsm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "E" && Em13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F" && Fm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "F# or Gb" && Fsm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G" && Gm13 == true){
                        RoundPass();
                    }
                    else if (currentNote == "G# or Ab" && Gsm13 == true){
                        RoundPass();
                    }
                    else{
                        MistakeMade();
                    }
                }
            }
            if (levelCount == 0){
                WinScreen();
            }
        }
    }

    public string RandomNote(){
        currentNoteNumber = Random.Range(1,13);
        if (currentNoteNumber == 1){
            if (doneA == true){
                return RandomNote();
            }
            else{
                doneA = true;
                return "A";
            }
        }
        if (currentNoteNumber == 2){
            if (doneAs == true){
                return RandomNote();
            }
            else{
                doneAs = true;
                return "A# or Bb";
            }
        }
        if (currentNoteNumber == 3){
            if (doneB == true){
                return RandomNote();
            }
            else{
                doneB = true;
                return "B";
            }
        }
        if (currentNoteNumber == 4){
            if (doneC == true){
                return RandomNote();
            }
            else{
                doneC = true;
                return "C";
            }
        }
        if (currentNoteNumber == 5){
            if (doneCs == true){
                return RandomNote();
            }
            else{
                doneCs = true;
                return "C# or Db";
            }
        }
        if (currentNoteNumber == 6){
            if (doneD == true){
                return RandomNote();
            }
            else{
                doneD = true;
                return "D";
            }
        }
        if (currentNoteNumber == 7){
            if (doneDs == true){
                return RandomNote();
            }
            else{
                doneDs = true;
                return "D# or Eb";
            }
        }
        if (currentNoteNumber == 8){
            if (doneE == true){
                return RandomNote();
            }
            else{
                doneE = true;
                return "E";
            }
        }
        if (currentNoteNumber == 9){
            if (doneF == true){
                return RandomNote();
            }
            else{
                doneF = true;
                return "F";
            }
        }
        if (currentNoteNumber == 10){
            if (doneFs == true){
                return RandomNote();
            }
            else{
                doneFs = true;
                return "F# or Gb";
            }
        }
        if (currentNoteNumber == 11){
            if (doneG == true){
                return RandomNote();
            }
            else{
                doneG = true;
                return "G";
            }
        }
        if (currentNoteNumber == 12){
            if (doneGs == true){
                return RandomNote();
            }
            else{
                doneGs = true;
                return "G# or Ab";
            }
        }
        return "done";
    }

    private IEnumerator wait(){
        yield return new WaitForSeconds(3);
        correct.SetActive(false);
        incorrect.SetActive(false);
    }

    public GameObject correct;
    public GameObject incorrect;

    void RoundPass(){
        Debug.Log("Level Passed");
        submitAns = false;
        levelCount -= 1;
        currentNote = RandomNote();
        ClearNoteToggle();
        incorrect.SetActive(false);
        correct.SetActive(true);
        StartCoroutine(wait());
       
    }

    void MistakeMade(){
        Debug.Log("Level Failed");
        score -= 2;
        mistakeCount++;
        submitAns = false;
        ClearNoteToggle();
        correct.SetActive(false);
        incorrect.SetActive(true);
        StartCoroutine(wait());
        
    }

    public GameObject end;
    public GameObject scoreText;
    public GameObject highscoreObject;
    int highscore;
    void WinScreen(){
        Debug.Log("Game won");
        scoreText.SetActive(false);
        end.SetActive(true);
        GameObject.Find ("Canvas").GetComponent<GameText> ().endScore();
        if(gameModeNumber == 1){
            highscore = PlayerPrefs.GetInt("1");
        }
        if(gameModeNumber == 2){
            highscore = PlayerPrefs.GetInt("2");
        }
        if(gameModeNumber == 3){
            highscore = PlayerPrefs.GetInt("3");
        }
        if(gameModeNumber == 4){
            highscore = PlayerPrefs.GetInt("4");
        }
        if(gameModeNumber == 5){
            highscore = PlayerPrefs.GetInt("5");
        }
        if(gameModeNumber == 6){
            highscore = PlayerPrefs.GetInt("6");
        }
        if(gameModeNumber == 7){
            highscore = PlayerPrefs.GetInt("7");
        }
        if(gameModeNumber == 8){
            highscore = PlayerPrefs.GetInt("8");
        }
        if(gameModeNumber == 9){
            highscore = PlayerPrefs.GetInt("9");
        }
        if(gameModeNumber == 10){
            highscore = PlayerPrefs.GetInt("10");
        }
        if(gameModeNumber == 11){
            highscore = PlayerPrefs.GetInt("11");
        }
        if(gameModeNumber == 12){
            highscore = PlayerPrefs.GetInt("12");
        }
        if(gameModeNumber == 13){
            highscore = PlayerPrefs.GetInt("13");
        }
        if(gameModeNumber == 14){
            highscore = PlayerPrefs.GetInt("14");
        }
        if(gameModeNumber == 15){
            highscore = PlayerPrefs.GetInt("15");
        }
        if(gameModeNumber == 16){
            highscore = PlayerPrefs.GetInt("16");
        }
        if(gameModeNumber == 17){
            highscore = PlayerPrefs.GetInt("17");
        }
        if(gameModeNumber == 18){
            highscore = PlayerPrefs.GetInt("18");
        }
        if(gameModeNumber == 19){
            highscore = PlayerPrefs.GetInt("19");
        }
        if(gameModeNumber == 20){
            highscore = PlayerPrefs.GetInt("20");
        }
        if(gameModeNumber == 21){
            highscore = PlayerPrefs.GetInt("21");
        }
        if(gameModeNumber == 22){
            highscore = PlayerPrefs.GetInt("22");
        }
        if(gameModeNumber == 23){
            highscore = PlayerPrefs.GetInt("23");
        }
        if (highscore < score){
            highscore = score;
            GameObject.Find ("Canvas").GetComponent<GameText> ().highscoreTextDisplay();
            if(gameModeNumber == 1){
                PlayerPrefs.SetInt("1",highscore);
            }
            if(gameModeNumber == 2){
                PlayerPrefs.SetInt("2",highscore);
            }
            if(gameModeNumber == 3){
                PlayerPrefs.SetInt("3",highscore);
            }
            if(gameModeNumber == 4){
                PlayerPrefs.SetInt("4",highscore);
            }
            if(gameModeNumber == 5){
                PlayerPrefs.SetInt("5",highscore);
            }
            if(gameModeNumber == 6){
                PlayerPrefs.SetInt("6",highscore);
            }
            if(gameModeNumber == 7){
                PlayerPrefs.SetInt("7",highscore);
            }
            if(gameModeNumber == 8){
                PlayerPrefs.SetInt("8",highscore);
            }
            if(gameModeNumber == 9){
                PlayerPrefs.SetInt("9",highscore);
            }
            if(gameModeNumber == 10){
                PlayerPrefs.SetInt("10",highscore);
            }
            if(gameModeNumber == 11){
                PlayerPrefs.SetInt("11",highscore);
            }
            if(gameModeNumber == 12){
                PlayerPrefs.SetInt("12",highscore);
            }
            if(gameModeNumber == 13){
                PlayerPrefs.SetInt("13",highscore);
            }
            if(gameModeNumber == 14){
                PlayerPrefs.SetInt("14",highscore);
            }
            if(gameModeNumber == 15){
                PlayerPrefs.SetInt("15",highscore);
            }
            if(gameModeNumber == 16){
                PlayerPrefs.SetInt("16",highscore);
            }
            if(gameModeNumber == 17){
                PlayerPrefs.SetInt("17",highscore);
            }
            if(gameModeNumber == 18){
                PlayerPrefs.SetInt("18",highscore);
            }
            if(gameModeNumber == 19){
                PlayerPrefs.SetInt("19",highscore);
            }
            if(gameModeNumber == 20){
                PlayerPrefs.SetInt("20",highscore);
            }
            if(gameModeNumber == 21){
                PlayerPrefs.SetInt("21",highscore);
            }
            if(gameModeNumber == 22){
                PlayerPrefs.SetInt("22",highscore);
            }
            if(gameModeNumber == 23){
                PlayerPrefs.SetInt("23",highscore);
            }
            PlayerPrefs.Save();
        }
        Debug.Log(highscore);
    }

    public void ClearNoteToggle(){
        toggleA = false;
        toggleAs = false;
        toggleB = false;
        toggleC = false;
        toggleCs = false;
        toggleD = false;
        toggleDs = false;
        toggleE = false;
        toggleF = false;
        toggleFs = false;
        toggleG = false;
        toggleGs = false;
    }

    public bool submitAns = false;
    public void SubmitAnswer(){
        submitAns = true;
    }
}
