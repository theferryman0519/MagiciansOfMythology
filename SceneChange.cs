using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class SceneChange : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------


// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    // List of Scenes
    public static string Scene00 = "00FerrymanLogo";
    public static string Scene01 = "01MainLogo";
    public static string Scene02 = "02LogInSignUp";
    public static string Scene03 = "03SignUpDeck";
    public static string Scene04 = "04SignUpTutorial";
    public static string Scene05 = "05MainMenu";
    public static string Scene06 = "06GameStore";
    public static string Scene07 = "07StoryMode";
    public static string Scene08 = "08StoryRPS";
    public static string Scene09A = "09StoryGamePlayA";
    public static string Scene09B = "09StoryGamePlayB";
    public static string Scene09C = "09StoryGamePlayC";
    public static string Scene10 = "10MultiplayerMode";
    public static string Scene11 = "11YourDeck";
    public static string Scene12 = "12Settings";
    public static string Scene13 = "13ContactUs";

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {

    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- SCENE CHANGE FUNCTIONS --------------------
    // Load Scene00 - Ferryman Logo Scene
    public void Scene00Load() {
        SceneManager.LoadScene(Scene00);
    }

    // Load Scene01 - Main Logo Scene
    public void Scene01Load() {
        SceneManager.LoadScene(Scene01);
    }

    // Load Scene02 - Log In Sign Up Scene
    public void Scene02Load() {
        SceneManager.LoadScene(Scene02);
    }

    // Load Scene03 - Sign Up Deck Scene
    public void Scene03Load() {
        SceneManager.LoadScene(Scene03);
    }

    // Load Scene04 - Sign Up Tutorial Scene
    public void Scene04Load() {
        SceneManager.LoadScene(Scene04);
    }

    // Load Scene05 - Main Menu Scene
    public void Scene05Load() {
        SceneManager.LoadScene(Scene05);
    }

    // Load Scene06 - Game Store Scene
    public void Scene06Load() {
        SceneManager.LoadScene(Scene06);
    }

    // Load Scene07 - Story Mode Scene
    public void Scene07Load() {
        SceneManager.LoadScene(Scene07);
    }

    // Load Scene08 - Story RPS Scene
    public void Scene08Load() {
        SceneManager.LoadScene(Scene08);
    }

    // Load Scene09A - Story Game Play Scene
    public void Scene09ALoad() {
        SceneManager.LoadScene(Scene09A);
    }

    // Load Scene09B - Story Game Play Scene
    public void Scene09BLoad() {
        SceneManager.LoadScene(Scene09B);
    }

    // Load Scene09C - Story Game Play Scene
    public void Scene09CLoad() {
        SceneManager.LoadScene(Scene09C);
    }

    // Load Scene10 - Multiplayer Mode Scene
    public void Scene10Load() {
        SceneManager.LoadScene(Scene10);
    }

    // Load Scene11 - Your Deck Scene
    public void Scene11Load() {
        SceneManager.LoadScene(Scene11);
    }

    // Load Scene12 - Settings Scene
    public void Scene12Load() {
        SceneManager.LoadScene(Scene12);
    }

    // Load Scene13 - Contact Us Scene
    public void Scene13Load() {
        SceneManager.LoadScene(Scene13);
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}