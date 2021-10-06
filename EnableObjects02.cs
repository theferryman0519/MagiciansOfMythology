using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects02 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Image BackgroundImage;
    public Text LogoText;
    public Text VersionText;

    public Image LogInButtonOn;
    public Image LogInButtonOff;
    public Image SignUpButtonOn;
    public Image SignUpButtonOff;

    public Text LogInTitle;
    public Text LogInText;
    public Image LogInUsername;
    public Text LogInUsernamePlace;
    public Text LogInUsernameInput;
    public Image LogInButton;

    public Text SignUpTitle;
    public Text SignUpText;
    public Image SignUpUsername;
    public Text SignUpUsernamePlace;
    public Text SignUpUsernameInput;
    public Image SignUpFirstName;
    public Text SignUpFirstNamePlace;
    public Text SignUpFirstNameInput;
    public Image SignUpNextButton;

    public Text SignUpRealmText;
    public Image SignUpRealmDarkButton;
    public Image SignUpRealmEarthButton;
    public Image SignUpRealmLightButton;
    public Image SignUpRealmSeaButton;
    public Image SignUpRealmSkiesButton;
    public Image SignUpFavGod;
    public Text SignUpFavGodPlace;
    public Text SignUpFavGodInput;
    public Image SignUpButton;

// -------------------- PRIVATE VARIABLES --------------------
    public static int LogInSignUpInt;

// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableMain();
        EnableLogInSet();
        EnableLogInButtonOn();
        EnableSignUpButtonOff();
        DisableSignUpSetA();
        DisableSignUpSetB();
        DisableLogInButtonOff();
        DisableSignUpButtonOn();

        LogInSignUpInt = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        if (LogInSignUpInt == 0) {
            EnableLogInSet();
            EnableLogInButtonOn();
            EnableSignUpButtonOff();
            DisableSignUpSetA();
            DisableSignUpSetB();
            DisableLogInButtonOff();
            DisableSignUpButtonOn();

            if ((LogInUsernameInput.text == null) || (LogInUsernameInput.text == "")) {
                LogInUsernamePlace.enabled = true;
                LogInUsernameInput.enabled = true;
            }

            else {
                LogInUsernamePlace.enabled = false;
                LogInUsernameInput.enabled = true;
            }
        }

        else if (LogInSignUpInt == 1) {
            EnableSignUpSetA();
            EnableLogInButtonOff();
            EnableSignUpButtonOn();
            DisableLogInSet();
            DisableSignUpSetB();
            DisableLogInButtonOn();
            DisableSignUpButtonOff();

            if ((SignUpUsernameInput.text == null) || (SignUpUsernameInput.text == "")) {
                SignUpUsernamePlace.enabled = true;
                SignUpUsernameInput.enabled = true;
            }

            else {
                SignUpUsernamePlace.enabled = false;
                SignUpUsernameInput.enabled = true;
            }

            if ((SignUpFirstNameInput.text == null) || (SignUpFirstNameInput.text == "")) {
                SignUpFirstNamePlace.enabled = true;
                SignUpFirstNameInput.enabled = true;
            }

            else {
                SignUpFirstNamePlace.enabled = false;
                SignUpFirstNameInput.enabled = true;
            }
        }

        else if (LogInSignUpInt == 2) {
            EnableSignUpSetB();
            EnableLogInButtonOff();
            EnableSignUpButtonOn();
            DisableLogInSet();
            DisableSignUpSetA();
            DisableLogInButtonOn();
            DisableSignUpButtonOff();

            if ((SignUpFavGodInput.text == null) || (SignUpFavGodInput.text == "")) {
                SignUpFavGodPlace.enabled = true;
                SignUpFavGodInput.enabled = true;
            }

            else {
                SignUpFavGodPlace.enabled = false;
                SignUpFavGodInput.enabled = true;
            }
        }

        VersionText.text = PlayerDatabase.VersionText;
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLE OBJECT FUNCTIONS --------------------
    public void EnableMain() {
        BackgroundImage.enabled = true;
        LogoText.enabled = true;
        VersionText.enabled = true;
    }

    public void EnableLogInButtonOn() {
        LogInButtonOn.enabled = true;
    }

    public void EnableLogInButtonOff() {
        LogInButtonOff.enabled = true;
    }

    public void EnableSignUpButtonOn() {
        SignUpButtonOn.enabled = true;
    }

    public void EnableSignUpButtonOff() {
        SignUpButtonOff.enabled = true;
    }

    public void EnableLogInSet() {
        LogInTitle.enabled = true;
        LogInText.enabled = true;
        LogInUsername.enabled = true;
        LogInUsernamePlace.enabled = true;
        LogInUsernameInput.enabled = true;
        LogInButton.enabled = true;
    }

    public void EnableSignUpSetA() {
        SignUpTitle.enabled = true;
        SignUpText.enabled = true;
        SignUpUsername.enabled = true;
        SignUpUsernamePlace.enabled = true;
        SignUpUsernameInput.enabled = true;
        SignUpFirstName.enabled = true;
        SignUpFirstNamePlace.enabled = true;
        SignUpFirstNameInput.enabled = true;
        SignUpNextButton.enabled = true;
    }

    public void EnableSignUpSetB() {
        SignUpRealmText.enabled = true;
        SignUpRealmDarkButton.enabled = true;
        SignUpRealmEarthButton.enabled = true;
        SignUpRealmLightButton.enabled = true;
        SignUpRealmSeaButton.enabled = true;
        SignUpRealmSkiesButton.enabled = true;
        SignUpFavGod.enabled = true;
        SignUpFavGodPlace.enabled = true;
        SignUpFavGodInput.enabled = true;
        SignUpButton.enabled = true;
    }

// -------------------- DISABLE OBJECT FUNCTIONS --------------------
    public void DisableMain() {
        BackgroundImage.enabled = false;
        LogoText.enabled = false;
        VersionText.enabled = false;
    }

    public void DisableLogInButtonOn() {
        LogInButtonOn.enabled = false;
    }

    public void DisableLogInButtonOff() {
        LogInButtonOff.enabled = false;
    }

    public void DisableSignUpButtonOn() {
        SignUpButtonOn.enabled = false;
    }

    public void DisableSignUpButtonOff() {
        SignUpButtonOff.enabled = false;
    }

    public void DisableLogInSet() {
        LogInButtonOn.enabled = false;
        SignUpButtonOff.enabled = false;
        LogInTitle.enabled = false;
        LogInText.enabled = false;
        LogInUsername.enabled = false;
        LogInUsernamePlace.enabled = false;
        LogInUsernameInput.enabled = false;
        LogInButton.enabled = false;
    }

    public void DisableSignUpSetA() {
        SignUpTitle.enabled = false;
        SignUpText.enabled = false;
        SignUpUsername.enabled = false;
        SignUpUsernamePlace.enabled = false;
        SignUpUsernameInput.enabled = false;
        SignUpFirstName.enabled = false;
        SignUpFirstNamePlace.enabled = false;
        SignUpFirstNameInput.enabled = false;
        SignUpNextButton.enabled = false;
    }

    public void DisableSignUpSetB() {
        SignUpRealmText.enabled = false;
        SignUpRealmDarkButton.enabled = false;
        SignUpRealmEarthButton.enabled = false;
        SignUpRealmLightButton.enabled = false;
        SignUpRealmSeaButton.enabled = false;
        SignUpRealmSkiesButton.enabled = false;
        SignUpFavGod.enabled = false;
        SignUpFavGodPlace.enabled = false;
        SignUpFavGodInput.enabled = false;
        SignUpButton.enabled = false;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}