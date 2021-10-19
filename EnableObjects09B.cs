using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects09B : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Main Items
    public Image BackgroundImage;
    public Text TitleText;
    public Text ActionText;

    // Deck Items
    public Image PickDeckScroll;
    public Image PickDeckView;
    public Text SelectedDeckText;
    public Image BeginButton;
    public Text DeckText01;
    public Image DeckOn01;
    public Text DeckText02;
    public Image DeckOn02;
    public Text DeckText03;
    public Image DeckOn03;
    public Text DeckText04;
    public Image DeckOn04;
    public Text DeckText05;
    public Image DeckOn05;
    public Text DeckText06;
    public Image DeckOn06;
    public Text DeckText07;
    public Image DeckOn07;
    public Text DeckText08;
    public Image DeckOn08;
    public Text DeckText09;
    public Image DeckOn09;
    public Text DeckText10;
    public Image DeckOn10;
    public Text DeckText11;
    public Image DeckOn11;
    public Text DeckText12;
    public Image DeckOn12;
    public Text DeckText13;
    public Image DeckOn13;
    public Text DeckText14;
    public Image DeckOn14;
    public Text DeckText15;
    public Image DeckOn15;
    public Text DeckText16;
    public Image DeckOn16;
    public Text DeckText17;
    public Image DeckOn17;
    public Text DeckText18;
    public Image DeckOn18;
    public Text DeckText19;
    public Image DeckOn19;
    public Text DeckText20;
    public Image DeckOn20;
    public Text DeckText21;
    public Image DeckOn21;
    public Text DeckText22;
    public Image DeckOn22;
    public Text DeckText23;
    public Image DeckOn23;
    public Text DeckText24;
    public Image DeckOn24;
    public Text DeckText25;
    public Image DeckOn25;
    public Text DeckText26;
    public Image DeckOn26;
    public Text DeckText27;
    public Image DeckOn27;
    public Text DeckText28;
    public Image DeckOn28;
    public Text DeckText29;
    public Image DeckOn29;
    public Text DeckText30;
    public Image DeckOn30;
    public Text DeckText31;
    public Image DeckOn31;
    public Text DeckText32;
    public Image DeckOn32;
    public Text DeckText33;
    public Image DeckOn33;
    public Text DeckText34;
    public Image DeckOn34;
    public Text DeckText35;
    public Image DeckOn35;
    public Text DeckText36;
    public Image DeckOn36;
    public Text DeckText37;
    public Image DeckOn37;
    public Text DeckText38;
    public Image DeckOn38;
    public Text DeckText39;
    public Image DeckOn39;
    public Text DeckText40;
    public Image DeckOn40;
    public Text DeckText41;
    public Image DeckOn41;
    public Text DeckText42;
    public Image DeckOn42;
    public Text DeckText43;
    public Image DeckOn43;
    public Text DeckText44;
    public Image DeckOn44;
    public Text DeckText45;
    public Image DeckOn45;
    public Text DeckText46;
    public Image DeckOn46;
    public Text DeckText47;
    public Image DeckOn47;
    public Text DeckText48;
    public Image DeckOn48;
    public Text DeckText49;
    public Image DeckOn49;
    public Text DeckText50;
    public Image DeckOn50;
    public Text DeckText51;
    public Image DeckOn51;
    public Text DeckText52;
    public Image DeckOn52;
    public Text DeckText53;
    public Image DeckOn53;
    public Text DeckText54;
    public Image DeckOn54;
    public Text DeckText55;
    public Image DeckOn55;
    public Text DeckText56;
    public Image DeckOn56;
    public Text DeckText57;
    public Image DeckOn57;
    public Text DeckText58;
    public Image DeckOn58;
    public Text DeckText59;
    public Image DeckOn59;
    public Text DeckText60;
    public Image DeckOn60;
    public Text DeckText61;
    public Image DeckOn61;
    public Text DeckText62;
    public Image DeckOn62;
    public Text DeckText63;
    public Image DeckOn63;
    public Text DeckText64;
    public Image DeckOn64;
    public Text DeckText65;
    public Image DeckOn65;
    public Text DeckText66;
    public Image DeckOn66;
    public Text DeckText67;
    public Image DeckOn67;
    public Text DeckText68;
    public Image DeckOn68;

    // Sprites
    public Sprite SelectedSprite;
    public Sprite SelectSprite;
    public Sprite AddSprite;

// -------------------- PRIVATE VARIABLES --------------------
    Color OwnedColor = new Color(1.0f, 1.0f, 1.0f);
    Color UnownedColor = new Color(0.5f, 0.5f, 0.5f);

// -------------------- STATIC VARIABLES --------------------
    public static int GamePlayPanelInt;
    public static List<int> OwnedDeckList = new List<int>();

    // Deck Items
    public static int DeckIntOn01;
    public static int DeckIntOn02;
    public static int DeckIntOn03;
    public static int DeckIntOn04;
    public static int DeckIntOn05;
    public static int DeckIntOn06;
    public static int DeckIntOn07;
    public static int DeckIntOn08;
    public static int DeckIntOn09;
    public static int DeckIntOn10;
    public static int DeckIntOn11;
    public static int DeckIntOn12;
    public static int DeckIntOn13;
    public static int DeckIntOn14;
    public static int DeckIntOn15;
    public static int DeckIntOn16;
    public static int DeckIntOn17;
    public static int DeckIntOn18;
    public static int DeckIntOn19;
    public static int DeckIntOn20;
    public static int DeckIntOn21;
    public static int DeckIntOn22;
    public static int DeckIntOn23;
    public static int DeckIntOn24;
    public static int DeckIntOn25;
    public static int DeckIntOn26;
    public static int DeckIntOn27;
    public static int DeckIntOn28;
    public static int DeckIntOn29;
    public static int DeckIntOn30;
    public static int DeckIntOn31;
    public static int DeckIntOn32;
    public static int DeckIntOn33;
    public static int DeckIntOn34;
    public static int DeckIntOn35;
    public static int DeckIntOn36;
    public static int DeckIntOn37;
    public static int DeckIntOn38;
    public static int DeckIntOn39;
    public static int DeckIntOn40;
    public static int DeckIntOn41;
    public static int DeckIntOn42;
    public static int DeckIntOn43;
    public static int DeckIntOn44;
    public static int DeckIntOn45;
    public static int DeckIntOn46;
    public static int DeckIntOn47;
    public static int DeckIntOn48;
    public static int DeckIntOn49;
    public static int DeckIntOn50;
    public static int DeckIntOn51;
    public static int DeckIntOn52;
    public static int DeckIntOn53;
    public static int DeckIntOn54;
    public static int DeckIntOn55;
    public static int DeckIntOn56;
    public static int DeckIntOn57;
    public static int DeckIntOn58;
    public static int DeckIntOn59;
    public static int DeckIntOn60;
    public static int DeckIntOn61;
    public static int DeckIntOn62;
    public static int DeckIntOn63;
    public static int DeckIntOn64;
    public static int DeckIntOn65;
    public static int DeckIntOn66;
    public static int DeckIntOn67;
    public static int DeckIntOn68;

    // Deck Items
    public static int DeckDownloaded01;
    public static int DeckDownloaded02;
    public static int DeckDownloaded03;
    public static int DeckDownloaded04;
    public static int DeckDownloaded05;
    public static int DeckDownloaded06;
    public static int DeckDownloaded07;
    public static int DeckDownloaded08;
    public static int DeckDownloaded09;
    public static int DeckDownloaded10;
    public static int DeckDownloaded11;
    public static int DeckDownloaded12;
    public static int DeckDownloaded13;
    public static int DeckDownloaded14;
    public static int DeckDownloaded15;
    public static int DeckDownloaded16;
    public static int DeckDownloaded17;
    public static int DeckDownloaded18;
    public static int DeckDownloaded19;
    public static int DeckDownloaded20;
    public static int DeckDownloaded21;
    public static int DeckDownloaded22;
    public static int DeckDownloaded23;
    public static int DeckDownloaded24;
    public static int DeckDownloaded25;
    public static int DeckDownloaded26;
    public static int DeckDownloaded27;
    public static int DeckDownloaded28;
    public static int DeckDownloaded29;
    public static int DeckDownloaded30;
    public static int DeckDownloaded31;
    public static int DeckDownloaded32;
    public static int DeckDownloaded33;
    public static int DeckDownloaded34;
    public static int DeckDownloaded35;
    public static int DeckDownloaded36;
    public static int DeckDownloaded37;
    public static int DeckDownloaded38;
    public static int DeckDownloaded39;
    public static int DeckDownloaded40;
    public static int DeckDownloaded41;
    public static int DeckDownloaded42;
    public static int DeckDownloaded43;
    public static int DeckDownloaded44;
    public static int DeckDownloaded45;
    public static int DeckDownloaded46;
    public static int DeckDownloaded47;
    public static int DeckDownloaded48;
    public static int DeckDownloaded49;
    public static int DeckDownloaded50;
    public static int DeckDownloaded51;
    public static int DeckDownloaded52;
    public static int DeckDownloaded53;
    public static int DeckDownloaded54;
    public static int DeckDownloaded55;
    public static int DeckDownloaded56;
    public static int DeckDownloaded57;
    public static int DeckDownloaded58;
    public static int DeckDownloaded59;
    public static int DeckDownloaded60;
    public static int DeckDownloaded61;
    public static int DeckDownloaded62;
    public static int DeckDownloaded63;
    public static int DeckDownloaded64;
    public static int DeckDownloaded65;
    public static int DeckDownloaded66;
    public static int DeckDownloaded67;
    public static int DeckDownloaded68;

    // Deck Items
    public static int DeckSelected01;
    public static int DeckSelected02;
    public static int DeckSelected03;
    public static int DeckSelected04;
    public static int DeckSelected05;
    public static int DeckSelected06;
    public static int DeckSelected07;
    public static int DeckSelected08;
    public static int DeckSelected09;
    public static int DeckSelected10;
    public static int DeckSelected11;
    public static int DeckSelected12;
    public static int DeckSelected13;
    public static int DeckSelected14;
    public static int DeckSelected15;
    public static int DeckSelected16;
    public static int DeckSelected17;
    public static int DeckSelected18;
    public static int DeckSelected19;
    public static int DeckSelected20;
    public static int DeckSelected21;
    public static int DeckSelected22;
    public static int DeckSelected23;
    public static int DeckSelected24;
    public static int DeckSelected25;
    public static int DeckSelected26;
    public static int DeckSelected27;
    public static int DeckSelected28;
    public static int DeckSelected29;
    public static int DeckSelected30;
    public static int DeckSelected31;
    public static int DeckSelected32;
    public static int DeckSelected33;
    public static int DeckSelected34;
    public static int DeckSelected35;
    public static int DeckSelected36;
    public static int DeckSelected37;
    public static int DeckSelected38;
    public static int DeckSelected39;
    public static int DeckSelected40;
    public static int DeckSelected41;
    public static int DeckSelected42;
    public static int DeckSelected43;
    public static int DeckSelected44;
    public static int DeckSelected45;
    public static int DeckSelected46;
    public static int DeckSelected47;
    public static int DeckSelected48;
    public static int DeckSelected49;
    public static int DeckSelected50;
    public static int DeckSelected51;
    public static int DeckSelected52;
    public static int DeckSelected53;
    public static int DeckSelected54;
    public static int DeckSelected55;
    public static int DeckSelected56;
    public static int DeckSelected57;
    public static int DeckSelected58;
    public static int DeckSelected59;
    public static int DeckSelected60;
    public static int DeckSelected61;
    public static int DeckSelected62;
    public static int DeckSelected63;
    public static int DeckSelected64;
    public static int DeckSelected65;
    public static int DeckSelected66;
    public static int DeckSelected67;
    public static int DeckSelected68;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------


// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        EnableMain();
        SetInitialSprites();

        TitleText.text = "Duel Set-Up:" + "\n" + "Choose Your Deck";
        ActionText.text = "Next, you must choose up to fifteen (15) cards to form your hand. These are a mix of both Realm and Myth cards, so choose wisely. Select up five and then click Start to begin the duel. Good luck!";
        ShowDeckItems();
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        SettingSprites();
        DetermineDownloadedInts();
        DetermineSelectedInts();

        SelectedDeckText.text = Buttons09B.TotalDeckInPlay.ToString() + " / 15 Cards";
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

    public void DisableAllDeckItems() {
        PickDeckScroll.enabled = false;
        PickDeckView.enabled = false;
        SelectedDeckText.enabled = false;
        BeginButton.enabled = false;
        DeckText01.enabled = false;
        DeckOn01.enabled = false;
        DeckText02.enabled = false;
        DeckOn02.enabled = false;
        DeckText03.enabled = false;
        DeckOn03.enabled = false;
        DeckText04.enabled = false;
        DeckOn04.enabled = false;
        DeckText05.enabled = false;
        DeckOn05.enabled = false;
        DeckText06.enabled = false;
        DeckOn06.enabled = false;
        DeckText07.enabled = false;
        DeckOn07.enabled = false;
        DeckText08.enabled = false;
        DeckOn08.enabled = false;
        DeckText09.enabled = false;
        DeckOn09.enabled = false;
        DeckText10.enabled = false;
        DeckOn10.enabled = false;
        DeckText11.enabled = false;
        DeckOn11.enabled = false;
        DeckText12.enabled = false;
        DeckOn12.enabled = false;
        DeckText13.enabled = false;
        DeckOn13.enabled = false;
        DeckText14.enabled = false;
        DeckOn14.enabled = false;
        DeckText15.enabled = false;
        DeckOn15.enabled = false;
        DeckText16.enabled = false;
        DeckOn16.enabled = false;
        DeckText17.enabled = false;
        DeckOn17.enabled = false;
        DeckText18.enabled = false;
        DeckOn18.enabled = false;
        DeckText19.enabled = false;
        DeckOn19.enabled = false;
        DeckText20.enabled = false;
        DeckOn20.enabled = false;
        DeckText21.enabled = false;
        DeckOn21.enabled = false;
        DeckText22.enabled = false;
        DeckOn22.enabled = false;
        DeckText23.enabled = false;
        DeckOn23.enabled = false;
        DeckText24.enabled = false;
        DeckOn24.enabled = false;
        DeckText25.enabled = false;
        DeckOn25.enabled = false;
        DeckText26.enabled = false;
        DeckOn26.enabled = false;
        DeckText27.enabled = false;
        DeckOn27.enabled = false;
        DeckText28.enabled = false;
        DeckOn28.enabled = false;
        DeckText29.enabled = false;
        DeckOn29.enabled = false;
        DeckText30.enabled = false;
        DeckOn30.enabled = false;
        DeckText31.enabled = false;
        DeckOn31.enabled = false;
        DeckText32.enabled = false;
        DeckOn32.enabled = false;
        DeckText33.enabled = false;
        DeckOn33.enabled = false;
        DeckText34.enabled = false;
        DeckOn34.enabled = false;
        DeckText35.enabled = false;
        DeckOn35.enabled = false;
        DeckText36.enabled = false;
        DeckOn36.enabled = false;
        DeckText37.enabled = false;
        DeckOn37.enabled = false;
        DeckText38.enabled = false;
        DeckOn38.enabled = false;
        DeckText39.enabled = false;
        DeckOn39.enabled = false;
        DeckText40.enabled = false;
        DeckOn40.enabled = false;
        DeckText41.enabled = false;
        DeckOn41.enabled = false;
        DeckText42.enabled = false;
        DeckOn42.enabled = false;
        DeckText43.enabled = false;
        DeckOn43.enabled = false;
        DeckText44.enabled = false;
        DeckOn44.enabled = false;
        DeckText45.enabled = false;
        DeckOn45.enabled = false;
        DeckText46.enabled = false;
        DeckOn46.enabled = false;
        DeckText47.enabled = false;
        DeckOn47.enabled = false;
        DeckText48.enabled = false;
        DeckOn48.enabled = false;
        DeckText49.enabled = false;
        DeckOn49.enabled = false;
        DeckText50.enabled = false;
        DeckOn50.enabled = false;
        DeckText51.enabled = false;
        DeckOn51.enabled = false;
        DeckText52.enabled = false;
        DeckOn52.enabled = false;
        DeckText53.enabled = false;
        DeckOn53.enabled = false;
        DeckText54.enabled = false;
        DeckOn54.enabled = false;
        DeckText55.enabled = false;
        DeckOn55.enabled = false;
        DeckText56.enabled = false;
        DeckOn56.enabled = false;
        DeckText57.enabled = false;
        DeckOn57.enabled = false;
        DeckText58.enabled = false;
        DeckOn58.enabled = false;
        DeckText59.enabled = false;
        DeckOn59.enabled = false;
        DeckText60.enabled = false;
        DeckOn60.enabled = false;
        DeckText61.enabled = false;
        DeckOn61.enabled = false;
        DeckText62.enabled = false;
        DeckOn62.enabled = false;
        DeckText63.enabled = false;
        DeckOn63.enabled = false;
        DeckText64.enabled = false;
        DeckOn64.enabled = false;
        DeckText65.enabled = false;
        DeckOn65.enabled = false;
        DeckText66.enabled = false;
        DeckOn66.enabled = false;
        DeckText67.enabled = false;
        DeckOn67.enabled = false;
        DeckText68.enabled = false;
        DeckOn68.enabled = false;
    }

// -------------------- UPDATE FUNCTIONS --------------------
    public void ShowDeckItems() {
        // Disable All Items
        DisableAllDeckItems();

        // Enable Main Items
        PickDeckScroll.enabled = true;
        PickDeckView.enabled = true;
        SelectedDeckText.enabled = true;
        BeginButton.enabled = true;

        // Enable Owned
        EnableOwnedDeck();
        DownloadOwnedDeck();
    }

    public void EnableOwnedDeck() {
        // Dark
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount001) >= 1) {
            OwnedDeckList.Add(000);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount002) >= 1) {
            OwnedDeckList.Add(001);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount003) >= 1) {
            OwnedDeckList.Add(002);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount004) >= 1) {
            OwnedDeckList.Add(003);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount005) >= 1) {
            OwnedDeckList.Add(004);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount006) >= 1) {
            OwnedDeckList.Add(005);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount007) >= 1) {
            OwnedDeckList.Add(006);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount008) >= 1) {
            OwnedDeckList.Add(007);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount009) >= 1) {
            OwnedDeckList.Add(008);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount010) >= 1) {
            OwnedDeckList.Add(009);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount011) >= 1) {
            OwnedDeckList.Add(010);
        }

        // Earth
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount024) >= 1) {
            OwnedDeckList.Add(023);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount025) >= 1) {
            OwnedDeckList.Add(024);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount026) >= 1) {
            OwnedDeckList.Add(025);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount027) >= 1) {
            OwnedDeckList.Add(026);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount028) >= 1) {
            OwnedDeckList.Add(027);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount029) >= 1) {
            OwnedDeckList.Add(028);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount030) >= 1) {
            OwnedDeckList.Add(029);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount031) >= 1) {
            OwnedDeckList.Add(030);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount032) >= 1) {
            OwnedDeckList.Add(031);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount033) >= 1) {
            OwnedDeckList.Add(032);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount034) >= 1) {
            OwnedDeckList.Add(033);
        }

        // Light
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount046) >= 1) {
            OwnedDeckList.Add(045);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount047) >= 1) {
            OwnedDeckList.Add(046);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount048) >= 1) {
            OwnedDeckList.Add(047);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount049) >= 1) {
            OwnedDeckList.Add(048);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount050) >= 1) {
            OwnedDeckList.Add(049);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount051) >= 1) {
            OwnedDeckList.Add(050);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount052) >= 1) {
            OwnedDeckList.Add(051);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount053) >= 1) {
            OwnedDeckList.Add(052);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount054) >= 1) {
            OwnedDeckList.Add(053);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount055) >= 1) {
            OwnedDeckList.Add(054);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount056) >= 1) {
            OwnedDeckList.Add(055);
        }

        // Sea
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount070) >= 1) {
            OwnedDeckList.Add(069);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount071) >= 1) {
            OwnedDeckList.Add(070);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount072) >= 1) {
            OwnedDeckList.Add(071);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount073) >= 1) {
            OwnedDeckList.Add(072);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount074) >= 1) {
            OwnedDeckList.Add(073);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount075) >= 1) {
            OwnedDeckList.Add(074);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount076) >= 1) {
            OwnedDeckList.Add(075);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount077) >= 1) {
            OwnedDeckList.Add(076);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount078) >= 1) {
            OwnedDeckList.Add(077);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount079) >= 1) {
            OwnedDeckList.Add(078);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount080) >= 1) {
            OwnedDeckList.Add(079);
        }

        // Skies
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount091) >= 1) {
            OwnedDeckList.Add(090);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount092) >= 1) {
            OwnedDeckList.Add(091);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount093) >= 1) {
            OwnedDeckList.Add(092);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount094) >= 1) {
            OwnedDeckList.Add(093);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount095) >= 1) {
            OwnedDeckList.Add(094);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount096) >= 1) {
            OwnedDeckList.Add(095);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount097) >= 1) {
            OwnedDeckList.Add(096);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount098) >= 1) {
            OwnedDeckList.Add(097);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount099) >= 1) {
            OwnedDeckList.Add(098);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount100) >= 1) {
            OwnedDeckList.Add(099);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount101) >= 1) {
            OwnedDeckList.Add(100);
        }

        // Epic
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount114) >= 1) {
            OwnedDeckList.Add(113);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount115) >= 1) {
            OwnedDeckList.Add(114);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount116) >= 1) {
            OwnedDeckList.Add(115);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount117) >= 1) {
            OwnedDeckList.Add(116);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount118) >= 1) {
            OwnedDeckList.Add(117);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount119) >= 1) {
            OwnedDeckList.Add(118);
        }

        // World
        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount123) >= 1) {
            OwnedDeckList.Add(122);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount124) >= 1) {
            OwnedDeckList.Add(123);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount125) >= 1) {
            OwnedDeckList.Add(124);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount126) >= 1) {
            OwnedDeckList.Add(125);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount127) >= 1) {
            OwnedDeckList.Add(126);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount128) >= 1) {
            OwnedDeckList.Add(127);
        }

        if (System.Int32.Parse(PlayerDatabase.PlayerCardAmount129) >= 1) {
            OwnedDeckList.Add(128);
        }

        // Enabling All Texts
        DeckText01.enabled = true;
        DeckText02.enabled = true;
        DeckText03.enabled = true;
        DeckText04.enabled = true;
        DeckText05.enabled = true;
        DeckText06.enabled = true;
        DeckText07.enabled = true;
        DeckText08.enabled = true;
        DeckText09.enabled = true;
        DeckText10.enabled = true;
        DeckText11.enabled = true;
        DeckText12.enabled = true;
        DeckText13.enabled = true;
        DeckText14.enabled = true;
        DeckText15.enabled = true;
        DeckText16.enabled = true;
        DeckText17.enabled = true;
        DeckText18.enabled = true;
        DeckText19.enabled = true;
        DeckText20.enabled = true;
        DeckText21.enabled = true;
        DeckText22.enabled = true;
        DeckText23.enabled = true;
        DeckText24.enabled = true;
        DeckText25.enabled = true;
        DeckText26.enabled = true;
        DeckText27.enabled = true;
        DeckText28.enabled = true;
        DeckText29.enabled = true;
        DeckText30.enabled = true;
        DeckText31.enabled = true;
        DeckText32.enabled = true;
        DeckText33.enabled = true;
        DeckText34.enabled = true;
        DeckText35.enabled = true;
        DeckText36.enabled = true;
        DeckText37.enabled = true;
        DeckText38.enabled = true;
        DeckText39.enabled = true;
        DeckText40.enabled = true;
        DeckText41.enabled = true;
        DeckText42.enabled = true;
        DeckText43.enabled = true;
        DeckText44.enabled = true;
        DeckText45.enabled = true;
        DeckText46.enabled = true;
        DeckText47.enabled = true;
        DeckText48.enabled = true;
        DeckText49.enabled = true;
        DeckText50.enabled = true;
        DeckText51.enabled = true;
        DeckText52.enabled = true;
        DeckText53.enabled = true;
        DeckText54.enabled = true;
        DeckText55.enabled = true;
        DeckText56.enabled = true;
        DeckText57.enabled = true;
        DeckText58.enabled = true;
        DeckText59.enabled = true;
        DeckText60.enabled = true;
        DeckText61.enabled = true;
        DeckText62.enabled = true;
        DeckText63.enabled = true;
        DeckText64.enabled = true;
        DeckText65.enabled = true;
        DeckText66.enabled = true;
        DeckText67.enabled = true;
        DeckText68.enabled = true;

        // Coloring All Texts
        DeckText01.color = UnownedColor;
        DeckText02.color = UnownedColor;
        DeckText03.color = UnownedColor;
        DeckText04.color = UnownedColor;
        DeckText05.color = UnownedColor;
        DeckText06.color = UnownedColor;
        DeckText07.color = UnownedColor;
        DeckText08.color = UnownedColor;
        DeckText09.color = UnownedColor;
        DeckText10.color = UnownedColor;
        DeckText11.color = UnownedColor;
        DeckText12.color = UnownedColor;
        DeckText13.color = UnownedColor;
        DeckText14.color = UnownedColor;
        DeckText15.color = UnownedColor;
        DeckText16.color = UnownedColor;
        DeckText17.color = UnownedColor;
        DeckText18.color = UnownedColor;
        DeckText19.color = UnownedColor;
        DeckText20.color = UnownedColor;
        DeckText21.color = UnownedColor;
        DeckText22.color = UnownedColor;
        DeckText23.color = UnownedColor;
        DeckText24.color = UnownedColor;
        DeckText25.color = UnownedColor;
        DeckText26.color = UnownedColor;
        DeckText27.color = UnownedColor;
        DeckText28.color = UnownedColor;
        DeckText29.color = UnownedColor;
        DeckText30.color = UnownedColor;
        DeckText31.color = UnownedColor;
        DeckText32.color = UnownedColor;
        DeckText33.color = UnownedColor;
        DeckText34.color = UnownedColor;
        DeckText35.color = UnownedColor;
        DeckText36.color = UnownedColor;
        DeckText37.color = UnownedColor;
        DeckText38.color = UnownedColor;
        DeckText39.color = UnownedColor;
        DeckText40.color = UnownedColor;
        DeckText41.color = UnownedColor;
        DeckText42.color = UnownedColor;
        DeckText43.color = UnownedColor;
        DeckText44.color = UnownedColor;
        DeckText45.color = UnownedColor;
        DeckText46.color = UnownedColor;
        DeckText47.color = UnownedColor;
        DeckText48.color = UnownedColor;
        DeckText49.color = UnownedColor;
        DeckText50.color = UnownedColor;
        DeckText51.color = UnownedColor;
        DeckText52.color = UnownedColor;
        DeckText53.color = UnownedColor;
        DeckText54.color = UnownedColor;
        DeckText55.color = UnownedColor;
        DeckText56.color = UnownedColor;
        DeckText57.color = UnownedColor;
        DeckText58.color = UnownedColor;
        DeckText59.color = UnownedColor;
        DeckText60.color = UnownedColor;
        DeckText61.color = UnownedColor;
        DeckText62.color = UnownedColor;
        DeckText63.color = UnownedColor;
        DeckText64.color = UnownedColor;
        DeckText65.color = UnownedColor;
        DeckText66.color = UnownedColor;
        DeckText67.color = UnownedColor;
        DeckText68.color = UnownedColor;

        // Naming All Texts
        DeckText01.text = "Unowned Card";
        DeckText02.text = "Unowned Card";
        DeckText03.text = "Unowned Card";
        DeckText04.text = "Unowned Card";
        DeckText05.text = "Unowned Card";
        DeckText06.text = "Unowned Card";
        DeckText07.text = "Unowned Card";
        DeckText08.text = "Unowned Card";
        DeckText09.text = "Unowned Card";
        DeckText10.text = "Unowned Card";
        DeckText11.text = "Unowned Card";
        DeckText12.text = "Unowned Card";
        DeckText13.text = "Unowned Card";
        DeckText14.text = "Unowned Card";
        DeckText15.text = "Unowned Card";
        DeckText16.text = "Unowned Card";
        DeckText17.text = "Unowned Card";
        DeckText18.text = "Unowned Card";
        DeckText19.text = "Unowned Card";
        DeckText20.text = "Unowned Card";
        DeckText21.text = "Unowned Card";
        DeckText22.text = "Unowned Card";
        DeckText23.text = "Unowned Card";
        DeckText24.text = "Unowned Card";
        DeckText25.text = "Unowned Card";
        DeckText26.text = "Unowned Card";
        DeckText27.text = "Unowned Card";
        DeckText28.text = "Unowned Card";
        DeckText29.text = "Unowned Card";
        DeckText30.text = "Unowned Card";
        DeckText31.text = "Unowned Card";
        DeckText32.text = "Unowned Card";
        DeckText33.text = "Unowned Card";
        DeckText34.text = "Unowned Card";
        DeckText35.text = "Unowned Card";
        DeckText36.text = "Unowned Card";
        DeckText37.text = "Unowned Card";
        DeckText38.text = "Unowned Card";
        DeckText39.text = "Unowned Card";
        DeckText40.text = "Unowned Card";
        DeckText41.text = "Unowned Card";
        DeckText42.text = "Unowned Card";
        DeckText43.text = "Unowned Card";
        DeckText44.text = "Unowned Card";
        DeckText45.text = "Unowned Card";
        DeckText46.text = "Unowned Card";
        DeckText47.text = "Unowned Card";
        DeckText48.text = "Unowned Card";
        DeckText49.text = "Unowned Card";
        DeckText50.text = "Unowned Card";
        DeckText51.text = "Unowned Card";
        DeckText52.text = "Unowned Card";
        DeckText53.text = "Unowned Card";
        DeckText54.text = "Unowned Card";
        DeckText55.text = "Unowned Card";
        DeckText56.text = "Unowned Card";
        DeckText57.text = "Unowned Card";
        DeckText58.text = "Unowned Card";
        DeckText59.text = "Unowned Card";
        DeckText60.text = "Unowned Card";
        DeckText61.text = "Unowned Card";
        DeckText62.text = "Unowned Card";
        DeckText63.text = "Unowned Card";
        DeckText64.text = "Unowned Card";
        DeckText65.text = "Unowned Card";
        DeckText66.text = "Unowned Card";
        DeckText67.text = "Unowned Card";
        DeckText68.text = "Unowned Card";
    }

    public void DownloadOwnedDeck() {
        if (OwnedDeckList.Count >= 1) {
            DeckOn01.enabled = true;
            DeckText01.color = OwnedColor;
            DeckText01.text = CardDatabase.CardName[OwnedDeckList[0]] + "\n" + "(" + DeckSelected01.ToString() + "/" + DeckDownloaded01.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 2) {
            DeckOn02.enabled = true;
            DeckText02.color = OwnedColor;
            DeckText02.text = CardDatabase.CardName[OwnedDeckList[1]] + "\n" + "(" + DeckSelected02.ToString() + "/" + DeckDownloaded02.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 3) {
            DeckOn03.enabled = true;
            DeckText03.color = OwnedColor;
            DeckText03.text = CardDatabase.CardName[OwnedDeckList[2]] + "\n" + "(" + DeckSelected03.ToString() + "/" + DeckDownloaded03.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 4) {
            DeckOn04.enabled = true;
            DeckText04.color = OwnedColor;
            DeckText04.text = CardDatabase.CardName[OwnedDeckList[3]] + "\n" + "(" + DeckSelected04.ToString() + "/" + DeckDownloaded04.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 5) {
            DeckOn05.enabled = true;
            DeckText05.color = OwnedColor;
            DeckText05.text = CardDatabase.CardName[OwnedDeckList[4]] + "\n" + "(" + DeckSelected05.ToString() + "/" + DeckDownloaded05.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 6) {
            DeckOn06.enabled = true;
            DeckText06.color = OwnedColor;
            DeckText06.text = CardDatabase.CardName[OwnedDeckList[5]] + "\n" + "(" + DeckSelected06.ToString() + "/" + DeckDownloaded06.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 7) {
            DeckOn07.enabled = true;
            DeckText07.color = OwnedColor;
            DeckText07.text = CardDatabase.CardName[OwnedDeckList[6]] + "\n" + "(" + DeckSelected07.ToString() + "/" + DeckDownloaded07.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 8) {
            DeckOn08.enabled = true;
            DeckText08.color = OwnedColor;
            DeckText08.text = CardDatabase.CardName[OwnedDeckList[7]] + "\n" + "(" + DeckSelected08.ToString() + "/" + DeckDownloaded08.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 9) {
            DeckOn09.enabled = true;
            DeckText09.color = OwnedColor;
            DeckText09.text = CardDatabase.CardName[OwnedDeckList[8]] + "\n" + "(" + DeckSelected09.ToString() + "/" + DeckDownloaded09.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 10) {
            DeckOn10.enabled = true;
            DeckText10.color = OwnedColor;
            DeckText10.text = CardDatabase.CardName[OwnedDeckList[9]] + "\n" + "(" + DeckSelected10.ToString() + "/" + DeckDownloaded10.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 11) {
            DeckOn11.enabled = true;
            DeckText11.color = OwnedColor;
            DeckText11.text = CardDatabase.CardName[OwnedDeckList[10]] + "\n" + "(" + DeckSelected11.ToString() + "/" + DeckDownloaded11.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 12) {
            DeckOn12.enabled = true;
            DeckText12.color = OwnedColor;
            DeckText12.text = CardDatabase.CardName[OwnedDeckList[11]] + "\n" + "(" + DeckSelected12.ToString() + "/" + DeckDownloaded12.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 13) {
            DeckOn13.enabled = true;
            DeckText13.color = OwnedColor;
            DeckText13.text = CardDatabase.CardName[OwnedDeckList[12]] + "\n" + "(" + DeckSelected13.ToString() + "/" + DeckDownloaded13.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 14) {
            DeckOn14.enabled = true;
            DeckText14.color = OwnedColor;
            DeckText14.text = CardDatabase.CardName[OwnedDeckList[13]] + "\n" + "(" + DeckSelected14.ToString() + "/" + DeckDownloaded14.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 15) {
            DeckOn15.enabled = true;
            DeckText15.color = OwnedColor;
            DeckText15.text = CardDatabase.CardName[OwnedDeckList[14]] + "\n" + "(" + DeckSelected15.ToString() + "/" + DeckDownloaded15.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 16) {
            DeckOn16.enabled = true;
            DeckText16.color = OwnedColor;
            DeckText16.text = CardDatabase.CardName[OwnedDeckList[15]] + "\n" + "(" + DeckSelected16.ToString() + "/" + DeckDownloaded16.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 17) {
            DeckOn17.enabled = true;
            DeckText17.color = OwnedColor;
            DeckText17.text = CardDatabase.CardName[OwnedDeckList[16]] + "\n" + "(" + DeckSelected17.ToString() + "/" + DeckDownloaded17.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 18) {
            DeckOn18.enabled = true;
            DeckText18.color = OwnedColor;
            DeckText18.text = CardDatabase.CardName[OwnedDeckList[17]] + "\n" + "(" + DeckSelected18.ToString() + "/" + DeckDownloaded18.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 19) {
            DeckOn19.enabled = true;
            DeckText19.color = OwnedColor;
            DeckText19.text = CardDatabase.CardName[OwnedDeckList[18]] + "\n" + "(" + DeckSelected19.ToString() + "/" + DeckDownloaded19.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 20) {
            DeckOn20.enabled = true;
            DeckText20.color = OwnedColor;
            DeckText20.text = CardDatabase.CardName[OwnedDeckList[19]] + "\n" + "(" + DeckSelected20.ToString() + "/" + DeckDownloaded20.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 21) {
            DeckOn21.enabled = true;
            DeckText21.color = OwnedColor;
            DeckText21.text = CardDatabase.CardName[OwnedDeckList[20]] + "\n" + "(" + DeckSelected21.ToString() + "/" + DeckDownloaded21.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 22) {
            DeckOn22.enabled = true;
            DeckText22.color = OwnedColor;
            DeckText22.text = CardDatabase.CardName[OwnedDeckList[21]] + "\n" + "(" + DeckSelected22.ToString() + "/" + DeckDownloaded22.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 23) {
            DeckOn23.enabled = true;
            DeckText23.color = OwnedColor;
            DeckText23.text = CardDatabase.CardName[OwnedDeckList[22]] + "\n" + "(" + DeckSelected23.ToString() + "/" + DeckDownloaded23.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 24) {
            DeckOn24.enabled = true;
            DeckText24.color = OwnedColor;
            DeckText24.text = CardDatabase.CardName[OwnedDeckList[23]] + "\n" + "(" + DeckSelected24.ToString() + "/" + DeckDownloaded24.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 25) {
            DeckOn25.enabled = true;
            DeckText25.color = OwnedColor;
            DeckText25.text = CardDatabase.CardName[OwnedDeckList[24]] + "\n" + "(" + DeckSelected25.ToString() + "/" + DeckDownloaded25.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 26) {
            DeckOn26.enabled = true;
            DeckText26.color = OwnedColor;
            DeckText26.text = CardDatabase.CardName[OwnedDeckList[25]] + "\n" + "(" + DeckSelected26.ToString() + "/" + DeckDownloaded26.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 27) {
            DeckOn27.enabled = true;
            DeckText27.color = OwnedColor;
            DeckText27.text = CardDatabase.CardName[OwnedDeckList[26]] + "\n" + "(" + DeckSelected27.ToString() + "/" + DeckDownloaded27.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 28) {
            DeckOn28.enabled = true;
            DeckText28.color = OwnedColor;
            DeckText28.text = CardDatabase.CardName[OwnedDeckList[27]] + "\n" + "(" + DeckSelected28.ToString() + "/" + DeckDownloaded28.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 29) {
            DeckOn29.enabled = true;
            DeckText29.color = OwnedColor;
            DeckText29.text = CardDatabase.CardName[OwnedDeckList[28]] + "\n" + "(" + DeckSelected29.ToString() + "/" + DeckDownloaded29.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 30) {
            DeckOn30.enabled = true;
            DeckText30.color = OwnedColor;
            DeckText30.text = CardDatabase.CardName[OwnedDeckList[29]] + "\n" + "(" + DeckSelected30.ToString() + "/" + DeckDownloaded30.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 31) {
            DeckOn31.enabled = true;
            DeckText31.color = OwnedColor;
            DeckText31.text = CardDatabase.CardName[OwnedDeckList[30]] + "\n" + "(" + DeckSelected31.ToString() + "/" + DeckDownloaded31.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 32) {
            DeckOn32.enabled = true;
            DeckText32.color = OwnedColor;
            DeckText32.text = CardDatabase.CardName[OwnedDeckList[31]] + "\n" + "(" + DeckSelected32.ToString() + "/" + DeckDownloaded32.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 33) {
            DeckOn33.enabled = true;
            DeckText33.color = OwnedColor;
            DeckText33.text = CardDatabase.CardName[OwnedDeckList[32]] + "\n" + "(" + DeckSelected33.ToString() + "/" + DeckDownloaded33.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 34) {
            DeckOn34.enabled = true;
            DeckText34.color = OwnedColor;
            DeckText34.text = CardDatabase.CardName[OwnedDeckList[33]] + "\n" + "(" + DeckSelected34.ToString() + "/" + DeckDownloaded34.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 35) {
            DeckOn35.enabled = true;
            DeckText35.color = OwnedColor;
            DeckText35.text = CardDatabase.CardName[OwnedDeckList[34]] + "\n" + "(" + DeckSelected35.ToString() + "/" + DeckDownloaded35.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 36) {
            DeckOn36.enabled = true;
            DeckText36.color = OwnedColor;
            DeckText36.text = CardDatabase.CardName[OwnedDeckList[35]] + "\n" + "(" + DeckSelected36.ToString() + "/" + DeckDownloaded36.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 37) {
            DeckOn37.enabled = true;
            DeckText37.color = OwnedColor;
            DeckText37.text = CardDatabase.CardName[OwnedDeckList[36]] + "\n" + "(" + DeckSelected37.ToString() + "/" + DeckDownloaded37.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 38) {
            DeckOn38.enabled = true;
            DeckText38.color = OwnedColor;
            DeckText38.text = CardDatabase.CardName[OwnedDeckList[37]] + "\n" + "(" + DeckSelected38.ToString() + "/" + DeckDownloaded38.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 39) {
            DeckOn39.enabled = true;
            DeckText39.color = OwnedColor;
            DeckText39.text = CardDatabase.CardName[OwnedDeckList[38]] + "\n" + "(" + DeckSelected39.ToString() + "/" + DeckDownloaded39.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 40) {
            DeckOn40.enabled = true;
            DeckText40.color = OwnedColor;
            DeckText40.text = CardDatabase.CardName[OwnedDeckList[39]] + "\n" + "(" + DeckSelected40.ToString() + "/" + DeckDownloaded40.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 41) {
            DeckOn41.enabled = true;
            DeckText41.color = OwnedColor;
            DeckText41.text = CardDatabase.CardName[OwnedDeckList[40]] + "\n" + "(" + DeckSelected41.ToString() + "/" + DeckDownloaded41.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 42) {
            DeckOn42.enabled = true;
            DeckText42.color = OwnedColor;
            DeckText42.text = CardDatabase.CardName[OwnedDeckList[41]] + "\n" + "(" + DeckSelected42.ToString() + "/" + DeckDownloaded42.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 43) {
            DeckOn43.enabled = true;
            DeckText43.color = OwnedColor;
            DeckText43.text = CardDatabase.CardName[OwnedDeckList[42]] + "\n" + "(" + DeckSelected43.ToString() + "/" + DeckDownloaded43.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 44) {
            DeckOn44.enabled = true;
            DeckText44.color = OwnedColor;
            DeckText44.text = CardDatabase.CardName[OwnedDeckList[43]] + "\n" + "(" + DeckSelected44.ToString() + "/" + DeckDownloaded44.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 45) {
            DeckOn45.enabled = true;
            DeckText45.color = OwnedColor;
            DeckText45.text = CardDatabase.CardName[OwnedDeckList[44]] + "\n" + "(" + DeckSelected45.ToString() + "/" + DeckDownloaded45.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 46) {
            DeckOn46.enabled = true;
            DeckText46.color = OwnedColor;
            DeckText46.text = CardDatabase.CardName[OwnedDeckList[45]] + "\n" + "(" + DeckSelected46.ToString() + "/" + DeckDownloaded46.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 47) {
            DeckOn47.enabled = true;
            DeckText47.color = OwnedColor;
            DeckText47.text = CardDatabase.CardName[OwnedDeckList[46]] + "\n" + "(" + DeckSelected47.ToString() + "/" + DeckDownloaded47.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 48) {
            DeckOn48.enabled = true;
            DeckText48.color = OwnedColor;
            DeckText48.text = CardDatabase.CardName[OwnedDeckList[47]] + "\n" + "(" + DeckSelected48.ToString() + "/" + DeckDownloaded48.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 49) {
            DeckOn49.enabled = true;
            DeckText49.color = OwnedColor;
            DeckText49.text = CardDatabase.CardName[OwnedDeckList[48]] + "\n" + "(" + DeckSelected49.ToString() + "/" + DeckDownloaded49.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 50) {
            DeckOn50.enabled = true;
            DeckText50.color = OwnedColor;
            DeckText50.text = CardDatabase.CardName[OwnedDeckList[49]] + "\n" + "(" + DeckSelected50.ToString() + "/" + DeckDownloaded50.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 51) {
            DeckOn51.enabled = true;
            DeckText51.color = OwnedColor;
            DeckText51.text = CardDatabase.CardName[OwnedDeckList[50]] + "\n" + "(" + DeckSelected51.ToString() + "/" + DeckDownloaded51.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 52) {
            DeckOn52.enabled = true;
            DeckText52.color = OwnedColor;
            DeckText52.text = CardDatabase.CardName[OwnedDeckList[51]] + "\n" + "(" + DeckSelected52.ToString() + "/" + DeckDownloaded52.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 53) {
            DeckOn53.enabled = true;
            DeckText53.color = OwnedColor;
            DeckText53.text = CardDatabase.CardName[OwnedDeckList[52]] + "\n" + "(" + DeckSelected53.ToString() + "/" + DeckDownloaded53.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 54) {
            DeckOn54.enabled = true;
            DeckText54.color = OwnedColor;
            DeckText54.text = CardDatabase.CardName[OwnedDeckList[53]] + "\n" + "(" + DeckSelected54.ToString() + "/" + DeckDownloaded54.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 55) {
            DeckOn55.enabled = true;
            DeckText55.color = OwnedColor;
            DeckText55.text = CardDatabase.CardName[OwnedDeckList[54]] + "\n" + "(" + DeckSelected55.ToString() + "/" + DeckDownloaded55.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 56) {
            DeckOn56.enabled = true;
            DeckText56.color = OwnedColor;
            DeckText56.text = CardDatabase.CardName[OwnedDeckList[55]] + "\n" + "(" + DeckSelected56.ToString() + "/" + DeckDownloaded56.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 57) {
            DeckOn57.enabled = true;
            DeckText57.color = OwnedColor;
            DeckText57.text = CardDatabase.CardName[OwnedDeckList[56]] + "\n" + "(" + DeckSelected57.ToString() + "/" + DeckDownloaded57.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 58) {
            DeckOn58.enabled = true;
            DeckText58.color = OwnedColor;
            DeckText58.text = CardDatabase.CardName[OwnedDeckList[57]] + "\n" + "(" + DeckSelected58.ToString() + "/" + DeckDownloaded58.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 59) {
            DeckOn59.enabled = true;
            DeckText59.color = OwnedColor;
            DeckText59.text = CardDatabase.CardName[OwnedDeckList[58]] + "\n" + "(" + DeckSelected59.ToString() + "/" + DeckDownloaded59.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 60) {
            DeckOn60.enabled = true;
            DeckText60.color = OwnedColor;
            DeckText60.text = CardDatabase.CardName[OwnedDeckList[59]] + "\n" + "(" + DeckSelected60.ToString() + "/" + DeckDownloaded60.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 61) {
            DeckOn61.enabled = true;
            DeckText61.color = OwnedColor;
            DeckText61.text = CardDatabase.CardName[OwnedDeckList[60]] + "\n" + "(" + DeckSelected61.ToString() + "/" + DeckDownloaded61.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 62) {
            DeckOn62.enabled = true;
            DeckText62.color = OwnedColor;
            DeckText62.text = CardDatabase.CardName[OwnedDeckList[61]] + "\n" + "(" + DeckSelected62.ToString() + "/" + DeckDownloaded62.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 63) {
            DeckOn63.enabled = true;
            DeckText63.color = OwnedColor;
            DeckText63.text = CardDatabase.CardName[OwnedDeckList[62]] + "\n" + "(" + DeckSelected63.ToString() + "/" + DeckDownloaded63.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 64) {
            DeckOn64.enabled = true;
            DeckText64.color = OwnedColor;
            DeckText64.text = CardDatabase.CardName[OwnedDeckList[63]] + "\n" + "(" + DeckSelected64.ToString() + "/" + DeckDownloaded64.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 65) {
            DeckOn65.enabled = true;
            DeckText65.color = OwnedColor;
            DeckText65.text = CardDatabase.CardName[OwnedDeckList[64]] + "\n" + "(" + DeckSelected65.ToString() + "/" + DeckDownloaded65.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 66) {
            DeckOn66.enabled = true;
            DeckText66.color = OwnedColor;
            DeckText66.text = CardDatabase.CardName[OwnedDeckList[65]] + "\n" + "(" + DeckSelected66.ToString() + "/" + DeckDownloaded66.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 67) {
            DeckOn67.enabled = true;
            DeckText67.color = OwnedColor;
            DeckText67.text = CardDatabase.CardName[OwnedDeckList[66]] + "\n" + "(" + DeckSelected67.ToString() + "/" + DeckDownloaded67.ToString() + ")";
        }

        if (OwnedDeckList.Count >= 68) {
            DeckOn68.enabled = true;
            DeckText68.color = OwnedColor;
            DeckText68.text = CardDatabase.CardName[OwnedDeckList[67]] + "\n" + "(" + DeckSelected68.ToString() + "/" + DeckDownloaded68.ToString() + ")";
        }
    }

    public void DetermineDownloadedInts() {
        // DeckText01
        if (DeckText01.text == CardDatabase.CardName[0]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText01.text == CardDatabase.CardName[1]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText01.text == CardDatabase.CardName[2]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText01.text == CardDatabase.CardName[3]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText01.text == CardDatabase.CardName[4]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText01.text == CardDatabase.CardName[5]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText01.text == CardDatabase.CardName[6]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText01.text == CardDatabase.CardName[7]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText01.text == CardDatabase.CardName[8]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText01.text == CardDatabase.CardName[9]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText01.text == CardDatabase.CardName[10]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText01.text == CardDatabase.CardName[23]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText01.text == CardDatabase.CardName[24]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText01.text == CardDatabase.CardName[25]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText01.text == CardDatabase.CardName[26]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText01.text == CardDatabase.CardName[27]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText01.text == CardDatabase.CardName[28]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText01.text == CardDatabase.CardName[29]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText01.text == CardDatabase.CardName[30]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText01.text == CardDatabase.CardName[31]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText01.text == CardDatabase.CardName[32]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText01.text == CardDatabase.CardName[33]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText01.text == CardDatabase.CardName[45]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText01.text == CardDatabase.CardName[46]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText01.text == CardDatabase.CardName[47]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText01.text == CardDatabase.CardName[48]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText01.text == CardDatabase.CardName[49]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText01.text == CardDatabase.CardName[50]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText01.text == CardDatabase.CardName[51]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText01.text == CardDatabase.CardName[52]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText01.text == CardDatabase.CardName[53]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText01.text == CardDatabase.CardName[54]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText01.text == CardDatabase.CardName[55]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText01.text == CardDatabase.CardName[69]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText01.text == CardDatabase.CardName[70]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText01.text == CardDatabase.CardName[71]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText01.text == CardDatabase.CardName[72]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText01.text == CardDatabase.CardName[73]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText01.text == CardDatabase.CardName[74]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText01.text == CardDatabase.CardName[75]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText01.text == CardDatabase.CardName[76]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText01.text == CardDatabase.CardName[77]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText01.text == CardDatabase.CardName[78]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText01.text == CardDatabase.CardName[79]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText01.text == CardDatabase.CardName[90]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText01.text == CardDatabase.CardName[91]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText01.text == CardDatabase.CardName[92]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText01.text == CardDatabase.CardName[93]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText01.text == CardDatabase.CardName[94]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText01.text == CardDatabase.CardName[95]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText01.text == CardDatabase.CardName[96]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText01.text == CardDatabase.CardName[97]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText01.text == CardDatabase.CardName[98]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText01.text == CardDatabase.CardName[99]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText01.text == CardDatabase.CardName[100]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText01.text == CardDatabase.CardName[113]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText01.text == CardDatabase.CardName[114]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText01.text == CardDatabase.CardName[115]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText01.text == CardDatabase.CardName[116]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText01.text == CardDatabase.CardName[117]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText01.text == CardDatabase.CardName[118]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText01.text == CardDatabase.CardName[122]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText01.text == CardDatabase.CardName[123]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText01.text == CardDatabase.CardName[124]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText01.text == CardDatabase.CardName[125]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText01.text == CardDatabase.CardName[126]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText01.text == CardDatabase.CardName[127]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText01.text == CardDatabase.CardName[128]) {
            DeckDownloaded01 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText02
        if (DeckText02.text == CardDatabase.CardName[0]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText02.text == CardDatabase.CardName[1]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText02.text == CardDatabase.CardName[2]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText02.text == CardDatabase.CardName[3]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText02.text == CardDatabase.CardName[4]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText02.text == CardDatabase.CardName[5]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText02.text == CardDatabase.CardName[6]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText02.text == CardDatabase.CardName[7]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText02.text == CardDatabase.CardName[8]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText02.text == CardDatabase.CardName[9]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText02.text == CardDatabase.CardName[10]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText02.text == CardDatabase.CardName[23]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText02.text == CardDatabase.CardName[24]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText02.text == CardDatabase.CardName[25]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText02.text == CardDatabase.CardName[26]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText02.text == CardDatabase.CardName[27]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText02.text == CardDatabase.CardName[28]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText02.text == CardDatabase.CardName[29]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText02.text == CardDatabase.CardName[30]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText02.text == CardDatabase.CardName[31]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText02.text == CardDatabase.CardName[32]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText02.text == CardDatabase.CardName[33]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText02.text == CardDatabase.CardName[45]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText02.text == CardDatabase.CardName[46]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText02.text == CardDatabase.CardName[47]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText02.text == CardDatabase.CardName[48]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText02.text == CardDatabase.CardName[49]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText02.text == CardDatabase.CardName[50]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText02.text == CardDatabase.CardName[51]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText02.text == CardDatabase.CardName[52]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText02.text == CardDatabase.CardName[53]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText02.text == CardDatabase.CardName[54]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText02.text == CardDatabase.CardName[55]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText02.text == CardDatabase.CardName[69]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText02.text == CardDatabase.CardName[70]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText02.text == CardDatabase.CardName[71]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText02.text == CardDatabase.CardName[72]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText02.text == CardDatabase.CardName[73]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText02.text == CardDatabase.CardName[74]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText02.text == CardDatabase.CardName[75]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText02.text == CardDatabase.CardName[76]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText02.text == CardDatabase.CardName[77]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText02.text == CardDatabase.CardName[78]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText02.text == CardDatabase.CardName[79]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText02.text == CardDatabase.CardName[90]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText02.text == CardDatabase.CardName[91]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText02.text == CardDatabase.CardName[92]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText02.text == CardDatabase.CardName[93]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText02.text == CardDatabase.CardName[94]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText02.text == CardDatabase.CardName[95]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText02.text == CardDatabase.CardName[96]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText02.text == CardDatabase.CardName[97]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText02.text == CardDatabase.CardName[98]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText02.text == CardDatabase.CardName[99]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText02.text == CardDatabase.CardName[100]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText02.text == CardDatabase.CardName[113]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText02.text == CardDatabase.CardName[114]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText02.text == CardDatabase.CardName[115]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText02.text == CardDatabase.CardName[116]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText02.text == CardDatabase.CardName[117]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText02.text == CardDatabase.CardName[118]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText02.text == CardDatabase.CardName[122]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText02.text == CardDatabase.CardName[123]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText02.text == CardDatabase.CardName[124]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText02.text == CardDatabase.CardName[125]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText02.text == CardDatabase.CardName[126]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText02.text == CardDatabase.CardName[127]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText02.text == CardDatabase.CardName[128]) {
            DeckDownloaded02 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText03
        if (DeckText03.text == CardDatabase.CardName[0]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText03.text == CardDatabase.CardName[1]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText03.text == CardDatabase.CardName[2]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText03.text == CardDatabase.CardName[3]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText03.text == CardDatabase.CardName[4]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText03.text == CardDatabase.CardName[5]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText03.text == CardDatabase.CardName[6]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText03.text == CardDatabase.CardName[7]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText03.text == CardDatabase.CardName[8]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText03.text == CardDatabase.CardName[9]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText03.text == CardDatabase.CardName[10]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText03.text == CardDatabase.CardName[23]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText03.text == CardDatabase.CardName[24]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText03.text == CardDatabase.CardName[25]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText03.text == CardDatabase.CardName[26]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText03.text == CardDatabase.CardName[27]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText03.text == CardDatabase.CardName[28]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText03.text == CardDatabase.CardName[29]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText03.text == CardDatabase.CardName[30]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText03.text == CardDatabase.CardName[31]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText03.text == CardDatabase.CardName[32]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText03.text == CardDatabase.CardName[33]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText03.text == CardDatabase.CardName[45]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText03.text == CardDatabase.CardName[46]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText03.text == CardDatabase.CardName[47]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText03.text == CardDatabase.CardName[48]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText03.text == CardDatabase.CardName[49]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText03.text == CardDatabase.CardName[50]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText03.text == CardDatabase.CardName[51]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText03.text == CardDatabase.CardName[52]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText03.text == CardDatabase.CardName[53]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText03.text == CardDatabase.CardName[54]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText03.text == CardDatabase.CardName[55]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText03.text == CardDatabase.CardName[69]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText03.text == CardDatabase.CardName[70]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText03.text == CardDatabase.CardName[71]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText03.text == CardDatabase.CardName[72]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText03.text == CardDatabase.CardName[73]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText03.text == CardDatabase.CardName[74]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText03.text == CardDatabase.CardName[75]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText03.text == CardDatabase.CardName[76]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText03.text == CardDatabase.CardName[77]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText03.text == CardDatabase.CardName[78]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText03.text == CardDatabase.CardName[79]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText03.text == CardDatabase.CardName[90]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText03.text == CardDatabase.CardName[91]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText03.text == CardDatabase.CardName[92]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText03.text == CardDatabase.CardName[93]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText03.text == CardDatabase.CardName[94]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText03.text == CardDatabase.CardName[95]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText03.text == CardDatabase.CardName[96]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText03.text == CardDatabase.CardName[97]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText03.text == CardDatabase.CardName[98]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText03.text == CardDatabase.CardName[99]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText03.text == CardDatabase.CardName[100]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText03.text == CardDatabase.CardName[113]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText03.text == CardDatabase.CardName[114]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText03.text == CardDatabase.CardName[115]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText03.text == CardDatabase.CardName[116]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText03.text == CardDatabase.CardName[117]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText03.text == CardDatabase.CardName[118]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText03.text == CardDatabase.CardName[122]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText03.text == CardDatabase.CardName[123]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText03.text == CardDatabase.CardName[124]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText03.text == CardDatabase.CardName[125]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText03.text == CardDatabase.CardName[126]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText03.text == CardDatabase.CardName[127]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText03.text == CardDatabase.CardName[128]) {
            DeckDownloaded03 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText04
        if (DeckText04.text == CardDatabase.CardName[0]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText04.text == CardDatabase.CardName[1]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText04.text == CardDatabase.CardName[2]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText04.text == CardDatabase.CardName[3]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText04.text == CardDatabase.CardName[4]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText04.text == CardDatabase.CardName[5]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText04.text == CardDatabase.CardName[6]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText04.text == CardDatabase.CardName[7]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText04.text == CardDatabase.CardName[8]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText04.text == CardDatabase.CardName[9]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText04.text == CardDatabase.CardName[10]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText04.text == CardDatabase.CardName[23]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText04.text == CardDatabase.CardName[24]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText04.text == CardDatabase.CardName[25]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText04.text == CardDatabase.CardName[26]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText04.text == CardDatabase.CardName[27]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText04.text == CardDatabase.CardName[28]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText04.text == CardDatabase.CardName[29]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText04.text == CardDatabase.CardName[30]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText04.text == CardDatabase.CardName[31]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText04.text == CardDatabase.CardName[32]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText04.text == CardDatabase.CardName[33]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText04.text == CardDatabase.CardName[45]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText04.text == CardDatabase.CardName[46]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText04.text == CardDatabase.CardName[47]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText04.text == CardDatabase.CardName[48]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText04.text == CardDatabase.CardName[49]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText04.text == CardDatabase.CardName[50]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText04.text == CardDatabase.CardName[51]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText04.text == CardDatabase.CardName[52]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText04.text == CardDatabase.CardName[53]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText04.text == CardDatabase.CardName[54]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText04.text == CardDatabase.CardName[55]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText04.text == CardDatabase.CardName[69]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText04.text == CardDatabase.CardName[70]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText04.text == CardDatabase.CardName[71]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText04.text == CardDatabase.CardName[72]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText04.text == CardDatabase.CardName[73]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText04.text == CardDatabase.CardName[74]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText04.text == CardDatabase.CardName[75]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText04.text == CardDatabase.CardName[76]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText04.text == CardDatabase.CardName[77]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText04.text == CardDatabase.CardName[78]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText04.text == CardDatabase.CardName[79]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText04.text == CardDatabase.CardName[90]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText04.text == CardDatabase.CardName[91]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText04.text == CardDatabase.CardName[92]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText04.text == CardDatabase.CardName[93]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText04.text == CardDatabase.CardName[94]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText04.text == CardDatabase.CardName[95]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText04.text == CardDatabase.CardName[96]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText04.text == CardDatabase.CardName[97]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText04.text == CardDatabase.CardName[98]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText04.text == CardDatabase.CardName[99]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText04.text == CardDatabase.CardName[100]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText04.text == CardDatabase.CardName[113]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText04.text == CardDatabase.CardName[114]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText04.text == CardDatabase.CardName[115]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText04.text == CardDatabase.CardName[116]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText04.text == CardDatabase.CardName[117]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText04.text == CardDatabase.CardName[118]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText04.text == CardDatabase.CardName[122]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText04.text == CardDatabase.CardName[123]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText04.text == CardDatabase.CardName[124]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText04.text == CardDatabase.CardName[125]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText04.text == CardDatabase.CardName[126]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText04.text == CardDatabase.CardName[127]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText04.text == CardDatabase.CardName[128]) {
            DeckDownloaded04 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText05
        if (DeckText05.text == CardDatabase.CardName[0]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText05.text == CardDatabase.CardName[1]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText05.text == CardDatabase.CardName[2]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText05.text == CardDatabase.CardName[3]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText05.text == CardDatabase.CardName[4]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText05.text == CardDatabase.CardName[5]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText05.text == CardDatabase.CardName[6]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText05.text == CardDatabase.CardName[7]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText05.text == CardDatabase.CardName[8]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText05.text == CardDatabase.CardName[9]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText05.text == CardDatabase.CardName[10]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText05.text == CardDatabase.CardName[23]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText05.text == CardDatabase.CardName[24]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText05.text == CardDatabase.CardName[25]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText05.text == CardDatabase.CardName[26]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText05.text == CardDatabase.CardName[27]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText05.text == CardDatabase.CardName[28]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText05.text == CardDatabase.CardName[29]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText05.text == CardDatabase.CardName[30]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText05.text == CardDatabase.CardName[31]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText05.text == CardDatabase.CardName[32]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText05.text == CardDatabase.CardName[33]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText05.text == CardDatabase.CardName[45]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText05.text == CardDatabase.CardName[46]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText05.text == CardDatabase.CardName[47]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText05.text == CardDatabase.CardName[48]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText05.text == CardDatabase.CardName[49]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText05.text == CardDatabase.CardName[50]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText05.text == CardDatabase.CardName[51]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText05.text == CardDatabase.CardName[52]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText05.text == CardDatabase.CardName[53]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText05.text == CardDatabase.CardName[54]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText05.text == CardDatabase.CardName[55]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText05.text == CardDatabase.CardName[69]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText05.text == CardDatabase.CardName[70]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText05.text == CardDatabase.CardName[71]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText05.text == CardDatabase.CardName[72]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText05.text == CardDatabase.CardName[73]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText05.text == CardDatabase.CardName[74]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText05.text == CardDatabase.CardName[75]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText05.text == CardDatabase.CardName[76]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText05.text == CardDatabase.CardName[77]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText05.text == CardDatabase.CardName[78]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText05.text == CardDatabase.CardName[79]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText05.text == CardDatabase.CardName[90]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText05.text == CardDatabase.CardName[91]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText05.text == CardDatabase.CardName[92]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText05.text == CardDatabase.CardName[93]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText05.text == CardDatabase.CardName[94]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText05.text == CardDatabase.CardName[95]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText05.text == CardDatabase.CardName[96]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText05.text == CardDatabase.CardName[97]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText05.text == CardDatabase.CardName[98]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText05.text == CardDatabase.CardName[99]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText05.text == CardDatabase.CardName[100]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText05.text == CardDatabase.CardName[113]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText05.text == CardDatabase.CardName[114]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText05.text == CardDatabase.CardName[115]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText05.text == CardDatabase.CardName[116]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText05.text == CardDatabase.CardName[117]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText05.text == CardDatabase.CardName[118]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText05.text == CardDatabase.CardName[122]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText05.text == CardDatabase.CardName[123]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText05.text == CardDatabase.CardName[124]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText05.text == CardDatabase.CardName[125]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText05.text == CardDatabase.CardName[126]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText05.text == CardDatabase.CardName[127]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText05.text == CardDatabase.CardName[128]) {
            DeckDownloaded05 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText06
        if (DeckText06.text == CardDatabase.CardName[0]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText06.text == CardDatabase.CardName[1]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText06.text == CardDatabase.CardName[2]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText06.text == CardDatabase.CardName[3]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText06.text == CardDatabase.CardName[4]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText06.text == CardDatabase.CardName[5]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText06.text == CardDatabase.CardName[6]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText06.text == CardDatabase.CardName[7]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText06.text == CardDatabase.CardName[8]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText06.text == CardDatabase.CardName[9]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText06.text == CardDatabase.CardName[10]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText06.text == CardDatabase.CardName[23]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText06.text == CardDatabase.CardName[24]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText06.text == CardDatabase.CardName[25]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText06.text == CardDatabase.CardName[26]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText06.text == CardDatabase.CardName[27]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText06.text == CardDatabase.CardName[28]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText06.text == CardDatabase.CardName[29]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText06.text == CardDatabase.CardName[30]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText06.text == CardDatabase.CardName[31]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText06.text == CardDatabase.CardName[32]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText06.text == CardDatabase.CardName[33]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText06.text == CardDatabase.CardName[45]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText06.text == CardDatabase.CardName[46]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText06.text == CardDatabase.CardName[47]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText06.text == CardDatabase.CardName[48]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText06.text == CardDatabase.CardName[49]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText06.text == CardDatabase.CardName[50]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText06.text == CardDatabase.CardName[51]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText06.text == CardDatabase.CardName[52]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText06.text == CardDatabase.CardName[53]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText06.text == CardDatabase.CardName[54]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText06.text == CardDatabase.CardName[55]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText06.text == CardDatabase.CardName[69]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText06.text == CardDatabase.CardName[70]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText06.text == CardDatabase.CardName[71]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText06.text == CardDatabase.CardName[72]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText06.text == CardDatabase.CardName[73]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText06.text == CardDatabase.CardName[74]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText06.text == CardDatabase.CardName[75]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText06.text == CardDatabase.CardName[76]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText06.text == CardDatabase.CardName[77]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText06.text == CardDatabase.CardName[78]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText06.text == CardDatabase.CardName[79]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText06.text == CardDatabase.CardName[90]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText06.text == CardDatabase.CardName[91]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText06.text == CardDatabase.CardName[92]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText06.text == CardDatabase.CardName[93]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText06.text == CardDatabase.CardName[94]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText06.text == CardDatabase.CardName[95]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText06.text == CardDatabase.CardName[96]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText06.text == CardDatabase.CardName[97]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText06.text == CardDatabase.CardName[98]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText06.text == CardDatabase.CardName[99]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText06.text == CardDatabase.CardName[100]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText06.text == CardDatabase.CardName[113]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText06.text == CardDatabase.CardName[114]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText06.text == CardDatabase.CardName[115]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText06.text == CardDatabase.CardName[116]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText06.text == CardDatabase.CardName[117]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText06.text == CardDatabase.CardName[118]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText06.text == CardDatabase.CardName[122]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText06.text == CardDatabase.CardName[123]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText06.text == CardDatabase.CardName[124]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText06.text == CardDatabase.CardName[125]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText06.text == CardDatabase.CardName[126]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText06.text == CardDatabase.CardName[127]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText06.text == CardDatabase.CardName[128]) {
            DeckDownloaded06 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText07
        if (DeckText07.text == CardDatabase.CardName[0]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText07.text == CardDatabase.CardName[1]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText07.text == CardDatabase.CardName[2]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText07.text == CardDatabase.CardName[3]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText07.text == CardDatabase.CardName[4]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText07.text == CardDatabase.CardName[5]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText07.text == CardDatabase.CardName[6]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText07.text == CardDatabase.CardName[7]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText07.text == CardDatabase.CardName[8]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText07.text == CardDatabase.CardName[9]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText07.text == CardDatabase.CardName[10]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText07.text == CardDatabase.CardName[23]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText07.text == CardDatabase.CardName[24]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText07.text == CardDatabase.CardName[25]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText07.text == CardDatabase.CardName[26]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText07.text == CardDatabase.CardName[27]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText07.text == CardDatabase.CardName[28]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText07.text == CardDatabase.CardName[29]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText07.text == CardDatabase.CardName[30]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText07.text == CardDatabase.CardName[31]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText07.text == CardDatabase.CardName[32]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText07.text == CardDatabase.CardName[33]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText07.text == CardDatabase.CardName[45]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText07.text == CardDatabase.CardName[46]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText07.text == CardDatabase.CardName[47]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText07.text == CardDatabase.CardName[48]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText07.text == CardDatabase.CardName[49]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText07.text == CardDatabase.CardName[50]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText07.text == CardDatabase.CardName[51]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText07.text == CardDatabase.CardName[52]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText07.text == CardDatabase.CardName[53]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText07.text == CardDatabase.CardName[54]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText07.text == CardDatabase.CardName[55]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText07.text == CardDatabase.CardName[69]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText07.text == CardDatabase.CardName[70]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText07.text == CardDatabase.CardName[71]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText07.text == CardDatabase.CardName[72]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText07.text == CardDatabase.CardName[73]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText07.text == CardDatabase.CardName[74]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText07.text == CardDatabase.CardName[75]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText07.text == CardDatabase.CardName[76]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText07.text == CardDatabase.CardName[77]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText07.text == CardDatabase.CardName[78]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText07.text == CardDatabase.CardName[79]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText07.text == CardDatabase.CardName[90]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText07.text == CardDatabase.CardName[91]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText07.text == CardDatabase.CardName[92]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText07.text == CardDatabase.CardName[93]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText07.text == CardDatabase.CardName[94]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText07.text == CardDatabase.CardName[95]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText07.text == CardDatabase.CardName[96]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText07.text == CardDatabase.CardName[97]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText07.text == CardDatabase.CardName[98]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText07.text == CardDatabase.CardName[99]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText07.text == CardDatabase.CardName[100]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText07.text == CardDatabase.CardName[113]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText07.text == CardDatabase.CardName[114]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText07.text == CardDatabase.CardName[115]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText07.text == CardDatabase.CardName[116]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText07.text == CardDatabase.CardName[117]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText07.text == CardDatabase.CardName[118]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText07.text == CardDatabase.CardName[122]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText07.text == CardDatabase.CardName[123]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText07.text == CardDatabase.CardName[124]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText07.text == CardDatabase.CardName[125]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText07.text == CardDatabase.CardName[126]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText07.text == CardDatabase.CardName[127]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText07.text == CardDatabase.CardName[128]) {
            DeckDownloaded07 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText08
        if (DeckText08.text == CardDatabase.CardName[0]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText08.text == CardDatabase.CardName[1]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText08.text == CardDatabase.CardName[2]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText08.text == CardDatabase.CardName[3]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText08.text == CardDatabase.CardName[4]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText08.text == CardDatabase.CardName[5]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText08.text == CardDatabase.CardName[6]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText08.text == CardDatabase.CardName[7]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText08.text == CardDatabase.CardName[8]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText08.text == CardDatabase.CardName[9]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText08.text == CardDatabase.CardName[10]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText08.text == CardDatabase.CardName[23]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText08.text == CardDatabase.CardName[24]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText08.text == CardDatabase.CardName[25]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText08.text == CardDatabase.CardName[26]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText08.text == CardDatabase.CardName[27]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText08.text == CardDatabase.CardName[28]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText08.text == CardDatabase.CardName[29]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText08.text == CardDatabase.CardName[30]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText08.text == CardDatabase.CardName[31]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText08.text == CardDatabase.CardName[32]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText08.text == CardDatabase.CardName[33]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText08.text == CardDatabase.CardName[45]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText08.text == CardDatabase.CardName[46]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText08.text == CardDatabase.CardName[47]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText08.text == CardDatabase.CardName[48]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText08.text == CardDatabase.CardName[49]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText08.text == CardDatabase.CardName[50]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText08.text == CardDatabase.CardName[51]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText08.text == CardDatabase.CardName[52]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText08.text == CardDatabase.CardName[53]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText08.text == CardDatabase.CardName[54]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText08.text == CardDatabase.CardName[55]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText08.text == CardDatabase.CardName[69]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText08.text == CardDatabase.CardName[70]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText08.text == CardDatabase.CardName[71]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText08.text == CardDatabase.CardName[72]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText08.text == CardDatabase.CardName[73]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText08.text == CardDatabase.CardName[74]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText08.text == CardDatabase.CardName[75]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText08.text == CardDatabase.CardName[76]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText08.text == CardDatabase.CardName[77]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText08.text == CardDatabase.CardName[78]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText08.text == CardDatabase.CardName[79]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText08.text == CardDatabase.CardName[90]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText08.text == CardDatabase.CardName[91]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText08.text == CardDatabase.CardName[92]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText08.text == CardDatabase.CardName[93]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText08.text == CardDatabase.CardName[94]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText08.text == CardDatabase.CardName[95]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText08.text == CardDatabase.CardName[96]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText08.text == CardDatabase.CardName[97]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText08.text == CardDatabase.CardName[98]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText08.text == CardDatabase.CardName[99]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText08.text == CardDatabase.CardName[100]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText08.text == CardDatabase.CardName[113]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText08.text == CardDatabase.CardName[114]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText08.text == CardDatabase.CardName[115]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText08.text == CardDatabase.CardName[116]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText08.text == CardDatabase.CardName[117]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText08.text == CardDatabase.CardName[118]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText08.text == CardDatabase.CardName[122]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText08.text == CardDatabase.CardName[123]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText08.text == CardDatabase.CardName[124]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText08.text == CardDatabase.CardName[125]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText08.text == CardDatabase.CardName[126]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText08.text == CardDatabase.CardName[127]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText08.text == CardDatabase.CardName[128]) {
            DeckDownloaded08 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText09
        if (DeckText09.text == CardDatabase.CardName[0]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText09.text == CardDatabase.CardName[1]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText09.text == CardDatabase.CardName[2]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText09.text == CardDatabase.CardName[3]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText09.text == CardDatabase.CardName[4]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText09.text == CardDatabase.CardName[5]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText09.text == CardDatabase.CardName[6]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText09.text == CardDatabase.CardName[7]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText09.text == CardDatabase.CardName[8]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText09.text == CardDatabase.CardName[9]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText09.text == CardDatabase.CardName[10]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText09.text == CardDatabase.CardName[23]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText09.text == CardDatabase.CardName[24]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText09.text == CardDatabase.CardName[25]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText09.text == CardDatabase.CardName[26]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText09.text == CardDatabase.CardName[27]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText09.text == CardDatabase.CardName[28]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText09.text == CardDatabase.CardName[29]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText09.text == CardDatabase.CardName[30]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText09.text == CardDatabase.CardName[31]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText09.text == CardDatabase.CardName[32]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText09.text == CardDatabase.CardName[33]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText09.text == CardDatabase.CardName[45]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText09.text == CardDatabase.CardName[46]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText09.text == CardDatabase.CardName[47]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText09.text == CardDatabase.CardName[48]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText09.text == CardDatabase.CardName[49]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText09.text == CardDatabase.CardName[50]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText09.text == CardDatabase.CardName[51]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText09.text == CardDatabase.CardName[52]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText09.text == CardDatabase.CardName[53]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText09.text == CardDatabase.CardName[54]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText09.text == CardDatabase.CardName[55]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText09.text == CardDatabase.CardName[69]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText09.text == CardDatabase.CardName[70]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText09.text == CardDatabase.CardName[71]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText09.text == CardDatabase.CardName[72]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText09.text == CardDatabase.CardName[73]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText09.text == CardDatabase.CardName[74]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText09.text == CardDatabase.CardName[75]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText09.text == CardDatabase.CardName[76]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText09.text == CardDatabase.CardName[77]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText09.text == CardDatabase.CardName[78]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText09.text == CardDatabase.CardName[79]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText09.text == CardDatabase.CardName[90]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText09.text == CardDatabase.CardName[91]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText09.text == CardDatabase.CardName[92]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText09.text == CardDatabase.CardName[93]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText09.text == CardDatabase.CardName[94]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText09.text == CardDatabase.CardName[95]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText09.text == CardDatabase.CardName[96]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText09.text == CardDatabase.CardName[97]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText09.text == CardDatabase.CardName[98]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText09.text == CardDatabase.CardName[99]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText09.text == CardDatabase.CardName[100]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText09.text == CardDatabase.CardName[113]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText09.text == CardDatabase.CardName[114]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText09.text == CardDatabase.CardName[115]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText09.text == CardDatabase.CardName[116]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText09.text == CardDatabase.CardName[117]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText09.text == CardDatabase.CardName[118]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText09.text == CardDatabase.CardName[122]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText09.text == CardDatabase.CardName[123]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText09.text == CardDatabase.CardName[124]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText09.text == CardDatabase.CardName[125]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText09.text == CardDatabase.CardName[126]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText09.text == CardDatabase.CardName[127]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText09.text == CardDatabase.CardName[128]) {
            DeckDownloaded09 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText10
        if (DeckText10.text == CardDatabase.CardName[0]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText10.text == CardDatabase.CardName[1]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText10.text == CardDatabase.CardName[2]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText10.text == CardDatabase.CardName[3]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText10.text == CardDatabase.CardName[4]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText10.text == CardDatabase.CardName[5]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText10.text == CardDatabase.CardName[6]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText10.text == CardDatabase.CardName[7]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText10.text == CardDatabase.CardName[8]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText10.text == CardDatabase.CardName[9]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText10.text == CardDatabase.CardName[10]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText10.text == CardDatabase.CardName[23]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText10.text == CardDatabase.CardName[24]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText10.text == CardDatabase.CardName[25]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText10.text == CardDatabase.CardName[26]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText10.text == CardDatabase.CardName[27]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText10.text == CardDatabase.CardName[28]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText10.text == CardDatabase.CardName[29]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText10.text == CardDatabase.CardName[30]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText10.text == CardDatabase.CardName[31]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText10.text == CardDatabase.CardName[32]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText10.text == CardDatabase.CardName[33]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText10.text == CardDatabase.CardName[45]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText10.text == CardDatabase.CardName[46]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText10.text == CardDatabase.CardName[47]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText10.text == CardDatabase.CardName[48]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText10.text == CardDatabase.CardName[49]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText10.text == CardDatabase.CardName[50]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText10.text == CardDatabase.CardName[51]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText10.text == CardDatabase.CardName[52]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText10.text == CardDatabase.CardName[53]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText10.text == CardDatabase.CardName[54]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText10.text == CardDatabase.CardName[55]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText10.text == CardDatabase.CardName[69]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText10.text == CardDatabase.CardName[70]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText10.text == CardDatabase.CardName[71]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText10.text == CardDatabase.CardName[72]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText10.text == CardDatabase.CardName[73]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText10.text == CardDatabase.CardName[74]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText10.text == CardDatabase.CardName[75]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText10.text == CardDatabase.CardName[76]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText10.text == CardDatabase.CardName[77]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText10.text == CardDatabase.CardName[78]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText10.text == CardDatabase.CardName[79]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText10.text == CardDatabase.CardName[90]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText10.text == CardDatabase.CardName[91]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText10.text == CardDatabase.CardName[92]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText10.text == CardDatabase.CardName[93]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText10.text == CardDatabase.CardName[94]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText10.text == CardDatabase.CardName[95]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText10.text == CardDatabase.CardName[96]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText10.text == CardDatabase.CardName[97]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText10.text == CardDatabase.CardName[98]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText10.text == CardDatabase.CardName[99]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText10.text == CardDatabase.CardName[100]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText10.text == CardDatabase.CardName[113]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText10.text == CardDatabase.CardName[114]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText10.text == CardDatabase.CardName[115]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText10.text == CardDatabase.CardName[116]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText10.text == CardDatabase.CardName[117]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText10.text == CardDatabase.CardName[118]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText10.text == CardDatabase.CardName[122]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText10.text == CardDatabase.CardName[123]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText10.text == CardDatabase.CardName[124]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText10.text == CardDatabase.CardName[125]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText10.text == CardDatabase.CardName[126]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText10.text == CardDatabase.CardName[127]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText10.text == CardDatabase.CardName[128]) {
            DeckDownloaded10 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText11
        if (DeckText11.text == CardDatabase.CardName[0]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText11.text == CardDatabase.CardName[1]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText11.text == CardDatabase.CardName[2]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText11.text == CardDatabase.CardName[3]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText11.text == CardDatabase.CardName[4]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText11.text == CardDatabase.CardName[5]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText11.text == CardDatabase.CardName[6]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText11.text == CardDatabase.CardName[7]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText11.text == CardDatabase.CardName[8]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText11.text == CardDatabase.CardName[9]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText11.text == CardDatabase.CardName[10]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText11.text == CardDatabase.CardName[23]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText11.text == CardDatabase.CardName[24]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText11.text == CardDatabase.CardName[25]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText11.text == CardDatabase.CardName[26]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText11.text == CardDatabase.CardName[27]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText11.text == CardDatabase.CardName[28]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText11.text == CardDatabase.CardName[29]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText11.text == CardDatabase.CardName[30]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText11.text == CardDatabase.CardName[31]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText11.text == CardDatabase.CardName[32]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText11.text == CardDatabase.CardName[33]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText11.text == CardDatabase.CardName[45]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText11.text == CardDatabase.CardName[46]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText11.text == CardDatabase.CardName[47]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText11.text == CardDatabase.CardName[48]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText11.text == CardDatabase.CardName[49]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText11.text == CardDatabase.CardName[50]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText11.text == CardDatabase.CardName[51]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText11.text == CardDatabase.CardName[52]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText11.text == CardDatabase.CardName[53]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText11.text == CardDatabase.CardName[54]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText11.text == CardDatabase.CardName[55]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText11.text == CardDatabase.CardName[69]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText11.text == CardDatabase.CardName[70]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText11.text == CardDatabase.CardName[71]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText11.text == CardDatabase.CardName[72]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText11.text == CardDatabase.CardName[73]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText11.text == CardDatabase.CardName[74]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText11.text == CardDatabase.CardName[75]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText11.text == CardDatabase.CardName[76]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText11.text == CardDatabase.CardName[77]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText11.text == CardDatabase.CardName[78]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText11.text == CardDatabase.CardName[79]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText11.text == CardDatabase.CardName[90]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText11.text == CardDatabase.CardName[91]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText11.text == CardDatabase.CardName[92]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText11.text == CardDatabase.CardName[93]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText11.text == CardDatabase.CardName[94]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText11.text == CardDatabase.CardName[95]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText11.text == CardDatabase.CardName[96]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText11.text == CardDatabase.CardName[97]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText11.text == CardDatabase.CardName[98]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText11.text == CardDatabase.CardName[99]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText11.text == CardDatabase.CardName[100]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText11.text == CardDatabase.CardName[113]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText11.text == CardDatabase.CardName[114]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText11.text == CardDatabase.CardName[115]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText11.text == CardDatabase.CardName[116]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText11.text == CardDatabase.CardName[117]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText11.text == CardDatabase.CardName[118]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText11.text == CardDatabase.CardName[122]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText11.text == CardDatabase.CardName[123]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText11.text == CardDatabase.CardName[124]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText11.text == CardDatabase.CardName[125]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText11.text == CardDatabase.CardName[126]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText11.text == CardDatabase.CardName[127]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText11.text == CardDatabase.CardName[128]) {
            DeckDownloaded11 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText12
        if (DeckText12.text == CardDatabase.CardName[0]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText12.text == CardDatabase.CardName[1]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText12.text == CardDatabase.CardName[2]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText12.text == CardDatabase.CardName[3]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText12.text == CardDatabase.CardName[4]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText12.text == CardDatabase.CardName[5]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText12.text == CardDatabase.CardName[6]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText12.text == CardDatabase.CardName[7]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText12.text == CardDatabase.CardName[8]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText12.text == CardDatabase.CardName[9]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText12.text == CardDatabase.CardName[10]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText12.text == CardDatabase.CardName[23]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText12.text == CardDatabase.CardName[24]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText12.text == CardDatabase.CardName[25]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText12.text == CardDatabase.CardName[26]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText12.text == CardDatabase.CardName[27]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText12.text == CardDatabase.CardName[28]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText12.text == CardDatabase.CardName[29]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText12.text == CardDatabase.CardName[30]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText12.text == CardDatabase.CardName[31]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText12.text == CardDatabase.CardName[32]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText12.text == CardDatabase.CardName[33]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText12.text == CardDatabase.CardName[45]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText12.text == CardDatabase.CardName[46]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText12.text == CardDatabase.CardName[47]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText12.text == CardDatabase.CardName[48]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText12.text == CardDatabase.CardName[49]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText12.text == CardDatabase.CardName[50]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText12.text == CardDatabase.CardName[51]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText12.text == CardDatabase.CardName[52]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText12.text == CardDatabase.CardName[53]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText12.text == CardDatabase.CardName[54]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText12.text == CardDatabase.CardName[55]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText12.text == CardDatabase.CardName[69]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText12.text == CardDatabase.CardName[70]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText12.text == CardDatabase.CardName[71]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText12.text == CardDatabase.CardName[72]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText12.text == CardDatabase.CardName[73]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText12.text == CardDatabase.CardName[74]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText12.text == CardDatabase.CardName[75]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText12.text == CardDatabase.CardName[76]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText12.text == CardDatabase.CardName[77]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText12.text == CardDatabase.CardName[78]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText12.text == CardDatabase.CardName[79]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText12.text == CardDatabase.CardName[90]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText12.text == CardDatabase.CardName[91]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText12.text == CardDatabase.CardName[92]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText12.text == CardDatabase.CardName[93]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText12.text == CardDatabase.CardName[94]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText12.text == CardDatabase.CardName[95]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText12.text == CardDatabase.CardName[96]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText12.text == CardDatabase.CardName[97]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText12.text == CardDatabase.CardName[98]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText12.text == CardDatabase.CardName[99]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText12.text == CardDatabase.CardName[100]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText12.text == CardDatabase.CardName[113]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText12.text == CardDatabase.CardName[114]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText12.text == CardDatabase.CardName[115]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText12.text == CardDatabase.CardName[116]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText12.text == CardDatabase.CardName[117]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText12.text == CardDatabase.CardName[118]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText12.text == CardDatabase.CardName[122]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText12.text == CardDatabase.CardName[123]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText12.text == CardDatabase.CardName[124]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText12.text == CardDatabase.CardName[125]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText12.text == CardDatabase.CardName[126]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText12.text == CardDatabase.CardName[127]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText12.text == CardDatabase.CardName[128]) {
            DeckDownloaded12 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText13
        if (DeckText13.text == CardDatabase.CardName[0]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText13.text == CardDatabase.CardName[1]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText13.text == CardDatabase.CardName[2]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText13.text == CardDatabase.CardName[3]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText13.text == CardDatabase.CardName[4]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText13.text == CardDatabase.CardName[5]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText13.text == CardDatabase.CardName[6]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText13.text == CardDatabase.CardName[7]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText13.text == CardDatabase.CardName[8]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText13.text == CardDatabase.CardName[9]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText13.text == CardDatabase.CardName[10]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText13.text == CardDatabase.CardName[23]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText13.text == CardDatabase.CardName[24]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText13.text == CardDatabase.CardName[25]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText13.text == CardDatabase.CardName[26]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText13.text == CardDatabase.CardName[27]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText13.text == CardDatabase.CardName[28]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText13.text == CardDatabase.CardName[29]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText13.text == CardDatabase.CardName[30]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText13.text == CardDatabase.CardName[31]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText13.text == CardDatabase.CardName[32]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText13.text == CardDatabase.CardName[33]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText13.text == CardDatabase.CardName[45]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText13.text == CardDatabase.CardName[46]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText13.text == CardDatabase.CardName[47]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText13.text == CardDatabase.CardName[48]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText13.text == CardDatabase.CardName[49]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText13.text == CardDatabase.CardName[50]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText13.text == CardDatabase.CardName[51]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText13.text == CardDatabase.CardName[52]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText13.text == CardDatabase.CardName[53]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText13.text == CardDatabase.CardName[54]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText13.text == CardDatabase.CardName[55]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText13.text == CardDatabase.CardName[69]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText13.text == CardDatabase.CardName[70]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText13.text == CardDatabase.CardName[71]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText13.text == CardDatabase.CardName[72]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText13.text == CardDatabase.CardName[73]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText13.text == CardDatabase.CardName[74]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText13.text == CardDatabase.CardName[75]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText13.text == CardDatabase.CardName[76]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText13.text == CardDatabase.CardName[77]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText13.text == CardDatabase.CardName[78]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText13.text == CardDatabase.CardName[79]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText13.text == CardDatabase.CardName[90]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText13.text == CardDatabase.CardName[91]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText13.text == CardDatabase.CardName[92]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText13.text == CardDatabase.CardName[93]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText13.text == CardDatabase.CardName[94]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText13.text == CardDatabase.CardName[95]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText13.text == CardDatabase.CardName[96]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText13.text == CardDatabase.CardName[97]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText13.text == CardDatabase.CardName[98]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText13.text == CardDatabase.CardName[99]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText13.text == CardDatabase.CardName[100]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText13.text == CardDatabase.CardName[113]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText13.text == CardDatabase.CardName[114]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText13.text == CardDatabase.CardName[115]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText13.text == CardDatabase.CardName[116]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText13.text == CardDatabase.CardName[117]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText13.text == CardDatabase.CardName[118]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText13.text == CardDatabase.CardName[122]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText13.text == CardDatabase.CardName[123]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText13.text == CardDatabase.CardName[124]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText13.text == CardDatabase.CardName[125]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText13.text == CardDatabase.CardName[126]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText13.text == CardDatabase.CardName[127]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText13.text == CardDatabase.CardName[128]) {
            DeckDownloaded13 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText14
        if (DeckText14.text == CardDatabase.CardName[0]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText14.text == CardDatabase.CardName[1]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText14.text == CardDatabase.CardName[2]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText14.text == CardDatabase.CardName[3]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText14.text == CardDatabase.CardName[4]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText14.text == CardDatabase.CardName[5]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText14.text == CardDatabase.CardName[6]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText14.text == CardDatabase.CardName[7]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText14.text == CardDatabase.CardName[8]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText14.text == CardDatabase.CardName[9]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText14.text == CardDatabase.CardName[10]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText14.text == CardDatabase.CardName[23]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText14.text == CardDatabase.CardName[24]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText14.text == CardDatabase.CardName[25]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText14.text == CardDatabase.CardName[26]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText14.text == CardDatabase.CardName[27]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText14.text == CardDatabase.CardName[28]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText14.text == CardDatabase.CardName[29]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText14.text == CardDatabase.CardName[30]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText14.text == CardDatabase.CardName[31]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText14.text == CardDatabase.CardName[32]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText14.text == CardDatabase.CardName[33]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText14.text == CardDatabase.CardName[45]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText14.text == CardDatabase.CardName[46]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText14.text == CardDatabase.CardName[47]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText14.text == CardDatabase.CardName[48]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText14.text == CardDatabase.CardName[49]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText14.text == CardDatabase.CardName[50]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText14.text == CardDatabase.CardName[51]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText14.text == CardDatabase.CardName[52]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText14.text == CardDatabase.CardName[53]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText14.text == CardDatabase.CardName[54]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText14.text == CardDatabase.CardName[55]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText14.text == CardDatabase.CardName[69]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText14.text == CardDatabase.CardName[70]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText14.text == CardDatabase.CardName[71]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText14.text == CardDatabase.CardName[72]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText14.text == CardDatabase.CardName[73]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText14.text == CardDatabase.CardName[74]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText14.text == CardDatabase.CardName[75]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText14.text == CardDatabase.CardName[76]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText14.text == CardDatabase.CardName[77]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText14.text == CardDatabase.CardName[78]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText14.text == CardDatabase.CardName[79]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText14.text == CardDatabase.CardName[90]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText14.text == CardDatabase.CardName[91]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText14.text == CardDatabase.CardName[92]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText14.text == CardDatabase.CardName[93]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText14.text == CardDatabase.CardName[94]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText14.text == CardDatabase.CardName[95]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText14.text == CardDatabase.CardName[96]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText14.text == CardDatabase.CardName[97]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText14.text == CardDatabase.CardName[98]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText14.text == CardDatabase.CardName[99]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText14.text == CardDatabase.CardName[100]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText14.text == CardDatabase.CardName[113]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText14.text == CardDatabase.CardName[114]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText14.text == CardDatabase.CardName[115]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText14.text == CardDatabase.CardName[116]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText14.text == CardDatabase.CardName[117]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText14.text == CardDatabase.CardName[118]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText14.text == CardDatabase.CardName[122]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText14.text == CardDatabase.CardName[123]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText14.text == CardDatabase.CardName[124]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText14.text == CardDatabase.CardName[125]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText14.text == CardDatabase.CardName[126]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText14.text == CardDatabase.CardName[127]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText14.text == CardDatabase.CardName[128]) {
            DeckDownloaded14 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText15
        if (DeckText15.text == CardDatabase.CardName[0]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText15.text == CardDatabase.CardName[1]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText15.text == CardDatabase.CardName[2]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText15.text == CardDatabase.CardName[3]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText15.text == CardDatabase.CardName[4]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText15.text == CardDatabase.CardName[5]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText15.text == CardDatabase.CardName[6]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText15.text == CardDatabase.CardName[7]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText15.text == CardDatabase.CardName[8]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText15.text == CardDatabase.CardName[9]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText15.text == CardDatabase.CardName[10]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText15.text == CardDatabase.CardName[23]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText15.text == CardDatabase.CardName[24]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText15.text == CardDatabase.CardName[25]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText15.text == CardDatabase.CardName[26]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText15.text == CardDatabase.CardName[27]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText15.text == CardDatabase.CardName[28]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText15.text == CardDatabase.CardName[29]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText15.text == CardDatabase.CardName[30]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText15.text == CardDatabase.CardName[31]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText15.text == CardDatabase.CardName[32]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText15.text == CardDatabase.CardName[33]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText15.text == CardDatabase.CardName[45]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText15.text == CardDatabase.CardName[46]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText15.text == CardDatabase.CardName[47]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText15.text == CardDatabase.CardName[48]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText15.text == CardDatabase.CardName[49]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText15.text == CardDatabase.CardName[50]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText15.text == CardDatabase.CardName[51]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText15.text == CardDatabase.CardName[52]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText15.text == CardDatabase.CardName[53]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText15.text == CardDatabase.CardName[54]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText15.text == CardDatabase.CardName[55]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText15.text == CardDatabase.CardName[69]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText15.text == CardDatabase.CardName[70]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText15.text == CardDatabase.CardName[71]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText15.text == CardDatabase.CardName[72]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText15.text == CardDatabase.CardName[73]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText15.text == CardDatabase.CardName[74]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText15.text == CardDatabase.CardName[75]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText15.text == CardDatabase.CardName[76]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText15.text == CardDatabase.CardName[77]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText15.text == CardDatabase.CardName[78]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText15.text == CardDatabase.CardName[79]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText15.text == CardDatabase.CardName[90]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText15.text == CardDatabase.CardName[91]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText15.text == CardDatabase.CardName[92]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText15.text == CardDatabase.CardName[93]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText15.text == CardDatabase.CardName[94]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText15.text == CardDatabase.CardName[95]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText15.text == CardDatabase.CardName[96]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText15.text == CardDatabase.CardName[97]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText15.text == CardDatabase.CardName[98]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText15.text == CardDatabase.CardName[99]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText15.text == CardDatabase.CardName[100]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText15.text == CardDatabase.CardName[113]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText15.text == CardDatabase.CardName[114]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText15.text == CardDatabase.CardName[115]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText15.text == CardDatabase.CardName[116]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText15.text == CardDatabase.CardName[117]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText15.text == CardDatabase.CardName[118]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText15.text == CardDatabase.CardName[122]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText15.text == CardDatabase.CardName[123]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText15.text == CardDatabase.CardName[124]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText15.text == CardDatabase.CardName[125]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText15.text == CardDatabase.CardName[126]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText15.text == CardDatabase.CardName[127]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText15.text == CardDatabase.CardName[128]) {
            DeckDownloaded15 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText16
        if (DeckText16.text == CardDatabase.CardName[0]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText16.text == CardDatabase.CardName[1]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText16.text == CardDatabase.CardName[2]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText16.text == CardDatabase.CardName[3]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText16.text == CardDatabase.CardName[4]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText16.text == CardDatabase.CardName[5]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText16.text == CardDatabase.CardName[6]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText16.text == CardDatabase.CardName[7]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText16.text == CardDatabase.CardName[8]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText16.text == CardDatabase.CardName[9]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText16.text == CardDatabase.CardName[10]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText16.text == CardDatabase.CardName[23]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText16.text == CardDatabase.CardName[24]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText16.text == CardDatabase.CardName[25]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText16.text == CardDatabase.CardName[26]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText16.text == CardDatabase.CardName[27]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText16.text == CardDatabase.CardName[28]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText16.text == CardDatabase.CardName[29]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText16.text == CardDatabase.CardName[30]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText16.text == CardDatabase.CardName[31]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText16.text == CardDatabase.CardName[32]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText16.text == CardDatabase.CardName[33]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText16.text == CardDatabase.CardName[45]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText16.text == CardDatabase.CardName[46]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText16.text == CardDatabase.CardName[47]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText16.text == CardDatabase.CardName[48]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText16.text == CardDatabase.CardName[49]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText16.text == CardDatabase.CardName[50]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText16.text == CardDatabase.CardName[51]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText16.text == CardDatabase.CardName[52]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText16.text == CardDatabase.CardName[53]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText16.text == CardDatabase.CardName[54]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText16.text == CardDatabase.CardName[55]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText16.text == CardDatabase.CardName[69]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText16.text == CardDatabase.CardName[70]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText16.text == CardDatabase.CardName[71]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText16.text == CardDatabase.CardName[72]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText16.text == CardDatabase.CardName[73]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText16.text == CardDatabase.CardName[74]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText16.text == CardDatabase.CardName[75]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText16.text == CardDatabase.CardName[76]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText16.text == CardDatabase.CardName[77]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText16.text == CardDatabase.CardName[78]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText16.text == CardDatabase.CardName[79]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText16.text == CardDatabase.CardName[90]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText16.text == CardDatabase.CardName[91]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText16.text == CardDatabase.CardName[92]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText16.text == CardDatabase.CardName[93]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText16.text == CardDatabase.CardName[94]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText16.text == CardDatabase.CardName[95]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText16.text == CardDatabase.CardName[96]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText16.text == CardDatabase.CardName[97]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText16.text == CardDatabase.CardName[98]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText16.text == CardDatabase.CardName[99]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText16.text == CardDatabase.CardName[100]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText16.text == CardDatabase.CardName[113]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText16.text == CardDatabase.CardName[114]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText16.text == CardDatabase.CardName[115]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText16.text == CardDatabase.CardName[116]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText16.text == CardDatabase.CardName[117]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText16.text == CardDatabase.CardName[118]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText16.text == CardDatabase.CardName[122]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText16.text == CardDatabase.CardName[123]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText16.text == CardDatabase.CardName[124]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText16.text == CardDatabase.CardName[125]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText16.text == CardDatabase.CardName[126]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText16.text == CardDatabase.CardName[127]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText16.text == CardDatabase.CardName[128]) {
            DeckDownloaded16 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText17
        if (DeckText17.text == CardDatabase.CardName[0]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText17.text == CardDatabase.CardName[1]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText17.text == CardDatabase.CardName[2]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText17.text == CardDatabase.CardName[3]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText17.text == CardDatabase.CardName[4]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText17.text == CardDatabase.CardName[5]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText17.text == CardDatabase.CardName[6]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText17.text == CardDatabase.CardName[7]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText17.text == CardDatabase.CardName[8]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText17.text == CardDatabase.CardName[9]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText17.text == CardDatabase.CardName[10]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText17.text == CardDatabase.CardName[23]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText17.text == CardDatabase.CardName[24]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText17.text == CardDatabase.CardName[25]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText17.text == CardDatabase.CardName[26]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText17.text == CardDatabase.CardName[27]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText17.text == CardDatabase.CardName[28]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText17.text == CardDatabase.CardName[29]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText17.text == CardDatabase.CardName[30]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText17.text == CardDatabase.CardName[31]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText17.text == CardDatabase.CardName[32]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText17.text == CardDatabase.CardName[33]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText17.text == CardDatabase.CardName[45]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText17.text == CardDatabase.CardName[46]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText17.text == CardDatabase.CardName[47]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText17.text == CardDatabase.CardName[48]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText17.text == CardDatabase.CardName[49]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText17.text == CardDatabase.CardName[50]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText17.text == CardDatabase.CardName[51]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText17.text == CardDatabase.CardName[52]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText17.text == CardDatabase.CardName[53]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText17.text == CardDatabase.CardName[54]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText17.text == CardDatabase.CardName[55]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText17.text == CardDatabase.CardName[69]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText17.text == CardDatabase.CardName[70]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText17.text == CardDatabase.CardName[71]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText17.text == CardDatabase.CardName[72]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText17.text == CardDatabase.CardName[73]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText17.text == CardDatabase.CardName[74]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText17.text == CardDatabase.CardName[75]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText17.text == CardDatabase.CardName[76]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText17.text == CardDatabase.CardName[77]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText17.text == CardDatabase.CardName[78]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText17.text == CardDatabase.CardName[79]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText17.text == CardDatabase.CardName[90]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText17.text == CardDatabase.CardName[91]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText17.text == CardDatabase.CardName[92]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText17.text == CardDatabase.CardName[93]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText17.text == CardDatabase.CardName[94]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText17.text == CardDatabase.CardName[95]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText17.text == CardDatabase.CardName[96]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText17.text == CardDatabase.CardName[97]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText17.text == CardDatabase.CardName[98]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText17.text == CardDatabase.CardName[99]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText17.text == CardDatabase.CardName[100]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText17.text == CardDatabase.CardName[113]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText17.text == CardDatabase.CardName[114]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText17.text == CardDatabase.CardName[115]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText17.text == CardDatabase.CardName[116]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText17.text == CardDatabase.CardName[117]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText17.text == CardDatabase.CardName[118]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText17.text == CardDatabase.CardName[122]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText17.text == CardDatabase.CardName[123]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText17.text == CardDatabase.CardName[124]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText17.text == CardDatabase.CardName[125]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText17.text == CardDatabase.CardName[126]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText17.text == CardDatabase.CardName[127]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText17.text == CardDatabase.CardName[128]) {
            DeckDownloaded17 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText18
        if (DeckText18.text == CardDatabase.CardName[0]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText18.text == CardDatabase.CardName[1]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText18.text == CardDatabase.CardName[2]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText18.text == CardDatabase.CardName[3]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText18.text == CardDatabase.CardName[4]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText18.text == CardDatabase.CardName[5]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText18.text == CardDatabase.CardName[6]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText18.text == CardDatabase.CardName[7]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText18.text == CardDatabase.CardName[8]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText18.text == CardDatabase.CardName[9]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText18.text == CardDatabase.CardName[10]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText18.text == CardDatabase.CardName[23]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText18.text == CardDatabase.CardName[24]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText18.text == CardDatabase.CardName[25]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText18.text == CardDatabase.CardName[26]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText18.text == CardDatabase.CardName[27]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText18.text == CardDatabase.CardName[28]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText18.text == CardDatabase.CardName[29]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText18.text == CardDatabase.CardName[30]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText18.text == CardDatabase.CardName[31]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText18.text == CardDatabase.CardName[32]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText18.text == CardDatabase.CardName[33]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText18.text == CardDatabase.CardName[45]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText18.text == CardDatabase.CardName[46]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText18.text == CardDatabase.CardName[47]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText18.text == CardDatabase.CardName[48]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText18.text == CardDatabase.CardName[49]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText18.text == CardDatabase.CardName[50]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText18.text == CardDatabase.CardName[51]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText18.text == CardDatabase.CardName[52]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText18.text == CardDatabase.CardName[53]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText18.text == CardDatabase.CardName[54]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText18.text == CardDatabase.CardName[55]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText18.text == CardDatabase.CardName[69]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText18.text == CardDatabase.CardName[70]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText18.text == CardDatabase.CardName[71]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText18.text == CardDatabase.CardName[72]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText18.text == CardDatabase.CardName[73]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText18.text == CardDatabase.CardName[74]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText18.text == CardDatabase.CardName[75]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText18.text == CardDatabase.CardName[76]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText18.text == CardDatabase.CardName[77]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText18.text == CardDatabase.CardName[78]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText18.text == CardDatabase.CardName[79]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText18.text == CardDatabase.CardName[90]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText18.text == CardDatabase.CardName[91]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText18.text == CardDatabase.CardName[92]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText18.text == CardDatabase.CardName[93]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText18.text == CardDatabase.CardName[94]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText18.text == CardDatabase.CardName[95]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText18.text == CardDatabase.CardName[96]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText18.text == CardDatabase.CardName[97]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText18.text == CardDatabase.CardName[98]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText18.text == CardDatabase.CardName[99]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText18.text == CardDatabase.CardName[100]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText18.text == CardDatabase.CardName[113]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText18.text == CardDatabase.CardName[114]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText18.text == CardDatabase.CardName[115]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText18.text == CardDatabase.CardName[116]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText18.text == CardDatabase.CardName[117]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText18.text == CardDatabase.CardName[118]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText18.text == CardDatabase.CardName[122]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText18.text == CardDatabase.CardName[123]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText18.text == CardDatabase.CardName[124]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText18.text == CardDatabase.CardName[125]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText18.text == CardDatabase.CardName[126]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText18.text == CardDatabase.CardName[127]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText18.text == CardDatabase.CardName[128]) {
            DeckDownloaded18 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText19
        if (DeckText19.text == CardDatabase.CardName[0]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText19.text == CardDatabase.CardName[1]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText19.text == CardDatabase.CardName[2]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText19.text == CardDatabase.CardName[3]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText19.text == CardDatabase.CardName[4]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText19.text == CardDatabase.CardName[5]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText19.text == CardDatabase.CardName[6]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText19.text == CardDatabase.CardName[7]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText19.text == CardDatabase.CardName[8]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText19.text == CardDatabase.CardName[9]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText19.text == CardDatabase.CardName[10]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText19.text == CardDatabase.CardName[23]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText19.text == CardDatabase.CardName[24]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText19.text == CardDatabase.CardName[25]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText19.text == CardDatabase.CardName[26]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText19.text == CardDatabase.CardName[27]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText19.text == CardDatabase.CardName[28]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText19.text == CardDatabase.CardName[29]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText19.text == CardDatabase.CardName[30]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText19.text == CardDatabase.CardName[31]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText19.text == CardDatabase.CardName[32]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText19.text == CardDatabase.CardName[33]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText19.text == CardDatabase.CardName[45]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText19.text == CardDatabase.CardName[46]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText19.text == CardDatabase.CardName[47]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText19.text == CardDatabase.CardName[48]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText19.text == CardDatabase.CardName[49]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText19.text == CardDatabase.CardName[50]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText19.text == CardDatabase.CardName[51]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText19.text == CardDatabase.CardName[52]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText19.text == CardDatabase.CardName[53]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText19.text == CardDatabase.CardName[54]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText19.text == CardDatabase.CardName[55]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText19.text == CardDatabase.CardName[69]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText19.text == CardDatabase.CardName[70]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText19.text == CardDatabase.CardName[71]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText19.text == CardDatabase.CardName[72]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText19.text == CardDatabase.CardName[73]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText19.text == CardDatabase.CardName[74]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText19.text == CardDatabase.CardName[75]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText19.text == CardDatabase.CardName[76]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText19.text == CardDatabase.CardName[77]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText19.text == CardDatabase.CardName[78]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText19.text == CardDatabase.CardName[79]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText19.text == CardDatabase.CardName[90]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText19.text == CardDatabase.CardName[91]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText19.text == CardDatabase.CardName[92]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText19.text == CardDatabase.CardName[93]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText19.text == CardDatabase.CardName[94]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText19.text == CardDatabase.CardName[95]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText19.text == CardDatabase.CardName[96]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText19.text == CardDatabase.CardName[97]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText19.text == CardDatabase.CardName[98]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText19.text == CardDatabase.CardName[99]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText19.text == CardDatabase.CardName[100]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText19.text == CardDatabase.CardName[113]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText19.text == CardDatabase.CardName[114]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText19.text == CardDatabase.CardName[115]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText19.text == CardDatabase.CardName[116]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText19.text == CardDatabase.CardName[117]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText19.text == CardDatabase.CardName[118]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText19.text == CardDatabase.CardName[122]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText19.text == CardDatabase.CardName[123]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText19.text == CardDatabase.CardName[124]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText19.text == CardDatabase.CardName[125]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText19.text == CardDatabase.CardName[126]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText19.text == CardDatabase.CardName[127]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText19.text == CardDatabase.CardName[128]) {
            DeckDownloaded19 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText20
        if (DeckText20.text == CardDatabase.CardName[0]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText20.text == CardDatabase.CardName[1]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText20.text == CardDatabase.CardName[2]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText20.text == CardDatabase.CardName[3]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText20.text == CardDatabase.CardName[4]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText20.text == CardDatabase.CardName[5]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText20.text == CardDatabase.CardName[6]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText20.text == CardDatabase.CardName[7]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText20.text == CardDatabase.CardName[8]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText20.text == CardDatabase.CardName[9]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText20.text == CardDatabase.CardName[10]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText20.text == CardDatabase.CardName[23]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText20.text == CardDatabase.CardName[24]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText20.text == CardDatabase.CardName[25]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText20.text == CardDatabase.CardName[26]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText20.text == CardDatabase.CardName[27]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText20.text == CardDatabase.CardName[28]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText20.text == CardDatabase.CardName[29]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText20.text == CardDatabase.CardName[30]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText20.text == CardDatabase.CardName[31]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText20.text == CardDatabase.CardName[32]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText20.text == CardDatabase.CardName[33]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText20.text == CardDatabase.CardName[45]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText20.text == CardDatabase.CardName[46]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText20.text == CardDatabase.CardName[47]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText20.text == CardDatabase.CardName[48]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText20.text == CardDatabase.CardName[49]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText20.text == CardDatabase.CardName[50]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText20.text == CardDatabase.CardName[51]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText20.text == CardDatabase.CardName[52]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText20.text == CardDatabase.CardName[53]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText20.text == CardDatabase.CardName[54]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText20.text == CardDatabase.CardName[55]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText20.text == CardDatabase.CardName[69]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText20.text == CardDatabase.CardName[70]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText20.text == CardDatabase.CardName[71]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText20.text == CardDatabase.CardName[72]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText20.text == CardDatabase.CardName[73]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText20.text == CardDatabase.CardName[74]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText20.text == CardDatabase.CardName[75]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText20.text == CardDatabase.CardName[76]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText20.text == CardDatabase.CardName[77]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText20.text == CardDatabase.CardName[78]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText20.text == CardDatabase.CardName[79]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText20.text == CardDatabase.CardName[90]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText20.text == CardDatabase.CardName[91]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText20.text == CardDatabase.CardName[92]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText20.text == CardDatabase.CardName[93]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText20.text == CardDatabase.CardName[94]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText20.text == CardDatabase.CardName[95]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText20.text == CardDatabase.CardName[96]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText20.text == CardDatabase.CardName[97]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText20.text == CardDatabase.CardName[98]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText20.text == CardDatabase.CardName[99]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText20.text == CardDatabase.CardName[100]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText20.text == CardDatabase.CardName[113]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText20.text == CardDatabase.CardName[114]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText20.text == CardDatabase.CardName[115]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText20.text == CardDatabase.CardName[116]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText20.text == CardDatabase.CardName[117]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText20.text == CardDatabase.CardName[118]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText20.text == CardDatabase.CardName[122]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText20.text == CardDatabase.CardName[123]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText20.text == CardDatabase.CardName[124]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText20.text == CardDatabase.CardName[125]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText20.text == CardDatabase.CardName[126]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText20.text == CardDatabase.CardName[127]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText20.text == CardDatabase.CardName[128]) {
            DeckDownloaded20 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText21
        if (DeckText21.text == CardDatabase.CardName[0]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText21.text == CardDatabase.CardName[1]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText21.text == CardDatabase.CardName[2]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText21.text == CardDatabase.CardName[3]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText21.text == CardDatabase.CardName[4]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText21.text == CardDatabase.CardName[5]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText21.text == CardDatabase.CardName[6]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText21.text == CardDatabase.CardName[7]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText21.text == CardDatabase.CardName[8]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText21.text == CardDatabase.CardName[9]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText21.text == CardDatabase.CardName[10]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText21.text == CardDatabase.CardName[23]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText21.text == CardDatabase.CardName[24]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText21.text == CardDatabase.CardName[25]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText21.text == CardDatabase.CardName[26]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText21.text == CardDatabase.CardName[27]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText21.text == CardDatabase.CardName[28]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText21.text == CardDatabase.CardName[29]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText21.text == CardDatabase.CardName[30]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText21.text == CardDatabase.CardName[31]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText21.text == CardDatabase.CardName[32]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText21.text == CardDatabase.CardName[33]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText21.text == CardDatabase.CardName[45]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText21.text == CardDatabase.CardName[46]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText21.text == CardDatabase.CardName[47]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText21.text == CardDatabase.CardName[48]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText21.text == CardDatabase.CardName[49]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText21.text == CardDatabase.CardName[50]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText21.text == CardDatabase.CardName[51]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText21.text == CardDatabase.CardName[52]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText21.text == CardDatabase.CardName[53]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText21.text == CardDatabase.CardName[54]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText21.text == CardDatabase.CardName[55]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText21.text == CardDatabase.CardName[69]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText21.text == CardDatabase.CardName[70]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText21.text == CardDatabase.CardName[71]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText21.text == CardDatabase.CardName[72]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText21.text == CardDatabase.CardName[73]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText21.text == CardDatabase.CardName[74]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText21.text == CardDatabase.CardName[75]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText21.text == CardDatabase.CardName[76]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText21.text == CardDatabase.CardName[77]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText21.text == CardDatabase.CardName[78]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText21.text == CardDatabase.CardName[79]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText21.text == CardDatabase.CardName[90]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText21.text == CardDatabase.CardName[91]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText21.text == CardDatabase.CardName[92]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText21.text == CardDatabase.CardName[93]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText21.text == CardDatabase.CardName[94]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText21.text == CardDatabase.CardName[95]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText21.text == CardDatabase.CardName[96]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText21.text == CardDatabase.CardName[97]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText21.text == CardDatabase.CardName[98]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText21.text == CardDatabase.CardName[99]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText21.text == CardDatabase.CardName[100]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText21.text == CardDatabase.CardName[113]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText21.text == CardDatabase.CardName[114]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText21.text == CardDatabase.CardName[115]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText21.text == CardDatabase.CardName[116]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText21.text == CardDatabase.CardName[117]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText21.text == CardDatabase.CardName[118]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText21.text == CardDatabase.CardName[122]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText21.text == CardDatabase.CardName[123]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText21.text == CardDatabase.CardName[124]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText21.text == CardDatabase.CardName[125]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText21.text == CardDatabase.CardName[126]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText21.text == CardDatabase.CardName[127]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText21.text == CardDatabase.CardName[128]) {
            DeckDownloaded21 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText22
        if (DeckText22.text == CardDatabase.CardName[0]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText22.text == CardDatabase.CardName[1]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText22.text == CardDatabase.CardName[2]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText22.text == CardDatabase.CardName[3]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText22.text == CardDatabase.CardName[4]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText22.text == CardDatabase.CardName[5]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText22.text == CardDatabase.CardName[6]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText22.text == CardDatabase.CardName[7]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText22.text == CardDatabase.CardName[8]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText22.text == CardDatabase.CardName[9]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText22.text == CardDatabase.CardName[10]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText22.text == CardDatabase.CardName[23]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText22.text == CardDatabase.CardName[24]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText22.text == CardDatabase.CardName[25]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText22.text == CardDatabase.CardName[26]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText22.text == CardDatabase.CardName[27]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText22.text == CardDatabase.CardName[28]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText22.text == CardDatabase.CardName[29]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText22.text == CardDatabase.CardName[30]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText22.text == CardDatabase.CardName[31]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText22.text == CardDatabase.CardName[32]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText22.text == CardDatabase.CardName[33]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText22.text == CardDatabase.CardName[45]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText22.text == CardDatabase.CardName[46]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText22.text == CardDatabase.CardName[47]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText22.text == CardDatabase.CardName[48]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText22.text == CardDatabase.CardName[49]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText22.text == CardDatabase.CardName[50]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText22.text == CardDatabase.CardName[51]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText22.text == CardDatabase.CardName[52]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText22.text == CardDatabase.CardName[53]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText22.text == CardDatabase.CardName[54]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText22.text == CardDatabase.CardName[55]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText22.text == CardDatabase.CardName[69]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText22.text == CardDatabase.CardName[70]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText22.text == CardDatabase.CardName[71]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText22.text == CardDatabase.CardName[72]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText22.text == CardDatabase.CardName[73]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText22.text == CardDatabase.CardName[74]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText22.text == CardDatabase.CardName[75]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText22.text == CardDatabase.CardName[76]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText22.text == CardDatabase.CardName[77]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText22.text == CardDatabase.CardName[78]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText22.text == CardDatabase.CardName[79]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText22.text == CardDatabase.CardName[90]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText22.text == CardDatabase.CardName[91]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText22.text == CardDatabase.CardName[92]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText22.text == CardDatabase.CardName[93]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText22.text == CardDatabase.CardName[94]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText22.text == CardDatabase.CardName[95]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText22.text == CardDatabase.CardName[96]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText22.text == CardDatabase.CardName[97]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText22.text == CardDatabase.CardName[98]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText22.text == CardDatabase.CardName[99]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText22.text == CardDatabase.CardName[100]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText22.text == CardDatabase.CardName[113]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText22.text == CardDatabase.CardName[114]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText22.text == CardDatabase.CardName[115]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText22.text == CardDatabase.CardName[116]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText22.text == CardDatabase.CardName[117]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText22.text == CardDatabase.CardName[118]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText22.text == CardDatabase.CardName[122]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText22.text == CardDatabase.CardName[123]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText22.text == CardDatabase.CardName[124]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText22.text == CardDatabase.CardName[125]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText22.text == CardDatabase.CardName[126]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText22.text == CardDatabase.CardName[127]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText22.text == CardDatabase.CardName[128]) {
            DeckDownloaded22 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText23
        if (DeckText23.text == CardDatabase.CardName[0]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText23.text == CardDatabase.CardName[1]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText23.text == CardDatabase.CardName[2]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText23.text == CardDatabase.CardName[3]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText23.text == CardDatabase.CardName[4]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText23.text == CardDatabase.CardName[5]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText23.text == CardDatabase.CardName[6]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText23.text == CardDatabase.CardName[7]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText23.text == CardDatabase.CardName[8]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText23.text == CardDatabase.CardName[9]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText23.text == CardDatabase.CardName[10]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText23.text == CardDatabase.CardName[23]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText23.text == CardDatabase.CardName[24]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText23.text == CardDatabase.CardName[25]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText23.text == CardDatabase.CardName[26]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText23.text == CardDatabase.CardName[27]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText23.text == CardDatabase.CardName[28]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText23.text == CardDatabase.CardName[29]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText23.text == CardDatabase.CardName[30]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText23.text == CardDatabase.CardName[31]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText23.text == CardDatabase.CardName[32]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText23.text == CardDatabase.CardName[33]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText23.text == CardDatabase.CardName[45]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText23.text == CardDatabase.CardName[46]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText23.text == CardDatabase.CardName[47]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText23.text == CardDatabase.CardName[48]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText23.text == CardDatabase.CardName[49]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText23.text == CardDatabase.CardName[50]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText23.text == CardDatabase.CardName[51]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText23.text == CardDatabase.CardName[52]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText23.text == CardDatabase.CardName[53]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText23.text == CardDatabase.CardName[54]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText23.text == CardDatabase.CardName[55]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText23.text == CardDatabase.CardName[69]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText23.text == CardDatabase.CardName[70]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText23.text == CardDatabase.CardName[71]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText23.text == CardDatabase.CardName[72]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText23.text == CardDatabase.CardName[73]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText23.text == CardDatabase.CardName[74]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText23.text == CardDatabase.CardName[75]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText23.text == CardDatabase.CardName[76]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText23.text == CardDatabase.CardName[77]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText23.text == CardDatabase.CardName[78]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText23.text == CardDatabase.CardName[79]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText23.text == CardDatabase.CardName[90]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText23.text == CardDatabase.CardName[91]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText23.text == CardDatabase.CardName[92]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText23.text == CardDatabase.CardName[93]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText23.text == CardDatabase.CardName[94]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText23.text == CardDatabase.CardName[95]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText23.text == CardDatabase.CardName[96]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText23.text == CardDatabase.CardName[97]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText23.text == CardDatabase.CardName[98]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText23.text == CardDatabase.CardName[99]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText23.text == CardDatabase.CardName[100]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText23.text == CardDatabase.CardName[113]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText23.text == CardDatabase.CardName[114]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText23.text == CardDatabase.CardName[115]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText23.text == CardDatabase.CardName[116]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText23.text == CardDatabase.CardName[117]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText23.text == CardDatabase.CardName[118]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText23.text == CardDatabase.CardName[122]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText23.text == CardDatabase.CardName[123]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText23.text == CardDatabase.CardName[124]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText23.text == CardDatabase.CardName[125]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText23.text == CardDatabase.CardName[126]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText23.text == CardDatabase.CardName[127]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText23.text == CardDatabase.CardName[128]) {
            DeckDownloaded23 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText24
        if (DeckText24.text == CardDatabase.CardName[0]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText24.text == CardDatabase.CardName[1]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText24.text == CardDatabase.CardName[2]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText24.text == CardDatabase.CardName[3]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText24.text == CardDatabase.CardName[4]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText24.text == CardDatabase.CardName[5]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText24.text == CardDatabase.CardName[6]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText24.text == CardDatabase.CardName[7]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText24.text == CardDatabase.CardName[8]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText24.text == CardDatabase.CardName[9]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText24.text == CardDatabase.CardName[10]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText24.text == CardDatabase.CardName[23]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText24.text == CardDatabase.CardName[24]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText24.text == CardDatabase.CardName[25]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText24.text == CardDatabase.CardName[26]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText24.text == CardDatabase.CardName[27]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText24.text == CardDatabase.CardName[28]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText24.text == CardDatabase.CardName[29]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText24.text == CardDatabase.CardName[30]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText24.text == CardDatabase.CardName[31]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText24.text == CardDatabase.CardName[32]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText24.text == CardDatabase.CardName[33]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText24.text == CardDatabase.CardName[45]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText24.text == CardDatabase.CardName[46]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText24.text == CardDatabase.CardName[47]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText24.text == CardDatabase.CardName[48]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText24.text == CardDatabase.CardName[49]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText24.text == CardDatabase.CardName[50]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText24.text == CardDatabase.CardName[51]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText24.text == CardDatabase.CardName[52]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText24.text == CardDatabase.CardName[53]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText24.text == CardDatabase.CardName[54]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText24.text == CardDatabase.CardName[55]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText24.text == CardDatabase.CardName[69]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText24.text == CardDatabase.CardName[70]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText24.text == CardDatabase.CardName[71]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText24.text == CardDatabase.CardName[72]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText24.text == CardDatabase.CardName[73]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText24.text == CardDatabase.CardName[74]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText24.text == CardDatabase.CardName[75]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText24.text == CardDatabase.CardName[76]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText24.text == CardDatabase.CardName[77]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText24.text == CardDatabase.CardName[78]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText24.text == CardDatabase.CardName[79]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText24.text == CardDatabase.CardName[90]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText24.text == CardDatabase.CardName[91]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText24.text == CardDatabase.CardName[92]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText24.text == CardDatabase.CardName[93]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText24.text == CardDatabase.CardName[94]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText24.text == CardDatabase.CardName[95]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText24.text == CardDatabase.CardName[96]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText24.text == CardDatabase.CardName[97]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText24.text == CardDatabase.CardName[98]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText24.text == CardDatabase.CardName[99]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText24.text == CardDatabase.CardName[100]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText24.text == CardDatabase.CardName[113]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText24.text == CardDatabase.CardName[114]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText24.text == CardDatabase.CardName[115]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText24.text == CardDatabase.CardName[116]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText24.text == CardDatabase.CardName[117]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText24.text == CardDatabase.CardName[118]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText24.text == CardDatabase.CardName[122]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText24.text == CardDatabase.CardName[123]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText24.text == CardDatabase.CardName[124]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText24.text == CardDatabase.CardName[125]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText24.text == CardDatabase.CardName[126]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText24.text == CardDatabase.CardName[127]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText24.text == CardDatabase.CardName[128]) {
            DeckDownloaded24 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText25
        if (DeckText25.text == CardDatabase.CardName[0]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText25.text == CardDatabase.CardName[1]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText25.text == CardDatabase.CardName[2]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText25.text == CardDatabase.CardName[3]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText25.text == CardDatabase.CardName[4]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText25.text == CardDatabase.CardName[5]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText25.text == CardDatabase.CardName[6]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText25.text == CardDatabase.CardName[7]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText25.text == CardDatabase.CardName[8]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText25.text == CardDatabase.CardName[9]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText25.text == CardDatabase.CardName[10]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText25.text == CardDatabase.CardName[23]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText25.text == CardDatabase.CardName[24]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText25.text == CardDatabase.CardName[25]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText25.text == CardDatabase.CardName[26]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText25.text == CardDatabase.CardName[27]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText25.text == CardDatabase.CardName[28]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText25.text == CardDatabase.CardName[29]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText25.text == CardDatabase.CardName[30]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText25.text == CardDatabase.CardName[31]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText25.text == CardDatabase.CardName[32]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText25.text == CardDatabase.CardName[33]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText25.text == CardDatabase.CardName[45]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText25.text == CardDatabase.CardName[46]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText25.text == CardDatabase.CardName[47]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText25.text == CardDatabase.CardName[48]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText25.text == CardDatabase.CardName[49]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText25.text == CardDatabase.CardName[50]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText25.text == CardDatabase.CardName[51]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText25.text == CardDatabase.CardName[52]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText25.text == CardDatabase.CardName[53]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText25.text == CardDatabase.CardName[54]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText25.text == CardDatabase.CardName[55]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText25.text == CardDatabase.CardName[69]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText25.text == CardDatabase.CardName[70]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText25.text == CardDatabase.CardName[71]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText25.text == CardDatabase.CardName[72]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText25.text == CardDatabase.CardName[73]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText25.text == CardDatabase.CardName[74]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText25.text == CardDatabase.CardName[75]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText25.text == CardDatabase.CardName[76]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText25.text == CardDatabase.CardName[77]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText25.text == CardDatabase.CardName[78]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText25.text == CardDatabase.CardName[79]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText25.text == CardDatabase.CardName[90]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText25.text == CardDatabase.CardName[91]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText25.text == CardDatabase.CardName[92]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText25.text == CardDatabase.CardName[93]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText25.text == CardDatabase.CardName[94]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText25.text == CardDatabase.CardName[95]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText25.text == CardDatabase.CardName[96]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText25.text == CardDatabase.CardName[97]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText25.text == CardDatabase.CardName[98]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText25.text == CardDatabase.CardName[99]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText25.text == CardDatabase.CardName[100]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText25.text == CardDatabase.CardName[113]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText25.text == CardDatabase.CardName[114]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText25.text == CardDatabase.CardName[115]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText25.text == CardDatabase.CardName[116]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText25.text == CardDatabase.CardName[117]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText25.text == CardDatabase.CardName[118]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText25.text == CardDatabase.CardName[122]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText25.text == CardDatabase.CardName[123]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText25.text == CardDatabase.CardName[124]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText25.text == CardDatabase.CardName[125]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText25.text == CardDatabase.CardName[126]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText25.text == CardDatabase.CardName[127]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText25.text == CardDatabase.CardName[128]) {
            DeckDownloaded25 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText26
        if (DeckText26.text == CardDatabase.CardName[0]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText26.text == CardDatabase.CardName[1]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText26.text == CardDatabase.CardName[2]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText26.text == CardDatabase.CardName[3]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText26.text == CardDatabase.CardName[4]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText26.text == CardDatabase.CardName[5]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText26.text == CardDatabase.CardName[6]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText26.text == CardDatabase.CardName[7]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText26.text == CardDatabase.CardName[8]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText26.text == CardDatabase.CardName[9]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText26.text == CardDatabase.CardName[10]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText26.text == CardDatabase.CardName[23]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText26.text == CardDatabase.CardName[24]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText26.text == CardDatabase.CardName[25]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText26.text == CardDatabase.CardName[26]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText26.text == CardDatabase.CardName[27]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText26.text == CardDatabase.CardName[28]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText26.text == CardDatabase.CardName[29]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText26.text == CardDatabase.CardName[30]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText26.text == CardDatabase.CardName[31]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText26.text == CardDatabase.CardName[32]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText26.text == CardDatabase.CardName[33]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText26.text == CardDatabase.CardName[45]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText26.text == CardDatabase.CardName[46]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText26.text == CardDatabase.CardName[47]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText26.text == CardDatabase.CardName[48]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText26.text == CardDatabase.CardName[49]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText26.text == CardDatabase.CardName[50]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText26.text == CardDatabase.CardName[51]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText26.text == CardDatabase.CardName[52]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText26.text == CardDatabase.CardName[53]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText26.text == CardDatabase.CardName[54]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText26.text == CardDatabase.CardName[55]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText26.text == CardDatabase.CardName[69]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText26.text == CardDatabase.CardName[70]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText26.text == CardDatabase.CardName[71]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText26.text == CardDatabase.CardName[72]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText26.text == CardDatabase.CardName[73]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText26.text == CardDatabase.CardName[74]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText26.text == CardDatabase.CardName[75]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText26.text == CardDatabase.CardName[76]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText26.text == CardDatabase.CardName[77]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText26.text == CardDatabase.CardName[78]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText26.text == CardDatabase.CardName[79]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText26.text == CardDatabase.CardName[90]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText26.text == CardDatabase.CardName[91]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText26.text == CardDatabase.CardName[92]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText26.text == CardDatabase.CardName[93]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText26.text == CardDatabase.CardName[94]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText26.text == CardDatabase.CardName[95]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText26.text == CardDatabase.CardName[96]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText26.text == CardDatabase.CardName[97]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText26.text == CardDatabase.CardName[98]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText26.text == CardDatabase.CardName[99]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText26.text == CardDatabase.CardName[100]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText26.text == CardDatabase.CardName[113]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText26.text == CardDatabase.CardName[114]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText26.text == CardDatabase.CardName[115]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText26.text == CardDatabase.CardName[116]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText26.text == CardDatabase.CardName[117]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText26.text == CardDatabase.CardName[118]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText26.text == CardDatabase.CardName[122]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText26.text == CardDatabase.CardName[123]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText26.text == CardDatabase.CardName[124]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText26.text == CardDatabase.CardName[125]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText26.text == CardDatabase.CardName[126]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText26.text == CardDatabase.CardName[127]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText26.text == CardDatabase.CardName[128]) {
            DeckDownloaded26 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText27
        if (DeckText27.text == CardDatabase.CardName[0]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText27.text == CardDatabase.CardName[1]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText27.text == CardDatabase.CardName[2]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText27.text == CardDatabase.CardName[3]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText27.text == CardDatabase.CardName[4]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText27.text == CardDatabase.CardName[5]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText27.text == CardDatabase.CardName[6]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText27.text == CardDatabase.CardName[7]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText27.text == CardDatabase.CardName[8]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText27.text == CardDatabase.CardName[9]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText27.text == CardDatabase.CardName[10]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText27.text == CardDatabase.CardName[23]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText27.text == CardDatabase.CardName[24]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText27.text == CardDatabase.CardName[25]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText27.text == CardDatabase.CardName[26]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText27.text == CardDatabase.CardName[27]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText27.text == CardDatabase.CardName[28]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText27.text == CardDatabase.CardName[29]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText27.text == CardDatabase.CardName[30]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText27.text == CardDatabase.CardName[31]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText27.text == CardDatabase.CardName[32]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText27.text == CardDatabase.CardName[33]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText27.text == CardDatabase.CardName[45]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText27.text == CardDatabase.CardName[46]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText27.text == CardDatabase.CardName[47]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText27.text == CardDatabase.CardName[48]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText27.text == CardDatabase.CardName[49]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText27.text == CardDatabase.CardName[50]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText27.text == CardDatabase.CardName[51]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText27.text == CardDatabase.CardName[52]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText27.text == CardDatabase.CardName[53]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText27.text == CardDatabase.CardName[54]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText27.text == CardDatabase.CardName[55]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText27.text == CardDatabase.CardName[69]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText27.text == CardDatabase.CardName[70]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText27.text == CardDatabase.CardName[71]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText27.text == CardDatabase.CardName[72]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText27.text == CardDatabase.CardName[73]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText27.text == CardDatabase.CardName[74]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText27.text == CardDatabase.CardName[75]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText27.text == CardDatabase.CardName[76]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText27.text == CardDatabase.CardName[77]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText27.text == CardDatabase.CardName[78]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText27.text == CardDatabase.CardName[79]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText27.text == CardDatabase.CardName[90]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText27.text == CardDatabase.CardName[91]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText27.text == CardDatabase.CardName[92]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText27.text == CardDatabase.CardName[93]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText27.text == CardDatabase.CardName[94]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText27.text == CardDatabase.CardName[95]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText27.text == CardDatabase.CardName[96]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText27.text == CardDatabase.CardName[97]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText27.text == CardDatabase.CardName[98]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText27.text == CardDatabase.CardName[99]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText27.text == CardDatabase.CardName[100]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText27.text == CardDatabase.CardName[113]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText27.text == CardDatabase.CardName[114]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText27.text == CardDatabase.CardName[115]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText27.text == CardDatabase.CardName[116]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText27.text == CardDatabase.CardName[117]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText27.text == CardDatabase.CardName[118]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText27.text == CardDatabase.CardName[122]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText27.text == CardDatabase.CardName[123]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText27.text == CardDatabase.CardName[124]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText27.text == CardDatabase.CardName[125]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText27.text == CardDatabase.CardName[126]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText27.text == CardDatabase.CardName[127]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText27.text == CardDatabase.CardName[128]) {
            DeckDownloaded27 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText28
        if (DeckText28.text == CardDatabase.CardName[0]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText28.text == CardDatabase.CardName[1]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText28.text == CardDatabase.CardName[2]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText28.text == CardDatabase.CardName[3]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText28.text == CardDatabase.CardName[4]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText28.text == CardDatabase.CardName[5]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText28.text == CardDatabase.CardName[6]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText28.text == CardDatabase.CardName[7]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText28.text == CardDatabase.CardName[8]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText28.text == CardDatabase.CardName[9]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText28.text == CardDatabase.CardName[10]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText28.text == CardDatabase.CardName[23]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText28.text == CardDatabase.CardName[24]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText28.text == CardDatabase.CardName[25]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText28.text == CardDatabase.CardName[26]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText28.text == CardDatabase.CardName[27]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText28.text == CardDatabase.CardName[28]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText28.text == CardDatabase.CardName[29]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText28.text == CardDatabase.CardName[30]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText28.text == CardDatabase.CardName[31]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText28.text == CardDatabase.CardName[32]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText28.text == CardDatabase.CardName[33]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText28.text == CardDatabase.CardName[45]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText28.text == CardDatabase.CardName[46]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText28.text == CardDatabase.CardName[47]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText28.text == CardDatabase.CardName[48]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText28.text == CardDatabase.CardName[49]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText28.text == CardDatabase.CardName[50]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText28.text == CardDatabase.CardName[51]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText28.text == CardDatabase.CardName[52]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText28.text == CardDatabase.CardName[53]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText28.text == CardDatabase.CardName[54]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText28.text == CardDatabase.CardName[55]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText28.text == CardDatabase.CardName[69]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText28.text == CardDatabase.CardName[70]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText28.text == CardDatabase.CardName[71]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText28.text == CardDatabase.CardName[72]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText28.text == CardDatabase.CardName[73]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText28.text == CardDatabase.CardName[74]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText28.text == CardDatabase.CardName[75]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText28.text == CardDatabase.CardName[76]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText28.text == CardDatabase.CardName[77]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText28.text == CardDatabase.CardName[78]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText28.text == CardDatabase.CardName[79]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText28.text == CardDatabase.CardName[90]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText28.text == CardDatabase.CardName[91]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText28.text == CardDatabase.CardName[92]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText28.text == CardDatabase.CardName[93]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText28.text == CardDatabase.CardName[94]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText28.text == CardDatabase.CardName[95]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText28.text == CardDatabase.CardName[96]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText28.text == CardDatabase.CardName[97]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText28.text == CardDatabase.CardName[98]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText28.text == CardDatabase.CardName[99]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText28.text == CardDatabase.CardName[100]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText28.text == CardDatabase.CardName[113]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText28.text == CardDatabase.CardName[114]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText28.text == CardDatabase.CardName[115]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText28.text == CardDatabase.CardName[116]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText28.text == CardDatabase.CardName[117]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText28.text == CardDatabase.CardName[118]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText28.text == CardDatabase.CardName[122]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText28.text == CardDatabase.CardName[123]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText28.text == CardDatabase.CardName[124]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText28.text == CardDatabase.CardName[125]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText28.text == CardDatabase.CardName[126]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText28.text == CardDatabase.CardName[127]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText28.text == CardDatabase.CardName[128]) {
            DeckDownloaded28 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText29
        if (DeckText29.text == CardDatabase.CardName[0]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText29.text == CardDatabase.CardName[1]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText29.text == CardDatabase.CardName[2]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText29.text == CardDatabase.CardName[3]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText29.text == CardDatabase.CardName[4]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText29.text == CardDatabase.CardName[5]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText29.text == CardDatabase.CardName[6]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText29.text == CardDatabase.CardName[7]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText29.text == CardDatabase.CardName[8]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText29.text == CardDatabase.CardName[9]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText29.text == CardDatabase.CardName[10]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText29.text == CardDatabase.CardName[23]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText29.text == CardDatabase.CardName[24]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText29.text == CardDatabase.CardName[25]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText29.text == CardDatabase.CardName[26]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText29.text == CardDatabase.CardName[27]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText29.text == CardDatabase.CardName[28]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText29.text == CardDatabase.CardName[29]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText29.text == CardDatabase.CardName[30]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText29.text == CardDatabase.CardName[31]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText29.text == CardDatabase.CardName[32]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText29.text == CardDatabase.CardName[33]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText29.text == CardDatabase.CardName[45]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText29.text == CardDatabase.CardName[46]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText29.text == CardDatabase.CardName[47]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText29.text == CardDatabase.CardName[48]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText29.text == CardDatabase.CardName[49]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText29.text == CardDatabase.CardName[50]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText29.text == CardDatabase.CardName[51]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText29.text == CardDatabase.CardName[52]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText29.text == CardDatabase.CardName[53]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText29.text == CardDatabase.CardName[54]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText29.text == CardDatabase.CardName[55]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText29.text == CardDatabase.CardName[69]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText29.text == CardDatabase.CardName[70]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText29.text == CardDatabase.CardName[71]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText29.text == CardDatabase.CardName[72]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText29.text == CardDatabase.CardName[73]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText29.text == CardDatabase.CardName[74]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText29.text == CardDatabase.CardName[75]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText29.text == CardDatabase.CardName[76]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText29.text == CardDatabase.CardName[77]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText29.text == CardDatabase.CardName[78]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText29.text == CardDatabase.CardName[79]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText29.text == CardDatabase.CardName[90]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText29.text == CardDatabase.CardName[91]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText29.text == CardDatabase.CardName[92]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText29.text == CardDatabase.CardName[93]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText29.text == CardDatabase.CardName[94]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText29.text == CardDatabase.CardName[95]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText29.text == CardDatabase.CardName[96]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText29.text == CardDatabase.CardName[97]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText29.text == CardDatabase.CardName[98]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText29.text == CardDatabase.CardName[99]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText29.text == CardDatabase.CardName[100]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText29.text == CardDatabase.CardName[113]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText29.text == CardDatabase.CardName[114]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText29.text == CardDatabase.CardName[115]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText29.text == CardDatabase.CardName[116]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText29.text == CardDatabase.CardName[117]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText29.text == CardDatabase.CardName[118]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText29.text == CardDatabase.CardName[122]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText29.text == CardDatabase.CardName[123]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText29.text == CardDatabase.CardName[124]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText29.text == CardDatabase.CardName[125]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText29.text == CardDatabase.CardName[126]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText29.text == CardDatabase.CardName[127]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText29.text == CardDatabase.CardName[128]) {
            DeckDownloaded29 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText30
        if (DeckText30.text == CardDatabase.CardName[0]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText30.text == CardDatabase.CardName[1]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText30.text == CardDatabase.CardName[2]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText30.text == CardDatabase.CardName[3]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText30.text == CardDatabase.CardName[4]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText30.text == CardDatabase.CardName[5]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText30.text == CardDatabase.CardName[6]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText30.text == CardDatabase.CardName[7]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText30.text == CardDatabase.CardName[8]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText30.text == CardDatabase.CardName[9]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText30.text == CardDatabase.CardName[10]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText30.text == CardDatabase.CardName[23]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText30.text == CardDatabase.CardName[24]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText30.text == CardDatabase.CardName[25]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText30.text == CardDatabase.CardName[26]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText30.text == CardDatabase.CardName[27]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText30.text == CardDatabase.CardName[28]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText30.text == CardDatabase.CardName[29]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText30.text == CardDatabase.CardName[30]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText30.text == CardDatabase.CardName[31]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText30.text == CardDatabase.CardName[32]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText30.text == CardDatabase.CardName[33]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText30.text == CardDatabase.CardName[45]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText30.text == CardDatabase.CardName[46]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText30.text == CardDatabase.CardName[47]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText30.text == CardDatabase.CardName[48]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText30.text == CardDatabase.CardName[49]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText30.text == CardDatabase.CardName[50]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText30.text == CardDatabase.CardName[51]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText30.text == CardDatabase.CardName[52]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText30.text == CardDatabase.CardName[53]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText30.text == CardDatabase.CardName[54]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText30.text == CardDatabase.CardName[55]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText30.text == CardDatabase.CardName[69]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText30.text == CardDatabase.CardName[70]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText30.text == CardDatabase.CardName[71]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText30.text == CardDatabase.CardName[72]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText30.text == CardDatabase.CardName[73]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText30.text == CardDatabase.CardName[74]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText30.text == CardDatabase.CardName[75]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText30.text == CardDatabase.CardName[76]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText30.text == CardDatabase.CardName[77]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText30.text == CardDatabase.CardName[78]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText30.text == CardDatabase.CardName[79]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText30.text == CardDatabase.CardName[90]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText30.text == CardDatabase.CardName[91]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText30.text == CardDatabase.CardName[92]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText30.text == CardDatabase.CardName[93]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText30.text == CardDatabase.CardName[94]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText30.text == CardDatabase.CardName[95]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText30.text == CardDatabase.CardName[96]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText30.text == CardDatabase.CardName[97]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText30.text == CardDatabase.CardName[98]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText30.text == CardDatabase.CardName[99]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText30.text == CardDatabase.CardName[100]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText30.text == CardDatabase.CardName[113]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText30.text == CardDatabase.CardName[114]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText30.text == CardDatabase.CardName[115]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText30.text == CardDatabase.CardName[116]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText30.text == CardDatabase.CardName[117]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText30.text == CardDatabase.CardName[118]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText30.text == CardDatabase.CardName[122]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText30.text == CardDatabase.CardName[123]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText30.text == CardDatabase.CardName[124]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText30.text == CardDatabase.CardName[125]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText30.text == CardDatabase.CardName[126]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText30.text == CardDatabase.CardName[127]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText30.text == CardDatabase.CardName[128]) {
            DeckDownloaded30 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText31
        if (DeckText31.text == CardDatabase.CardName[0]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText31.text == CardDatabase.CardName[1]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText31.text == CardDatabase.CardName[2]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText31.text == CardDatabase.CardName[3]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText31.text == CardDatabase.CardName[4]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText31.text == CardDatabase.CardName[5]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText31.text == CardDatabase.CardName[6]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText31.text == CardDatabase.CardName[7]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText31.text == CardDatabase.CardName[8]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText31.text == CardDatabase.CardName[9]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText31.text == CardDatabase.CardName[10]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText31.text == CardDatabase.CardName[23]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText31.text == CardDatabase.CardName[24]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText31.text == CardDatabase.CardName[25]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText31.text == CardDatabase.CardName[26]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText31.text == CardDatabase.CardName[27]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText31.text == CardDatabase.CardName[28]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText31.text == CardDatabase.CardName[29]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText31.text == CardDatabase.CardName[30]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText31.text == CardDatabase.CardName[31]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText31.text == CardDatabase.CardName[32]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText31.text == CardDatabase.CardName[33]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText31.text == CardDatabase.CardName[45]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText31.text == CardDatabase.CardName[46]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText31.text == CardDatabase.CardName[47]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText31.text == CardDatabase.CardName[48]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText31.text == CardDatabase.CardName[49]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText31.text == CardDatabase.CardName[50]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText31.text == CardDatabase.CardName[51]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText31.text == CardDatabase.CardName[52]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText31.text == CardDatabase.CardName[53]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText31.text == CardDatabase.CardName[54]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText31.text == CardDatabase.CardName[55]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText31.text == CardDatabase.CardName[69]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText31.text == CardDatabase.CardName[70]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText31.text == CardDatabase.CardName[71]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText31.text == CardDatabase.CardName[72]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText31.text == CardDatabase.CardName[73]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText31.text == CardDatabase.CardName[74]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText31.text == CardDatabase.CardName[75]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText31.text == CardDatabase.CardName[76]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText31.text == CardDatabase.CardName[77]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText31.text == CardDatabase.CardName[78]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText31.text == CardDatabase.CardName[79]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText31.text == CardDatabase.CardName[90]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText31.text == CardDatabase.CardName[91]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText31.text == CardDatabase.CardName[92]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText31.text == CardDatabase.CardName[93]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText31.text == CardDatabase.CardName[94]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText31.text == CardDatabase.CardName[95]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText31.text == CardDatabase.CardName[96]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText31.text == CardDatabase.CardName[97]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText31.text == CardDatabase.CardName[98]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText31.text == CardDatabase.CardName[99]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText31.text == CardDatabase.CardName[100]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText31.text == CardDatabase.CardName[113]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText31.text == CardDatabase.CardName[114]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText31.text == CardDatabase.CardName[115]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText31.text == CardDatabase.CardName[116]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText31.text == CardDatabase.CardName[117]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText31.text == CardDatabase.CardName[118]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText31.text == CardDatabase.CardName[122]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText31.text == CardDatabase.CardName[123]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText31.text == CardDatabase.CardName[124]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText31.text == CardDatabase.CardName[125]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText31.text == CardDatabase.CardName[126]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText31.text == CardDatabase.CardName[127]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText31.text == CardDatabase.CardName[128]) {
            DeckDownloaded31 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText32
        if (DeckText32.text == CardDatabase.CardName[0]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText32.text == CardDatabase.CardName[1]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText32.text == CardDatabase.CardName[2]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText32.text == CardDatabase.CardName[3]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText32.text == CardDatabase.CardName[4]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText32.text == CardDatabase.CardName[5]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText32.text == CardDatabase.CardName[6]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText32.text == CardDatabase.CardName[7]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText32.text == CardDatabase.CardName[8]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText32.text == CardDatabase.CardName[9]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText32.text == CardDatabase.CardName[10]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText32.text == CardDatabase.CardName[23]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText32.text == CardDatabase.CardName[24]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText32.text == CardDatabase.CardName[25]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText32.text == CardDatabase.CardName[26]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText32.text == CardDatabase.CardName[27]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText32.text == CardDatabase.CardName[28]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText32.text == CardDatabase.CardName[29]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText32.text == CardDatabase.CardName[30]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText32.text == CardDatabase.CardName[31]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText32.text == CardDatabase.CardName[32]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText32.text == CardDatabase.CardName[33]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText32.text == CardDatabase.CardName[45]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText32.text == CardDatabase.CardName[46]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText32.text == CardDatabase.CardName[47]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText32.text == CardDatabase.CardName[48]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText32.text == CardDatabase.CardName[49]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText32.text == CardDatabase.CardName[50]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText32.text == CardDatabase.CardName[51]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText32.text == CardDatabase.CardName[52]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText32.text == CardDatabase.CardName[53]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText32.text == CardDatabase.CardName[54]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText32.text == CardDatabase.CardName[55]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText32.text == CardDatabase.CardName[69]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText32.text == CardDatabase.CardName[70]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText32.text == CardDatabase.CardName[71]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText32.text == CardDatabase.CardName[72]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText32.text == CardDatabase.CardName[73]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText32.text == CardDatabase.CardName[74]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText32.text == CardDatabase.CardName[75]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText32.text == CardDatabase.CardName[76]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText32.text == CardDatabase.CardName[77]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText32.text == CardDatabase.CardName[78]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText32.text == CardDatabase.CardName[79]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText32.text == CardDatabase.CardName[90]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText32.text == CardDatabase.CardName[91]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText32.text == CardDatabase.CardName[92]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText32.text == CardDatabase.CardName[93]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText32.text == CardDatabase.CardName[94]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText32.text == CardDatabase.CardName[95]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText32.text == CardDatabase.CardName[96]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText32.text == CardDatabase.CardName[97]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText32.text == CardDatabase.CardName[98]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText32.text == CardDatabase.CardName[99]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText32.text == CardDatabase.CardName[100]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText32.text == CardDatabase.CardName[113]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText32.text == CardDatabase.CardName[114]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText32.text == CardDatabase.CardName[115]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText32.text == CardDatabase.CardName[116]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText32.text == CardDatabase.CardName[117]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText32.text == CardDatabase.CardName[118]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText32.text == CardDatabase.CardName[122]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText32.text == CardDatabase.CardName[123]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText32.text == CardDatabase.CardName[124]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText32.text == CardDatabase.CardName[125]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText32.text == CardDatabase.CardName[126]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText32.text == CardDatabase.CardName[127]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText32.text == CardDatabase.CardName[128]) {
            DeckDownloaded32 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText33
        if (DeckText33.text == CardDatabase.CardName[0]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText33.text == CardDatabase.CardName[1]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText33.text == CardDatabase.CardName[2]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText33.text == CardDatabase.CardName[3]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText33.text == CardDatabase.CardName[4]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText33.text == CardDatabase.CardName[5]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText33.text == CardDatabase.CardName[6]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText33.text == CardDatabase.CardName[7]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText33.text == CardDatabase.CardName[8]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText33.text == CardDatabase.CardName[9]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText33.text == CardDatabase.CardName[10]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText33.text == CardDatabase.CardName[23]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText33.text == CardDatabase.CardName[24]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText33.text == CardDatabase.CardName[25]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText33.text == CardDatabase.CardName[26]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText33.text == CardDatabase.CardName[27]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText33.text == CardDatabase.CardName[28]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText33.text == CardDatabase.CardName[29]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText33.text == CardDatabase.CardName[30]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText33.text == CardDatabase.CardName[31]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText33.text == CardDatabase.CardName[32]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText33.text == CardDatabase.CardName[33]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText33.text == CardDatabase.CardName[45]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText33.text == CardDatabase.CardName[46]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText33.text == CardDatabase.CardName[47]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText33.text == CardDatabase.CardName[48]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText33.text == CardDatabase.CardName[49]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText33.text == CardDatabase.CardName[50]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText33.text == CardDatabase.CardName[51]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText33.text == CardDatabase.CardName[52]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText33.text == CardDatabase.CardName[53]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText33.text == CardDatabase.CardName[54]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText33.text == CardDatabase.CardName[55]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText33.text == CardDatabase.CardName[69]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText33.text == CardDatabase.CardName[70]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText33.text == CardDatabase.CardName[71]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText33.text == CardDatabase.CardName[72]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText33.text == CardDatabase.CardName[73]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText33.text == CardDatabase.CardName[74]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText33.text == CardDatabase.CardName[75]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText33.text == CardDatabase.CardName[76]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText33.text == CardDatabase.CardName[77]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText33.text == CardDatabase.CardName[78]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText33.text == CardDatabase.CardName[79]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText33.text == CardDatabase.CardName[90]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText33.text == CardDatabase.CardName[91]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText33.text == CardDatabase.CardName[92]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText33.text == CardDatabase.CardName[93]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText33.text == CardDatabase.CardName[94]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText33.text == CardDatabase.CardName[95]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText33.text == CardDatabase.CardName[96]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText33.text == CardDatabase.CardName[97]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText33.text == CardDatabase.CardName[98]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText33.text == CardDatabase.CardName[99]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText33.text == CardDatabase.CardName[100]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText33.text == CardDatabase.CardName[113]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText33.text == CardDatabase.CardName[114]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText33.text == CardDatabase.CardName[115]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText33.text == CardDatabase.CardName[116]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText33.text == CardDatabase.CardName[117]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText33.text == CardDatabase.CardName[118]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText33.text == CardDatabase.CardName[122]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText33.text == CardDatabase.CardName[123]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText33.text == CardDatabase.CardName[124]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText33.text == CardDatabase.CardName[125]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText33.text == CardDatabase.CardName[126]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText33.text == CardDatabase.CardName[127]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText33.text == CardDatabase.CardName[128]) {
            DeckDownloaded33 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText34
        if (DeckText34.text == CardDatabase.CardName[0]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText34.text == CardDatabase.CardName[1]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText34.text == CardDatabase.CardName[2]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText34.text == CardDatabase.CardName[3]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText34.text == CardDatabase.CardName[4]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText34.text == CardDatabase.CardName[5]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText34.text == CardDatabase.CardName[6]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText34.text == CardDatabase.CardName[7]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText34.text == CardDatabase.CardName[8]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText34.text == CardDatabase.CardName[9]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText34.text == CardDatabase.CardName[10]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText34.text == CardDatabase.CardName[23]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText34.text == CardDatabase.CardName[24]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText34.text == CardDatabase.CardName[25]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText34.text == CardDatabase.CardName[26]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText34.text == CardDatabase.CardName[27]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText34.text == CardDatabase.CardName[28]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText34.text == CardDatabase.CardName[29]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText34.text == CardDatabase.CardName[30]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText34.text == CardDatabase.CardName[31]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText34.text == CardDatabase.CardName[32]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText34.text == CardDatabase.CardName[33]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText34.text == CardDatabase.CardName[45]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText34.text == CardDatabase.CardName[46]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText34.text == CardDatabase.CardName[47]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText34.text == CardDatabase.CardName[48]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText34.text == CardDatabase.CardName[49]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText34.text == CardDatabase.CardName[50]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText34.text == CardDatabase.CardName[51]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText34.text == CardDatabase.CardName[52]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText34.text == CardDatabase.CardName[53]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText34.text == CardDatabase.CardName[54]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText34.text == CardDatabase.CardName[55]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText34.text == CardDatabase.CardName[69]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText34.text == CardDatabase.CardName[70]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText34.text == CardDatabase.CardName[71]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText34.text == CardDatabase.CardName[72]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText34.text == CardDatabase.CardName[73]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText34.text == CardDatabase.CardName[74]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText34.text == CardDatabase.CardName[75]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText34.text == CardDatabase.CardName[76]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText34.text == CardDatabase.CardName[77]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText34.text == CardDatabase.CardName[78]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText34.text == CardDatabase.CardName[79]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText34.text == CardDatabase.CardName[90]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText34.text == CardDatabase.CardName[91]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText34.text == CardDatabase.CardName[92]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText34.text == CardDatabase.CardName[93]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText34.text == CardDatabase.CardName[94]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText34.text == CardDatabase.CardName[95]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText34.text == CardDatabase.CardName[96]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText34.text == CardDatabase.CardName[97]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText34.text == CardDatabase.CardName[98]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText34.text == CardDatabase.CardName[99]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText34.text == CardDatabase.CardName[100]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText34.text == CardDatabase.CardName[113]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText34.text == CardDatabase.CardName[114]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText34.text == CardDatabase.CardName[115]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText34.text == CardDatabase.CardName[116]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText34.text == CardDatabase.CardName[117]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText34.text == CardDatabase.CardName[118]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText34.text == CardDatabase.CardName[122]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText34.text == CardDatabase.CardName[123]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText34.text == CardDatabase.CardName[124]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText34.text == CardDatabase.CardName[125]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText34.text == CardDatabase.CardName[126]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText34.text == CardDatabase.CardName[127]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText34.text == CardDatabase.CardName[128]) {
            DeckDownloaded34 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText35
        if (DeckText35.text == CardDatabase.CardName[0]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText35.text == CardDatabase.CardName[1]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText35.text == CardDatabase.CardName[2]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText35.text == CardDatabase.CardName[3]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText35.text == CardDatabase.CardName[4]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText35.text == CardDatabase.CardName[5]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText35.text == CardDatabase.CardName[6]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText35.text == CardDatabase.CardName[7]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText35.text == CardDatabase.CardName[8]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText35.text == CardDatabase.CardName[9]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText35.text == CardDatabase.CardName[10]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText35.text == CardDatabase.CardName[23]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText35.text == CardDatabase.CardName[24]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText35.text == CardDatabase.CardName[25]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText35.text == CardDatabase.CardName[26]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText35.text == CardDatabase.CardName[27]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText35.text == CardDatabase.CardName[28]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText35.text == CardDatabase.CardName[29]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText35.text == CardDatabase.CardName[30]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText35.text == CardDatabase.CardName[31]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText35.text == CardDatabase.CardName[32]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText35.text == CardDatabase.CardName[33]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText35.text == CardDatabase.CardName[45]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText35.text == CardDatabase.CardName[46]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText35.text == CardDatabase.CardName[47]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText35.text == CardDatabase.CardName[48]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText35.text == CardDatabase.CardName[49]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText35.text == CardDatabase.CardName[50]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText35.text == CardDatabase.CardName[51]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText35.text == CardDatabase.CardName[52]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText35.text == CardDatabase.CardName[53]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText35.text == CardDatabase.CardName[54]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText35.text == CardDatabase.CardName[55]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText35.text == CardDatabase.CardName[69]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText35.text == CardDatabase.CardName[70]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText35.text == CardDatabase.CardName[71]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText35.text == CardDatabase.CardName[72]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText35.text == CardDatabase.CardName[73]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText35.text == CardDatabase.CardName[74]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText35.text == CardDatabase.CardName[75]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText35.text == CardDatabase.CardName[76]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText35.text == CardDatabase.CardName[77]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText35.text == CardDatabase.CardName[78]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText35.text == CardDatabase.CardName[79]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText35.text == CardDatabase.CardName[90]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText35.text == CardDatabase.CardName[91]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText35.text == CardDatabase.CardName[92]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText35.text == CardDatabase.CardName[93]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText35.text == CardDatabase.CardName[94]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText35.text == CardDatabase.CardName[95]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText35.text == CardDatabase.CardName[96]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText35.text == CardDatabase.CardName[97]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText35.text == CardDatabase.CardName[98]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText35.text == CardDatabase.CardName[99]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText35.text == CardDatabase.CardName[100]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText35.text == CardDatabase.CardName[113]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText35.text == CardDatabase.CardName[114]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText35.text == CardDatabase.CardName[115]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText35.text == CardDatabase.CardName[116]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText35.text == CardDatabase.CardName[117]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText35.text == CardDatabase.CardName[118]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText35.text == CardDatabase.CardName[122]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText35.text == CardDatabase.CardName[123]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText35.text == CardDatabase.CardName[124]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText35.text == CardDatabase.CardName[125]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText35.text == CardDatabase.CardName[126]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText35.text == CardDatabase.CardName[127]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText35.text == CardDatabase.CardName[128]) {
            DeckDownloaded35 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText36
        if (DeckText36.text == CardDatabase.CardName[0]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText36.text == CardDatabase.CardName[1]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText36.text == CardDatabase.CardName[2]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText36.text == CardDatabase.CardName[3]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText36.text == CardDatabase.CardName[4]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText36.text == CardDatabase.CardName[5]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText36.text == CardDatabase.CardName[6]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText36.text == CardDatabase.CardName[7]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText36.text == CardDatabase.CardName[8]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText36.text == CardDatabase.CardName[9]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText36.text == CardDatabase.CardName[10]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText36.text == CardDatabase.CardName[23]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText36.text == CardDatabase.CardName[24]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText36.text == CardDatabase.CardName[25]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText36.text == CardDatabase.CardName[26]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText36.text == CardDatabase.CardName[27]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText36.text == CardDatabase.CardName[28]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText36.text == CardDatabase.CardName[29]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText36.text == CardDatabase.CardName[30]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText36.text == CardDatabase.CardName[31]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText36.text == CardDatabase.CardName[32]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText36.text == CardDatabase.CardName[33]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText36.text == CardDatabase.CardName[45]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText36.text == CardDatabase.CardName[46]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText36.text == CardDatabase.CardName[47]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText36.text == CardDatabase.CardName[48]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText36.text == CardDatabase.CardName[49]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText36.text == CardDatabase.CardName[50]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText36.text == CardDatabase.CardName[51]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText36.text == CardDatabase.CardName[52]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText36.text == CardDatabase.CardName[53]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText36.text == CardDatabase.CardName[54]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText36.text == CardDatabase.CardName[55]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText36.text == CardDatabase.CardName[69]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText36.text == CardDatabase.CardName[70]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText36.text == CardDatabase.CardName[71]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText36.text == CardDatabase.CardName[72]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText36.text == CardDatabase.CardName[73]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText36.text == CardDatabase.CardName[74]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText36.text == CardDatabase.CardName[75]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText36.text == CardDatabase.CardName[76]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText36.text == CardDatabase.CardName[77]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText36.text == CardDatabase.CardName[78]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText36.text == CardDatabase.CardName[79]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText36.text == CardDatabase.CardName[90]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText36.text == CardDatabase.CardName[91]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText36.text == CardDatabase.CardName[92]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText36.text == CardDatabase.CardName[93]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText36.text == CardDatabase.CardName[94]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText36.text == CardDatabase.CardName[95]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText36.text == CardDatabase.CardName[96]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText36.text == CardDatabase.CardName[97]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText36.text == CardDatabase.CardName[98]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText36.text == CardDatabase.CardName[99]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText36.text == CardDatabase.CardName[100]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText36.text == CardDatabase.CardName[113]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText36.text == CardDatabase.CardName[114]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText36.text == CardDatabase.CardName[115]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText36.text == CardDatabase.CardName[116]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText36.text == CardDatabase.CardName[117]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText36.text == CardDatabase.CardName[118]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText36.text == CardDatabase.CardName[122]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText36.text == CardDatabase.CardName[123]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText36.text == CardDatabase.CardName[124]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText36.text == CardDatabase.CardName[125]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText36.text == CardDatabase.CardName[126]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText36.text == CardDatabase.CardName[127]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText36.text == CardDatabase.CardName[128]) {
            DeckDownloaded36 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText37
        if (DeckText37.text == CardDatabase.CardName[0]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText37.text == CardDatabase.CardName[1]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText37.text == CardDatabase.CardName[2]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText37.text == CardDatabase.CardName[3]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText37.text == CardDatabase.CardName[4]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText37.text == CardDatabase.CardName[5]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText37.text == CardDatabase.CardName[6]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText37.text == CardDatabase.CardName[7]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText37.text == CardDatabase.CardName[8]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText37.text == CardDatabase.CardName[9]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText37.text == CardDatabase.CardName[10]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText37.text == CardDatabase.CardName[23]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText37.text == CardDatabase.CardName[24]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText37.text == CardDatabase.CardName[25]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText37.text == CardDatabase.CardName[26]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText37.text == CardDatabase.CardName[27]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText37.text == CardDatabase.CardName[28]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText37.text == CardDatabase.CardName[29]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText37.text == CardDatabase.CardName[30]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText37.text == CardDatabase.CardName[31]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText37.text == CardDatabase.CardName[32]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText37.text == CardDatabase.CardName[33]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText37.text == CardDatabase.CardName[45]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText37.text == CardDatabase.CardName[46]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText37.text == CardDatabase.CardName[47]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText37.text == CardDatabase.CardName[48]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText37.text == CardDatabase.CardName[49]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText37.text == CardDatabase.CardName[50]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText37.text == CardDatabase.CardName[51]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText37.text == CardDatabase.CardName[52]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText37.text == CardDatabase.CardName[53]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText37.text == CardDatabase.CardName[54]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText37.text == CardDatabase.CardName[55]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText37.text == CardDatabase.CardName[69]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText37.text == CardDatabase.CardName[70]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText37.text == CardDatabase.CardName[71]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText37.text == CardDatabase.CardName[72]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText37.text == CardDatabase.CardName[73]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText37.text == CardDatabase.CardName[74]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText37.text == CardDatabase.CardName[75]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText37.text == CardDatabase.CardName[76]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText37.text == CardDatabase.CardName[77]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText37.text == CardDatabase.CardName[78]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText37.text == CardDatabase.CardName[79]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText37.text == CardDatabase.CardName[90]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText37.text == CardDatabase.CardName[91]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText37.text == CardDatabase.CardName[92]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText37.text == CardDatabase.CardName[93]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText37.text == CardDatabase.CardName[94]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText37.text == CardDatabase.CardName[95]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText37.text == CardDatabase.CardName[96]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText37.text == CardDatabase.CardName[97]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText37.text == CardDatabase.CardName[98]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText37.text == CardDatabase.CardName[99]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText37.text == CardDatabase.CardName[100]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText37.text == CardDatabase.CardName[113]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText37.text == CardDatabase.CardName[114]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText37.text == CardDatabase.CardName[115]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText37.text == CardDatabase.CardName[116]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText37.text == CardDatabase.CardName[117]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText37.text == CardDatabase.CardName[118]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText37.text == CardDatabase.CardName[122]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText37.text == CardDatabase.CardName[123]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText37.text == CardDatabase.CardName[124]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText37.text == CardDatabase.CardName[125]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText37.text == CardDatabase.CardName[126]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText37.text == CardDatabase.CardName[127]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText37.text == CardDatabase.CardName[128]) {
            DeckDownloaded37 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText38
        if (DeckText38.text == CardDatabase.CardName[0]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText38.text == CardDatabase.CardName[1]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText38.text == CardDatabase.CardName[2]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText38.text == CardDatabase.CardName[3]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText38.text == CardDatabase.CardName[4]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText38.text == CardDatabase.CardName[5]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText38.text == CardDatabase.CardName[6]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText38.text == CardDatabase.CardName[7]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText38.text == CardDatabase.CardName[8]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText38.text == CardDatabase.CardName[9]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText38.text == CardDatabase.CardName[10]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText38.text == CardDatabase.CardName[23]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText38.text == CardDatabase.CardName[24]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText38.text == CardDatabase.CardName[25]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText38.text == CardDatabase.CardName[26]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText38.text == CardDatabase.CardName[27]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText38.text == CardDatabase.CardName[28]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText38.text == CardDatabase.CardName[29]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText38.text == CardDatabase.CardName[30]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText38.text == CardDatabase.CardName[31]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText38.text == CardDatabase.CardName[32]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText38.text == CardDatabase.CardName[33]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText38.text == CardDatabase.CardName[45]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText38.text == CardDatabase.CardName[46]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText38.text == CardDatabase.CardName[47]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText38.text == CardDatabase.CardName[48]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText38.text == CardDatabase.CardName[49]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText38.text == CardDatabase.CardName[50]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText38.text == CardDatabase.CardName[51]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText38.text == CardDatabase.CardName[52]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText38.text == CardDatabase.CardName[53]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText38.text == CardDatabase.CardName[54]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText38.text == CardDatabase.CardName[55]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText38.text == CardDatabase.CardName[69]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText38.text == CardDatabase.CardName[70]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText38.text == CardDatabase.CardName[71]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText38.text == CardDatabase.CardName[72]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText38.text == CardDatabase.CardName[73]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText38.text == CardDatabase.CardName[74]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText38.text == CardDatabase.CardName[75]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText38.text == CardDatabase.CardName[76]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText38.text == CardDatabase.CardName[77]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText38.text == CardDatabase.CardName[78]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText38.text == CardDatabase.CardName[79]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText38.text == CardDatabase.CardName[90]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText38.text == CardDatabase.CardName[91]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText38.text == CardDatabase.CardName[92]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText38.text == CardDatabase.CardName[93]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText38.text == CardDatabase.CardName[94]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText38.text == CardDatabase.CardName[95]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText38.text == CardDatabase.CardName[96]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText38.text == CardDatabase.CardName[97]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText38.text == CardDatabase.CardName[98]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText38.text == CardDatabase.CardName[99]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText38.text == CardDatabase.CardName[100]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText38.text == CardDatabase.CardName[113]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText38.text == CardDatabase.CardName[114]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText38.text == CardDatabase.CardName[115]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText38.text == CardDatabase.CardName[116]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText38.text == CardDatabase.CardName[117]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText38.text == CardDatabase.CardName[118]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText38.text == CardDatabase.CardName[122]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText38.text == CardDatabase.CardName[123]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText38.text == CardDatabase.CardName[124]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText38.text == CardDatabase.CardName[125]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText38.text == CardDatabase.CardName[126]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText38.text == CardDatabase.CardName[127]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText38.text == CardDatabase.CardName[128]) {
            DeckDownloaded38 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText39
        if (DeckText39.text == CardDatabase.CardName[0]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText39.text == CardDatabase.CardName[1]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText39.text == CardDatabase.CardName[2]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText39.text == CardDatabase.CardName[3]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText39.text == CardDatabase.CardName[4]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText39.text == CardDatabase.CardName[5]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText39.text == CardDatabase.CardName[6]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText39.text == CardDatabase.CardName[7]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText39.text == CardDatabase.CardName[8]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText39.text == CardDatabase.CardName[9]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText39.text == CardDatabase.CardName[10]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText39.text == CardDatabase.CardName[23]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText39.text == CardDatabase.CardName[24]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText39.text == CardDatabase.CardName[25]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText39.text == CardDatabase.CardName[26]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText39.text == CardDatabase.CardName[27]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText39.text == CardDatabase.CardName[28]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText39.text == CardDatabase.CardName[29]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText39.text == CardDatabase.CardName[30]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText39.text == CardDatabase.CardName[31]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText39.text == CardDatabase.CardName[32]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText39.text == CardDatabase.CardName[33]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText39.text == CardDatabase.CardName[45]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText39.text == CardDatabase.CardName[46]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText39.text == CardDatabase.CardName[47]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText39.text == CardDatabase.CardName[48]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText39.text == CardDatabase.CardName[49]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText39.text == CardDatabase.CardName[50]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText39.text == CardDatabase.CardName[51]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText39.text == CardDatabase.CardName[52]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText39.text == CardDatabase.CardName[53]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText39.text == CardDatabase.CardName[54]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText39.text == CardDatabase.CardName[55]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText39.text == CardDatabase.CardName[69]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText39.text == CardDatabase.CardName[70]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText39.text == CardDatabase.CardName[71]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText39.text == CardDatabase.CardName[72]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText39.text == CardDatabase.CardName[73]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText39.text == CardDatabase.CardName[74]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText39.text == CardDatabase.CardName[75]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText39.text == CardDatabase.CardName[76]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText39.text == CardDatabase.CardName[77]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText39.text == CardDatabase.CardName[78]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText39.text == CardDatabase.CardName[79]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText39.text == CardDatabase.CardName[90]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText39.text == CardDatabase.CardName[91]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText39.text == CardDatabase.CardName[92]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText39.text == CardDatabase.CardName[93]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText39.text == CardDatabase.CardName[94]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText39.text == CardDatabase.CardName[95]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText39.text == CardDatabase.CardName[96]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText39.text == CardDatabase.CardName[97]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText39.text == CardDatabase.CardName[98]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText39.text == CardDatabase.CardName[99]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText39.text == CardDatabase.CardName[100]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText39.text == CardDatabase.CardName[113]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText39.text == CardDatabase.CardName[114]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText39.text == CardDatabase.CardName[115]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText39.text == CardDatabase.CardName[116]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText39.text == CardDatabase.CardName[117]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText39.text == CardDatabase.CardName[118]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText39.text == CardDatabase.CardName[122]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText39.text == CardDatabase.CardName[123]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText39.text == CardDatabase.CardName[124]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText39.text == CardDatabase.CardName[125]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText39.text == CardDatabase.CardName[126]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText39.text == CardDatabase.CardName[127]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText39.text == CardDatabase.CardName[128]) {
            DeckDownloaded39 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText40
        if (DeckText40.text == CardDatabase.CardName[0]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText40.text == CardDatabase.CardName[1]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText40.text == CardDatabase.CardName[2]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText40.text == CardDatabase.CardName[3]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText40.text == CardDatabase.CardName[4]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText40.text == CardDatabase.CardName[5]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText40.text == CardDatabase.CardName[6]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText40.text == CardDatabase.CardName[7]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText40.text == CardDatabase.CardName[8]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText40.text == CardDatabase.CardName[9]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText40.text == CardDatabase.CardName[10]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText40.text == CardDatabase.CardName[23]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText40.text == CardDatabase.CardName[24]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText40.text == CardDatabase.CardName[25]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText40.text == CardDatabase.CardName[26]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText40.text == CardDatabase.CardName[27]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText40.text == CardDatabase.CardName[28]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText40.text == CardDatabase.CardName[29]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText40.text == CardDatabase.CardName[30]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText40.text == CardDatabase.CardName[31]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText40.text == CardDatabase.CardName[32]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText40.text == CardDatabase.CardName[33]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText40.text == CardDatabase.CardName[45]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText40.text == CardDatabase.CardName[46]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText40.text == CardDatabase.CardName[47]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText40.text == CardDatabase.CardName[48]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText40.text == CardDatabase.CardName[49]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText40.text == CardDatabase.CardName[50]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText40.text == CardDatabase.CardName[51]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText40.text == CardDatabase.CardName[52]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText40.text == CardDatabase.CardName[53]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText40.text == CardDatabase.CardName[54]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText40.text == CardDatabase.CardName[55]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText40.text == CardDatabase.CardName[69]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText40.text == CardDatabase.CardName[70]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText40.text == CardDatabase.CardName[71]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText40.text == CardDatabase.CardName[72]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText40.text == CardDatabase.CardName[73]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText40.text == CardDatabase.CardName[74]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText40.text == CardDatabase.CardName[75]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText40.text == CardDatabase.CardName[76]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText40.text == CardDatabase.CardName[77]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText40.text == CardDatabase.CardName[78]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText40.text == CardDatabase.CardName[79]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText40.text == CardDatabase.CardName[90]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText40.text == CardDatabase.CardName[91]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText40.text == CardDatabase.CardName[92]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText40.text == CardDatabase.CardName[93]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText40.text == CardDatabase.CardName[94]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText40.text == CardDatabase.CardName[95]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText40.text == CardDatabase.CardName[96]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText40.text == CardDatabase.CardName[97]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText40.text == CardDatabase.CardName[98]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText40.text == CardDatabase.CardName[99]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText40.text == CardDatabase.CardName[100]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText40.text == CardDatabase.CardName[113]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText40.text == CardDatabase.CardName[114]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText40.text == CardDatabase.CardName[115]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText40.text == CardDatabase.CardName[116]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText40.text == CardDatabase.CardName[117]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText40.text == CardDatabase.CardName[118]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText40.text == CardDatabase.CardName[122]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText40.text == CardDatabase.CardName[123]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText40.text == CardDatabase.CardName[124]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText40.text == CardDatabase.CardName[125]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText40.text == CardDatabase.CardName[126]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText40.text == CardDatabase.CardName[127]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText40.text == CardDatabase.CardName[128]) {
            DeckDownloaded40 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText41
        if (DeckText41.text == CardDatabase.CardName[0]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText41.text == CardDatabase.CardName[1]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText41.text == CardDatabase.CardName[2]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText41.text == CardDatabase.CardName[3]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText41.text == CardDatabase.CardName[4]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText41.text == CardDatabase.CardName[5]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText41.text == CardDatabase.CardName[6]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText41.text == CardDatabase.CardName[7]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText41.text == CardDatabase.CardName[8]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText41.text == CardDatabase.CardName[9]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText41.text == CardDatabase.CardName[10]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText41.text == CardDatabase.CardName[23]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText41.text == CardDatabase.CardName[24]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText41.text == CardDatabase.CardName[25]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText41.text == CardDatabase.CardName[26]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText41.text == CardDatabase.CardName[27]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText41.text == CardDatabase.CardName[28]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText41.text == CardDatabase.CardName[29]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText41.text == CardDatabase.CardName[30]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText41.text == CardDatabase.CardName[31]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText41.text == CardDatabase.CardName[32]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText41.text == CardDatabase.CardName[33]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText41.text == CardDatabase.CardName[45]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText41.text == CardDatabase.CardName[46]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText41.text == CardDatabase.CardName[47]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText41.text == CardDatabase.CardName[48]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText41.text == CardDatabase.CardName[49]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText41.text == CardDatabase.CardName[50]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText41.text == CardDatabase.CardName[51]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText41.text == CardDatabase.CardName[52]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText41.text == CardDatabase.CardName[53]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText41.text == CardDatabase.CardName[54]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText41.text == CardDatabase.CardName[55]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText41.text == CardDatabase.CardName[69]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText41.text == CardDatabase.CardName[70]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText41.text == CardDatabase.CardName[71]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText41.text == CardDatabase.CardName[72]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText41.text == CardDatabase.CardName[73]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText41.text == CardDatabase.CardName[74]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText41.text == CardDatabase.CardName[75]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText41.text == CardDatabase.CardName[76]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText41.text == CardDatabase.CardName[77]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText41.text == CardDatabase.CardName[78]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText41.text == CardDatabase.CardName[79]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText41.text == CardDatabase.CardName[90]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText41.text == CardDatabase.CardName[91]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText41.text == CardDatabase.CardName[92]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText41.text == CardDatabase.CardName[93]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText41.text == CardDatabase.CardName[94]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText41.text == CardDatabase.CardName[95]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText41.text == CardDatabase.CardName[96]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText41.text == CardDatabase.CardName[97]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText41.text == CardDatabase.CardName[98]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText41.text == CardDatabase.CardName[99]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText41.text == CardDatabase.CardName[100]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText41.text == CardDatabase.CardName[113]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText41.text == CardDatabase.CardName[114]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText41.text == CardDatabase.CardName[115]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText41.text == CardDatabase.CardName[116]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText41.text == CardDatabase.CardName[117]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText41.text == CardDatabase.CardName[118]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText41.text == CardDatabase.CardName[122]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText41.text == CardDatabase.CardName[123]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText41.text == CardDatabase.CardName[124]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText41.text == CardDatabase.CardName[125]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText41.text == CardDatabase.CardName[126]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText41.text == CardDatabase.CardName[127]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText41.text == CardDatabase.CardName[128]) {
            DeckDownloaded41 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText42
        if (DeckText42.text == CardDatabase.CardName[0]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText42.text == CardDatabase.CardName[1]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText42.text == CardDatabase.CardName[2]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText42.text == CardDatabase.CardName[3]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText42.text == CardDatabase.CardName[4]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText42.text == CardDatabase.CardName[5]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText42.text == CardDatabase.CardName[6]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText42.text == CardDatabase.CardName[7]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText42.text == CardDatabase.CardName[8]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText42.text == CardDatabase.CardName[9]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText42.text == CardDatabase.CardName[10]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText42.text == CardDatabase.CardName[23]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText42.text == CardDatabase.CardName[24]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText42.text == CardDatabase.CardName[25]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText42.text == CardDatabase.CardName[26]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText42.text == CardDatabase.CardName[27]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText42.text == CardDatabase.CardName[28]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText42.text == CardDatabase.CardName[29]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText42.text == CardDatabase.CardName[30]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText42.text == CardDatabase.CardName[31]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText42.text == CardDatabase.CardName[32]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText42.text == CardDatabase.CardName[33]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText42.text == CardDatabase.CardName[45]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText42.text == CardDatabase.CardName[46]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText42.text == CardDatabase.CardName[47]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText42.text == CardDatabase.CardName[48]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText42.text == CardDatabase.CardName[49]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText42.text == CardDatabase.CardName[50]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText42.text == CardDatabase.CardName[51]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText42.text == CardDatabase.CardName[52]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText42.text == CardDatabase.CardName[53]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText42.text == CardDatabase.CardName[54]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText42.text == CardDatabase.CardName[55]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText42.text == CardDatabase.CardName[69]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText42.text == CardDatabase.CardName[70]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText42.text == CardDatabase.CardName[71]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText42.text == CardDatabase.CardName[72]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText42.text == CardDatabase.CardName[73]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText42.text == CardDatabase.CardName[74]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText42.text == CardDatabase.CardName[75]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText42.text == CardDatabase.CardName[76]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText42.text == CardDatabase.CardName[77]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText42.text == CardDatabase.CardName[78]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText42.text == CardDatabase.CardName[79]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText42.text == CardDatabase.CardName[90]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText42.text == CardDatabase.CardName[91]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText42.text == CardDatabase.CardName[92]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText42.text == CardDatabase.CardName[93]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText42.text == CardDatabase.CardName[94]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText42.text == CardDatabase.CardName[95]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText42.text == CardDatabase.CardName[96]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText42.text == CardDatabase.CardName[97]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText42.text == CardDatabase.CardName[98]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText42.text == CardDatabase.CardName[99]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText42.text == CardDatabase.CardName[100]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText42.text == CardDatabase.CardName[113]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText42.text == CardDatabase.CardName[114]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText42.text == CardDatabase.CardName[115]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText42.text == CardDatabase.CardName[116]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText42.text == CardDatabase.CardName[117]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText42.text == CardDatabase.CardName[118]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText42.text == CardDatabase.CardName[122]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText42.text == CardDatabase.CardName[123]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText42.text == CardDatabase.CardName[124]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText42.text == CardDatabase.CardName[125]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText42.text == CardDatabase.CardName[126]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText42.text == CardDatabase.CardName[127]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText42.text == CardDatabase.CardName[128]) {
            DeckDownloaded42 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText43
        if (DeckText43.text == CardDatabase.CardName[0]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText43.text == CardDatabase.CardName[1]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText43.text == CardDatabase.CardName[2]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText43.text == CardDatabase.CardName[3]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText43.text == CardDatabase.CardName[4]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText43.text == CardDatabase.CardName[5]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText43.text == CardDatabase.CardName[6]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText43.text == CardDatabase.CardName[7]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText43.text == CardDatabase.CardName[8]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText43.text == CardDatabase.CardName[9]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText43.text == CardDatabase.CardName[10]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText43.text == CardDatabase.CardName[23]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText43.text == CardDatabase.CardName[24]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText43.text == CardDatabase.CardName[25]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText43.text == CardDatabase.CardName[26]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText43.text == CardDatabase.CardName[27]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText43.text == CardDatabase.CardName[28]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText43.text == CardDatabase.CardName[29]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText43.text == CardDatabase.CardName[30]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText43.text == CardDatabase.CardName[31]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText43.text == CardDatabase.CardName[32]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText43.text == CardDatabase.CardName[33]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText43.text == CardDatabase.CardName[45]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText43.text == CardDatabase.CardName[46]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText43.text == CardDatabase.CardName[47]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText43.text == CardDatabase.CardName[48]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText43.text == CardDatabase.CardName[49]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText43.text == CardDatabase.CardName[50]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText43.text == CardDatabase.CardName[51]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText43.text == CardDatabase.CardName[52]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText43.text == CardDatabase.CardName[53]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText43.text == CardDatabase.CardName[54]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText43.text == CardDatabase.CardName[55]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText43.text == CardDatabase.CardName[69]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText43.text == CardDatabase.CardName[70]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText43.text == CardDatabase.CardName[71]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText43.text == CardDatabase.CardName[72]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText43.text == CardDatabase.CardName[73]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText43.text == CardDatabase.CardName[74]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText43.text == CardDatabase.CardName[75]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText43.text == CardDatabase.CardName[76]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText43.text == CardDatabase.CardName[77]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText43.text == CardDatabase.CardName[78]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText43.text == CardDatabase.CardName[79]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText43.text == CardDatabase.CardName[90]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText43.text == CardDatabase.CardName[91]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText43.text == CardDatabase.CardName[92]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText43.text == CardDatabase.CardName[93]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText43.text == CardDatabase.CardName[94]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText43.text == CardDatabase.CardName[95]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText43.text == CardDatabase.CardName[96]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText43.text == CardDatabase.CardName[97]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText43.text == CardDatabase.CardName[98]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText43.text == CardDatabase.CardName[99]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText43.text == CardDatabase.CardName[100]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText43.text == CardDatabase.CardName[113]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText43.text == CardDatabase.CardName[114]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText43.text == CardDatabase.CardName[115]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText43.text == CardDatabase.CardName[116]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText43.text == CardDatabase.CardName[117]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText43.text == CardDatabase.CardName[118]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText43.text == CardDatabase.CardName[122]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText43.text == CardDatabase.CardName[123]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText43.text == CardDatabase.CardName[124]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText43.text == CardDatabase.CardName[125]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText43.text == CardDatabase.CardName[126]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText43.text == CardDatabase.CardName[127]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText43.text == CardDatabase.CardName[128]) {
            DeckDownloaded43 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText44
        if (DeckText44.text == CardDatabase.CardName[0]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText44.text == CardDatabase.CardName[1]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText44.text == CardDatabase.CardName[2]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText44.text == CardDatabase.CardName[3]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText44.text == CardDatabase.CardName[4]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText44.text == CardDatabase.CardName[5]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText44.text == CardDatabase.CardName[6]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText44.text == CardDatabase.CardName[7]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText44.text == CardDatabase.CardName[8]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText44.text == CardDatabase.CardName[9]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText44.text == CardDatabase.CardName[10]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText44.text == CardDatabase.CardName[23]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText44.text == CardDatabase.CardName[24]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText44.text == CardDatabase.CardName[25]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText44.text == CardDatabase.CardName[26]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText44.text == CardDatabase.CardName[27]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText44.text == CardDatabase.CardName[28]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText44.text == CardDatabase.CardName[29]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText44.text == CardDatabase.CardName[30]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText44.text == CardDatabase.CardName[31]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText44.text == CardDatabase.CardName[32]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText44.text == CardDatabase.CardName[33]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText44.text == CardDatabase.CardName[45]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText44.text == CardDatabase.CardName[46]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText44.text == CardDatabase.CardName[47]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText44.text == CardDatabase.CardName[48]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText44.text == CardDatabase.CardName[49]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText44.text == CardDatabase.CardName[50]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText44.text == CardDatabase.CardName[51]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText44.text == CardDatabase.CardName[52]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText44.text == CardDatabase.CardName[53]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText44.text == CardDatabase.CardName[54]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText44.text == CardDatabase.CardName[55]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText44.text == CardDatabase.CardName[69]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText44.text == CardDatabase.CardName[70]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText44.text == CardDatabase.CardName[71]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText44.text == CardDatabase.CardName[72]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText44.text == CardDatabase.CardName[73]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText44.text == CardDatabase.CardName[74]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText44.text == CardDatabase.CardName[75]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText44.text == CardDatabase.CardName[76]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText44.text == CardDatabase.CardName[77]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText44.text == CardDatabase.CardName[78]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText44.text == CardDatabase.CardName[79]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText44.text == CardDatabase.CardName[90]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText44.text == CardDatabase.CardName[91]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText44.text == CardDatabase.CardName[92]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText44.text == CardDatabase.CardName[93]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText44.text == CardDatabase.CardName[94]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText44.text == CardDatabase.CardName[95]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText44.text == CardDatabase.CardName[96]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText44.text == CardDatabase.CardName[97]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText44.text == CardDatabase.CardName[98]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText44.text == CardDatabase.CardName[99]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText44.text == CardDatabase.CardName[100]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText44.text == CardDatabase.CardName[113]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText44.text == CardDatabase.CardName[114]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText44.text == CardDatabase.CardName[115]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText44.text == CardDatabase.CardName[116]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText44.text == CardDatabase.CardName[117]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText44.text == CardDatabase.CardName[118]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText44.text == CardDatabase.CardName[122]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText44.text == CardDatabase.CardName[123]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText44.text == CardDatabase.CardName[124]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText44.text == CardDatabase.CardName[125]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText44.text == CardDatabase.CardName[126]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText44.text == CardDatabase.CardName[127]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText44.text == CardDatabase.CardName[128]) {
            DeckDownloaded44 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText45
        if (DeckText45.text == CardDatabase.CardName[0]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText45.text == CardDatabase.CardName[1]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText45.text == CardDatabase.CardName[2]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText45.text == CardDatabase.CardName[3]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText45.text == CardDatabase.CardName[4]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText45.text == CardDatabase.CardName[5]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText45.text == CardDatabase.CardName[6]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText45.text == CardDatabase.CardName[7]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText45.text == CardDatabase.CardName[8]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText45.text == CardDatabase.CardName[9]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText45.text == CardDatabase.CardName[10]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText45.text == CardDatabase.CardName[23]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText45.text == CardDatabase.CardName[24]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText45.text == CardDatabase.CardName[25]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText45.text == CardDatabase.CardName[26]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText45.text == CardDatabase.CardName[27]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText45.text == CardDatabase.CardName[28]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText45.text == CardDatabase.CardName[29]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText45.text == CardDatabase.CardName[30]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText45.text == CardDatabase.CardName[31]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText45.text == CardDatabase.CardName[32]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText45.text == CardDatabase.CardName[33]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText45.text == CardDatabase.CardName[45]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText45.text == CardDatabase.CardName[46]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText45.text == CardDatabase.CardName[47]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText45.text == CardDatabase.CardName[48]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText45.text == CardDatabase.CardName[49]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText45.text == CardDatabase.CardName[50]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText45.text == CardDatabase.CardName[51]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText45.text == CardDatabase.CardName[52]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText45.text == CardDatabase.CardName[53]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText45.text == CardDatabase.CardName[54]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText45.text == CardDatabase.CardName[55]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText45.text == CardDatabase.CardName[69]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText45.text == CardDatabase.CardName[70]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText45.text == CardDatabase.CardName[71]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText45.text == CardDatabase.CardName[72]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText45.text == CardDatabase.CardName[73]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText45.text == CardDatabase.CardName[74]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText45.text == CardDatabase.CardName[75]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText45.text == CardDatabase.CardName[76]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText45.text == CardDatabase.CardName[77]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText45.text == CardDatabase.CardName[78]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText45.text == CardDatabase.CardName[79]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText45.text == CardDatabase.CardName[90]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText45.text == CardDatabase.CardName[91]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText45.text == CardDatabase.CardName[92]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText45.text == CardDatabase.CardName[93]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText45.text == CardDatabase.CardName[94]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText45.text == CardDatabase.CardName[95]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText45.text == CardDatabase.CardName[96]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText45.text == CardDatabase.CardName[97]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText45.text == CardDatabase.CardName[98]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText45.text == CardDatabase.CardName[99]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText45.text == CardDatabase.CardName[100]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText45.text == CardDatabase.CardName[113]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText45.text == CardDatabase.CardName[114]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText45.text == CardDatabase.CardName[115]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText45.text == CardDatabase.CardName[116]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText45.text == CardDatabase.CardName[117]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText45.text == CardDatabase.CardName[118]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText45.text == CardDatabase.CardName[122]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText45.text == CardDatabase.CardName[123]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText45.text == CardDatabase.CardName[124]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText45.text == CardDatabase.CardName[125]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText45.text == CardDatabase.CardName[126]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText45.text == CardDatabase.CardName[127]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText45.text == CardDatabase.CardName[128]) {
            DeckDownloaded45 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText46
        if (DeckText46.text == CardDatabase.CardName[0]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText46.text == CardDatabase.CardName[1]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText46.text == CardDatabase.CardName[2]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText46.text == CardDatabase.CardName[3]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText46.text == CardDatabase.CardName[4]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText46.text == CardDatabase.CardName[5]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText46.text == CardDatabase.CardName[6]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText46.text == CardDatabase.CardName[7]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText46.text == CardDatabase.CardName[8]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText46.text == CardDatabase.CardName[9]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText46.text == CardDatabase.CardName[10]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText46.text == CardDatabase.CardName[23]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText46.text == CardDatabase.CardName[24]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText46.text == CardDatabase.CardName[25]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText46.text == CardDatabase.CardName[26]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText46.text == CardDatabase.CardName[27]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText46.text == CardDatabase.CardName[28]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText46.text == CardDatabase.CardName[29]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText46.text == CardDatabase.CardName[30]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText46.text == CardDatabase.CardName[31]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText46.text == CardDatabase.CardName[32]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText46.text == CardDatabase.CardName[33]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText46.text == CardDatabase.CardName[45]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText46.text == CardDatabase.CardName[46]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText46.text == CardDatabase.CardName[47]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText46.text == CardDatabase.CardName[48]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText46.text == CardDatabase.CardName[49]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText46.text == CardDatabase.CardName[50]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText46.text == CardDatabase.CardName[51]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText46.text == CardDatabase.CardName[52]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText46.text == CardDatabase.CardName[53]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText46.text == CardDatabase.CardName[54]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText46.text == CardDatabase.CardName[55]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText46.text == CardDatabase.CardName[69]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText46.text == CardDatabase.CardName[70]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText46.text == CardDatabase.CardName[71]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText46.text == CardDatabase.CardName[72]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText46.text == CardDatabase.CardName[73]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText46.text == CardDatabase.CardName[74]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText46.text == CardDatabase.CardName[75]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText46.text == CardDatabase.CardName[76]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText46.text == CardDatabase.CardName[77]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText46.text == CardDatabase.CardName[78]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText46.text == CardDatabase.CardName[79]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText46.text == CardDatabase.CardName[90]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText46.text == CardDatabase.CardName[91]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText46.text == CardDatabase.CardName[92]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText46.text == CardDatabase.CardName[93]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText46.text == CardDatabase.CardName[94]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText46.text == CardDatabase.CardName[95]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText46.text == CardDatabase.CardName[96]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText46.text == CardDatabase.CardName[97]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText46.text == CardDatabase.CardName[98]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText46.text == CardDatabase.CardName[99]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText46.text == CardDatabase.CardName[100]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText46.text == CardDatabase.CardName[113]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText46.text == CardDatabase.CardName[114]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText46.text == CardDatabase.CardName[115]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText46.text == CardDatabase.CardName[116]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText46.text == CardDatabase.CardName[117]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText46.text == CardDatabase.CardName[118]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText46.text == CardDatabase.CardName[122]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText46.text == CardDatabase.CardName[123]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText46.text == CardDatabase.CardName[124]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText46.text == CardDatabase.CardName[125]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText46.text == CardDatabase.CardName[126]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText46.text == CardDatabase.CardName[127]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText46.text == CardDatabase.CardName[128]) {
            DeckDownloaded46 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText47
        if (DeckText47.text == CardDatabase.CardName[0]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText47.text == CardDatabase.CardName[1]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText47.text == CardDatabase.CardName[2]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText47.text == CardDatabase.CardName[3]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText47.text == CardDatabase.CardName[4]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText47.text == CardDatabase.CardName[5]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText47.text == CardDatabase.CardName[6]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText47.text == CardDatabase.CardName[7]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText47.text == CardDatabase.CardName[8]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText47.text == CardDatabase.CardName[9]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText47.text == CardDatabase.CardName[10]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText47.text == CardDatabase.CardName[23]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText47.text == CardDatabase.CardName[24]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText47.text == CardDatabase.CardName[25]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText47.text == CardDatabase.CardName[26]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText47.text == CardDatabase.CardName[27]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText47.text == CardDatabase.CardName[28]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText47.text == CardDatabase.CardName[29]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText47.text == CardDatabase.CardName[30]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText47.text == CardDatabase.CardName[31]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText47.text == CardDatabase.CardName[32]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText47.text == CardDatabase.CardName[33]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText47.text == CardDatabase.CardName[45]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText47.text == CardDatabase.CardName[46]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText47.text == CardDatabase.CardName[47]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText47.text == CardDatabase.CardName[48]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText47.text == CardDatabase.CardName[49]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText47.text == CardDatabase.CardName[50]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText47.text == CardDatabase.CardName[51]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText47.text == CardDatabase.CardName[52]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText47.text == CardDatabase.CardName[53]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText47.text == CardDatabase.CardName[54]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText47.text == CardDatabase.CardName[55]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText47.text == CardDatabase.CardName[69]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText47.text == CardDatabase.CardName[70]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText47.text == CardDatabase.CardName[71]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText47.text == CardDatabase.CardName[72]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText47.text == CardDatabase.CardName[73]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText47.text == CardDatabase.CardName[74]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText47.text == CardDatabase.CardName[75]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText47.text == CardDatabase.CardName[76]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText47.text == CardDatabase.CardName[77]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText47.text == CardDatabase.CardName[78]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText47.text == CardDatabase.CardName[79]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText47.text == CardDatabase.CardName[90]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText47.text == CardDatabase.CardName[91]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText47.text == CardDatabase.CardName[92]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText47.text == CardDatabase.CardName[93]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText47.text == CardDatabase.CardName[94]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText47.text == CardDatabase.CardName[95]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText47.text == CardDatabase.CardName[96]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText47.text == CardDatabase.CardName[97]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText47.text == CardDatabase.CardName[98]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText47.text == CardDatabase.CardName[99]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText47.text == CardDatabase.CardName[100]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText47.text == CardDatabase.CardName[113]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText47.text == CardDatabase.CardName[114]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText47.text == CardDatabase.CardName[115]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText47.text == CardDatabase.CardName[116]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText47.text == CardDatabase.CardName[117]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText47.text == CardDatabase.CardName[118]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText47.text == CardDatabase.CardName[122]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText47.text == CardDatabase.CardName[123]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText47.text == CardDatabase.CardName[124]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText47.text == CardDatabase.CardName[125]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText47.text == CardDatabase.CardName[126]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText47.text == CardDatabase.CardName[127]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText47.text == CardDatabase.CardName[128]) {
            DeckDownloaded47 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText48
        if (DeckText48.text == CardDatabase.CardName[0]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText48.text == CardDatabase.CardName[1]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText48.text == CardDatabase.CardName[2]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText48.text == CardDatabase.CardName[3]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText48.text == CardDatabase.CardName[4]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText48.text == CardDatabase.CardName[5]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText48.text == CardDatabase.CardName[6]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText48.text == CardDatabase.CardName[7]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText48.text == CardDatabase.CardName[8]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText48.text == CardDatabase.CardName[9]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText48.text == CardDatabase.CardName[10]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText48.text == CardDatabase.CardName[23]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText48.text == CardDatabase.CardName[24]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText48.text == CardDatabase.CardName[25]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText48.text == CardDatabase.CardName[26]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText48.text == CardDatabase.CardName[27]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText48.text == CardDatabase.CardName[28]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText48.text == CardDatabase.CardName[29]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText48.text == CardDatabase.CardName[30]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText48.text == CardDatabase.CardName[31]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText48.text == CardDatabase.CardName[32]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText48.text == CardDatabase.CardName[33]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText48.text == CardDatabase.CardName[45]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText48.text == CardDatabase.CardName[46]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText48.text == CardDatabase.CardName[47]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText48.text == CardDatabase.CardName[48]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText48.text == CardDatabase.CardName[49]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText48.text == CardDatabase.CardName[50]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText48.text == CardDatabase.CardName[51]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText48.text == CardDatabase.CardName[52]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText48.text == CardDatabase.CardName[53]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText48.text == CardDatabase.CardName[54]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText48.text == CardDatabase.CardName[55]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText48.text == CardDatabase.CardName[69]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText48.text == CardDatabase.CardName[70]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText48.text == CardDatabase.CardName[71]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText48.text == CardDatabase.CardName[72]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText48.text == CardDatabase.CardName[73]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText48.text == CardDatabase.CardName[74]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText48.text == CardDatabase.CardName[75]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText48.text == CardDatabase.CardName[76]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText48.text == CardDatabase.CardName[77]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText48.text == CardDatabase.CardName[78]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText48.text == CardDatabase.CardName[79]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText48.text == CardDatabase.CardName[90]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText48.text == CardDatabase.CardName[91]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText48.text == CardDatabase.CardName[92]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText48.text == CardDatabase.CardName[93]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText48.text == CardDatabase.CardName[94]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText48.text == CardDatabase.CardName[95]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText48.text == CardDatabase.CardName[96]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText48.text == CardDatabase.CardName[97]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText48.text == CardDatabase.CardName[98]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText48.text == CardDatabase.CardName[99]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText48.text == CardDatabase.CardName[100]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText48.text == CardDatabase.CardName[113]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText48.text == CardDatabase.CardName[114]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText48.text == CardDatabase.CardName[115]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText48.text == CardDatabase.CardName[116]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText48.text == CardDatabase.CardName[117]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText48.text == CardDatabase.CardName[118]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText48.text == CardDatabase.CardName[122]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText48.text == CardDatabase.CardName[123]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText48.text == CardDatabase.CardName[124]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText48.text == CardDatabase.CardName[125]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText48.text == CardDatabase.CardName[126]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText48.text == CardDatabase.CardName[127]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText48.text == CardDatabase.CardName[128]) {
            DeckDownloaded48 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText49
        if (DeckText49.text == CardDatabase.CardName[0]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText49.text == CardDatabase.CardName[1]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText49.text == CardDatabase.CardName[2]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText49.text == CardDatabase.CardName[3]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText49.text == CardDatabase.CardName[4]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText49.text == CardDatabase.CardName[5]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText49.text == CardDatabase.CardName[6]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText49.text == CardDatabase.CardName[7]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText49.text == CardDatabase.CardName[8]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText49.text == CardDatabase.CardName[9]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText49.text == CardDatabase.CardName[10]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText49.text == CardDatabase.CardName[23]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText49.text == CardDatabase.CardName[24]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText49.text == CardDatabase.CardName[25]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText49.text == CardDatabase.CardName[26]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText49.text == CardDatabase.CardName[27]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText49.text == CardDatabase.CardName[28]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText49.text == CardDatabase.CardName[29]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText49.text == CardDatabase.CardName[30]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText49.text == CardDatabase.CardName[31]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText49.text == CardDatabase.CardName[32]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText49.text == CardDatabase.CardName[33]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText49.text == CardDatabase.CardName[45]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText49.text == CardDatabase.CardName[46]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText49.text == CardDatabase.CardName[47]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText49.text == CardDatabase.CardName[48]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText49.text == CardDatabase.CardName[49]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText49.text == CardDatabase.CardName[50]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText49.text == CardDatabase.CardName[51]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText49.text == CardDatabase.CardName[52]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText49.text == CardDatabase.CardName[53]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText49.text == CardDatabase.CardName[54]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText49.text == CardDatabase.CardName[55]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText49.text == CardDatabase.CardName[69]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText49.text == CardDatabase.CardName[70]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText49.text == CardDatabase.CardName[71]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText49.text == CardDatabase.CardName[72]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText49.text == CardDatabase.CardName[73]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText49.text == CardDatabase.CardName[74]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText49.text == CardDatabase.CardName[75]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText49.text == CardDatabase.CardName[76]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText49.text == CardDatabase.CardName[77]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText49.text == CardDatabase.CardName[78]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText49.text == CardDatabase.CardName[79]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText49.text == CardDatabase.CardName[90]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText49.text == CardDatabase.CardName[91]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText49.text == CardDatabase.CardName[92]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText49.text == CardDatabase.CardName[93]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText49.text == CardDatabase.CardName[94]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText49.text == CardDatabase.CardName[95]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText49.text == CardDatabase.CardName[96]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText49.text == CardDatabase.CardName[97]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText49.text == CardDatabase.CardName[98]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText49.text == CardDatabase.CardName[99]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText49.text == CardDatabase.CardName[100]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText49.text == CardDatabase.CardName[113]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText49.text == CardDatabase.CardName[114]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText49.text == CardDatabase.CardName[115]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText49.text == CardDatabase.CardName[116]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText49.text == CardDatabase.CardName[117]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText49.text == CardDatabase.CardName[118]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText49.text == CardDatabase.CardName[122]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText49.text == CardDatabase.CardName[123]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText49.text == CardDatabase.CardName[124]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText49.text == CardDatabase.CardName[125]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText49.text == CardDatabase.CardName[126]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText49.text == CardDatabase.CardName[127]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText49.text == CardDatabase.CardName[128]) {
            DeckDownloaded49 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText50
        if (DeckText50.text == CardDatabase.CardName[0]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText50.text == CardDatabase.CardName[1]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText50.text == CardDatabase.CardName[2]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText50.text == CardDatabase.CardName[3]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText50.text == CardDatabase.CardName[4]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText50.text == CardDatabase.CardName[5]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText50.text == CardDatabase.CardName[6]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText50.text == CardDatabase.CardName[7]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText50.text == CardDatabase.CardName[8]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText50.text == CardDatabase.CardName[9]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText50.text == CardDatabase.CardName[10]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText50.text == CardDatabase.CardName[23]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText50.text == CardDatabase.CardName[24]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText50.text == CardDatabase.CardName[25]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText50.text == CardDatabase.CardName[26]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText50.text == CardDatabase.CardName[27]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText50.text == CardDatabase.CardName[28]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText50.text == CardDatabase.CardName[29]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText50.text == CardDatabase.CardName[30]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText50.text == CardDatabase.CardName[31]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText50.text == CardDatabase.CardName[32]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText50.text == CardDatabase.CardName[33]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText50.text == CardDatabase.CardName[45]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText50.text == CardDatabase.CardName[46]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText50.text == CardDatabase.CardName[47]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText50.text == CardDatabase.CardName[48]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText50.text == CardDatabase.CardName[49]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText50.text == CardDatabase.CardName[50]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText50.text == CardDatabase.CardName[51]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText50.text == CardDatabase.CardName[52]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText50.text == CardDatabase.CardName[53]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText50.text == CardDatabase.CardName[54]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText50.text == CardDatabase.CardName[55]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText50.text == CardDatabase.CardName[69]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText50.text == CardDatabase.CardName[70]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText50.text == CardDatabase.CardName[71]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText50.text == CardDatabase.CardName[72]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText50.text == CardDatabase.CardName[73]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText50.text == CardDatabase.CardName[74]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText50.text == CardDatabase.CardName[75]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText50.text == CardDatabase.CardName[76]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText50.text == CardDatabase.CardName[77]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText50.text == CardDatabase.CardName[78]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText50.text == CardDatabase.CardName[79]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText50.text == CardDatabase.CardName[90]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText50.text == CardDatabase.CardName[91]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText50.text == CardDatabase.CardName[92]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText50.text == CardDatabase.CardName[93]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText50.text == CardDatabase.CardName[94]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText50.text == CardDatabase.CardName[95]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText50.text == CardDatabase.CardName[96]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText50.text == CardDatabase.CardName[97]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText50.text == CardDatabase.CardName[98]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText50.text == CardDatabase.CardName[99]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText50.text == CardDatabase.CardName[100]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText50.text == CardDatabase.CardName[113]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText50.text == CardDatabase.CardName[114]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText50.text == CardDatabase.CardName[115]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText50.text == CardDatabase.CardName[116]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText50.text == CardDatabase.CardName[117]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText50.text == CardDatabase.CardName[118]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText50.text == CardDatabase.CardName[122]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText50.text == CardDatabase.CardName[123]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText50.text == CardDatabase.CardName[124]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText50.text == CardDatabase.CardName[125]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText50.text == CardDatabase.CardName[126]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText50.text == CardDatabase.CardName[127]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText50.text == CardDatabase.CardName[128]) {
            DeckDownloaded50 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText51
        if (DeckText51.text == CardDatabase.CardName[0]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText51.text == CardDatabase.CardName[1]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText51.text == CardDatabase.CardName[2]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText51.text == CardDatabase.CardName[3]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText51.text == CardDatabase.CardName[4]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText51.text == CardDatabase.CardName[5]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText51.text == CardDatabase.CardName[6]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText51.text == CardDatabase.CardName[7]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText51.text == CardDatabase.CardName[8]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText51.text == CardDatabase.CardName[9]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText51.text == CardDatabase.CardName[10]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText51.text == CardDatabase.CardName[23]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText51.text == CardDatabase.CardName[24]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText51.text == CardDatabase.CardName[25]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText51.text == CardDatabase.CardName[26]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText51.text == CardDatabase.CardName[27]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText51.text == CardDatabase.CardName[28]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText51.text == CardDatabase.CardName[29]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText51.text == CardDatabase.CardName[30]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText51.text == CardDatabase.CardName[31]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText51.text == CardDatabase.CardName[32]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText51.text == CardDatabase.CardName[33]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText51.text == CardDatabase.CardName[45]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText51.text == CardDatabase.CardName[46]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText51.text == CardDatabase.CardName[47]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText51.text == CardDatabase.CardName[48]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText51.text == CardDatabase.CardName[49]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText51.text == CardDatabase.CardName[50]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText51.text == CardDatabase.CardName[51]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText51.text == CardDatabase.CardName[52]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText51.text == CardDatabase.CardName[53]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText51.text == CardDatabase.CardName[54]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText51.text == CardDatabase.CardName[55]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText51.text == CardDatabase.CardName[69]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText51.text == CardDatabase.CardName[70]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText51.text == CardDatabase.CardName[71]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText51.text == CardDatabase.CardName[72]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText51.text == CardDatabase.CardName[73]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText51.text == CardDatabase.CardName[74]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText51.text == CardDatabase.CardName[75]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText51.text == CardDatabase.CardName[76]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText51.text == CardDatabase.CardName[77]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText51.text == CardDatabase.CardName[78]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText51.text == CardDatabase.CardName[79]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText51.text == CardDatabase.CardName[90]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText51.text == CardDatabase.CardName[91]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText51.text == CardDatabase.CardName[92]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText51.text == CardDatabase.CardName[93]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText51.text == CardDatabase.CardName[94]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText51.text == CardDatabase.CardName[95]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText51.text == CardDatabase.CardName[96]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText51.text == CardDatabase.CardName[97]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText51.text == CardDatabase.CardName[98]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText51.text == CardDatabase.CardName[99]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText51.text == CardDatabase.CardName[100]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText51.text == CardDatabase.CardName[113]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText51.text == CardDatabase.CardName[114]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText51.text == CardDatabase.CardName[115]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText51.text == CardDatabase.CardName[116]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText51.text == CardDatabase.CardName[117]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText51.text == CardDatabase.CardName[118]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText51.text == CardDatabase.CardName[122]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText51.text == CardDatabase.CardName[123]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText51.text == CardDatabase.CardName[124]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText51.text == CardDatabase.CardName[125]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText51.text == CardDatabase.CardName[126]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText51.text == CardDatabase.CardName[127]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText51.text == CardDatabase.CardName[128]) {
            DeckDownloaded51 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText52
        if (DeckText52.text == CardDatabase.CardName[0]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText52.text == CardDatabase.CardName[1]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText52.text == CardDatabase.CardName[2]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText52.text == CardDatabase.CardName[3]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText52.text == CardDatabase.CardName[4]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText52.text == CardDatabase.CardName[5]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText52.text == CardDatabase.CardName[6]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText52.text == CardDatabase.CardName[7]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText52.text == CardDatabase.CardName[8]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText52.text == CardDatabase.CardName[9]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText52.text == CardDatabase.CardName[10]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText52.text == CardDatabase.CardName[23]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText52.text == CardDatabase.CardName[24]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText52.text == CardDatabase.CardName[25]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText52.text == CardDatabase.CardName[26]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText52.text == CardDatabase.CardName[27]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText52.text == CardDatabase.CardName[28]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText52.text == CardDatabase.CardName[29]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText52.text == CardDatabase.CardName[30]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText52.text == CardDatabase.CardName[31]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText52.text == CardDatabase.CardName[32]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText52.text == CardDatabase.CardName[33]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText52.text == CardDatabase.CardName[45]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText52.text == CardDatabase.CardName[46]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText52.text == CardDatabase.CardName[47]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText52.text == CardDatabase.CardName[48]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText52.text == CardDatabase.CardName[49]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText52.text == CardDatabase.CardName[50]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText52.text == CardDatabase.CardName[51]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText52.text == CardDatabase.CardName[52]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText52.text == CardDatabase.CardName[53]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText52.text == CardDatabase.CardName[54]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText52.text == CardDatabase.CardName[55]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText52.text == CardDatabase.CardName[69]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText52.text == CardDatabase.CardName[70]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText52.text == CardDatabase.CardName[71]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText52.text == CardDatabase.CardName[72]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText52.text == CardDatabase.CardName[73]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText52.text == CardDatabase.CardName[74]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText52.text == CardDatabase.CardName[75]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText52.text == CardDatabase.CardName[76]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText52.text == CardDatabase.CardName[77]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText52.text == CardDatabase.CardName[78]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText52.text == CardDatabase.CardName[79]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText52.text == CardDatabase.CardName[90]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText52.text == CardDatabase.CardName[91]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText52.text == CardDatabase.CardName[92]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText52.text == CardDatabase.CardName[93]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText52.text == CardDatabase.CardName[94]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText52.text == CardDatabase.CardName[95]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText52.text == CardDatabase.CardName[96]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText52.text == CardDatabase.CardName[97]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText52.text == CardDatabase.CardName[98]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText52.text == CardDatabase.CardName[99]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText52.text == CardDatabase.CardName[100]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText52.text == CardDatabase.CardName[113]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText52.text == CardDatabase.CardName[114]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText52.text == CardDatabase.CardName[115]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText52.text == CardDatabase.CardName[116]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText52.text == CardDatabase.CardName[117]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText52.text == CardDatabase.CardName[118]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText52.text == CardDatabase.CardName[122]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText52.text == CardDatabase.CardName[123]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText52.text == CardDatabase.CardName[124]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText52.text == CardDatabase.CardName[125]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText52.text == CardDatabase.CardName[126]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText52.text == CardDatabase.CardName[127]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText52.text == CardDatabase.CardName[128]) {
            DeckDownloaded52 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText53
        if (DeckText53.text == CardDatabase.CardName[0]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText53.text == CardDatabase.CardName[1]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText53.text == CardDatabase.CardName[2]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText53.text == CardDatabase.CardName[3]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText53.text == CardDatabase.CardName[4]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText53.text == CardDatabase.CardName[5]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText53.text == CardDatabase.CardName[6]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText53.text == CardDatabase.CardName[7]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText53.text == CardDatabase.CardName[8]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText53.text == CardDatabase.CardName[9]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText53.text == CardDatabase.CardName[10]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText53.text == CardDatabase.CardName[23]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText53.text == CardDatabase.CardName[24]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText53.text == CardDatabase.CardName[25]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText53.text == CardDatabase.CardName[26]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText53.text == CardDatabase.CardName[27]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText53.text == CardDatabase.CardName[28]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText53.text == CardDatabase.CardName[29]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText53.text == CardDatabase.CardName[30]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText53.text == CardDatabase.CardName[31]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText53.text == CardDatabase.CardName[32]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText53.text == CardDatabase.CardName[33]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText53.text == CardDatabase.CardName[45]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText53.text == CardDatabase.CardName[46]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText53.text == CardDatabase.CardName[47]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText53.text == CardDatabase.CardName[48]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText53.text == CardDatabase.CardName[49]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText53.text == CardDatabase.CardName[50]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText53.text == CardDatabase.CardName[51]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText53.text == CardDatabase.CardName[52]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText53.text == CardDatabase.CardName[53]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText53.text == CardDatabase.CardName[54]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText53.text == CardDatabase.CardName[55]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText53.text == CardDatabase.CardName[69]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText53.text == CardDatabase.CardName[70]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText53.text == CardDatabase.CardName[71]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText53.text == CardDatabase.CardName[72]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText53.text == CardDatabase.CardName[73]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText53.text == CardDatabase.CardName[74]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText53.text == CardDatabase.CardName[75]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText53.text == CardDatabase.CardName[76]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText53.text == CardDatabase.CardName[77]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText53.text == CardDatabase.CardName[78]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText53.text == CardDatabase.CardName[79]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText53.text == CardDatabase.CardName[90]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText53.text == CardDatabase.CardName[91]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText53.text == CardDatabase.CardName[92]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText53.text == CardDatabase.CardName[93]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText53.text == CardDatabase.CardName[94]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText53.text == CardDatabase.CardName[95]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText53.text == CardDatabase.CardName[96]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText53.text == CardDatabase.CardName[97]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText53.text == CardDatabase.CardName[98]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText53.text == CardDatabase.CardName[99]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText53.text == CardDatabase.CardName[100]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText53.text == CardDatabase.CardName[113]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText53.text == CardDatabase.CardName[114]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText53.text == CardDatabase.CardName[115]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText53.text == CardDatabase.CardName[116]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText53.text == CardDatabase.CardName[117]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText53.text == CardDatabase.CardName[118]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText53.text == CardDatabase.CardName[122]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText53.text == CardDatabase.CardName[123]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText53.text == CardDatabase.CardName[124]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText53.text == CardDatabase.CardName[125]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText53.text == CardDatabase.CardName[126]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText53.text == CardDatabase.CardName[127]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText53.text == CardDatabase.CardName[128]) {
            DeckDownloaded53 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText54
        if (DeckText54.text == CardDatabase.CardName[0]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText54.text == CardDatabase.CardName[1]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText54.text == CardDatabase.CardName[2]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText54.text == CardDatabase.CardName[3]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText54.text == CardDatabase.CardName[4]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText54.text == CardDatabase.CardName[5]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText54.text == CardDatabase.CardName[6]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText54.text == CardDatabase.CardName[7]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText54.text == CardDatabase.CardName[8]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText54.text == CardDatabase.CardName[9]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText54.text == CardDatabase.CardName[10]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText54.text == CardDatabase.CardName[23]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText54.text == CardDatabase.CardName[24]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText54.text == CardDatabase.CardName[25]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText54.text == CardDatabase.CardName[26]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText54.text == CardDatabase.CardName[27]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText54.text == CardDatabase.CardName[28]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText54.text == CardDatabase.CardName[29]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText54.text == CardDatabase.CardName[30]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText54.text == CardDatabase.CardName[31]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText54.text == CardDatabase.CardName[32]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText54.text == CardDatabase.CardName[33]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText54.text == CardDatabase.CardName[45]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText54.text == CardDatabase.CardName[46]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText54.text == CardDatabase.CardName[47]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText54.text == CardDatabase.CardName[48]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText54.text == CardDatabase.CardName[49]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText54.text == CardDatabase.CardName[50]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText54.text == CardDatabase.CardName[51]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText54.text == CardDatabase.CardName[52]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText54.text == CardDatabase.CardName[53]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText54.text == CardDatabase.CardName[54]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText54.text == CardDatabase.CardName[55]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText54.text == CardDatabase.CardName[69]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText54.text == CardDatabase.CardName[70]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText54.text == CardDatabase.CardName[71]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText54.text == CardDatabase.CardName[72]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText54.text == CardDatabase.CardName[73]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText54.text == CardDatabase.CardName[74]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText54.text == CardDatabase.CardName[75]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText54.text == CardDatabase.CardName[76]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText54.text == CardDatabase.CardName[77]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText54.text == CardDatabase.CardName[78]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText54.text == CardDatabase.CardName[79]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText54.text == CardDatabase.CardName[90]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText54.text == CardDatabase.CardName[91]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText54.text == CardDatabase.CardName[92]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText54.text == CardDatabase.CardName[93]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText54.text == CardDatabase.CardName[94]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText54.text == CardDatabase.CardName[95]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText54.text == CardDatabase.CardName[96]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText54.text == CardDatabase.CardName[97]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText54.text == CardDatabase.CardName[98]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText54.text == CardDatabase.CardName[99]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText54.text == CardDatabase.CardName[100]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText54.text == CardDatabase.CardName[113]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText54.text == CardDatabase.CardName[114]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText54.text == CardDatabase.CardName[115]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText54.text == CardDatabase.CardName[116]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText54.text == CardDatabase.CardName[117]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText54.text == CardDatabase.CardName[118]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText54.text == CardDatabase.CardName[122]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText54.text == CardDatabase.CardName[123]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText54.text == CardDatabase.CardName[124]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText54.text == CardDatabase.CardName[125]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText54.text == CardDatabase.CardName[126]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText54.text == CardDatabase.CardName[127]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText54.text == CardDatabase.CardName[128]) {
            DeckDownloaded54 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText55
        if (DeckText55.text == CardDatabase.CardName[0]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText55.text == CardDatabase.CardName[1]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText55.text == CardDatabase.CardName[2]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText55.text == CardDatabase.CardName[3]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText55.text == CardDatabase.CardName[4]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText55.text == CardDatabase.CardName[5]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText55.text == CardDatabase.CardName[6]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText55.text == CardDatabase.CardName[7]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText55.text == CardDatabase.CardName[8]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText55.text == CardDatabase.CardName[9]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText55.text == CardDatabase.CardName[10]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText55.text == CardDatabase.CardName[23]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText55.text == CardDatabase.CardName[24]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText55.text == CardDatabase.CardName[25]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText55.text == CardDatabase.CardName[26]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText55.text == CardDatabase.CardName[27]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText55.text == CardDatabase.CardName[28]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText55.text == CardDatabase.CardName[29]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText55.text == CardDatabase.CardName[30]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText55.text == CardDatabase.CardName[31]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText55.text == CardDatabase.CardName[32]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText55.text == CardDatabase.CardName[33]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText55.text == CardDatabase.CardName[45]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText55.text == CardDatabase.CardName[46]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText55.text == CardDatabase.CardName[47]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText55.text == CardDatabase.CardName[48]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText55.text == CardDatabase.CardName[49]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText55.text == CardDatabase.CardName[50]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText55.text == CardDatabase.CardName[51]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText55.text == CardDatabase.CardName[52]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText55.text == CardDatabase.CardName[53]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText55.text == CardDatabase.CardName[54]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText55.text == CardDatabase.CardName[55]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText55.text == CardDatabase.CardName[69]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText55.text == CardDatabase.CardName[70]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText55.text == CardDatabase.CardName[71]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText55.text == CardDatabase.CardName[72]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText55.text == CardDatabase.CardName[73]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText55.text == CardDatabase.CardName[74]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText55.text == CardDatabase.CardName[75]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText55.text == CardDatabase.CardName[76]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText55.text == CardDatabase.CardName[77]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText55.text == CardDatabase.CardName[78]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText55.text == CardDatabase.CardName[79]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText55.text == CardDatabase.CardName[90]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText55.text == CardDatabase.CardName[91]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText55.text == CardDatabase.CardName[92]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText55.text == CardDatabase.CardName[93]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText55.text == CardDatabase.CardName[94]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText55.text == CardDatabase.CardName[95]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText55.text == CardDatabase.CardName[96]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText55.text == CardDatabase.CardName[97]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText55.text == CardDatabase.CardName[98]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText55.text == CardDatabase.CardName[99]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText55.text == CardDatabase.CardName[100]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText55.text == CardDatabase.CardName[113]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText55.text == CardDatabase.CardName[114]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText55.text == CardDatabase.CardName[115]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText55.text == CardDatabase.CardName[116]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText55.text == CardDatabase.CardName[117]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText55.text == CardDatabase.CardName[118]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText55.text == CardDatabase.CardName[122]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText55.text == CardDatabase.CardName[123]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText55.text == CardDatabase.CardName[124]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText55.text == CardDatabase.CardName[125]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText55.text == CardDatabase.CardName[126]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText55.text == CardDatabase.CardName[127]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText55.text == CardDatabase.CardName[128]) {
            DeckDownloaded55 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText56
        if (DeckText56.text == CardDatabase.CardName[0]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText56.text == CardDatabase.CardName[1]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText56.text == CardDatabase.CardName[2]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText56.text == CardDatabase.CardName[3]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText56.text == CardDatabase.CardName[4]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText56.text == CardDatabase.CardName[5]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText56.text == CardDatabase.CardName[6]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText56.text == CardDatabase.CardName[7]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText56.text == CardDatabase.CardName[8]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText56.text == CardDatabase.CardName[9]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText56.text == CardDatabase.CardName[10]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText56.text == CardDatabase.CardName[23]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText56.text == CardDatabase.CardName[24]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText56.text == CardDatabase.CardName[25]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText56.text == CardDatabase.CardName[26]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText56.text == CardDatabase.CardName[27]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText56.text == CardDatabase.CardName[28]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText56.text == CardDatabase.CardName[29]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText56.text == CardDatabase.CardName[30]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText56.text == CardDatabase.CardName[31]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText56.text == CardDatabase.CardName[32]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText56.text == CardDatabase.CardName[33]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText56.text == CardDatabase.CardName[45]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText56.text == CardDatabase.CardName[46]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText56.text == CardDatabase.CardName[47]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText56.text == CardDatabase.CardName[48]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText56.text == CardDatabase.CardName[49]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText56.text == CardDatabase.CardName[50]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText56.text == CardDatabase.CardName[51]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText56.text == CardDatabase.CardName[52]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText56.text == CardDatabase.CardName[53]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText56.text == CardDatabase.CardName[54]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText56.text == CardDatabase.CardName[55]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText56.text == CardDatabase.CardName[69]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText56.text == CardDatabase.CardName[70]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText56.text == CardDatabase.CardName[71]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText56.text == CardDatabase.CardName[72]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText56.text == CardDatabase.CardName[73]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText56.text == CardDatabase.CardName[74]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText56.text == CardDatabase.CardName[75]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText56.text == CardDatabase.CardName[76]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText56.text == CardDatabase.CardName[77]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText56.text == CardDatabase.CardName[78]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText56.text == CardDatabase.CardName[79]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText56.text == CardDatabase.CardName[90]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText56.text == CardDatabase.CardName[91]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText56.text == CardDatabase.CardName[92]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText56.text == CardDatabase.CardName[93]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText56.text == CardDatabase.CardName[94]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText56.text == CardDatabase.CardName[95]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText56.text == CardDatabase.CardName[96]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText56.text == CardDatabase.CardName[97]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText56.text == CardDatabase.CardName[98]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText56.text == CardDatabase.CardName[99]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText56.text == CardDatabase.CardName[100]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText56.text == CardDatabase.CardName[113]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText56.text == CardDatabase.CardName[114]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText56.text == CardDatabase.CardName[115]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText56.text == CardDatabase.CardName[116]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText56.text == CardDatabase.CardName[117]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText56.text == CardDatabase.CardName[118]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText56.text == CardDatabase.CardName[122]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText56.text == CardDatabase.CardName[123]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText56.text == CardDatabase.CardName[124]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText56.text == CardDatabase.CardName[125]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText56.text == CardDatabase.CardName[126]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText56.text == CardDatabase.CardName[127]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText56.text == CardDatabase.CardName[128]) {
            DeckDownloaded56 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText57
        if (DeckText57.text == CardDatabase.CardName[0]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText57.text == CardDatabase.CardName[1]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText57.text == CardDatabase.CardName[2]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText57.text == CardDatabase.CardName[3]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText57.text == CardDatabase.CardName[4]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText57.text == CardDatabase.CardName[5]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText57.text == CardDatabase.CardName[6]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText57.text == CardDatabase.CardName[7]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText57.text == CardDatabase.CardName[8]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText57.text == CardDatabase.CardName[9]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText57.text == CardDatabase.CardName[10]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText57.text == CardDatabase.CardName[23]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText57.text == CardDatabase.CardName[24]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText57.text == CardDatabase.CardName[25]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText57.text == CardDatabase.CardName[26]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText57.text == CardDatabase.CardName[27]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText57.text == CardDatabase.CardName[28]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText57.text == CardDatabase.CardName[29]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText57.text == CardDatabase.CardName[30]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText57.text == CardDatabase.CardName[31]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText57.text == CardDatabase.CardName[32]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText57.text == CardDatabase.CardName[33]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText57.text == CardDatabase.CardName[45]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText57.text == CardDatabase.CardName[46]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText57.text == CardDatabase.CardName[47]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText57.text == CardDatabase.CardName[48]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText57.text == CardDatabase.CardName[49]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText57.text == CardDatabase.CardName[50]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText57.text == CardDatabase.CardName[51]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText57.text == CardDatabase.CardName[52]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText57.text == CardDatabase.CardName[53]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText57.text == CardDatabase.CardName[54]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText57.text == CardDatabase.CardName[55]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText57.text == CardDatabase.CardName[69]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText57.text == CardDatabase.CardName[70]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText57.text == CardDatabase.CardName[71]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText57.text == CardDatabase.CardName[72]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText57.text == CardDatabase.CardName[73]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText57.text == CardDatabase.CardName[74]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText57.text == CardDatabase.CardName[75]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText57.text == CardDatabase.CardName[76]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText57.text == CardDatabase.CardName[77]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText57.text == CardDatabase.CardName[78]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText57.text == CardDatabase.CardName[79]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText57.text == CardDatabase.CardName[90]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText57.text == CardDatabase.CardName[91]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText57.text == CardDatabase.CardName[92]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText57.text == CardDatabase.CardName[93]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText57.text == CardDatabase.CardName[94]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText57.text == CardDatabase.CardName[95]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText57.text == CardDatabase.CardName[96]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText57.text == CardDatabase.CardName[97]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText57.text == CardDatabase.CardName[98]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText57.text == CardDatabase.CardName[99]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText57.text == CardDatabase.CardName[100]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText57.text == CardDatabase.CardName[113]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText57.text == CardDatabase.CardName[114]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText57.text == CardDatabase.CardName[115]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText57.text == CardDatabase.CardName[116]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText57.text == CardDatabase.CardName[117]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText57.text == CardDatabase.CardName[118]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText57.text == CardDatabase.CardName[122]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText57.text == CardDatabase.CardName[123]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText57.text == CardDatabase.CardName[124]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText57.text == CardDatabase.CardName[125]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText57.text == CardDatabase.CardName[126]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText57.text == CardDatabase.CardName[127]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText57.text == CardDatabase.CardName[128]) {
            DeckDownloaded57 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText58
        if (DeckText58.text == CardDatabase.CardName[0]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText58.text == CardDatabase.CardName[1]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText58.text == CardDatabase.CardName[2]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText58.text == CardDatabase.CardName[3]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText58.text == CardDatabase.CardName[4]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText58.text == CardDatabase.CardName[5]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText58.text == CardDatabase.CardName[6]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText58.text == CardDatabase.CardName[7]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText58.text == CardDatabase.CardName[8]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText58.text == CardDatabase.CardName[9]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText58.text == CardDatabase.CardName[10]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText58.text == CardDatabase.CardName[23]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText58.text == CardDatabase.CardName[24]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText58.text == CardDatabase.CardName[25]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText58.text == CardDatabase.CardName[26]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText58.text == CardDatabase.CardName[27]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText58.text == CardDatabase.CardName[28]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText58.text == CardDatabase.CardName[29]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText58.text == CardDatabase.CardName[30]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText58.text == CardDatabase.CardName[31]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText58.text == CardDatabase.CardName[32]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText58.text == CardDatabase.CardName[33]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText58.text == CardDatabase.CardName[45]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText58.text == CardDatabase.CardName[46]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText58.text == CardDatabase.CardName[47]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText58.text == CardDatabase.CardName[48]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText58.text == CardDatabase.CardName[49]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText58.text == CardDatabase.CardName[50]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText58.text == CardDatabase.CardName[51]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText58.text == CardDatabase.CardName[52]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText58.text == CardDatabase.CardName[53]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText58.text == CardDatabase.CardName[54]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText58.text == CardDatabase.CardName[55]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText58.text == CardDatabase.CardName[69]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText58.text == CardDatabase.CardName[70]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText58.text == CardDatabase.CardName[71]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText58.text == CardDatabase.CardName[72]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText58.text == CardDatabase.CardName[73]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText58.text == CardDatabase.CardName[74]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText58.text == CardDatabase.CardName[75]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText58.text == CardDatabase.CardName[76]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText58.text == CardDatabase.CardName[77]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText58.text == CardDatabase.CardName[78]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText58.text == CardDatabase.CardName[79]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText58.text == CardDatabase.CardName[90]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText58.text == CardDatabase.CardName[91]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText58.text == CardDatabase.CardName[92]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText58.text == CardDatabase.CardName[93]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText58.text == CardDatabase.CardName[94]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText58.text == CardDatabase.CardName[95]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText58.text == CardDatabase.CardName[96]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText58.text == CardDatabase.CardName[97]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText58.text == CardDatabase.CardName[98]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText58.text == CardDatabase.CardName[99]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText58.text == CardDatabase.CardName[100]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText58.text == CardDatabase.CardName[113]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText58.text == CardDatabase.CardName[114]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText58.text == CardDatabase.CardName[115]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText58.text == CardDatabase.CardName[116]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText58.text == CardDatabase.CardName[117]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText58.text == CardDatabase.CardName[118]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText58.text == CardDatabase.CardName[122]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText58.text == CardDatabase.CardName[123]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText58.text == CardDatabase.CardName[124]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText58.text == CardDatabase.CardName[125]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText58.text == CardDatabase.CardName[126]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText58.text == CardDatabase.CardName[127]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText58.text == CardDatabase.CardName[128]) {
            DeckDownloaded58 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText59
        if (DeckText59.text == CardDatabase.CardName[0]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText59.text == CardDatabase.CardName[1]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText59.text == CardDatabase.CardName[2]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText59.text == CardDatabase.CardName[3]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText59.text == CardDatabase.CardName[4]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText59.text == CardDatabase.CardName[5]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText59.text == CardDatabase.CardName[6]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText59.text == CardDatabase.CardName[7]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText59.text == CardDatabase.CardName[8]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText59.text == CardDatabase.CardName[9]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText59.text == CardDatabase.CardName[10]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText59.text == CardDatabase.CardName[23]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText59.text == CardDatabase.CardName[24]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText59.text == CardDatabase.CardName[25]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText59.text == CardDatabase.CardName[26]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText59.text == CardDatabase.CardName[27]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText59.text == CardDatabase.CardName[28]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText59.text == CardDatabase.CardName[29]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText59.text == CardDatabase.CardName[30]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText59.text == CardDatabase.CardName[31]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText59.text == CardDatabase.CardName[32]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText59.text == CardDatabase.CardName[33]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText59.text == CardDatabase.CardName[45]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText59.text == CardDatabase.CardName[46]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText59.text == CardDatabase.CardName[47]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText59.text == CardDatabase.CardName[48]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText59.text == CardDatabase.CardName[49]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText59.text == CardDatabase.CardName[50]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText59.text == CardDatabase.CardName[51]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText59.text == CardDatabase.CardName[52]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText59.text == CardDatabase.CardName[53]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText59.text == CardDatabase.CardName[54]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText59.text == CardDatabase.CardName[55]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText59.text == CardDatabase.CardName[69]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText59.text == CardDatabase.CardName[70]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText59.text == CardDatabase.CardName[71]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText59.text == CardDatabase.CardName[72]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText59.text == CardDatabase.CardName[73]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText59.text == CardDatabase.CardName[74]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText59.text == CardDatabase.CardName[75]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText59.text == CardDatabase.CardName[76]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText59.text == CardDatabase.CardName[77]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText59.text == CardDatabase.CardName[78]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText59.text == CardDatabase.CardName[79]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText59.text == CardDatabase.CardName[90]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText59.text == CardDatabase.CardName[91]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText59.text == CardDatabase.CardName[92]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText59.text == CardDatabase.CardName[93]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText59.text == CardDatabase.CardName[94]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText59.text == CardDatabase.CardName[95]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText59.text == CardDatabase.CardName[96]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText59.text == CardDatabase.CardName[97]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText59.text == CardDatabase.CardName[98]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText59.text == CardDatabase.CardName[99]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText59.text == CardDatabase.CardName[100]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText59.text == CardDatabase.CardName[113]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText59.text == CardDatabase.CardName[114]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText59.text == CardDatabase.CardName[115]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText59.text == CardDatabase.CardName[116]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText59.text == CardDatabase.CardName[117]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText59.text == CardDatabase.CardName[118]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText59.text == CardDatabase.CardName[122]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText59.text == CardDatabase.CardName[123]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText59.text == CardDatabase.CardName[124]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText59.text == CardDatabase.CardName[125]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText59.text == CardDatabase.CardName[126]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText59.text == CardDatabase.CardName[127]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText59.text == CardDatabase.CardName[128]) {
            DeckDownloaded59 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText60
        if (DeckText60.text == CardDatabase.CardName[0]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText60.text == CardDatabase.CardName[1]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText60.text == CardDatabase.CardName[2]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText60.text == CardDatabase.CardName[3]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText60.text == CardDatabase.CardName[4]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText60.text == CardDatabase.CardName[5]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText60.text == CardDatabase.CardName[6]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText60.text == CardDatabase.CardName[7]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText60.text == CardDatabase.CardName[8]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText60.text == CardDatabase.CardName[9]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText60.text == CardDatabase.CardName[10]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText60.text == CardDatabase.CardName[23]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText60.text == CardDatabase.CardName[24]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText60.text == CardDatabase.CardName[25]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText60.text == CardDatabase.CardName[26]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText60.text == CardDatabase.CardName[27]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText60.text == CardDatabase.CardName[28]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText60.text == CardDatabase.CardName[29]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText60.text == CardDatabase.CardName[30]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText60.text == CardDatabase.CardName[31]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText60.text == CardDatabase.CardName[32]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText60.text == CardDatabase.CardName[33]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText60.text == CardDatabase.CardName[45]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText60.text == CardDatabase.CardName[46]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText60.text == CardDatabase.CardName[47]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText60.text == CardDatabase.CardName[48]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText60.text == CardDatabase.CardName[49]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText60.text == CardDatabase.CardName[50]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText60.text == CardDatabase.CardName[51]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText60.text == CardDatabase.CardName[52]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText60.text == CardDatabase.CardName[53]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText60.text == CardDatabase.CardName[54]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText60.text == CardDatabase.CardName[55]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText60.text == CardDatabase.CardName[69]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText60.text == CardDatabase.CardName[70]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText60.text == CardDatabase.CardName[71]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText60.text == CardDatabase.CardName[72]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText60.text == CardDatabase.CardName[73]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText60.text == CardDatabase.CardName[74]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText60.text == CardDatabase.CardName[75]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText60.text == CardDatabase.CardName[76]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText60.text == CardDatabase.CardName[77]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText60.text == CardDatabase.CardName[78]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText60.text == CardDatabase.CardName[79]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText60.text == CardDatabase.CardName[90]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText60.text == CardDatabase.CardName[91]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText60.text == CardDatabase.CardName[92]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText60.text == CardDatabase.CardName[93]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText60.text == CardDatabase.CardName[94]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText60.text == CardDatabase.CardName[95]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText60.text == CardDatabase.CardName[96]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText60.text == CardDatabase.CardName[97]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText60.text == CardDatabase.CardName[98]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText60.text == CardDatabase.CardName[99]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText60.text == CardDatabase.CardName[100]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText60.text == CardDatabase.CardName[113]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText60.text == CardDatabase.CardName[114]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText60.text == CardDatabase.CardName[115]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText60.text == CardDatabase.CardName[116]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText60.text == CardDatabase.CardName[117]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText60.text == CardDatabase.CardName[118]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText60.text == CardDatabase.CardName[122]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText60.text == CardDatabase.CardName[123]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText60.text == CardDatabase.CardName[124]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText60.text == CardDatabase.CardName[125]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText60.text == CardDatabase.CardName[126]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText60.text == CardDatabase.CardName[127]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText60.text == CardDatabase.CardName[128]) {
            DeckDownloaded60 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText61
        if (DeckText61.text == CardDatabase.CardName[0]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText61.text == CardDatabase.CardName[1]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText61.text == CardDatabase.CardName[2]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText61.text == CardDatabase.CardName[3]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText61.text == CardDatabase.CardName[4]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText61.text == CardDatabase.CardName[5]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText61.text == CardDatabase.CardName[6]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText61.text == CardDatabase.CardName[7]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText61.text == CardDatabase.CardName[8]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText61.text == CardDatabase.CardName[9]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText61.text == CardDatabase.CardName[10]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText61.text == CardDatabase.CardName[23]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText61.text == CardDatabase.CardName[24]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText61.text == CardDatabase.CardName[25]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText61.text == CardDatabase.CardName[26]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText61.text == CardDatabase.CardName[27]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText61.text == CardDatabase.CardName[28]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText61.text == CardDatabase.CardName[29]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText61.text == CardDatabase.CardName[30]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText61.text == CardDatabase.CardName[31]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText61.text == CardDatabase.CardName[32]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText61.text == CardDatabase.CardName[33]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText61.text == CardDatabase.CardName[45]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText61.text == CardDatabase.CardName[46]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText61.text == CardDatabase.CardName[47]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText61.text == CardDatabase.CardName[48]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText61.text == CardDatabase.CardName[49]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText61.text == CardDatabase.CardName[50]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText61.text == CardDatabase.CardName[51]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText61.text == CardDatabase.CardName[52]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText61.text == CardDatabase.CardName[53]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText61.text == CardDatabase.CardName[54]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText61.text == CardDatabase.CardName[55]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText61.text == CardDatabase.CardName[69]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText61.text == CardDatabase.CardName[70]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText61.text == CardDatabase.CardName[71]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText61.text == CardDatabase.CardName[72]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText61.text == CardDatabase.CardName[73]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText61.text == CardDatabase.CardName[74]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText61.text == CardDatabase.CardName[75]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText61.text == CardDatabase.CardName[76]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText61.text == CardDatabase.CardName[77]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText61.text == CardDatabase.CardName[78]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText61.text == CardDatabase.CardName[79]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText61.text == CardDatabase.CardName[90]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText61.text == CardDatabase.CardName[91]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText61.text == CardDatabase.CardName[92]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText61.text == CardDatabase.CardName[93]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText61.text == CardDatabase.CardName[94]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText61.text == CardDatabase.CardName[95]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText61.text == CardDatabase.CardName[96]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText61.text == CardDatabase.CardName[97]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText61.text == CardDatabase.CardName[98]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText61.text == CardDatabase.CardName[99]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText61.text == CardDatabase.CardName[100]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText61.text == CardDatabase.CardName[113]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText61.text == CardDatabase.CardName[114]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText61.text == CardDatabase.CardName[115]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText61.text == CardDatabase.CardName[116]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText61.text == CardDatabase.CardName[117]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText61.text == CardDatabase.CardName[118]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText61.text == CardDatabase.CardName[122]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText61.text == CardDatabase.CardName[123]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText61.text == CardDatabase.CardName[124]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText61.text == CardDatabase.CardName[125]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText61.text == CardDatabase.CardName[126]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText61.text == CardDatabase.CardName[127]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText61.text == CardDatabase.CardName[128]) {
            DeckDownloaded61 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText62
        if (DeckText62.text == CardDatabase.CardName[0]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText62.text == CardDatabase.CardName[1]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText62.text == CardDatabase.CardName[2]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText62.text == CardDatabase.CardName[3]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText62.text == CardDatabase.CardName[4]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText62.text == CardDatabase.CardName[5]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText62.text == CardDatabase.CardName[6]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText62.text == CardDatabase.CardName[7]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText62.text == CardDatabase.CardName[8]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText62.text == CardDatabase.CardName[9]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText62.text == CardDatabase.CardName[10]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText62.text == CardDatabase.CardName[23]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText62.text == CardDatabase.CardName[24]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText62.text == CardDatabase.CardName[25]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText62.text == CardDatabase.CardName[26]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText62.text == CardDatabase.CardName[27]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText62.text == CardDatabase.CardName[28]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText62.text == CardDatabase.CardName[29]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText62.text == CardDatabase.CardName[30]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText62.text == CardDatabase.CardName[31]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText62.text == CardDatabase.CardName[32]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText62.text == CardDatabase.CardName[33]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText62.text == CardDatabase.CardName[45]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText62.text == CardDatabase.CardName[46]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText62.text == CardDatabase.CardName[47]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText62.text == CardDatabase.CardName[48]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText62.text == CardDatabase.CardName[49]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText62.text == CardDatabase.CardName[50]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText62.text == CardDatabase.CardName[51]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText62.text == CardDatabase.CardName[52]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText62.text == CardDatabase.CardName[53]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText62.text == CardDatabase.CardName[54]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText62.text == CardDatabase.CardName[55]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText62.text == CardDatabase.CardName[69]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText62.text == CardDatabase.CardName[70]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText62.text == CardDatabase.CardName[71]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText62.text == CardDatabase.CardName[72]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText62.text == CardDatabase.CardName[73]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText62.text == CardDatabase.CardName[74]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText62.text == CardDatabase.CardName[75]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText62.text == CardDatabase.CardName[76]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText62.text == CardDatabase.CardName[77]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText62.text == CardDatabase.CardName[78]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText62.text == CardDatabase.CardName[79]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText62.text == CardDatabase.CardName[90]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText62.text == CardDatabase.CardName[91]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText62.text == CardDatabase.CardName[92]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText62.text == CardDatabase.CardName[93]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText62.text == CardDatabase.CardName[94]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText62.text == CardDatabase.CardName[95]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText62.text == CardDatabase.CardName[96]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText62.text == CardDatabase.CardName[97]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText62.text == CardDatabase.CardName[98]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText62.text == CardDatabase.CardName[99]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText62.text == CardDatabase.CardName[100]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText62.text == CardDatabase.CardName[113]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText62.text == CardDatabase.CardName[114]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText62.text == CardDatabase.CardName[115]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText62.text == CardDatabase.CardName[116]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText62.text == CardDatabase.CardName[117]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText62.text == CardDatabase.CardName[118]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText62.text == CardDatabase.CardName[122]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText62.text == CardDatabase.CardName[123]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText62.text == CardDatabase.CardName[124]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText62.text == CardDatabase.CardName[125]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText62.text == CardDatabase.CardName[126]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText62.text == CardDatabase.CardName[127]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText62.text == CardDatabase.CardName[128]) {
            DeckDownloaded62 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText63
        if (DeckText63.text == CardDatabase.CardName[0]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText63.text == CardDatabase.CardName[1]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText63.text == CardDatabase.CardName[2]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText63.text == CardDatabase.CardName[3]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText63.text == CardDatabase.CardName[4]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText63.text == CardDatabase.CardName[5]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText63.text == CardDatabase.CardName[6]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText63.text == CardDatabase.CardName[7]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText63.text == CardDatabase.CardName[8]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText63.text == CardDatabase.CardName[9]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText63.text == CardDatabase.CardName[10]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText63.text == CardDatabase.CardName[23]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText63.text == CardDatabase.CardName[24]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText63.text == CardDatabase.CardName[25]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText63.text == CardDatabase.CardName[26]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText63.text == CardDatabase.CardName[27]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText63.text == CardDatabase.CardName[28]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText63.text == CardDatabase.CardName[29]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText63.text == CardDatabase.CardName[30]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText63.text == CardDatabase.CardName[31]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText63.text == CardDatabase.CardName[32]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText63.text == CardDatabase.CardName[33]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText63.text == CardDatabase.CardName[45]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText63.text == CardDatabase.CardName[46]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText63.text == CardDatabase.CardName[47]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText63.text == CardDatabase.CardName[48]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText63.text == CardDatabase.CardName[49]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText63.text == CardDatabase.CardName[50]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText63.text == CardDatabase.CardName[51]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText63.text == CardDatabase.CardName[52]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText63.text == CardDatabase.CardName[53]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText63.text == CardDatabase.CardName[54]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText63.text == CardDatabase.CardName[55]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText63.text == CardDatabase.CardName[69]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText63.text == CardDatabase.CardName[70]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText63.text == CardDatabase.CardName[71]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText63.text == CardDatabase.CardName[72]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText63.text == CardDatabase.CardName[73]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText63.text == CardDatabase.CardName[74]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText63.text == CardDatabase.CardName[75]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText63.text == CardDatabase.CardName[76]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText63.text == CardDatabase.CardName[77]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText63.text == CardDatabase.CardName[78]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText63.text == CardDatabase.CardName[79]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText63.text == CardDatabase.CardName[90]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText63.text == CardDatabase.CardName[91]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText63.text == CardDatabase.CardName[92]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText63.text == CardDatabase.CardName[93]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText63.text == CardDatabase.CardName[94]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText63.text == CardDatabase.CardName[95]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText63.text == CardDatabase.CardName[96]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText63.text == CardDatabase.CardName[97]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText63.text == CardDatabase.CardName[98]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText63.text == CardDatabase.CardName[99]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText63.text == CardDatabase.CardName[100]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText63.text == CardDatabase.CardName[113]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText63.text == CardDatabase.CardName[114]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText63.text == CardDatabase.CardName[115]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText63.text == CardDatabase.CardName[116]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText63.text == CardDatabase.CardName[117]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText63.text == CardDatabase.CardName[118]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText63.text == CardDatabase.CardName[122]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText63.text == CardDatabase.CardName[123]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText63.text == CardDatabase.CardName[124]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText63.text == CardDatabase.CardName[125]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText63.text == CardDatabase.CardName[126]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText63.text == CardDatabase.CardName[127]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText63.text == CardDatabase.CardName[128]) {
            DeckDownloaded63 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText64
        if (DeckText64.text == CardDatabase.CardName[0]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText64.text == CardDatabase.CardName[1]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText64.text == CardDatabase.CardName[2]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText64.text == CardDatabase.CardName[3]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText64.text == CardDatabase.CardName[4]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText64.text == CardDatabase.CardName[5]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText64.text == CardDatabase.CardName[6]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText64.text == CardDatabase.CardName[7]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText64.text == CardDatabase.CardName[8]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText64.text == CardDatabase.CardName[9]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText64.text == CardDatabase.CardName[10]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText64.text == CardDatabase.CardName[23]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText64.text == CardDatabase.CardName[24]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText64.text == CardDatabase.CardName[25]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText64.text == CardDatabase.CardName[26]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText64.text == CardDatabase.CardName[27]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText64.text == CardDatabase.CardName[28]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText64.text == CardDatabase.CardName[29]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText64.text == CardDatabase.CardName[30]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText64.text == CardDatabase.CardName[31]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText64.text == CardDatabase.CardName[32]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText64.text == CardDatabase.CardName[33]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText64.text == CardDatabase.CardName[45]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText64.text == CardDatabase.CardName[46]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText64.text == CardDatabase.CardName[47]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText64.text == CardDatabase.CardName[48]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText64.text == CardDatabase.CardName[49]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText64.text == CardDatabase.CardName[50]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText64.text == CardDatabase.CardName[51]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText64.text == CardDatabase.CardName[52]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText64.text == CardDatabase.CardName[53]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText64.text == CardDatabase.CardName[54]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText64.text == CardDatabase.CardName[55]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText64.text == CardDatabase.CardName[69]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText64.text == CardDatabase.CardName[70]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText64.text == CardDatabase.CardName[71]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText64.text == CardDatabase.CardName[72]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText64.text == CardDatabase.CardName[73]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText64.text == CardDatabase.CardName[74]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText64.text == CardDatabase.CardName[75]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText64.text == CardDatabase.CardName[76]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText64.text == CardDatabase.CardName[77]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText64.text == CardDatabase.CardName[78]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText64.text == CardDatabase.CardName[79]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText64.text == CardDatabase.CardName[90]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText64.text == CardDatabase.CardName[91]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText64.text == CardDatabase.CardName[92]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText64.text == CardDatabase.CardName[93]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText64.text == CardDatabase.CardName[94]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText64.text == CardDatabase.CardName[95]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText64.text == CardDatabase.CardName[96]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText64.text == CardDatabase.CardName[97]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText64.text == CardDatabase.CardName[98]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText64.text == CardDatabase.CardName[99]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText64.text == CardDatabase.CardName[100]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText64.text == CardDatabase.CardName[113]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText64.text == CardDatabase.CardName[114]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText64.text == CardDatabase.CardName[115]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText64.text == CardDatabase.CardName[116]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText64.text == CardDatabase.CardName[117]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText64.text == CardDatabase.CardName[118]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText64.text == CardDatabase.CardName[122]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText64.text == CardDatabase.CardName[123]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText64.text == CardDatabase.CardName[124]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText64.text == CardDatabase.CardName[125]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText64.text == CardDatabase.CardName[126]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText64.text == CardDatabase.CardName[127]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText64.text == CardDatabase.CardName[128]) {
            DeckDownloaded64 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText65
        if (DeckText65.text == CardDatabase.CardName[0]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText65.text == CardDatabase.CardName[1]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText65.text == CardDatabase.CardName[2]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText65.text == CardDatabase.CardName[3]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText65.text == CardDatabase.CardName[4]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText65.text == CardDatabase.CardName[5]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText65.text == CardDatabase.CardName[6]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText65.text == CardDatabase.CardName[7]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText65.text == CardDatabase.CardName[8]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText65.text == CardDatabase.CardName[9]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText65.text == CardDatabase.CardName[10]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText65.text == CardDatabase.CardName[23]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText65.text == CardDatabase.CardName[24]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText65.text == CardDatabase.CardName[25]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText65.text == CardDatabase.CardName[26]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText65.text == CardDatabase.CardName[27]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText65.text == CardDatabase.CardName[28]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText65.text == CardDatabase.CardName[29]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText65.text == CardDatabase.CardName[30]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText65.text == CardDatabase.CardName[31]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText65.text == CardDatabase.CardName[32]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText65.text == CardDatabase.CardName[33]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText65.text == CardDatabase.CardName[45]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText65.text == CardDatabase.CardName[46]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText65.text == CardDatabase.CardName[47]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText65.text == CardDatabase.CardName[48]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText65.text == CardDatabase.CardName[49]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText65.text == CardDatabase.CardName[50]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText65.text == CardDatabase.CardName[51]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText65.text == CardDatabase.CardName[52]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText65.text == CardDatabase.CardName[53]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText65.text == CardDatabase.CardName[54]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText65.text == CardDatabase.CardName[55]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText65.text == CardDatabase.CardName[69]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText65.text == CardDatabase.CardName[70]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText65.text == CardDatabase.CardName[71]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText65.text == CardDatabase.CardName[72]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText65.text == CardDatabase.CardName[73]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText65.text == CardDatabase.CardName[74]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText65.text == CardDatabase.CardName[75]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText65.text == CardDatabase.CardName[76]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText65.text == CardDatabase.CardName[77]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText65.text == CardDatabase.CardName[78]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText65.text == CardDatabase.CardName[79]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText65.text == CardDatabase.CardName[90]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText65.text == CardDatabase.CardName[91]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText65.text == CardDatabase.CardName[92]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText65.text == CardDatabase.CardName[93]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText65.text == CardDatabase.CardName[94]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText65.text == CardDatabase.CardName[95]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText65.text == CardDatabase.CardName[96]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText65.text == CardDatabase.CardName[97]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText65.text == CardDatabase.CardName[98]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText65.text == CardDatabase.CardName[99]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText65.text == CardDatabase.CardName[100]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText65.text == CardDatabase.CardName[113]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText65.text == CardDatabase.CardName[114]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText65.text == CardDatabase.CardName[115]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText65.text == CardDatabase.CardName[116]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText65.text == CardDatabase.CardName[117]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText65.text == CardDatabase.CardName[118]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText65.text == CardDatabase.CardName[122]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText65.text == CardDatabase.CardName[123]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText65.text == CardDatabase.CardName[124]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText65.text == CardDatabase.CardName[125]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText65.text == CardDatabase.CardName[126]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText65.text == CardDatabase.CardName[127]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText65.text == CardDatabase.CardName[128]) {
            DeckDownloaded65 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText66
        if (DeckText66.text == CardDatabase.CardName[0]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText66.text == CardDatabase.CardName[1]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText66.text == CardDatabase.CardName[2]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText66.text == CardDatabase.CardName[3]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText66.text == CardDatabase.CardName[4]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText66.text == CardDatabase.CardName[5]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText66.text == CardDatabase.CardName[6]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText66.text == CardDatabase.CardName[7]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText66.text == CardDatabase.CardName[8]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText66.text == CardDatabase.CardName[9]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText66.text == CardDatabase.CardName[10]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText66.text == CardDatabase.CardName[23]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText66.text == CardDatabase.CardName[24]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText66.text == CardDatabase.CardName[25]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText66.text == CardDatabase.CardName[26]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText66.text == CardDatabase.CardName[27]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText66.text == CardDatabase.CardName[28]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText66.text == CardDatabase.CardName[29]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText66.text == CardDatabase.CardName[30]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText66.text == CardDatabase.CardName[31]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText66.text == CardDatabase.CardName[32]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText66.text == CardDatabase.CardName[33]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText66.text == CardDatabase.CardName[45]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText66.text == CardDatabase.CardName[46]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText66.text == CardDatabase.CardName[47]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText66.text == CardDatabase.CardName[48]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText66.text == CardDatabase.CardName[49]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText66.text == CardDatabase.CardName[50]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText66.text == CardDatabase.CardName[51]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText66.text == CardDatabase.CardName[52]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText66.text == CardDatabase.CardName[53]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText66.text == CardDatabase.CardName[54]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText66.text == CardDatabase.CardName[55]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText66.text == CardDatabase.CardName[69]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText66.text == CardDatabase.CardName[70]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText66.text == CardDatabase.CardName[71]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText66.text == CardDatabase.CardName[72]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText66.text == CardDatabase.CardName[73]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText66.text == CardDatabase.CardName[74]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText66.text == CardDatabase.CardName[75]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText66.text == CardDatabase.CardName[76]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText66.text == CardDatabase.CardName[77]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText66.text == CardDatabase.CardName[78]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText66.text == CardDatabase.CardName[79]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText66.text == CardDatabase.CardName[90]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText66.text == CardDatabase.CardName[91]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText66.text == CardDatabase.CardName[92]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText66.text == CardDatabase.CardName[93]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText66.text == CardDatabase.CardName[94]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText66.text == CardDatabase.CardName[95]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText66.text == CardDatabase.CardName[96]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText66.text == CardDatabase.CardName[97]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText66.text == CardDatabase.CardName[98]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText66.text == CardDatabase.CardName[99]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText66.text == CardDatabase.CardName[100]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText66.text == CardDatabase.CardName[113]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText66.text == CardDatabase.CardName[114]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText66.text == CardDatabase.CardName[115]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText66.text == CardDatabase.CardName[116]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText66.text == CardDatabase.CardName[117]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText66.text == CardDatabase.CardName[118]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText66.text == CardDatabase.CardName[122]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText66.text == CardDatabase.CardName[123]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText66.text == CardDatabase.CardName[124]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText66.text == CardDatabase.CardName[125]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText66.text == CardDatabase.CardName[126]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText66.text == CardDatabase.CardName[127]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText66.text == CardDatabase.CardName[128]) {
            DeckDownloaded66 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText67
        if (DeckText67.text == CardDatabase.CardName[0]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText67.text == CardDatabase.CardName[1]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText67.text == CardDatabase.CardName[2]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText67.text == CardDatabase.CardName[3]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText67.text == CardDatabase.CardName[4]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText67.text == CardDatabase.CardName[5]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText67.text == CardDatabase.CardName[6]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText67.text == CardDatabase.CardName[7]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText67.text == CardDatabase.CardName[8]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText67.text == CardDatabase.CardName[9]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText67.text == CardDatabase.CardName[10]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText67.text == CardDatabase.CardName[23]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText67.text == CardDatabase.CardName[24]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText67.text == CardDatabase.CardName[25]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText67.text == CardDatabase.CardName[26]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText67.text == CardDatabase.CardName[27]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText67.text == CardDatabase.CardName[28]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText67.text == CardDatabase.CardName[29]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText67.text == CardDatabase.CardName[30]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText67.text == CardDatabase.CardName[31]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText67.text == CardDatabase.CardName[32]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText67.text == CardDatabase.CardName[33]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText67.text == CardDatabase.CardName[45]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText67.text == CardDatabase.CardName[46]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText67.text == CardDatabase.CardName[47]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText67.text == CardDatabase.CardName[48]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText67.text == CardDatabase.CardName[49]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText67.text == CardDatabase.CardName[50]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText67.text == CardDatabase.CardName[51]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText67.text == CardDatabase.CardName[52]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText67.text == CardDatabase.CardName[53]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText67.text == CardDatabase.CardName[54]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText67.text == CardDatabase.CardName[55]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText67.text == CardDatabase.CardName[69]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText67.text == CardDatabase.CardName[70]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText67.text == CardDatabase.CardName[71]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText67.text == CardDatabase.CardName[72]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText67.text == CardDatabase.CardName[73]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText67.text == CardDatabase.CardName[74]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText67.text == CardDatabase.CardName[75]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText67.text == CardDatabase.CardName[76]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText67.text == CardDatabase.CardName[77]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText67.text == CardDatabase.CardName[78]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText67.text == CardDatabase.CardName[79]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText67.text == CardDatabase.CardName[90]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText67.text == CardDatabase.CardName[91]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText67.text == CardDatabase.CardName[92]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText67.text == CardDatabase.CardName[93]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText67.text == CardDatabase.CardName[94]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText67.text == CardDatabase.CardName[95]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText67.text == CardDatabase.CardName[96]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText67.text == CardDatabase.CardName[97]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText67.text == CardDatabase.CardName[98]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText67.text == CardDatabase.CardName[99]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText67.text == CardDatabase.CardName[100]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText67.text == CardDatabase.CardName[113]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText67.text == CardDatabase.CardName[114]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText67.text == CardDatabase.CardName[115]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText67.text == CardDatabase.CardName[116]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText67.text == CardDatabase.CardName[117]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText67.text == CardDatabase.CardName[118]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText67.text == CardDatabase.CardName[122]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText67.text == CardDatabase.CardName[123]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText67.text == CardDatabase.CardName[124]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText67.text == CardDatabase.CardName[125]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText67.text == CardDatabase.CardName[126]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText67.text == CardDatabase.CardName[127]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText67.text == CardDatabase.CardName[128]) {
            DeckDownloaded67 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }

        // DeckText68
        if (DeckText68.text == CardDatabase.CardName[0]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount001);
        }

        else if (DeckText68.text == CardDatabase.CardName[1]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount002);
        }

        else if (DeckText68.text == CardDatabase.CardName[2]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount003);
        }

        else if (DeckText68.text == CardDatabase.CardName[3]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount004);
        }

        else if (DeckText68.text == CardDatabase.CardName[4]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount005);
        }

        else if (DeckText68.text == CardDatabase.CardName[5]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount006);
        }

        else if (DeckText68.text == CardDatabase.CardName[6]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount007);
        }

        else if (DeckText68.text == CardDatabase.CardName[7]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount008);
        }

        else if (DeckText68.text == CardDatabase.CardName[8]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount009);
        }

        else if (DeckText68.text == CardDatabase.CardName[9]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount010);
        }

        else if (DeckText68.text == CardDatabase.CardName[10]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount011);
        }

        else if (DeckText68.text == CardDatabase.CardName[23]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount024);
        }

        else if (DeckText68.text == CardDatabase.CardName[24]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount025);
        }

        else if (DeckText68.text == CardDatabase.CardName[25]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount026);
        }

        else if (DeckText68.text == CardDatabase.CardName[26]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount027);
        }

        else if (DeckText68.text == CardDatabase.CardName[27]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount028);
        }

        else if (DeckText68.text == CardDatabase.CardName[28]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount029);
        }

        else if (DeckText68.text == CardDatabase.CardName[29]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount030);
        }

        else if (DeckText68.text == CardDatabase.CardName[30]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount031);
        }

        else if (DeckText68.text == CardDatabase.CardName[31]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount032);
        }

        else if (DeckText68.text == CardDatabase.CardName[32]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount033);
        }

        else if (DeckText68.text == CardDatabase.CardName[33]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount034);
        }

        else if (DeckText68.text == CardDatabase.CardName[45]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount046);
        }

        else if (DeckText68.text == CardDatabase.CardName[46]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount047);
        }

        else if (DeckText68.text == CardDatabase.CardName[47]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount048);
        }

        else if (DeckText68.text == CardDatabase.CardName[48]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount049);
        }

        else if (DeckText68.text == CardDatabase.CardName[49]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount050);
        }

        else if (DeckText68.text == CardDatabase.CardName[50]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount051);
        }

        else if (DeckText68.text == CardDatabase.CardName[51]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount052);
        }

        else if (DeckText68.text == CardDatabase.CardName[52]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount053);
        }

        else if (DeckText68.text == CardDatabase.CardName[53]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount054);
        }

        else if (DeckText68.text == CardDatabase.CardName[54]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount055);
        }

        else if (DeckText68.text == CardDatabase.CardName[55]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount056);
        }

        else if (DeckText68.text == CardDatabase.CardName[69]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount070);
        }

        else if (DeckText68.text == CardDatabase.CardName[70]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount071);
        }

        else if (DeckText68.text == CardDatabase.CardName[71]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount072);
        }

        else if (DeckText68.text == CardDatabase.CardName[72]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount073);
        }

        else if (DeckText68.text == CardDatabase.CardName[73]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount074);
        }

        else if (DeckText68.text == CardDatabase.CardName[74]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount075);
        }

        else if (DeckText68.text == CardDatabase.CardName[75]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount076);
        }

        else if (DeckText68.text == CardDatabase.CardName[76]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount077);
        }

        else if (DeckText68.text == CardDatabase.CardName[77]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount078);
        }

        else if (DeckText68.text == CardDatabase.CardName[78]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount079);
        }

        else if (DeckText68.text == CardDatabase.CardName[79]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount080);
        }

        else if (DeckText68.text == CardDatabase.CardName[90]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount091);
        }

        else if (DeckText68.text == CardDatabase.CardName[91]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount092);
        }

        else if (DeckText68.text == CardDatabase.CardName[92]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount093);
        }

        else if (DeckText68.text == CardDatabase.CardName[93]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount094);
        }

        else if (DeckText68.text == CardDatabase.CardName[94]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount095);
        }

        else if (DeckText68.text == CardDatabase.CardName[95]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount096);
        }

        else if (DeckText68.text == CardDatabase.CardName[96]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount097);
        }

        else if (DeckText68.text == CardDatabase.CardName[97]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount098);
        }

        else if (DeckText68.text == CardDatabase.CardName[98]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount099);
        }

        else if (DeckText68.text == CardDatabase.CardName[99]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount100);
        }

        else if (DeckText68.text == CardDatabase.CardName[100]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount101);
        }

        else if (DeckText68.text == CardDatabase.CardName[113]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount114);
        }

        else if (DeckText68.text == CardDatabase.CardName[114]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount115);
        }

        else if (DeckText68.text == CardDatabase.CardName[115]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount116);
        }

        else if (DeckText68.text == CardDatabase.CardName[116]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount117);
        }

        else if (DeckText68.text == CardDatabase.CardName[117]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount118);
        }

        else if (DeckText68.text == CardDatabase.CardName[118]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount119);
        }

        else if (DeckText68.text == CardDatabase.CardName[122]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount123);
        }

        else if (DeckText68.text == CardDatabase.CardName[123]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount124);
        }

        else if (DeckText68.text == CardDatabase.CardName[124]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount125);
        }

        else if (DeckText68.text == CardDatabase.CardName[125]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount126);
        }

        else if (DeckText68.text == CardDatabase.CardName[126]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount127);
        }

        else if (DeckText68.text == CardDatabase.CardName[127]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount128);
        }

        else if (DeckText68.text == CardDatabase.CardName[128]) {
            DeckDownloaded68 = System.Int32.Parse(PlayerDatabase.PlayerCardAmount129);
        }
    }

    public void DetermineSelectedInts() {
        DeckSelected01 = Buttons09B.DeckSelectedInt01;
        DeckSelected02 = Buttons09B.DeckSelectedInt02;
        DeckSelected03 = Buttons09B.DeckSelectedInt03;
        DeckSelected04 = Buttons09B.DeckSelectedInt04;
        DeckSelected05 = Buttons09B.DeckSelectedInt05;
        DeckSelected06 = Buttons09B.DeckSelectedInt06;
        DeckSelected07 = Buttons09B.DeckSelectedInt07;
        DeckSelected08 = Buttons09B.DeckSelectedInt08;
        DeckSelected09 = Buttons09B.DeckSelectedInt09;
        DeckSelected10 = Buttons09B.DeckSelectedInt10;
        DeckSelected11 = Buttons09B.DeckSelectedInt11;
        DeckSelected12 = Buttons09B.DeckSelectedInt12;
        DeckSelected13 = Buttons09B.DeckSelectedInt13;
        DeckSelected14 = Buttons09B.DeckSelectedInt14;
        DeckSelected15 = Buttons09B.DeckSelectedInt15;
        DeckSelected16 = Buttons09B.DeckSelectedInt16;
        DeckSelected17 = Buttons09B.DeckSelectedInt17;
        DeckSelected18 = Buttons09B.DeckSelectedInt18;
        DeckSelected19 = Buttons09B.DeckSelectedInt19;
        DeckSelected20 = Buttons09B.DeckSelectedInt20;
        DeckSelected21 = Buttons09B.DeckSelectedInt21;
        DeckSelected22 = Buttons09B.DeckSelectedInt22;
        DeckSelected23 = Buttons09B.DeckSelectedInt23;
        DeckSelected24 = Buttons09B.DeckSelectedInt24;
        DeckSelected25 = Buttons09B.DeckSelectedInt25;
        DeckSelected26 = Buttons09B.DeckSelectedInt26;
        DeckSelected27 = Buttons09B.DeckSelectedInt27;
        DeckSelected28 = Buttons09B.DeckSelectedInt28;
        DeckSelected29 = Buttons09B.DeckSelectedInt29;
        DeckSelected30 = Buttons09B.DeckSelectedInt30;
        DeckSelected31 = Buttons09B.DeckSelectedInt31;
        DeckSelected32 = Buttons09B.DeckSelectedInt32;
        DeckSelected33 = Buttons09B.DeckSelectedInt33;
        DeckSelected34 = Buttons09B.DeckSelectedInt34;
        DeckSelected35 = Buttons09B.DeckSelectedInt35;
        DeckSelected36 = Buttons09B.DeckSelectedInt36;
        DeckSelected37 = Buttons09B.DeckSelectedInt37;
        DeckSelected38 = Buttons09B.DeckSelectedInt38;
        DeckSelected39 = Buttons09B.DeckSelectedInt39;
        DeckSelected40 = Buttons09B.DeckSelectedInt40;
        DeckSelected41 = Buttons09B.DeckSelectedInt41;
        DeckSelected42 = Buttons09B.DeckSelectedInt42;
        DeckSelected43 = Buttons09B.DeckSelectedInt43;
        DeckSelected44 = Buttons09B.DeckSelectedInt44;
        DeckSelected45 = Buttons09B.DeckSelectedInt45;
        DeckSelected46 = Buttons09B.DeckSelectedInt46;
        DeckSelected47 = Buttons09B.DeckSelectedInt47;
        DeckSelected48 = Buttons09B.DeckSelectedInt48;
        DeckSelected49 = Buttons09B.DeckSelectedInt49;
        DeckSelected50 = Buttons09B.DeckSelectedInt50;
        DeckSelected51 = Buttons09B.DeckSelectedInt51;
        DeckSelected52 = Buttons09B.DeckSelectedInt52;
        DeckSelected53 = Buttons09B.DeckSelectedInt53;
        DeckSelected54 = Buttons09B.DeckSelectedInt54;
        DeckSelected55 = Buttons09B.DeckSelectedInt55;
        DeckSelected56 = Buttons09B.DeckSelectedInt56;
        DeckSelected57 = Buttons09B.DeckSelectedInt57;
        DeckSelected58 = Buttons09B.DeckSelectedInt58;
        DeckSelected59 = Buttons09B.DeckSelectedInt59;
        DeckSelected60 = Buttons09B.DeckSelectedInt60;
        DeckSelected61 = Buttons09B.DeckSelectedInt61;
        DeckSelected62 = Buttons09B.DeckSelectedInt62;
        DeckSelected63 = Buttons09B.DeckSelectedInt63;
        DeckSelected64 = Buttons09B.DeckSelectedInt64;
        DeckSelected65 = Buttons09B.DeckSelectedInt65;
        DeckSelected66 = Buttons09B.DeckSelectedInt66;
        DeckSelected67 = Buttons09B.DeckSelectedInt67;
        DeckSelected68 = Buttons09B.DeckSelectedInt68;
    }

    public void SetInitialSprites() {
        // Deck Items
        DeckIntOn01 = 0;
        DeckIntOn02 = 0;
        DeckIntOn03 = 0;
        DeckIntOn04 = 0;
        DeckIntOn05 = 0;
        DeckIntOn06 = 0;
        DeckIntOn07 = 0;
        DeckIntOn08 = 0;
        DeckIntOn09 = 0;
        DeckIntOn10 = 0;
        DeckIntOn11 = 0;
        DeckIntOn12 = 0;
        DeckIntOn13 = 0;
        DeckIntOn14 = 0;
        DeckIntOn15 = 0;
        DeckIntOn16 = 0;
        DeckIntOn17 = 0;
        DeckIntOn18 = 0;
        DeckIntOn19 = 0;
        DeckIntOn20 = 0;
        DeckIntOn21 = 0;
        DeckIntOn22 = 0;
        DeckIntOn23 = 0;
        DeckIntOn24 = 0;
        DeckIntOn25 = 0;
        DeckIntOn26 = 0;
        DeckIntOn27 = 0;
        DeckIntOn28 = 0;
        DeckIntOn29 = 0;
        DeckIntOn30 = 0;
        DeckIntOn31 = 0;
        DeckIntOn32 = 0;
        DeckIntOn33 = 0;
        DeckIntOn34 = 0;
        DeckIntOn35 = 0;
        DeckIntOn36 = 0;
        DeckIntOn37 = 0;
        DeckIntOn38 = 0;
        DeckIntOn39 = 0;
        DeckIntOn40 = 0;
        DeckIntOn41 = 0;
        DeckIntOn42 = 0;
        DeckIntOn43 = 0;
        DeckIntOn44 = 0;
        DeckIntOn45 = 0;
        DeckIntOn46 = 0;
        DeckIntOn47 = 0;
        DeckIntOn48 = 0;
        DeckIntOn49 = 0;
        DeckIntOn50 = 0;
        DeckIntOn51 = 0;
        DeckIntOn52 = 0;
        DeckIntOn53 = 0;
        DeckIntOn54 = 0;
        DeckIntOn55 = 0;
        DeckIntOn56 = 0;
        DeckIntOn57 = 0;
        DeckIntOn58 = 0;
        DeckIntOn59 = 0;
        DeckIntOn60 = 0;
        DeckIntOn61 = 0;
        DeckIntOn62 = 0;
        DeckIntOn63 = 0;
        DeckIntOn64 = 0;
        DeckIntOn65 = 0;
        DeckIntOn66 = 0;
        DeckIntOn67 = 0;
        DeckIntOn68 = 0;

        // Deck Items
        DeckDownloaded01 = 0;
        DeckDownloaded02 = 0;
        DeckDownloaded03 = 0;
        DeckDownloaded04 = 0;
        DeckDownloaded05 = 0;
        DeckDownloaded06 = 0;
        DeckDownloaded07 = 0;
        DeckDownloaded08 = 0;
        DeckDownloaded09 = 0;
        DeckDownloaded10 = 0;
        DeckDownloaded11 = 0;
        DeckDownloaded12 = 0;
        DeckDownloaded13 = 0;
        DeckDownloaded14 = 0;
        DeckDownloaded15 = 0;
        DeckDownloaded16 = 0;
        DeckDownloaded17 = 0;
        DeckDownloaded18 = 0;
        DeckDownloaded19 = 0;
        DeckDownloaded20 = 0;
        DeckDownloaded21 = 0;
        DeckDownloaded22 = 0;
        DeckDownloaded23 = 0;
        DeckDownloaded24 = 0;
        DeckDownloaded25 = 0;
        DeckDownloaded26 = 0;
        DeckDownloaded27 = 0;
        DeckDownloaded28 = 0;
        DeckDownloaded29 = 0;
        DeckDownloaded30 = 0;
        DeckDownloaded31 = 0;
        DeckDownloaded32 = 0;
        DeckDownloaded33 = 0;
        DeckDownloaded34 = 0;
        DeckDownloaded35 = 0;
        DeckDownloaded36 = 0;
        DeckDownloaded37 = 0;
        DeckDownloaded38 = 0;
        DeckDownloaded39 = 0;
        DeckDownloaded40 = 0;
        DeckDownloaded41 = 0;
        DeckDownloaded42 = 0;
        DeckDownloaded43 = 0;
        DeckDownloaded44 = 0;
        DeckDownloaded45 = 0;
        DeckDownloaded46 = 0;
        DeckDownloaded47 = 0;
        DeckDownloaded48 = 0;
        DeckDownloaded49 = 0;
        DeckDownloaded50 = 0;
        DeckDownloaded51 = 0;
        DeckDownloaded52 = 0;
        DeckDownloaded53 = 0;
        DeckDownloaded54 = 0;
        DeckDownloaded55 = 0;
        DeckDownloaded56 = 0;
        DeckDownloaded57 = 0;
        DeckDownloaded58 = 0;
        DeckDownloaded59 = 0;
        DeckDownloaded60 = 0;
        DeckDownloaded61 = 0;
        DeckDownloaded62 = 0;
        DeckDownloaded63 = 0;
        DeckDownloaded64 = 0;
        DeckDownloaded65 = 0;
        DeckDownloaded66 = 0;
        DeckDownloaded67 = 0;
        DeckDownloaded68 = 0;

        // Deck Items
        DeckSelected01 = 0;
        DeckSelected02 = 0;
        DeckSelected03 = 0;
        DeckSelected04 = 0;
        DeckSelected05 = 0;
        DeckSelected06 = 0;
        DeckSelected07 = 0;
        DeckSelected08 = 0;
        DeckSelected09 = 0;
        DeckSelected10 = 0;
        DeckSelected11 = 0;
        DeckSelected12 = 0;
        DeckSelected13 = 0;
        DeckSelected14 = 0;
        DeckSelected15 = 0;
        DeckSelected16 = 0;
        DeckSelected17 = 0;
        DeckSelected18 = 0;
        DeckSelected19 = 0;
        DeckSelected20 = 0;
        DeckSelected21 = 0;
        DeckSelected22 = 0;
        DeckSelected23 = 0;
        DeckSelected24 = 0;
        DeckSelected25 = 0;
        DeckSelected26 = 0;
        DeckSelected27 = 0;
        DeckSelected28 = 0;
        DeckSelected29 = 0;
        DeckSelected30 = 0;
        DeckSelected31 = 0;
        DeckSelected32 = 0;
        DeckSelected33 = 0;
        DeckSelected34 = 0;
        DeckSelected35 = 0;
        DeckSelected36 = 0;
        DeckSelected37 = 0;
        DeckSelected38 = 0;
        DeckSelected39 = 0;
        DeckSelected40 = 0;
        DeckSelected41 = 0;
        DeckSelected42 = 0;
        DeckSelected43 = 0;
        DeckSelected44 = 0;
        DeckSelected45 = 0;
        DeckSelected46 = 0;
        DeckSelected47 = 0;
        DeckSelected48 = 0;
        DeckSelected49 = 0;
        DeckSelected50 = 0;
        DeckSelected51 = 0;
        DeckSelected52 = 0;
        DeckSelected53 = 0;
        DeckSelected54 = 0;
        DeckSelected55 = 0;
        DeckSelected56 = 0;
        DeckSelected57 = 0;
        DeckSelected58 = 0;
        DeckSelected59 = 0;
        DeckSelected60 = 0;
        DeckSelected61 = 0;
        DeckSelected62 = 0;
        DeckSelected63 = 0;
        DeckSelected64 = 0;
        DeckSelected65 = 0;
        DeckSelected66 = 0;
        DeckSelected67 = 0;
        DeckSelected68 = 0;
    }

    public void SettingSprites() {
        // DeckOn01
        if (DeckIntOn01 == 0) {
            DeckOn01.sprite = SelectSprite;
        }

        else if (DeckIntOn01 >= 1) {
            DeckOn01.sprite = SelectedSprite;
        }

        // DeckOn02
        if (DeckIntOn02 == 0) {
            DeckOn02.sprite = SelectSprite;
        }

        else if (DeckIntOn02 >= 1) {
            DeckOn02.sprite = SelectedSprite;
        }

        // DeckOn03
        if (DeckIntOn03 == 0) {
            DeckOn03.sprite = SelectSprite;
        }

        else if (DeckIntOn03 >= 1) {
            DeckOn03.sprite = SelectedSprite;
        }

        // DeckOn04
        if (DeckIntOn04 == 0) {
            DeckOn04.sprite = SelectSprite;
        }

        else if (DeckIntOn04 >= 1) {
            DeckOn04.sprite = SelectedSprite;
        }

        // DeckOn05
        if (DeckIntOn05 == 0) {
            DeckOn05.sprite = SelectSprite;
        }

        else if (DeckIntOn05 >= 1) {
            DeckOn05.sprite = SelectedSprite;
        }

        // DeckOn06
        if (DeckIntOn06 == 0) {
            DeckOn06.sprite = SelectSprite;
        }

        else if (DeckIntOn06 >= 1) {
            DeckOn06.sprite = SelectedSprite;
        }

        // DeckOn07
        if (DeckIntOn07 == 0) {
            DeckOn07.sprite = SelectSprite;
        }

        else if (DeckIntOn07 >= 1) {
            DeckOn07.sprite = SelectedSprite;
        }

        // DeckOn08
        if (DeckIntOn08 == 0) {
            DeckOn08.sprite = SelectSprite;
        }

        else if (DeckIntOn08 >= 1) {
            DeckOn08.sprite = SelectedSprite;
        }

        // DeckOn09
        if (DeckIntOn09 == 0) {
            DeckOn09.sprite = SelectSprite;
        }

        else if (DeckIntOn09 >= 1) {
            DeckOn09.sprite = SelectedSprite;
        }

        // DeckOn10
        if (DeckIntOn10 == 0) {
            DeckOn10.sprite = SelectSprite;
        }

        else if (DeckIntOn10 >= 1) {
            DeckOn10.sprite = SelectedSprite;
        }

        // DeckOn11
        if (DeckIntOn11 == 0) {
            DeckOn11.sprite = SelectSprite;
        }

        else if (DeckIntOn11 >= 1) {
            DeckOn11.sprite = SelectedSprite;
        }

        // DeckOn12
        if (DeckIntOn12 == 0) {
            DeckOn12.sprite = SelectSprite;
        }

        else if (DeckIntOn12 >= 1) {
            DeckOn12.sprite = SelectedSprite;
        }

        // DeckOn13
        if (DeckIntOn13 == 0) {
            DeckOn13.sprite = SelectSprite;
        }

        else if (DeckIntOn13 >= 1) {
            DeckOn13.sprite = SelectedSprite;
        }

        // DeckOn14
        if (DeckIntOn14 == 0) {
            DeckOn14.sprite = SelectSprite;
        }

        else if (DeckIntOn14 >= 1) {
            DeckOn14.sprite = SelectedSprite;
        }

        // DeckOn15
        if (DeckIntOn15 == 0) {
            DeckOn15.sprite = SelectSprite;
        }

        else if (DeckIntOn15 >= 1) {
            DeckOn15.sprite = SelectedSprite;
        }

        // DeckOn16
        if (DeckIntOn16 == 0) {
            DeckOn16.sprite = SelectSprite;
        }

        else if (DeckIntOn16 >= 1) {
            DeckOn16.sprite = SelectedSprite;
        }

        // DeckOn17
        if (DeckIntOn17 == 0) {
            DeckOn17.sprite = SelectSprite;
        }

        else if (DeckIntOn17 >= 1) {
            DeckOn17.sprite = SelectedSprite;
        }

        // DeckOn18
        if (DeckIntOn18 == 0) {
            DeckOn18.sprite = SelectSprite;
        }

        else if (DeckIntOn18 >= 1) {
            DeckOn18.sprite = SelectedSprite;
        }

        // DeckOn19
        if (DeckIntOn19 == 0) {
            DeckOn19.sprite = SelectSprite;
        }

        else if (DeckIntOn19 >= 1) {
            DeckOn19.sprite = SelectedSprite;
        }

        // DeckOn20
        if (DeckIntOn20 == 0) {
            DeckOn20.sprite = SelectSprite;
        }

        else if (DeckIntOn20 >= 1) {
            DeckOn20.sprite = SelectedSprite;
        }

        // DeckOn21
        if (DeckIntOn21 == 0) {
            DeckOn21.sprite = SelectSprite;
        }

        else if (DeckIntOn21 >= 1) {
            DeckOn21.sprite = SelectedSprite;
        }

        // DeckOn22
        if (DeckIntOn22 == 0) {
            DeckOn22.sprite = SelectSprite;
        }

        else if (DeckIntOn22 >= 1) {
            DeckOn22.sprite = SelectedSprite;
        }

        // DeckOn23
        if (DeckIntOn23 == 0) {
            DeckOn23.sprite = SelectSprite;
        }

        else if (DeckIntOn23 >= 1) {
            DeckOn23.sprite = SelectedSprite;
        }

        // DeckOn24
        if (DeckIntOn24 == 0) {
            DeckOn24.sprite = SelectSprite;
        }

        else if (DeckIntOn24 >= 1) {
            DeckOn24.sprite = SelectedSprite;
        }

        // DeckOn25
        if (DeckIntOn25 == 0) {
            DeckOn25.sprite = SelectSprite;
        }

        else if (DeckIntOn25 >= 1) {
            DeckOn25.sprite = SelectedSprite;
        }

        // DeckOn26
        if (DeckIntOn26 == 0) {
            DeckOn26.sprite = SelectSprite;
        }

        else if (DeckIntOn26 >= 1) {
            DeckOn26.sprite = SelectedSprite;
        }

        // DeckOn27
        if (DeckIntOn27 == 0) {
            DeckOn27.sprite = SelectSprite;
        }

        else if (DeckIntOn27 >= 1) {
            DeckOn27.sprite = SelectedSprite;
        }

        // DeckOn28
        if (DeckIntOn28 == 0) {
            DeckOn28.sprite = SelectSprite;
        }

        else if (DeckIntOn28 >= 1) {
            DeckOn28.sprite = SelectedSprite;
        }

        // DeckOn29
        if (DeckIntOn29 == 0) {
            DeckOn29.sprite = SelectSprite;
        }

        else if (DeckIntOn29 >= 1) {
            DeckOn29.sprite = SelectedSprite;
        }

        // DeckOn30
        if (DeckIntOn30 == 0) {
            DeckOn30.sprite = SelectSprite;
        }

        else if (DeckIntOn30 >= 1) {
            DeckOn30.sprite = SelectedSprite;
        }

        // DeckOn31
        if (DeckIntOn31 == 0) {
            DeckOn31.sprite = SelectSprite;
        }

        else if (DeckIntOn31 >= 1) {
            DeckOn31.sprite = SelectedSprite;
        }

        // DeckOn32
        if (DeckIntOn32 == 0) {
            DeckOn32.sprite = SelectSprite;
        }

        else if (DeckIntOn32 >= 1) {
            DeckOn32.sprite = SelectedSprite;
        }

        // DeckOn33
        if (DeckIntOn33 == 0) {
            DeckOn33.sprite = SelectSprite;
        }

        else if (DeckIntOn33 >= 1) {
            DeckOn33.sprite = SelectedSprite;
        }

        // DeckOn34
        if (DeckIntOn34 == 0) {
            DeckOn34.sprite = SelectSprite;
        }

        else if (DeckIntOn34 >= 1) {
            DeckOn34.sprite = SelectedSprite;
        }

        // DeckOn35
        if (DeckIntOn35 == 0) {
            DeckOn35.sprite = SelectSprite;
        }

        else if (DeckIntOn35 >= 1) {
            DeckOn35.sprite = SelectedSprite;
        }

        // DeckOn36
        if (DeckIntOn36 == 0) {
            DeckOn36.sprite = SelectSprite;
        }

        else if (DeckIntOn36 >= 1) {
            DeckOn36.sprite = SelectedSprite;
        }

        // DeckOn37
        if (DeckIntOn37 == 0) {
            DeckOn37.sprite = SelectSprite;
        }

        else if (DeckIntOn37 >= 1) {
            DeckOn37.sprite = SelectedSprite;
        }

        // DeckOn38
        if (DeckIntOn38 == 0) {
            DeckOn38.sprite = SelectSprite;
        }

        else if (DeckIntOn38 >= 1) {
            DeckOn38.sprite = SelectedSprite;
        }

        // DeckOn39
        if (DeckIntOn39 == 0) {
            DeckOn39.sprite = SelectSprite;
        }

        else if (DeckIntOn39 >= 1) {
            DeckOn39.sprite = SelectedSprite;
        }

        // DeckOn40
        if (DeckIntOn40 == 0) {
            DeckOn40.sprite = SelectSprite;
        }

        else if (DeckIntOn40 >= 1) {
            DeckOn40.sprite = SelectedSprite;
        }

        // DeckOn41
        if (DeckIntOn41 == 0) {
            DeckOn41.sprite = SelectSprite;
        }

        else if (DeckIntOn41 >= 1) {
            DeckOn41.sprite = SelectedSprite;
        }

        // DeckOn42
        if (DeckIntOn42 == 0) {
            DeckOn42.sprite = SelectSprite;
        }

        else if (DeckIntOn42 >= 1) {
            DeckOn42.sprite = SelectedSprite;
        }

        // DeckOn43
        if (DeckIntOn43 == 0) {
            DeckOn43.sprite = SelectSprite;
        }

        else if (DeckIntOn43 >= 1) {
            DeckOn43.sprite = SelectedSprite;
        }

        // DeckOn44
        if (DeckIntOn44 == 0) {
            DeckOn44.sprite = SelectSprite;
        }

        else if (DeckIntOn44 >= 1) {
            DeckOn44.sprite = SelectedSprite;
        }

        // DeckOn45
        if (DeckIntOn45 == 0) {
            DeckOn45.sprite = SelectSprite;
        }

        else if (DeckIntOn45 >= 1) {
            DeckOn45.sprite = SelectedSprite;
        }

        // DeckOn46
        if (DeckIntOn46 == 0) {
            DeckOn46.sprite = SelectSprite;
        }

        else if (DeckIntOn46 >= 1) {
            DeckOn46.sprite = SelectedSprite;
        }

        // DeckOn47
        if (DeckIntOn47 == 0) {
            DeckOn47.sprite = SelectSprite;
        }

        else if (DeckIntOn47 >= 1) {
            DeckOn47.sprite = SelectedSprite;
        }

        // DeckOn48
        if (DeckIntOn48 == 0) {
            DeckOn48.sprite = SelectSprite;
        }

        else if (DeckIntOn48 >= 1) {
            DeckOn48.sprite = SelectedSprite;
        }

        // DeckOn49
        if (DeckIntOn49 == 0) {
            DeckOn49.sprite = SelectSprite;
        }

        else if (DeckIntOn49 >= 1) {
            DeckOn49.sprite = SelectedSprite;
        }

        // DeckOn50
        if (DeckIntOn50 == 0) {
            DeckOn50.sprite = SelectSprite;
        }

        else if (DeckIntOn50 >= 1) {
            DeckOn50.sprite = SelectedSprite;
        }

        // DeckOn51
        if (DeckIntOn51 == 0) {
            DeckOn51.sprite = SelectSprite;
        }

        else if (DeckIntOn51 >= 1) {
            DeckOn51.sprite = SelectedSprite;
        }

        // DeckOn52
        if (DeckIntOn52 == 0) {
            DeckOn52.sprite = SelectSprite;
        }

        else if (DeckIntOn52 >= 1) {
            DeckOn52.sprite = SelectedSprite;
        }

        // DeckOn53
        if (DeckIntOn53 == 0) {
            DeckOn53.sprite = SelectSprite;
        }

        else if (DeckIntOn53 >= 1) {
            DeckOn53.sprite = SelectedSprite;
        }

        // DeckOn54
        if (DeckIntOn54 == 0) {
            DeckOn54.sprite = SelectSprite;
        }

        else if (DeckIntOn54 >= 1) {
            DeckOn54.sprite = SelectedSprite;
        }

        // DeckOn55
        if (DeckIntOn55 == 0) {
            DeckOn55.sprite = SelectSprite;
        }

        else if (DeckIntOn55 >= 1) {
            DeckOn55.sprite = SelectedSprite;
        }

        // DeckOn56
        if (DeckIntOn56 == 0) {
            DeckOn56.sprite = SelectSprite;
        }

        else if (DeckIntOn56 >= 1) {
            DeckOn56.sprite = SelectedSprite;
        }

        // DeckOn57
        if (DeckIntOn57 == 0) {
            DeckOn57.sprite = SelectSprite;
        }

        else if (DeckIntOn57 >= 1) {
            DeckOn57.sprite = SelectedSprite;
        }

        // DeckOn58
        if (DeckIntOn58 == 0) {
            DeckOn58.sprite = SelectSprite;
        }

        else if (DeckIntOn58 >= 1) {
            DeckOn58.sprite = SelectedSprite;
        }

        // DeckOn59
        if (DeckIntOn59 == 0) {
            DeckOn59.sprite = SelectSprite;
        }

        else if (DeckIntOn59 >= 1) {
            DeckOn59.sprite = SelectedSprite;
        }

        // DeckOn60
        if (DeckIntOn60 == 0) {
            DeckOn60.sprite = SelectSprite;
        }

        else if (DeckIntOn60 >= 1) {
            DeckOn60.sprite = SelectedSprite;
        }

        // DeckOn61
        if (DeckIntOn61 == 0) {
            DeckOn61.sprite = SelectSprite;
        }

        else if (DeckIntOn61 >= 1) {
            DeckOn61.sprite = SelectedSprite;
        }

        // DeckOn62
        if (DeckIntOn62 == 0) {
            DeckOn62.sprite = SelectSprite;
        }

        else if (DeckIntOn62 >= 1) {
            DeckOn62.sprite = SelectedSprite;
        }

        // DeckOn63
        if (DeckIntOn63 == 0) {
            DeckOn63.sprite = SelectSprite;
        }

        else if (DeckIntOn63 >= 1) {
            DeckOn63.sprite = SelectedSprite;
        }

        // DeckOn64
        if (DeckIntOn64 == 0) {
            DeckOn64.sprite = SelectSprite;
        }

        else if (DeckIntOn64 >= 1) {
            DeckOn64.sprite = SelectedSprite;
        }

        // DeckOn65
        if (DeckIntOn65 == 0) {
            DeckOn65.sprite = SelectSprite;
        }

        else if (DeckIntOn65 >= 1) {
            DeckOn65.sprite = SelectedSprite;
        }

        // DeckOn66
        if (DeckIntOn66 == 0) {
            DeckOn66.sprite = SelectSprite;
        }

        else if (DeckIntOn66 >= 1) {
            DeckOn66.sprite = SelectedSprite;
        }

        // DeckOn67
        if (DeckIntOn67 == 0) {
            DeckOn67.sprite = SelectSprite;
        }

        else if (DeckIntOn67 >= 1) {
            DeckOn67.sprite = SelectedSprite;
        }

        // DeckOn68
        if (DeckIntOn68 == 0) {
            DeckOn68.sprite = SelectSprite;
        }

        else if (DeckIntOn68 >= 1) {
            DeckOn68.sprite = SelectedSprite;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}