using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons11 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button BackButton;
    public Button ZoomCloseButton;
    public Button Card001;
    public Button Card002;
    public Button Card003;
    public Button Card004;
    public Button Card005;
    public Button Card006;
    public Button Card007;
    public Button Card008;
    public Button Card009;
    public Button Card010;
    public Button Card011;
    public Button Card012;
    public Button Card013;
    public Button Card014;
    public Button Card015;
    public Button Card016;
    public Button Card017;
    public Button Card018;
    public Button Card019;
    public Button Card020;
    public Button Card021;
    public Button Card022;
    public Button Card023;
    public Button Card024;
    public Button Card025;
    public Button Card026;
    public Button Card027;
    public Button Card028;
    public Button Card029;
    public Button Card030;
    public Button Card031;
    public Button Card032;
    public Button Card033;
    public Button Card034;
    public Button Card035;
    public Button Card036;
    public Button Card037;
    public Button Card038;
    public Button Card039;
    public Button Card040;
    public Button Card041;
    public Button Card042;
    public Button Card043;
    public Button Card044;
    public Button Card045;
    public Button Card046;
    public Button Card047;
    public Button Card048;
    public Button Card049;
    public Button Card050;
    public Button Card051;
    public Button Card052;
    public Button Card053;
    public Button Card054;
    public Button Card055;
    public Button Card056;
    public Button Card057;
    public Button Card058;
    public Button Card059;
    public Button Card060;
    public Button Card061;
    public Button Card062;
    public Button Card063;
    public Button Card064;
    public Button Card065;
    public Button Card066;
    public Button Card067;
    public Button Card068;
    public Button Card069;
    public Button Card070;
    public Button Card071;
    public Button Card072;
    public Button Card073;
    public Button Card074;
    public Button Card075;
    public Button Card076;
    public Button Card077;
    public Button Card078;
    public Button Card079;
    public Button Card080;
    public Button Card081;
    public Button Card082;
    public Button Card083;
    public Button Card084;
    public Button Card085;
    public Button Card086;
    public Button Card087;
    public Button Card088;
    public Button Card089;
    public Button Card090;
    public Button Card091;
    public Button Card092;
    public Button Card093;
    public Button Card094;
    public Button Card095;
    public Button Card096;
    public Button Card097;
    public Button Card098;
    public Button Card099;
    public Button Card100;
    public Button Card101;
    public Button Card102;
    public Button Card103;
    public Button Card104;
    public Button Card105;
    public Button Card106;
    public Button Card107;
    public Button Card108;
    public Button Card109;
    public Button Card110;
    public Button Card111;
    public Button Card112;
    public Button Card113;
    public Button Card114;
    public Button Card115;
    public Button Card116;
    public Button Card117;
    public Button Card118;
    public Button Card119;
    public Button Card120;
    public Button Card121;
    public Button Card122;
    public Button Card123;
    public Button Card124;
    public Button Card125;
    public Button Card126;
    public Button Card127;
    public Button Card128;
    public Button Card129;
    public Button Card130;
    public Button Card131;
    public Button Card132;
    public Button Card133;
    public Button Card134;

    // Images
    public Image CardImage001;
    public Image CardImage002;
    public Image CardImage003;
    public Image CardImage004;
    public Image CardImage005;
    public Image CardImage006;
    public Image CardImage007;
    public Image CardImage008;
    public Image CardImage009;
    public Image CardImage010;
    public Image CardImage011;
    public Image CardImage012;
    public Image CardImage013;
    public Image CardImage014;
    public Image CardImage015;
    public Image CardImage016;
    public Image CardImage017;
    public Image CardImage018;
    public Image CardImage019;
    public Image CardImage020;
    public Image CardImage021;
    public Image CardImage022;
    public Image CardImage023;
    public Image CardImage024;
    public Image CardImage025;
    public Image CardImage026;
    public Image CardImage027;
    public Image CardImage028;
    public Image CardImage029;
    public Image CardImage030;
    public Image CardImage031;
    public Image CardImage032;
    public Image CardImage033;
    public Image CardImage034;
    public Image CardImage035;
    public Image CardImage036;
    public Image CardImage037;
    public Image CardImage038;
    public Image CardImage039;
    public Image CardImage040;
    public Image CardImage041;
    public Image CardImage042;
    public Image CardImage043;
    public Image CardImage044;
    public Image CardImage045;
    public Image CardImage046;
    public Image CardImage047;
    public Image CardImage048;
    public Image CardImage049;
    public Image CardImage050;
    public Image CardImage051;
    public Image CardImage052;
    public Image CardImage053;
    public Image CardImage054;
    public Image CardImage055;
    public Image CardImage056;
    public Image CardImage057;
    public Image CardImage058;
    public Image CardImage059;
    public Image CardImage060;
    public Image CardImage061;
    public Image CardImage062;
    public Image CardImage063;
    public Image CardImage064;
    public Image CardImage065;
    public Image CardImage066;
    public Image CardImage067;
    public Image CardImage068;
    public Image CardImage069;
    public Image CardImage070;
    public Image CardImage071;
    public Image CardImage072;
    public Image CardImage073;
    public Image CardImage074;
    public Image CardImage075;
    public Image CardImage076;
    public Image CardImage077;
    public Image CardImage078;
    public Image CardImage079;
    public Image CardImage080;
    public Image CardImage081;
    public Image CardImage082;
    public Image CardImage083;
    public Image CardImage084;
    public Image CardImage085;
    public Image CardImage086;
    public Image CardImage087;
    public Image CardImage088;
    public Image CardImage089;
    public Image CardImage090;
    public Image CardImage091;
    public Image CardImage092;
    public Image CardImage093;
    public Image CardImage094;
    public Image CardImage095;
    public Image CardImage096;
    public Image CardImage097;
    public Image CardImage098;
    public Image CardImage099;
    public Image CardImage100;
    public Image CardImage101;
    public Image CardImage102;
    public Image CardImage103;
    public Image CardImage104;
    public Image CardImage105;
    public Image CardImage106;
    public Image CardImage107;
    public Image CardImage108;
    public Image CardImage109;
    public Image CardImage110;
    public Image CardImage111;
    public Image CardImage112;
    public Image CardImage113;
    public Image CardImage114;
    public Image CardImage115;
    public Image CardImage116;
    public Image CardImage117;
    public Image CardImage118;
    public Image CardImage119;
    public Image CardImage120;
    public Image CardImage121;
    public Image CardImage122;
    public Image CardImage123;
    public Image CardImage124;
    public Image CardImage125;
    public Image CardImage126;
    public Image CardImage127;
    public Image CardImage128;
    public Image CardImage129;
    public Image CardImage130;
    public Image CardImage131;
    public Image CardImage132;
    public Image CardImage133;
    public Image CardImage134;

// -------------------- PRIVATE VARIABLES --------------------
    Color OwnedColor = new Color(1.0f, 1.0f, 1.0f);
    Color UnownedColor = new Color(0.5f, 0.5f, 0.5f);

// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene05LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // BackButton
        Button BackButtonClick = BackButton.GetComponent<Button>();
        BackButtonClick.onClick.AddListener(BackButtonClicking);

        // ZoomCloseButton
        Button ZoomCloseButtonClick = ZoomCloseButton.GetComponent<Button>();
        ZoomCloseButtonClick.onClick.AddListener(ZoomCloseButtonClicking);

        // Cards
        Button Card001Click = Card001.GetComponent<Button>();
        Button Card002Click = Card002.GetComponent<Button>();
        Button Card003Click = Card003.GetComponent<Button>();
        Button Card004Click = Card004.GetComponent<Button>();
        Button Card005Click = Card005.GetComponent<Button>();
        Button Card006Click = Card006.GetComponent<Button>();
        Button Card007Click = Card007.GetComponent<Button>();
        Button Card008Click = Card008.GetComponent<Button>();
        Button Card009Click = Card009.GetComponent<Button>();
        Button Card010Click = Card010.GetComponent<Button>();
        Button Card011Click = Card011.GetComponent<Button>();
        Button Card012Click = Card012.GetComponent<Button>();
        Button Card013Click = Card013.GetComponent<Button>();
        Button Card014Click = Card014.GetComponent<Button>();
        Button Card015Click = Card015.GetComponent<Button>();
        Button Card016Click = Card016.GetComponent<Button>();
        Button Card017Click = Card017.GetComponent<Button>();
        Button Card018Click = Card018.GetComponent<Button>();
        Button Card019Click = Card019.GetComponent<Button>();
        Button Card020Click = Card020.GetComponent<Button>();
        Button Card021Click = Card021.GetComponent<Button>();
        Button Card022Click = Card022.GetComponent<Button>();
        Button Card023Click = Card023.GetComponent<Button>();
        Button Card024Click = Card024.GetComponent<Button>();
        Button Card025Click = Card025.GetComponent<Button>();
        Button Card026Click = Card026.GetComponent<Button>();
        Button Card027Click = Card027.GetComponent<Button>();
        Button Card028Click = Card028.GetComponent<Button>();
        Button Card029Click = Card029.GetComponent<Button>();
        Button Card030Click = Card030.GetComponent<Button>();
        Button Card031Click = Card031.GetComponent<Button>();
        Button Card032Click = Card032.GetComponent<Button>();
        Button Card033Click = Card033.GetComponent<Button>();
        Button Card034Click = Card034.GetComponent<Button>();
        Button Card035Click = Card035.GetComponent<Button>();
        Button Card036Click = Card036.GetComponent<Button>();
        Button Card037Click = Card037.GetComponent<Button>();
        Button Card038Click = Card038.GetComponent<Button>();
        Button Card039Click = Card039.GetComponent<Button>();
        Button Card040Click = Card040.GetComponent<Button>();
        Button Card041Click = Card041.GetComponent<Button>();
        Button Card042Click = Card042.GetComponent<Button>();
        Button Card043Click = Card043.GetComponent<Button>();
        Button Card044Click = Card044.GetComponent<Button>();
        Button Card045Click = Card045.GetComponent<Button>();
        Button Card046Click = Card046.GetComponent<Button>();
        Button Card047Click = Card047.GetComponent<Button>();
        Button Card048Click = Card048.GetComponent<Button>();
        Button Card049Click = Card049.GetComponent<Button>();
        Button Card050Click = Card050.GetComponent<Button>();
        Button Card051Click = Card051.GetComponent<Button>();
        Button Card052Click = Card052.GetComponent<Button>();
        Button Card053Click = Card053.GetComponent<Button>();
        Button Card054Click = Card054.GetComponent<Button>();
        Button Card055Click = Card055.GetComponent<Button>();
        Button Card056Click = Card056.GetComponent<Button>();
        Button Card057Click = Card057.GetComponent<Button>();
        Button Card058Click = Card058.GetComponent<Button>();
        Button Card059Click = Card059.GetComponent<Button>();
        Button Card060Click = Card060.GetComponent<Button>();
        Button Card061Click = Card061.GetComponent<Button>();
        Button Card062Click = Card062.GetComponent<Button>();
        Button Card063Click = Card063.GetComponent<Button>();
        Button Card064Click = Card064.GetComponent<Button>();
        Button Card065Click = Card065.GetComponent<Button>();
        Button Card066Click = Card066.GetComponent<Button>();
        Button Card067Click = Card067.GetComponent<Button>();
        Button Card068Click = Card068.GetComponent<Button>();
        Button Card069Click = Card069.GetComponent<Button>();
        Button Card070Click = Card070.GetComponent<Button>();
        Button Card071Click = Card071.GetComponent<Button>();
        Button Card072Click = Card072.GetComponent<Button>();
        Button Card073Click = Card073.GetComponent<Button>();
        Button Card074Click = Card074.GetComponent<Button>();
        Button Card075Click = Card075.GetComponent<Button>();
        Button Card076Click = Card076.GetComponent<Button>();
        Button Card077Click = Card077.GetComponent<Button>();
        Button Card078Click = Card078.GetComponent<Button>();
        Button Card079Click = Card079.GetComponent<Button>();
        Button Card080Click = Card080.GetComponent<Button>();
        Button Card081Click = Card081.GetComponent<Button>();
        Button Card082Click = Card082.GetComponent<Button>();
        Button Card083Click = Card083.GetComponent<Button>();
        Button Card084Click = Card084.GetComponent<Button>();
        Button Card085Click = Card085.GetComponent<Button>();
        Button Card086Click = Card086.GetComponent<Button>();
        Button Card087Click = Card087.GetComponent<Button>();
        Button Card088Click = Card088.GetComponent<Button>();
        Button Card089Click = Card089.GetComponent<Button>();
        Button Card090Click = Card090.GetComponent<Button>();
        Button Card091Click = Card091.GetComponent<Button>();
        Button Card092Click = Card092.GetComponent<Button>();
        Button Card093Click = Card093.GetComponent<Button>();
        Button Card094Click = Card094.GetComponent<Button>();
        Button Card095Click = Card095.GetComponent<Button>();
        Button Card096Click = Card096.GetComponent<Button>();
        Button Card097Click = Card097.GetComponent<Button>();
        Button Card098Click = Card098.GetComponent<Button>();
        Button Card099Click = Card099.GetComponent<Button>();
        Button Card100Click = Card100.GetComponent<Button>();
        Button Card101Click = Card101.GetComponent<Button>();
        Button Card102Click = Card102.GetComponent<Button>();
        Button Card103Click = Card103.GetComponent<Button>();
        Button Card104Click = Card104.GetComponent<Button>();
        Button Card105Click = Card105.GetComponent<Button>();
        Button Card106Click = Card106.GetComponent<Button>();
        Button Card107Click = Card107.GetComponent<Button>();
        Button Card108Click = Card108.GetComponent<Button>();
        Button Card109Click = Card109.GetComponent<Button>();
        Button Card110Click = Card110.GetComponent<Button>();
        Button Card111Click = Card111.GetComponent<Button>();
        Button Card112Click = Card112.GetComponent<Button>();
        Button Card113Click = Card113.GetComponent<Button>();
        Button Card114Click = Card114.GetComponent<Button>();
        Button Card115Click = Card115.GetComponent<Button>();
        Button Card116Click = Card116.GetComponent<Button>();
        Button Card117Click = Card117.GetComponent<Button>();
        Button Card118Click = Card118.GetComponent<Button>();
        Button Card119Click = Card119.GetComponent<Button>();
        Button Card120Click = Card120.GetComponent<Button>();
        Button Card121Click = Card121.GetComponent<Button>();
        Button Card122Click = Card122.GetComponent<Button>();
        Button Card123Click = Card123.GetComponent<Button>();
        Button Card124Click = Card124.GetComponent<Button>();
        Button Card125Click = Card125.GetComponent<Button>();
        Button Card126Click = Card126.GetComponent<Button>();
        Button Card127Click = Card127.GetComponent<Button>();
        Button Card128Click = Card128.GetComponent<Button>();
        Button Card129Click = Card129.GetComponent<Button>();
        Button Card130Click = Card130.GetComponent<Button>();
        Button Card131Click = Card131.GetComponent<Button>();
        Button Card132Click = Card132.GetComponent<Button>();
        Button Card133Click = Card133.GetComponent<Button>();
        Button Card134Click = Card134.GetComponent<Button>();

        Card001Click.onClick.AddListener(Card001Clicking);
        Card002Click.onClick.AddListener(Card002Clicking);
        Card003Click.onClick.AddListener(Card003Clicking);
        Card004Click.onClick.AddListener(Card004Clicking);
        Card005Click.onClick.AddListener(Card005Clicking);
        Card006Click.onClick.AddListener(Card006Clicking);
        Card007Click.onClick.AddListener(Card007Clicking);
        Card008Click.onClick.AddListener(Card008Clicking);
        Card009Click.onClick.AddListener(Card009Clicking);
        Card010Click.onClick.AddListener(Card010Clicking);
        Card011Click.onClick.AddListener(Card011Clicking);
        Card012Click.onClick.AddListener(Card012Clicking);
        Card013Click.onClick.AddListener(Card013Clicking);
        Card014Click.onClick.AddListener(Card014Clicking);
        Card015Click.onClick.AddListener(Card015Clicking);
        Card016Click.onClick.AddListener(Card016Clicking);
        Card017Click.onClick.AddListener(Card017Clicking);
        Card018Click.onClick.AddListener(Card018Clicking);
        Card019Click.onClick.AddListener(Card019Clicking);
        Card020Click.onClick.AddListener(Card020Clicking);
        Card021Click.onClick.AddListener(Card021Clicking);
        Card022Click.onClick.AddListener(Card022Clicking);
        Card023Click.onClick.AddListener(Card023Clicking);
        Card024Click.onClick.AddListener(Card024Clicking);
        Card025Click.onClick.AddListener(Card025Clicking);
        Card026Click.onClick.AddListener(Card026Clicking);
        Card027Click.onClick.AddListener(Card027Clicking);
        Card028Click.onClick.AddListener(Card028Clicking);
        Card029Click.onClick.AddListener(Card029Clicking);
        Card030Click.onClick.AddListener(Card030Clicking);
        Card031Click.onClick.AddListener(Card031Clicking);
        Card032Click.onClick.AddListener(Card032Clicking);
        Card033Click.onClick.AddListener(Card033Clicking);
        Card034Click.onClick.AddListener(Card034Clicking);
        Card035Click.onClick.AddListener(Card035Clicking);
        Card036Click.onClick.AddListener(Card036Clicking);
        Card037Click.onClick.AddListener(Card037Clicking);
        Card038Click.onClick.AddListener(Card038Clicking);
        Card039Click.onClick.AddListener(Card039Clicking);
        Card040Click.onClick.AddListener(Card040Clicking);
        Card041Click.onClick.AddListener(Card041Clicking);
        Card042Click.onClick.AddListener(Card042Clicking);
        Card043Click.onClick.AddListener(Card043Clicking);
        Card044Click.onClick.AddListener(Card044Clicking);
        Card045Click.onClick.AddListener(Card045Clicking);
        Card046Click.onClick.AddListener(Card046Clicking);
        Card047Click.onClick.AddListener(Card047Clicking);
        Card048Click.onClick.AddListener(Card048Clicking);
        Card049Click.onClick.AddListener(Card049Clicking);
        Card050Click.onClick.AddListener(Card050Clicking);
        Card051Click.onClick.AddListener(Card051Clicking);
        Card052Click.onClick.AddListener(Card052Clicking);
        Card053Click.onClick.AddListener(Card053Clicking);
        Card054Click.onClick.AddListener(Card054Clicking);
        Card055Click.onClick.AddListener(Card055Clicking);
        Card056Click.onClick.AddListener(Card056Clicking);
        Card057Click.onClick.AddListener(Card057Clicking);
        Card058Click.onClick.AddListener(Card058Clicking);
        Card059Click.onClick.AddListener(Card059Clicking);
        Card060Click.onClick.AddListener(Card060Clicking);
        Card061Click.onClick.AddListener(Card061Clicking);
        Card062Click.onClick.AddListener(Card062Clicking);
        Card063Click.onClick.AddListener(Card063Clicking);
        Card064Click.onClick.AddListener(Card064Clicking);
        Card065Click.onClick.AddListener(Card065Clicking);
        Card066Click.onClick.AddListener(Card066Clicking);
        Card067Click.onClick.AddListener(Card067Clicking);
        Card068Click.onClick.AddListener(Card068Clicking);
        Card069Click.onClick.AddListener(Card069Clicking);
        Card070Click.onClick.AddListener(Card070Clicking);
        Card071Click.onClick.AddListener(Card071Clicking);
        Card072Click.onClick.AddListener(Card072Clicking);
        Card073Click.onClick.AddListener(Card073Clicking);
        Card074Click.onClick.AddListener(Card074Clicking);
        Card075Click.onClick.AddListener(Card075Clicking);
        Card076Click.onClick.AddListener(Card076Clicking);
        Card077Click.onClick.AddListener(Card077Clicking);
        Card078Click.onClick.AddListener(Card078Clicking);
        Card079Click.onClick.AddListener(Card079Clicking);
        Card080Click.onClick.AddListener(Card080Clicking);
        Card081Click.onClick.AddListener(Card081Clicking);
        Card082Click.onClick.AddListener(Card082Clicking);
        Card083Click.onClick.AddListener(Card083Clicking);
        Card084Click.onClick.AddListener(Card084Clicking);
        Card085Click.onClick.AddListener(Card085Clicking);
        Card086Click.onClick.AddListener(Card086Clicking);
        Card087Click.onClick.AddListener(Card087Clicking);
        Card088Click.onClick.AddListener(Card088Clicking);
        Card089Click.onClick.AddListener(Card089Clicking);
        Card090Click.onClick.AddListener(Card090Clicking);
        Card091Click.onClick.AddListener(Card091Clicking);
        Card092Click.onClick.AddListener(Card092Clicking);
        Card093Click.onClick.AddListener(Card093Clicking);
        Card094Click.onClick.AddListener(Card094Clicking);
        Card095Click.onClick.AddListener(Card095Clicking);
        Card096Click.onClick.AddListener(Card096Clicking);
        Card097Click.onClick.AddListener(Card097Clicking);
        Card098Click.onClick.AddListener(Card098Clicking);
        Card099Click.onClick.AddListener(Card099Clicking);
        Card100Click.onClick.AddListener(Card100Clicking);
        Card101Click.onClick.AddListener(Card101Clicking);
        Card102Click.onClick.AddListener(Card102Clicking);
        Card103Click.onClick.AddListener(Card103Clicking);
        Card104Click.onClick.AddListener(Card104Clicking);
        Card105Click.onClick.AddListener(Card105Clicking);
        Card106Click.onClick.AddListener(Card106Clicking);
        Card107Click.onClick.AddListener(Card107Clicking);
        Card108Click.onClick.AddListener(Card108Clicking);
        Card109Click.onClick.AddListener(Card109Clicking);
        Card110Click.onClick.AddListener(Card110Clicking);
        Card111Click.onClick.AddListener(Card111Clicking);
        Card112Click.onClick.AddListener(Card112Clicking);
        Card113Click.onClick.AddListener(Card113Clicking);
        Card114Click.onClick.AddListener(Card114Clicking);
        Card115Click.onClick.AddListener(Card115Clicking);
        Card116Click.onClick.AddListener(Card116Clicking);
        Card117Click.onClick.AddListener(Card117Clicking);
        Card118Click.onClick.AddListener(Card118Clicking);
        Card119Click.onClick.AddListener(Card119Clicking);
        Card120Click.onClick.AddListener(Card120Clicking);
        Card121Click.onClick.AddListener(Card121Clicking);
        Card122Click.onClick.AddListener(Card122Clicking);
        Card123Click.onClick.AddListener(Card123Clicking);
        Card124Click.onClick.AddListener(Card124Clicking);
        Card125Click.onClick.AddListener(Card125Clicking);
        Card126Click.onClick.AddListener(Card126Clicking);
        Card127Click.onClick.AddListener(Card127Clicking);
        Card128Click.onClick.AddListener(Card128Clicking);
        Card129Click.onClick.AddListener(Card129Clicking);
        Card130Click.onClick.AddListener(Card130Clicking);
        Card131Click.onClick.AddListener(Card131Clicking);
        Card132Click.onClick.AddListener(Card132Clicking);
        Card133Click.onClick.AddListener(Card133Clicking);
        Card134Click.onClick.AddListener(Card134Clicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
    public void BackButtonClicking() {
        Scene05LoadRun.Scene05Load();
    }

    public void ZoomCloseButtonClicking() {
        EnableObjects11.ZoomingInCard = 0;
        EnableObjects11.ZoomInNumber = 0;
    }

    public void Card001Clicking() {
        if (CardImage001.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 0;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card002Clicking() {
        if (CardImage002.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 1;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card003Clicking() {
        if (CardImage003.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 2;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card004Clicking() {
        if (CardImage004.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 3;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card005Clicking() {
        if (CardImage005.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 4;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card006Clicking() {
        if (CardImage006.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 5;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card007Clicking() {
        if (CardImage007.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 6;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card008Clicking() {
        if (CardImage008.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 7;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card009Clicking() {
        if (CardImage009.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 8;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card010Clicking() {
        if (CardImage010.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 9;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card011Clicking() {
        if (CardImage011.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 10;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card012Clicking() {
        if (CardImage012.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 11;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card013Clicking() {
        if (CardImage013.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 12;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card014Clicking() {
        if (CardImage014.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 13;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card015Clicking() {
        if (CardImage015.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 14;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card016Clicking() {
        if (CardImage016.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 15;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card017Clicking() {
        if (CardImage017.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 16;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card018Clicking() {
        if (CardImage018.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 17;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card019Clicking() {
        if (CardImage019.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 18;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card020Clicking() {
        if (CardImage020.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 19;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card021Clicking() {
        if (CardImage021.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 20;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card022Clicking() {
        if (CardImage022.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 21;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card023Clicking() {
        if (CardImage023.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 22;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card024Clicking() {
        if (CardImage024.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 23;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card025Clicking() {
        if (CardImage025.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 24;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card026Clicking() {
        if (CardImage026.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 25;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card027Clicking() {
        if (CardImage027.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 26;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card028Clicking() {
        if (CardImage028.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 27;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card029Clicking() {
        if (CardImage029.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 28;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card030Clicking() {
        if (CardImage030.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 29;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card031Clicking() {
        if (CardImage031.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 30;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card032Clicking() {
        if (CardImage032.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 31;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card033Clicking() {
        if (CardImage033.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 32;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card034Clicking() {
        if (CardImage034.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 33;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card035Clicking() {
        if (CardImage035.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 34;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card036Clicking() {
        if (CardImage036.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 35;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card037Clicking() {
        if (CardImage037.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 36;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card038Clicking() {
        if (CardImage038.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 37;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card039Clicking() {
        if (CardImage039.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 38;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card040Clicking() {
        if (CardImage040.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 39;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card041Clicking() {
        if (CardImage041.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 40;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card042Clicking() {
        if (CardImage042.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 41;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card043Clicking() {
        if (CardImage043.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 42;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card044Clicking() {
        if (CardImage044.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 43;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card045Clicking() {
        if (CardImage045.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 44;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card046Clicking() {
        if (CardImage046.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 45;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card047Clicking() {
        if (CardImage047.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 46;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card048Clicking() {
        if (CardImage048.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 47;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card049Clicking() {
        if (CardImage049.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 48;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card050Clicking() {
        if (CardImage050.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 49;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card051Clicking() {
        if (CardImage051.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 50;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card052Clicking() {
        if (CardImage052.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 51;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card053Clicking() {
        if (CardImage053.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 52;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card054Clicking() {
        if (CardImage054.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 53;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card055Clicking() {
        if (CardImage055.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 54;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card056Clicking() {
        if (CardImage056.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 55;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card057Clicking() {
        if (CardImage057.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 56;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card058Clicking() {
        if (CardImage058.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 57;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card059Clicking() {
        if (CardImage059.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 58;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card060Clicking() {
        if (CardImage060.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 59;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card061Clicking() {
        if (CardImage061.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 60;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card062Clicking() {
        if (CardImage062.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 61;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card063Clicking() {
        if (CardImage063.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 62;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card064Clicking() {
        if (CardImage064.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 63;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card065Clicking() {
        if (CardImage065.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 64;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card066Clicking() {
        if (CardImage066.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 65;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card067Clicking() {
        if (CardImage067.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 66;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card068Clicking() {
        if (CardImage068.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 67;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card069Clicking() {
        if (CardImage069.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 68;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card070Clicking() {
        if (CardImage070.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 69;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card071Clicking() {
        if (CardImage071.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 70;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card072Clicking() {
        if (CardImage072.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 71;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card073Clicking() {
        if (CardImage073.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 72;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card074Clicking() {
        if (CardImage074.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 73;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card075Clicking() {
        if (CardImage075.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 74;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card076Clicking() {
        if (CardImage076.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 75;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card077Clicking() {
        if (CardImage077.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 76;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card078Clicking() {
        if (CardImage078.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 77;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card079Clicking() {
        if (CardImage079.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 78;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card080Clicking() {
        if (CardImage080.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 79;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card081Clicking() {
        if (CardImage081.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 80;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card082Clicking() {
        if (CardImage082.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 81;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card083Clicking() {
        if (CardImage083.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 82;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card084Clicking() {
        if (CardImage084.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 83;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card085Clicking() {
        if (CardImage085.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 84;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card086Clicking() {
        if (CardImage086.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 85;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card087Clicking() {
        if (CardImage087.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 86;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card088Clicking() {
        if (CardImage088.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 87;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card089Clicking() {
        if (CardImage089.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 88;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card090Clicking() {
        if (CardImage090.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 89;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card091Clicking() {
        if (CardImage091.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 90;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card092Clicking() {
        if (CardImage092.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 91;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card093Clicking() {
        if (CardImage093.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 92;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card094Clicking() {
        if (CardImage094.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 93;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card095Clicking() {
        if (CardImage095.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 94;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card096Clicking() {
        if (CardImage096.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 95;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card097Clicking() {
        if (CardImage097.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 96;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card098Clicking() {
        if (CardImage098.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 97;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card099Clicking() {
        if (CardImage099.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 98;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card100Clicking() {
        if (CardImage100.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 99;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card101Clicking() {
        if (CardImage101.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 100;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card102Clicking() {
        if (CardImage102.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 101;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card103Clicking() {
        if (CardImage103.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 102;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card104Clicking() {
        if (CardImage104.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 103;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card105Clicking() {
        if (CardImage105.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 104;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card106Clicking() {
        if (CardImage106.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 105;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card107Clicking() {
        if (CardImage107.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 106;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card108Clicking() {
        if (CardImage108.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 107;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card109Clicking() {
        if (CardImage109.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 108;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card110Clicking() {
        if (CardImage110.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 109;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card111Clicking() {
        if (CardImage111.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 110;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card112Clicking() {
        if (CardImage112.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 111;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card113Clicking() {
        if (CardImage113.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 112;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card114Clicking() {
        if (CardImage114.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 113;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card115Clicking() {
        if (CardImage115.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 114;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card116Clicking() {
        if (CardImage116.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 115;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card117Clicking() {
        if (CardImage117.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 116;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card118Clicking() {
        if (CardImage118.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 117;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card119Clicking() {
        if (CardImage119.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 118;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card120Clicking() {
        if (CardImage120.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 119;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card121Clicking() {
        if (CardImage121.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 120;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card122Clicking() {
        if (CardImage122.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 121;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card123Clicking() {
        if (CardImage123.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 122;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card124Clicking() {
        if (CardImage124.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 123;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card125Clicking() {
        if (CardImage125.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 124;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card126Clicking() {
        if (CardImage126.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 125;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card127Clicking() {
        if (CardImage127.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 126;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card128Clicking() {
        if (CardImage128.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 127;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card129Clicking() {
        if (CardImage129.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 128;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card130Clicking() {
        if (CardImage130.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 129;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card131Clicking() {
        if (CardImage131.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 130;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card132Clicking() {
        if (CardImage132.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 131;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card133Clicking() {
        if (CardImage133.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 132;
            EnableObjects11.ZoomingInCard = 1;
        }
    }
    
    public void Card134Clicking() {
        if (CardImage134.GetComponent<Image>().color == UnownedColor) {
            // Do nothing
        }

        else {
            EnableObjects11.ZoomInNumber = 133;
            EnableObjects11.ZoomingInCard = 1;
        }
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}