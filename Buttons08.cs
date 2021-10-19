using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons08 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button SpinButton;
    public Button BackButton;
    public Button BeginDuelButton;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Changing
    public SceneChange Scene07LoadRun;
    public SceneChange Scene09ALoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // SpinButton
        Button SpinButtonClick = SpinButton.GetComponent<Button>();
        SpinButtonClick.onClick.AddListener(SpinButtonClicking);

        // BackButton
        Button BackButtonClick = BackButton.GetComponent<Button>();
        BackButtonClick.onClick.AddListener(BackButtonClicking);

        // BeginDuelButton
        Button BeginDuelButtonClick = BeginDuelButton.GetComponent<Button>();
        BeginDuelButtonClick.onClick.AddListener(BeginDuelButtonClicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
    public void SpinButtonClicking() {
        EnableObjects08.YourNumberInt = Random.Range(1,100);
        EnableObjects08.ComputerNumberInt = Random.Range(1,100);

        if (EnableObjects08.YourNumberInt == EnableObjects08.ComputerNumberInt) {
            SpinButtonClicking();
        }

        else {
            StartCoroutine(GettingResults());
        }
    }

    public void BackButtonClicking() {
        Buttons07.SelectedCityDuel = 0;
        Scene07LoadRun.Scene07Load();
    }

    public void BeginDuelButtonClicking() {
        Scene09ALoadRun.Scene09ALoad();
    }

    public IEnumerator GettingResults() {
        EnableObjects08.PanelViewInt = 1;
        yield return new WaitForSeconds(2.5f);
        EnableObjects08.PanelViewInt = 2;
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}