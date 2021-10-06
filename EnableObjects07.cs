using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects07 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImageA;
    public Image BackgroundImageB;
    public Image BackgroundImageC;
    public Image BackgroundImageD;
    public Image BackgroundImageE;
    public Text LogoText;

    // Level Items
    public Text ActionText;
    public Image RandomButton;
    public Image LevelButton1Off;
    public Image LevelButton2Off;
    public Image LevelButton3Off;
    public Image LevelButton4Off;
    public Image LevelButton5Off;
    public Image LevelButton1On;
    public Image LevelButton2On;
    public Image LevelButton3On;
    public Image LevelButton4On;
    public Image LevelButton5On;
    public Image BackButton;

    // City Items
    public Image CityA1Off;
    public Image CityA2Off;
    public Image CityA3Off;
    public Image CityA4Off;
    public Image CityA5Off;
    public Image CityB1Off;
    public Image CityB2Off;
    public Image CityB3Off;
    public Image CityB4Off;
    public Image CityB5Off;
    public Image CityC1Off;
    public Image CityC2Off;
    public Image CityC3Off;
    public Image CityC4Off;
    public Image CityC5Off;
    public Image CityD1Off;
    public Image CityD2Off;
    public Image CityD3Off;
    public Image CityD4Off;
    public Image CityD5Off;
    public Image CityEOff;
    public Image CityA1On;
    public Image CityA2On;
    public Image CityA3On;
    public Image CityA4On;
    public Image CityA5On;
    public Image CityB1On;
    public Image CityB2On;
    public Image CityB3On;
    public Image CityB4On;
    public Image CityB5On;
    public Image CityC1On;
    public Image CityC2On;
    public Image CityC3On;
    public Image CityC4On;
    public Image CityC5On;
    public Image CityD1On;
    public Image CityD2On;
    public Image CityD3On;
    public Image CityD4On;
    public Image CityD5On;
    public Image CityEOn;
    public Image CityBackButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static int ShowLevelCities;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgrounds();
        EnableMain();
        ShowLevelCities = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        UpdateShowItems();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    // Main Items
    public void EnableMain() {
        LogoText.enabled = true;
    }

    // Level Items
    public void EnableLevelMain() {
        ActionText.enabled = true;
        RandomButton.enabled = true;
        BackButton.enabled = true;
    }

    public void EnableLevelButton1Off() {
        LevelButton1Off.enabled = true;
    }

    public void EnableLevelButton2Off() {
        LevelButton2Off.enabled = true;
    }

    public void EnableLevelButton3Off() {
        LevelButton3Off.enabled = true;
    }

    public void EnableLevelButton4Off() {
        LevelButton4Off.enabled = true;
    }

    public void EnableLevelButton5Off() {
        LevelButton5Off.enabled = true;
    }

    public void EnableLevelButton1On() {
        LevelButton1On.enabled = true;
    }

    public void EnableLevelButton2On() {
        LevelButton2On.enabled = true;
    }

    public void EnableLevelButton3On() {
        LevelButton3On.enabled = true;
    }

    public void EnableLevelButton4On() {
        LevelButton4On.enabled = true;
    }

    public void EnableLevelButton5On() {
        LevelButton5On.enabled = true;
    }

    // City Items
    public void EnableCityA1Off() {
        CityA1Off.enabled = true;
    }

    public void EnableCityA2Off() {
        CityA2Off.enabled = true;
    }

    public void EnableCityA3Off() {
        CityA3Off.enabled = true;
    }

    public void EnableCityA4Off() {
        CityA4Off.enabled = true;
    }

    public void EnableCityA5Off() {
        CityA5Off.enabled = true;
    }

    public void EnableCityB1Off() {
        CityB1Off.enabled = true;
    }

    public void EnableCityB2Off() {
        CityB2Off.enabled = true;
    }

    public void EnableCityB3Off() {
        CityB3Off.enabled = true;
    }

    public void EnableCityB4Off() {
        CityB4Off.enabled = true;
    }

    public void EnableCityB5Off() {
        CityB5Off.enabled = true;
    }

    public void EnableCityC1Off() {
        CityC1Off.enabled = true;
    }

    public void EnableCityC2Off() {
        CityC2Off.enabled = true;
    }

    public void EnableCityC3Off() {
        CityC3Off.enabled = true;
    }

    public void EnableCityC4Off() {
        CityC4Off.enabled = true;
    }

    public void EnableCityC5Off() {
        CityC5Off.enabled = true;
    }

    public void EnableCityD1Off() {
        CityD1Off.enabled = true;
    }

    public void EnableCityD2Off() {
        CityD2Off.enabled = true;
    }

    public void EnableCityD3Off() {
        CityD3Off.enabled = true;
    }

    public void EnableCityD4Off() {
        CityD4Off.enabled = true;
    }

    public void EnableCityD5Off() {
        CityD5Off.enabled = true;
    }

    public void EnableCityEOff() {
        CityEOff.enabled = true;
    }

    public void EnableCityA1On() {
        CityA1On.enabled = true;
    }

    public void EnableCityA2On() {
        CityA2On.enabled = true;
    }

    public void EnableCityA3On() {
        CityA3On.enabled = true;
    }

    public void EnableCityA4On() {
        CityA4On.enabled = true;
    }

    public void EnableCityA5On() {
        CityA5On.enabled = true;
    }

    public void EnableCityB1On() {
        CityB1On.enabled = true;
    }

    public void EnableCityB2On() {
        CityB2On.enabled = true;
    }

    public void EnableCityB3On() {
        CityB3On.enabled = true;
    }

    public void EnableCityB4On() {
        CityB4On.enabled = true;
    }

    public void EnableCityB5On() {
        CityB5On.enabled = true;
    }

    public void EnableCityC1On() {
        CityC1On.enabled = true;
    }

    public void EnableCityC2On() {
        CityC2On.enabled = true;
    }

    public void EnableCityC3On() {
        CityC3On.enabled = true;
    }

    public void EnableCityC4On() {
        CityC4On.enabled = true;
    }

    public void EnableCityC5On() {
        CityC5On.enabled = true;
    }

    public void EnableCityD1On() {
        CityD1On.enabled = true;
    }

    public void EnableCityD2On() {
        CityD2On.enabled = true;
    }

    public void EnableCityD3On() {
        CityD3On.enabled = true;
    }

    public void EnableCityD4On() {
        CityD4On.enabled = true;
    }

    public void EnableCityD5On() {
        CityD5On.enabled = true;
    }

    public void EnableCityEOn() {
        CityEOn.enabled = true;
    }

    public void EnableCityBackButton() {
        CityBackButton.enabled = true;
    }

// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    // Main Items
    public void DisableMain() {
        LogoText.enabled = false;
    }

    // Level Items
    public void DisableLevelMain() {
        ActionText.enabled = false;
        RandomButton.enabled = false;
        BackButton.enabled = false;
    }

    public void DisableLevelButton1Off() {
        LevelButton1Off.enabled = false;
    }

    public void DisableLevelButton2Off() {
        LevelButton2Off.enabled = false;
    }

    public void DisableLevelButton3Off() {
        LevelButton3Off.enabled = false;
    }

    public void DisableLevelButton4Off() {
        LevelButton4Off.enabled = false;
    }

    public void DisableLevelButton5Off() {
        LevelButton5Off.enabled = false;
    }

    public void DisableLevelButton1On() {
        LevelButton1On.enabled = false;
    }

    public void DisableLevelButton2On() {
        LevelButton2On.enabled = false;
    }

    public void DisableLevelButton3On() {
        LevelButton3On.enabled = false;
    }

    public void DisableLevelButton4On() {
        LevelButton4On.enabled = false;
    }

    public void DisableLevelButton5On() {
        LevelButton5On.enabled = false;
    }

    // City Items
    public void DisableCityA1Off() {
        CityA1Off.enabled = false;
    }

    public void DisableCityA2Off() {
        CityA2Off.enabled = false;
    }

    public void DisableCityA3Off() {
        CityA3Off.enabled = false;
    }

    public void DisableCityA4Off() {
        CityA4Off.enabled = false;
    }

    public void DisableCityA5Off() {
        CityA5Off.enabled = false;
    }

    public void DisableCityB1Off() {
        CityB1Off.enabled = false;
    }

    public void DisableCityB2Off() {
        CityB2Off.enabled = false;
    }

    public void DisableCityB3Off() {
        CityB3Off.enabled = false;
    }

    public void DisableCityB4Off() {
        CityB4Off.enabled = false;
    }

    public void DisableCityB5Off() {
        CityB5Off.enabled = false;
    }

    public void DisableCityC1Off() {
        CityC1Off.enabled = false;
    }

    public void DisableCityC2Off() {
        CityC2Off.enabled = false;
    }

    public void DisableCityC3Off() {
        CityC3Off.enabled = false;
    }

    public void DisableCityC4Off() {
        CityC4Off.enabled = false;
    }

    public void DisableCityC5Off() {
        CityC5Off.enabled = false;
    }

    public void DisableCityD1Off() {
        CityD1Off.enabled = false;
    }

    public void DisableCityD2Off() {
        CityD2Off.enabled = false;
    }

    public void DisableCityD3Off() {
        CityD3Off.enabled = false;
    }

    public void DisableCityD4Off() {
        CityD4Off.enabled = false;
    }

    public void DisableCityD5Off() {
        CityD5Off.enabled = false;
    }

    public void DisableCityEOff() {
        CityEOff.enabled = false;
    }

    public void DisableCityA1On() {
        CityA1On.enabled = false;
    }

    public void DisableCityA2On() {
        CityA2On.enabled = false;
    }

    public void DisableCityA3On() {
        CityA3On.enabled = false;
    }

    public void DisableCityA4On() {
        CityA4On.enabled = false;
    }

    public void DisableCityA5On() {
        CityA5On.enabled = false;
    }

    public void DisableCityB1On() {
        CityB1On.enabled = false;
    }

    public void DisableCityB2On() {
        CityB2On.enabled = false;
    }

    public void DisableCityB3On() {
        CityB3On.enabled = false;
    }

    public void DisableCityB4On() {
        CityB4On.enabled = false;
    }

    public void DisableCityB5On() {
        CityB5On.enabled = false;
    }

    public void DisableCityC1On() {
        CityC1On.enabled = false;
    }

    public void DisableCityC2On() {
        CityC2On.enabled = false;
    }

    public void DisableCityC3On() {
        CityC3On.enabled = false;
    }

    public void DisableCityC4On() {
        CityC4On.enabled = false;
    }

    public void DisableCityC5On() {
        CityC5On.enabled = false;
    }

    public void DisableCityD1On() {
        CityD1On.enabled = false;
    }

    public void DisableCityD2On() {
        CityD2On.enabled = false;
    }

    public void DisableCityD3On() {
        CityD3On.enabled = false;
    }

    public void DisableCityD4On() {
        CityD4On.enabled = false;
    }

    public void DisableCityD5On() {
        CityD5On.enabled = false;
    }

    public void DisableCityEOn() {
        CityEOn.enabled = false;
    }

    public void DisableCityBackButton() {
        CityBackButton.enabled = false;
    }

    // Disable All
    public void DisableAllLevelItems() {
        DisableLevelMain();
        DisableLevelButton1Off();
        DisableLevelButton2Off();
        DisableLevelButton3Off();
        DisableLevelButton4Off();
        DisableLevelButton5Off();
        DisableLevelButton1On();
        DisableLevelButton2On();
        DisableLevelButton3On();
        DisableLevelButton4On();
        DisableLevelButton5On();
    }

    public void DisableAllCityItems() {
        DisableCityA1Off();
        DisableCityA2Off();
        DisableCityA3Off();
        DisableCityA4Off();
        DisableCityA5Off();
        DisableCityB1Off();
        DisableCityB2Off();
        DisableCityB3Off();
        DisableCityB4Off();
        DisableCityB5Off();
        DisableCityC1Off();
        DisableCityC2Off();
        DisableCityC3Off();
        DisableCityC4Off();
        DisableCityC5Off();
        DisableCityD1Off();
        DisableCityD2Off();
        DisableCityD3Off();
        DisableCityD4Off();
        DisableCityD5Off();
        DisableCityEOff();
        DisableCityA1On();
        DisableCityA2On();
        DisableCityA3On();
        DisableCityA4On();
        DisableCityA5On();
        DisableCityB1On();
        DisableCityB2On();
        DisableCityB3On();
        DisableCityB4On();
        DisableCityB5On();
        DisableCityC1On();
        DisableCityC2On();
        DisableCityC3On();
        DisableCityC4On();
        DisableCityC5On();
        DisableCityD1On();
        DisableCityD2On();
        DisableCityD3On();
        DisableCityD4On();
        DisableCityD5On();
        DisableCityEOn();
        DisableCityBackButton();
    }

// -------------------- UPDATE FUNCTIONS --------------------
    public void EnableBackgrounds() {
        if (PlayerDatabase.PlayerRealm == "Dark") {
            BackgroundImageA.enabled = true;
            BackgroundImageB.enabled = false;
            BackgroundImageC.enabled = false;
            BackgroundImageD.enabled = false;
            BackgroundImageE.enabled = false;
        }

        else if (PlayerDatabase.PlayerRealm == "Earth") {
            BackgroundImageA.enabled = false;
            BackgroundImageB.enabled = true;
            BackgroundImageC.enabled = false;
            BackgroundImageD.enabled = false;
            BackgroundImageE.enabled = false;
        }

        else if (PlayerDatabase.PlayerRealm == "Light") {
            BackgroundImageA.enabled = false;
            BackgroundImageB.enabled = false;
            BackgroundImageC.enabled = true;
            BackgroundImageD.enabled = false;
            BackgroundImageE.enabled = false;
        }

        else if (PlayerDatabase.PlayerRealm == "Sea") {
            BackgroundImageA.enabled = false;
            BackgroundImageB.enabled = false;
            BackgroundImageC.enabled = false;
            BackgroundImageD.enabled = true;
            BackgroundImageE.enabled = false;
        }

        else if (PlayerDatabase.PlayerRealm == "Skies") {
            BackgroundImageA.enabled = false;
            BackgroundImageB.enabled = false;
            BackgroundImageC.enabled = false;
            BackgroundImageD.enabled = false;
            BackgroundImageE.enabled = true;
        }
    }

    public void UpdateShowItems() {
        if (ShowLevelCities == 0) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Items
            if ((PlayerDatabase.PlayerStoryLevel == "1") || (PlayerDatabase.PlayerStoryLevel == "2") || (PlayerDatabase.PlayerStoryLevel == "3") || (PlayerDatabase.PlayerStoryLevel == "4") || (PlayerDatabase.PlayerStoryLevel == "5")) {
                // Enable Main
                EnableLevelMain();

                // Off Levels
                EnableLevelButton2Off();
                EnableLevelButton3Off();
                EnableLevelButton4Off();
                EnableLevelButton5Off();

                // On Levels
                EnableLevelButton1On();
            }

            else if ((PlayerDatabase.PlayerStoryLevel == "6") || (PlayerDatabase.PlayerStoryLevel == "7") || (PlayerDatabase.PlayerStoryLevel == "8") || (PlayerDatabase.PlayerStoryLevel == "9") || (PlayerDatabase.PlayerStoryLevel == "10")) {
                // Enable Main
                EnableLevelMain();

                // Off Levels
                EnableLevelButton3Off();
                EnableLevelButton4Off();
                EnableLevelButton5Off();

                // On Levels
                EnableLevelButton1On();
                EnableLevelButton2On();
            }

            else if ((PlayerDatabase.PlayerStoryLevel == "11") || (PlayerDatabase.PlayerStoryLevel == "12") || (PlayerDatabase.PlayerStoryLevel == "13") || (PlayerDatabase.PlayerStoryLevel == "14") || (PlayerDatabase.PlayerStoryLevel == "15")) {
                // Enable Main
                EnableLevelMain();

                // Off Levels
                EnableLevelButton4Off();
                EnableLevelButton5Off();

                // On Levels
                EnableLevelButton1On();
                EnableLevelButton2On();
                EnableLevelButton3On();
            }

            else if ((PlayerDatabase.PlayerStoryLevel == "16") || (PlayerDatabase.PlayerStoryLevel == "17") || (PlayerDatabase.PlayerStoryLevel == "18") || (PlayerDatabase.PlayerStoryLevel == "19") || (PlayerDatabase.PlayerStoryLevel == "20")) {
                // Enable Main
                EnableLevelMain();

                // Off Levels
                EnableLevelButton5Off();

                // On Levels
                EnableLevelButton1On();
                EnableLevelButton2On();
                EnableLevelButton3On();
                EnableLevelButton4On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "21") {
                // Enable Main
                EnableLevelMain();

                // Off Levels

                // On Levels
                EnableLevelButton1On();
                EnableLevelButton2On();
                EnableLevelButton3On();
                EnableLevelButton4On();
                EnableLevelButton5On();
            }
        }

        else if (ShowLevelCities == 1) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Items
            if (PlayerDatabase.PlayerStoryLevel == "1") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityA2Off();
                EnableCityA3Off();
                EnableCityA4Off();
                EnableCityA5Off();

                // On Cities
                EnableCityA1On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "2") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityA3Off();
                EnableCityA4Off();
                EnableCityA5Off();

                // On Cities
                EnableCityA1On();
                EnableCityA2On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "3") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityA4Off();
                EnableCityA5Off();

                // On Cities
                EnableCityA1On();
                EnableCityA2On();
                EnableCityA3On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "4") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityA5Off();

                // On Cities
                EnableCityA1On();
                EnableCityA2On();
                EnableCityA3On();
                EnableCityA4On();
            }

            else {
                // Enable Main
                EnableCityBackButton();

                // Off Cities

                // On Cities
                EnableCityA1On();
                EnableCityA2On();
                EnableCityA3On();
                EnableCityA4On();
                EnableCityA5On();
            }
        }

        else if (ShowLevelCities == 2) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Items
            if (PlayerDatabase.PlayerStoryLevel == "6") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityB2Off();
                EnableCityB3Off();
                EnableCityB4Off();
                EnableCityB5Off();

                // On Cities
                EnableCityB1On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "7") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityB3Off();
                EnableCityB4Off();
                EnableCityB5Off();

                // On Cities
                EnableCityB1On();
                EnableCityB2On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "8") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityB4Off();
                EnableCityB5Off();

                // On Cities
                EnableCityB1On();
                EnableCityB2On();
                EnableCityB3On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "9") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityB5Off();

                // On Cities
                EnableCityB1On();
                EnableCityB2On();
                EnableCityB3On();
                EnableCityB4On();
            }

            else {
                // Enable Main
                EnableCityBackButton();

                // Off Cities

                // On Cities
                EnableCityB1On();
                EnableCityB2On();
                EnableCityB3On();
                EnableCityB4On();
                EnableCityB5On();
            }
        }

        else if (ShowLevelCities == 3) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Items
            if (PlayerDatabase.PlayerStoryLevel == "11") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityC2Off();
                EnableCityC3Off();
                EnableCityC4Off();
                EnableCityC5Off();

                // On Cities
                EnableCityC1On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "12") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityC3Off();
                EnableCityC4Off();
                EnableCityC5Off();

                // On Cities
                EnableCityC1On();
                EnableCityC2On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "13") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityC4Off();
                EnableCityC5Off();

                // On Cities
                EnableCityC1On();
                EnableCityC2On();
                EnableCityC3On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "14") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityC5Off();

                // On Cities
                EnableCityC1On();
                EnableCityC2On();
                EnableCityC3On();
                EnableCityC4On();
            }

            else {
                // Enable Main
                EnableCityBackButton();

                // Off Cities

                // On Cities
                EnableCityC1On();
                EnableCityC2On();
                EnableCityC3On();
                EnableCityC4On();
                EnableCityC5On();
            }
        }

        else if (ShowLevelCities == 4) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Items
            if (PlayerDatabase.PlayerStoryLevel == "16") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityD2Off();
                EnableCityD3Off();
                EnableCityD4Off();
                EnableCityD5Off();

                // On Cities
                EnableCityD1On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "17") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityD3Off();
                EnableCityD4Off();
                EnableCityD5Off();

                // On Cities
                EnableCityD1On();
                EnableCityD2On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "18") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityD4Off();
                EnableCityD5Off();

                // On Cities
                EnableCityD1On();
                EnableCityD2On();
                EnableCityD3On();
            }

            else if (PlayerDatabase.PlayerStoryLevel == "19") {
                // Enable Main
                EnableCityBackButton();

                // Off Cities
                EnableCityD5Off();

                // On Cities
                EnableCityD1On();
                EnableCityD2On();
                EnableCityD3On();
                EnableCityD4On();
            }

            else {
                // Enable Main
                EnableCityBackButton();

                // Off Cities

                // On Cities
                EnableCityD1On();
                EnableCityD2On();
                EnableCityD3On();
                EnableCityD4On();
                EnableCityD5On();
            }
        }

        else if (ShowLevelCities == 5) {
            // Disable All
            DisableAllLevelItems();
            DisableAllCityItems();

            // Enable Main
            EnableCityBackButton();
            EnableCityEOn();
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}