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

    // Zoom Items
    public Image ZoomBackground;
    public Text ZoomTitle;
    public Image ZoomCard;
    public Text ZoomRealm;
    public Text ZoomType;
    public Text ZoomNumber;
    public Text ZoomDescription;
    public Text ZoomOwnTitle;
    public Text ZoomOwnNumber;
    public Image ZoomCloseButton;

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

    // Sprites
    public Sprite SpriteBackView;

// -------------------- PRIVATE VARIABLES --------------------
    Color OwnedColor = new Color(1.0f, 1.0f, 1.0f);
    Color UnownedColor = new Color(0.5f, 0.5f, 0.5f);

// -------------------- STATIC VARIABLES --------------------
    public static int ZoomingInCard;
    public static int ZoomInNumber;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableBackgrounds();
        AdjustSprites();
        EnableAll();
        ZoomingInCard = 0;
        ZoomInNumber = 0;
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        ShowZoomInformation();

        if (ZoomingInCard == 0) {
            EnableScrollView();
            DisableZoom();
        }

        else if (ZoomingInCard == 1) {
            DisableScrollView();
            EnableZoom();
        }
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void EnableAll() {
        TitleText.enabled = true;
    }

    public void EnableScrollView() {
        ActionText.enabled = true;
        BackButton.enabled = true;
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

    public void EnableZoom() {
        ZoomBackground.enabled = true;
        ZoomTitle.enabled = true;
        ZoomCard.enabled = true;
        ZoomRealm.enabled = true;
        ZoomType.enabled = true;
        ZoomNumber.enabled = true;
        ZoomDescription.enabled = true;
        ZoomOwnTitle.enabled = true;
        ZoomOwnNumber.enabled = true;
        ZoomCloseButton.enabled = true;
    }

// -------------------- ENABLING OBJECT FUNCTIONS --------------------
    public void DisableAll() {
        TitleText.enabled = false;
    }

    public void DisableScrollView() {
        ActionText.enabled = false;
        BackButton.enabled = false;
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

    public void DisableZoom() {
        ZoomBackground.enabled = false;
        ZoomTitle.enabled = false;
        ZoomCard.enabled = false;
        ZoomRealm.enabled = false;
        ZoomType.enabled = false;
        ZoomNumber.enabled = false;
        ZoomDescription.enabled = false;
        ZoomOwnTitle.enabled = false;
        ZoomOwnNumber.enabled = false;
        ZoomCloseButton.enabled = false;
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

    public void AdjustSprites() {
        // Card001
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount001) >= 1) {
            Card001.sprite = CardDatabase.CardBaseImage[0];
            Card001.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card001.sprite = SpriteBackView;
            Card001.GetComponent<Image>().color = UnownedColor;
        }

        // Card002
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount002) >= 1) {
            Card002.sprite = CardDatabase.CardBaseImage[1];
            Card002.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card002.sprite = SpriteBackView;
            Card002.GetComponent<Image>().color = UnownedColor;
        }

        // Card003
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount003) >= 1) {
            Card003.sprite = CardDatabase.CardBaseImage[2];
            Card003.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card003.sprite = SpriteBackView;
            Card003.GetComponent<Image>().color = UnownedColor;
        }

        // Card004
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount004) >= 1) {
            Card004.sprite = CardDatabase.CardBaseImage[3];
            Card004.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card004.sprite = SpriteBackView;
            Card004.GetComponent<Image>().color = UnownedColor;
        }

        // Card005
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount005) >= 1) {
            Card005.sprite = CardDatabase.CardBaseImage[4];
            Card005.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card005.sprite = SpriteBackView;
            Card005.GetComponent<Image>().color = UnownedColor;
        }

        // Card006
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount006) >= 1) {
            Card006.sprite = CardDatabase.CardBaseImage[5];
            Card006.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card006.sprite = SpriteBackView;
            Card006.GetComponent<Image>().color = UnownedColor;
        }

        // Card007
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount007) >= 1) {
            Card007.sprite = CardDatabase.CardBaseImage[6];
            Card007.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card007.sprite = SpriteBackView;
            Card007.GetComponent<Image>().color = UnownedColor;
        }

        // Card008
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount008) >= 1) {
            Card008.sprite = CardDatabase.CardBaseImage[7];
            Card008.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card008.sprite = SpriteBackView;
            Card008.GetComponent<Image>().color = UnownedColor;
        }

        // Card009
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount009) >= 1) {
            Card009.sprite = CardDatabase.CardBaseImage[8];
            Card009.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card009.sprite = SpriteBackView;
            Card009.GetComponent<Image>().color = UnownedColor;
        }

        // Card010
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount010) >= 1) {
            Card010.sprite = CardDatabase.CardBaseImage[9];
            Card010.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card010.sprite = SpriteBackView;
            Card010.GetComponent<Image>().color = UnownedColor;
        }

        // Card011
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount011) >= 1) {
            Card011.sprite = CardDatabase.CardBaseImage[10];
            Card011.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card011.sprite = SpriteBackView;
            Card011.GetComponent<Image>().color = UnownedColor;
        }

        // Card012
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount012) >= 1) {
            Card012.sprite = CardDatabase.CardBaseImage[11];
            Card012.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card012.sprite = SpriteBackView;
            Card012.GetComponent<Image>().color = UnownedColor;
        }

        // Card013
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount013) >= 1) {
            Card013.sprite = CardDatabase.CardBaseImage[12];
            Card013.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card013.sprite = SpriteBackView;
            Card013.GetComponent<Image>().color = UnownedColor;
        }

        // Card014
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount014) >= 1) {
            Card014.sprite = CardDatabase.CardBaseImage[13];
            Card014.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card014.sprite = SpriteBackView;
            Card014.GetComponent<Image>().color = UnownedColor;
        }

        // Card015
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount015) >= 1) {
            Card015.sprite = CardDatabase.CardBaseImage[14];
            Card015.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card015.sprite = SpriteBackView;
            Card015.GetComponent<Image>().color = UnownedColor;
        }

        // Card016
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount016) >= 1) {
            Card016.sprite = CardDatabase.CardBaseImage[15];
            Card016.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card016.sprite = SpriteBackView;
            Card016.GetComponent<Image>().color = UnownedColor;
        }

        // Card017
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount017) >= 1) {
            Card017.sprite = CardDatabase.CardBaseImage[16];
            Card017.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card017.sprite = SpriteBackView;
            Card017.GetComponent<Image>().color = UnownedColor;
        }

        // Card018
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount018) >= 1) {
            Card018.sprite = CardDatabase.CardBaseImage[17];
            Card018.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card018.sprite = SpriteBackView;
            Card018.GetComponent<Image>().color = UnownedColor;
        }

        // Card019
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount019) >= 1) {
            Card019.sprite = CardDatabase.CardBaseImage[18];
            Card019.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card019.sprite = SpriteBackView;
            Card019.GetComponent<Image>().color = UnownedColor;
        }

        // Card020
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount020) >= 1) {
            Card020.sprite = CardDatabase.CardBaseImage[19];
            Card020.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card020.sprite = SpriteBackView;
            Card020.GetComponent<Image>().color = UnownedColor;
        }

        // Card021
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount021) >= 1) {
            Card021.sprite = CardDatabase.CardBaseImage[20];
            Card021.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card021.sprite = SpriteBackView;
            Card021.GetComponent<Image>().color = UnownedColor;
        }

        // Card022
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount022) >= 1) {
            Card022.sprite = CardDatabase.CardBaseImage[21];
            Card022.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card022.sprite = SpriteBackView;
            Card022.GetComponent<Image>().color = UnownedColor;
        }

        // Card023
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount023) >= 1) {
            Card023.sprite = CardDatabase.CardBaseImage[22];
            Card023.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card023.sprite = SpriteBackView;
            Card023.GetComponent<Image>().color = UnownedColor;
        }

        // Card024
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount024) >= 1) {
            Card024.sprite = CardDatabase.CardBaseImage[23];
            Card024.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card024.sprite = SpriteBackView;
            Card024.GetComponent<Image>().color = UnownedColor;
        }

        // Card025
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount025) >= 1) {
            Card025.sprite = CardDatabase.CardBaseImage[24];
            Card025.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card025.sprite = SpriteBackView;
            Card025.GetComponent<Image>().color = UnownedColor;
        }

        // Card026
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount026) >= 1) {
            Card026.sprite = CardDatabase.CardBaseImage[25];
            Card026.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card026.sprite = SpriteBackView;
            Card026.GetComponent<Image>().color = UnownedColor;
        }

        // Card027
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount027) >= 1) {
            Card027.sprite = CardDatabase.CardBaseImage[26];
            Card027.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card027.sprite = SpriteBackView;
            Card027.GetComponent<Image>().color = UnownedColor;
        }

        // Card028
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount028) >= 1) {
            Card028.sprite = CardDatabase.CardBaseImage[27];
            Card028.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card028.sprite = SpriteBackView;
            Card028.GetComponent<Image>().color = UnownedColor;
        }

        // Card029
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount029) >= 1) {
            Card029.sprite = CardDatabase.CardBaseImage[28];
            Card029.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card029.sprite = SpriteBackView;
            Card029.GetComponent<Image>().color = UnownedColor;
        }

        // Card030
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount030) >= 1) {
            Card030.sprite = CardDatabase.CardBaseImage[29];
            Card030.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card030.sprite = SpriteBackView;
            Card030.GetComponent<Image>().color = UnownedColor;
        }

        // Card031
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount031) >= 1) {
            Card031.sprite = CardDatabase.CardBaseImage[30];
            Card031.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card031.sprite = SpriteBackView;
            Card031.GetComponent<Image>().color = UnownedColor;
        }

        // Card032
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount032) >= 1) {
            Card032.sprite = CardDatabase.CardBaseImage[31];
            Card032.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card032.sprite = SpriteBackView;
            Card032.GetComponent<Image>().color = UnownedColor;
        }

        // Card033
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount033) >= 1) {
            Card033.sprite = CardDatabase.CardBaseImage[32];
            Card033.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card033.sprite = SpriteBackView;
            Card033.GetComponent<Image>().color = UnownedColor;
        }

        // Card034
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount034) >= 1) {
            Card034.sprite = CardDatabase.CardBaseImage[33];
            Card034.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card034.sprite = SpriteBackView;
            Card034.GetComponent<Image>().color = UnownedColor;
        }

        // Card035
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount035) >= 1) {
            Card035.sprite = CardDatabase.CardBaseImage[34];
            Card035.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card035.sprite = SpriteBackView;
            Card035.GetComponent<Image>().color = UnownedColor;
        }

        // Card036
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount036) >= 1) {
            Card036.sprite = CardDatabase.CardBaseImage[35];
            Card036.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card036.sprite = SpriteBackView;
            Card036.GetComponent<Image>().color = UnownedColor;
        }

        // Card037
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount037) >= 1) {
            Card037.sprite = CardDatabase.CardBaseImage[36];
            Card037.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card037.sprite = SpriteBackView;
            Card037.GetComponent<Image>().color = UnownedColor;
        }

        // Card038
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount038) >= 1) {
            Card038.sprite = CardDatabase.CardBaseImage[37];
            Card038.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card038.sprite = SpriteBackView;
            Card038.GetComponent<Image>().color = UnownedColor;
        }

        // Card039
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount039) >= 1) {
            Card039.sprite = CardDatabase.CardBaseImage[38];
            Card039.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card039.sprite = SpriteBackView;
            Card039.GetComponent<Image>().color = UnownedColor;
        }

        // Card040
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount040) >= 1) {
            Card040.sprite = CardDatabase.CardBaseImage[39];
            Card040.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card040.sprite = SpriteBackView;
            Card040.GetComponent<Image>().color = UnownedColor;
        }

        // Card041
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount041) >= 1) {
            Card041.sprite = CardDatabase.CardBaseImage[40];
            Card041.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card041.sprite = SpriteBackView;
            Card041.GetComponent<Image>().color = UnownedColor;
        }

        // Card042
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount042) >= 1) {
            Card042.sprite = CardDatabase.CardBaseImage[41];
            Card042.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card042.sprite = SpriteBackView;
            Card042.GetComponent<Image>().color = UnownedColor;
        }

        // Card043
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount043) >= 1) {
            Card043.sprite = CardDatabase.CardBaseImage[42];
            Card043.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card043.sprite = SpriteBackView;
            Card043.GetComponent<Image>().color = UnownedColor;
        }

        // Card044
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount044) >= 1) {
            Card044.sprite = CardDatabase.CardBaseImage[43];
            Card044.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card044.sprite = SpriteBackView;
            Card044.GetComponent<Image>().color = UnownedColor;
        }

        // Card045
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount045) >= 1) {
            Card045.sprite = CardDatabase.CardBaseImage[44];
            Card045.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card045.sprite = SpriteBackView;
            Card045.GetComponent<Image>().color = UnownedColor;
        }

        // Card046
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount046) >= 1) {
            Card046.sprite = CardDatabase.CardBaseImage[45];
            Card046.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card046.sprite = SpriteBackView;
            Card046.GetComponent<Image>().color = UnownedColor;
        }

        // Card047
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount047) >= 1) {
            Card047.sprite = CardDatabase.CardBaseImage[46];
            Card047.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card047.sprite = SpriteBackView;
            Card047.GetComponent<Image>().color = UnownedColor;
        }

        // Card048
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount048) >= 1) {
            Card048.sprite = CardDatabase.CardBaseImage[47];
            Card048.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card048.sprite = SpriteBackView;
            Card048.GetComponent<Image>().color = UnownedColor;
        }

        // Card049
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount049) >= 1) {
            Card049.sprite = CardDatabase.CardBaseImage[48];
            Card049.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card049.sprite = SpriteBackView;
            Card049.GetComponent<Image>().color = UnownedColor;
        }

        // Card050
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount050) >= 1) {
            Card050.sprite = CardDatabase.CardBaseImage[49];
            Card050.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card050.sprite = SpriteBackView;
            Card050.GetComponent<Image>().color = UnownedColor;
        }

        // Card051
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount051) >= 1) {
            Card051.sprite = CardDatabase.CardBaseImage[50];
            Card051.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card051.sprite = SpriteBackView;
            Card051.GetComponent<Image>().color = UnownedColor;
        }

        // Card052
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount052) >= 1) {
            Card052.sprite = CardDatabase.CardBaseImage[51];
            Card052.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card052.sprite = SpriteBackView;
            Card052.GetComponent<Image>().color = UnownedColor;
        }

        // Card053
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount053) >= 1) {
            Card053.sprite = CardDatabase.CardBaseImage[52];
            Card053.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card053.sprite = SpriteBackView;
            Card053.GetComponent<Image>().color = UnownedColor;
        }

        // Card054
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount054) >= 1) {
            Card054.sprite = CardDatabase.CardBaseImage[53];
            Card054.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card054.sprite = SpriteBackView;
            Card054.GetComponent<Image>().color = UnownedColor;
        }

        // Card055
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount055) >= 1) {
            Card055.sprite = CardDatabase.CardBaseImage[54];
            Card055.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card055.sprite = SpriteBackView;
            Card055.GetComponent<Image>().color = UnownedColor;
        }

        // Card056
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount056) >= 1) {
            Card056.sprite = CardDatabase.CardBaseImage[55];
            Card056.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card056.sprite = SpriteBackView;
            Card056.GetComponent<Image>().color = UnownedColor;
        }

        // Card057
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount057) >= 1) {
            Card057.sprite = CardDatabase.CardBaseImage[56];
            Card057.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card057.sprite = SpriteBackView;
            Card057.GetComponent<Image>().color = UnownedColor;
        }

        // Card058
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount058) >= 1) {
            Card058.sprite = CardDatabase.CardBaseImage[57];
            Card058.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card058.sprite = SpriteBackView;
            Card058.GetComponent<Image>().color = UnownedColor;
        }

        // Card059
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount059) >= 1) {
            Card059.sprite = CardDatabase.CardBaseImage[58];
            Card059.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card059.sprite = SpriteBackView;
            Card059.GetComponent<Image>().color = UnownedColor;
        }

        // Card060
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount060) >= 1) {
            Card060.sprite = CardDatabase.CardBaseImage[59];
            Card060.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card060.sprite = SpriteBackView;
            Card060.GetComponent<Image>().color = UnownedColor;
        }

        // Card061
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount061) >= 1) {
            Card061.sprite = CardDatabase.CardBaseImage[60];
            Card061.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card061.sprite = SpriteBackView;
            Card061.GetComponent<Image>().color = UnownedColor;
        }

        // Card062
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount062) >= 1) {
            Card062.sprite = CardDatabase.CardBaseImage[61];
            Card062.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card062.sprite = SpriteBackView;
            Card062.GetComponent<Image>().color = UnownedColor;
        }

        // Card063
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount063) >= 1) {
            Card063.sprite = CardDatabase.CardBaseImage[62];
            Card063.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card063.sprite = SpriteBackView;
            Card063.GetComponent<Image>().color = UnownedColor;
        }

        // Card064
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount064) >= 1) {
            Card064.sprite = CardDatabase.CardBaseImage[63];
            Card064.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card064.sprite = SpriteBackView;
            Card064.GetComponent<Image>().color = UnownedColor;
        }

        // Card065
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount065) >= 1) {
            Card065.sprite = CardDatabase.CardBaseImage[64];
            Card065.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card065.sprite = SpriteBackView;
            Card065.GetComponent<Image>().color = UnownedColor;
        }

        // Card066
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount066) >= 1) {
            Card066.sprite = CardDatabase.CardBaseImage[65];
            Card066.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card066.sprite = SpriteBackView;
            Card066.GetComponent<Image>().color = UnownedColor;
        }

        // Card067
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount067) >= 1) {
            Card067.sprite = CardDatabase.CardBaseImage[66];
            Card067.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card067.sprite = SpriteBackView;
            Card067.GetComponent<Image>().color = UnownedColor;
        }

        // Card068
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount068) >= 1) {
            Card068.sprite = CardDatabase.CardBaseImage[67];
            Card068.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card068.sprite = SpriteBackView;
            Card068.GetComponent<Image>().color = UnownedColor;
        }

        // Card069
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount069) >= 1) {
            Card069.sprite = CardDatabase.CardBaseImage[68];
            Card069.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card069.sprite = SpriteBackView;
            Card069.GetComponent<Image>().color = UnownedColor;
        }

        // Card070
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount070) >= 1) {
            Card070.sprite = CardDatabase.CardBaseImage[69];
            Card070.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card070.sprite = SpriteBackView;
            Card070.GetComponent<Image>().color = UnownedColor;
        }

        // Card071
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount071) >= 1) {
            Card071.sprite = CardDatabase.CardBaseImage[70];
            Card071.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card071.sprite = SpriteBackView;
            Card071.GetComponent<Image>().color = UnownedColor;
        }

        // Card072
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount072) >= 1) {
            Card072.sprite = CardDatabase.CardBaseImage[71];
            Card072.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card072.sprite = SpriteBackView;
            Card072.GetComponent<Image>().color = UnownedColor;
        }

        // Card073
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount073) >= 1) {
            Card073.sprite = CardDatabase.CardBaseImage[72];
            Card073.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card073.sprite = SpriteBackView;
            Card073.GetComponent<Image>().color = UnownedColor;
        }

        // Card074
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount074) >= 1) {
            Card074.sprite = CardDatabase.CardBaseImage[73];
            Card074.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card074.sprite = SpriteBackView;
            Card074.GetComponent<Image>().color = UnownedColor;
        }

        // Card075
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount075) >= 1) {
            Card075.sprite = CardDatabase.CardBaseImage[74];
            Card075.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card075.sprite = SpriteBackView;
            Card075.GetComponent<Image>().color = UnownedColor;
        }

        // Card076
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount076) >= 1) {
            Card076.sprite = CardDatabase.CardBaseImage[75];
            Card076.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card076.sprite = SpriteBackView;
            Card076.GetComponent<Image>().color = UnownedColor;
        }

        // Card077
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount077) >= 1) {
            Card077.sprite = CardDatabase.CardBaseImage[76];
            Card077.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card077.sprite = SpriteBackView;
            Card077.GetComponent<Image>().color = UnownedColor;
        }

        // Card078
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount078) >= 1) {
            Card078.sprite = CardDatabase.CardBaseImage[77];
            Card078.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card078.sprite = SpriteBackView;
            Card078.GetComponent<Image>().color = UnownedColor;
        }

        // Card079
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount079) >= 1) {
            Card079.sprite = CardDatabase.CardBaseImage[78];
            Card079.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card079.sprite = SpriteBackView;
            Card079.GetComponent<Image>().color = UnownedColor;
        }

        // Card080
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount080) >= 1) {
            Card080.sprite = CardDatabase.CardBaseImage[79];
            Card080.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card080.sprite = SpriteBackView;
            Card080.GetComponent<Image>().color = UnownedColor;
        }

        // Card081
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount081) >= 1) {
            Card081.sprite = CardDatabase.CardBaseImage[80];
            Card081.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card081.sprite = SpriteBackView;
            Card081.GetComponent<Image>().color = UnownedColor;
        }

        // Card082
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount082) >= 1) {
            Card082.sprite = CardDatabase.CardBaseImage[81];
            Card082.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card082.sprite = SpriteBackView;
            Card082.GetComponent<Image>().color = UnownedColor;
        }

        // Card083
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount083) >= 1) {
            Card083.sprite = CardDatabase.CardBaseImage[82];
            Card083.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card083.sprite = SpriteBackView;
            Card083.GetComponent<Image>().color = UnownedColor;
        }

        // Card084
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount084) >= 1) {
            Card084.sprite = CardDatabase.CardBaseImage[83];
            Card084.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card084.sprite = SpriteBackView;
            Card084.GetComponent<Image>().color = UnownedColor;
        }

        // Card085
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount085) >= 1) {
            Card085.sprite = CardDatabase.CardBaseImage[84];
            Card085.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card085.sprite = SpriteBackView;
            Card085.GetComponent<Image>().color = UnownedColor;
        }

        // Card086
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount086) >= 1) {
            Card086.sprite = CardDatabase.CardBaseImage[85];
            Card086.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card086.sprite = SpriteBackView;
            Card086.GetComponent<Image>().color = UnownedColor;
        }

        // Card087
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount087) >= 1) {
            Card087.sprite = CardDatabase.CardBaseImage[86];
            Card087.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card087.sprite = SpriteBackView;
            Card087.GetComponent<Image>().color = UnownedColor;
        }

        // Card088
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount088) >= 1) {
            Card088.sprite = CardDatabase.CardBaseImage[87];
            Card088.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card088.sprite = SpriteBackView;
            Card088.GetComponent<Image>().color = UnownedColor;
        }

        // Card089
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount089) >= 1) {
            Card089.sprite = CardDatabase.CardBaseImage[88];
            Card089.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card089.sprite = SpriteBackView;
            Card089.GetComponent<Image>().color = UnownedColor;
        }

        // Card090
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount090) >= 1) {
            Card090.sprite = CardDatabase.CardBaseImage[89];
            Card090.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card090.sprite = SpriteBackView;
            Card090.GetComponent<Image>().color = UnownedColor;
        }

        // Card091
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount091) >= 1) {
            Card091.sprite = CardDatabase.CardBaseImage[90];
            Card091.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card091.sprite = SpriteBackView;
            Card091.GetComponent<Image>().color = UnownedColor;
        }

        // Card092
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount092) >= 1) {
            Card092.sprite = CardDatabase.CardBaseImage[91];
            Card092.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card092.sprite = SpriteBackView;
            Card092.GetComponent<Image>().color = UnownedColor;
        }

        // Card093
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount093) >= 1) {
            Card093.sprite = CardDatabase.CardBaseImage[92];
            Card093.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card093.sprite = SpriteBackView;
            Card093.GetComponent<Image>().color = UnownedColor;
        }

        // Card094
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount094) >= 1) {
            Card094.sprite = CardDatabase.CardBaseImage[93];
            Card094.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card094.sprite = SpriteBackView;
            Card094.GetComponent<Image>().color = UnownedColor;
        }

        // Card095
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount095) >= 1) {
            Card095.sprite = CardDatabase.CardBaseImage[94];
            Card095.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card095.sprite = SpriteBackView;
            Card095.GetComponent<Image>().color = UnownedColor;
        }

        // Card096
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount096) >= 1) {
            Card096.sprite = CardDatabase.CardBaseImage[95];
            Card096.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card096.sprite = SpriteBackView;
            Card096.GetComponent<Image>().color = UnownedColor;
        }

        // Card097
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount097) >= 1) {
            Card097.sprite = CardDatabase.CardBaseImage[96];
            Card097.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card097.sprite = SpriteBackView;
            Card097.GetComponent<Image>().color = UnownedColor;
        }

        // Card098
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount098) >= 1) {
            Card098.sprite = CardDatabase.CardBaseImage[97];
            Card098.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card098.sprite = SpriteBackView;
            Card098.GetComponent<Image>().color = UnownedColor;
        }

        // Card099
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount099) >= 1) {
            Card099.sprite = CardDatabase.CardBaseImage[98];
            Card099.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card099.sprite = SpriteBackView;
            Card099.GetComponent<Image>().color = UnownedColor;
        }

        // Card100
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount100) >= 1) {
            Card100.sprite = CardDatabase.CardBaseImage[99];
            Card100.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card100.sprite = SpriteBackView;
            Card100.GetComponent<Image>().color = UnownedColor;
        }

        // Card101
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount101) >= 1) {
            Card101.sprite = CardDatabase.CardBaseImage[100];
            Card101.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card101.sprite = SpriteBackView;
            Card101.GetComponent<Image>().color = UnownedColor;
        }

        // Card102
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount102) >= 1) {
            Card102.sprite = CardDatabase.CardBaseImage[101];
            Card102.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card102.sprite = SpriteBackView;
            Card102.GetComponent<Image>().color = UnownedColor;
        }

        // Card103
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount103) >= 1) {
            Card103.sprite = CardDatabase.CardBaseImage[102];
            Card103.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card103.sprite = SpriteBackView;
            Card103.GetComponent<Image>().color = UnownedColor;
        }

        // Card104
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount104) >= 1) {
            Card104.sprite = CardDatabase.CardBaseImage[103];
            Card104.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card104.sprite = SpriteBackView;
            Card104.GetComponent<Image>().color = UnownedColor;
        }

        // Card105
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount105) >= 1) {
            Card105.sprite = CardDatabase.CardBaseImage[104];
            Card105.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card105.sprite = SpriteBackView;
            Card105.GetComponent<Image>().color = UnownedColor;
        }

        // Card106
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount106) >= 1) {
            Card106.sprite = CardDatabase.CardBaseImage[105];
            Card106.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card106.sprite = SpriteBackView;
            Card106.GetComponent<Image>().color = UnownedColor;
        }

        // Card107
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount107) >= 1) {
            Card107.sprite = CardDatabase.CardBaseImage[106];
            Card107.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card107.sprite = SpriteBackView;
            Card107.GetComponent<Image>().color = UnownedColor;
        }

        // Card108
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount108) >= 1) {
            Card108.sprite = CardDatabase.CardBaseImage[107];
            Card108.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card108.sprite = SpriteBackView;
            Card108.GetComponent<Image>().color = UnownedColor;
        }

        // Card109
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount109) >= 1) {
            Card109.sprite = CardDatabase.CardBaseImage[108];
            Card109.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card109.sprite = SpriteBackView;
            Card109.GetComponent<Image>().color = UnownedColor;
        }

        // Card110
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount110) >= 1) {
            Card110.sprite = CardDatabase.CardBaseImage[109];
            Card110.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card110.sprite = SpriteBackView;
            Card110.GetComponent<Image>().color = UnownedColor;
        }

        // Card111
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount111) >= 1) {
            Card111.sprite = CardDatabase.CardBaseImage[110];
            Card111.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card111.sprite = SpriteBackView;
            Card111.GetComponent<Image>().color = UnownedColor;
        }

        // Card112
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount112) >= 1) {
            Card112.sprite = CardDatabase.CardBaseImage[111];
            Card112.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card112.sprite = SpriteBackView;
            Card112.GetComponent<Image>().color = UnownedColor;
        }

        // Card113
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount113) >= 1) {
            Card113.sprite = CardDatabase.CardBaseImage[112];
            Card113.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card113.sprite = SpriteBackView;
            Card113.GetComponent<Image>().color = UnownedColor;
        }

        // Card114
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount114) >= 1) {
            Card114.sprite = CardDatabase.CardBaseImage[113];
            Card114.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card114.sprite = SpriteBackView;
            Card114.GetComponent<Image>().color = UnownedColor;
        }

        // Card115
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount115) >= 1) {
            Card115.sprite = CardDatabase.CardBaseImage[114];
            Card115.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card115.sprite = SpriteBackView;
            Card115.GetComponent<Image>().color = UnownedColor;
        }

        // Card116
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount116) >= 1) {
            Card116.sprite = CardDatabase.CardBaseImage[115];
            Card116.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card116.sprite = SpriteBackView;
            Card116.GetComponent<Image>().color = UnownedColor;
        }

        // Card117
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount117) >= 1) {
            Card117.sprite = CardDatabase.CardBaseImage[116];
            Card117.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card117.sprite = SpriteBackView;
            Card117.GetComponent<Image>().color = UnownedColor;
        }

        // Card118
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount118) >= 1) {
            Card118.sprite = CardDatabase.CardBaseImage[117];
            Card118.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card118.sprite = SpriteBackView;
            Card118.GetComponent<Image>().color = UnownedColor;
        }

        // Card119
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount119) >= 1) {
            Card119.sprite = CardDatabase.CardBaseImage[118];
            Card119.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card119.sprite = SpriteBackView;
            Card119.GetComponent<Image>().color = UnownedColor;
        }

        // Card120
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount120) >= 1) {
            Card120.sprite = CardDatabase.CardBaseImage[119];
            Card120.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card120.sprite = SpriteBackView;
            Card120.GetComponent<Image>().color = UnownedColor;
        }

        // Card121
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount121) >= 1) {
            Card121.sprite = CardDatabase.CardBaseImage[120];
            Card121.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card121.sprite = SpriteBackView;
            Card121.GetComponent<Image>().color = UnownedColor;
        }

        // Card122
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount122) >= 1) {
            Card122.sprite = CardDatabase.CardBaseImage[121];
            Card122.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card122.sprite = SpriteBackView;
            Card122.GetComponent<Image>().color = UnownedColor;
        }

        // Card123
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount123) >= 1) {
            Card123.sprite = CardDatabase.CardBaseImage[122];
            Card123.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card123.sprite = SpriteBackView;
            Card123.GetComponent<Image>().color = UnownedColor;
        }

        // Card124
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount124) >= 1) {
            Card124.sprite = CardDatabase.CardBaseImage[123];
            Card124.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card124.sprite = SpriteBackView;
            Card124.GetComponent<Image>().color = UnownedColor;
        }

        // Card125
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount125) >= 1) {
            Card125.sprite = CardDatabase.CardBaseImage[124];
            Card125.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card125.sprite = SpriteBackView;
            Card125.GetComponent<Image>().color = UnownedColor;
        }

        // Card126
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount126) >= 1) {
            Card126.sprite = CardDatabase.CardBaseImage[125];
            Card126.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card126.sprite = SpriteBackView;
            Card126.GetComponent<Image>().color = UnownedColor;
        }

        // Card127
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount127) >= 1) {
            Card127.sprite = CardDatabase.CardBaseImage[126];
            Card127.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card127.sprite = SpriteBackView;
            Card127.GetComponent<Image>().color = UnownedColor;
        }

        // Card128
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount128) >= 1) {
            Card128.sprite = CardDatabase.CardBaseImage[127];
            Card128.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card128.sprite = SpriteBackView;
            Card128.GetComponent<Image>().color = UnownedColor;
        }

        // Card129
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount129) >= 1) {
            Card129.sprite = CardDatabase.CardBaseImage[128];
            Card129.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card129.sprite = SpriteBackView;
            Card129.GetComponent<Image>().color = UnownedColor;
        }

        // Card130
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount130) >= 1) {
            Card130.sprite = CardDatabase.CardBaseImage[129];
            Card130.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card130.sprite = SpriteBackView;
            Card130.GetComponent<Image>().color = UnownedColor;
        }

        // Card131
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount131) >= 1) {
            Card131.sprite = CardDatabase.CardBaseImage[130];
            Card131.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card131.sprite = SpriteBackView;
            Card131.GetComponent<Image>().color = UnownedColor;
        }

        // Card132
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount132) >= 1) {
            Card132.sprite = CardDatabase.CardBaseImage[131];
            Card132.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card132.sprite = SpriteBackView;
            Card132.GetComponent<Image>().color = UnownedColor;
        }

        // Card133
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount133) >= 1) {
            Card133.sprite = CardDatabase.CardBaseImage[132];
            Card133.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card133.sprite = SpriteBackView;
            Card133.GetComponent<Image>().color = UnownedColor;
        }

        // Card134
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount134) >= 1) {
            Card134.sprite = CardDatabase.CardBaseImage[133];
            Card134.GetComponent<Image>().color = OwnedColor;
        }

        else {
            Card134.sprite = SpriteBackView;
            Card134.GetComponent<Image>().color = UnownedColor;
        }
    }

    public void ShowZoomInformation() {
        if (ZoomInNumber == 0) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount001;
        }

        else if (ZoomInNumber == 1) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount002;
        }

        else if (ZoomInNumber == 2) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount003;
        }

        else if (ZoomInNumber == 3) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount004;
        }

        else if (ZoomInNumber == 4) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount005;
        }

        else if (ZoomInNumber == 5) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount006;
        }

        else if (ZoomInNumber == 6) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount007;
        }

        else if (ZoomInNumber == 7) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount008;
        }

        else if (ZoomInNumber == 8) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount009;
        }

        else if (ZoomInNumber == 9) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount010;
        }

        else if (ZoomInNumber == 10) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount011;
        }

        else if (ZoomInNumber == 11) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount012;
        }

        else if (ZoomInNumber == 12) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount013;
        }

        else if (ZoomInNumber == 13) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount014;
        }

        else if (ZoomInNumber == 14) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount015;
        }

        else if (ZoomInNumber == 15) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount016;
        }

        else if (ZoomInNumber == 16) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount017;
        }

        else if (ZoomInNumber == 17) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount018;
        }

        else if (ZoomInNumber == 18) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount019;
        }

        else if (ZoomInNumber == 19) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount020;
        }

        else if (ZoomInNumber == 20) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount021;
        }

        else if (ZoomInNumber == 21) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount022;
        }

        else if (ZoomInNumber == 22) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount023;
        }

        else if (ZoomInNumber == 23) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount024;
        }

        else if (ZoomInNumber == 24) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount025;
        }

        else if (ZoomInNumber == 25) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount026;
        }

        else if (ZoomInNumber == 26) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount027;
        }

        else if (ZoomInNumber == 27) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount028;
        }

        else if (ZoomInNumber == 28) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount029;
        }

        else if (ZoomInNumber == 29) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount030;
        }

        else if (ZoomInNumber == 30) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount031;
        }

        else if (ZoomInNumber == 31) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount032;
        }

        else if (ZoomInNumber == 32) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount033;
        }

        else if (ZoomInNumber == 33) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount034;
        }

        else if (ZoomInNumber == 34) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount035;
        }

        else if (ZoomInNumber == 35) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount036;
        }

        else if (ZoomInNumber == 36) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount037;
        }

        else if (ZoomInNumber == 37) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount038;
        }

        else if (ZoomInNumber == 38) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount039;
        }

        else if (ZoomInNumber == 39) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount040;
        }

        else if (ZoomInNumber == 40) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount041;
        }

        else if (ZoomInNumber == 41) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount042;
        }

        else if (ZoomInNumber == 42) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount043;
        }

        else if (ZoomInNumber == 43) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount044;
        }

        else if (ZoomInNumber == 44) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount045;
        }

        else if (ZoomInNumber == 45) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount046;
        }

        else if (ZoomInNumber == 46) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount047;
        }

        else if (ZoomInNumber == 47) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount048;
        }

        else if (ZoomInNumber == 48) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount049;
        }

        else if (ZoomInNumber == 49) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount050;
        }

        else if (ZoomInNumber == 50) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount051;
        }

        else if (ZoomInNumber == 51) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount052;
        }

        else if (ZoomInNumber == 52) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount053;
        }

        else if (ZoomInNumber == 53) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount054;
        }

        else if (ZoomInNumber == 54) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount055;
        }

        else if (ZoomInNumber == 55) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount056;
        }

        else if (ZoomInNumber == 56) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount057;
        }

        else if (ZoomInNumber == 57) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount058;
        }

        else if (ZoomInNumber == 58) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount059;
        }

        else if (ZoomInNumber == 59) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount060;
        }

        else if (ZoomInNumber == 60) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount061;
        }

        else if (ZoomInNumber == 61) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount062;
        }

        else if (ZoomInNumber == 62) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount063;
        }

        else if (ZoomInNumber == 63) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount064;
        }

        else if (ZoomInNumber == 64) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount065;
        }

        else if (ZoomInNumber == 65) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount066;
        }

        else if (ZoomInNumber == 66) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount067;
        }

        else if (ZoomInNumber == 67) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount068;
        }

        else if (ZoomInNumber == 68) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount069;
        }

        else if (ZoomInNumber == 69) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount070;
        }

        else if (ZoomInNumber == 70) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount071;
        }

        else if (ZoomInNumber == 71) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount072;
        }

        else if (ZoomInNumber == 72) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount073;
        }

        else if (ZoomInNumber == 73) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount074;
        }

        else if (ZoomInNumber == 74) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount075;
        }

        else if (ZoomInNumber == 75) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount076;
        }

        else if (ZoomInNumber == 76) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount077;
        }

        else if (ZoomInNumber == 77) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount078;
        }

        else if (ZoomInNumber == 78) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount079;
        }

        else if (ZoomInNumber == 79) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount080;
        }

        else if (ZoomInNumber == 80) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount081;
        }

        else if (ZoomInNumber == 81) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount082;
        }

        else if (ZoomInNumber == 82) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount083;
        }

        else if (ZoomInNumber == 83) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount084;
        }

        else if (ZoomInNumber == 84) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount085;
        }

        else if (ZoomInNumber == 85) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount086;
        }

        else if (ZoomInNumber == 86) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount087;
        }

        else if (ZoomInNumber == 87) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount088;
        }

        else if (ZoomInNumber == 88) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount089;
        }

        else if (ZoomInNumber == 89) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount090;
        }

        else if (ZoomInNumber == 90) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount091;
        }

        else if (ZoomInNumber == 91) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount092;
        }

        else if (ZoomInNumber == 92) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount093;
        }

        else if (ZoomInNumber == 93) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount094;
        }

        else if (ZoomInNumber == 94) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount095;
        }

        else if (ZoomInNumber == 95) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount096;
        }

        else if (ZoomInNumber == 96) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount097;
        }

        else if (ZoomInNumber == 97) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount098;
        }

        else if (ZoomInNumber == 98) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount099;
        }

        else if (ZoomInNumber == 99) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount100;
        }

        else if (ZoomInNumber == 100) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount101;
        }

        else if (ZoomInNumber == 101) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount102;
        }

        else if (ZoomInNumber == 102) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount103;
        }

        else if (ZoomInNumber == 103) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount104;
        }

        else if (ZoomInNumber == 104) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount105;
        }

        else if (ZoomInNumber == 105) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount106;
        }

        else if (ZoomInNumber == 106) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount107;
        }

        else if (ZoomInNumber == 107) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount108;
        }

        else if (ZoomInNumber == 108) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount109;
        }

        else if (ZoomInNumber == 109) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount110;
        }

        else if (ZoomInNumber == 110) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount111;
        }

        else if (ZoomInNumber == 111) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount112;
        }

        else if (ZoomInNumber == 112) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount113;
        }

        else if (ZoomInNumber == 113) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount114;
        }

        else if (ZoomInNumber == 114) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount115;
        }

        else if (ZoomInNumber == 115) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount116;
        }

        else if (ZoomInNumber == 116) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount117;
        }

        else if (ZoomInNumber == 117) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount118;
        }

        else if (ZoomInNumber == 118) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount119;
        }

        else if (ZoomInNumber == 119) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount120;
        }

        else if (ZoomInNumber == 120) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount121;
        }

        else if (ZoomInNumber == 121) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount122;
        }

        else if (ZoomInNumber == 122) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount123;
        }

        else if (ZoomInNumber == 123) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount124;
        }

        else if (ZoomInNumber == 124) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount125;
        }

        else if (ZoomInNumber == 125) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount126;
        }

        else if (ZoomInNumber == 126) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount127;
        }

        else if (ZoomInNumber == 127) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount128;
        }

        else if (ZoomInNumber == 128) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount129;
        }

        else if (ZoomInNumber == 129) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount130;
        }

        else if (ZoomInNumber == 130) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount131;
        }

        else if (ZoomInNumber == 131) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount132;
        }

        else if (ZoomInNumber == 132) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount133;
        }

        else if (ZoomInNumber == 133) {
            ZoomTitle.text = CardDatabase.CardName[ZoomInNumber];
            ZoomCard.sprite = CardDatabase.CardBaseImage[ZoomInNumber];
            ZoomRealm.text = "Card Realm:" + "\n" + CardDatabase.CardRealm[ZoomInNumber];
            ZoomType.text = "Card Type:" + "\n" + CardDatabase.CardType[ZoomInNumber];
            ZoomNumber.text = "Card Number:" + "\n" + CardDatabase.CardNumber[ZoomInNumber] + " / 134";
            ZoomDescription.text = CardDatabase.CardDescription[ZoomInNumber];
            ZoomOwnNumber.text = PlayerDatabase.PlayerCardAmount134;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}