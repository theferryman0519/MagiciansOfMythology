using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class PlayerDatabase : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    // Version Text
    public static string VersionText = "Version: 1.0";

    // Player Information
    public static string PlayerName;
    public static string PlayerLogInName;
    public static string PlayerRealm;
    public static string PlayerFavGod;
    public static string PlayerStoryLevel;
    public static string PlayerWins;
    public static string PlayerLosses;
    public static string PlayerStalemates;

    // Card Information
    public static string PlayerCardAmount001;
    public static string PlayerCardAmount002;
    public static string PlayerCardAmount003;
    public static string PlayerCardAmount004;
    public static string PlayerCardAmount005;
    public static string PlayerCardAmount006;
    public static string PlayerCardAmount007;
    public static string PlayerCardAmount008;
    public static string PlayerCardAmount009;
    public static string PlayerCardAmount010;
    public static string PlayerCardAmount011;
    public static string PlayerCardAmount012;
    public static string PlayerCardAmount013;
    public static string PlayerCardAmount014;
    public static string PlayerCardAmount015;
    public static string PlayerCardAmount016;
    public static string PlayerCardAmount017;
    public static string PlayerCardAmount018;
    public static string PlayerCardAmount019;
    public static string PlayerCardAmount020;
    public static string PlayerCardAmount021;
    public static string PlayerCardAmount022;
    public static string PlayerCardAmount023;
    public static string PlayerCardAmount024;
    public static string PlayerCardAmount025;
    public static string PlayerCardAmount026;
    public static string PlayerCardAmount027;
    public static string PlayerCardAmount028;
    public static string PlayerCardAmount029;
    public static string PlayerCardAmount030;
    public static string PlayerCardAmount031;
    public static string PlayerCardAmount032;
    public static string PlayerCardAmount033;
    public static string PlayerCardAmount034;
    public static string PlayerCardAmount035;
    public static string PlayerCardAmount036;
    public static string PlayerCardAmount037;
    public static string PlayerCardAmount038;
    public static string PlayerCardAmount039;
    public static string PlayerCardAmount040;
    public static string PlayerCardAmount041;
    public static string PlayerCardAmount042;
    public static string PlayerCardAmount043;
    public static string PlayerCardAmount044;
    public static string PlayerCardAmount045;
    public static string PlayerCardAmount046;
    public static string PlayerCardAmount047;
    public static string PlayerCardAmount048;
    public static string PlayerCardAmount049;
    public static string PlayerCardAmount050;
    public static string PlayerCardAmount051;
    public static string PlayerCardAmount052;
    public static string PlayerCardAmount053;
    public static string PlayerCardAmount054;
    public static string PlayerCardAmount055;
    public static string PlayerCardAmount056;
    public static string PlayerCardAmount057;
    public static string PlayerCardAmount058;
    public static string PlayerCardAmount059;
    public static string PlayerCardAmount060;
    public static string PlayerCardAmount061;
    public static string PlayerCardAmount062;
    public static string PlayerCardAmount063;
    public static string PlayerCardAmount064;
    public static string PlayerCardAmount065;
    public static string PlayerCardAmount066;
    public static string PlayerCardAmount067;
    public static string PlayerCardAmount068;
    public static string PlayerCardAmount069;
    public static string PlayerCardAmount070;
    public static string PlayerCardAmount071;
    public static string PlayerCardAmount072;
    public static string PlayerCardAmount073;
    public static string PlayerCardAmount074;
    public static string PlayerCardAmount075;
    public static string PlayerCardAmount076;
    public static string PlayerCardAmount077;
    public static string PlayerCardAmount078;
    public static string PlayerCardAmount079;
    public static string PlayerCardAmount080;
    public static string PlayerCardAmount081;
    public static string PlayerCardAmount082;
    public static string PlayerCardAmount083;
    public static string PlayerCardAmount084;
    public static string PlayerCardAmount085;
    public static string PlayerCardAmount086;
    public static string PlayerCardAmount087;
    public static string PlayerCardAmount088;
    public static string PlayerCardAmount089;
    public static string PlayerCardAmount090;
    public static string PlayerCardAmount091;
    public static string PlayerCardAmount092;
    public static string PlayerCardAmount093;
    public static string PlayerCardAmount094;
    public static string PlayerCardAmount095;
    public static string PlayerCardAmount096;
    public static string PlayerCardAmount097;
    public static string PlayerCardAmount098;
    public static string PlayerCardAmount099;
    public static string PlayerCardAmount100;
    public static string PlayerCardAmount101;
    public static string PlayerCardAmount102;
    public static string PlayerCardAmount103;
    public static string PlayerCardAmount104;
    public static string PlayerCardAmount105;
    public static string PlayerCardAmount106;
    public static string PlayerCardAmount107;
    public static string PlayerCardAmount108;
    public static string PlayerCardAmount109;
    public static string PlayerCardAmount110;
    public static string PlayerCardAmount111;
    public static string PlayerCardAmount112;
    public static string PlayerCardAmount113;
    public static string PlayerCardAmount114;
    public static string PlayerCardAmount115;
    public static string PlayerCardAmount116;
    public static string PlayerCardAmount117;
    public static string PlayerCardAmount118;
    public static string PlayerCardAmount119;
    public static string PlayerCardAmount120;
    public static string PlayerCardAmount121;
    public static string PlayerCardAmount122;
    public static string PlayerCardAmount123;
    public static string PlayerCardAmount124;
    public static string PlayerCardAmount125;
    public static string PlayerCardAmount126;
    public static string PlayerCardAmount127;
    public static string PlayerCardAmount128;
    public static string PlayerCardAmount129;
    public static string PlayerCardAmount130;
    public static string PlayerCardAmount131;
    public static string PlayerCardAmount132;
    public static string PlayerCardAmount133;
    public static string PlayerCardAmount134;

    // Store Information
    public static string StoreBoughtDarkPack;
    public static string StoreBoughtEarthPack;
    public static string StoreBoughtLightPack;
    public static string StoreBoughtSeaPack;
    public static string StoreBoughtSkiesPack;
    public static string StoreBoughtEpicPack;
    public static string StoreBoughtWorldPack;

    // Multiplayer Information
    public static string MultiplayerWins;
    public static string MultiplayerLosses;
    public static string MultiplayerStalemates;
    public static string MultiplayerGameCode;
    public static string MultiplayerRandomCode;
    public static string MultiplayerP1Name;
    public static string MultiplayerP2Name;
    public static string MultiplayerP1Wins;
    public static string MultiplayerP2Wins;
    public static string MultiplayerP1Losses;
    public static string MultiplayerP2Losses;
    public static string MultiplayerP1Stalemates;
    public static string MultiplayerP2Stalemates;
    public static string MultiplayerP1Ready;
    public static string MultiplayerP2Ready;
    public static string MultiplayerTurnNumber;
    public static string MultiplayerTurnPlayer;
    public static string MultiplayerP1God01;
    public static string MultiplayerP1God02;
    public static string MultiplayerP1God03;
    public static string MultiplayerP1God04;
    public static string MultiplayerP1God05;
    public static string MultiplayerP2God01;
    public static string MultiplayerP2God02;
    public static string MultiplayerP2God03;
    public static string MultiplayerP2God04;
    public static string MultiplayerP2God05;
    public static string MultiplayerP1God01Stance;
    public static string MultiplayerP1God02Stance;
    public static string MultiplayerP1God03Stance;
    public static string MultiplayerP1God04Stance;
    public static string MultiplayerP1God05Stance;
    public static string MultiplayerP2God01Stance;
    public static string MultiplayerP2God02Stance;
    public static string MultiplayerP2God03Stance;
    public static string MultiplayerP2God04Stance;
    public static string MultiplayerP2God05Stance;
    public static string MultiplayerP1God01Health;
    public static string MultiplayerP1God02Health;
    public static string MultiplayerP1God03Health;
    public static string MultiplayerP1God04Health;
    public static string MultiplayerP1God05Health;
    public static string MultiplayerP2God01Health;
    public static string MultiplayerP2God02Health;
    public static string MultiplayerP2God03Health;
    public static string MultiplayerP2God04Health;
    public static string MultiplayerP2God05Health;
    public static string MultiplayerP1God01Action;
    public static string MultiplayerP1God02Action;
    public static string MultiplayerP1God03Action;
    public static string MultiplayerP1God04Action;
    public static string MultiplayerP1God05Action;
    public static string MultiplayerP2God01Action;
    public static string MultiplayerP2God02Action;
    public static string MultiplayerP2God03Action;
    public static string MultiplayerP2God04Action;
    public static string MultiplayerP2God05Action;
    public static string MultiplayerP1MythRealm01;
    public static string MultiplayerP1MythRealm02;
    public static string MultiplayerP1MythRealm03;
    public static string MultiplayerP1MythRealm04;
    public static string MultiplayerP1MythRealm05;
    public static string MultiplayerP1MythRealm06;
    public static string MultiplayerP1MythRealm07;
    public static string MultiplayerP1MythRealm08;
    public static string MultiplayerP1MythRealm09;
    public static string MultiplayerP1MythRealm10;
    public static string MultiplayerP1MythRealm11;
    public static string MultiplayerP1MythRealm12;
    public static string MultiplayerP1MythRealm13;
    public static string MultiplayerP1MythRealm14;
    public static string MultiplayerP1MythRealm15;
    public static string MultiplayerP2MythRealm01;
    public static string MultiplayerP2MythRealm02;
    public static string MultiplayerP2MythRealm03;
    public static string MultiplayerP2MythRealm04;
    public static string MultiplayerP2MythRealm05;
    public static string MultiplayerP2MythRealm06;
    public static string MultiplayerP2MythRealm07;
    public static string MultiplayerP2MythRealm08;
    public static string MultiplayerP2MythRealm09;
    public static string MultiplayerP2MythRealm10;
    public static string MultiplayerP2MythRealm11;
    public static string MultiplayerP2MythRealm12;
    public static string MultiplayerP2MythRealm13;
    public static string MultiplayerP2MythRealm14;
    public static string MultiplayerP2MythRealm15;
    public static List<string> MultiplayerP1Deck = new List<string>();
    public static List<string> MultiplayerP2Deck = new List<string>();
    public static List<string> MultiplayerP1Temple = new List<string>();
    public static List<string> MultiplayerP2Temple = new List<string>();
    public static List<string> MultiplayerP1Crypt = new List<string>();
    public static List<string> MultiplayerP2Crypt = new List<string>();

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------


// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------



// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {

    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------



// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}