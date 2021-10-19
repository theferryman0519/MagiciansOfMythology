using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects09A : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImage;
    public Text TitleText;
    public Text ActionText;

    // Gods Items
    public Image PickGodsScroll;
    public Image PickGodsView;
    public Text SelectedText;
    public Image ContinueButton;
    public Text GodText01;
    public Image GodOn01;
    public Text GodText02;
    public Image GodOn02;
    public Text GodText03;
    public Image GodOn03;
    public Text GodText04;
    public Image GodOn04;
    public Text GodText05;
    public Image GodOn05;
    public Text GodText06;
    public Image GodOn06;
    public Text GodText07;
    public Image GodOn07;
    public Text GodText08;
    public Image GodOn08;
    public Text GodText09;
    public Image GodOn09;
    public Text GodText10;
    public Image GodOn10;
    public Text GodText11;
    public Image GodOn11;
    public Text GodText12;
    public Image GodOn12;
    public Text GodText13;
    public Image GodOn13;
    public Text GodText14;
    public Image GodOn14;
    public Text GodText15;
    public Image GodOn15;
    public Text GodText16;
    public Image GodOn16;
    public Text GodText17;
    public Image GodOn17;
    public Text GodText18;
    public Image GodOn18;
    public Text GodText19;
    public Image GodOn19;
    public Text GodText20;
    public Image GodOn20;
    public Text GodText21;
    public Image GodOn21;
    public Text GodText22;
    public Image GodOn22;
    public Text GodText23;
    public Image GodOn23;
    public Text GodText24;
    public Image GodOn24;
    public Text GodText25;
    public Image GodOn25;
    public Text GodText26;
    public Image GodOn26;
    public Text GodText27;
    public Image GodOn27;
    public Text GodText28;
    public Image GodOn28;
    public Text GodText29;
    public Image GodOn29;
    public Text GodText30;
    public Image GodOn30;
    public Text GodText31;
    public Image GodOn31;
    public Text GodText32;
    public Image GodOn32;
    public Text GodText33;
    public Image GodOn33;
    public Text GodText34;
    public Image GodOn34;
    public Text GodText35;
    public Image GodOn35;
    public Text GodText36;
    public Image GodOn36;
    public Text GodText37;
    public Image GodOn37;
    public Text GodText38;
    public Image GodOn38;
    public Text GodText39;
    public Image GodOn39;
    public Text GodText40;
    public Image GodOn40;
    public Text GodText41;
    public Image GodOn41;
    public Text GodText42;
    public Image GodOn42;
    public Text GodText43;
    public Image GodOn43;
    public Text GodText44;
    public Image GodOn44;
    public Text GodText45;
    public Image GodOn45;
    public Text GodText46;
    public Image GodOn46;
    public Text GodText47;
    public Image GodOn47;
    public Text GodText48;
    public Image GodOn48;
    public Text GodText49;
    public Image GodOn49;
    public Text GodText50;
    public Image GodOn50;
    public Text GodText51;
    public Image GodOn51;
    public Text GodText52;
    public Image GodOn52;
    public Text GodText53;
    public Image GodOn53;
    public Text GodText54;
    public Image GodOn54;
    public Text GodText55;
    public Image GodOn55;
    public Text GodText56;
    public Image GodOn56;
    public Text GodText57;
    public Image GodOn57;
    public Text GodText58;
    public Image GodOn58;
    public Text GodText59;
    public Image GodOn59;
    public Text GodText60;
    public Image GodOn60;
    public Text GodText61;
    public Image GodOn61;
    public Text GodText62;
    public Image GodOn62;
    public Text GodText63;
    public Image GodOn63;
    public Text GodText64;
    public Image GodOn64;
    public Text GodText65;
    public Image GodOn65;
    public Text GodText66;
    public Image GodOn66;

    // Sprites
    public Sprite SelectedSprite;
    public Sprite SelectSprite;

// -------------------- PRIVATE VARIABLES --------------------
    Color OwnedColor = new Color(1.0f, 1.0f, 1.0f);
    Color UnownedColor = new Color(0.5f, 0.5f, 0.5f);

// -------------------- STATIC VARIABLES --------------------
    public static int GamePlayPanelInt;
    public static List<int> OwnedGodsList = new List<int>();

    // Gods Items
    public static int GodIntOn01;
    public static int GodIntOn02;
    public static int GodIntOn03;
    public static int GodIntOn04;
    public static int GodIntOn05;
    public static int GodIntOn06;
    public static int GodIntOn07;
    public static int GodIntOn08;
    public static int GodIntOn09;
    public static int GodIntOn10;
    public static int GodIntOn11;
    public static int GodIntOn12;
    public static int GodIntOn13;
    public static int GodIntOn14;
    public static int GodIntOn15;
    public static int GodIntOn16;
    public static int GodIntOn17;
    public static int GodIntOn18;
    public static int GodIntOn19;
    public static int GodIntOn20;
    public static int GodIntOn21;
    public static int GodIntOn22;
    public static int GodIntOn23;
    public static int GodIntOn24;
    public static int GodIntOn25;
    public static int GodIntOn26;
    public static int GodIntOn27;
    public static int GodIntOn28;
    public static int GodIntOn29;
    public static int GodIntOn30;
    public static int GodIntOn31;
    public static int GodIntOn32;
    public static int GodIntOn33;
    public static int GodIntOn34;
    public static int GodIntOn35;
    public static int GodIntOn36;
    public static int GodIntOn37;
    public static int GodIntOn38;
    public static int GodIntOn39;
    public static int GodIntOn40;
    public static int GodIntOn41;
    public static int GodIntOn42;
    public static int GodIntOn43;
    public static int GodIntOn44;
    public static int GodIntOn45;
    public static int GodIntOn46;
    public static int GodIntOn47;
    public static int GodIntOn48;
    public static int GodIntOn49;
    public static int GodIntOn50;
    public static int GodIntOn51;
    public static int GodIntOn52;
    public static int GodIntOn53;
    public static int GodIntOn54;
    public static int GodIntOn55;
    public static int GodIntOn56;
    public static int GodIntOn57;
    public static int GodIntOn58;
    public static int GodIntOn59;
    public static int GodIntOn60;
    public static int GodIntOn61;
    public static int GodIntOn62;
    public static int GodIntOn63;
    public static int GodIntOn64;
    public static int GodIntOn65;
    public static int GodIntOn66;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------


// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableMain();
        SetInitialSprites();

        TitleText.text = "Duel Set-Up:" + "\n" + "Choose Your Gods";
        ActionText.text = "Before starting the duel, you must select up to five (5) gods to do battle on your behalf. Below is the list of all gods, with cards you own at the top. Select up five and then click Next to continue.";
        ShowGodsItems();
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        SettingSprites();

        SelectedText.text = Buttons09A.TotalGodsInPlay.ToString() + " / 5 Cards";
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- ENABLE OBJECTS FUNCTIONS --------------------
    public void EnableMain() {
        BackgroundImage.enabled = true;
        TitleText.enabled = true;
        ActionText.enabled = true;
    }

// -------------------- ENABLE OBJECTS FUNCTIONS --------------------
    public void DisableMain() {
        BackgroundImage.enabled = false;
        TitleText.enabled = false;
        ActionText.enabled = false;
    }

    public void DisableAllGodsItems() {
        PickGodsScroll.enabled = false;
        PickGodsView.enabled = false;
        SelectedText.enabled = false;
        ContinueButton.enabled = false;
        GodText01.enabled = false;
        GodOn01.enabled = false;
        GodText02.enabled = false;
        GodOn02.enabled = false;
        GodText03.enabled = false;
        GodOn03.enabled = false;
        GodText04.enabled = false;
        GodOn04.enabled = false;
        GodText05.enabled = false;
        GodOn05.enabled = false;
        GodText06.enabled = false;
        GodOn06.enabled = false;
        GodText07.enabled = false;
        GodOn07.enabled = false;
        GodText08.enabled = false;
        GodOn08.enabled = false;
        GodText09.enabled = false;
        GodOn09.enabled = false;
        GodText10.enabled = false;
        GodOn10.enabled = false;
        GodText11.enabled = false;
        GodOn11.enabled = false;
        GodText12.enabled = false;
        GodOn12.enabled = false;
        GodText13.enabled = false;
        GodOn13.enabled = false;
        GodText14.enabled = false;
        GodOn14.enabled = false;
        GodText15.enabled = false;
        GodOn15.enabled = false;
        GodText16.enabled = false;
        GodOn16.enabled = false;
        GodText17.enabled = false;
        GodOn17.enabled = false;
        GodText18.enabled = false;
        GodOn18.enabled = false;
        GodText19.enabled = false;
        GodOn19.enabled = false;
        GodText20.enabled = false;
        GodOn20.enabled = false;
        GodText21.enabled = false;
        GodOn21.enabled = false;
        GodText22.enabled = false;
        GodOn22.enabled = false;
        GodText23.enabled = false;
        GodOn23.enabled = false;
        GodText24.enabled = false;
        GodOn24.enabled = false;
        GodText25.enabled = false;
        GodOn25.enabled = false;
        GodText26.enabled = false;
        GodOn26.enabled = false;
        GodText27.enabled = false;
        GodOn27.enabled = false;
        GodText28.enabled = false;
        GodOn28.enabled = false;
        GodText29.enabled = false;
        GodOn29.enabled = false;
        GodText30.enabled = false;
        GodOn30.enabled = false;
        GodText31.enabled = false;
        GodOn31.enabled = false;
        GodText32.enabled = false;
        GodOn32.enabled = false;
        GodText33.enabled = false;
        GodOn33.enabled = false;
        GodText34.enabled = false;
        GodOn34.enabled = false;
        GodText35.enabled = false;
        GodOn35.enabled = false;
        GodText36.enabled = false;
        GodOn36.enabled = false;
        GodText37.enabled = false;
        GodOn37.enabled = false;
        GodText38.enabled = false;
        GodOn38.enabled = false;
        GodText39.enabled = false;
        GodOn39.enabled = false;
        GodText40.enabled = false;
        GodOn40.enabled = false;
        GodText41.enabled = false;
        GodOn41.enabled = false;
        GodText42.enabled = false;
        GodOn42.enabled = false;
        GodText43.enabled = false;
        GodOn43.enabled = false;
        GodText44.enabled = false;
        GodOn44.enabled = false;
        GodText45.enabled = false;
        GodOn45.enabled = false;
        GodText46.enabled = false;
        GodOn46.enabled = false;
        GodText47.enabled = false;
        GodOn47.enabled = false;
        GodText48.enabled = false;
        GodOn48.enabled = false;
        GodText49.enabled = false;
        GodOn49.enabled = false;
        GodText50.enabled = false;
        GodOn50.enabled = false;
        GodText51.enabled = false;
        GodOn51.enabled = false;
        GodText52.enabled = false;
        GodOn52.enabled = false;
        GodText53.enabled = false;
        GodOn53.enabled = false;
        GodText54.enabled = false;
        GodOn54.enabled = false;
        GodText55.enabled = false;
        GodOn55.enabled = false;
        GodText56.enabled = false;
        GodOn56.enabled = false;
        GodText57.enabled = false;
        GodOn57.enabled = false;
        GodText58.enabled = false;
        GodOn58.enabled = false;
        GodText59.enabled = false;
        GodOn59.enabled = false;
        GodText60.enabled = false;
        GodOn60.enabled = false;
        GodText61.enabled = false;
        GodOn61.enabled = false;
        GodText62.enabled = false;
        GodOn62.enabled = false;
        GodText63.enabled = false;
        GodOn63.enabled = false;
        GodText64.enabled = false;
        GodOn64.enabled = false;
        GodText65.enabled = false;
        GodOn65.enabled = false;
        GodText66.enabled = false;
        GodOn66.enabled = false;
    }

// -------------------- UPDATE FUNCTIONS --------------------
    public void ShowGodsItems() {
        // Disable All Items
        DisableAllGodsItems();

        // Enable Main Items
        PickGodsScroll.enabled = true;
        PickGodsView.enabled = true;
        SelectedText.enabled = true;
        ContinueButton.enabled = true;

        // Enable Owned
        EnableOwnedGods();
        DownloadOwnedGods();
    }

    public void EnableOwnedGods() {
        // Dark
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount012) >= 1) {
            OwnedGodsList.Add(011);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount013) >= 1) {
            OwnedGodsList.Add(012);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount014) >= 1) {
            OwnedGodsList.Add(013);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount015) >= 1) {
            OwnedGodsList.Add(014);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount016) >= 1) {
            OwnedGodsList.Add(015);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount017) >= 1) {
            OwnedGodsList.Add(016);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount018) >= 1) {
            OwnedGodsList.Add(017);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount019) >= 1) {
            OwnedGodsList.Add(018);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount020) >= 1) {
            OwnedGodsList.Add(019);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount021) >= 1) {
            OwnedGodsList.Add(020);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount022) >= 1) {
            OwnedGodsList.Add(021);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount023) >= 1) {
            OwnedGodsList.Add(022);
        }

        // Earth
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount035) >= 1) {
            OwnedGodsList.Add(034);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount036) >= 1) {
            OwnedGodsList.Add(035);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount037) >= 1) {
            OwnedGodsList.Add(036);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount038) >= 1) {
            OwnedGodsList.Add(037);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount039) >= 1) {
            OwnedGodsList.Add(038);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount040) >= 1) {
            OwnedGodsList.Add(039);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount041) >= 1) {
            OwnedGodsList.Add(040);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount042) >= 1) {
            OwnedGodsList.Add(041);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount043) >= 1) {
            OwnedGodsList.Add(042);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount044) >= 1) {
            OwnedGodsList.Add(043);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount045) >= 1) {
            OwnedGodsList.Add(044);
        }

        // Light
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount057) >= 1) {
            OwnedGodsList.Add(056);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount058) >= 1) {
            OwnedGodsList.Add(057);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount059) >= 1) {
            OwnedGodsList.Add(058);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount060) >= 1) {
            OwnedGodsList.Add(059);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount061) >= 1) {
            OwnedGodsList.Add(060);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount062) >= 1) {
            OwnedGodsList.Add(061);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount063) >= 1) {
            OwnedGodsList.Add(062);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount064) >= 1) {
            OwnedGodsList.Add(063);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount065) >= 1) {
            OwnedGodsList.Add(064);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount066) >= 1) {
            OwnedGodsList.Add(065);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount067) >= 1) {
            OwnedGodsList.Add(066);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount068) >= 1) {
            OwnedGodsList.Add(067);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount069) >= 1) {
            OwnedGodsList.Add(068);
        }

        // Sea
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount081) >= 1) {
            OwnedGodsList.Add(080);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount082) >= 1) {
            OwnedGodsList.Add(081);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount083) >= 1) {
            OwnedGodsList.Add(082);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount084) >= 1) {
            OwnedGodsList.Add(083);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount085) >= 1) {
            OwnedGodsList.Add(084);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount086) >= 1) {
            OwnedGodsList.Add(085);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount087) >= 1) {
            OwnedGodsList.Add(086);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount088) >= 1) {
            OwnedGodsList.Add(087);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount089) >= 1) {
            OwnedGodsList.Add(088);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount090) >= 1) {
            OwnedGodsList.Add(089);
        }

        // Skies
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount102) >= 1) {
            OwnedGodsList.Add(101);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount103) >= 1) {
            OwnedGodsList.Add(102);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount104) >= 1) {
            OwnedGodsList.Add(103);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount105) >= 1) {
            OwnedGodsList.Add(104);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount106) >= 1) {
            OwnedGodsList.Add(105);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount107) >= 1) {
            OwnedGodsList.Add(106);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount108) >= 1) {
            OwnedGodsList.Add(107);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount109) >= 1) {
            OwnedGodsList.Add(108);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount110) >= 1) {
            OwnedGodsList.Add(109);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount111) >= 1) {
            OwnedGodsList.Add(110);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount112) >= 1) {
            OwnedGodsList.Add(111);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount113) >= 1) {
            OwnedGodsList.Add(112);
        }

        // Epic
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount120) >= 1) {
            OwnedGodsList.Add(119);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount121) >= 1) {
            OwnedGodsList.Add(120);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount122) >= 1) {
            OwnedGodsList.Add(121);
        }

        // World
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount130) >= 1) {
            OwnedGodsList.Add(129);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount131) >= 1) {
            OwnedGodsList.Add(130);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount132) >= 1) {
            OwnedGodsList.Add(131);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount133) >= 1) {
            OwnedGodsList.Add(132);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount134) >= 1) {
            OwnedGodsList.Add(133);
        }

        // Enabling All Texts
        GodText01.enabled = true;
        GodText02.enabled = true;
        GodText03.enabled = true;
        GodText04.enabled = true;
        GodText05.enabled = true;
        GodText06.enabled = true;
        GodText07.enabled = true;
        GodText08.enabled = true;
        GodText09.enabled = true;
        GodText10.enabled = true;
        GodText11.enabled = true;
        GodText12.enabled = true;
        GodText13.enabled = true;
        GodText14.enabled = true;
        GodText15.enabled = true;
        GodText16.enabled = true;
        GodText17.enabled = true;
        GodText18.enabled = true;
        GodText19.enabled = true;
        GodText20.enabled = true;
        GodText21.enabled = true;
        GodText22.enabled = true;
        GodText23.enabled = true;
        GodText24.enabled = true;
        GodText25.enabled = true;
        GodText26.enabled = true;
        GodText27.enabled = true;
        GodText28.enabled = true;
        GodText29.enabled = true;
        GodText30.enabled = true;
        GodText31.enabled = true;
        GodText32.enabled = true;
        GodText33.enabled = true;
        GodText34.enabled = true;
        GodText35.enabled = true;
        GodText36.enabled = true;
        GodText37.enabled = true;
        GodText38.enabled = true;
        GodText39.enabled = true;
        GodText40.enabled = true;
        GodText41.enabled = true;
        GodText42.enabled = true;
        GodText43.enabled = true;
        GodText44.enabled = true;
        GodText45.enabled = true;
        GodText46.enabled = true;
        GodText47.enabled = true;
        GodText48.enabled = true;
        GodText49.enabled = true;
        GodText50.enabled = true;
        GodText51.enabled = true;
        GodText52.enabled = true;
        GodText53.enabled = true;
        GodText54.enabled = true;
        GodText55.enabled = true;
        GodText56.enabled = true;
        GodText57.enabled = true;
        GodText58.enabled = true;
        GodText59.enabled = true;
        GodText60.enabled = true;
        GodText61.enabled = true;
        GodText62.enabled = true;
        GodText63.enabled = true;
        GodText64.enabled = true;
        GodText65.enabled = true;
        GodText66.enabled = true;

        // Coloring All Texts
        GodText01.color = UnownedColor;
        GodText02.color = UnownedColor;
        GodText03.color = UnownedColor;
        GodText04.color = UnownedColor;
        GodText05.color = UnownedColor;
        GodText06.color = UnownedColor;
        GodText07.color = UnownedColor;
        GodText08.color = UnownedColor;
        GodText09.color = UnownedColor;
        GodText10.color = UnownedColor;
        GodText11.color = UnownedColor;
        GodText12.color = UnownedColor;
        GodText13.color = UnownedColor;
        GodText14.color = UnownedColor;
        GodText15.color = UnownedColor;
        GodText16.color = UnownedColor;
        GodText17.color = UnownedColor;
        GodText18.color = UnownedColor;
        GodText19.color = UnownedColor;
        GodText20.color = UnownedColor;
        GodText21.color = UnownedColor;
        GodText22.color = UnownedColor;
        GodText23.color = UnownedColor;
        GodText24.color = UnownedColor;
        GodText25.color = UnownedColor;
        GodText26.color = UnownedColor;
        GodText27.color = UnownedColor;
        GodText28.color = UnownedColor;
        GodText29.color = UnownedColor;
        GodText30.color = UnownedColor;
        GodText31.color = UnownedColor;
        GodText32.color = UnownedColor;
        GodText33.color = UnownedColor;
        GodText34.color = UnownedColor;
        GodText35.color = UnownedColor;
        GodText36.color = UnownedColor;
        GodText37.color = UnownedColor;
        GodText38.color = UnownedColor;
        GodText39.color = UnownedColor;
        GodText40.color = UnownedColor;
        GodText41.color = UnownedColor;
        GodText42.color = UnownedColor;
        GodText43.color = UnownedColor;
        GodText44.color = UnownedColor;
        GodText45.color = UnownedColor;
        GodText46.color = UnownedColor;
        GodText47.color = UnownedColor;
        GodText48.color = UnownedColor;
        GodText49.color = UnownedColor;
        GodText50.color = UnownedColor;
        GodText51.color = UnownedColor;
        GodText52.color = UnownedColor;
        GodText53.color = UnownedColor;
        GodText54.color = UnownedColor;
        GodText55.color = UnownedColor;
        GodText56.color = UnownedColor;
        GodText57.color = UnownedColor;
        GodText58.color = UnownedColor;
        GodText59.color = UnownedColor;
        GodText60.color = UnownedColor;
        GodText61.color = UnownedColor;
        GodText62.color = UnownedColor;
        GodText63.color = UnownedColor;
        GodText64.color = UnownedColor;
        GodText65.color = UnownedColor;
        GodText66.color = UnownedColor;

        // Naming All Texts
        GodText01.text = "Unowned God";
        GodText02.text = "Unowned God";
        GodText03.text = "Unowned God";
        GodText04.text = "Unowned God";
        GodText05.text = "Unowned God";
        GodText06.text = "Unowned God";
        GodText07.text = "Unowned God";
        GodText08.text = "Unowned God";
        GodText09.text = "Unowned God";
        GodText10.text = "Unowned God";
        GodText11.text = "Unowned God";
        GodText12.text = "Unowned God";
        GodText13.text = "Unowned God";
        GodText14.text = "Unowned God";
        GodText15.text = "Unowned God";
        GodText16.text = "Unowned God";
        GodText17.text = "Unowned God";
        GodText18.text = "Unowned God";
        GodText19.text = "Unowned God";
        GodText20.text = "Unowned God";
        GodText21.text = "Unowned God";
        GodText22.text = "Unowned God";
        GodText23.text = "Unowned God";
        GodText24.text = "Unowned God";
        GodText25.text = "Unowned God";
        GodText26.text = "Unowned God";
        GodText27.text = "Unowned God";
        GodText28.text = "Unowned God";
        GodText29.text = "Unowned God";
        GodText30.text = "Unowned God";
        GodText31.text = "Unowned God";
        GodText32.text = "Unowned God";
        GodText33.text = "Unowned God";
        GodText34.text = "Unowned God";
        GodText35.text = "Unowned God";
        GodText36.text = "Unowned God";
        GodText37.text = "Unowned God";
        GodText38.text = "Unowned God";
        GodText39.text = "Unowned God";
        GodText40.text = "Unowned God";
        GodText41.text = "Unowned God";
        GodText42.text = "Unowned God";
        GodText43.text = "Unowned God";
        GodText44.text = "Unowned God";
        GodText45.text = "Unowned God";
        GodText46.text = "Unowned God";
        GodText47.text = "Unowned God";
        GodText48.text = "Unowned God";
        GodText49.text = "Unowned God";
        GodText50.text = "Unowned God";
        GodText51.text = "Unowned God";
        GodText52.text = "Unowned God";
        GodText53.text = "Unowned God";
        GodText54.text = "Unowned God";
        GodText55.text = "Unowned God";
        GodText56.text = "Unowned God";
        GodText57.text = "Unowned God";
        GodText58.text = "Unowned God";
        GodText59.text = "Unowned God";
        GodText60.text = "Unowned God";
        GodText61.text = "Unowned God";
        GodText62.text = "Unowned God";
        GodText63.text = "Unowned God";
        GodText64.text = "Unowned God";
        GodText65.text = "Unowned God";
        GodText66.text = "Unowned God";
    }

    public void DownloadOwnedGods() {
        if (OwnedGodsList.Count >= 1) {
            GodOn01.enabled = true;
            GodText01.color = OwnedColor;
            GodText01.text = CardDatabase.CardName[OwnedGodsList[0]];
        }

        if (OwnedGodsList.Count >= 2) {
            GodOn02.enabled = true;
            GodText02.color = OwnedColor;
            GodText02.text = CardDatabase.CardName[OwnedGodsList[1]];
        }

        if (OwnedGodsList.Count >= 3) {
            GodOn03.enabled = true;
            GodText03.color = OwnedColor;
            GodText03.text = CardDatabase.CardName[OwnedGodsList[2]];
        }

        if (OwnedGodsList.Count >= 4) {
            GodOn04.enabled = true;
            GodText04.color = OwnedColor;
            GodText04.text = CardDatabase.CardName[OwnedGodsList[3]];
        }

        if (OwnedGodsList.Count >= 5) {
            GodOn05.enabled = true;
            GodText05.color = OwnedColor;
            GodText05.text = CardDatabase.CardName[OwnedGodsList[4]];
        }

        if (OwnedGodsList.Count >= 6) {
            GodOn06.enabled = true;
            GodText06.color = OwnedColor;
            GodText06.text = CardDatabase.CardName[OwnedGodsList[5]];
        }

        if (OwnedGodsList.Count >= 7) {
            GodOn07.enabled = true;
            GodText07.color = OwnedColor;
            GodText07.text = CardDatabase.CardName[OwnedGodsList[6]];
        }

        if (OwnedGodsList.Count >= 8) {
            GodOn08.enabled = true;
            GodText08.color = OwnedColor;
            GodText08.text = CardDatabase.CardName[OwnedGodsList[7]];
        }

        if (OwnedGodsList.Count >= 9) {
            GodOn09.enabled = true;
            GodText09.color = OwnedColor;
            GodText09.text = CardDatabase.CardName[OwnedGodsList[8]];
        }

        if (OwnedGodsList.Count >= 10) {
            GodOn10.enabled = true;
            GodText10.color = OwnedColor;
            GodText10.text = CardDatabase.CardName[OwnedGodsList[9]];
        }

        if (OwnedGodsList.Count >= 11) {
            GodOn11.enabled = true;
            GodText11.color = OwnedColor;
            GodText11.text = CardDatabase.CardName[OwnedGodsList[10]];
        }

        if (OwnedGodsList.Count >= 12) {
            GodOn12.enabled = true;
            GodText12.color = OwnedColor;
            GodText12.text = CardDatabase.CardName[OwnedGodsList[11]];
        }

        if (OwnedGodsList.Count >= 13) {
            GodOn13.enabled = true;
            GodText13.color = OwnedColor;
            GodText13.text = CardDatabase.CardName[OwnedGodsList[12]];
        }

        if (OwnedGodsList.Count >= 14) {
            GodOn14.enabled = true;
            GodText14.color = OwnedColor;
            GodText14.text = CardDatabase.CardName[OwnedGodsList[13]];
        }

        if (OwnedGodsList.Count >= 15) {
            GodOn15.enabled = true;
            GodText15.color = OwnedColor;
            GodText15.text = CardDatabase.CardName[OwnedGodsList[14]];
        }

        if (OwnedGodsList.Count >= 16) {
            GodOn16.enabled = true;
            GodText16.color = OwnedColor;
            GodText16.text = CardDatabase.CardName[OwnedGodsList[15]];
        }

        if (OwnedGodsList.Count >= 17) {
            GodOn17.enabled = true;
            GodText17.color = OwnedColor;
            GodText17.text = CardDatabase.CardName[OwnedGodsList[16]];
        }

        if (OwnedGodsList.Count >= 18) {
            GodOn18.enabled = true;
            GodText18.color = OwnedColor;
            GodText18.text = CardDatabase.CardName[OwnedGodsList[17]];
        }

        if (OwnedGodsList.Count >= 19) {
            GodOn19.enabled = true;
            GodText19.color = OwnedColor;
            GodText19.text = CardDatabase.CardName[OwnedGodsList[18]];
        }

        if (OwnedGodsList.Count >= 20) {
            GodOn20.enabled = true;
            GodText20.color = OwnedColor;
            GodText20.text = CardDatabase.CardName[OwnedGodsList[19]];
        }

        if (OwnedGodsList.Count >= 21) {
            GodOn21.enabled = true;
            GodText21.color = OwnedColor;
            GodText21.text = CardDatabase.CardName[OwnedGodsList[20]];
        }

        if (OwnedGodsList.Count >= 22) {
            GodOn22.enabled = true;
            GodText22.color = OwnedColor;
            GodText22.text = CardDatabase.CardName[OwnedGodsList[21]];
        }

        if (OwnedGodsList.Count >= 23) {
            GodOn23.enabled = true;
            GodText23.color = OwnedColor;
            GodText23.text = CardDatabase.CardName[OwnedGodsList[22]];
        }

        if (OwnedGodsList.Count >= 24) {
            GodOn24.enabled = true;
            GodText24.color = OwnedColor;
            GodText24.text = CardDatabase.CardName[OwnedGodsList[23]];
        }

        if (OwnedGodsList.Count >= 25) {
            GodOn25.enabled = true;
            GodText25.color = OwnedColor;
            GodText25.text = CardDatabase.CardName[OwnedGodsList[24]];
        }

        if (OwnedGodsList.Count >= 26) {
            GodOn26.enabled = true;
            GodText26.color = OwnedColor;
            GodText26.text = CardDatabase.CardName[OwnedGodsList[25]];
        }

        if (OwnedGodsList.Count >= 27) {
            GodOn27.enabled = true;
            GodText27.color = OwnedColor;
            GodText27.text = CardDatabase.CardName[OwnedGodsList[26]];
        }

        if (OwnedGodsList.Count >= 28) {
            GodOn28.enabled = true;
            GodText28.color = OwnedColor;
            GodText28.text = CardDatabase.CardName[OwnedGodsList[27]];
        }

        if (OwnedGodsList.Count >= 29) {
            GodOn29.enabled = true;
            GodText29.color = OwnedColor;
            GodText29.text = CardDatabase.CardName[OwnedGodsList[28]];
        }

        if (OwnedGodsList.Count >= 30) {
            GodOn30.enabled = true;
            GodText30.color = OwnedColor;
            GodText30.text = CardDatabase.CardName[OwnedGodsList[29]];
        }

        if (OwnedGodsList.Count >= 31) {
            GodOn31.enabled = true;
            GodText31.color = OwnedColor;
            GodText31.text = CardDatabase.CardName[OwnedGodsList[30]];
        }

        if (OwnedGodsList.Count >= 32) {
            GodOn32.enabled = true;
            GodText32.color = OwnedColor;
            GodText32.text = CardDatabase.CardName[OwnedGodsList[31]];
        }

        if (OwnedGodsList.Count >= 33) {
            GodOn33.enabled = true;
            GodText33.color = OwnedColor;
            GodText33.text = CardDatabase.CardName[OwnedGodsList[32]];
        }

        if (OwnedGodsList.Count >= 34) {
            GodOn34.enabled = true;
            GodText34.color = OwnedColor;
            GodText34.text = CardDatabase.CardName[OwnedGodsList[33]];
        }

        if (OwnedGodsList.Count >= 35) {
            GodOn35.enabled = true;
            GodText35.color = OwnedColor;
            GodText35.text = CardDatabase.CardName[OwnedGodsList[34]];
        }

        if (OwnedGodsList.Count >= 36) {
            GodOn36.enabled = true;
            GodText36.color = OwnedColor;
            GodText36.text = CardDatabase.CardName[OwnedGodsList[35]];
        }

        if (OwnedGodsList.Count >= 37) {
            GodOn37.enabled = true;
            GodText37.color = OwnedColor;
            GodText37.text = CardDatabase.CardName[OwnedGodsList[36]];
        }

        if (OwnedGodsList.Count >= 38) {
            GodOn38.enabled = true;
            GodText38.color = OwnedColor;
            GodText38.text = CardDatabase.CardName[OwnedGodsList[37]];
        }

        if (OwnedGodsList.Count >= 39) {
            GodOn39.enabled = true;
            GodText39.color = OwnedColor;
            GodText39.text = CardDatabase.CardName[OwnedGodsList[38]];
        }

        if (OwnedGodsList.Count >= 40) {
            GodOn40.enabled = true;
            GodText40.color = OwnedColor;
            GodText40.text = CardDatabase.CardName[OwnedGodsList[39]];
        }

        if (OwnedGodsList.Count >= 41) {
            GodOn41.enabled = true;
            GodText41.color = OwnedColor;
            GodText41.text = CardDatabase.CardName[OwnedGodsList[40]];
        }

        if (OwnedGodsList.Count >= 42) {
            GodOn42.enabled = true;
            GodText42.color = OwnedColor;
            GodText42.text = CardDatabase.CardName[OwnedGodsList[41]];
        }

        if (OwnedGodsList.Count >= 43) {
            GodOn43.enabled = true;
            GodText43.color = OwnedColor;
            GodText43.text = CardDatabase.CardName[OwnedGodsList[42]];
        }

        if (OwnedGodsList.Count >= 44) {
            GodOn44.enabled = true;
            GodText44.color = OwnedColor;
            GodText44.text = CardDatabase.CardName[OwnedGodsList[43]];
        }

        if (OwnedGodsList.Count >= 45) {
            GodOn45.enabled = true;
            GodText45.color = OwnedColor;
            GodText45.text = CardDatabase.CardName[OwnedGodsList[44]];
        }

        if (OwnedGodsList.Count >= 46) {
            GodOn46.enabled = true;
            GodText46.color = OwnedColor;
            GodText46.text = CardDatabase.CardName[OwnedGodsList[45]];
        }

        if (OwnedGodsList.Count >= 47) {
            GodOn47.enabled = true;
            GodText47.color = OwnedColor;
            GodText47.text = CardDatabase.CardName[OwnedGodsList[46]];
        }

        if (OwnedGodsList.Count >= 48) {
            GodOn48.enabled = true;
            GodText48.color = OwnedColor;
            GodText48.text = CardDatabase.CardName[OwnedGodsList[47]];
        }

        if (OwnedGodsList.Count >= 49) {
            GodOn49.enabled = true;
            GodText49.color = OwnedColor;
            GodText49.text = CardDatabase.CardName[OwnedGodsList[48]];
        }

        if (OwnedGodsList.Count >= 50) {
            GodOn50.enabled = true;
            GodText50.color = OwnedColor;
            GodText50.text = CardDatabase.CardName[OwnedGodsList[49]];
        }

        if (OwnedGodsList.Count >= 51) {
            GodOn51.enabled = true;
            GodText51.color = OwnedColor;
            GodText51.text = CardDatabase.CardName[OwnedGodsList[50]];
        }

        if (OwnedGodsList.Count >= 52) {
            GodOn52.enabled = true;
            GodText52.color = OwnedColor;
            GodText52.text = CardDatabase.CardName[OwnedGodsList[51]];
        }

        if (OwnedGodsList.Count >= 53) {
            GodOn53.enabled = true;
            GodText53.color = OwnedColor;
            GodText53.text = CardDatabase.CardName[OwnedGodsList[52]];
        }

        if (OwnedGodsList.Count >= 54) {
            GodOn54.enabled = true;
            GodText54.color = OwnedColor;
            GodText54.text = CardDatabase.CardName[OwnedGodsList[53]];
        }

        if (OwnedGodsList.Count >= 55) {
            GodOn55.enabled = true;
            GodText55.color = OwnedColor;
            GodText55.text = CardDatabase.CardName[OwnedGodsList[54]];
        }

        if (OwnedGodsList.Count >= 56) {
            GodOn56.enabled = true;
            GodText56.color = OwnedColor;
            GodText56.text = CardDatabase.CardName[OwnedGodsList[55]];
        }

        if (OwnedGodsList.Count >= 57) {
            GodOn57.enabled = true;
            GodText57.color = OwnedColor;
            GodText57.text = CardDatabase.CardName[OwnedGodsList[56]];
        }

        if (OwnedGodsList.Count >= 58) {
            GodOn58.enabled = true;
            GodText58.color = OwnedColor;
            GodText58.text = CardDatabase.CardName[OwnedGodsList[57]];
        }

        if (OwnedGodsList.Count >= 59) {
            GodOn59.enabled = true;
            GodText59.color = OwnedColor;
            GodText59.text = CardDatabase.CardName[OwnedGodsList[58]];
        }

        if (OwnedGodsList.Count >= 60) {
            GodOn60.enabled = true;
            GodText60.color = OwnedColor;
            GodText60.text = CardDatabase.CardName[OwnedGodsList[59]];
        }

        if (OwnedGodsList.Count >= 61) {
            GodOn61.enabled = true;
            GodText61.color = OwnedColor;
            GodText61.text = CardDatabase.CardName[OwnedGodsList[60]];
        }

        if (OwnedGodsList.Count >= 62) {
            GodOn62.enabled = true;
            GodText62.color = OwnedColor;
            GodText62.text = CardDatabase.CardName[OwnedGodsList[61]];
        }

        if (OwnedGodsList.Count >= 63) {
            GodOn63.enabled = true;
            GodText63.color = OwnedColor;
            GodText63.text = CardDatabase.CardName[OwnedGodsList[62]];
        }

        if (OwnedGodsList.Count >= 64) {
            GodOn64.enabled = true;
            GodText64.color = OwnedColor;
            GodText64.text = CardDatabase.CardName[OwnedGodsList[63]];
        }

        if (OwnedGodsList.Count >= 65) {
            GodOn65.enabled = true;
            GodText65.color = OwnedColor;
            GodText65.text = CardDatabase.CardName[OwnedGodsList[64]];
        }

        if (OwnedGodsList.Count >= 66) {
            GodOn66.enabled = true;
            GodText66.color = OwnedColor;
            GodText66.text = CardDatabase.CardName[OwnedGodsList[65]];
        }
    }

    public void SetInitialSprites() {
        // Gods Items
        GodIntOn01 = 0;
        GodIntOn02 = 0;
        GodIntOn03 = 0;
        GodIntOn04 = 0;
        GodIntOn05 = 0;
        GodIntOn06 = 0;
        GodIntOn07 = 0;
        GodIntOn08 = 0;
        GodIntOn09 = 0;
        GodIntOn10 = 0;
        GodIntOn11 = 0;
        GodIntOn12 = 0;
        GodIntOn13 = 0;
        GodIntOn14 = 0;
        GodIntOn15 = 0;
        GodIntOn16 = 0;
        GodIntOn17 = 0;
        GodIntOn18 = 0;
        GodIntOn19 = 0;
        GodIntOn20 = 0;
        GodIntOn21 = 0;
        GodIntOn22 = 0;
        GodIntOn23 = 0;
        GodIntOn24 = 0;
        GodIntOn25 = 0;
        GodIntOn26 = 0;
        GodIntOn27 = 0;
        GodIntOn28 = 0;
        GodIntOn29 = 0;
        GodIntOn30 = 0;
        GodIntOn31 = 0;
        GodIntOn32 = 0;
        GodIntOn33 = 0;
        GodIntOn34 = 0;
        GodIntOn35 = 0;
        GodIntOn36 = 0;
        GodIntOn37 = 0;
        GodIntOn38 = 0;
        GodIntOn39 = 0;
        GodIntOn40 = 0;
        GodIntOn41 = 0;
        GodIntOn42 = 0;
        GodIntOn43 = 0;
        GodIntOn44 = 0;
        GodIntOn45 = 0;
        GodIntOn46 = 0;
        GodIntOn47 = 0;
        GodIntOn48 = 0;
        GodIntOn49 = 0;
        GodIntOn50 = 0;
        GodIntOn51 = 0;
        GodIntOn52 = 0;
        GodIntOn53 = 0;
        GodIntOn54 = 0;
        GodIntOn55 = 0;
        GodIntOn56 = 0;
        GodIntOn57 = 0;
        GodIntOn58 = 0;
        GodIntOn59 = 0;
        GodIntOn60 = 0;
        GodIntOn61 = 0;
        GodIntOn62 = 0;
        GodIntOn63 = 0;
        GodIntOn64 = 0;
        GodIntOn65 = 0;
        GodIntOn66 = 0;
    }

    public void SettingSprites() {
        // GodOn01
        if (GodIntOn01 == 0) {
            GodOn01.sprite = SelectSprite;
        }

        else if (GodIntOn01 >= 1) {
            GodOn01.sprite = SelectedSprite;
        }

        // GodOn02
        if (GodIntOn02 == 0) {
            GodOn02.sprite = SelectSprite;
        }

        else if (GodIntOn02 >= 1) {
            GodOn02.sprite = SelectedSprite;
        }

        // GodOn03
        if (GodIntOn03 == 0) {
            GodOn03.sprite = SelectSprite;
        }

        else if (GodIntOn03 >= 1) {
            GodOn03.sprite = SelectedSprite;
        }

        // GodOn04
        if (GodIntOn04 == 0) {
            GodOn04.sprite = SelectSprite;
        }

        else if (GodIntOn04 >= 1) {
            GodOn04.sprite = SelectedSprite;
        }

        // GodOn05
        if (GodIntOn05 == 0) {
            GodOn05.sprite = SelectSprite;
        }

        else if (GodIntOn05 >= 1) {
            GodOn05.sprite = SelectedSprite;
        }

        // GodOn06
        if (GodIntOn06 == 0) {
            GodOn06.sprite = SelectSprite;
        }

        else if (GodIntOn06 >= 1) {
            GodOn06.sprite = SelectedSprite;
        }

        // GodOn07
        if (GodIntOn07 == 0) {
            GodOn07.sprite = SelectSprite;
        }

        else if (GodIntOn07 >= 1) {
            GodOn07.sprite = SelectedSprite;
        }

        // GodOn08
        if (GodIntOn08 == 0) {
            GodOn08.sprite = SelectSprite;
        }

        else if (GodIntOn08 >= 1) {
            GodOn08.sprite = SelectedSprite;
        }

        // GodOn09
        if (GodIntOn09 == 0) {
            GodOn09.sprite = SelectSprite;
        }

        else if (GodIntOn09 >= 1) {
            GodOn09.sprite = SelectedSprite;
        }

        // GodOn10
        if (GodIntOn10 == 0) {
            GodOn10.sprite = SelectSprite;
        }

        else if (GodIntOn10 >= 1) {
            GodOn10.sprite = SelectedSprite;
        }

        // GodOn11
        if (GodIntOn11 == 0) {
            GodOn11.sprite = SelectSprite;
        }

        else if (GodIntOn11 >= 1) {
            GodOn11.sprite = SelectedSprite;
        }

        // GodOn12
        if (GodIntOn12 == 0) {
            GodOn12.sprite = SelectSprite;
        }

        else if (GodIntOn12 >= 1) {
            GodOn12.sprite = SelectedSprite;
        }

        // GodOn13
        if (GodIntOn13 == 0) {
            GodOn13.sprite = SelectSprite;
        }

        else if (GodIntOn13 >= 1) {
            GodOn13.sprite = SelectedSprite;
        }

        // GodOn14
        if (GodIntOn14 == 0) {
            GodOn14.sprite = SelectSprite;
        }

        else if (GodIntOn14 >= 1) {
            GodOn14.sprite = SelectedSprite;
        }

        // GodOn15
        if (GodIntOn15 == 0) {
            GodOn15.sprite = SelectSprite;
        }

        else if (GodIntOn15 >= 1) {
            GodOn15.sprite = SelectedSprite;
        }

        // GodOn16
        if (GodIntOn16 == 0) {
            GodOn16.sprite = SelectSprite;
        }

        else if (GodIntOn16 >= 1) {
            GodOn16.sprite = SelectedSprite;
        }

        // GodOn17
        if (GodIntOn17 == 0) {
            GodOn17.sprite = SelectSprite;
        }

        else if (GodIntOn17 >= 1) {
            GodOn17.sprite = SelectedSprite;
        }

        // GodOn18
        if (GodIntOn18 == 0) {
            GodOn18.sprite = SelectSprite;
        }

        else if (GodIntOn18 >= 1) {
            GodOn18.sprite = SelectedSprite;
        }

        // GodOn19
        if (GodIntOn19 == 0) {
            GodOn19.sprite = SelectSprite;
        }

        else if (GodIntOn19 >= 1) {
            GodOn19.sprite = SelectedSprite;
        }

        // GodOn20
        if (GodIntOn20 == 0) {
            GodOn20.sprite = SelectSprite;
        }

        else if (GodIntOn20 >= 1) {
            GodOn20.sprite = SelectedSprite;
        }

        // GodOn21
        if (GodIntOn21 == 0) {
            GodOn21.sprite = SelectSprite;
        }

        else if (GodIntOn21 >= 1) {
            GodOn21.sprite = SelectedSprite;
        }

        // GodOn22
        if (GodIntOn22 == 0) {
            GodOn22.sprite = SelectSprite;
        }

        else if (GodIntOn22 >= 1) {
            GodOn22.sprite = SelectedSprite;
        }

        // GodOn23
        if (GodIntOn23 == 0) {
            GodOn23.sprite = SelectSprite;
        }

        else if (GodIntOn23 >= 1) {
            GodOn23.sprite = SelectedSprite;
        }

        // GodOn24
        if (GodIntOn24 == 0) {
            GodOn24.sprite = SelectSprite;
        }

        else if (GodIntOn24 >= 1) {
            GodOn24.sprite = SelectedSprite;
        }

        // GodOn25
        if (GodIntOn25 == 0) {
            GodOn25.sprite = SelectSprite;
        }

        else if (GodIntOn25 >= 1) {
            GodOn25.sprite = SelectedSprite;
        }

        // GodOn26
        if (GodIntOn26 == 0) {
            GodOn26.sprite = SelectSprite;
        }

        else if (GodIntOn26 >= 1) {
            GodOn26.sprite = SelectedSprite;
        }

        // GodOn27
        if (GodIntOn27 == 0) {
            GodOn27.sprite = SelectSprite;
        }

        else if (GodIntOn27 >= 1) {
            GodOn27.sprite = SelectedSprite;
        }

        // GodOn28
        if (GodIntOn28 == 0) {
            GodOn28.sprite = SelectSprite;
        }

        else if (GodIntOn28 >= 1) {
            GodOn28.sprite = SelectedSprite;
        }

        // GodOn29
        if (GodIntOn29 == 0) {
            GodOn29.sprite = SelectSprite;
        }

        else if (GodIntOn29 >= 1) {
            GodOn29.sprite = SelectedSprite;
        }

        // GodOn30
        if (GodIntOn30 == 0) {
            GodOn30.sprite = SelectSprite;
        }

        else if (GodIntOn30 >= 1) {
            GodOn30.sprite = SelectedSprite;
        }

        // GodOn31
        if (GodIntOn31 == 0) {
            GodOn31.sprite = SelectSprite;
        }

        else if (GodIntOn31 >= 1) {
            GodOn31.sprite = SelectedSprite;
        }

        // GodOn32
        if (GodIntOn32 == 0) {
            GodOn32.sprite = SelectSprite;
        }

        else if (GodIntOn32 >= 1) {
            GodOn32.sprite = SelectedSprite;
        }

        // GodOn33
        if (GodIntOn33 == 0) {
            GodOn33.sprite = SelectSprite;
        }

        else if (GodIntOn33 >= 1) {
            GodOn33.sprite = SelectedSprite;
        }

        // GodOn34
        if (GodIntOn34 == 0) {
            GodOn34.sprite = SelectSprite;
        }

        else if (GodIntOn34 >= 1) {
            GodOn34.sprite = SelectedSprite;
        }

        // GodOn35
        if (GodIntOn35 == 0) {
            GodOn35.sprite = SelectSprite;
        }

        else if (GodIntOn35 >= 1) {
            GodOn35.sprite = SelectedSprite;
        }

        // GodOn36
        if (GodIntOn36 == 0) {
            GodOn36.sprite = SelectSprite;
        }

        else if (GodIntOn36 >= 1) {
            GodOn36.sprite = SelectedSprite;
        }

        // GodOn37
        if (GodIntOn37 == 0) {
            GodOn37.sprite = SelectSprite;
        }

        else if (GodIntOn37 >= 1) {
            GodOn37.sprite = SelectedSprite;
        }

        // GodOn38
        if (GodIntOn38 == 0) {
            GodOn38.sprite = SelectSprite;
        }

        else if (GodIntOn38 >= 1) {
            GodOn38.sprite = SelectedSprite;
        }

        // GodOn39
        if (GodIntOn39 == 0) {
            GodOn39.sprite = SelectSprite;
        }

        else if (GodIntOn39 >= 1) {
            GodOn39.sprite = SelectedSprite;
        }

        // GodOn40
        if (GodIntOn40 == 0) {
            GodOn40.sprite = SelectSprite;
        }

        else if (GodIntOn40 >= 1) {
            GodOn40.sprite = SelectedSprite;
        }

        // GodOn41
        if (GodIntOn41 == 0) {
            GodOn41.sprite = SelectSprite;
        }

        else if (GodIntOn41 >= 1) {
            GodOn41.sprite = SelectedSprite;
        }

        // GodOn42
        if (GodIntOn42 == 0) {
            GodOn42.sprite = SelectSprite;
        }

        else if (GodIntOn42 >= 1) {
            GodOn42.sprite = SelectedSprite;
        }

        // GodOn43
        if (GodIntOn43 == 0) {
            GodOn43.sprite = SelectSprite;
        }

        else if (GodIntOn43 >= 1) {
            GodOn43.sprite = SelectedSprite;
        }

        // GodOn44
        if (GodIntOn44 == 0) {
            GodOn44.sprite = SelectSprite;
        }

        else if (GodIntOn44 >= 1) {
            GodOn44.sprite = SelectedSprite;
        }

        // GodOn45
        if (GodIntOn45 == 0) {
            GodOn45.sprite = SelectSprite;
        }

        else if (GodIntOn45 >= 1) {
            GodOn45.sprite = SelectedSprite;
        }

        // GodOn46
        if (GodIntOn46 == 0) {
            GodOn46.sprite = SelectSprite;
        }

        else if (GodIntOn46 >= 1) {
            GodOn46.sprite = SelectedSprite;
        }

        // GodOn47
        if (GodIntOn47 == 0) {
            GodOn47.sprite = SelectSprite;
        }

        else if (GodIntOn47 >= 1) {
            GodOn47.sprite = SelectedSprite;
        }

        // GodOn48
        if (GodIntOn48 == 0) {
            GodOn48.sprite = SelectSprite;
        }

        else if (GodIntOn48 >= 1) {
            GodOn48.sprite = SelectedSprite;
        }

        // GodOn49
        if (GodIntOn49 == 0) {
            GodOn49.sprite = SelectSprite;
        }

        else if (GodIntOn49 >= 1) {
            GodOn49.sprite = SelectedSprite;
        }

        // GodOn50
        if (GodIntOn50 == 0) {
            GodOn50.sprite = SelectSprite;
        }

        else if (GodIntOn50 >= 1) {
            GodOn50.sprite = SelectedSprite;
        }

        // GodOn51
        if (GodIntOn51 == 0) {
            GodOn51.sprite = SelectSprite;
        }

        else if (GodIntOn51 >= 1) {
            GodOn51.sprite = SelectedSprite;
        }

        // GodOn52
        if (GodIntOn52 == 0) {
            GodOn52.sprite = SelectSprite;
        }

        else if (GodIntOn52 >= 1) {
            GodOn52.sprite = SelectedSprite;
        }

        // GodOn53
        if (GodIntOn53 == 0) {
            GodOn53.sprite = SelectSprite;
        }

        else if (GodIntOn53 >= 1) {
            GodOn53.sprite = SelectedSprite;
        }

        // GodOn54
        if (GodIntOn54 == 0) {
            GodOn54.sprite = SelectSprite;
        }

        else if (GodIntOn54 >= 1) {
            GodOn54.sprite = SelectedSprite;
        }

        // GodOn55
        if (GodIntOn55 == 0) {
            GodOn55.sprite = SelectSprite;
        }

        else if (GodIntOn55 >= 1) {
            GodOn55.sprite = SelectedSprite;
        }

        // GodOn56
        if (GodIntOn56 == 0) {
            GodOn56.sprite = SelectSprite;
        }

        else if (GodIntOn56 >= 1) {
            GodOn56.sprite = SelectedSprite;
        }

        // GodOn57
        if (GodIntOn57 == 0) {
            GodOn57.sprite = SelectSprite;
        }

        else if (GodIntOn57 >= 1) {
            GodOn57.sprite = SelectedSprite;
        }

        // GodOn58
        if (GodIntOn58 == 0) {
            GodOn58.sprite = SelectSprite;
        }

        else if (GodIntOn58 >= 1) {
            GodOn58.sprite = SelectedSprite;
        }

        // GodOn59
        if (GodIntOn59 == 0) {
            GodOn59.sprite = SelectSprite;
        }

        else if (GodIntOn59 >= 1) {
            GodOn59.sprite = SelectedSprite;
        }

        // GodOn60
        if (GodIntOn60 == 0) {
            GodOn60.sprite = SelectSprite;
        }

        else if (GodIntOn60 >= 1) {
            GodOn60.sprite = SelectedSprite;
        }

        // GodOn61
        if (GodIntOn61 == 0) {
            GodOn61.sprite = SelectSprite;
        }

        else if (GodIntOn61 >= 1) {
            GodOn61.sprite = SelectedSprite;
        }

        // GodOn62
        if (GodIntOn62 == 0) {
            GodOn62.sprite = SelectSprite;
        }

        else if (GodIntOn62 >= 1) {
            GodOn62.sprite = SelectedSprite;
        }

        // GodOn63
        if (GodIntOn63 == 0) {
            GodOn63.sprite = SelectSprite;
        }

        else if (GodIntOn63 >= 1) {
            GodOn63.sprite = SelectedSprite;
        }

        // GodOn64
        if (GodIntOn64 == 0) {
            GodOn64.sprite = SelectSprite;
        }

        else if (GodIntOn64 >= 1) {
            GodOn64.sprite = SelectedSprite;
        }

        // GodOn65
        if (GodIntOn65 == 0) {
            GodOn65.sprite = SelectSprite;
        }

        else if (GodIntOn65 >= 1) {
            GodOn65.sprite = SelectedSprite;
        }

        // GodOn66
        if (GodIntOn66 == 0) {
            GodOn66.sprite = SelectSprite;
        }

        else if (GodIntOn66 >= 1) {
            GodOn66.sprite = SelectedSprite;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}