using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects11 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImageA;
    public Image BackgroundImageB;
    public Image BackgroundImageC;
    public Image BackgroundImageD;
    public Image BackgroundImageE;
    public Text TitleText;
    public Text ActionText;
    public Image BackButton;

    // Scroll View
    public Image DeckScroll;
    public Image DeckView;
    public Image Card001;
    public Image Card002;
    public Image Card003;
    public Image Card004;
    public Image Card005;
    public Image Card006;
    public Image Card007;
    public Image Card008;
    public Image Card009;
    public Image Card010;
    public Image Card011;
    public Image Card012;
    public Image Card013;
    public Image Card014;
    public Image Card015;
    public Image Card016;
    public Image Card017;
    public Image Card018;
    public Image Card019;
    public Image Card020;
    public Image Card021;
    public Image Card022;
    public Image Card023;
    public Image Card024;
    public Image Card025;
    public Image Card026;
    public Image Card027;
    public Image Card028;
    public Image Card029;
    public Image Card030;
    public Image Card031;
    public Image Card032;
    public Image Card033;
    public Image Card034;
    public Image Card035;
    public Image Card036;
    public Image Card037;
    public Image Card038;
    public Image Card039;
    public Image Card040;
    public Image Card041;
    public Image Card042;
    public Image Card043;
    public Image Card044;
    public Image Card045;
    public Image Card046;
    public Image Card047;
    public Image Card048;
    public Image Card049;
    public Image Card050;
    public Image Card051;
    public Image Card052;
    public Image Card053;
    public Image Card054;
    public Image Card055;
    public Image Card056;
    public Image Card057;
    public Image Card058;
    public Image Card059;
    public Image Card060;
    public Image Card061;
    public Image Card062;
    public Image Card063;
    public Image Card064;
    public Image Card065;
    public Image Card066;
    public Image Card067;
    public Image Card068;
    public Image Card069;
    public Image Card070;
    public Image Card071;
    public Image Card072;
    public Image Card073;
    public Image Card074;
    public Image Card075;
    public Image Card076;
    public Image Card077;
    public Image Card078;
    public Image Card079;
    public Image Card080;
    public Image Card081;
    public Image Card082;
    public Image Card083;
    public Image Card084;
    public Image Card085;
    public Image Card086;
    public Image Card087;
    public Image Card088;
    public Image Card089;
    public Image Card090;
    public Image Card091;
    public Image Card092;
    public Image Card093;
    public Image Card094;
    public Image Card095;
    public Image Card096;
    public Image Card097;
    public Image Card098;
    public Image Card099;
    public Image Card100;
    public Image Card101;
    public Image Card102;
    public Image Card103;
    public Image Card104;
    public Image Card105;
    public Image Card106;
    public Image Card107;
    public Image Card108;
    public Image Card109;
    public Image Card110;
    public Image Card111;
    public Image Card112;
    public Image Card113;
    public Image Card114;
    public Image Card115;
    public Image Card116;
    public Image Card117;
    public Image Card118;
    public Image Card119;
    public Image Card120;
    public Image Card121;
    public Image Card122;
    public Image Card123;
    public Image Card124;
    public Image Card125;
    public Image Card126;
    public Image Card127;
    public Image Card128;
    public Image Card129;
    public Image Card130;
    public Image Card131;
    public Image Card132;
    public Image Card133;
    public Image Card134;

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static int ZoomingInCard;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgrounds();
        EnableAll();
        ZoomingInCard = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        if (ZoomingInCard == 0) {
            EnableScrollView();
        }

        else if (ZoomingInCard == 1) {
            DisableScrollView();
        }
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableAll() {
        TitleText.enabled = true;
        ActionText.enabled = true;
        BackButton.enabled = true;
    }

    public void EnableScrollView() {
        DeckScroll.enabled = true;
        DeckView.enabled = true;
        Card001.enabled = true;
        Card002.enabled = true;
        Card003.enabled = true;
        Card004.enabled = true;
        Card005.enabled = true;
        Card006.enabled = true;
        Card007.enabled = true;
        Card008.enabled = true;
        Card009.enabled = true;
        Card010.enabled = true;
        Card011.enabled = true;
        Card012.enabled = true;
        Card013.enabled = true;
        Card014.enabled = true;
        Card015.enabled = true;
        Card016.enabled = true;
        Card017.enabled = true;
        Card018.enabled = true;
        Card019.enabled = true;
        Card020.enabled = true;
        Card021.enabled = true;
        Card022.enabled = true;
        Card023.enabled = true;
        Card024.enabled = true;
        Card025.enabled = true;
        Card026.enabled = true;
        Card027.enabled = true;
        Card028.enabled = true;
        Card029.enabled = true;
        Card030.enabled = true;
        Card031.enabled = true;
        Card032.enabled = true;
        Card033.enabled = true;
        Card034.enabled = true;
        Card035.enabled = true;
        Card036.enabled = true;
        Card037.enabled = true;
        Card038.enabled = true;
        Card039.enabled = true;
        Card040.enabled = true;
        Card041.enabled = true;
        Card042.enabled = true;
        Card043.enabled = true;
        Card044.enabled = true;
        Card045.enabled = true;
        Card046.enabled = true;
        Card047.enabled = true;
        Card048.enabled = true;
        Card049.enabled = true;
        Card050.enabled = true;
        Card051.enabled = true;
        Card052.enabled = true;
        Card053.enabled = true;
        Card054.enabled = true;
        Card055.enabled = true;
        Card056.enabled = true;
        Card057.enabled = true;
        Card058.enabled = true;
        Card059.enabled = true;
        Card060.enabled = true;
        Card061.enabled = true;
        Card062.enabled = true;
        Card063.enabled = true;
        Card064.enabled = true;
        Card065.enabled = true;
        Card066.enabled = true;
        Card067.enabled = true;
        Card068.enabled = true;
        Card069.enabled = true;
        Card070.enabled = true;
        Card071.enabled = true;
        Card072.enabled = true;
        Card073.enabled = true;
        Card074.enabled = true;
        Card075.enabled = true;
        Card076.enabled = true;
        Card077.enabled = true;
        Card078.enabled = true;
        Card079.enabled = true;
        Card080.enabled = true;
        Card081.enabled = true;
        Card082.enabled = true;
        Card083.enabled = true;
        Card084.enabled = true;
        Card085.enabled = true;
        Card086.enabled = true;
        Card087.enabled = true;
        Card088.enabled = true;
        Card089.enabled = true;
        Card090.enabled = true;
        Card091.enabled = true;
        Card092.enabled = true;
        Card093.enabled = true;
        Card094.enabled = true;
        Card095.enabled = true;
        Card096.enabled = true;
        Card097.enabled = true;
        Card098.enabled = true;
        Card099.enabled = true;
        Card100.enabled = true;
        Card101.enabled = true;
        Card102.enabled = true;
        Card103.enabled = true;
        Card104.enabled = true;
        Card105.enabled = true;
        Card106.enabled = true;
        Card107.enabled = true;
        Card108.enabled = true;
        Card109.enabled = true;
        Card110.enabled = true;
        Card111.enabled = true;
        Card112.enabled = true;
        Card113.enabled = true;
        Card114.enabled = true;
        Card115.enabled = true;
        Card116.enabled = true;
        Card117.enabled = true;
        Card118.enabled = true;
        Card119.enabled = true;
        Card120.enabled = true;
        Card121.enabled = true;
        Card122.enabled = true;
        Card123.enabled = true;
        Card124.enabled = true;
        Card125.enabled = true;
        Card126.enabled = true;
        Card127.enabled = true;
        Card128.enabled = true;
        Card129.enabled = true;
        Card130.enabled = true;
        Card131.enabled = true;
        Card132.enabled = true;
        Card133.enabled = true;
        Card134.enabled = true;
    }

// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void DisableAll() {
        TitleText.enabled = false;
        ActionText.enabled = false;
        BackButton.enabled = false;
    }

    public void DisableScrollView() {
        DeckScroll.enabled = false;
        DeckView.enabled = false;
        Card001.enabled = false;
        Card002.enabled = false;
        Card003.enabled = false;
        Card004.enabled = false;
        Card005.enabled = false;
        Card006.enabled = false;
        Card007.enabled = false;
        Card008.enabled = false;
        Card009.enabled = false;
        Card010.enabled = false;
        Card011.enabled = false;
        Card012.enabled = false;
        Card013.enabled = false;
        Card014.enabled = false;
        Card015.enabled = false;
        Card016.enabled = false;
        Card017.enabled = false;
        Card018.enabled = false;
        Card019.enabled = false;
        Card020.enabled = false;
        Card021.enabled = false;
        Card022.enabled = false;
        Card023.enabled = false;
        Card024.enabled = false;
        Card025.enabled = false;
        Card026.enabled = false;
        Card027.enabled = false;
        Card028.enabled = false;
        Card029.enabled = false;
        Card030.enabled = false;
        Card031.enabled = false;
        Card032.enabled = false;
        Card033.enabled = false;
        Card034.enabled = false;
        Card035.enabled = false;
        Card036.enabled = false;
        Card037.enabled = false;
        Card038.enabled = false;
        Card039.enabled = false;
        Card040.enabled = false;
        Card041.enabled = false;
        Card042.enabled = false;
        Card043.enabled = false;
        Card044.enabled = false;
        Card045.enabled = false;
        Card046.enabled = false;
        Card047.enabled = false;
        Card048.enabled = false;
        Card049.enabled = false;
        Card050.enabled = false;
        Card051.enabled = false;
        Card052.enabled = false;
        Card053.enabled = false;
        Card054.enabled = false;
        Card055.enabled = false;
        Card056.enabled = false;
        Card057.enabled = false;
        Card058.enabled = false;
        Card059.enabled = false;
        Card060.enabled = false;
        Card061.enabled = false;
        Card062.enabled = false;
        Card063.enabled = false;
        Card064.enabled = false;
        Card065.enabled = false;
        Card066.enabled = false;
        Card067.enabled = false;
        Card068.enabled = false;
        Card069.enabled = false;
        Card070.enabled = false;
        Card071.enabled = false;
        Card072.enabled = false;
        Card073.enabled = false;
        Card074.enabled = false;
        Card075.enabled = false;
        Card076.enabled = false;
        Card077.enabled = false;
        Card078.enabled = false;
        Card079.enabled = false;
        Card080.enabled = false;
        Card081.enabled = false;
        Card082.enabled = false;
        Card083.enabled = false;
        Card084.enabled = false;
        Card085.enabled = false;
        Card086.enabled = false;
        Card087.enabled = false;
        Card088.enabled = false;
        Card089.enabled = false;
        Card090.enabled = false;
        Card091.enabled = false;
        Card092.enabled = false;
        Card093.enabled = false;
        Card094.enabled = false;
        Card095.enabled = false;
        Card096.enabled = false;
        Card097.enabled = false;
        Card098.enabled = false;
        Card099.enabled = false;
        Card100.enabled = false;
        Card101.enabled = false;
        Card102.enabled = false;
        Card103.enabled = false;
        Card104.enabled = false;
        Card105.enabled = false;
        Card106.enabled = false;
        Card107.enabled = false;
        Card108.enabled = false;
        Card109.enabled = false;
        Card110.enabled = false;
        Card111.enabled = false;
        Card112.enabled = false;
        Card113.enabled = false;
        Card114.enabled = false;
        Card115.enabled = false;
        Card116.enabled = false;
        Card117.enabled = false;
        Card118.enabled = false;
        Card119.enabled = false;
        Card120.enabled = false;
        Card121.enabled = false;
        Card122.enabled = false;
        Card123.enabled = false;
        Card124.enabled = false;
        Card125.enabled = false;
        Card126.enabled = false;
        Card127.enabled = false;
        Card128.enabled = false;
        Card129.enabled = false;
        Card130.enabled = false;
        Card131.enabled = false;
        Card132.enabled = false;
        Card133.enabled = false;
        Card134.enabled = false;
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

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}