using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons09A : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Gods Items
    public Button ContinueButton;
    public Button GodOn01;
    public Button GodOn02;
    public Button GodOn03;
    public Button GodOn04;
    public Button GodOn05;
    public Button GodOn06;
    public Button GodOn07;
    public Button GodOn08;
    public Button GodOn09;
    public Button GodOn10;
    public Button GodOn11;
    public Button GodOn12;
    public Button GodOn13;
    public Button GodOn14;
    public Button GodOn15;
    public Button GodOn16;
    public Button GodOn17;
    public Button GodOn18;
    public Button GodOn19;
    public Button GodOn20;
    public Button GodOn21;
    public Button GodOn22;
    public Button GodOn23;
    public Button GodOn24;
    public Button GodOn25;
    public Button GodOn26;
    public Button GodOn27;
    public Button GodOn28;
    public Button GodOn29;
    public Button GodOn30;
    public Button GodOn31;
    public Button GodOn32;
    public Button GodOn33;
    public Button GodOn34;
    public Button GodOn35;
    public Button GodOn36;
    public Button GodOn37;
    public Button GodOn38;
    public Button GodOn39;
    public Button GodOn40;
    public Button GodOn41;
    public Button GodOn42;
    public Button GodOn43;
    public Button GodOn44;
    public Button GodOn45;
    public Button GodOn46;
    public Button GodOn47;
    public Button GodOn48;
    public Button GodOn49;
    public Button GodOn50;
    public Button GodOn51;
    public Button GodOn52;
    public Button GodOn53;
    public Button GodOn54;
    public Button GodOn55;
    public Button GodOn56;
    public Button GodOn57;
    public Button GodOn58;
    public Button GodOn59;
    public Button GodOn60;
    public Button GodOn61;
    public Button GodOn62;
    public Button GodOn63;
    public Button GodOn64;
    public Button GodOn65;
    public Button GodOn66;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static int TotalGodsInPlay;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene09BLoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        TotalGodsInPlay = 0;

        // ContinueButton
        Button ContinueButtonClick = ContinueButton.GetComponent<Button>();
        ContinueButtonClick.onClick.AddListener(ContinueButtonClicking);

        // Gods
        Button GodOn01Click = GodOn01.GetComponent<Button>();
        Button GodOn02Click = GodOn02.GetComponent<Button>();
        Button GodOn03Click = GodOn03.GetComponent<Button>();
        Button GodOn04Click = GodOn04.GetComponent<Button>();
        Button GodOn05Click = GodOn05.GetComponent<Button>();
        Button GodOn06Click = GodOn06.GetComponent<Button>();
        Button GodOn07Click = GodOn07.GetComponent<Button>();
        Button GodOn08Click = GodOn08.GetComponent<Button>();
        Button GodOn09Click = GodOn09.GetComponent<Button>();
        Button GodOn10Click = GodOn10.GetComponent<Button>();
        Button GodOn11Click = GodOn11.GetComponent<Button>();
        Button GodOn12Click = GodOn12.GetComponent<Button>();
        Button GodOn13Click = GodOn13.GetComponent<Button>();
        Button GodOn14Click = GodOn14.GetComponent<Button>();
        Button GodOn15Click = GodOn15.GetComponent<Button>();
        Button GodOn16Click = GodOn16.GetComponent<Button>();
        Button GodOn17Click = GodOn17.GetComponent<Button>();
        Button GodOn18Click = GodOn18.GetComponent<Button>();
        Button GodOn19Click = GodOn19.GetComponent<Button>();
        Button GodOn20Click = GodOn20.GetComponent<Button>();
        Button GodOn21Click = GodOn21.GetComponent<Button>();
        Button GodOn22Click = GodOn22.GetComponent<Button>();
        Button GodOn23Click = GodOn23.GetComponent<Button>();
        Button GodOn24Click = GodOn24.GetComponent<Button>();
        Button GodOn25Click = GodOn25.GetComponent<Button>();
        Button GodOn26Click = GodOn26.GetComponent<Button>();
        Button GodOn27Click = GodOn27.GetComponent<Button>();
        Button GodOn28Click = GodOn28.GetComponent<Button>();
        Button GodOn29Click = GodOn29.GetComponent<Button>();
        Button GodOn30Click = GodOn30.GetComponent<Button>();
        Button GodOn31Click = GodOn31.GetComponent<Button>();
        Button GodOn32Click = GodOn32.GetComponent<Button>();
        Button GodOn33Click = GodOn33.GetComponent<Button>();
        Button GodOn34Click = GodOn34.GetComponent<Button>();
        Button GodOn35Click = GodOn35.GetComponent<Button>();
        Button GodOn36Click = GodOn36.GetComponent<Button>();
        Button GodOn37Click = GodOn37.GetComponent<Button>();
        Button GodOn38Click = GodOn38.GetComponent<Button>();
        Button GodOn39Click = GodOn39.GetComponent<Button>();
        Button GodOn40Click = GodOn40.GetComponent<Button>();
        Button GodOn41Click = GodOn41.GetComponent<Button>();
        Button GodOn42Click = GodOn42.GetComponent<Button>();
        Button GodOn43Click = GodOn43.GetComponent<Button>();
        Button GodOn44Click = GodOn44.GetComponent<Button>();
        Button GodOn45Click = GodOn45.GetComponent<Button>();
        Button GodOn46Click = GodOn46.GetComponent<Button>();
        Button GodOn47Click = GodOn47.GetComponent<Button>();
        Button GodOn48Click = GodOn48.GetComponent<Button>();
        Button GodOn49Click = GodOn49.GetComponent<Button>();
        Button GodOn50Click = GodOn50.GetComponent<Button>();
        Button GodOn51Click = GodOn51.GetComponent<Button>();
        Button GodOn52Click = GodOn52.GetComponent<Button>();
        Button GodOn53Click = GodOn53.GetComponent<Button>();
        Button GodOn54Click = GodOn54.GetComponent<Button>();
        Button GodOn55Click = GodOn55.GetComponent<Button>();
        Button GodOn56Click = GodOn56.GetComponent<Button>();
        Button GodOn57Click = GodOn57.GetComponent<Button>();
        Button GodOn58Click = GodOn58.GetComponent<Button>();
        Button GodOn59Click = GodOn59.GetComponent<Button>();
        Button GodOn60Click = GodOn60.GetComponent<Button>();
        Button GodOn61Click = GodOn61.GetComponent<Button>();
        Button GodOn62Click = GodOn62.GetComponent<Button>();
        Button GodOn63Click = GodOn63.GetComponent<Button>();
        Button GodOn64Click = GodOn64.GetComponent<Button>();
        Button GodOn65Click = GodOn65.GetComponent<Button>();
        Button GodOn66Click = GodOn66.GetComponent<Button>();

        GodOn01Click.onClick.AddListener(GodOn01Clicking);
        GodOn02Click.onClick.AddListener(GodOn02Clicking);
        GodOn03Click.onClick.AddListener(GodOn03Clicking);
        GodOn04Click.onClick.AddListener(GodOn04Clicking);
        GodOn05Click.onClick.AddListener(GodOn05Clicking);
        GodOn06Click.onClick.AddListener(GodOn06Clicking);
        GodOn07Click.onClick.AddListener(GodOn07Clicking);
        GodOn08Click.onClick.AddListener(GodOn08Clicking);
        GodOn09Click.onClick.AddListener(GodOn09Clicking);
        GodOn10Click.onClick.AddListener(GodOn10Clicking);
        GodOn11Click.onClick.AddListener(GodOn11Clicking);
        GodOn12Click.onClick.AddListener(GodOn12Clicking);
        GodOn13Click.onClick.AddListener(GodOn13Clicking);
        GodOn14Click.onClick.AddListener(GodOn14Clicking);
        GodOn15Click.onClick.AddListener(GodOn15Clicking);
        GodOn16Click.onClick.AddListener(GodOn16Clicking);
        GodOn17Click.onClick.AddListener(GodOn17Clicking);
        GodOn18Click.onClick.AddListener(GodOn18Clicking);
        GodOn19Click.onClick.AddListener(GodOn19Clicking);
        GodOn20Click.onClick.AddListener(GodOn20Clicking);
        GodOn21Click.onClick.AddListener(GodOn21Clicking);
        GodOn22Click.onClick.AddListener(GodOn22Clicking);
        GodOn23Click.onClick.AddListener(GodOn23Clicking);
        GodOn24Click.onClick.AddListener(GodOn24Clicking);
        GodOn25Click.onClick.AddListener(GodOn25Clicking);
        GodOn26Click.onClick.AddListener(GodOn26Clicking);
        GodOn27Click.onClick.AddListener(GodOn27Clicking);
        GodOn28Click.onClick.AddListener(GodOn28Clicking);
        GodOn29Click.onClick.AddListener(GodOn29Clicking);
        GodOn30Click.onClick.AddListener(GodOn30Clicking);
        GodOn31Click.onClick.AddListener(GodOn31Clicking);
        GodOn32Click.onClick.AddListener(GodOn32Clicking);
        GodOn33Click.onClick.AddListener(GodOn33Clicking);
        GodOn34Click.onClick.AddListener(GodOn34Clicking);
        GodOn35Click.onClick.AddListener(GodOn35Clicking);
        GodOn36Click.onClick.AddListener(GodOn36Clicking);
        GodOn37Click.onClick.AddListener(GodOn37Clicking);
        GodOn38Click.onClick.AddListener(GodOn38Clicking);
        GodOn39Click.onClick.AddListener(GodOn39Clicking);
        GodOn40Click.onClick.AddListener(GodOn40Clicking);
        GodOn41Click.onClick.AddListener(GodOn41Clicking);
        GodOn42Click.onClick.AddListener(GodOn42Clicking);
        GodOn43Click.onClick.AddListener(GodOn43Clicking);
        GodOn44Click.onClick.AddListener(GodOn44Clicking);
        GodOn45Click.onClick.AddListener(GodOn45Clicking);
        GodOn46Click.onClick.AddListener(GodOn46Clicking);
        GodOn47Click.onClick.AddListener(GodOn47Clicking);
        GodOn48Click.onClick.AddListener(GodOn48Clicking);
        GodOn49Click.onClick.AddListener(GodOn49Clicking);
        GodOn50Click.onClick.AddListener(GodOn50Clicking);
        GodOn51Click.onClick.AddListener(GodOn51Clicking);
        GodOn52Click.onClick.AddListener(GodOn52Clicking);
        GodOn53Click.onClick.AddListener(GodOn53Clicking);
        GodOn54Click.onClick.AddListener(GodOn54Clicking);
        GodOn55Click.onClick.AddListener(GodOn55Clicking);
        GodOn56Click.onClick.AddListener(GodOn56Clicking);
        GodOn57Click.onClick.AddListener(GodOn57Clicking);
        GodOn58Click.onClick.AddListener(GodOn58Clicking);
        GodOn59Click.onClick.AddListener(GodOn59Clicking);
        GodOn60Click.onClick.AddListener(GodOn60Clicking);
        GodOn61Click.onClick.AddListener(GodOn61Clicking);
        GodOn62Click.onClick.AddListener(GodOn62Clicking);
        GodOn63Click.onClick.AddListener(GodOn63Clicking);
        GodOn64Click.onClick.AddListener(GodOn64Clicking);
        GodOn65Click.onClick.AddListener(GodOn65Clicking);
        GodOn66Click.onClick.AddListener(GodOn66Clicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
    public void ContinueButtonClicking() {
        if (TotalGodsInPlay >= 1) {
            Scene09BLoadRun.Scene09BLoad();
        }
    }

    public void GodOn01Clicking() {
        if ((EnableObjects09A.GodIntOn01 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn01 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn01 >= 1) {
            EnableObjects09A.GodIntOn01 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn02Clicking() {
        if ((EnableObjects09A.GodIntOn02 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn02 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn02 >= 1) {
            EnableObjects09A.GodIntOn02 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn03Clicking() {
        if ((EnableObjects09A.GodIntOn03 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn03 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn03 >= 1) {
            EnableObjects09A.GodIntOn03 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn04Clicking() {
        if ((EnableObjects09A.GodIntOn04 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn04 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn04 >= 1) {
            EnableObjects09A.GodIntOn04 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn05Clicking() {
        if ((EnableObjects09A.GodIntOn05 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn05 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn05 >= 1) {
            EnableObjects09A.GodIntOn05 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn06Clicking() {
        if ((EnableObjects09A.GodIntOn06 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn06 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn06 >= 1) {
            EnableObjects09A.GodIntOn06 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn07Clicking() {
        if ((EnableObjects09A.GodIntOn07 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn07 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn07 >= 1) {
            EnableObjects09A.GodIntOn07 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn08Clicking() {
        if ((EnableObjects09A.GodIntOn08 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn08 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn08 >= 1) {
            EnableObjects09A.GodIntOn08 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn09Clicking() {
        if ((EnableObjects09A.GodIntOn09 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn09 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn09 >= 1) {
            EnableObjects09A.GodIntOn09 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn10Clicking() {
        if ((EnableObjects09A.GodIntOn10 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn10 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn10 >= 1) {
            EnableObjects09A.GodIntOn10 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn11Clicking() {
        if ((EnableObjects09A.GodIntOn11 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn11 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn11 >= 1) {
            EnableObjects09A.GodIntOn11 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn12Clicking() {
        if ((EnableObjects09A.GodIntOn12 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn12 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn12 >= 1) {
            EnableObjects09A.GodIntOn12 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn13Clicking() {
        if ((EnableObjects09A.GodIntOn13 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn13 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn13 >= 1) {
            EnableObjects09A.GodIntOn13 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn14Clicking() {
        if ((EnableObjects09A.GodIntOn14 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn14 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn14 >= 1) {
            EnableObjects09A.GodIntOn14 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn15Clicking() {
        if ((EnableObjects09A.GodIntOn15 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn15 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn15 >= 1) {
            EnableObjects09A.GodIntOn15 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn16Clicking() {
        if ((EnableObjects09A.GodIntOn16 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn16 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn16 >= 1) {
            EnableObjects09A.GodIntOn16 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn17Clicking() {
        if ((EnableObjects09A.GodIntOn17 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn17 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn17 >= 1) {
            EnableObjects09A.GodIntOn17 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn18Clicking() {
        if ((EnableObjects09A.GodIntOn18 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn18 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn18 >= 1) {
            EnableObjects09A.GodIntOn18 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn19Clicking() {
        if ((EnableObjects09A.GodIntOn19 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn19 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn19 >= 1) {
            EnableObjects09A.GodIntOn19 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn20Clicking() {
        if ((EnableObjects09A.GodIntOn20 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn20 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn20 >= 1) {
            EnableObjects09A.GodIntOn20 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn21Clicking() {
        if ((EnableObjects09A.GodIntOn21 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn21 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn21 >= 1) {
            EnableObjects09A.GodIntOn21 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn22Clicking() {
        if ((EnableObjects09A.GodIntOn22 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn22 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn22 >= 1) {
            EnableObjects09A.GodIntOn22 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn23Clicking() {
        if ((EnableObjects09A.GodIntOn23 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn23 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn23 >= 1) {
            EnableObjects09A.GodIntOn23 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn24Clicking() {
        if ((EnableObjects09A.GodIntOn24 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn24 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn24 >= 1) {
            EnableObjects09A.GodIntOn24 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn25Clicking() {
        if ((EnableObjects09A.GodIntOn25 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn25 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn25 >= 1) {
            EnableObjects09A.GodIntOn25 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn26Clicking() {
        if ((EnableObjects09A.GodIntOn26 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn26 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn26 >= 1) {
            EnableObjects09A.GodIntOn26 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn27Clicking() {
        if ((EnableObjects09A.GodIntOn27 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn27 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn27 >= 1) {
            EnableObjects09A.GodIntOn27 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn28Clicking() {
        if ((EnableObjects09A.GodIntOn28 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn28 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn28 >= 1) {
            EnableObjects09A.GodIntOn28 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn29Clicking() {
        if ((EnableObjects09A.GodIntOn29 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn29 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn29 >= 1) {
            EnableObjects09A.GodIntOn29 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn30Clicking() {
        if ((EnableObjects09A.GodIntOn30 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn30 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn30 >= 1) {
            EnableObjects09A.GodIntOn30 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn31Clicking() {
        if ((EnableObjects09A.GodIntOn31 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn31 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn31 >= 1) {
            EnableObjects09A.GodIntOn31 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn32Clicking() {
        if ((EnableObjects09A.GodIntOn32 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn32 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn32 >= 1) {
            EnableObjects09A.GodIntOn32 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn33Clicking() {
        if ((EnableObjects09A.GodIntOn33 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn33 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn33 >= 1) {
            EnableObjects09A.GodIntOn33 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn34Clicking() {
        if ((EnableObjects09A.GodIntOn34 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn34 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn34 >= 1) {
            EnableObjects09A.GodIntOn34 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn35Clicking() {
        if ((EnableObjects09A.GodIntOn35 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn35 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn35 >= 1) {
            EnableObjects09A.GodIntOn35 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn36Clicking() {
        if ((EnableObjects09A.GodIntOn36 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn36 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn36 >= 1) {
            EnableObjects09A.GodIntOn36 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn37Clicking() {
        if ((EnableObjects09A.GodIntOn37 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn37 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn37 >= 1) {
            EnableObjects09A.GodIntOn37 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn38Clicking() {
        if ((EnableObjects09A.GodIntOn38 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn38 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn38 >= 1) {
            EnableObjects09A.GodIntOn38 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn39Clicking() {
        if ((EnableObjects09A.GodIntOn39 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn39 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn39 >= 1) {
            EnableObjects09A.GodIntOn39 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn40Clicking() {
        if ((EnableObjects09A.GodIntOn40 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn40 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn40 >= 1) {
            EnableObjects09A.GodIntOn40 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn41Clicking() {
        if ((EnableObjects09A.GodIntOn41 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn41 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn41 >= 1) {
            EnableObjects09A.GodIntOn41 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn42Clicking() {
        if ((EnableObjects09A.GodIntOn42 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn42 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn42 >= 1) {
            EnableObjects09A.GodIntOn42 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn43Clicking() {
        if ((EnableObjects09A.GodIntOn43 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn43 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn43 >= 1) {
            EnableObjects09A.GodIntOn43 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn44Clicking() {
        if ((EnableObjects09A.GodIntOn44 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn44 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn44 >= 1) {
            EnableObjects09A.GodIntOn44 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn45Clicking() {
        if ((EnableObjects09A.GodIntOn45 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn45 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn45 >= 1) {
            EnableObjects09A.GodIntOn45 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn46Clicking() {
        if ((EnableObjects09A.GodIntOn46 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn46 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn46 >= 1) {
            EnableObjects09A.GodIntOn46 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn47Clicking() {
        if ((EnableObjects09A.GodIntOn47 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn47 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn47 >= 1) {
            EnableObjects09A.GodIntOn47 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn48Clicking() {
        if ((EnableObjects09A.GodIntOn48 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn48 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn48 >= 1) {
            EnableObjects09A.GodIntOn48 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn49Clicking() {
        if ((EnableObjects09A.GodIntOn49 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn49 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn49 >= 1) {
            EnableObjects09A.GodIntOn49 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn50Clicking() {
        if ((EnableObjects09A.GodIntOn50 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn50 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn50 >= 1) {
            EnableObjects09A.GodIntOn50 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn51Clicking() {
        if ((EnableObjects09A.GodIntOn51 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn51 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn51 >= 1) {
            EnableObjects09A.GodIntOn51 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn52Clicking() {
        if ((EnableObjects09A.GodIntOn52 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn52 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn52 >= 1) {
            EnableObjects09A.GodIntOn52 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn53Clicking() {
        if ((EnableObjects09A.GodIntOn53 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn53 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn53 >= 1) {
            EnableObjects09A.GodIntOn53 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn54Clicking() {
        if ((EnableObjects09A.GodIntOn54 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn54 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn54 >= 1) {
            EnableObjects09A.GodIntOn54 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn55Clicking() {
        if ((EnableObjects09A.GodIntOn55 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn55 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn55 >= 1) {
            EnableObjects09A.GodIntOn55 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn56Clicking() {
        if ((EnableObjects09A.GodIntOn56 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn56 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn56 >= 1) {
            EnableObjects09A.GodIntOn56 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn57Clicking() {
        if ((EnableObjects09A.GodIntOn57 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn57 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn57 >= 1) {
            EnableObjects09A.GodIntOn57 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn58Clicking() {
        if ((EnableObjects09A.GodIntOn58 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn58 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn58 >= 1) {
            EnableObjects09A.GodIntOn58 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn59Clicking() {
        if ((EnableObjects09A.GodIntOn59 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn59 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn59 >= 1) {
            EnableObjects09A.GodIntOn59 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn60Clicking() {
        if ((EnableObjects09A.GodIntOn60 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn60 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn60 >= 1) {
            EnableObjects09A.GodIntOn60 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn61Clicking() {
        if ((EnableObjects09A.GodIntOn61 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn61 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn61 >= 1) {
            EnableObjects09A.GodIntOn61 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn62Clicking() {
        if ((EnableObjects09A.GodIntOn62 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn62 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn62 >= 1) {
            EnableObjects09A.GodIntOn62 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn63Clicking() {
        if ((EnableObjects09A.GodIntOn63 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn63 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn63 >= 1) {
            EnableObjects09A.GodIntOn63 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn64Clicking() {
        if ((EnableObjects09A.GodIntOn64 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn64 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn64 >= 1) {
            EnableObjects09A.GodIntOn64 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn65Clicking() {
        if ((EnableObjects09A.GodIntOn65 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn65 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn65 >= 1) {
            EnableObjects09A.GodIntOn65 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

    public void GodOn66Clicking() {
        if ((EnableObjects09A.GodIntOn66 == 0) && (TotalGodsInPlay < 5)) {
            EnableObjects09A.GodIntOn66 = 1;
            TotalGodsInPlay = TotalGodsInPlay + 1;
        }

        else if (EnableObjects09A.GodIntOn66 >= 1) {
            EnableObjects09A.GodIntOn66 = 0;
            TotalGodsInPlay = TotalGodsInPlay - 1;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}