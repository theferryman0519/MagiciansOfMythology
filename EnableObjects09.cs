using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnableObjects09 : MonoBehaviour {

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

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    public static int GamePlayPanelInt;

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------


// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        GamePlayPanelInt = 0;
        EnableMain();
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        ShowingPanels();
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
    public void ShowingPanels() {
        if (GamePlayPanelInt == 0) {
            TitleText.text = "Duel Set-Up:" + "\n" + "Choose Your Gods";
            ActionText.text = "Before starting the duel, you must select up to five (5) gods to do battle on your behalf. Below is the list of all gods, with cards you own at the top. Select up five and then click Next to continue.";
            ShowGodsItems();
        }

        else if (GamePlayPanelInt == 1) {
            TitleText.text = "Duel Set-Up:" + "\n" + "Choose Your Deck";
            ActionText.text = "Next, you must choose up to fifteen (15) cards to form your hand. These are a mix of both Realm and Myth cards, so choose wisely. Select up five and then click Start to begin the duel. Good luck!";
            ShowDeckItems();
        }

        else if (GamePlayPanelInt == 2) {
            TitleText.enabled = false;
            ActionText.enabled = false;
        }
    }

    public void ShowGodsItems() {
        // Disable All Items
        DisableAllGodsItems();
        DisableAllDeckItems();

        // Enable Main Items
        PickGodsScroll.enabled = true;
        PickGodsView.enabled = true;
        SelectedText.enabled = true;
        ContinueButton.enabled = true;

        // Deselect All
    }

    public void ShowDeckItems() {
        // Disable All Items
        DisableAllGodsItems();
        DisableAllDeckItems();

        // Enable Main Items
        PickDeckScroll.enabled = true;
        PickDeckView.enabled = true;
        SelectedDeckText.enabled = true;
        BeginButton.enabled = true;

        // Deselect All
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}