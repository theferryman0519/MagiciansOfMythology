using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons07 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Level Items
    public Button RandomButton;
    public Button LevelButton1On;
    public Button LevelButton2On;
    public Button LevelButton3On;
    public Button LevelButton4On;
    public Button LevelButton5On;
    public Button BackButton;

    // City Items
    public Button CityA1On;
    public Button CityA2On;
    public Button CityA3On;
    public Button CityA4On;
    public Button CityA5On;
    public Button CityB1On;
    public Button CityB2On;
    public Button CityB3On;
    public Button CityB4On;
    public Button CityB5On;
    public Button CityC1On;
    public Button CityC2On;
    public Button CityC3On;
    public Button CityC4On;
    public Button CityC5On;
    public Button CityD1On;
    public Button CityD2On;
    public Button CityD3On;
    public Button CityD4On;
    public Button CityD5On;
    public Button CityEOn;
    public Button CityBackButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Changing
    public SceneChange Scene05LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // RandomButton
        Button RandomButtonClick = RandomButton.GetComponent<Button>();
        RandomButtonClick.onClick.AddListener(RandomButtonClicking);

        // LevelButton1On
        Button LevelButton1OnClick = LevelButton1On.GetComponent<Button>();
        LevelButton1OnClick.onClick.AddListener(LevelButton1OnClicking);

        // LevelButton2On
        Button LevelButton2OnClick = LevelButton2On.GetComponent<Button>();
        LevelButton2OnClick.onClick.AddListener(LevelButton2OnClicking);

        // LevelButton3On
        Button LevelButton3OnClick = LevelButton3On.GetComponent<Button>();
        LevelButton3OnClick.onClick.AddListener(LevelButton3OnClicking);

        // LevelButton4On
        Button LevelButton4OnClick = LevelButton4On.GetComponent<Button>();
        LevelButton4OnClick.onClick.AddListener(LevelButton4OnClicking);

        // LevelButton5On
        Button LevelButton5OnClick = LevelButton5On.GetComponent<Button>();
        LevelButton5OnClick.onClick.AddListener(LevelButton5OnClicking);

        // BackButton
        Button BackButtonClick = BackButton.GetComponent<Button>();
        BackButtonClick.onClick.AddListener(BackButtonClicking);

        // CityA1On
        Button CityA1OnClick = CityA1On.GetComponent<Button>();
        CityA1OnClick.onClick.AddListener(CityA1OnClicking);

        // CityA2On
        Button CityA2OnClick = CityA2On.GetComponent<Button>();
        CityA2OnClick.onClick.AddListener(CityA2OnClicking);

        // CityA3On
        Button CityA3OnClick = CityA3On.GetComponent<Button>();
        CityA3OnClick.onClick.AddListener(CityA3OnClicking);

        // CityA4On
        Button CityA4OnClick = CityA4On.GetComponent<Button>();
        CityA4OnClick.onClick.AddListener(CityA4OnClicking);

        // CityA5On
        Button CityA5OnClick = CityA5On.GetComponent<Button>();
        CityA5OnClick.onClick.AddListener(CityA5OnClicking);

        // CityB1On
        Button CityB1OnClick = CityB1On.GetComponent<Button>();
        CityB1OnClick.onClick.AddListener(CityB1OnClicking);

        // CityB2On
        Button CityB2OnClick = CityB2On.GetComponent<Button>();
        CityB2OnClick.onClick.AddListener(CityB2OnClicking);

        // CityB3On
        Button CityB3OnClick = CityB3On.GetComponent<Button>();
        CityB3OnClick.onClick.AddListener(CityB3OnClicking);

        // CityB4On
        Button CityB4OnClick = CityB4On.GetComponent<Button>();
        CityB4OnClick.onClick.AddListener(CityB4OnClicking);

        // CityB5On
        Button CityB5OnClick = CityB5On.GetComponent<Button>();
        CityB5OnClick.onClick.AddListener(CityB5OnClicking);

        // CityC1On
        Button CityC1OnClick = CityC1On.GetComponent<Button>();
        CityC1OnClick.onClick.AddListener(CityC1OnClicking);

        // CityC2On
        Button CityC2OnClick = CityC2On.GetComponent<Button>();
        CityC2OnClick.onClick.AddListener(CityC2OnClicking);

        // CityC3On
        Button CityC3OnClick = CityC3On.GetComponent<Button>();
        CityC3OnClick.onClick.AddListener(CityC3OnClicking);

        // CityC4On
        Button CityC4OnClick = CityC4On.GetComponent<Button>();
        CityC4OnClick.onClick.AddListener(CityC4OnClicking);

        // CityC5On
        Button CityC5OnClick = CityC5On.GetComponent<Button>();
        CityC5OnClick.onClick.AddListener(CityC5OnClicking);

        // CityD1On
        Button CityD1OnClick = CityD1On.GetComponent<Button>();
        CityD1OnClick.onClick.AddListener(CityD1OnClicking);

        // CityD2On
        Button CityD2OnClick = CityD2On.GetComponent<Button>();
        CityD2OnClick.onClick.AddListener(CityD2OnClicking);

        // CityD3On
        Button CityD3OnClick = CityD3On.GetComponent<Button>();
        CityD3OnClick.onClick.AddListener(CityD3OnClicking);

        // CityD4On
        Button CityD4OnClick = CityD4On.GetComponent<Button>();
        CityD4OnClick.onClick.AddListener(CityD4OnClicking);

        // CityD5On
        Button CityD5OnClick = CityD5On.GetComponent<Button>();
        CityD5OnClick.onClick.AddListener(CityD5OnClicking);

        // CityEOn
        Button CityEOnClick = CityEOn.GetComponent<Button>();
        CityEOnClick.onClick.AddListener(CityEOnClicking);

        // CityBackButton
        Button CityBackButtonClick = CityBackButton.GetComponent<Button>();
        CityBackButtonClick.onClick.AddListener(CityBackButtonClicking);
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
    public void RandomButtonClicking() {
        //
    }

    public void LevelButton1OnClicking() {
        EnableObjects07.ShowLevelCities = 1;
    }

    public void LevelButton2OnClicking() {
        EnableObjects07.ShowLevelCities = 2;
    }

    public void LevelButton3OnClicking() {
        EnableObjects07.ShowLevelCities = 3;
    }

    public void LevelButton4OnClicking() {
        EnableObjects07.ShowLevelCities = 4;
    }

    public void LevelButton5OnClicking() {
        EnableObjects07.ShowLevelCities = 5;
    }

    public void BackButtonClicking() {
        Scene05LoadRun.Scene05Load();
    }

    public void CityA1OnClicking() {
        //
    }

    public void CityA2OnClicking() {
        //
    }

    public void CityA3OnClicking() {
        //
    }

    public void CityA4OnClicking() {
        //
    }

    public void CityA5OnClicking() {
        //
    }

    public void CityB1OnClicking() {
        //
    }

    public void CityB2OnClicking() {
        //
    }

    public void CityB3OnClicking() {
        //
    }

    public void CityB4OnClicking() {
        //
    }

    public void CityB5OnClicking() {
        //
    }

    public void CityC1OnClicking() {
        //
    }

    public void CityC2OnClicking() {
        //
    }

    public void CityC3OnClicking() {
        //
    }

    public void CityC4OnClicking() {
        //
    }

    public void CityC5OnClicking() {
        //
    }

    public void CityD1OnClicking() {
        //
    }

    public void CityD2OnClicking() {
        //
    }

    public void CityD3OnClicking() {
        //
    }

    public void CityD4OnClicking() {
        //
    }

    public void CityD5OnClicking() {
        //
    }

    public void CityEOnClicking() {
        //
    }

    public void CityBackButtonClicking() {
        EnableObjects07.ShowLevelCities = 0;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}