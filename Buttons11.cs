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

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene07LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        // BackButton
        Button BackButtonClick = BackButton.GetComponent<Button>();
        BackButtonClick.onClick.AddListener(BackButtonClicking);

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
        Scene07LoadRun.Scene07Load();
    }

    public void Card001Clicking() {
        //
    }
    
    public void Card002Clicking() {
        //
    }
    
    public void Card003Clicking() {
        //
    }
    
    public void Card004Clicking() {
        //
    }
    
    public void Card005Clicking() {
        //
    }
    
    public void Card006Clicking() {
        //
    }
    
    public void Card007Clicking() {
        //
    }
    
    public void Card008Clicking() {
        //
    }
    
    public void Card009Clicking() {
        //
    }
    
    public void Card010Clicking() {
        //
    }
    
    public void Card011Clicking() {
        //
    }
    
    public void Card012Clicking() {
        //
    }
    
    public void Card013Clicking() {
        //
    }
    
    public void Card014Clicking() {
        //
    }
    
    public void Card015Clicking() {
        //
    }
    
    public void Card016Clicking() {
        //
    }
    
    public void Card017Clicking() {
        //
    }
    
    public void Card018Clicking() {
        //
    }
    
    public void Card019Clicking() {
        //
    }
    
    public void Card020Clicking() {
        //
    }
    
    public void Card021Clicking() {
        //
    }
    
    public void Card022Clicking() {
        //
    }
    
    public void Card023Clicking() {
        //
    }
    
    public void Card024Clicking() {
        //
    }
    
    public void Card025Clicking() {
        //
    }
    
    public void Card026Clicking() {
        //
    }
    
    public void Card027Clicking() {
        //
    }
    
    public void Card028Clicking() {
        //
    }
    
    public void Card029Clicking() {
        //
    }
    
    public void Card030Clicking() {
        //
    }
    
    public void Card031Clicking() {
        //
    }
    
    public void Card032Clicking() {
        //
    }
    
    public void Card033Clicking() {
        //
    }
    
    public void Card034Clicking() {
        //
    }
    
    public void Card035Clicking() {
        //
    }
    
    public void Card036Clicking() {
        //
    }
    
    public void Card037Clicking() {
        //
    }
    
    public void Card038Clicking() {
        //
    }
    
    public void Card039Clicking() {
        //
    }
    
    public void Card040Clicking() {
        //
    }
    
    public void Card041Clicking() {
        //
    }
    
    public void Card042Clicking() {
        //
    }
    
    public void Card043Clicking() {
        //
    }
    
    public void Card044Clicking() {
        //
    }
    
    public void Card045Clicking() {
        //
    }
    
    public void Card046Clicking() {
        //
    }
    
    public void Card047Clicking() {
        //
    }
    
    public void Card048Clicking() {
        //
    }
    
    public void Card049Clicking() {
        //
    }
    
    public void Card050Clicking() {
        //
    }
    
    public void Card051Clicking() {
        //
    }
    
    public void Card052Clicking() {
        //
    }
    
    public void Card053Clicking() {
        //
    }
    
    public void Card054Clicking() {
        //
    }
    
    public void Card055Clicking() {
        //
    }
    
    public void Card056Clicking() {
        //
    }
    
    public void Card057Clicking() {
        //
    }
    
    public void Card058Clicking() {
        //
    }
    
    public void Card059Clicking() {
        //
    }
    
    public void Card060Clicking() {
        //
    }
    
    public void Card061Clicking() {
        //
    }
    
    public void Card062Clicking() {
        //
    }
    
    public void Card063Clicking() {
        //
    }
    
    public void Card064Clicking() {
        //
    }
    
    public void Card065Clicking() {
        //
    }
    
    public void Card066Clicking() {
        //
    }
    
    public void Card067Clicking() {
        //
    }
    
    public void Card068Clicking() {
        //
    }
    
    public void Card069Clicking() {
        //
    }
    
    public void Card070Clicking() {
        //
    }
    
    public void Card071Clicking() {
        //
    }
    
    public void Card072Clicking() {
        //
    }
    
    public void Card073Clicking() {
        //
    }
    
    public void Card074Clicking() {
        //
    }
    
    public void Card075Clicking() {
        //
    }
    
    public void Card076Clicking() {
        //
    }
    
    public void Card077Clicking() {
        //
    }
    
    public void Card078Clicking() {
        //
    }
    
    public void Card079Clicking() {
        //
    }
    
    public void Card080Clicking() {
        //
    }
    
    public void Card081Clicking() {
        //
    }
    
    public void Card082Clicking() {
        //
    }
    
    public void Card083Clicking() {
        //
    }
    
    public void Card084Clicking() {
        //
    }
    
    public void Card085Clicking() {
        //
    }
    
    public void Card086Clicking() {
        //
    }
    
    public void Card087Clicking() {
        //
    }
    
    public void Card088Clicking() {
        //
    }
    
    public void Card089Clicking() {
        //
    }
    
    public void Card090Clicking() {
        //
    }
    
    public void Card091Clicking() {
        //
    }
    
    public void Card092Clicking() {
        //
    }
    
    public void Card093Clicking() {
        //
    }
    
    public void Card094Clicking() {
        //
    }
    
    public void Card095Clicking() {
        //
    }
    
    public void Card096Clicking() {
        //
    }
    
    public void Card097Clicking() {
        //
    }
    
    public void Card098Clicking() {
        //
    }
    
    public void Card099Clicking() {
        //
    }
    
    public void Card100Clicking() {
        //
    }
    
    public void Card101Clicking() {
        //
    }
    
    public void Card102Clicking() {
        //
    }
    
    public void Card103Clicking() {
        //
    }
    
    public void Card104Clicking() {
        //
    }
    
    public void Card105Clicking() {
        //
    }
    
    public void Card106Clicking() {
        //
    }
    
    public void Card107Clicking() {
        //
    }
    
    public void Card108Clicking() {
        //
    }
    
    public void Card109Clicking() {
        //
    }
    
    public void Card110Clicking() {
        //
    }
    
    public void Card111Clicking() {
        //
    }
    
    public void Card112Clicking() {
        //
    }
    
    public void Card113Clicking() {
        //
    }
    
    public void Card114Clicking() {
        //
    }
    
    public void Card115Clicking() {
        //
    }
    
    public void Card116Clicking() {
        //
    }
    
    public void Card117Clicking() {
        //
    }
    
    public void Card118Clicking() {
        //
    }
    
    public void Card119Clicking() {
        //
    }
    
    public void Card120Clicking() {
        //
    }
    
    public void Card121Clicking() {
        //
    }
    
    public void Card122Clicking() {
        //
    }
    
    public void Card123Clicking() {
        //
    }
    
    public void Card124Clicking() {
        //
    }
    
    public void Card125Clicking() {
        //
    }
    
    public void Card126Clicking() {
        //
    }
    
    public void Card127Clicking() {
        //
    }
    
    public void Card128Clicking() {
        //
    }
    
    public void Card129Clicking() {
        //
    }
    
    public void Card130Clicking() {
        //
    }
    
    public void Card131Clicking() {
        //
    }
    
    public void Card132Clicking() {
        //
    }
    
    public void Card133Clicking() {
        //
    }
    
    public void Card134Clicking() {
        //
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}