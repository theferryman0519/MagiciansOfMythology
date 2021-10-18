using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects05 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImageA;
    public Image BackgroundImageB;
    public Image BackgroundImageC;
    public Image BackgroundImageD;
    public Image BackgroundImageE;
    public Text LogoText;
    public Text WelcomeText;
    public Text MonoplayerRecord;
    public Text MultiplayerRecord;

    // Menu Items
    public Image GameStoreButton;
    public Image StoryModeButton;
    public Image MultiplayerButton;
    public Image YourDeckButton;
    public Image SettingsButton;
    public Image ContactUsButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgrounds();
        EnableAll();
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        UpdateTexts();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableAll() {
        LogoText.enabled = true;
        WelcomeText.enabled = true;
        MonoplayerRecord.enabled = true;
        MultiplayerRecord.enabled = true;
        GameStoreButton.enabled = true;
        StoryModeButton.enabled = true;
        MultiplayerButton.enabled = true;
        YourDeckButton.enabled = true;
        SettingsButton.enabled = true;
        ContactUsButton.enabled = true;
    }

// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void DisableAll() {
        LogoText.enabled = false;
        WelcomeText.enabled = false;
        MonoplayerRecord.enabled = false;
        MultiplayerRecord.enabled = false;
        GameStoreButton.enabled = false;
        StoryModeButton.enabled = false;
        MultiplayerButton.enabled = false;
        YourDeckButton.enabled = false;
        SettingsButton.enabled = false;
        ContactUsButton.enabled = false;
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
    
    public void UpdateTexts() {
        WelcomeText.text = "Welcome, " + PlayerDatabase.PlayerName;
        MonoplayerRecord.text = "Story Mode Record" + "\n" + "Wins: " + PlayerDatabase.PlayerWins + " / Losses: " + PlayerDatabase.PlayerLosses + " / Ties: " + PlayerDatabase.PlayerStalemates;
        MultiplayerRecord.text = "Multiplayer Record" + "\n" + "Wins: " + PlayerDatabase.MultiplayerWins + " / Losses: " + PlayerDatabase.MultiplayerLosses + " / Ties: " + PlayerDatabase.MultiplayerStalemates;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}