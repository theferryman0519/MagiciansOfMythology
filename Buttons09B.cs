using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons09B : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Deck Items
    public Button BeginButton;
    public Button DeckOn01;
    public Button DeckOn02;
    public Button DeckOn03;
    public Button DeckOn04;
    public Button DeckOn05;
    public Button DeckOn06;
    public Button DeckOn07;
    public Button DeckOn08;
    public Button DeckOn09;
    public Button DeckOn10;
    public Button DeckOn11;
    public Button DeckOn12;
    public Button DeckOn13;
    public Button DeckOn14;
    public Button DeckOn15;
    public Button DeckOn16;
    public Button DeckOn17;
    public Button DeckOn18;
    public Button DeckOn19;
    public Button DeckOn20;
    public Button DeckOn21;
    public Button DeckOn22;
    public Button DeckOn23;
    public Button DeckOn24;
    public Button DeckOn25;
    public Button DeckOn26;
    public Button DeckOn27;
    public Button DeckOn28;
    public Button DeckOn29;
    public Button DeckOn30;
    public Button DeckOn31;
    public Button DeckOn32;
    public Button DeckOn33;
    public Button DeckOn34;
    public Button DeckOn35;
    public Button DeckOn36;
    public Button DeckOn37;
    public Button DeckOn38;
    public Button DeckOn39;
    public Button DeckOn40;
    public Button DeckOn41;
    public Button DeckOn42;
    public Button DeckOn43;
    public Button DeckOn44;
    public Button DeckOn45;
    public Button DeckOn46;
    public Button DeckOn47;
    public Button DeckOn48;
    public Button DeckOn49;
    public Button DeckOn50;
    public Button DeckOn51;
    public Button DeckOn52;
    public Button DeckOn53;
    public Button DeckOn54;
    public Button DeckOn55;
    public Button DeckOn56;
    public Button DeckOn57;
    public Button DeckOn58;
    public Button DeckOn59;
    public Button DeckOn60;
    public Button DeckOn61;
    public Button DeckOn62;
    public Button DeckOn63;
    public Button DeckOn64;
    public Button DeckOn65;
    public Button DeckOn66;
    public Button DeckOn67;
    public Button DeckOn68;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static int TotalDeckInPlay;
    public static int DeckSelectedInt01;
    public static int DeckSelectedInt02;
    public static int DeckSelectedInt03;
    public static int DeckSelectedInt04;
    public static int DeckSelectedInt05;
    public static int DeckSelectedInt06;
    public static int DeckSelectedInt07;
    public static int DeckSelectedInt08;
    public static int DeckSelectedInt09;
    public static int DeckSelectedInt10;
    public static int DeckSelectedInt11;
    public static int DeckSelectedInt12;
    public static int DeckSelectedInt13;
    public static int DeckSelectedInt14;
    public static int DeckSelectedInt15;
    public static int DeckSelectedInt16;
    public static int DeckSelectedInt17;
    public static int DeckSelectedInt18;
    public static int DeckSelectedInt19;
    public static int DeckSelectedInt20;
    public static int DeckSelectedInt21;
    public static int DeckSelectedInt22;
    public static int DeckSelectedInt23;
    public static int DeckSelectedInt24;
    public static int DeckSelectedInt25;
    public static int DeckSelectedInt26;
    public static int DeckSelectedInt27;
    public static int DeckSelectedInt28;
    public static int DeckSelectedInt29;
    public static int DeckSelectedInt30;
    public static int DeckSelectedInt31;
    public static int DeckSelectedInt32;
    public static int DeckSelectedInt33;
    public static int DeckSelectedInt34;
    public static int DeckSelectedInt35;
    public static int DeckSelectedInt36;
    public static int DeckSelectedInt37;
    public static int DeckSelectedInt38;
    public static int DeckSelectedInt39;
    public static int DeckSelectedInt40;
    public static int DeckSelectedInt41;
    public static int DeckSelectedInt42;
    public static int DeckSelectedInt43;
    public static int DeckSelectedInt44;
    public static int DeckSelectedInt45;
    public static int DeckSelectedInt46;
    public static int DeckSelectedInt47;
    public static int DeckSelectedInt48;
    public static int DeckSelectedInt49;
    public static int DeckSelectedInt50;
    public static int DeckSelectedInt51;
    public static int DeckSelectedInt52;
    public static int DeckSelectedInt53;
    public static int DeckSelectedInt54;
    public static int DeckSelectedInt55;
    public static int DeckSelectedInt56;
    public static int DeckSelectedInt57;
    public static int DeckSelectedInt58;
    public static int DeckSelectedInt59;
    public static int DeckSelectedInt60;
    public static int DeckSelectedInt61;
    public static int DeckSelectedInt62;
    public static int DeckSelectedInt63;
    public static int DeckSelectedInt64;
    public static int DeckSelectedInt65;
    public static int DeckSelectedInt66;
    public static int DeckSelectedInt67;
    public static int DeckSelectedInt68;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------


// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        TotalDeckInPlay = 0;

        // BeginButton
        Button BeginButtonClick = BeginButton.GetComponent<Button>();
        BeginButtonClick.onClick.AddListener(BeginButtonClicking);

        // Deck
        Button DeckOn01Click = DeckOn01.GetComponent<Button>();
        Button DeckOn02Click = DeckOn02.GetComponent<Button>();
        Button DeckOn03Click = DeckOn03.GetComponent<Button>();
        Button DeckOn04Click = DeckOn04.GetComponent<Button>();
        Button DeckOn05Click = DeckOn05.GetComponent<Button>();
        Button DeckOn06Click = DeckOn06.GetComponent<Button>();
        Button DeckOn07Click = DeckOn07.GetComponent<Button>();
        Button DeckOn08Click = DeckOn08.GetComponent<Button>();
        Button DeckOn09Click = DeckOn09.GetComponent<Button>();
        Button DeckOn10Click = DeckOn10.GetComponent<Button>();
        Button DeckOn11Click = DeckOn11.GetComponent<Button>();
        Button DeckOn12Click = DeckOn12.GetComponent<Button>();
        Button DeckOn13Click = DeckOn13.GetComponent<Button>();
        Button DeckOn14Click = DeckOn14.GetComponent<Button>();
        Button DeckOn15Click = DeckOn15.GetComponent<Button>();
        Button DeckOn16Click = DeckOn16.GetComponent<Button>();
        Button DeckOn17Click = DeckOn17.GetComponent<Button>();
        Button DeckOn18Click = DeckOn18.GetComponent<Button>();
        Button DeckOn19Click = DeckOn19.GetComponent<Button>();
        Button DeckOn20Click = DeckOn20.GetComponent<Button>();
        Button DeckOn21Click = DeckOn21.GetComponent<Button>();
        Button DeckOn22Click = DeckOn22.GetComponent<Button>();
        Button DeckOn23Click = DeckOn23.GetComponent<Button>();
        Button DeckOn24Click = DeckOn24.GetComponent<Button>();
        Button DeckOn25Click = DeckOn25.GetComponent<Button>();
        Button DeckOn26Click = DeckOn26.GetComponent<Button>();
        Button DeckOn27Click = DeckOn27.GetComponent<Button>();
        Button DeckOn28Click = DeckOn28.GetComponent<Button>();
        Button DeckOn29Click = DeckOn29.GetComponent<Button>();
        Button DeckOn30Click = DeckOn30.GetComponent<Button>();
        Button DeckOn31Click = DeckOn31.GetComponent<Button>();
        Button DeckOn32Click = DeckOn32.GetComponent<Button>();
        Button DeckOn33Click = DeckOn33.GetComponent<Button>();
        Button DeckOn34Click = DeckOn34.GetComponent<Button>();
        Button DeckOn35Click = DeckOn35.GetComponent<Button>();
        Button DeckOn36Click = DeckOn36.GetComponent<Button>();
        Button DeckOn37Click = DeckOn37.GetComponent<Button>();
        Button DeckOn38Click = DeckOn38.GetComponent<Button>();
        Button DeckOn39Click = DeckOn39.GetComponent<Button>();
        Button DeckOn40Click = DeckOn40.GetComponent<Button>();
        Button DeckOn41Click = DeckOn41.GetComponent<Button>();
        Button DeckOn42Click = DeckOn42.GetComponent<Button>();
        Button DeckOn43Click = DeckOn43.GetComponent<Button>();
        Button DeckOn44Click = DeckOn44.GetComponent<Button>();
        Button DeckOn45Click = DeckOn45.GetComponent<Button>();
        Button DeckOn46Click = DeckOn46.GetComponent<Button>();
        Button DeckOn47Click = DeckOn47.GetComponent<Button>();
        Button DeckOn48Click = DeckOn48.GetComponent<Button>();
        Button DeckOn49Click = DeckOn49.GetComponent<Button>();
        Button DeckOn50Click = DeckOn50.GetComponent<Button>();
        Button DeckOn51Click = DeckOn51.GetComponent<Button>();
        Button DeckOn52Click = DeckOn52.GetComponent<Button>();
        Button DeckOn53Click = DeckOn53.GetComponent<Button>();
        Button DeckOn54Click = DeckOn54.GetComponent<Button>();
        Button DeckOn55Click = DeckOn55.GetComponent<Button>();
        Button DeckOn56Click = DeckOn56.GetComponent<Button>();
        Button DeckOn57Click = DeckOn57.GetComponent<Button>();
        Button DeckOn58Click = DeckOn58.GetComponent<Button>();
        Button DeckOn59Click = DeckOn59.GetComponent<Button>();
        Button DeckOn60Click = DeckOn60.GetComponent<Button>();
        Button DeckOn61Click = DeckOn61.GetComponent<Button>();
        Button DeckOn62Click = DeckOn62.GetComponent<Button>();
        Button DeckOn63Click = DeckOn63.GetComponent<Button>();
        Button DeckOn64Click = DeckOn64.GetComponent<Button>();
        Button DeckOn65Click = DeckOn65.GetComponent<Button>();
        Button DeckOn66Click = DeckOn66.GetComponent<Button>();
        Button DeckOn67Click = DeckOn67.GetComponent<Button>();
        Button DeckOn68Click = DeckOn68.GetComponent<Button>();

        DeckOn01Click.onClick.AddListener(DeckOn01Clicking);
        DeckOn02Click.onClick.AddListener(DeckOn02Clicking);
        DeckOn03Click.onClick.AddListener(DeckOn03Clicking);
        DeckOn04Click.onClick.AddListener(DeckOn04Clicking);
        DeckOn05Click.onClick.AddListener(DeckOn05Clicking);
        DeckOn06Click.onClick.AddListener(DeckOn06Clicking);
        DeckOn07Click.onClick.AddListener(DeckOn07Clicking);
        DeckOn08Click.onClick.AddListener(DeckOn08Clicking);
        DeckOn09Click.onClick.AddListener(DeckOn09Clicking);
        DeckOn10Click.onClick.AddListener(DeckOn10Clicking);
        DeckOn11Click.onClick.AddListener(DeckOn11Clicking);
        DeckOn12Click.onClick.AddListener(DeckOn12Clicking);
        DeckOn13Click.onClick.AddListener(DeckOn13Clicking);
        DeckOn14Click.onClick.AddListener(DeckOn14Clicking);
        DeckOn15Click.onClick.AddListener(DeckOn15Clicking);
        DeckOn16Click.onClick.AddListener(DeckOn16Clicking);
        DeckOn17Click.onClick.AddListener(DeckOn17Clicking);
        DeckOn18Click.onClick.AddListener(DeckOn18Clicking);
        DeckOn19Click.onClick.AddListener(DeckOn19Clicking);
        DeckOn20Click.onClick.AddListener(DeckOn20Clicking);
        DeckOn21Click.onClick.AddListener(DeckOn21Clicking);
        DeckOn22Click.onClick.AddListener(DeckOn22Clicking);
        DeckOn23Click.onClick.AddListener(DeckOn23Clicking);
        DeckOn24Click.onClick.AddListener(DeckOn24Clicking);
        DeckOn25Click.onClick.AddListener(DeckOn25Clicking);
        DeckOn26Click.onClick.AddListener(DeckOn26Clicking);
        DeckOn27Click.onClick.AddListener(DeckOn27Clicking);
        DeckOn28Click.onClick.AddListener(DeckOn28Clicking);
        DeckOn29Click.onClick.AddListener(DeckOn29Clicking);
        DeckOn30Click.onClick.AddListener(DeckOn30Clicking);
        DeckOn31Click.onClick.AddListener(DeckOn31Clicking);
        DeckOn32Click.onClick.AddListener(DeckOn32Clicking);
        DeckOn33Click.onClick.AddListener(DeckOn33Clicking);
        DeckOn34Click.onClick.AddListener(DeckOn34Clicking);
        DeckOn35Click.onClick.AddListener(DeckOn35Clicking);
        DeckOn36Click.onClick.AddListener(DeckOn36Clicking);
        DeckOn37Click.onClick.AddListener(DeckOn37Clicking);
        DeckOn38Click.onClick.AddListener(DeckOn38Clicking);
        DeckOn39Click.onClick.AddListener(DeckOn39Clicking);
        DeckOn40Click.onClick.AddListener(DeckOn40Clicking);
        DeckOn41Click.onClick.AddListener(DeckOn41Clicking);
        DeckOn42Click.onClick.AddListener(DeckOn42Clicking);
        DeckOn43Click.onClick.AddListener(DeckOn43Clicking);
        DeckOn44Click.onClick.AddListener(DeckOn44Clicking);
        DeckOn45Click.onClick.AddListener(DeckOn45Clicking);
        DeckOn46Click.onClick.AddListener(DeckOn46Clicking);
        DeckOn47Click.onClick.AddListener(DeckOn47Clicking);
        DeckOn48Click.onClick.AddListener(DeckOn48Clicking);
        DeckOn49Click.onClick.AddListener(DeckOn49Clicking);
        DeckOn50Click.onClick.AddListener(DeckOn50Clicking);
        DeckOn51Click.onClick.AddListener(DeckOn51Clicking);
        DeckOn52Click.onClick.AddListener(DeckOn52Clicking);
        DeckOn53Click.onClick.AddListener(DeckOn53Clicking);
        DeckOn54Click.onClick.AddListener(DeckOn54Clicking);
        DeckOn55Click.onClick.AddListener(DeckOn55Clicking);
        DeckOn56Click.onClick.AddListener(DeckOn56Clicking);
        DeckOn57Click.onClick.AddListener(DeckOn57Clicking);
        DeckOn58Click.onClick.AddListener(DeckOn58Clicking);
        DeckOn59Click.onClick.AddListener(DeckOn59Clicking);
        DeckOn60Click.onClick.AddListener(DeckOn60Clicking);
        DeckOn61Click.onClick.AddListener(DeckOn61Clicking);
        DeckOn62Click.onClick.AddListener(DeckOn62Clicking);
        DeckOn63Click.onClick.AddListener(DeckOn63Clicking);
        DeckOn64Click.onClick.AddListener(DeckOn64Clicking);
        DeckOn65Click.onClick.AddListener(DeckOn65Clicking);
        DeckOn66Click.onClick.AddListener(DeckOn66Clicking);
        DeckOn67Click.onClick.AddListener(DeckOn67Clicking);
        DeckOn68Click.onClick.AddListener(DeckOn68Clicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
    public void BeginButtonClicking() {
        if (TotalDeckInPlay >= 1) {
            EnableObjects09B.GamePlayPanelInt = 2;
        }
    }

    public void DeckOn01Clicking() {
        if ((EnableObjects09B.DeckIntOn01 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn01 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn01 >= 1) {
            EnableObjects09B.DeckIntOn01 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn02Clicking() {
        if ((EnableObjects09B.DeckIntOn02 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn02 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn02 >= 1) {
            EnableObjects09B.DeckIntOn02 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn03Clicking() {
        if ((EnableObjects09B.DeckIntOn03 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn03 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn03 >= 1) {
            EnableObjects09B.DeckIntOn03 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn04Clicking() {
        if ((EnableObjects09B.DeckIntOn04 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn04 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn04 >= 1) {
            EnableObjects09B.DeckIntOn04 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn05Clicking() {
        if ((EnableObjects09B.DeckIntOn05 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn05 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn05 >= 1) {
            EnableObjects09B.DeckIntOn05 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn06Clicking() {
        if ((EnableObjects09B.DeckIntOn06 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn06 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn06 >= 1) {
            EnableObjects09B.DeckIntOn06 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn07Clicking() {
        if ((EnableObjects09B.DeckIntOn07 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn07 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn07 >= 1) {
            EnableObjects09B.DeckIntOn07 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn08Clicking() {
        if ((EnableObjects09B.DeckIntOn08 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn08 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn08 >= 1) {
            EnableObjects09B.DeckIntOn08 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn09Clicking() {
        if ((EnableObjects09B.DeckIntOn09 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn09 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn09 >= 1) {
            EnableObjects09B.DeckIntOn09 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn10Clicking() {
        if ((EnableObjects09B.DeckIntOn10 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn10 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn10 >= 1) {
            EnableObjects09B.DeckIntOn10 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn11Clicking() {
        if ((EnableObjects09B.DeckIntOn11 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn11 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn11 >= 1) {
            EnableObjects09B.DeckIntOn11 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn12Clicking() {
        if ((EnableObjects09B.DeckIntOn12 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn12 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn12 >= 1) {
            EnableObjects09B.DeckIntOn12 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn13Clicking() {
        if ((EnableObjects09B.DeckIntOn13 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn13 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn13 >= 1) {
            EnableObjects09B.DeckIntOn13 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn14Clicking() {
        if ((EnableObjects09B.DeckIntOn14 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn14 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn14 >= 1) {
            EnableObjects09B.DeckIntOn14 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn15Clicking() {
        if ((EnableObjects09B.DeckIntOn15 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn15 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn15 >= 1) {
            EnableObjects09B.DeckIntOn15 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn16Clicking() {
        if ((EnableObjects09B.DeckIntOn16 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn16 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn16 >= 1) {
            EnableObjects09B.DeckIntOn16 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn17Clicking() {
        if ((EnableObjects09B.DeckIntOn17 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn17 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn17 >= 1) {
            EnableObjects09B.DeckIntOn17 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn18Clicking() {
        if ((EnableObjects09B.DeckIntOn18 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn18 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn18 >= 1) {
            EnableObjects09B.DeckIntOn18 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn19Clicking() {
        if ((EnableObjects09B.DeckIntOn19 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn19 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn19 >= 1) {
            EnableObjects09B.DeckIntOn19 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn20Clicking() {
        if ((EnableObjects09B.DeckIntOn20 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn20 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn20 >= 1) {
            EnableObjects09B.DeckIntOn20 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn21Clicking() {
        if ((EnableObjects09B.DeckIntOn21 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn21 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn21 >= 1) {
            EnableObjects09B.DeckIntOn21 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn22Clicking() {
        if ((EnableObjects09B.DeckIntOn22 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn22 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn22 >= 1) {
            EnableObjects09B.DeckIntOn22 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn23Clicking() {
        if ((EnableObjects09B.DeckIntOn23 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn23 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn23 >= 1) {
            EnableObjects09B.DeckIntOn23 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn24Clicking() {
        if ((EnableObjects09B.DeckIntOn24 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn24 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn24 >= 1) {
            EnableObjects09B.DeckIntOn24 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn25Clicking() {
        if ((EnableObjects09B.DeckIntOn25 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn25 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn25 >= 1) {
            EnableObjects09B.DeckIntOn25 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn26Clicking() {
        if ((EnableObjects09B.DeckIntOn26 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn26 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn26 >= 1) {
            EnableObjects09B.DeckIntOn26 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn27Clicking() {
        if ((EnableObjects09B.DeckIntOn27 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn27 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn27 >= 1) {
            EnableObjects09B.DeckIntOn27 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn28Clicking() {
        if ((EnableObjects09B.DeckIntOn28 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn28 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn28 >= 1) {
            EnableObjects09B.DeckIntOn28 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn29Clicking() {
        if ((EnableObjects09B.DeckIntOn29 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn29 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn29 >= 1) {
            EnableObjects09B.DeckIntOn29 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn30Clicking() {
        if ((EnableObjects09B.DeckIntOn30 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn30 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn30 >= 1) {
            EnableObjects09B.DeckIntOn30 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn31Clicking() {
        if ((EnableObjects09B.DeckIntOn31 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn31 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn31 >= 1) {
            EnableObjects09B.DeckIntOn31 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn32Clicking() {
        if ((EnableObjects09B.DeckIntOn32 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn32 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn32 >= 1) {
            EnableObjects09B.DeckIntOn32 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn33Clicking() {
        if ((EnableObjects09B.DeckIntOn33 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn33 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn33 >= 1) {
            EnableObjects09B.DeckIntOn33 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn34Clicking() {
        if ((EnableObjects09B.DeckIntOn34 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn34 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn34 >= 1) {
            EnableObjects09B.DeckIntOn34 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn35Clicking() {
        if ((EnableObjects09B.DeckIntOn35 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn35 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn35 >= 1) {
            EnableObjects09B.DeckIntOn35 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn36Clicking() {
        if ((EnableObjects09B.DeckIntOn36 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn36 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn36 >= 1) {
            EnableObjects09B.DeckIntOn36 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn37Clicking() {
        if ((EnableObjects09B.DeckIntOn37 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn37 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn37 >= 1) {
            EnableObjects09B.DeckIntOn37 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn38Clicking() {
        if ((EnableObjects09B.DeckIntOn38 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn38 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn38 >= 1) {
            EnableObjects09B.DeckIntOn38 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn39Clicking() {
        if ((EnableObjects09B.DeckIntOn39 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn39 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn39 >= 1) {
            EnableObjects09B.DeckIntOn39 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn40Clicking() {
        if ((EnableObjects09B.DeckIntOn40 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn40 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn40 >= 1) {
            EnableObjects09B.DeckIntOn40 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn41Clicking() {
        if ((EnableObjects09B.DeckIntOn41 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn41 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn41 >= 1) {
            EnableObjects09B.DeckIntOn41 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn42Clicking() {
        if ((EnableObjects09B.DeckIntOn42 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn42 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn42 >= 1) {
            EnableObjects09B.DeckIntOn42 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn43Clicking() {
        if ((EnableObjects09B.DeckIntOn43 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn43 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn43 >= 1) {
            EnableObjects09B.DeckIntOn43 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn44Clicking() {
        if ((EnableObjects09B.DeckIntOn44 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn44 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn44 >= 1) {
            EnableObjects09B.DeckIntOn44 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn45Clicking() {
        if ((EnableObjects09B.DeckIntOn45 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn45 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn45 >= 1) {
            EnableObjects09B.DeckIntOn45 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn46Clicking() {
        if ((EnableObjects09B.DeckIntOn46 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn46 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn46 >= 1) {
            EnableObjects09B.DeckIntOn46 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn47Clicking() {
        if ((EnableObjects09B.DeckIntOn47 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn47 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn47 >= 1) {
            EnableObjects09B.DeckIntOn47 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn48Clicking() {
        if ((EnableObjects09B.DeckIntOn48 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn48 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn48 >= 1) {
            EnableObjects09B.DeckIntOn48 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn49Clicking() {
        if ((EnableObjects09B.DeckIntOn49 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn49 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn49 >= 1) {
            EnableObjects09B.DeckIntOn49 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn50Clicking() {
        if ((EnableObjects09B.DeckIntOn50 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn50 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn50 >= 1) {
            EnableObjects09B.DeckIntOn50 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn51Clicking() {
        if ((EnableObjects09B.DeckIntOn51 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn51 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn51 >= 1) {
            EnableObjects09B.DeckIntOn51 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn52Clicking() {
        if ((EnableObjects09B.DeckIntOn52 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn52 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn52 >= 1) {
            EnableObjects09B.DeckIntOn52 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn53Clicking() {
        if ((EnableObjects09B.DeckIntOn53 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn53 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn53 >= 1) {
            EnableObjects09B.DeckIntOn53 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn54Clicking() {
        if ((EnableObjects09B.DeckIntOn54 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn54 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn54 >= 1) {
            EnableObjects09B.DeckIntOn54 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn55Clicking() {
        if ((EnableObjects09B.DeckIntOn55 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn55 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn55 >= 1) {
            EnableObjects09B.DeckIntOn55 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn56Clicking() {
        if ((EnableObjects09B.DeckIntOn56 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn56 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn56 >= 1) {
            EnableObjects09B.DeckIntOn56 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn57Clicking() {
        if ((EnableObjects09B.DeckIntOn57 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn57 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn57 >= 1) {
            EnableObjects09B.DeckIntOn57 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn58Clicking() {
        if ((EnableObjects09B.DeckIntOn58 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn58 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn58 >= 1) {
            EnableObjects09B.DeckIntOn58 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn59Clicking() {
        if ((EnableObjects09B.DeckIntOn59 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn59 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn59 >= 1) {
            EnableObjects09B.DeckIntOn59 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn60Clicking() {
        if ((EnableObjects09B.DeckIntOn60 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn60 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn60 >= 1) {
            EnableObjects09B.DeckIntOn60 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn61Clicking() {
        if ((EnableObjects09B.DeckIntOn61 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn61 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn61 >= 1) {
            EnableObjects09B.DeckIntOn61 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn62Clicking() {
        if ((EnableObjects09B.DeckIntOn62 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn62 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn62 >= 1) {
            EnableObjects09B.DeckIntOn62 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn63Clicking() {
        if ((EnableObjects09B.DeckIntOn63 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn63 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn63 >= 1) {
            EnableObjects09B.DeckIntOn63 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn64Clicking() {
        if ((EnableObjects09B.DeckIntOn64 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn64 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn64 >= 1) {
            EnableObjects09B.DeckIntOn64 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn65Clicking() {
        if ((EnableObjects09B.DeckIntOn65 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn65 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn65 >= 1) {
            EnableObjects09B.DeckIntOn65 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn66Clicking() {
        if ((EnableObjects09B.DeckIntOn66 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn66 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn66 >= 1) {
            EnableObjects09B.DeckIntOn66 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn67Clicking() {
        if ((EnableObjects09B.DeckIntOn67 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn67 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn67 >= 1) {
            EnableObjects09B.DeckIntOn67 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

    public void DeckOn68Clicking() {
        if ((EnableObjects09B.DeckIntOn68 == 0) && (TotalDeckInPlay < 15)) {
            EnableObjects09B.DeckIntOn68 = 1;
            TotalDeckInPlay = TotalDeckInPlay + 1;
        }

        else if (EnableObjects09B.DeckIntOn68 >= 1) {
            EnableObjects09B.DeckIntOn68 = 0;
            TotalDeckInPlay = TotalDeckInPlay - 1;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}