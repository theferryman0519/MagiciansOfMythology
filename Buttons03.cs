using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons03 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button NextButton;
    public Button InitialCardA;
    public Button InitialCardB;
    public Button InitialCardC;
    public Button InitialCardD;
    public Button InitialCardE;
    public Button InitialCardF;
    public Button InitialCardG;
    public Button InitialCardH;
    public Button InitialCardI;
    public Button InitialCardJ;
    public Button ZoomPriorButton;
    public Button ZoomNextButton;
    public Button ZoomOffButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene05LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // NextButton
        Button NextButtonClick = NextButton.GetComponent<Button>();
        NextButtonClick.onClick.AddListener(NextButtonClicking);

        // InitialCardA
        Button InitialCardAClick = InitialCardA.GetComponent<Button>();
        InitialCardAClick.onClick.AddListener(InitialCardAClicking);

        // InitialCardB
        Button InitialCardBClick = InitialCardB.GetComponent<Button>();
        InitialCardBClick.onClick.AddListener(InitialCardBClicking);

        // InitialCardC
        Button InitialCardCClick = InitialCardC.GetComponent<Button>();
        InitialCardCClick.onClick.AddListener(InitialCardCClicking);

        // InitialCardD
        Button InitialCardDClick = InitialCardD.GetComponent<Button>();
        InitialCardDClick.onClick.AddListener(InitialCardDClicking);

        // InitialCardE
        Button InitialCardEClick = InitialCardE.GetComponent<Button>();
        InitialCardEClick.onClick.AddListener(InitialCardEClicking);

        // InitialCardF
        Button InitialCardFClick = InitialCardF.GetComponent<Button>();
        InitialCardFClick.onClick.AddListener(InitialCardFClicking);

        // InitialCardG
        Button InitialCardGClick = InitialCardG.GetComponent<Button>();
        InitialCardGClick.onClick.AddListener(InitialCardGClicking);

        // InitialCardH
        Button InitialCardHClick = InitialCardH.GetComponent<Button>();
        InitialCardHClick.onClick.AddListener(InitialCardHClicking);

        // InitialCardI
        Button InitialCardIClick = InitialCardI.GetComponent<Button>();
        InitialCardIClick.onClick.AddListener(InitialCardIClicking);

        // InitialCardJ
        Button InitialCardJClick = InitialCardJ.GetComponent<Button>();
        InitialCardJClick.onClick.AddListener(InitialCardJClicking);

        // ZoomPriorButton
        Button ZoomPriorButtonClick = ZoomPriorButton.GetComponent<Button>();
        ZoomPriorButtonClick.onClick.AddListener(ZoomPriorButtonClicking);

        // ZoomNextButton
        Button ZoomNextButtonClick = ZoomNextButton.GetComponent<Button>();
        ZoomNextButtonClick.onClick.AddListener(ZoomNextButtonClicking);

        // ZoomOffButton
        Button ZoomOffButtonClick = ZoomOffButton.GetComponent<Button>();
        ZoomOffButtonClick.onClick.AddListener(ZoomOffButtonClicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- BUTTON FUNCTIONS --------------------
    public void NextButtonClicking() {
        Scene05LoadRun.Scene05Load();
    }

    public void InitialCardAClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 1;
    }

    public void InitialCardBClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 2;
    }

    public void InitialCardCClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 3;
    }

    public void InitialCardDClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 4;
    }

    public void InitialCardEClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 5;
    }

    public void InitialCardFClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 6;
    }

    public void InitialCardGClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 7;
    }

    public void InitialCardHClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 8;
    }

    public void InitialCardIClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 9;
    }

    public void InitialCardJClicking() {
        EnableObjects03.ZoomInOut = 1;
        EnableObjects03.ZoomCardNumber = 10;
    }

    public void ZoomPriorButtonClicking() {
        if (EnableObjects03.ZoomCardNumber == 2) {
            EnableObjects03.ZoomCardNumber = 1;
        }

        else if (EnableObjects03.ZoomCardNumber == 3) {
            EnableObjects03.ZoomCardNumber = 2;
        }

        else if (EnableObjects03.ZoomCardNumber == 4) {
            EnableObjects03.ZoomCardNumber = 3;
        }

        else if (EnableObjects03.ZoomCardNumber == 5) {
            EnableObjects03.ZoomCardNumber = 4;
        }

        else if (EnableObjects03.ZoomCardNumber == 6) {
            EnableObjects03.ZoomCardNumber = 5;
        }

        else if (EnableObjects03.ZoomCardNumber == 7) {
            EnableObjects03.ZoomCardNumber = 6;
        }

        else if (EnableObjects03.ZoomCardNumber == 8) {
            EnableObjects03.ZoomCardNumber = 7;
        }

        else if (EnableObjects03.ZoomCardNumber == 9) {
            EnableObjects03.ZoomCardNumber = 8;
        }

        else if (EnableObjects03.ZoomCardNumber == 10) {
            EnableObjects03.ZoomCardNumber = 9;
        }
    }

    public void ZoomNextButtonClicking() {
        if (EnableObjects03.ZoomCardNumber == 1) {
            EnableObjects03.ZoomCardNumber = 2;
        }

        else if (EnableObjects03.ZoomCardNumber == 2) {
            EnableObjects03.ZoomCardNumber = 3;
        }

        else if (EnableObjects03.ZoomCardNumber == 3) {
            EnableObjects03.ZoomCardNumber = 4;
        }

        else if (EnableObjects03.ZoomCardNumber == 4) {
            EnableObjects03.ZoomCardNumber = 5;
        }

        else if (EnableObjects03.ZoomCardNumber == 5) {
            EnableObjects03.ZoomCardNumber = 6;
        }

        else if (EnableObjects03.ZoomCardNumber == 6) {
            EnableObjects03.ZoomCardNumber = 7;
        }

        else if (EnableObjects03.ZoomCardNumber == 7) {
            EnableObjects03.ZoomCardNumber = 8;
        }

        else if (EnableObjects03.ZoomCardNumber == 8) {
            EnableObjects03.ZoomCardNumber = 9;
        }

        else if (EnableObjects03.ZoomCardNumber == 9) {
            EnableObjects03.ZoomCardNumber = 10;
        }
    }

    public void ZoomOffButtonClicking() {
        EnableObjects03.ZoomInOut = 0;
        EnableObjects03.ZoomCardNumber = 1;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}