using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects03 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Image BackgroundImageA;
    public Image BackgroundImageB;
    public Image BackgroundImageC;
    public Image BackgroundImageD;
    public Image BackgroundImageE;
    public Text TitleText;
    public Text NoticeText;
    public Image NextButton;

    // Card Packs
    public Image InitialCardA;
    public Image InitialCardB;
    public Image InitialCardC;
    public Image InitialCardD;
    public Image InitialCardE;
    public Image InitialCardF;
    public Image InitialCardG;
    public Image InitialCardH;
    public Image InitialCardI;
    public Image InitialCardJ;

    // Card Zoomed
    public Image ZoomBackground;
    public Image ZoomCard;
    public Text ZoomCardTitle;
    public Text ZoomCardType;
    public Text ZoomCardRealm;
    public Text ZoomCardDescription;
    public Image ZoomPriorButton;
    public Image ZoomNextButton;
    public Image ZoomOffButton;


// -------------------- PRIVATE VARIABLES --------------------
    

// -------------------- STATIC VARIABLES --------------------
    public static int ZoomInOut;
    public static int ZoomCardNumber;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        ZoomInOut = 0;
        ZoomCardNumber = 1;
        EnableBackgrounds();

        EnableMain();
        EnableCards();

        DisableZoomMain();
        DisableZoomPriorButton();
        DisableZoomNextButton();
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        UpdateZoomInOut();
        UpdateAllCardData();
        UpdateAllZoomCardData();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLE OBJECT FUNCTIONS --------------------
    public void EnableMain() {
        TitleText.enabled = true;
        NoticeText.enabled = true;
        NextButton.enabled = true;
    }

    public void EnableCards() {
        InitialCardA.enabled = true;
        InitialCardB.enabled = true;
        InitialCardC.enabled = true;
        InitialCardD.enabled = true;
        InitialCardE.enabled = true;
        InitialCardF.enabled = true;
        InitialCardG.enabled = true;
        InitialCardH.enabled = true;
        InitialCardI.enabled = true;
        InitialCardJ.enabled = true;
    }

    public void EnableZoomMain() {
        ZoomBackground.enabled = true;
        ZoomCard.enabled = true;
        ZoomCardTitle.enabled = true;
        ZoomCardType.enabled = true;
        ZoomCardRealm.enabled = true;
        ZoomCardDescription.enabled = true;
        ZoomOffButton.enabled = true;
    }

    public void EnableZoomPriorButton() {
        ZoomPriorButton.enabled = true;
    }

    public void EnableZoomNextButton() {
        ZoomNextButton.enabled = true;
    }

// -------------------- DISABLE OBJECT FUNCTIONS --------------------
    public void DisableMain() {
        TitleText.enabled = false;
        NoticeText.enabled = false;
        NextButton.enabled = false;
    }

    public void DisableCards() {
        InitialCardA.enabled = false;
        InitialCardB.enabled = false;
        InitialCardC.enabled = false;
        InitialCardD.enabled = false;
        InitialCardE.enabled = false;
        InitialCardF.enabled = false;
        InitialCardG.enabled = false;
        InitialCardH.enabled = false;
        InitialCardI.enabled = false;
        InitialCardJ.enabled = false;
    }

    public void DisableZoomMain() {
        ZoomBackground.enabled = false;
        ZoomCard.enabled = false;
        ZoomCardTitle.enabled = false;
        ZoomCardType.enabled = false;
        ZoomCardRealm.enabled = false;
        ZoomCardDescription.enabled = false;
        ZoomOffButton.enabled = false;
    }

    public void DisableZoomPriorButton() {
        ZoomPriorButton.enabled = false;
    }

    public void DisableZoomNextButton() {
        ZoomNextButton.enabled = false;
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

    public void UpdateZoomInOut() {
        if (ZoomInOut == 0) {
            DisableZoomMain();
            DisableZoomPriorButton();
            DisableZoomNextButton();
        }

        else if (ZoomInOut == 1) {
            EnableZoomMain();
            UpdateZoomPriorNext();
        }
    }

    public void UpdateZoomPriorNext() {
        if (ZoomCardNumber == 1) {
            EnableZoomNextButton();
            DisableZoomPriorButton();
        }

        else if ((ZoomCardNumber >= 2) && (ZoomCardNumber <= 9)) {
            EnableZoomPriorButton();
            EnableZoomNextButton();
        }

        else if (ZoomCardNumber == 10) {
            EnableZoomPriorButton();
            DisableZoomNextButton();
        }
    }

    public void UpdateAllCardData() {
        if (PlayerDatabase.PlayerRealm == "Dark") {
            InitialCardA.sprite = CardDatabase.CardBaseImage[22];
            InitialCardB.sprite = CardDatabase.CardBaseImage[21];
            InitialCardC.sprite = CardDatabase.CardBaseImage[18];
            InitialCardD.sprite = CardDatabase.CardBaseImage[17];
            InitialCardE.sprite = CardDatabase.CardBaseImage[1];
            InitialCardF.sprite = CardDatabase.CardBaseImage[2];
            InitialCardG.sprite = CardDatabase.CardBaseImage[3];
            InitialCardH.sprite = CardDatabase.CardBaseImage[0];
            InitialCardI.sprite = CardDatabase.CardBaseImage[0];
            InitialCardJ.sprite = CardDatabase.CardBaseImage[0];
        }

        else if (PlayerDatabase.PlayerRealm == "Earth") {
            InitialCardA.sprite = CardDatabase.CardBaseImage[34];
            InitialCardB.sprite = CardDatabase.CardBaseImage[38];
            InitialCardC.sprite = CardDatabase.CardBaseImage[41];
            InitialCardD.sprite = CardDatabase.CardBaseImage[44];
            InitialCardE.sprite = CardDatabase.CardBaseImage[24];
            InitialCardF.sprite = CardDatabase.CardBaseImage[25];
            InitialCardG.sprite = CardDatabase.CardBaseImage[26];
            InitialCardH.sprite = CardDatabase.CardBaseImage[23];
            InitialCardI.sprite = CardDatabase.CardBaseImage[23];
            InitialCardJ.sprite = CardDatabase.CardBaseImage[23];
        }

        else if (PlayerDatabase.PlayerRealm == "Light") {
            InitialCardA.sprite = CardDatabase.CardBaseImage[58];
            InitialCardB.sprite = CardDatabase.CardBaseImage[61];
            InitialCardC.sprite = CardDatabase.CardBaseImage[67];
            InitialCardD.sprite = CardDatabase.CardBaseImage[65];
            InitialCardE.sprite = CardDatabase.CardBaseImage[46];
            InitialCardF.sprite = CardDatabase.CardBaseImage[47];
            InitialCardG.sprite = CardDatabase.CardBaseImage[48];
            InitialCardH.sprite = CardDatabase.CardBaseImage[45];
            InitialCardI.sprite = CardDatabase.CardBaseImage[45];
            InitialCardJ.sprite = CardDatabase.CardBaseImage[45];
        }

        else if (PlayerDatabase.PlayerRealm == "Sea") {
            InitialCardA.sprite = CardDatabase.CardBaseImage[80];
            InitialCardB.sprite = CardDatabase.CardBaseImage[81];
            InitialCardC.sprite = CardDatabase.CardBaseImage[83];
            InitialCardD.sprite = CardDatabase.CardBaseImage[84];
            InitialCardE.sprite = CardDatabase.CardBaseImage[70];
            InitialCardF.sprite = CardDatabase.CardBaseImage[71];
            InitialCardG.sprite = CardDatabase.CardBaseImage[72];
            InitialCardH.sprite = CardDatabase.CardBaseImage[69];
            InitialCardI.sprite = CardDatabase.CardBaseImage[69];
            InitialCardJ.sprite = CardDatabase.CardBaseImage[69];
        }

        else if (PlayerDatabase.PlayerRealm == "Skies") {
            InitialCardA.sprite = CardDatabase.CardBaseImage[103];
            InitialCardB.sprite = CardDatabase.CardBaseImage[107];
            InitialCardC.sprite = CardDatabase.CardBaseImage[101];
            InitialCardD.sprite = CardDatabase.CardBaseImage[110];
            InitialCardE.sprite = CardDatabase.CardBaseImage[91];
            InitialCardF.sprite = CardDatabase.CardBaseImage[92];
            InitialCardG.sprite = CardDatabase.CardBaseImage[93];
            InitialCardH.sprite = CardDatabase.CardBaseImage[90];
            InitialCardI.sprite = CardDatabase.CardBaseImage[90];
            InitialCardJ.sprite = CardDatabase.CardBaseImage[90];
        }
    }

    public void UpdateAllZoomCardData() {
        if (PlayerDatabase.PlayerRealm == "Dark") {
            if (ZoomCardNumber == 1) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[22];
                ZoomCardTitle.text = CardDatabase.CardName[22];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[22];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[22];
                ZoomCardDescription.text = CardDatabase.CardDescription[22];
            }

            else if (ZoomCardNumber == 2) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[21];
                ZoomCardTitle.text = CardDatabase.CardName[21];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[21];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[21];
                ZoomCardDescription.text = CardDatabase.CardDescription[21];
            }

            else if (ZoomCardNumber == 3) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[18];
                ZoomCardTitle.text = CardDatabase.CardName[18];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[18];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[18];
                ZoomCardDescription.text = CardDatabase.CardDescription[18];
            }

            else if (ZoomCardNumber == 4) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[17];
                ZoomCardTitle.text = CardDatabase.CardName[17];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[17];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[17];
                ZoomCardDescription.text = CardDatabase.CardDescription[17];
            }

            else if (ZoomCardNumber == 5) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[1];
                ZoomCardTitle.text = CardDatabase.CardName[1];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[1];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[1];
                ZoomCardDescription.text = CardDatabase.CardDescription[1];
            }

            else if (ZoomCardNumber == 6) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[2];
                ZoomCardTitle.text = CardDatabase.CardName[2];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[2];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[2];
                ZoomCardDescription.text = CardDatabase.CardDescription[2];
            }

            else if (ZoomCardNumber == 7) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[3];
                ZoomCardTitle.text = CardDatabase.CardName[3];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[3];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[3];
                ZoomCardDescription.text = CardDatabase.CardDescription[3];
            }

            else if (ZoomCardNumber == 8) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[0];
                ZoomCardTitle.text = CardDatabase.CardName[0];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[0];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[0];
                ZoomCardDescription.text = CardDatabase.CardDescription[0];
            }

            else if (ZoomCardNumber == 9) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[0];
                ZoomCardTitle.text = CardDatabase.CardName[0];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[0];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[0];
                ZoomCardDescription.text = CardDatabase.CardDescription[0];
            }

            else if (ZoomCardNumber == 10) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[0];
                ZoomCardTitle.text = CardDatabase.CardName[0];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[0];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[0];
                ZoomCardDescription.text = CardDatabase.CardDescription[0];
            }
        }

        else if (PlayerDatabase.PlayerRealm == "Earth") {
            if (ZoomCardNumber == 1) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[34];
                ZoomCardTitle.text = CardDatabase.CardName[34];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[34];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[34];
                ZoomCardDescription.text = CardDatabase.CardDescription[34];
            }

            else if (ZoomCardNumber == 2) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[38];
                ZoomCardTitle.text = CardDatabase.CardName[38];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[38];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[38];
                ZoomCardDescription.text = CardDatabase.CardDescription[38];
            }

            else if (ZoomCardNumber == 3) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[41];
                ZoomCardTitle.text = CardDatabase.CardName[41];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[41];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[41];
                ZoomCardDescription.text = CardDatabase.CardDescription[41];
            }

            else if (ZoomCardNumber == 4) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[44];
                ZoomCardTitle.text = CardDatabase.CardName[44];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[44];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[44];
                ZoomCardDescription.text = CardDatabase.CardDescription[44];
            }

            else if (ZoomCardNumber == 5) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[24];
                ZoomCardTitle.text = CardDatabase.CardName[24];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[24];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[24];
                ZoomCardDescription.text = CardDatabase.CardDescription[24];
            }

            else if (ZoomCardNumber == 6) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[25];
                ZoomCardTitle.text = CardDatabase.CardName[25];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[25];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[25];
                ZoomCardDescription.text = CardDatabase.CardDescription[25];
            }

            else if (ZoomCardNumber == 7) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[26];
                ZoomCardTitle.text = CardDatabase.CardName[26];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[26];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[26];
                ZoomCardDescription.text = CardDatabase.CardDescription[26];
            }

            else if (ZoomCardNumber == 8) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[23];
                ZoomCardTitle.text = CardDatabase.CardName[23];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[23];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[23];
                ZoomCardDescription.text = CardDatabase.CardDescription[23];
            }

            else if (ZoomCardNumber == 9) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[23];
                ZoomCardTitle.text = CardDatabase.CardName[23];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[23];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[23];
                ZoomCardDescription.text = CardDatabase.CardDescription[23];
            }

            else if (ZoomCardNumber == 10) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[23];
                ZoomCardTitle.text = CardDatabase.CardName[23];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[23];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[23];
                ZoomCardDescription.text = CardDatabase.CardDescription[23];
            }
        }

        else if (PlayerDatabase.PlayerRealm == "Light") {
            if (ZoomCardNumber == 1) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[58];
                ZoomCardTitle.text = CardDatabase.CardName[58];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[58];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[58];
                ZoomCardDescription.text = CardDatabase.CardDescription[58];
            }

            else if (ZoomCardNumber == 2) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[61];
                ZoomCardTitle.text = CardDatabase.CardName[61];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[61];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[61];
                ZoomCardDescription.text = CardDatabase.CardDescription[61];
            }

            else if (ZoomCardNumber == 3) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[67];
                ZoomCardTitle.text = CardDatabase.CardName[67];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[67];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[67];
                ZoomCardDescription.text = CardDatabase.CardDescription[67];
            }

            else if (ZoomCardNumber == 4) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[65];
                ZoomCardTitle.text = CardDatabase.CardName[65];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[65];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[65];
                ZoomCardDescription.text = CardDatabase.CardDescription[65];
            }

            else if (ZoomCardNumber == 5) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[46];
                ZoomCardTitle.text = CardDatabase.CardName[46];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[46];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[46];
                ZoomCardDescription.text = CardDatabase.CardDescription[46];
            }

            else if (ZoomCardNumber == 6) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[47];
                ZoomCardTitle.text = CardDatabase.CardName[47];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[47];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[47];
                ZoomCardDescription.text = CardDatabase.CardDescription[47];
            }

            else if (ZoomCardNumber == 7) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[48];
                ZoomCardTitle.text = CardDatabase.CardName[48];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[48];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[48];
                ZoomCardDescription.text = CardDatabase.CardDescription[48];
            }

            else if (ZoomCardNumber == 8) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[45];
                ZoomCardTitle.text = CardDatabase.CardName[45];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[45];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[45];
                ZoomCardDescription.text = CardDatabase.CardDescription[45];
            }

            else if (ZoomCardNumber == 9) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[45];
                ZoomCardTitle.text = CardDatabase.CardName[45];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[45];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[45];
                ZoomCardDescription.text = CardDatabase.CardDescription[45];
            }

            else if (ZoomCardNumber == 10) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[45];
                ZoomCardTitle.text = CardDatabase.CardName[45];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[45];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[45];
                ZoomCardDescription.text = CardDatabase.CardDescription[45];
            }
        }

        else if (PlayerDatabase.PlayerRealm == "Sea") {
            if (ZoomCardNumber == 1) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[80];
                ZoomCardTitle.text = CardDatabase.CardName[80];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[80];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[80];
                ZoomCardDescription.text = CardDatabase.CardDescription[80];
            }

            else if (ZoomCardNumber == 2) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[81];
                ZoomCardTitle.text = CardDatabase.CardName[81];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[81];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[81];
                ZoomCardDescription.text = CardDatabase.CardDescription[81];
            }

            else if (ZoomCardNumber == 3) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[83];
                ZoomCardTitle.text = CardDatabase.CardName[83];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[83];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[83];
                ZoomCardDescription.text = CardDatabase.CardDescription[83];
            }

            else if (ZoomCardNumber == 4) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[84];
                ZoomCardTitle.text = CardDatabase.CardName[84];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[84];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[84];
                ZoomCardDescription.text = CardDatabase.CardDescription[84];
            }

            else if (ZoomCardNumber == 5) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[70];
                ZoomCardTitle.text = CardDatabase.CardName[70];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[70];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[70];
                ZoomCardDescription.text = CardDatabase.CardDescription[70];
            }

            else if (ZoomCardNumber == 6) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[71];
                ZoomCardTitle.text = CardDatabase.CardName[71];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[71];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[71];
                ZoomCardDescription.text = CardDatabase.CardDescription[71];
            }

            else if (ZoomCardNumber == 7) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[72];
                ZoomCardTitle.text = CardDatabase.CardName[72];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[72];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[72];
                ZoomCardDescription.text = CardDatabase.CardDescription[72];
            }

            else if (ZoomCardNumber == 8) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[69];
                ZoomCardTitle.text = CardDatabase.CardName[69];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[69];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[69];
                ZoomCardDescription.text = CardDatabase.CardDescription[69];
            }

            else if (ZoomCardNumber == 9) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[69];
                ZoomCardTitle.text = CardDatabase.CardName[69];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[69];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[69];
                ZoomCardDescription.text = CardDatabase.CardDescription[69];
            }

            else if (ZoomCardNumber == 10) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[69];
                ZoomCardTitle.text = CardDatabase.CardName[69];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[69];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[69];
                ZoomCardDescription.text = CardDatabase.CardDescription[69];
            }
        }

        else if (PlayerDatabase.PlayerRealm == "Skies") {
            if (ZoomCardNumber == 1) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[103];
                ZoomCardTitle.text = CardDatabase.CardName[103];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[103];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[103];
                ZoomCardDescription.text = CardDatabase.CardDescription[103];
            }

            else if (ZoomCardNumber == 2) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[107];
                ZoomCardTitle.text = CardDatabase.CardName[107];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[107];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[107];
                ZoomCardDescription.text = CardDatabase.CardDescription[107];
            }

            else if (ZoomCardNumber == 3) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[101];
                ZoomCardTitle.text = CardDatabase.CardName[101];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[101];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[101];
                ZoomCardDescription.text = CardDatabase.CardDescription[101];
            }

            else if (ZoomCardNumber == 4) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[110];
                ZoomCardTitle.text = CardDatabase.CardName[110];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[110];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[110];
                ZoomCardDescription.text = CardDatabase.CardDescription[110];
            }

            else if (ZoomCardNumber == 5) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[91];
                ZoomCardTitle.text = CardDatabase.CardName[91];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[91];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[91];
                ZoomCardDescription.text = CardDatabase.CardDescription[91];
            }

            else if (ZoomCardNumber == 6) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[92];
                ZoomCardTitle.text = CardDatabase.CardName[92];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[92];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[92];
                ZoomCardDescription.text = CardDatabase.CardDescription[92];
            }

            else if (ZoomCardNumber == 7) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[93];
                ZoomCardTitle.text = CardDatabase.CardName[93];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[93];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[93];
                ZoomCardDescription.text = CardDatabase.CardDescription[93];
            }

            else if (ZoomCardNumber == 8) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[90];
                ZoomCardTitle.text = CardDatabase.CardName[90];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[90];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[90];
                ZoomCardDescription.text = CardDatabase.CardDescription[90];
            }

            else if (ZoomCardNumber == 9) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[90];
                ZoomCardTitle.text = CardDatabase.CardName[90];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[90];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[90];
                ZoomCardDescription.text = CardDatabase.CardDescription[90];
            }

            else if (ZoomCardNumber == 10) {
                ZoomCard.sprite = CardDatabase.CardBaseImage[90];
                ZoomCardTitle.text = CardDatabase.CardName[90];
                ZoomCardType.text = "Card Type: " + CardDatabase.CardType[90];
                ZoomCardRealm.text = "Card Realm: " + CardDatabase.CardRealm[90];
                ZoomCardDescription.text = CardDatabase.CardDescription[90];
            }
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}