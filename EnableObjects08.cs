using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects08 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImageA;
    public Image BackgroundImageB;
    public Image BackgroundImageC;
    public Image BackgroundImageD;
    public Image BackgroundImageE;
    public Text CityDuelText;
    public Text ActionText;
    public Image SpinButton;
    public Image BackButton;
    public Text YourNumberText;
    public Text YourNumber;
    public Text ComputerNumberText;
    public Text ComputerNumber;
    public Text ResultsText;
    public Image BeginDuelButton;

// -------------------- PRIVATE VARIABLES --------------------
    Color WinningNumber = new Color(0.8627452f, 0.6470588f, 0.2078432f);
    Color OriginalNumber = new Color(1.0f, 1.0f, 1.0f);

// -------------------- STATIC VARIABLES --------------------
    public static int YourNumberInt;
    public static int ComputerNumberInt;
    public static int PanelViewInt;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgrounds();
        EnableMain();

        YourNumberInt = 0;
        ComputerNumberInt = 0;
        PanelViewInt = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        UpdateCityText();
        UpdatePanelView();

        YourNumber.text = YourNumberInt.ToString();
        ComputerNumber.text = ComputerNumberInt.ToString();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableMain() {
        CityDuelText.enabled = true;
    }

    public void EnablePreNumbers() {
        ActionText.enabled = true;
        SpinButton.enabled = true;
        BackButton.enabled = true;
    }

    public void EnableChosenNumbers() {
        YourNumberText.enabled = true;
        YourNumber.enabled = true;
        ComputerNumberText.enabled = true;
        ComputerNumber.enabled = true;
    }

    public void EnableResults() {
        ResultsText.enabled = true;
        BeginDuelButton.enabled = true;
    }

// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void DisableMain() {
        CityDuelText.enabled = false;
    }

    public void DisablePreNumbers() {
        ActionText.enabled = false;
        SpinButton.enabled = false;
        BackButton.enabled = false;
    }

    public void DisableChosenNumbers() {
        YourNumberText.enabled = false;
        YourNumber.enabled = false;
        ComputerNumberText.enabled = false;
        ComputerNumber.enabled = false;
    }

    public void DisableResults() {
        ResultsText.enabled = false;
        BeginDuelButton.enabled = false;
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

    public void UpdateCityText() {
        if (Buttons07.SelectedCityDuel == 1) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Kepoi";
        }

        else if (Buttons07.SelectedCityDuel == 2) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Terina";
        }

        else if (Buttons07.SelectedCityDuel == 3) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Tyras";
        }

        else if (Buttons07.SelectedCityDuel == 4) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Alonis";
        }

        else if (Buttons07.SelectedCityDuel == 5) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Kamarina";
        }

        else if (Buttons07.SelectedCityDuel == 6) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Naxos";
        }

        else if (Buttons07.SelectedCityDuel == 7) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Antioch";
        }

        else if (Buttons07.SelectedCityDuel == 8) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Eleusis";
        }

        else if (Buttons07.SelectedCityDuel == 9) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Eretria";
        }

        else if (Buttons07.SelectedCityDuel == 10) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Marathon";
        }

        else if (Buttons07.SelectedCityDuel == 11) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Byzantium";
        }

        else if (Buttons07.SelectedCityDuel == 12) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Pergamon";
        }

        else if (Buttons07.SelectedCityDuel == 13) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Ephesus";
        }

        else if (Buttons07.SelectedCityDuel == 14) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Megara";
        }

        else if (Buttons07.SelectedCityDuel == 15) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Delphi";
        }

        else if (Buttons07.SelectedCityDuel == 16) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Argos";
        }

        else if (Buttons07.SelectedCityDuel == 17) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Sparta";
        }

        else if (Buttons07.SelectedCityDuel == 18) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Thiva";
        }

        else if (Buttons07.SelectedCityDuel == 19) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Syracuse";
        }

        else if (Buttons07.SelectedCityDuel == 20) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Corinth";
        }

        else if (Buttons07.SelectedCityDuel == 21) {
            CityDuelText.text = "Computer Duel at" + "\n" + "Athens";
        }
    }

    public void UpdatePanelView() {
        if (PanelViewInt == 0) {
            // Disable All
            DisablePreNumbers();
            DisableChosenNumbers();
            DisableResults();

            // Enable Select
            EnablePreNumbers();
        }

        else if (PanelViewInt == 1) {
            // Disable All
            DisablePreNumbers();
            DisableChosenNumbers();
            DisableResults();

            // Enable Select
            EnableChosenNumbers();

            if (YourNumberInt > ComputerNumberInt) {
                YourNumber.color = WinningNumber;
                ComputerNumber.color = OriginalNumber;
            }

            else if (YourNumberInt < ComputerNumberInt) {
                YourNumber.color = OriginalNumber;
                ComputerNumber.color = WinningNumber;
            }
        }

        else if (PanelViewInt == 2) {
            // Disable All
            DisablePreNumbers();
            DisableChosenNumbers();
            DisableResults();

            // Enable Select
            EnableResults();

            if (YourNumberInt > ComputerNumberInt) {
                ResultsText.text = "It looks like you won the number battle. You will now be going first in the duel. Click to begin and good luck!";
            }

            else if (YourNumberInt < ComputerNumberInt) {
                ResultsText.text = "It looks like you lost the number battle. You will now be going second in the duel. Click to begin and good luck!";
            }
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}