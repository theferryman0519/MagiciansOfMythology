using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons05 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button GameStoreButton;
    public Button StoryModeButton;
    // public Button MultiplayerButton;
    public Button YourDeckButton;
    public Button SettingsButton;
    public Button ContactUsButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Changing
    public SceneChange Scene06LoadRun;
    public SceneChange Scene07LoadRun;
    public SceneChange Scene10LoadRun;
    public SceneChange Scene11LoadRun;
    public SceneChange Scene12LoadRun;
    public SceneChange Scene13LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // GameStoreButton
        Button GameStoreButtonClick = GameStoreButton.GetComponent<Button>();
        GameStoreButtonClick.onClick.AddListener(GameStoreButtonClicking);

        // StoryModeButton
        Button StoryModeButtonClick = StoryModeButton.GetComponent<Button>();
        StoryModeButtonClick.onClick.AddListener(StoryModeButtonClicking);

        // MultiplayerButton
        //Button MultiplayerButtonClick = MultiplayerButton.GetComponent<Button>();
        //MultiplayerButtonClick.onClick.AddListener(MultiplayerButtonClicking);

        // YourDeckButton
        Button YourDeckButtonClick = YourDeckButton.GetComponent<Button>();
        YourDeckButtonClick.onClick.AddListener(YourDeckButtonClicking);

        // SettingsButton
        Button SettingsButtonClick = SettingsButton.GetComponent<Button>();
        SettingsButtonClick.onClick.AddListener(SettingsButtonClicking);

        // ContactUsButton
        Button ContactUsButtonClick = ContactUsButton.GetComponent<Button>();
        ContactUsButtonClick.onClick.AddListener(ContactUsButtonClicking);
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
    public void GameStoreButtonClicking() {
        // Run coroutine for loading store data
        Scene06LoadRun.Scene06Load();
    }

    public void StoryModeButtonClicking() {
        // Run coroutine for loading card and player data
        Scene07LoadRun.Scene07Load();
    }

    public void MultiplayerButtonClicking() {
        // Run coroutine for loading card and player data
        //Scene10LoadRun.Scene10Load();
    }

    public void YourDeckButtonClicking() {
        // Run coroutine for loading card and player data
        Scene11LoadRun.Scene11Load();
    }

    public void SettingsButtonClicking() {
        Scene12LoadRun.Scene12Load();
    }

    public void ContactUsButtonClicking() {
        Scene13LoadRun.Scene13Load();
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}