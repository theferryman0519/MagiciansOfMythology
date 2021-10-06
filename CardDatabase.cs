using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class CardDatabase : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    

// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    // Card001
    public static string Card001Number = "001";
    public static string Card001Name = "Realm of Darkness";
    public static string Card001Realm = "Dark";
    public static string Card001Type = "Realm";
    public static string Card001Description = "Realm of Darkness only allows Dark Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card001BaseImage;
    public static string Card001GodType = "";
    public static string Card001GodHealth = "";
    public static string Card001GodAttackName = "";
    public static string Card001GodAttackNumber = "";
    public static string Card001GodAttackDescription = "";
    public static string Card001GodDefenseName = "";
    public static string Card001GodDefenseNumber = "";
    public static string Card001GodDefenseDescription = "";

    // Card002
    public static string Card002Number = "002";
    public static string Card002Name = "Dusk";
    public static string Card002Realm = "Dark";
    public static string Card002Type = "Myth";
    public static string Card002Description = "All Dark Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn.";
    public static Sprite Card002BaseImage;
    public static string Card002GodType = "";
    public static string Card002GodHealth = "";
    public static string Card002GodAttackName = "";
    public static string Card002GodAttackNumber = "";
    public static string Card002GodAttackDescription = "";
    public static string Card002GodDefenseName = "";
    public static string Card002GodDefenseNumber = "";
    public static string Card002GodDefenseDescription = "";

    // Card003
    public static string Card003Number = "003";
    public static string Card003Name = "Curse";
    public static string Card003Realm = "Dark";
    public static string Card003Type = "Myth";
    public static string Card003Description = "If Moros is in your Temple, add 50 Attack Points to Moros if they are attacking your Opponent this turn.";
    public static Sprite Card003BaseImage;
    public static string Card003GodType = "";
    public static string Card003GodHealth = "";
    public static string Card003GodAttackName = "";
    public static string Card003GodAttackNumber = "";
    public static string Card003GodAttackDescription = "";
    public static string Card003GodDefenseName = "";
    public static string Card003GodDefenseNumber = "";
    public static string Card003GodDefenseDescription = "";

    // Card004
    public static string Card004Number = "004";
    public static string Card004Name = "Cold Abyss";
    public static string Card004Realm = "Dark";
    public static string Card004Type = "Myth";
    public static string Card004Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card004BaseImage;
    public static string Card004GodType = "";
    public static string Card004GodHealth = "";
    public static string Card004GodAttackName = "";
    public static string Card004GodAttackNumber = "";
    public static string Card004GodAttackDescription = "";
    public static string Card004GodDefenseName = "";
    public static string Card004GodDefenseNumber = "";
    public static string Card004GodDefenseDescription = "";

    // Card005
    public static string Card005Number = "005";
    public static string Card005Name = "Lunar Shadows";
    public static string Card005Realm = "Dark";
    public static string Card005Type = "Myth";
    public static string Card005Description = "All Dark Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card005BaseImage;
    public static string Card005GodType = "";
    public static string Card005GodHealth = "";
    public static string Card005GodAttackName = "";
    public static string Card005GodAttackNumber = "";
    public static string Card005GodAttackDescription = "";
    public static string Card005GodDefenseName = "";
    public static string Card005GodDefenseNumber = "";
    public static string Card005GodDefenseDescription = "";

    // Card006
    public static string Card006Number = "006";
    public static string Card006Name = "Grains of the Sandman";
    public static string Card006Realm = "Dark";
    public static string Card006Type = "Myth";
    public static string Card006Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card006BaseImage;
    public static string Card006GodType = "";
    public static string Card006GodHealth = "";
    public static string Card006GodAttackName = "";
    public static string Card006GodAttackNumber = "";
    public static string Card006GodAttackDescription = "";
    public static string Card006GodDefenseName = "";
    public static string Card006GodDefenseNumber = "";
    public static string Card006GodDefenseDescription = "";

    // Card007
    public static string Card007Number = "007";
    public static string Card007Name = "Eternal Slumber";
    public static string Card007Realm = "Dark";
    public static string Card007Type = "Myth";
    public static string Card007Description = "If Hypnos is in your Temple, they may attack two different of your Opponent's Gods this turn.";
    public static Sprite Card007BaseImage;
    public static string Card007GodType = "";
    public static string Card007GodHealth = "";
    public static string Card007GodAttackName = "";
    public static string Card007GodAttackNumber = "";
    public static string Card007GodAttackDescription = "";
    public static string Card007GodDefenseName = "";
    public static string Card007GodDefenseNumber = "";
    public static string Card007GodDefenseDescription = "";

    // Card008
    public static string Card008Number = "008";
    public static string Card008Name = "Bite of Cerberus";
    public static string Card008Realm = "Dark";
    public static string Card008Type = "Myth";
    public static string Card008Description = "All Olympians in your Opponent's Temple may not attack on your Opponent's next turn.";
    public static Sprite Card008BaseImage;
    public static string Card008GodType = "";
    public static string Card008GodHealth = "";
    public static string Card008GodAttackName = "";
    public static string Card008GodAttackNumber = "";
    public static string Card008GodAttackDescription = "";
    public static string Card008GodDefenseName = "";
    public static string Card008GodDefenseNumber = "";
    public static string Card008GodDefenseDescription = "";

    // Card009
    public static string Card009Number = "009";
    public static string Card009Name = "Raft of Charon";
    public static string Card009Realm = "Dark";
    public static string Card009Type = "Myth";
    public static string Card009Description = "If Hades is in the Temple Crypt, add him back to your Temple in Defense Position.";
    public static Sprite Card009BaseImage;
    public static string Card009GodType = "";
    public static string Card009GodHealth = "";
    public static string Card009GodAttackName = "";
    public static string Card009GodAttackNumber = "";
    public static string Card009GodAttackDescription = "";
    public static string Card009GodDefenseName = "";
    public static string Card009GodDefenseNumber = "";
    public static string Card009GodDefenseDescription = "";

    // Card010
    public static string Card010Number = "010";
    public static string Card010Name = "Gates of Tartarus";
    public static string Card010Realm = "Dark";
    public static string Card010Type = "Myth";
    public static string Card010Description = "All Dark Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card010BaseImage;
    public static string Card010GodType = "";
    public static string Card010GodHealth = "";
    public static string Card010GodAttackName = "";
    public static string Card010GodAttackNumber = "";
    public static string Card010GodAttackDescription = "";
    public static string Card010GodDefenseName = "";
    public static string Card010GodDefenseNumber = "";
    public static string Card010GodDefenseDescription = "";

    // Card011
    public static string Card011Number = "011";
    public static string Card011Name = "Pitchfork";
    public static string Card011Realm = "Dark";
    public static string Card011Type = "Myth";
    public static string Card011Description = "If Hades is in your Temple, add 100 Attack Points to Hades if they are attacking your Opponent this turn.";
    public static Sprite Card011BaseImage;
    public static string Card011GodType = "";
    public static string Card011GodHealth = "";
    public static string Card011GodAttackName = "";
    public static string Card011GodAttackNumber = "";
    public static string Card011GodAttackDescription = "";
    public static string Card011GodDefenseName = "";
    public static string Card011GodDefenseNumber = "";
    public static string Card011GodDefenseDescription = "";

    // Card012
    public static string Card012Number = "012";
    public static string Card012Name = "Ares";
    public static string Card012Realm = "Dark";
    public static string Card012Type = "God";
    public static string Card012Description = "Ares is the Olympic God of war, bloodshed, and violence.";
    public static Sprite Card012BaseImage;
    public static string Card012GodType = "Olympian";
    public static string Card012GodHealth = "300";
    public static string Card012GodAttackName = "Spoils of War";
    public static string Card012GodAttackNumber = "250";
    public static string Card012GodAttackDescription = "Heal 120 Health Points to Ares";
    public static string Card012GodDefenseName = "General's Shield";
    public static string Card012GodDefenseNumber = "230";
    public static string Card012GodDefenseDescription = "";

    // Card013
    public static string Card013Number = "013";
    public static string Card013Name = "Chaos";
    public static string Card013Realm = "Dark";
    public static string Card013Type = "God";
    public static string Card013Description = "Chaos is the Primordial Goddess of nothingness and void of existence.";
    public static Sprite Card013BaseImage;
    public static string Card013GodType = "Primordial";
    public static string Card013GodHealth = "280";
    public static string Card013GodAttackName = "Dark Abyss";
    public static string Card013GodAttackNumber = "180";
    public static string Card013GodAttackDescription = "";
    public static string Card013GodDefenseName = "Cease of Existence";
    public static string Card013GodDefenseNumber = "190";
    public static string Card013GodDefenseDescription = "";

    // Card014
    public static string Card014Number = "014";
    public static string Card014Name = "Cronus";
    public static string Card014Realm = "Dark";
    public static string Card014Type = "God";
    public static string Card014Description = "Cronus is the Titanic God of the destruction of time.";
    public static Sprite Card014BaseImage;
    public static string Card014GodType = "Titan";
    public static string Card014GodHealth = "430";
    public static string Card014GodAttackName = "Death of Time";
    public static string Card014GodAttackNumber = "450";
    public static string Card014GodAttackDescription = "";
    public static string Card014GodDefenseName = "Overthrow";
    public static string Card014GodDefenseNumber = "190";
    public static string Card014GodDefenseDescription = "";

    // Card015
    public static string Card015Number = "015";
    public static string Card015Name = "Deimos";
    public static string Card015Realm = "Dark";
    public static string Card015Type = "God";
    public static string Card015Description = "Deimos is the God of fear, dread, and terror.";
    public static Sprite Card015BaseImage;
    public static string Card015GodType = "Deity";
    public static string Card015GodHealth = "200";
    public static string Card015GodAttackName = "Terrorizing Twosome";
    public static string Card015GodAttackNumber = "200";
    public static string Card015GodAttackDescription = "If Phobos is in your Temple, add 100 Attack Points";
    public static string Card015GodDefenseName = "Veil of Fear";
    public static string Card015GodDefenseNumber = "70";
    public static string Card015GodDefenseDescription = "";

    // Card016
    public static string Card016Number = "016";
    public static string Card016Name = "Erebus";
    public static string Card016Realm = "Dark";
    public static string Card016Type = "God";
    public static string Card016Description = "Erebus is the Primordial God of darkness and shadows.";
    public static Sprite Card016BaseImage;
    public static string Card016GodType = "Primordial";
    public static string Card016GodHealth = "180";
    public static string Card016GodAttackName = "Shadow Rush";
    public static string Card016GodAttackNumber = "140";
    public static string Card016GodAttackDescription = "";
    public static string Card016GodDefenseName = "Black as Night";
    public static string Card016GodDefenseNumber = "130";
    public static string Card016GodDefenseDescription = "";

    // Card017
    public static string Card017Number = "017";
    public static string Card017Name = "Hecate";
    public static string Card017Realm = "Dark";
    public static string Card017Type = "God";
    public static string Card017Description = "Hecate is the Goddess of magic, witchcraft, the moon, and ghosts.";
    public static Sprite Card017BaseImage;
    public static string Card017GodType = "Deity";
    public static string Card017GodHealth = "160";
    public static string Card017GodAttackName = "Spiritual Tomb";
    public static string Card017GodAttackNumber = "110";
    public static string Card017GodAttackDescription = "";
    public static string Card017GodDefenseName = "Spellbook Bind";
    public static string Card017GodDefenseNumber = "80";
    public static string Card017GodDefenseDescription = "";

    // Card018
    public static string Card018Number = "018";
    public static string Card018Name = "Hypnos";
    public static string Card018Realm = "Dark";
    public static string Card018Type = "God";
    public static string Card018Description = "Hypnos is the God of sleep.";
    public static Sprite Card018BaseImage;
    public static string Card018GodType = "Deity";
    public static string Card018GodHealth = "80";
    public static string Card018GodAttackName = "Slumber";
    public static string Card018GodAttackNumber = "30";
    public static string Card018GodAttackDescription = "";
    public static string Card018GodDefenseName = "Dreamscape";
    public static string Card018GodDefenseNumber = "80";
    public static string Card018GodDefenseDescription = "";

    // Card019
    public static string Card019Number = "019";
    public static string Card019Name = "Moros";
    public static string Card019Realm = "Dark";
    public static string Card019Type = "God";
    public static string Card019Description = "Moros is the God of doom.";
    public static Sprite Card019BaseImage;
    public static string Card019GodType = "Deity";
    public static string Card019GodHealth = "60";
    public static string Card019GodAttackName = "Eye of Doom";
    public static string Card019GodAttackNumber = "80";
    public static string Card019GodAttackDescription = "";
    public static string Card019GodDefenseName = "Dark Shroud";
    public static string Card019GodDefenseNumber = "20";
    public static string Card019GodDefenseDescription = "";

    // Card020
    public static string Card020Number = "020";
    public static string Card020Name = "Nyx";
    public static string Card020Realm = "Dark";
    public static string Card020Type = "God";
    public static string Card020Description = "Nyx is the Primordial Goddess of the night.";
    public static Sprite Card020BaseImage;
    public static string Card020GodType = "Primordial";
    public static string Card020GodHealth = "300";
    public static string Card020GodAttackName = "Lunar Eclipse";
    public static string Card020GodAttackNumber = "210";
    public static string Card020GodAttackDescription = "";
    public static string Card020GodDefenseName = "Dark as Night";
    public static string Card020GodDefenseNumber = "250";
    public static string Card020GodDefenseDescription = "All Primordials in Opponent's Temple may not attack next turn";

    // Card021
    public static string Card021Number = "021";
    public static string Card021Name = "Phobos";
    public static string Card021Realm = "Dark";
    public static string Card021Type = "God";
    public static string Card021Description = "Phobos is the God of fear, flight, and the battlefield.";
    public static Sprite Card021BaseImage;
    public static string Card021GodType = "Deity";
    public static string Card021GodHealth = "200";
    public static string Card021GodAttackName = "Terrorizing Twosome";
    public static string Card021GodAttackNumber = "200";
    public static string Card021GodAttackDescription = "If Deimos is in your Temple, add 100 Attack Points";
    public static string Card021GodDefenseName = "Veil of Fear";
    public static string Card021GodDefenseNumber = "70";
    public static string Card021GodDefenseDescription = "";

    // Card022
    public static string Card022Number = "022";
    public static string Card022Name = "Selene";
    public static string Card022Realm = "Dark";
    public static string Card022Type = "God";
    public static string Card022Description = "Selene is the Goddess of the moon.";
    public static Sprite Card022BaseImage;
    public static string Card022GodType = "Deity";
    public static string Card022GodHealth = "110";
    public static string Card022GodAttackName = "Dark Side of the Moon";
    public static string Card022GodAttackNumber = "90";
    public static string Card022GodAttackDescription = "";
    public static string Card022GodDefenseName = "Lunar Veil";
    public static string Card022GodDefenseNumber = "50";
    public static string Card022GodDefenseDescription = "";

    // Card023
    public static string Card023Number = "023";
    public static string Card023Name = "Thanatos";
    public static string Card023Realm = "Dark";
    public static string Card023Type = "God";
    public static string Card023Description = "Thanatos is the God of death and mortality.";
    public static Sprite Card023BaseImage;
    public static string Card023GodType = "Deity";
    public static string Card023GodHealth = "50";
    public static string Card023GodAttackName = "Hole of the Grave";
    public static string Card023GodAttackNumber = "50";
    public static string Card023GodAttackDescription = "";
    public static string Card023GodDefenseName = "Dark Shroud";
    public static string Card023GodDefenseNumber = "20";
    public static string Card023GodDefenseDescription = "";

    // Card024
    public static string Card024Number = "024";
    public static string Card024Name = "Realm of the Earth";
    public static string Card024Realm = "Earth";
    public static string Card024Type = "Realm";
    public static string Card024Description = "Realm of the Earth only allows Earth Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card024BaseImage;
    public static string Card024GodType = "";
    public static string Card024GodHealth = "";
    public static string Card024GodAttackName = "";
    public static string Card024GodAttackNumber = "";
    public static string Card024GodAttackDescription = "";
    public static string Card024GodDefenseName = "";
    public static string Card024GodDefenseNumber = "";
    public static string Card024GodDefenseDescription = "";

    // Card025
    public static string Card025Number = "025";
    public static string Card025Name = "Rocky Road";
    public static string Card025Realm = "Earth";
    public static string Card025Type = "Myth";
    public static string Card025Description = "All Earth Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn.";
    public static Sprite Card025BaseImage;
    public static string Card025GodType = "";
    public static string Card025GodHealth = "";
    public static string Card025GodAttackName = "";
    public static string Card025GodAttackNumber = "";
    public static string Card025GodAttackDescription = "";
    public static string Card025GodDefenseName = "";
    public static string Card025GodDefenseNumber = "";
    public static string Card025GodDefenseDescription = "";

    // Card026
    public static string Card026Number = "026";
    public static string Card026Name = "Walk of Man";
    public static string Card026Realm = "Earth";
    public static string Card026Type = "Myth";
    public static string Card026Description = "If Ariadne is in your Temple, add 80 Defense Points to Ariadne if they are defending from your Opponent's next turn.";
    public static Sprite Card026BaseImage;
    public static string Card026GodType = "";
    public static string Card026GodHealth = "";
    public static string Card026GodAttackName = "";
    public static string Card026GodAttackNumber = "";
    public static string Card026GodAttackDescription = "";
    public static string Card026GodDefenseName = "";
    public static string Card026GodDefenseNumber = "";
    public static string Card026GodDefenseDescription = "";

    // Card027
    public static string Card027Number = "027";
    public static string Card027Name = "Passage of Time";
    public static string Card027Realm = "Earth";
    public static string Card027Type = "Myth";
    public static string Card027Description = "Skip your Opponent's next turn at the conclusion of your current turn.";
    public static Sprite Card027BaseImage;
    public static string Card027GodType = "";
    public static string Card027GodHealth = "";
    public static string Card027GodAttackName = "";
    public static string Card027GodAttackNumber = "";
    public static string Card027GodAttackDescription = "";
    public static string Card027GodDefenseName = "";
    public static string Card027GodDefenseNumber = "";
    public static string Card027GodDefenseDescription = "";

    // Card028
    public static string Card028Number = "028";
    public static string Card028Name = "Autumn";
    public static string Card028Realm = "Earth";
    public static string Card028Type = "Myth";
    public static string Card028Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card028BaseImage;
    public static string Card028GodType = "";
    public static string Card028GodHealth = "";
    public static string Card028GodAttackName = "";
    public static string Card028GodAttackNumber = "";
    public static string Card028GodAttackDescription = "";
    public static string Card028GodDefenseName = "";
    public static string Card028GodDefenseNumber = "";
    public static string Card028GodDefenseDescription = "";

    // Card029
    public static string Card029Number = "029";
    public static string Card029Name = "Summer";
    public static string Card029Realm = "Earth";
    public static string Card029Type = "Myth";
    public static string Card029Description = "All Earth Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card029BaseImage;
    public static string Card029GodType = "";
    public static string Card029GodHealth = "";
    public static string Card029GodAttackName = "";
    public static string Card029GodAttackNumber = "";
    public static string Card029GodAttackDescription = "";
    public static string Card029GodDefenseName = "";
    public static string Card029GodDefenseNumber = "";
    public static string Card029GodDefenseDescription = "";

    // Card030
    public static string Card030Number = "030";
    public static string Card030Name = "Winter";
    public static string Card030Realm = "Earth";
    public static string Card030Type = "Myth";
    public static string Card030Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card030BaseImage;
    public static string Card030GodType = "";
    public static string Card030GodHealth = "";
    public static string Card030GodAttackName = "";
    public static string Card030GodAttackNumber = "";
    public static string Card030GodAttackDescription = "";
    public static string Card030GodDefenseName = "";
    public static string Card030GodDefenseNumber = "";
    public static string Card030GodDefenseDescription = "";

    // Card031
    public static string Card031Number = "031";
    public static string Card031Name = "Spring";
    public static string Card031Realm = "Earth";
    public static string Card031Type = "Myth";
    public static string Card031Description = "If Persephone and/or Demeter are in the Temple Crypt, add them back to your Temple in Defense Position.";
    public static Sprite Card031BaseImage;
    public static string Card031GodType = "";
    public static string Card031GodHealth = "";
    public static string Card031GodAttackName = "";
    public static string Card031GodAttackNumber = "";
    public static string Card031GodAttackDescription = "";
    public static string Card031GodDefenseName = "";
    public static string Card031GodDefenseNumber = "";
    public static string Card031GodDefenseDescription = "";

    // Card032
    public static string Card032Number = "032";
    public static string Card032Name = "Cliffside Escape";
    public static string Card032Realm = "Earth";
    public static string Card032Type = "Myth";
    public static string Card032Description = "All Titans in your Temple add 200 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card032BaseImage;
    public static string Card032GodType = "";
    public static string Card032GodHealth = "";
    public static string Card032GodAttackName = "";
    public static string Card032GodAttackNumber = "";
    public static string Card032GodAttackDescription = "";
    public static string Card032GodDefenseName = "";
    public static string Card032GodDefenseNumber = "";
    public static string Card032GodDefenseDescription = "";

    // Card033
    public static string Card033Number = "033";
    public static string Card033Name = "Doctor in the House";
    public static string Card033Realm = "Earth";
    public static string Card033Type = "Myth";
    public static string Card033Description = "All Earth Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card033BaseImage;
    public static string Card033GodType = "";
    public static string Card033GodHealth = "";
    public static string Card033GodAttackName = "";
    public static string Card033GodAttackNumber = "";
    public static string Card033GodAttackDescription = "";
    public static string Card033GodDefenseName = "";
    public static string Card033GodDefenseNumber = "";
    public static string Card033GodDefenseDescription = "";

    // Card034
    public static string Card034Number = "034";
    public static string Card034Name = "Mother / Daughter Bond";
    public static string Card034Realm = "Earth";
    public static string Card034Type = "Myth";
    public static string Card034Description = "If both Persephone and Demeter are in your Temple, heal both by 100 Health Points this turn.";
    public static Sprite Card034BaseImage;
    public static string Card034GodType = "";
    public static string Card034GodHealth = "";
    public static string Card034GodAttackName = "";
    public static string Card034GodAttackNumber = "";
    public static string Card034GodAttackDescription = "";
    public static string Card034GodDefenseName = "";
    public static string Card034GodDefenseNumber = "";
    public static string Card034GodDefenseDescription = "";

    // Card035
    public static string Card035Number = "035";
    public static string Card035Name = "Ariadne";
    public static string Card035Realm = "Earth";
    public static string Card035Type = "God";
    public static string Card035Description = "Ariadne is the Goddess of vegeation, mazes, fertility, and wine.";
    public static Sprite Card035BaseImage;
    public static string Card035GodType = "Deity";
    public static string Card035GodHealth = "70";
    public static string Card035GodAttackName = "Petal Power";
    public static string Card035GodAttackNumber = "10";
    public static string Card035GodAttackDescription = "";
    public static string Card035GodDefenseName = "Labyrinth";
    public static string Card035GodDefenseNumber = "100";
    public static string Card035GodDefenseDescription = "";

    // Card036
    public static string Card036Number = "036";
    public static string Card036Name = "Artemis";
    public static string Card036Realm = "Earth";
    public static string Card036Type = "God";
    public static string Card036Description = "Artemis is the Olympic Goddess of the hunt, wilderness, and animals.";
    public static Sprite Card036BaseImage;
    public static string Card036GodType = "Olympian";
    public static string Card036GodHealth = "250";
    public static string Card036GodAttackName = "Predator";
    public static string Card036GodAttackNumber = "210";
    public static string Card036GodAttackDescription = "";
    public static string Card036GodDefenseName = "Wild & Free";
    public static string Card036GodDefenseNumber = "150";
    public static string Card036GodDefenseDescription = "";

    // Card037
    public static string Card037Number = "037";
    public static string Card037Name = "Demeter";
    public static string Card037Realm = "Earth";
    public static string Card037Type = "God";
    public static string Card037Description = "Demeter is the Olympic Goddess of grain, agriculture, and the harvest.";
    public static Sprite Card037BaseImage;
    public static string Card037GodType = "Olympian";
    public static string Card037GodHealth = "360";
    public static string Card037GodAttackName = "Crop Dust";
    public static string Card037GodAttackNumber = "190";
    public static string Card037GodAttackDescription = "";
    public static string Card037GodDefenseName = "Rise of Spring";
    public static string Card037GodDefenseNumber = "280";
    public static string Card037GodDefenseDescription = "If Persephone is in your Temple, heal 200 Health Points to Demeter";

    // Card038
    public static string Card038Number = "038";
    public static string Card038Name = "Dionysus";
    public static string Card038Realm = "Earth";
    public static string Card038Type = "God";
    public static string Card038Description = "Dionysus is the Olympic God of wine, chaos, festivals, and vegetation.";
    public static Sprite Card038BaseImage;
    public static string Card038GodType = "Olympian";
    public static string Card038GodHealth = "370";
    public static string Card038GodAttackName = "Vineyard Roots";
    public static string Card038GodAttackNumber = "230";
    public static string Card038GodAttackDescription = "";
    public static string Card038GodDefenseName = "Ivy Wall";
    public static string Card038GodDefenseNumber = "240";
    public static string Card038GodDefenseDescription = "All Olympians in Opponent's Temple may not attack next turn";

    // Card039
    public static string Card039Number = "039";
    public static string Card039Name = "Eileithyia";
    public static string Card039Realm = "Earth";
    public static string Card039Type = "God";
    public static string Card039Description = "Eileithyia is the Goddess of childbirth.";
    public static Sprite Card039BaseImage;
    public static string Card039GodType = "Deity";
    public static string Card039GodHealth = "140";
    public static string Card039GodAttackName = "Offspring";
    public static string Card039GodAttackNumber = "80";
    public static string Card039GodAttackDescription = "";
    public static string Card039GodDefenseName = "Generational Wall";
    public static string Card039GodDefenseNumber = "60";
    public static string Card039GodDefenseDescription = "";

    // Card040
    public static string Card040Number = "040";
    public static string Card040Name = "Hephaestus";
    public static string Card040Realm = "Earth";
    public static string Card040Type = "God";
    public static string Card040Description = "Hephaestus is the Olympic God of fire, metalworks, and crafting.";
    public static Sprite Card040BaseImage;
    public static string Card040GodType = "Olympian";
    public static string Card040GodHealth = "260";
    public static string Card040GodAttackName = "Volcanic Rush";
    public static string Card040GodAttackNumber = "160";
    public static string Card040GodAttackDescription = "";
    public static string Card040GodDefenseName = "Vulcan Forge";
    public static string Card040GodDefenseNumber = "200";
    public static string Card040GodDefenseDescription = "";

    // Card041
    public static string Card041Number = "041";
    public static string Card041Name = "Hestia";
    public static string Card041Realm = "Earth";
    public static string Card041Type = "God";
    public static string Card041Description = "Hestia is the Goddess of the hearth, home, and chastity.";
    public static Sprite Card041BaseImage;
    public static string Card041GodType = "Deity";
    public static string Card041GodHealth = "260";
    public static string Card041GodAttackName = "Embers of the Hearth";
    public static string Card041GodAttackNumber = "190";
    public static string Card041GodAttackDescription = "";
    public static string Card041GodDefenseName = "Where the Heart Is";
    public static string Card041GodDefenseNumber = "190";
    public static string Card041GodDefenseDescription = "";

    // Card042
    public static string Card042Number = "042";
    public static string Card042Name = "Pan";
    public static string Card042Realm = "Earth";
    public static string Card042Type = "God";
    public static string Card042Description = "Pan is the God of shepherds, pastures, and fertility.";
    public static Sprite Card042BaseImage;
    public static string Card042GodType = "Deity";
    public static string Card042GodHealth = "150";
    public static string Card042GodAttackName = "Following Flock";
    public static string Card042GodAttackNumber = "100";
    public static string Card042GodAttackDescription = "";
    public static string Card042GodDefenseName = "Fertile Ground";
    public static string Card042GodDefenseNumber = "90";
    public static string Card042GodDefenseDescription = "";

    // Card043
    public static string Card043Number = "043";
    public static string Card043Name = "Persephone";
    public static string Card043Realm = "Earth";
    public static string Card043Type = "God";
    public static string Card043Description = "Persephone is the Goddess of the Underworld, grain, and spring.";
    public static Sprite Card043BaseImage;
    public static string Card043GodType = "Deity";
    public static string Card043GodHealth = "310";
    public static string Card043GodAttackName = "Queen of Hell";
    public static string Card043GodAttackNumber = "200";
    public static string Card043GodAttackDescription = "If Hades is in your Temple, add 200 Attack Points to Persephone";
    public static string Card043GodDefenseName = "Rise of Spring";
    public static string Card043GodDefenseNumber = "280";
    public static string Card043GodDefenseDescription = "If Demeter is in your Temple, heal 200 Health Points to Persephone";

    // Card044
    public static string Card044Number = "044";
    public static string Card044Name = "Rhea";
    public static string Card044Realm = "Earth";
    public static string Card044Type = "God";
    public static string Card044Description = "Rhea is the Titanic Goddess of fertility, motherhood, and mountains.";
    public static Sprite Card044BaseImage;
    public static string Card044GodType = "Titan";
    public static string Card044GodHealth = "350";
    public static string Card044GodAttackName = "Leeward Winds";
    public static string Card044GodAttackNumber = "270";
    public static string Card044GodAttackDescription = "";
    public static string Card044GodDefenseName = "Mountainous Womb";
    public static string Card044GodDefenseNumber = "200";
    public static string Card044GodDefenseDescription = "";

    // Card045
    public static string Card045Number = "045";
    public static string Card045Name = "Themis";
    public static string Card045Realm = "Earth";
    public static string Card045Type = "God";
    public static string Card045Description = "Themis is the Titanic Goddess of law and order.";
    public static Sprite Card045BaseImage;
    public static string Card045GodType = "Titan";
    public static string Card045GodHealth = "200";
    public static string Card045GodAttackName = "Gavel Rush";
    public static string Card045GodAttackNumber = "140";
    public static string Card045GodAttackDescription = "";
    public static string Card045GodDefenseName = "Judgment Day";
    public static string Card045GodDefenseNumber = "130";
    public static string Card045GodDefenseDescription = "";

    // Card046
    public static string Card046Number = "046";
    public static string Card046Name = "Realm of Light";
    public static string Card046Realm = "Light";
    public static string Card046Type = "Realm";
    public static string Card046Description = "Realm of Light only allows Light Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card046BaseImage;
    public static string Card046GodType = "";
    public static string Card046GodHealth = "";
    public static string Card046GodAttackName = "";
    public static string Card046GodAttackNumber = "";
    public static string Card046GodAttackDescription = "";
    public static string Card046GodDefenseName = "";
    public static string Card046GodDefenseNumber = "";
    public static string Card046GodDefenseDescription = "";

    // Card047
    public static string Card047Number = "047";
    public static string Card047Name = "Dawn";
    public static string Card047Realm = "Light";
    public static string Card047Type = "Myth";
    public static string Card047Description = "All Light Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn.";
    public static Sprite Card047BaseImage;
    public static string Card047GodType = "";
    public static string Card047GodHealth = "";
    public static string Card047GodAttackName = "";
    public static string Card047GodAttackNumber = "";
    public static string Card047GodAttackDescription = "";
    public static string Card047GodDefenseName = "";
    public static string Card047GodDefenseNumber = "";
    public static string Card047GodDefenseDescription = "";

    // Card048
    public static string Card048Number = "048";
    public static string Card048Name = "Nimbus";
    public static string Card048Realm = "Light";
    public static string Card048Type = "Myth";
    public static string Card048Description = "All Light Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card048BaseImage;
    public static string Card048GodType = "";
    public static string Card048GodHealth = "";
    public static string Card048GodAttackName = "";
    public static string Card048GodAttackNumber = "";
    public static string Card048GodAttackDescription = "";
    public static string Card048GodDefenseName = "";
    public static string Card048GodDefenseNumber = "";
    public static string Card048GodDefenseDescription = "";

    // Card049
    public static string Card049Number = "049";
    public static string Card049Name = "Gambling Man";
    public static string Card049Realm = "Light";
    public static string Card049Type = "Myth";
    public static string Card049Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card049BaseImage;
    public static string Card049GodType = "";
    public static string Card049GodHealth = "";
    public static string Card049GodAttackName = "";
    public static string Card049GodAttackNumber = "";
    public static string Card049GodAttackDescription = "";
    public static string Card049GodDefenseName = "";
    public static string Card049GodDefenseNumber = "";
    public static string Card049GodDefenseDescription = "";

    // Card050
    public static string Card050Number = "050";
    public static string Card050Name = "Flights in the Heavens";
    public static string Card050Realm = "Light";
    public static string Card050Type = "Myth";
    public static string Card050Description = "If Eos is in your Temple, they may attack two different of your Opponent's Gods this turn.";
    public static Sprite Card050BaseImage;
    public static string Card050GodType = "";
    public static string Card050GodHealth = "";
    public static string Card050GodAttackName = "";
    public static string Card050GodAttackNumber = "";
    public static string Card050GodAttackDescription = "";
    public static string Card050GodDefenseName = "";
    public static string Card050GodDefenseNumber = "";
    public static string Card050GodDefenseDescription = "";

    // Card051
    public static string Card051Number = "051";
    public static string Card051Name = "Protected Veil";
    public static string Card051Realm = "Light";
    public static string Card051Type = "Myth";
    public static string Card051Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card051BaseImage;
    public static string Card051GodType = "";
    public static string Card051GodHealth = "";
    public static string Card051GodAttackName = "";
    public static string Card051GodAttackNumber = "";
    public static string Card051GodAttackDescription = "";
    public static string Card051GodDefenseName = "";
    public static string Card051GodDefenseNumber = "";
    public static string Card051GodDefenseDescription = "";

    // Card052
    public static string Card052Number = "052";
    public static string Card052Name = "Light Switch";
    public static string Card052Realm = "Light";
    public static string Card052Type = "Myth";
    public static string Card052Description = "All Deities in your Opponent's Temple may not attack on your Opponent's next turn.";
    public static Sprite Card052BaseImage;
    public static string Card052GodType = "";
    public static string Card052GodHealth = "";
    public static string Card052GodAttackName = "";
    public static string Card052GodAttackNumber = "";
    public static string Card052GodAttackDescription = "";
    public static string Card052GodDefenseName = "";
    public static string Card052GodDefenseNumber = "";
    public static string Card052GodDefenseDescription = "";

    // Card053
    public static string Card053Number = "053";
    public static string Card053Name = "Arts of the World";
    public static string Card053Realm = "Light";
    public static string Card053Type = "Myth";
    public static string Card053Description = "If Apollo is in the Temple Crypt, add them back to your Temple in Defense Position.";
    public static Sprite Card053BaseImage;
    public static string Card053GodType = "";
    public static string Card053GodHealth = "";
    public static string Card053GodAttackName = "";
    public static string Card053GodAttackNumber = "";
    public static string Card053GodAttackDescription = "";
    public static string Card053GodDefenseName = "";
    public static string Card053GodDefenseNumber = "";
    public static string Card053GodDefenseDescription = "";

    // Card054
    public static string Card054Number = "054";
    public static string Card054Name = "Past, Present, Future";
    public static string Card054Realm = "Light";
    public static string Card054Type = "Myth";
    public static string Card054Description = "If Psyche is in your Temple, they may both attack and defend twice this turn.";
    public static Sprite Card054BaseImage;
    public static string Card054GodType = "";
    public static string Card054GodHealth = "";
    public static string Card054GodAttackName = "";
    public static string Card054GodAttackNumber = "";
    public static string Card054GodAttackDescription = "";
    public static string Card054GodDefenseName = "";
    public static string Card054GodDefenseNumber = "";
    public static string Card054GodDefenseDescription = "";

    // Card055
    public static string Card055Number = "055";
    public static string Card055Name = "Clouds of Olympus";
    public static string Card055Realm = "Light";
    public static string Card055Type = "Myth";
    public static string Card055Description = "All Light Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card055BaseImage;
    public static string Card055GodType = "";
    public static string Card055GodHealth = "";
    public static string Card055GodAttackName = "";
    public static string Card055GodAttackNumber = "";
    public static string Card055GodAttackDescription = "";
    public static string Card055GodDefenseName = "";
    public static string Card055GodDefenseNumber = "";
    public static string Card055GodDefenseDescription = "";

    // Card056
    public static string Card056Number = "056";
    public static string Card056Name = "Lightning Bolt";
    public static string Card056Realm = "Light";
    public static string Card056Type = "Myth";
    public static string Card056Description = "If Zeus is in your Temple, add 100 Attack Points to Zeus if they are attacking your Opponent this turn.";
    public static Sprite Card056BaseImage;
    public static string Card056GodType = "";
    public static string Card056GodHealth = "";
    public static string Card056GodAttackName = "";
    public static string Card056GodAttackNumber = "";
    public static string Card056GodAttackDescription = "";
    public static string Card056GodDefenseName = "";
    public static string Card056GodDefenseNumber = "";
    public static string Card056GodDefenseDescription = "";

    // Card057
    public static string Card057Number = "057";
    public static string Card057Name = "Apollo";
    public static string Card057Realm = "Light";
    public static string Card057Type = "God";
    public static string Card057Description = "Apollo is the Olympic God of music, art, knowledge, the Sun, and archery.";
    public static Sprite Card057BaseImage;
    public static string Card057GodType = "Olympian";
    public static string Card057GodHealth = "450";
    public static string Card057GodAttackName = "Solar Chariot";
    public static string Card057GodAttackNumber = "350";
    public static string Card057GodAttackDescription = "";
    public static string Card057GodDefenseName = "Art & Its Muses";
    public static string Card057GodDefenseNumber = "290";
    public static string Card057GodDefenseDescription = "";

    // Card058
    public static string Card058Number = "058";
    public static string Card058Name = "Athena";
    public static string Card058Realm = "Light";
    public static string Card058Type = "God";
    public static string Card058Description = "Athena is the Olympic Goddess of reason, wisdom, skill, and peace.";
    public static Sprite Card058BaseImage;
    public static string Card058GodType = "Olympian";
    public static string Card058GodHealth = "420";
    public static string Card058GodAttackName = "Hunter's Bow";
    public static string Card058GodAttackNumber = "320";
    public static string Card058GodAttackDescription = "";
    public static string Card058GodDefenseName = "War & Peace";
    public static string Card058GodDefenseNumber = "330";
    public static string Card058GodDefenseDescription = "If Ares is in your Temple, all Gods in your Opponent's Temple each lose 80 Health Points";

    // Card059
    public static string Card059Number = "059";
    public static string Card059Name = "Eos";
    public static string Card059Realm = "Light";
    public static string Card059Type = "God";
    public static string Card059Description = "Eos is the Goddess of the dawn.";
    public static Sprite Card059BaseImage;
    public static string Card059GodType = "Deity";
    public static string Card059GodHealth = "110";
    public static string Card059GodAttackName = "Daybreak Sun";
    public static string Card059GodAttackNumber = "50";
    public static string Card059GodAttackDescription = "";
    public static string Card059GodDefenseName = "Morning Hue";
    public static string Card059GodDefenseNumber = "90";
    public static string Card059GodDefenseDescription = "";

    // Card060
    public static string Card060Number = "060";
    public static string Card060Name = "Eros";
    public static string Card060Realm = "Light";
    public static string Card060Type = "God";
    public static string Card060Description = "Eros is the Primordial God of love and attraction.";
    public static Sprite Card060BaseImage;
    public static string Card060GodType = "Primordial";
    public static string Card060GodHealth = "250";
    public static string Card060GodAttackName = "Cupid's Shot";
    public static string Card060GodAttackNumber = "170";
    public static string Card060GodAttackDescription = "";
    public static string Card060GodDefenseName = "Attractive Destiny";
    public static string Card060GodDefenseNumber = "190";
    public static string Card060GodDefenseDescription = "";

    // Card061
    public static string Card061Number = "061";
    public static string Card061Name = "Helios";
    public static string Card061Realm = "Light";
    public static string Card061Type = "God";
    public static string Card061Description = "Helios is the God of the Sun and oaths.";
    public static Sprite Card061BaseImage;
    public static string Card061GodType = "Deity";
    public static string Card061GodHealth = "230";
    public static string Card061GodAttackName = "Solar Oath";
    public static string Card061GodAttackNumber = "150";
    public static string Card061GodAttackDescription = "";
    public static string Card061GodDefenseName = "Flare of the Sun";
    public static string Card061GodDefenseNumber = "130";
    public static string Card061GodDefenseDescription = "";

    // Card062
    public static string Card062Number = "062";
    public static string Card062Name = "Hyperion";
    public static string Card062Realm = "Light";
    public static string Card062Type = "God";
    public static string Card062Description = "Hyperion is the Titanic God of light.";
    public static Sprite Card062BaseImage;
    public static string Card062GodType = "Titan";
    public static string Card062GodHealth = "170";
    public static string Card062GodAttackName = "Blinding Gaze";
    public static string Card062GodAttackNumber = "60";
    public static string Card062GodAttackDescription = "";
    public static string Card062GodDefenseName = "Illuminate";
    public static string Card062GodDefenseNumber = "140";
    public static string Card062GodDefenseDescription = "All Titans in Opponent's Temple may not attack next turn.";

    // Card063
    public static string Card063Number = "063";
    public static string Card063Name = "Iapetus";
    public static string Card063Realm = "Light";
    public static string Card063Type = "God";
    public static string Card063Description = "Iapetus is the Titanic God of mortality.";
    public static Sprite Card063BaseImage;
    public static string Card063GodType = "Titan";
    public static string Card063GodHealth = "130";
    public static string Card063GodAttackName = "Mortal Blow";
    public static string Card063GodAttackNumber = "120";
    public static string Card063GodAttackDescription = "";
    public static string Card063GodDefenseName = "Last Breath";
    public static string Card063GodDefenseNumber = "30";
    public static string Card063GodDefenseDescription = "";

    // Card064
    public static string Card064Number = "064";
    public static string Card064Name = "Mnemosyne";
    public static string Card064Realm = "Light";
    public static string Card064Type = "God";
    public static string Card064Description = "Mnemosyne is the Titanic Goddess of memory and remembrance.";
    public static Sprite Card064BaseImage;
    public static string Card064GodType = "Titan";
    public static string Card064GodHealth = "90";
    public static string Card064GodAttackName = "Psychic Push";
    public static string Card064GodAttackNumber = "20";
    public static string Card064GodAttackDescription = "";
    public static string Card064GodDefenseName = "Memorial Wall";
    public static string Card064GodDefenseNumber = "80";
    public static string Card064GodDefenseDescription = "";

    // Card065
    public static string Card065Number = "065";
    public static string Card065Name = "Nike";
    public static string Card065Realm = "Light";
    public static string Card065Type = "God";
    public static string Card065Description = "Nike is the Goddess of victory.";
    public static Sprite Card065BaseImage;
    public static string Card065GodType = "Deity";
    public static string Card065GodHealth = "290";
    public static string Card065GodAttackName = "Winged Rush";
    public static string Card065GodAttackNumber = "180";
    public static string Card065GodAttackDescription = "";
    public static string Card065GodDefenseName = "Victory Dance";
    public static string Card065GodDefenseNumber = "190";
    public static string Card065GodDefenseDescription = "";

    // Card066
    public static string Card066Number = "066";
    public static string Card066Name = "Phoebe";
    public static string Card066Realm = "Light";
    public static string Card066Type = "God";
    public static string Card066Description = "Phoebe is the Titanic Goddess of intelligence and prophecy.";
    public static Sprite Card066BaseImage;
    public static string Card066GodType = "Titan";
    public static string Card066GodHealth = "70";
    public static string Card066GodAttackName = "Foresight";
    public static string Card066GodAttackNumber = "50";
    public static string Card066GodAttackDescription = "During your turn, Phoebe both attacks and defends using Foresight.";
    public static string Card066GodDefenseName = "Foresight";
    public static string Card066GodDefenseNumber = "50";
    public static string Card066GodDefenseDescription = "During your turn, Phoebe both attacks and defends using Foresight.";

    // Card067
    public static string Card067Number = "067";
    public static string Card067Name = "Psyche";
    public static string Card067Realm = "Light";
    public static string Card067Type = "God";
    public static string Card067Description = "Psyche is the Goddess of the soul.";
    public static Sprite Card067BaseImage;
    public static string Card067GodType = "Deity";
    public static string Card067GodHealth = "180";
    public static string Card067GodAttackName = "Inner Thoughts";
    public static string Card067GodAttackNumber = "100";
    public static string Card067GodAttackDescription = "During your turn, Psyche both attacks and defends using Inner Thoughts.";
    public static string Card067GodDefenseName = "Inner Thoughts";
    public static string Card067GodDefenseNumber = "100";
    public static string Card067GodDefenseDescription = "During your turn, Psyche both attacks and defends using Inner Thoughts.";

    // Card068
    public static string Card068Number = "068";
    public static string Card068Name = "Theia";
    public static string Card068Realm = "Light";
    public static string Card068Type = "God";
    public static string Card068Description = "Theia is the Titanic Goddess of sight and the shining light.";
    public static Sprite Card068BaseImage;
    public static string Card068GodType = "Titan";
    public static string Card068GodHealth = "80";
    public static string Card068GodAttackName = "Blinding Gaze";
    public static string Card068GodAttackNumber = "60";
    public static string Card068GodAttackDescription = "";
    public static string Card068GodDefenseName = "Light Panel";
    public static string Card068GodDefenseNumber = "50";
    public static string Card068GodDefenseDescription = "";

    // Card069
    public static string Card069Number = "069";
    public static string Card069Name = "Tyche";
    public static string Card069Realm = "Light";
    public static string Card069Type = "God";
    public static string Card069Description = "Tyche is the Goddess of fortune, luck, and chance.";
    public static Sprite Card069BaseImage;
    public static string Card069GodType = "Deity";
    public static string Card069GodHealth = "150";
    public static string Card069GodAttackName = "Roll of the Dice";
    public static string Card069GodAttackNumber = "110";
    public static string Card069GodAttackDescription = "If you have less than 4 Gods in your Temple, this attack does no damage.";
    public static string Card069GodDefenseName = "Soothsayer";
    public static string Card069GodDefenseNumber = "80";
    public static string Card069GodDefenseDescription = "";

    // Card070
    public static string Card070Number = "070";
    public static string Card070Name = "Realm of the Sea";
    public static string Card070Realm = "Sea";
    public static string Card070Type = "Realm";
    public static string Card070Description = "Realm of the Sea only allows Sea Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card070BaseImage;
    public static string Card070GodType = "";
    public static string Card070GodHealth = "";
    public static string Card070GodAttackName = "";
    public static string Card070GodAttackNumber = "";
    public static string Card070GodAttackDescription = "";
    public static string Card070GodDefenseName = "";
    public static string Card070GodDefenseNumber = "";
    public static string Card070GodDefenseDescription = "";

    // Card071
    public static string Card071Number = "071";
    public static string Card071Name = "School of Fish";
    public static string Card071Realm = "Sea";
    public static string Card071Type = "Myth";
    public static string Card071Description = "All Sea Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn.";
    public static Sprite Card071BaseImage;
    public static string Card071GodType = "";
    public static string Card071GodHealth = "";
    public static string Card071GodAttackName = "";
    public static string Card071GodAttackNumber = "";
    public static string Card071GodAttackDescription = "";
    public static string Card071GodDefenseName = "";
    public static string Card071GodDefenseNumber = "";
    public static string Card071GodDefenseDescription = "";

    // Card072
    public static string Card072Number = "072";
    public static string Card072Name = "Dolphin Ride";
    public static string Card072Realm = "Sea";
    public static string Card072Type = "Myth";
    public static string Card072Description = "If Triton is in your Temple, add 20 Attack Points to Triton if they are attacking your Opponent this turn.";
    public static Sprite Card072BaseImage;
    public static string Card072GodType = "";
    public static string Card072GodHealth = "";
    public static string Card072GodAttackName = "";
    public static string Card072GodAttackNumber = "";
    public static string Card072GodAttackDescription = "";
    public static string Card072GodDefenseName = "";
    public static string Card072GodDefenseNumber = "";
    public static string Card072GodDefenseDescription = "";

    // Card073
    public static string Card073Number = "073";
    public static string Card073Name = "Hurricane";
    public static string Card073Realm = "Sea";
    public static string Card073Type = "Myth";
    public static string Card073Description = "All Sea Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card073BaseImage;
    public static string Card073GodType = "";
    public static string Card073GodHealth = "";
    public static string Card073GodAttackName = "";
    public static string Card073GodAttackNumber = "";
    public static string Card073GodAttackDescription = "";
    public static string Card073GodDefenseName = "";
    public static string Card073GodDefenseNumber = "";
    public static string Card073GodDefenseDescription = "";

    // Card074
    public static string Card074Number = "074";
    public static string Card074Name = "Shipwreck";
    public static string Card074Realm = "Sea";
    public static string Card074Type = "Myth";
    public static string Card074Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card074BaseImage;
    public static string Card074GodType = "";
    public static string Card074GodHealth = "";
    public static string Card074GodAttackName = "";
    public static string Card074GodAttackNumber = "";
    public static string Card074GodAttackDescription = "";
    public static string Card074GodDefenseName = "";
    public static string Card074GodDefenseNumber = "";
    public static string Card074GodDefenseDescription = "";

    // Card075
    public static string Card075Number = "075";
    public static string Card075Name = "Monsoon Season";
    public static string Card075Realm = "Sea";
    public static string Card075Type = "Myth";
    public static string Card075Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card075BaseImage;
    public static string Card075GodType = "";
    public static string Card075GodHealth = "";
    public static string Card075GodAttackName = "";
    public static string Card075GodAttackNumber = "";
    public static string Card075GodAttackDescription = "";
    public static string Card075GodDefenseName = "";
    public static string Card075GodDefenseNumber = "";
    public static string Card075GodDefenseDescription = "";

    // Card076
    public static string Card076Number = "076";
    public static string Card076Name = "Tsunami Wave";
    public static string Card076Realm = "Sea";
    public static string Card076Type = "Myth";
    public static string Card076Description = "If Oceanus and/or Tethys are in your Temple, add 100 Defense Points to each Oceanus and/or Tethys if they are defending from your Opponent's next turn.";
    public static Sprite Card076BaseImage;
    public static string Card076GodType = "";
    public static string Card076GodHealth = "";
    public static string Card076GodAttackName = "";
    public static string Card076GodAttackNumber = "";
    public static string Card076GodAttackDescription = "";
    public static string Card076GodDefenseName = "";
    public static string Card076GodDefenseNumber = "";
    public static string Card076GodDefenseDescription = "";

    // Card077
    public static string Card077Number = "077";
    public static string Card077Name = "Island of the Sirens";
    public static string Card077Realm = "Sea";
    public static string Card077Type = "Myth";
    public static string Card077Description = "All Primordials in your Opponent's Temple may not attack on your Opponent's next turn.";
    public static Sprite Card077BaseImage;
    public static string Card077GodType = "";
    public static string Card077GodHealth = "";
    public static string Card077GodAttackName = "";
    public static string Card077GodAttackNumber = "";
    public static string Card077GodAttackDescription = "";
    public static string Card077GodDefenseName = "";
    public static string Card077GodDefenseNumber = "";
    public static string Card077GodDefenseDescription = "";

    // Card078
    public static string Card078Number = "078";
    public static string Card078Name = "Release of the Kraken";
    public static string Card078Realm = "Sea";
    public static string Card078Type = "Myth";
    public static string Card078Description = "If Hades, Poseidon, and/or Zeus are in your Temple, add 80 Attack Points to each Hades, Poseidon and/or Zeus if they are attacking your Opponent this turn.";
    public static Sprite Card078BaseImage;
    public static string Card078GodType = "";
    public static string Card078GodHealth = "";
    public static string Card078GodAttackName = "";
    public static string Card078GodAttackNumber = "";
    public static string Card078GodAttackDescription = "";
    public static string Card078GodDefenseName = "";
    public static string Card078GodDefenseNumber = "";
    public static string Card078GodDefenseDescription = "";

    // Card079
    public static string Card079Number = "079";
    public static string Card079Name = "Atlantis";
    public static string Card079Realm = "Sea";
    public static string Card079Type = "Myth";
    public static string Card079Description = "All Sea Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card079BaseImage;
    public static string Card079GodType = "";
    public static string Card079GodHealth = "";
    public static string Card079GodAttackName = "";
    public static string Card079GodAttackNumber = "";
    public static string Card079GodAttackDescription = "";
    public static string Card079GodDefenseName = "";
    public static string Card079GodDefenseNumber = "";
    public static string Card079GodDefenseDescription = "";

    // Card080
    public static string Card080Number = "080";
    public static string Card080Name = "Trident";
    public static string Card080Realm = "Sea";
    public static string Card080Type = "Myth";
    public static string Card080Description = "If Poseidon is in your Temple, add 100 Attack Points to Poseidon if they are attacking your Opponent this turn.";
    public static Sprite Card080BaseImage;
    public static string Card080GodType = "";
    public static string Card080GodHealth = "";
    public static string Card080GodAttackName = "";
    public static string Card080GodAttackNumber = "";
    public static string Card080GodAttackDescription = "";
    public static string Card080GodDefenseName = "";
    public static string Card080GodDefenseNumber = "";
    public static string Card080GodDefenseDescription = "";

    // Card081
    public static string Card081Number = "081";
    public static string Card081Name = "Aegaeon";
    public static string Card081Realm = "Sea";
    public static string Card081Type = "God";
    public static string Card081Description = "Aegaeon is the God of violent seas and storms.";
    public static Sprite Card081BaseImage;
    public static string Card081GodType = "Deity";
    public static string Card081GodHealth = "120";
    public static string Card081GodAttackName = "River Rush";
    public static string Card081GodAttackNumber = "70";
    public static string Card081GodAttackDescription = "";
    public static string Card081GodDefenseName = "Rift Current";
    public static string Card081GodDefenseNumber = "80";
    public static string Card081GodDefenseDescription = "";

    // Card082
    public static string Card082Number = "082";
    public static string Card082Name = "Brizo";
    public static string Card082Realm = "Sea";
    public static string Card082Type = "God";
    public static string Card082Description = "Brizo is the Goddess of sailors.";
    public static Sprite Card082BaseImage;
    public static string Card082GodType = "Deity";
    public static string Card082GodHealth = "80";
    public static string Card082GodAttackName = "Tidal Crash";
    public static string Card082GodAttackNumber = "30";
    public static string Card082GodAttackDescription = "All Deities in your Opponent's Temple each lose 30 Health Points.";
    public static string Card082GodDefenseName = "Crow's Nest";
    public static string Card082GodDefenseNumber = "80";
    public static string Card082GodDefenseDescription = "";

    // Card083
    public static string Card083Number = "083";
    public static string Card083Name = "Doris";
    public static string Card083Realm = "Sea";
    public static string Card083Type = "God";
    public static string Card083Description = "Doris is the Goddess of the ocean fertility and sailors.";
    public static Sprite Card083BaseImage;
    public static string Card083GodType = "Deity";
    public static string Card083GodHealth = "130";
    public static string Card083GodAttackName = "Harpoon";
    public static string Card083GodAttackNumber = "90";
    public static string Card083GodAttackDescription = "";
    public static string Card083GodDefenseName = "Crow's Nest";
    public static string Card083GodDefenseNumber = "80";
    public static string Card083GodDefenseDescription = "";

    // Card084
    public static string Card084Number = "084";
    public static string Card084Name = "Eurybia";
    public static string Card084Realm = "Sea";
    public static string Card084Type = "God";
    public static string Card084Description = "Eurybia is the Goddess of the seas.";
    public static Sprite Card084BaseImage;
    public static string Card084GodType = "Deity";
    public static string Card084GodHealth = "50";
    public static string Card084GodAttackName = "Tidal Crash";
    public static string Card084GodAttackNumber = "30";
    public static string Card084GodAttackDescription = "All Gods in your Opponent's Temple each lose 30 Health Points.";
    public static string Card084GodDefenseName = "Pearl Shell";
    public static string Card084GodDefenseNumber = "20";
    public static string Card084GodDefenseDescription = "";

    // Card085
    public static string Card085Number = "085";
    public static string Card085Name = "Galene";
    public static string Card085Realm = "Sea";
    public static string Card085Type = "God";
    public static string Card085Description = "Galene is the Goddess of calm seas.";
    public static Sprite Card085BaseImage;
    public static string Card085GodType = "Deity";
    public static string Card085GodHealth = "80";
    public static string Card085GodAttackName = "Bubble Blast";
    public static string Card085GodAttackNumber = "20";
    public static string Card085GodAttackDescription = "";
    public static string Card085GodDefenseName = "Scales of a Fish";
    public static string Card085GodDefenseNumber = "90";
    public static string Card085GodDefenseDescription = "Heal 50 Health Points to Galene.";

    // Card086
    public static string Card086Number = "086";
    public static string Card086Name = "Oceanus";
    public static string Card086Realm = "Sea";
    public static string Card086Type = "God";
    public static string Card086Description = "Oceanus is the Titanic God of the oceans and fresh water.";
    public static Sprite Card086BaseImage;
    public static string Card086GodType = "Titan";
    public static string Card086GodHealth = "200";
    public static string Card086GodAttackName = "Fountain Falls";
    public static string Card086GodAttackNumber = "110";
    public static string Card086GodAttackDescription = "";
    public static string Card086GodDefenseName = "Whirlpool";
    public static string Card086GodDefenseNumber = "170";
    public static string Card086GodDefenseDescription = "";

    // Card087
    public static string Card087Number = "087";
    public static string Card087Name = "Pontus";
    public static string Card087Realm = "Sea";
    public static string Card087Type = "God";
    public static string Card087Description = "Pontus is the Primordial God of the sea, fish, and sea creatures.";
    public static Sprite Card087BaseImage;
    public static string Card087GodType = "Primordial";
    public static string Card087GodHealth = "110";
    public static string Card087GodAttackName = "Harpoon";
    public static string Card087GodAttackNumber = "90";
    public static string Card087GodAttackDescription = "";
    public static string Card087GodDefenseName = "Rift Current";
    public static string Card087GodDefenseNumber = "80";
    public static string Card087GodDefenseDescription = "";

    // Card088
    public static string Card088Number = "088";
    public static string Card088Name = "Tethys";
    public static string Card088Realm = "Sea";
    public static string Card088Type = "God";
    public static string Card088Description = "Tethys is the Titanic Goddess of fresh water, rivers, streams, and fountains.";
    public static Sprite Card088BaseImage;
    public static string Card088GodType = "Titan";
    public static string Card088GodHealth = "160";
    public static string Card088GodAttackName = "Tidal Crash";
    public static string Card088GodAttackNumber = "30";
    public static string Card088GodAttackDescription = "All Titans in your Opponent's Temple each lose 30 Health Points.";
    public static string Card088GodDefenseName = "Whirlpool";
    public static string Card088GodDefenseNumber = "170";
    public static string Card088GodDefenseDescription = "";

    // Card089
    public static string Card089Number = "089";
    public static string Card089Name = "Thalassa";
    public static string Card089Realm = "Sea";
    public static string Card089Type = "God";
    public static string Card089Description = "Thalassa is the Primordial Goddess of the sea.";
    public static Sprite Card089BaseImage;
    public static string Card089GodType = "Primordial";
    public static string Card089GodHealth = "280";
    public static string Card089GodAttackName = "River Rush";
    public static string Card089GodAttackNumber = "70";
    public static string Card089GodAttackDescription = "";
    public static string Card089GodDefenseName = "Atlantic Shell";
    public static string Card089GodDefenseNumber = "290";
    public static string Card089GodDefenseDescription = "Heal 120 Health Points to Thalassa.";

    // Card090
    public static string Card090Number = "090";
    public static string Card090Name = "Triton";
    public static string Card090Realm = "Sea";
    public static string Card090Type = "God";
    public static string Card090Description = "Triton is the God of the ocean and fish.";
    public static Sprite Card090BaseImage;
    public static string Card090GodType = "Deity";
    public static string Card090GodHealth = "50";
    public static string Card090GodAttackName = "Bubble Blast";
    public static string Card090GodAttackNumber = "20";
    public static string Card090GodAttackDescription = "";
    public static string Card090GodDefenseName = "Seafoam";
    public static string Card090GodDefenseNumber = "40";
    public static string Card090GodDefenseDescription = "";

    // Card091
    public static string Card091Number = "091";
    public static string Card091Name = "Realm of the Skies";
    public static string Card091Realm = "Skies";
    public static string Card091Type = "Realm";
    public static string Card091Description = "Realm of the Skies only allows Sky Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card091BaseImage;
    public static string Card091GodType = "";
    public static string Card091GodHealth = "";
    public static string Card091GodAttackName = "";
    public static string Card091GodAttackNumber = "";
    public static string Card091GodAttackDescription = "";
    public static string Card091GodDefenseName = "";
    public static string Card091GodDefenseNumber = "";
    public static string Card091GodDefenseDescription = "";

    // Card092
    public static string Card092Number = "092";
    public static string Card092Name = "Constellations";
    public static string Card092Realm = "Skies";
    public static string Card092Type = "Myth";
    public static string Card092Description = "All Sky Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn.";
    public static Sprite Card092BaseImage;
    public static string Card092GodType = "";
    public static string Card092GodHealth = "";
    public static string Card092GodAttackName = "";
    public static string Card092GodAttackNumber = "";
    public static string Card092GodAttackDescription = "";
    public static string Card092GodDefenseName = "";
    public static string Card092GodDefenseNumber = "";
    public static string Card092GodDefenseDescription = "";

    // Card093
    public static string Card093Number = "093";
    public static string Card093Name = "Overcast Skies";
    public static string Card093Realm = "Skies";
    public static string Card093Type = "Myth";
    public static string Card093Description = "If Aeolus is in your Temple, add 40 Defense Points to Aeolus if they are Defending from your Opponent's next turn.";
    public static Sprite Card093BaseImage;
    public static string Card093GodType = "";
    public static string Card093GodHealth = "";
    public static string Card093GodAttackName = "";
    public static string Card093GodAttackNumber = "";
    public static string Card093GodAttackDescription = "";
    public static string Card093GodDefenseName = "";
    public static string Card093GodDefenseNumber = "";
    public static string Card093GodDefenseDescription = "";

    // Card094
    public static string Card094Number = "094";
    public static string Card094Name = "Prism";
    public static string Card094Realm = "Skies";
    public static string Card094Type = "Myth";
    public static string Card094Description = "Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn.";
    public static Sprite Card094BaseImage;
    public static string Card094GodType = "";
    public static string Card094GodHealth = "";
    public static string Card094GodAttackName = "";
    public static string Card094GodAttackNumber = "";
    public static string Card094GodAttackDescription = "";
    public static string Card094GodDefenseName = "";
    public static string Card094GodDefenseNumber = "";
    public static string Card094GodDefenseDescription = "";

    // Card095
    public static string Card095Number = "095";
    public static string Card095Name = "Cupid's Arrow";
    public static string Card095Realm = "Skies";
    public static string Card095Type = "Myth";
    public static string Card095Description = "If Aphrodite is in your Temple, add 200 Defense Points to Aphrodite if they are Defending from your Opponent's next turn.";
    public static Sprite Card095BaseImage;
    public static string Card095GodType = "";
    public static string Card095GodHealth = "";
    public static string Card095GodAttackName = "";
    public static string Card095GodAttackNumber = "";
    public static string Card095GodAttackDescription = "";
    public static string Card095GodDefenseName = "";
    public static string Card095GodDefenseNumber = "";
    public static string Card095GodDefenseDescription = "";

    // Card096
    public static string Card096Number = "096";
    public static string Card096Name = "Galaxy";
    public static string Card096Realm = "Skies";
    public static string Card096Type = "Myth";
    public static string Card096Description = "All Primordials in your Opponent's Temple may not attack on your Opponent's next turn.";
    public static Sprite Card096BaseImage;
    public static string Card096GodType = "";
    public static string Card096GodHealth = "";
    public static string Card096GodAttackName = "";
    public static string Card096GodAttackNumber = "";
    public static string Card096GodAttackDescription = "";
    public static string Card096GodDefenseName = "";
    public static string Card096GodDefenseNumber = "";
    public static string Card096GodDefenseDescription = "";

    // Card097
    public static string Card097Number = "097";
    public static string Card097Name = "Planetary Rise";
    public static string Card097Realm = "Skies";
    public static string Card097Type = "Myth";
    public static string Card097Description = "If Uranus is in the Temple Crypt, add them back to your Temple in Defense Position.";
    public static Sprite Card097BaseImage;
    public static string Card097GodType = "";
    public static string Card097GodHealth = "";
    public static string Card097GodAttackName = "";
    public static string Card097GodAttackNumber = "";
    public static string Card097GodAttackDescription = "";
    public static string Card097GodDefenseName = "";
    public static string Card097GodDefenseNumber = "";
    public static string Card097GodDefenseDescription = "";

    // Card098
    public static string Card098Number = "098";
    public static string Card098Name = "Ascension";
    public static string Card098Realm = "Skies";
    public static string Card098Type = "Myth";
    public static string Card098Description = "If Gaia is in your Temple, heal 150 Health Points to Gaia this turn.";
    public static Sprite Card098BaseImage;
    public static string Card098GodType = "";
    public static string Card098GodHealth = "";
    public static string Card098GodAttackName = "";
    public static string Card098GodAttackNumber = "";
    public static string Card098GodAttackDescription = "";
    public static string Card098GodDefenseName = "";
    public static string Card098GodDefenseNumber = "";
    public static string Card098GodDefenseDescription = "";

    // Card099
    public static string Card099Number = "099";
    public static string Card099Name = "Orion's Arrow";
    public static string Card099Realm = "Skies";
    public static string Card099Type = "Myth";
    public static string Card099Description = "If Coeus and/or Crius are in your Temple, add 150 Attack Points to each Coeus and/or Crius if they are attacking your Opponent this turn.";
    public static Sprite Card099BaseImage;
    public static string Card099GodType = "";
    public static string Card099GodHealth = "";
    public static string Card099GodAttackName = "";
    public static string Card099GodAttackNumber = "";
    public static string Card099GodAttackDescription = "";
    public static string Card099GodDefenseName = "";
    public static string Card099GodDefenseNumber = "";
    public static string Card099GodDefenseDescription = "";

    // Card100
    public static string Card100Number = "100";
    public static string Card100Name = "Tornadic Winds";
    public static string Card100Realm = "Skies";
    public static string Card100Type = "Myth";
    public static string Card100Description = "All Sky Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn.";
    public static Sprite Card100BaseImage;
    public static string Card100GodType = "";
    public static string Card100GodHealth = "";
    public static string Card100GodAttackName = "";
    public static string Card100GodAttackNumber = "";
    public static string Card100GodAttackDescription = "";
    public static string Card100GodDefenseName = "";
    public static string Card100GodDefenseNumber = "";
    public static string Card100GodDefenseDescription = "";

    // Card101
    public static string Card101Number = "101";
    public static string Card101Name = "Throne in the Skies";
    public static string Card101Realm = "Skies";
    public static string Card101Type = "Myth";
    public static string Card101Description = "If Hera is in your Temple, add 100 Attack Points to Hera if they are attacking your Opponent this turn.";
    public static Sprite Card101BaseImage;
    public static string Card101GodType = "";
    public static string Card101GodHealth = "";
    public static string Card101GodAttackName = "";
    public static string Card101GodAttackNumber = "";
    public static string Card101GodAttackDescription = "";
    public static string Card101GodDefenseName = "";
    public static string Card101GodDefenseNumber = "";
    public static string Card101GodDefenseDescription = "";

    // Card102
    public static string Card102Number = "102";
    public static string Card102Name = "Aeolus";
    public static string Card102Realm = "Skies";
    public static string Card102Type = "God";
    public static string Card102Description = "Aeolus is the God of the winds.";
    public static Sprite Card102BaseImage;
    public static string Card102GodType = "Deity";
    public static string Card102GodHealth = "170";
    public static string Card102GodAttackName = "Gale Force";
    public static string Card102GodAttackNumber = "90";
    public static string Card102GodAttackDescription = "";
    public static string Card102GodDefenseName = "Windward Gust";
    public static string Card102GodDefenseNumber = "100";
    public static string Card102GodDefenseDescription = "";

    // Card103
    public static string Card103Number = "103";
    public static string Card103Name = "Aphrodite";
    public static string Card103Realm = "Skies";
    public static string Card103Type = "God";
    public static string Card103Description = "Aphrodite is the Olympic Goddess of love, beauty, and desire.";
    public static Sprite Card103BaseImage;
    public static string Card103GodType = "Olympian";
    public static string Card103GodHealth = "320";
    public static string Card103GodAttackName = "Lustful Look";
    public static string Card103GodAttackNumber = "240";
    public static string Card103GodAttackDescription = "";
    public static string Card103GodDefenseName = "Veil of Beauty";
    public static string Card103GodDefenseNumber = "220";
    public static string Card103GodDefenseDescription = "";

    // Card104
    public static string Card104Number = "104";
    public static string Card104Name = "Asclepius";
    public static string Card104Realm = "Skies";
    public static string Card104Type = "God";
    public static string Card104Description = "Asclepius is the God of medicine.";
    public static Sprite Card104BaseImage;
    public static string Card104GodType = "Deity";
    public static string Card104GodHealth = "80";
    public static string Card104GodAttackName = "Medicinal Herb";
    public static string Card104GodAttackNumber = "20";
    public static string Card104GodAttackDescription = "";
    public static string Card104GodDefenseName = "Healer";
    public static string Card104GodDefenseNumber = "100";
    public static string Card104GodDefenseDescription = "";

    // Card105
    public static string Card105Number = "105";
    public static string Card105Name = "Coeus";
    public static string Card105Realm = "Skies";
    public static string Card105Type = "God";
    public static string Card105Description = "Coeus is the Titanic God of constellations and the Earth's axis.";
    public static Sprite Card105BaseImage;
    public static string Card105GodType = "Titan";
    public static string Card105GodHealth = "190";
    public static string Card105GodAttackName = "Call of Orion";
    public static string Card105GodAttackNumber = "130";
    public static string Card105GodAttackDescription = "If Crius is in your Temple, add 130 Attack Points.";
    public static string Card105GodDefenseName = "Heavenly Realm";
    public static string Card105GodDefenseNumber = "130";
    public static string Card105GodDefenseDescription = "";

    // Card106
    public static string Card106Number = "106";
    public static string Card106Name = "Crius";
    public static string Card106Realm = "Skies";
    public static string Card106Type = "God";
    public static string Card106Description = "Crius is the Titanic God of constellations.";
    public static Sprite Card106BaseImage;
    public static string Card106GodType = "Titan";
    public static string Card106GodHealth = "220";
    public static string Card106GodAttackName = "Call of Orion";
    public static string Card106GodAttackNumber = "130";
    public static string Card106GodAttackDescription = "If Coeus is in your Temple, add 130 Attack Points.";
    public static string Card106GodDefenseName = "Galaxy Dust";
    public static string Card106GodDefenseNumber = "150";
    public static string Card106GodDefenseDescription = "";

    // Card107
    public static string Card107Number = "107";
    public static string Card107Name = "Gaia";
    public static string Card107Realm = "Skies";
    public static string Card107Type = "God";
    public static string Card107Description = "Gaia is the Primordial Goddess of the Earth.";
    public static Sprite Card107BaseImage;
    public static string Card107GodType = "Primordial";
    public static string Card107GodHealth = "340";
    public static string Card107GodAttackName = "Land & Seas";
    public static string Card107GodAttackNumber = "150";
    public static string Card107GodAttackDescription = "";
    public static string Card107GodDefenseName = "Mother Nature";
    public static string Card107GodDefenseNumber = "330";
    public static string Card107GodDefenseDescription = "";

    // Card108
    public static string Card108Number = "108";
    public static string Card108Name = "Ganymede";
    public static string Card108Realm = "Skies";
    public static string Card108Type = "God";
    public static string Card108Description = "Ganymede is the God of cup-bearing and servants.";
    public static Sprite Card108BaseImage;
    public static string Card108GodType = "Deity";
    public static string Card108GodHealth = "60";
    public static string Card108GodAttackName = "Power Chalice";
    public static string Card108GodAttackNumber = "30";
    public static string Card108GodAttackDescription = "";
    public static string Card108GodDefenseName = "Refill";
    public static string Card108GodDefenseNumber = "30";
    public static string Card108GodDefenseDescription = "Heal 30 Health Points to Ganymede.";

    // Card109
    public static string Card109Number = "109";
    public static string Card109Name = "Hera";
    public static string Card109Realm = "Skies";
    public static string Card109Type = "God";
    public static string Card109Description = "Hera is the Olympic Goddess of marriage, childbirth, empires, and kingdoms.";
    public static Sprite Card109BaseImage;
    public static string Card109GodType = "Olympian";
    public static string Card109GodHealth = "450";
    public static string Card109GodAttackName = "Royal Blood";
    public static string Card109GodAttackNumber = "270";
    public static string Card109GodAttackDescription = "";
    public static string Card109GodDefenseName = "Sacred Bond";
    public static string Card109GodDefenseNumber = "380";
    public static string Card109GodDefenseDescription = "All Olympians in Opponent's Temple may not attack next turn.";

    // Card110
    public static string Card110Number = "110";
    public static string Card110Name = "Hermes";
    public static string Card110Realm = "Skies";
    public static string Card110Type = "God";
    public static string Card110Description = "Hermes is the Olympic God of travel, boundaries, communication, and trade.";
    public static Sprite Card110BaseImage;
    public static string Card110GodType = "Olympian";
    public static string Card110GodHealth = "350";
    public static string Card110GodAttackName = "Messages of Time";
    public static string Card110GodAttackNumber = "220";
    public static string Card110GodAttackDescription = "";
    public static string Card110GodDefenseName = "Great Wall";
    public static string Card110GodDefenseNumber = "250";
    public static string Card110GodDefenseDescription = "";

    // Card111
    public static string Card111Number = "111";
    public static string Card111Name = "Iris";
    public static string Card111Realm = "Skies";
    public static string Card111Type = "God";
    public static string Card111Description = "Iris is the Goddess of rainbows and messages.";
    public static Sprite Card111BaseImage;
    public static string Card111GodType = "Deity";
    public static string Card111GodHealth = "180";
    public static string Card111GodAttackName = "Prism Blast";
    public static string Card111GodAttackNumber = "140";
    public static string Card111GodAttackDescription = "";
    public static string Card111GodDefenseName = "Pot of Gold";
    public static string Card111GodDefenseNumber = "130";
    public static string Card111GodDefenseDescription = "";

    // Card112
    public static string Card112Number = "112";
    public static string Card112Name = "Phanes";
    public static string Card112Realm = "Skies";
    public static string Card112Type = "God";
    public static string Card112Description = "Phanes is the Primordial God of tradition and procreation.";
    public static Sprite Card112BaseImage;
    public static string Card112GodType = "Primordial";
    public static string Card112GodHealth = "270";
    public static string Card112GodAttackName = "Generation Alpha";
    public static string Card112GodAttackNumber = "170";
    public static string Card112GodAttackDescription = "";
    public static string Card112GodDefenseName = "Generation Omega";
    public static string Card112GodDefenseNumber = "200";
    public static string Card112GodDefenseDescription = "";

    // Card113
    public static string Card113Number = "113";
    public static string Card113Name = "Uranus";
    public static string Card113Realm = "Skies";
    public static string Card113Type = "God";
    public static string Card113Description = "Uranus is the Primordial God of the heavens.";
    public static Sprite Card113BaseImage;
    public static string Card113GodType = "Primordial";
    public static string Card113GodHealth = "220";
    public static string Card113GodAttackName = "Titanic Push";
    public static string Card113GodAttackNumber = "160";
    public static string Card113GodAttackDescription = "";
    public static string Card113GodDefenseName = "Heavenly Realm";
    public static string Card113GodDefenseNumber = "130";
    public static string Card113GodDefenseDescription = "";

    // Card114
    public static string Card114Number = "114";
    public static string Card114Name = "Realm of the Gods";
    public static string Card114Realm = "Epic";
    public static string Card114Type = "Realm";
    public static string Card114Description = "Realm of the Gods is wild and allows all Gods the ability to attack, no matter their realm. Any God may defend, and any Myth may be played.";
    public static Sprite Card114BaseImage;
    public static string Card114GodType = "";
    public static string Card114GodHealth = "";
    public static string Card114GodAttackName = "";
    public static string Card114GodAttackNumber = "";
    public static string Card114GodAttackDescription = "";
    public static string Card114GodDefenseName = "";
    public static string Card114GodDefenseNumber = "";
    public static string Card114GodDefenseDescription = "";

    // Card115
    public static string Card115Number = "115";
    public static string Card115Name = "Reversing Realms";
    public static string Card115Realm = "Epic";
    public static string Card115Type = "Myth";
    public static string Card115Description = "Place the top Realm card into its owner's Temple Crypt, and start using the newly-revealed Realm until a new Realm is played.";
    public static Sprite Card115BaseImage;
    public static string Card115GodType = "";
    public static string Card115GodHealth = "";
    public static string Card115GodAttackName = "";
    public static string Card115GodAttackNumber = "";
    public static string Card115GodAttackDescription = "";
    public static string Card115GodDefenseName = "";
    public static string Card115GodDefenseNumber = "";
    public static string Card115GodDefenseDescription = "";

    // Card116
    public static string Card116Number = "116";
    public static string Card116Name = "Olympic Rings";
    public static string Card116Realm = "Epic";
    public static string Card116Type = "Myth";
    public static string Card116Description = "All Olympians in your Temple add 200 Defense Points to each Olympian if defending from your Opponent's next turn.";
    public static Sprite Card116BaseImage;
    public static string Card116GodType = "";
    public static string Card116GodHealth = "";
    public static string Card116GodAttackName = "";
    public static string Card116GodAttackNumber = "";
    public static string Card116GodAttackDescription = "";
    public static string Card116GodDefenseName = "";
    public static string Card116GodDefenseNumber = "";
    public static string Card116GodDefenseDescription = "";

    // Card117
    public static string Card117Number = "117";
    public static string Card117Name = "Breath of Life";
    public static string Card117Realm = "Epic";
    public static string Card117Type = "Myth";
    public static string Card117Description = "Heal all Gods in your Temple by 100 Health Points.";
    public static Sprite Card117BaseImage;
    public static string Card117GodType = "";
    public static string Card117GodHealth = "";
    public static string Card117GodAttackName = "";
    public static string Card117GodAttackNumber = "";
    public static string Card117GodAttackDescription = "";
    public static string Card117GodDefenseName = "";
    public static string Card117GodDefenseNumber = "";
    public static string Card117GodDefenseDescription = "";

    // Card118
    public static string Card118Number = "118";
    public static string Card118Name = "Dethrone";
    public static string Card118Realm = "Epic";
    public static string Card118Type = "Myth";
    public static string Card118Description = "All Titans in your Opponent's Temple are immediately moved to your Opponent's Temple Crypt.";
    public static Sprite Card118BaseImage;
    public static string Card118GodType = "";
    public static string Card118GodHealth = "";
    public static string Card118GodAttackName = "";
    public static string Card118GodAttackNumber = "";
    public static string Card118GodAttackDescription = "";
    public static string Card118GodDefenseName = "";
    public static string Card118GodDefenseNumber = "";
    public static string Card118GodDefenseDescription = "";

    // Card119
    public static string Card119Number = "119";
    public static string Card119Name = "Brotherhood";
    public static string Card119Realm = "Epic";
    public static string Card119Type = "Myth";
    public static string Card119Description = "If Hades, Poseidon, and/or Zeus are in your Temple, add 300 Attack Points to each Hades, Poseidon, and/or Zeus if they are attacking your Opponent this turn.";
    public static Sprite Card119BaseImage;
    public static string Card119GodType = "";
    public static string Card119GodHealth = "";
    public static string Card119GodAttackName = "";
    public static string Card119GodAttackNumber = "";
    public static string Card119GodAttackDescription = "";
    public static string Card119GodDefenseName = "";
    public static string Card119GodDefenseNumber = "";
    public static string Card119GodDefenseDescription = "";

    // Card120
    public static string Card120Number = "120";
    public static string Card120Name = "Hades";
    public static string Card120Realm = "Epic";
    public static string Card120Type = "God";
    public static string Card120Description = "Hades is the God of the Underworld, death, and wealth.";
    public static Sprite Card120BaseImage;
    public static string Card120GodType = "Deity";
    public static string Card120GodHealth = "750";
    public static string Card120GodAttackName = "Hell Hounds";
    public static string Card120GodAttackNumber = "500";
    public static string Card120GodAttackDescription = "";
    public static string Card120GodDefenseName = "Flood of the Styx";
    public static string Card120GodDefenseNumber = "290";
    public static string Card120GodDefenseDescription = "If Raft of Charon is in your Temple, all Gods in your Opponent's Temple each lose 250 Health Points";

    // Card121
    public static string Card121Number = "121";
    public static string Card121Name = "Poseidon";
    public static string Card121Realm = "Epic";
    public static string Card121Type = "God";
    public static string Card121Description = "Poseidon is the Olympic God of the sea, rivers, floods, and earthquakes.";
    public static Sprite Card121BaseImage;
    public static string Card121GodType = "Olympian";
    public static string Card121GodHealth = "750";
    public static string Card121GodAttackName = "Storm Surge";
    public static string Card121GodAttackNumber = "390";
    public static string Card121GodAttackDescription = "If Atlantis is in your Temple, add 200 Attack Points and heal 100 Health Points to Poseidon";
    public static string Card121GodDefenseName = "Wall of the Reef";
    public static string Card121GodDefenseNumber = "400";
    public static string Card121GodDefenseDescription = "";

    // Card122
    public static string Card122Number = "122";
    public static string Card122Name = "Zeus";
    public static string Card122Realm = "Epic";
    public static string Card122Type = "God";
    public static string Card122Description = "Zeus is the Olympic God of the sky, thunder, lightning, and justice.";
    public static Sprite Card122BaseImage;
    public static string Card122GodType = "Olympian";
    public static string Card122GodHealth = "750";
    public static string Card122GodAttackName = "Electric Volt";
    public static string Card122GodAttackNumber = "430";
    public static string Card122GodAttackDescription = "If Lightning Bolt is in your Temple, all Gods in your Opponent's Temple each lose 430 Health Points";
    public static string Card122GodDefenseName = "Wing of an Eagle";
    public static string Card122GodDefenseNumber = "360";
    public static string Card122GodDefenseDescription = "";

    // Card123
    public static string Card123Number = "123";
    public static string Card123Name = "Realm of the World";
    public static string Card123Realm = "World";
    public static string Card123Type = "Realm";
    public static string Card123Description = "Realm of the World only allows World Gods the ability to attack. Any God may defend, and any Myth may be played.";
    public static Sprite Card123BaseImage;
    public static string Card123GodType = "";
    public static string Card123GodHealth = "";
    public static string Card123GodAttackName = "";
    public static string Card123GodAttackNumber = "";
    public static string Card123GodAttackDescription = "";
    public static string Card123GodDefenseName = "";
    public static string Card123GodDefenseNumber = "";
    public static string Card123GodDefenseDescription = "";

    // Card124
    public static string Card124Number = "124";
    public static string Card124Name = "Cleopatra's Asp";
    public static string Card124Realm = "World";
    public static string Card124Type = "Myth";
    public static string Card124Description = "Add 80 Attack Points to all World Gods in your Temple if they are attacking your Opponent this turn.";
    public static Sprite Card124BaseImage;
    public static string Card124GodType = "";
    public static string Card124GodHealth = "";
    public static string Card124GodAttackName = "";
    public static string Card124GodAttackNumber = "";
    public static string Card124GodAttackDescription = "";
    public static string Card124GodDefenseName = "";
    public static string Card124GodDefenseNumber = "";
    public static string Card124GodDefenseDescription = "";

    // Card125
    public static string Card125Number = "125";
    public static string Card125Name = "Great Pyramid";
    public static string Card125Realm = "World";
    public static string Card125Type = "Myth";
    public static string Card125Description = "Add 80 Defense Points to all World Gods in your Temple if they are defending from your Opponent's next turn.";
    public static Sprite Card125BaseImage;
    public static string Card125GodType = "";
    public static string Card125GodHealth = "";
    public static string Card125GodAttackName = "";
    public static string Card125GodAttackNumber = "";
    public static string Card125GodAttackDescription = "";
    public static string Card125GodDefenseName = "";
    public static string Card125GodDefenseNumber = "";
    public static string Card125GodDefenseDescription = "";

    // Card126
    public static string Card126Number = "126";
    public static string Card126Name = "Loki's Revenge";
    public static string Card126Realm = "World";
    public static string Card126Type = "Myth";
    public static string Card126Description = "If Thor is in your temple, add 100 Attack Points to Thor if they are attacking your Opponent this turn.";
    public static Sprite Card126BaseImage;
    public static string Card126GodType = "";
    public static string Card126GodHealth = "";
    public static string Card126GodAttackName = "";
    public static string Card126GodAttackNumber = "";
    public static string Card126GodAttackDescription = "";
    public static string Card126GodDefenseName = "";
    public static string Card126GodDefenseNumber = "";
    public static string Card126GodDefenseDescription = "";

    // Card127
    public static string Card127Number = "127";
    public static string Card127Name = "Ride to Valhalla";
    public static string Card127Realm = "World";
    public static string Card127Type = "Myth";
    public static string Card127Description = "Heal all World Gods in your Temple by 100 Health Points.";
    public static Sprite Card127BaseImage;
    public static string Card127GodType = "";
    public static string Card127GodHealth = "";
    public static string Card127GodAttackName = "";
    public static string Card127GodAttackNumber = "";
    public static string Card127GodAttackDescription = "";
    public static string Card127GodDefenseName = "";
    public static string Card127GodDefenseNumber = "";
    public static string Card127GodDefenseDescription = "";

    // Card128
    public static string Card128Number = "128";
    public static string Card128Name = "Royal Valley";
    public static string Card128Realm = "World";
    public static string Card128Type = "Myth";
    public static string Card128Description = "If Isis, Anubis, and/or Ra are in your Temple, add 150 Attack Points to each Isis, Anubis, and/or Ra if they are attacking your Opponent this turn.";
    public static Sprite Card128BaseImage;
    public static string Card128GodType = "";
    public static string Card128GodHealth = "";
    public static string Card128GodAttackName = "";
    public static string Card128GodAttackNumber = "";
    public static string Card128GodAttackDescription = "";
    public static string Card128GodDefenseName = "";
    public static string Card128GodDefenseNumber = "";
    public static string Card128GodDefenseDescription = "";

    // Card129
    public static string Card129Number = "129";
    public static string Card129Name = "Veil of the Valkyries";
    public static string Card129Realm = "World";
    public static string Card129Type = "Myth";
    public static string Card129Description = "If Odin and/or Thor are in your Temple, add 150 Defense Points to each Odin and/or Thor if they are defending from your Opponent's next turn.";
    public static Sprite Card129BaseImage;
    public static string Card129GodType = "";
    public static string Card129GodHealth = "";
    public static string Card129GodAttackName = "";
    public static string Card129GodAttackNumber = "";
    public static string Card129GodAttackDescription = "";
    public static string Card129GodDefenseName = "";
    public static string Card129GodDefenseNumber = "";
    public static string Card129GodDefenseDescription = "";

    // Card130
    public static string Card130Number = "130";
    public static string Card130Name = "Anubis";
    public static string Card130Realm = "World";
    public static string Card130Type = "God";
    public static string Card130Description = "Anubis is the Egyptian God of the dead.";
    public static Sprite Card130BaseImage;
    public static string Card130GodType = "Deity";
    public static string Card130GodHealth = "500";
    public static string Card130GodAttackName = "Laugh of the Jackal";
    public static string Card130GodAttackNumber = "210";
    public static string Card130GodAttackDescription = "";
    public static string Card130GodDefenseName = "Charon's Nile";
    public static string Card130GodDefenseNumber = "260";
    public static string Card130GodDefenseDescription = "If Raft of Charon is in your Temple, all Gods in your Opponent's Temple each lose 100 Health Points";

    // Card131
    public static string Card131Number = "131";
    public static string Card131Name = "Isis";
    public static string Card131Realm = "World";
    public static string Card131Type = "God";
    public static string Card131Description = "Isis is the Egyptian Goddess of life, magic, and protection.";
    public static Sprite Card131BaseImage;
    public static string Card131GodType = "Deity";
    public static string Card131GodHealth = "500";
    public static string Card131GodAttackName = "Rush of the Nile";
    public static string Card131GodAttackNumber = "240";
    public static string Card131GodAttackDescription = "If both Ra and Anubis are in your Temple, all Gods in your Opponent's Temple each lose 500 Health Points";
    public static string Card131GodDefenseName = "Protectorate";
    public static string Card131GodDefenseNumber = "240";
    public static string Card131GodDefenseDescription = "";

    // Card132
    public static string Card132Number = "132";
    public static string Card132Name = "Odin";
    public static string Card132Realm = "World";
    public static string Card132Type = "God";
    public static string Card132Description = "Odin is the Norse God of wisdom, magic, death, and divination.";
    public static Sprite Card132BaseImage;
    public static string Card132GodType = "Deity";
    public static string Card132GodHealth = "500";
    public static string Card132GodAttackName = "Spear Throw";
    public static string Card132GodAttackNumber = "190";
    public static string Card132GodAttackDescription = "If Thor is in your Temple, add 100 Attack Points";
    public static string Card132GodDefenseName = "Spells of the Sage";
    public static string Card132GodDefenseNumber = "290";
    public static string Card132GodDefenseDescription = "";

    // Card133
    public static string Card133Number = "133";
    public static string Card133Name = "Ra";
    public static string Card133Realm = "World";
    public static string Card133Type = "God";
    public static string Card133Description = "Ra is the Egyptian God of the sun and creation.";
    public static Sprite Card133BaseImage;
    public static string Card133GodType = "Deity";
    public static string Card133GodHealth = "500";
    public static string Card133GodAttackName = "Sun of Hell";
    public static string Card133GodAttackNumber = "290";
    public static string Card133GodAttackDescription = "If Hades is in your Temple, heal 200 Health Points to Ra";
    public static string Card133GodDefenseName = "Sun of Creation";
    public static string Card133GodDefenseNumber = "180";
    public static string Card133GodDefenseDescription = "Heal 100 Health Points to Ra";

    // Card134
    public static string Card134Number = "134";
    public static string Card134Name = "Thor";
    public static string Card134Realm = "World";
    public static string Card134Type = "God";
    public static string Card134Description = "Thor is the Norse God of thunder, lightning, storms, and protection.";
    public static Sprite Card134BaseImage;
    public static string Card134GodType = "Deity";
    public static string Card134GodHealth = "500";
    public static string Card134GodAttackName = "Hammer Rush";
    public static string Card134GodAttackNumber = "230";
    public static string Card134GodAttackDescription = "If Odin is in your Temple, all Gods in your Opponent's Temple each lose 230 Health Points";
    public static string Card134GodDefenseName = "Electric Veil";
    public static string Card134GodDefenseNumber = "240";
    public static string Card134GodDefenseDescription = "";
    
    // Static Arrays
    public static string[] CardNumber = {Card001Number, Card002Number, Card003Number, Card004Number, Card005Number, Card006Number, Card007Number, Card008Number, Card009Number, Card010Number, Card011Number, Card012Number, Card013Number, Card014Number, Card015Number, Card016Number, Card017Number, Card018Number, Card019Number, Card020Number, Card021Number, Card022Number, Card023Number, Card024Number, Card025Number, Card026Number, Card027Number, Card028Number, Card029Number, Card030Number, Card031Number, Card032Number, Card033Number, Card034Number, Card035Number, Card036Number, Card037Number, Card038Number, Card039Number, Card040Number, Card041Number, Card042Number, Card043Number, Card044Number, Card045Number, Card046Number, Card047Number, Card048Number, Card049Number, Card050Number, Card051Number, Card052Number, Card053Number, Card054Number, Card055Number, Card056Number, Card057Number, Card058Number, Card059Number, Card060Number, Card061Number, Card062Number, Card063Number, Card064Number, Card065Number, Card066Number, Card067Number, Card068Number, Card069Number, Card070Number, Card071Number, Card072Number, Card073Number, Card074Number, Card075Number, Card076Number, Card077Number, Card078Number, Card079Number, Card080Number, Card081Number, Card082Number, Card083Number, Card084Number, Card085Number, Card086Number, Card087Number, Card088Number, Card089Number, Card090Number, Card091Number, Card092Number, Card093Number, Card094Number, Card095Number, Card096Number, Card097Number, Card098Number, Card099Number, Card100Number, Card101Number, Card102Number, Card103Number, Card104Number, Card105Number, Card106Number, Card107Number, Card108Number, Card109Number, Card110Number, Card111Number, Card112Number, Card113Number, Card114Number, Card115Number, Card116Number, Card117Number, Card118Number, Card119Number, Card120Number, Card121Number, Card122Number, Card123Number, Card124Number, Card125Number, Card126Number, Card127Number, Card128Number, Card129Number, Card130Number, Card131Number, Card132Number, Card133Number, Card134Number};

    public static string[] CardName = {Card001Name, Card002Name, Card003Name, Card004Name, Card005Name, Card006Name, Card007Name, Card008Name, Card009Name, Card010Name, Card011Name, Card012Name, Card013Name, Card014Name, Card015Name, Card016Name, Card017Name, Card018Name, Card019Name, Card020Name, Card021Name, Card022Name, Card023Name, Card024Name, Card025Name, Card026Name, Card027Name, Card028Name, Card029Name, Card030Name, Card031Name, Card032Name, Card033Name, Card034Name, Card035Name, Card036Name, Card037Name, Card038Name, Card039Name, Card040Name, Card041Name, Card042Name, Card043Name, Card044Name, Card045Name, Card046Name, Card047Name, Card048Name, Card049Name, Card050Name, Card051Name, Card052Name, Card053Name, Card054Name, Card055Name, Card056Name, Card057Name, Card058Name, Card059Name, Card060Name, Card061Name, Card062Name, Card063Name, Card064Name, Card065Name, Card066Name, Card067Name, Card068Name, Card069Name, Card070Name, Card071Name, Card072Name, Card073Name, Card074Name, Card075Name, Card076Name, Card077Name, Card078Name, Card079Name, Card080Name, Card081Name, Card082Name, Card083Name, Card084Name, Card085Name, Card086Name, Card087Name, Card088Name, Card089Name, Card090Name, Card091Name, Card092Name, Card093Name, Card094Name, Card095Name, Card096Name, Card097Name, Card098Name, Card099Name, Card100Name, Card101Name, Card102Name, Card103Name, Card104Name, Card105Name, Card106Name, Card107Name, Card108Name, Card109Name, Card110Name, Card111Name, Card112Name, Card113Name, Card114Name, Card115Name, Card116Name, Card117Name, Card118Name, Card119Name, Card120Name, Card121Name, Card122Name, Card123Name, Card124Name, Card125Name, Card126Name, Card127Name, Card128Name, Card129Name, Card130Name, Card131Name, Card132Name, Card133Name, Card134Name};

    public static string[] CardRealm = {Card001Realm, Card002Realm, Card003Realm, Card004Realm, Card005Realm, Card006Realm, Card007Realm, Card008Realm, Card009Realm, Card010Realm, Card011Realm, Card012Realm, Card013Realm, Card014Realm, Card015Realm, Card016Realm, Card017Realm, Card018Realm, Card019Realm, Card020Realm, Card021Realm, Card022Realm, Card023Realm, Card024Realm, Card025Realm, Card026Realm, Card027Realm, Card028Realm, Card029Realm, Card030Realm, Card031Realm, Card032Realm, Card033Realm, Card034Realm, Card035Realm, Card036Realm, Card037Realm, Card038Realm, Card039Realm, Card040Realm, Card041Realm, Card042Realm, Card043Realm, Card044Realm, Card045Realm, Card046Realm, Card047Realm, Card048Realm, Card049Realm, Card050Realm, Card051Realm, Card052Realm, Card053Realm, Card054Realm, Card055Realm, Card056Realm, Card057Realm, Card058Realm, Card059Realm, Card060Realm, Card061Realm, Card062Realm, Card063Realm, Card064Realm, Card065Realm, Card066Realm, Card067Realm, Card068Realm, Card069Realm, Card070Realm, Card071Realm, Card072Realm, Card073Realm, Card074Realm, Card075Realm, Card076Realm, Card077Realm, Card078Realm, Card079Realm, Card080Realm, Card081Realm, Card082Realm, Card083Realm, Card084Realm, Card085Realm, Card086Realm, Card087Realm, Card088Realm, Card089Realm, Card090Realm, Card091Realm, Card092Realm, Card093Realm, Card094Realm, Card095Realm, Card096Realm, Card097Realm, Card098Realm, Card099Realm, Card100Realm, Card101Realm, Card102Realm, Card103Realm, Card104Realm, Card105Realm, Card106Realm, Card107Realm, Card108Realm, Card109Realm, Card110Realm, Card111Realm, Card112Realm, Card113Realm, Card114Realm, Card115Realm, Card116Realm, Card117Realm, Card118Realm, Card119Realm, Card120Realm, Card121Realm, Card122Realm, Card123Realm, Card124Realm, Card125Realm, Card126Realm, Card127Realm, Card128Realm, Card129Realm, Card130Realm, Card131Realm, Card132Realm, Card133Realm, Card134Realm};

    public static string[] CardType = {Card001Type, Card002Type, Card003Type, Card004Type, Card005Type, Card006Type, Card007Type, Card008Type, Card009Type, Card010Type, Card011Type, Card012Type, Card013Type, Card014Type, Card015Type, Card016Type, Card017Type, Card018Type, Card019Type, Card020Type, Card021Type, Card022Type, Card023Type, Card024Type, Card025Type, Card026Type, Card027Type, Card028Type, Card029Type, Card030Type, Card031Type, Card032Type, Card033Type, Card034Type, Card035Type, Card036Type, Card037Type, Card038Type, Card039Type, Card040Type, Card041Type, Card042Type, Card043Type, Card044Type, Card045Type, Card046Type, Card047Type, Card048Type, Card049Type, Card050Type, Card051Type, Card052Type, Card053Type, Card054Type, Card055Type, Card056Type, Card057Type, Card058Type, Card059Type, Card060Type, Card061Type, Card062Type, Card063Type, Card064Type, Card065Type, Card066Type, Card067Type, Card068Type, Card069Type, Card070Type, Card071Type, Card072Type, Card073Type, Card074Type, Card075Type, Card076Type, Card077Type, Card078Type, Card079Type, Card080Type, Card081Type, Card082Type, Card083Type, Card084Type, Card085Type, Card086Type, Card087Type, Card088Type, Card089Type, Card090Type, Card091Type, Card092Type, Card093Type, Card094Type, Card095Type, Card096Type, Card097Type, Card098Type, Card099Type, Card100Type, Card101Type, Card102Type, Card103Type, Card104Type, Card105Type, Card106Type, Card107Type, Card108Type, Card109Type, Card110Type, Card111Type, Card112Type, Card113Type, Card114Type, Card115Type, Card116Type, Card117Type, Card118Type, Card119Type, Card120Type, Card121Type, Card122Type, Card123Type, Card124Type, Card125Type, Card126Type, Card127Type, Card128Type, Card129Type, Card130Type, Card131Type, Card132Type, Card133Type, Card134Type};

    public static string[] CardDescription = {Card001Description, Card002Description, Card003Description, Card004Description, Card005Description, Card006Description, Card007Description, Card008Description, Card009Description, Card010Description, Card011Description, Card012Description, Card013Description, Card014Description, Card015Description, Card016Description, Card017Description, Card018Description, Card019Description, Card020Description, Card021Description, Card022Description, Card023Description, Card024Description, Card025Description, Card026Description, Card027Description, Card028Description, Card029Description, Card030Description, Card031Description, Card032Description, Card033Description, Card034Description, Card035Description, Card036Description, Card037Description, Card038Description, Card039Description, Card040Description, Card041Description, Card042Description, Card043Description, Card044Description, Card045Description, Card046Description, Card047Description, Card048Description, Card049Description, Card050Description, Card051Description, Card052Description, Card053Description, Card054Description, Card055Description, Card056Description, Card057Description, Card058Description, Card059Description, Card060Description, Card061Description, Card062Description, Card063Description, Card064Description, Card065Description, Card066Description, Card067Description, Card068Description, Card069Description, Card070Description, Card071Description, Card072Description, Card073Description, Card074Description, Card075Description, Card076Description, Card077Description, Card078Description, Card079Description, Card080Description, Card081Description, Card082Description, Card083Description, Card084Description, Card085Description, Card086Description, Card087Description, Card088Description, Card089Description, Card090Description, Card091Description, Card092Description, Card093Description, Card094Description, Card095Description, Card096Description, Card097Description, Card098Description, Card099Description, Card100Description, Card101Description, Card102Description, Card103Description, Card104Description, Card105Description, Card106Description, Card107Description, Card108Description, Card109Description, Card110Description, Card111Description, Card112Description, Card113Description, Card114Description, Card115Description, Card116Description, Card117Description, Card118Description, Card119Description, Card120Description, Card121Description, Card122Description, Card123Description, Card124Description, Card125Description, Card126Description, Card127Description, Card128Description, Card129Description, Card130Description, Card131Description, Card132Description, Card133Description, Card134Description};

    public static Sprite[] CardBaseImage = {Card001BaseImage, Card002BaseImage, Card003BaseImage, Card004BaseImage, Card005BaseImage, Card006BaseImage, Card007BaseImage, Card008BaseImage, Card009BaseImage, Card010BaseImage, Card011BaseImage, Card012BaseImage, Card013BaseImage, Card014BaseImage, Card015BaseImage, Card016BaseImage, Card017BaseImage, Card018BaseImage, Card019BaseImage, Card020BaseImage, Card021BaseImage, Card022BaseImage, Card023BaseImage, Card024BaseImage, Card025BaseImage, Card026BaseImage, Card027BaseImage, Card028BaseImage, Card029BaseImage, Card030BaseImage, Card031BaseImage, Card032BaseImage, Card033BaseImage, Card034BaseImage, Card035BaseImage, Card036BaseImage, Card037BaseImage, Card038BaseImage, Card039BaseImage, Card040BaseImage, Card041BaseImage, Card042BaseImage, Card043BaseImage, Card044BaseImage, Card045BaseImage, Card046BaseImage, Card047BaseImage, Card048BaseImage, Card049BaseImage, Card050BaseImage, Card051BaseImage, Card052BaseImage, Card053BaseImage, Card054BaseImage, Card055BaseImage, Card056BaseImage, Card057BaseImage, Card058BaseImage, Card059BaseImage, Card060BaseImage, Card061BaseImage, Card062BaseImage, Card063BaseImage, Card064BaseImage, Card065BaseImage, Card066BaseImage, Card067BaseImage, Card068BaseImage, Card069BaseImage, Card070BaseImage, Card071BaseImage, Card072BaseImage, Card073BaseImage, Card074BaseImage, Card075BaseImage, Card076BaseImage, Card077BaseImage, Card078BaseImage, Card079BaseImage, Card080BaseImage, Card081BaseImage, Card082BaseImage, Card083BaseImage, Card084BaseImage, Card085BaseImage, Card086BaseImage, Card087BaseImage, Card088BaseImage, Card089BaseImage, Card090BaseImage, Card091BaseImage, Card092BaseImage, Card093BaseImage, Card094BaseImage, Card095BaseImage, Card096BaseImage, Card097BaseImage, Card098BaseImage, Card099BaseImage, Card100BaseImage, Card101BaseImage, Card102BaseImage, Card103BaseImage, Card104BaseImage, Card105BaseImage, Card106BaseImage, Card107BaseImage, Card108BaseImage, Card109BaseImage, Card110BaseImage, Card111BaseImage, Card112BaseImage, Card113BaseImage, Card114BaseImage, Card115BaseImage, Card116BaseImage, Card117BaseImage, Card118BaseImage, Card119BaseImage, Card120BaseImage, Card121BaseImage, Card122BaseImage, Card123BaseImage, Card124BaseImage, Card125BaseImage, Card126BaseImage, Card127BaseImage, Card128BaseImage, Card129BaseImage, Card130BaseImage, Card131BaseImage, Card132BaseImage, Card133BaseImage, Card134BaseImage};

    public static string[] CardGodType = {Card001GodType, Card002GodType, Card003GodType, Card004GodType, Card005GodType, Card006GodType, Card007GodType, Card008GodType, Card009GodType, Card010GodType, Card011GodType, Card012GodType, Card013GodType, Card014GodType, Card015GodType, Card016GodType, Card017GodType, Card018GodType, Card019GodType, Card020GodType, Card021GodType, Card022GodType, Card023GodType, Card024GodType, Card025GodType, Card026GodType, Card027GodType, Card028GodType, Card029GodType, Card030GodType, Card031GodType, Card032GodType, Card033GodType, Card034GodType, Card035GodType, Card036GodType, Card037GodType, Card038GodType, Card039GodType, Card040GodType, Card041GodType, Card042GodType, Card043GodType, Card044GodType, Card045GodType, Card046GodType, Card047GodType, Card048GodType, Card049GodType, Card050GodType, Card051GodType, Card052GodType, Card053GodType, Card054GodType, Card055GodType, Card056GodType, Card057GodType, Card058GodType, Card059GodType, Card060GodType, Card061GodType, Card062GodType, Card063GodType, Card064GodType, Card065GodType, Card066GodType, Card067GodType, Card068GodType, Card069GodType, Card070GodType, Card071GodType, Card072GodType, Card073GodType, Card074GodType, Card075GodType, Card076GodType, Card077GodType, Card078GodType, Card079GodType, Card080GodType, Card081GodType, Card082GodType, Card083GodType, Card084GodType, Card085GodType, Card086GodType, Card087GodType, Card088GodType, Card089GodType, Card090GodType, Card091GodType, Card092GodType, Card093GodType, Card094GodType, Card095GodType, Card096GodType, Card097GodType, Card098GodType, Card099GodType, Card100GodType, Card101GodType, Card102GodType, Card103GodType, Card104GodType, Card105GodType, Card106GodType, Card107GodType, Card108GodType, Card109GodType, Card110GodType, Card111GodType, Card112GodType, Card113GodType, Card114GodType, Card115GodType, Card116GodType, Card117GodType, Card118GodType, Card119GodType, Card120GodType, Card121GodType, Card122GodType, Card123GodType, Card124GodType, Card125GodType, Card126GodType, Card127GodType, Card128GodType, Card129GodType, Card130GodType, Card131GodType, Card132GodType, Card133GodType, Card134GodType};

    public static string[] CardGodHealth = {Card001GodHealth, Card002GodHealth, Card003GodHealth, Card004GodHealth, Card005GodHealth, Card006GodHealth, Card007GodHealth, Card008GodHealth, Card009GodHealth, Card010GodHealth, Card011GodHealth, Card012GodHealth, Card013GodHealth, Card014GodHealth, Card015GodHealth, Card016GodHealth, Card017GodHealth, Card018GodHealth, Card019GodHealth, Card020GodHealth, Card021GodHealth, Card022GodHealth, Card023GodHealth, Card024GodHealth, Card025GodHealth, Card026GodHealth, Card027GodHealth, Card028GodHealth, Card029GodHealth, Card030GodHealth, Card031GodHealth, Card032GodHealth, Card033GodHealth, Card034GodHealth, Card035GodHealth, Card036GodHealth, Card037GodHealth, Card038GodHealth, Card039GodHealth, Card040GodHealth, Card041GodHealth, Card042GodHealth, Card043GodHealth, Card044GodHealth, Card045GodHealth, Card046GodHealth, Card047GodHealth, Card048GodHealth, Card049GodHealth, Card050GodHealth, Card051GodHealth, Card052GodHealth, Card053GodHealth, Card054GodHealth, Card055GodHealth, Card056GodHealth, Card057GodHealth, Card058GodHealth, Card059GodHealth, Card060GodHealth, Card061GodHealth, Card062GodHealth, Card063GodHealth, Card064GodHealth, Card065GodHealth, Card066GodHealth, Card067GodHealth, Card068GodHealth, Card069GodHealth, Card070GodHealth, Card071GodHealth, Card072GodHealth, Card073GodHealth, Card074GodHealth, Card075GodHealth, Card076GodHealth, Card077GodHealth, Card078GodHealth, Card079GodHealth, Card080GodHealth, Card081GodHealth, Card082GodHealth, Card083GodHealth, Card084GodHealth, Card085GodHealth, Card086GodHealth, Card087GodHealth, Card088GodHealth, Card089GodHealth, Card090GodHealth, Card091GodHealth, Card092GodHealth, Card093GodHealth, Card094GodHealth, Card095GodHealth, Card096GodHealth, Card097GodHealth, Card098GodHealth, Card099GodHealth, Card100GodHealth, Card101GodHealth, Card102GodHealth, Card103GodHealth, Card104GodHealth, Card105GodHealth, Card106GodHealth, Card107GodHealth, Card108GodHealth, Card109GodHealth, Card110GodHealth, Card111GodHealth, Card112GodHealth, Card113GodHealth, Card114GodHealth, Card115GodHealth, Card116GodHealth, Card117GodHealth, Card118GodHealth, Card119GodHealth, Card120GodHealth, Card121GodHealth, Card122GodHealth, Card123GodHealth, Card124GodHealth, Card125GodHealth, Card126GodHealth, Card127GodHealth, Card128GodHealth, Card129GodHealth, Card130GodHealth, Card131GodHealth, Card132GodHealth, Card133GodHealth, Card134GodHealth};

    public static string[] CardGodAttackName = {Card001GodAttackName, Card002GodAttackName, Card003GodAttackName, Card004GodAttackName, Card005GodAttackName, Card006GodAttackName, Card007GodAttackName, Card008GodAttackName, Card009GodAttackName, Card010GodAttackName, Card011GodAttackName, Card012GodAttackName, Card013GodAttackName, Card014GodAttackName, Card015GodAttackName, Card016GodAttackName, Card017GodAttackName, Card018GodAttackName, Card019GodAttackName, Card020GodAttackName, Card021GodAttackName, Card022GodAttackName, Card023GodAttackName, Card024GodAttackName, Card025GodAttackName, Card026GodAttackName, Card027GodAttackName, Card028GodAttackName, Card029GodAttackName, Card030GodAttackName, Card031GodAttackName, Card032GodAttackName, Card033GodAttackName, Card034GodAttackName, Card035GodAttackName, Card036GodAttackName, Card037GodAttackName, Card038GodAttackName, Card039GodAttackName, Card040GodAttackName, Card041GodAttackName, Card042GodAttackName, Card043GodAttackName, Card044GodAttackName, Card045GodAttackName, Card046GodAttackName, Card047GodAttackName, Card048GodAttackName, Card049GodAttackName, Card050GodAttackName, Card051GodAttackName, Card052GodAttackName, Card053GodAttackName, Card054GodAttackName, Card055GodAttackName, Card056GodAttackName, Card057GodAttackName, Card058GodAttackName, Card059GodAttackName, Card060GodAttackName, Card061GodAttackName, Card062GodAttackName, Card063GodAttackName, Card064GodAttackName, Card065GodAttackName, Card066GodAttackName, Card067GodAttackName, Card068GodAttackName, Card069GodAttackName, Card070GodAttackName, Card071GodAttackName, Card072GodAttackName, Card073GodAttackName, Card074GodAttackName, Card075GodAttackName, Card076GodAttackName, Card077GodAttackName, Card078GodAttackName, Card079GodAttackName, Card080GodAttackName, Card081GodAttackName, Card082GodAttackName, Card083GodAttackName, Card084GodAttackName, Card085GodAttackName, Card086GodAttackName, Card087GodAttackName, Card088GodAttackName, Card089GodAttackName, Card090GodAttackName, Card091GodAttackName, Card092GodAttackName, Card093GodAttackName, Card094GodAttackName, Card095GodAttackName, Card096GodAttackName, Card097GodAttackName, Card098GodAttackName, Card099GodAttackName, Card100GodAttackName, Card101GodAttackName, Card102GodAttackName, Card103GodAttackName, Card104GodAttackName, Card105GodAttackName, Card106GodAttackName, Card107GodAttackName, Card108GodAttackName, Card109GodAttackName, Card110GodAttackName, Card111GodAttackName, Card112GodAttackName, Card113GodAttackName, Card114GodAttackName, Card115GodAttackName, Card116GodAttackName, Card117GodAttackName, Card118GodAttackName, Card119GodAttackName, Card120GodAttackName, Card121GodAttackName, Card122GodAttackName, Card123GodAttackName, Card124GodAttackName, Card125GodAttackName, Card126GodAttackName, Card127GodAttackName, Card128GodAttackName, Card129GodAttackName, Card130GodAttackName, Card131GodAttackName, Card132GodAttackName, Card133GodAttackName, Card134GodAttackName};

    public static string[] CardGodAttackNumber = {Card001GodAttackNumber, Card002GodAttackNumber, Card003GodAttackNumber, Card004GodAttackNumber, Card005GodAttackNumber, Card006GodAttackNumber, Card007GodAttackNumber, Card008GodAttackNumber, Card009GodAttackNumber, Card010GodAttackNumber, Card011GodAttackNumber, Card012GodAttackNumber, Card013GodAttackNumber, Card014GodAttackNumber, Card015GodAttackNumber, Card016GodAttackNumber, Card017GodAttackNumber, Card018GodAttackNumber, Card019GodAttackNumber, Card020GodAttackNumber, Card021GodAttackNumber, Card022GodAttackNumber, Card023GodAttackNumber, Card024GodAttackNumber, Card025GodAttackNumber, Card026GodAttackNumber, Card027GodAttackNumber, Card028GodAttackNumber, Card029GodAttackNumber, Card030GodAttackNumber, Card031GodAttackNumber, Card032GodAttackNumber, Card033GodAttackNumber, Card034GodAttackNumber, Card035GodAttackNumber, Card036GodAttackNumber, Card037GodAttackNumber, Card038GodAttackNumber, Card039GodAttackNumber, Card040GodAttackNumber, Card041GodAttackNumber, Card042GodAttackNumber, Card043GodAttackNumber, Card044GodAttackNumber, Card045GodAttackNumber, Card046GodAttackNumber, Card047GodAttackNumber, Card048GodAttackNumber, Card049GodAttackNumber, Card050GodAttackNumber, Card051GodAttackNumber, Card052GodAttackNumber, Card053GodAttackNumber, Card054GodAttackNumber, Card055GodAttackNumber, Card056GodAttackNumber, Card057GodAttackNumber, Card058GodAttackNumber, Card059GodAttackNumber, Card060GodAttackNumber, Card061GodAttackNumber, Card062GodAttackNumber, Card063GodAttackNumber, Card064GodAttackNumber, Card065GodAttackNumber, Card066GodAttackNumber, Card067GodAttackNumber, Card068GodAttackNumber, Card069GodAttackNumber, Card070GodAttackNumber, Card071GodAttackNumber, Card072GodAttackNumber, Card073GodAttackNumber, Card074GodAttackNumber, Card075GodAttackNumber, Card076GodAttackNumber, Card077GodAttackNumber, Card078GodAttackNumber, Card079GodAttackNumber, Card080GodAttackNumber, Card081GodAttackNumber, Card082GodAttackNumber, Card083GodAttackNumber, Card084GodAttackNumber, Card085GodAttackNumber, Card086GodAttackNumber, Card087GodAttackNumber, Card088GodAttackNumber, Card089GodAttackNumber, Card090GodAttackNumber, Card091GodAttackNumber, Card092GodAttackNumber, Card093GodAttackNumber, Card094GodAttackNumber, Card095GodAttackNumber, Card096GodAttackNumber, Card097GodAttackNumber, Card098GodAttackNumber, Card099GodAttackNumber, Card100GodAttackNumber, Card101GodAttackNumber, Card102GodAttackNumber, Card103GodAttackNumber, Card104GodAttackNumber, Card105GodAttackNumber, Card106GodAttackNumber, Card107GodAttackNumber, Card108GodAttackNumber, Card109GodAttackNumber, Card110GodAttackNumber, Card111GodAttackNumber, Card112GodAttackNumber, Card113GodAttackNumber, Card114GodAttackNumber, Card115GodAttackNumber, Card116GodAttackNumber, Card117GodAttackNumber, Card118GodAttackNumber, Card119GodAttackNumber, Card120GodAttackNumber, Card121GodAttackNumber, Card122GodAttackNumber, Card123GodAttackNumber, Card124GodAttackNumber, Card125GodAttackNumber, Card126GodAttackNumber, Card127GodAttackNumber, Card128GodAttackNumber, Card129GodAttackNumber, Card130GodAttackNumber, Card131GodAttackNumber, Card132GodAttackNumber, Card133GodAttackNumber, Card134GodAttackNumber};

    public static string[] CardGodAttackDescription = {Card001GodAttackDescription, Card002GodAttackDescription, Card003GodAttackDescription, Card004GodAttackDescription, Card005GodAttackDescription, Card006GodAttackDescription, Card007GodAttackDescription, Card008GodAttackDescription, Card009GodAttackDescription, Card010GodAttackDescription, Card011GodAttackDescription, Card012GodAttackDescription, Card013GodAttackDescription, Card014GodAttackDescription, Card015GodAttackDescription, Card016GodAttackDescription, Card017GodAttackDescription, Card018GodAttackDescription, Card019GodAttackDescription, Card020GodAttackDescription, Card021GodAttackDescription, Card022GodAttackDescription, Card023GodAttackDescription, Card024GodAttackDescription, Card025GodAttackDescription, Card026GodAttackDescription, Card027GodAttackDescription, Card028GodAttackDescription, Card029GodAttackDescription, Card030GodAttackDescription, Card031GodAttackDescription, Card032GodAttackDescription, Card033GodAttackDescription, Card034GodAttackDescription, Card035GodAttackDescription, Card036GodAttackDescription, Card037GodAttackDescription, Card038GodAttackDescription, Card039GodAttackDescription, Card040GodAttackDescription, Card041GodAttackDescription, Card042GodAttackDescription, Card043GodAttackDescription, Card044GodAttackDescription, Card045GodAttackDescription, Card046GodAttackDescription, Card047GodAttackDescription, Card048GodAttackDescription, Card049GodAttackDescription, Card050GodAttackDescription, Card051GodAttackDescription, Card052GodAttackDescription, Card053GodAttackDescription, Card054GodAttackDescription, Card055GodAttackDescription, Card056GodAttackDescription, Card057GodAttackDescription, Card058GodAttackDescription, Card059GodAttackDescription, Card060GodAttackDescription, Card061GodAttackDescription, Card062GodAttackDescription, Card063GodAttackDescription, Card064GodAttackDescription, Card065GodAttackDescription, Card066GodAttackDescription, Card067GodAttackDescription, Card068GodAttackDescription, Card069GodAttackDescription, Card070GodAttackDescription, Card071GodAttackDescription, Card072GodAttackDescription, Card073GodAttackDescription, Card074GodAttackDescription, Card075GodAttackDescription, Card076GodAttackDescription, Card077GodAttackDescription, Card078GodAttackDescription, Card079GodAttackDescription, Card080GodAttackDescription, Card081GodAttackDescription, Card082GodAttackDescription, Card083GodAttackDescription, Card084GodAttackDescription, Card085GodAttackDescription, Card086GodAttackDescription, Card087GodAttackDescription, Card088GodAttackDescription, Card089GodAttackDescription, Card090GodAttackDescription, Card091GodAttackDescription, Card092GodAttackDescription, Card093GodAttackDescription, Card094GodAttackDescription, Card095GodAttackDescription, Card096GodAttackDescription, Card097GodAttackDescription, Card098GodAttackDescription, Card099GodAttackDescription, Card100GodAttackDescription, Card101GodAttackDescription, Card102GodAttackDescription, Card103GodAttackDescription, Card104GodAttackDescription, Card105GodAttackDescription, Card106GodAttackDescription, Card107GodAttackDescription, Card108GodAttackDescription, Card109GodAttackDescription, Card110GodAttackDescription, Card111GodAttackDescription, Card112GodAttackDescription, Card113GodAttackDescription, Card114GodAttackDescription, Card115GodAttackDescription, Card116GodAttackDescription, Card117GodAttackDescription, Card118GodAttackDescription, Card119GodAttackDescription, Card120GodAttackDescription, Card121GodAttackDescription, Card122GodAttackDescription, Card123GodAttackDescription, Card124GodAttackDescription, Card125GodAttackDescription, Card126GodAttackDescription, Card127GodAttackDescription, Card128GodAttackDescription, Card129GodAttackDescription, Card130GodAttackDescription, Card131GodAttackDescription, Card132GodAttackDescription, Card133GodAttackDescription, Card134GodAttackDescription};

    public static string[] CardGodDefenseName = {Card001GodDefenseName, Card002GodDefenseName, Card003GodDefenseName, Card004GodDefenseName, Card005GodDefenseName, Card006GodDefenseName, Card007GodDefenseName, Card008GodDefenseName, Card009GodDefenseName, Card010GodDefenseName, Card011GodDefenseName, Card012GodDefenseName, Card013GodDefenseName, Card014GodDefenseName, Card015GodDefenseName, Card016GodDefenseName, Card017GodDefenseName, Card018GodDefenseName, Card019GodDefenseName, Card020GodDefenseName, Card021GodDefenseName, Card022GodDefenseName, Card023GodDefenseName, Card024GodDefenseName, Card025GodDefenseName, Card026GodDefenseName, Card027GodDefenseName, Card028GodDefenseName, Card029GodDefenseName, Card030GodDefenseName, Card031GodDefenseName, Card032GodDefenseName, Card033GodDefenseName, Card034GodDefenseName, Card035GodDefenseName, Card036GodDefenseName, Card037GodDefenseName, Card038GodDefenseName, Card039GodDefenseName, Card040GodDefenseName, Card041GodDefenseName, Card042GodDefenseName, Card043GodDefenseName, Card044GodDefenseName, Card045GodDefenseName, Card046GodDefenseName, Card047GodDefenseName, Card048GodDefenseName, Card049GodDefenseName, Card050GodDefenseName, Card051GodDefenseName, Card052GodDefenseName, Card053GodDefenseName, Card054GodDefenseName, Card055GodDefenseName, Card056GodDefenseName, Card057GodDefenseName, Card058GodDefenseName, Card059GodDefenseName, Card060GodDefenseName, Card061GodDefenseName, Card062GodDefenseName, Card063GodDefenseName, Card064GodDefenseName, Card065GodDefenseName, Card066GodDefenseName, Card067GodDefenseName, Card068GodDefenseName, Card069GodDefenseName, Card070GodDefenseName, Card071GodDefenseName, Card072GodDefenseName, Card073GodDefenseName, Card074GodDefenseName, Card075GodDefenseName, Card076GodDefenseName, Card077GodDefenseName, Card078GodDefenseName, Card079GodDefenseName, Card080GodDefenseName, Card081GodDefenseName, Card082GodDefenseName, Card083GodDefenseName, Card084GodDefenseName, Card085GodDefenseName, Card086GodDefenseName, Card087GodDefenseName, Card088GodDefenseName, Card089GodDefenseName, Card090GodDefenseName, Card091GodDefenseName, Card092GodDefenseName, Card093GodDefenseName, Card094GodDefenseName, Card095GodDefenseName, Card096GodDefenseName, Card097GodDefenseName, Card098GodDefenseName, Card099GodDefenseName, Card100GodDefenseName, Card101GodDefenseName, Card102GodDefenseName, Card103GodDefenseName, Card104GodDefenseName, Card105GodDefenseName, Card106GodDefenseName, Card107GodDefenseName, Card108GodDefenseName, Card109GodDefenseName, Card110GodDefenseName, Card111GodDefenseName, Card112GodDefenseName, Card113GodDefenseName, Card114GodDefenseName, Card115GodDefenseName, Card116GodDefenseName, Card117GodDefenseName, Card118GodDefenseName, Card119GodDefenseName, Card120GodDefenseName, Card121GodDefenseName, Card122GodDefenseName, Card123GodDefenseName, Card124GodDefenseName, Card125GodDefenseName, Card126GodDefenseName, Card127GodDefenseName, Card128GodDefenseName, Card129GodDefenseName, Card130GodDefenseName, Card131GodDefenseName, Card132GodDefenseName, Card133GodDefenseName, Card134GodDefenseName};

    public static string[] CardGodDefenseNumber = {Card001GodDefenseNumber, Card002GodDefenseNumber, Card003GodDefenseNumber, Card004GodDefenseNumber, Card005GodDefenseNumber, Card006GodDefenseNumber, Card007GodDefenseNumber, Card008GodDefenseNumber, Card009GodDefenseNumber, Card010GodDefenseNumber, Card011GodDefenseNumber, Card012GodDefenseNumber, Card013GodDefenseNumber, Card014GodDefenseNumber, Card015GodDefenseNumber, Card016GodDefenseNumber, Card017GodDefenseNumber, Card018GodDefenseNumber, Card019GodDefenseNumber, Card020GodDefenseNumber, Card021GodDefenseNumber, Card022GodDefenseNumber, Card023GodDefenseNumber, Card024GodDefenseNumber, Card025GodDefenseNumber, Card026GodDefenseNumber, Card027GodDefenseNumber, Card028GodDefenseNumber, Card029GodDefenseNumber, Card030GodDefenseNumber, Card031GodDefenseNumber, Card032GodDefenseNumber, Card033GodDefenseNumber, Card034GodDefenseNumber, Card035GodDefenseNumber, Card036GodDefenseNumber, Card037GodDefenseNumber, Card038GodDefenseNumber, Card039GodDefenseNumber, Card040GodDefenseNumber, Card041GodDefenseNumber, Card042GodDefenseNumber, Card043GodDefenseNumber, Card044GodDefenseNumber, Card045GodDefenseNumber, Card046GodDefenseNumber, Card047GodDefenseNumber, Card048GodDefenseNumber, Card049GodDefenseNumber, Card050GodDefenseNumber, Card051GodDefenseNumber, Card052GodDefenseNumber, Card053GodDefenseNumber, Card054GodDefenseNumber, Card055GodDefenseNumber, Card056GodDefenseNumber, Card057GodDefenseNumber, Card058GodDefenseNumber, Card059GodDefenseNumber, Card060GodDefenseNumber, Card061GodDefenseNumber, Card062GodDefenseNumber, Card063GodDefenseNumber, Card064GodDefenseNumber, Card065GodDefenseNumber, Card066GodDefenseNumber, Card067GodDefenseNumber, Card068GodDefenseNumber, Card069GodDefenseNumber, Card070GodDefenseNumber, Card071GodDefenseNumber, Card072GodDefenseNumber, Card073GodDefenseNumber, Card074GodDefenseNumber, Card075GodDefenseNumber, Card076GodDefenseNumber, Card077GodDefenseNumber, Card078GodDefenseNumber, Card079GodDefenseNumber, Card080GodDefenseNumber, Card081GodDefenseNumber, Card082GodDefenseNumber, Card083GodDefenseNumber, Card084GodDefenseNumber, Card085GodDefenseNumber, Card086GodDefenseNumber, Card087GodDefenseNumber, Card088GodDefenseNumber, Card089GodDefenseNumber, Card090GodDefenseNumber, Card091GodDefenseNumber, Card092GodDefenseNumber, Card093GodDefenseNumber, Card094GodDefenseNumber, Card095GodDefenseNumber, Card096GodDefenseNumber, Card097GodDefenseNumber, Card098GodDefenseNumber, Card099GodDefenseNumber, Card100GodDefenseNumber, Card101GodDefenseNumber, Card102GodDefenseNumber, Card103GodDefenseNumber, Card104GodDefenseNumber, Card105GodDefenseNumber, Card106GodDefenseNumber, Card107GodDefenseNumber, Card108GodDefenseNumber, Card109GodDefenseNumber, Card110GodDefenseNumber, Card111GodDefenseNumber, Card112GodDefenseNumber, Card113GodDefenseNumber, Card114GodDefenseNumber, Card115GodDefenseNumber, Card116GodDefenseNumber, Card117GodDefenseNumber, Card118GodDefenseNumber, Card119GodDefenseNumber, Card120GodDefenseNumber, Card121GodDefenseNumber, Card122GodDefenseNumber, Card123GodDefenseNumber, Card124GodDefenseNumber, Card125GodDefenseNumber, Card126GodDefenseNumber, Card127GodDefenseNumber, Card128GodDefenseNumber, Card129GodDefenseNumber, Card130GodDefenseNumber, Card131GodDefenseNumber, Card132GodDefenseNumber, Card133GodDefenseNumber, Card134GodDefenseNumber};

    public static string[] CardGodDefenseDescription = {Card001GodDefenseDescription, Card002GodDefenseDescription, Card003GodDefenseDescription, Card004GodDefenseDescription, Card005GodDefenseDescription, Card006GodDefenseDescription, Card007GodDefenseDescription, Card008GodDefenseDescription, Card009GodDefenseDescription, Card010GodDefenseDescription, Card011GodDefenseDescription, Card012GodDefenseDescription, Card013GodDefenseDescription, Card014GodDefenseDescription, Card015GodDefenseDescription, Card016GodDefenseDescription, Card017GodDefenseDescription, Card018GodDefenseDescription, Card019GodDefenseDescription, Card020GodDefenseDescription, Card021GodDefenseDescription, Card022GodDefenseDescription, Card023GodDefenseDescription, Card024GodDefenseDescription, Card025GodDefenseDescription, Card026GodDefenseDescription, Card027GodDefenseDescription, Card028GodDefenseDescription, Card029GodDefenseDescription, Card030GodDefenseDescription, Card031GodDefenseDescription, Card032GodDefenseDescription, Card033GodDefenseDescription, Card034GodDefenseDescription, Card035GodDefenseDescription, Card036GodDefenseDescription, Card037GodDefenseDescription, Card038GodDefenseDescription, Card039GodDefenseDescription, Card040GodDefenseDescription, Card041GodDefenseDescription, Card042GodDefenseDescription, Card043GodDefenseDescription, Card044GodDefenseDescription, Card045GodDefenseDescription, Card046GodDefenseDescription, Card047GodDefenseDescription, Card048GodDefenseDescription, Card049GodDefenseDescription, Card050GodDefenseDescription, Card051GodDefenseDescription, Card052GodDefenseDescription, Card053GodDefenseDescription, Card054GodDefenseDescription, Card055GodDefenseDescription, Card056GodDefenseDescription, Card057GodDefenseDescription, Card058GodDefenseDescription, Card059GodDefenseDescription, Card060GodDefenseDescription, Card061GodDefenseDescription, Card062GodDefenseDescription, Card063GodDefenseDescription, Card064GodDefenseDescription, Card065GodDefenseDescription, Card066GodDefenseDescription, Card067GodDefenseDescription, Card068GodDefenseDescription, Card069GodDefenseDescription, Card070GodDefenseDescription, Card071GodDefenseDescription, Card072GodDefenseDescription, Card073GodDefenseDescription, Card074GodDefenseDescription, Card075GodDefenseDescription, Card076GodDefenseDescription, Card077GodDefenseDescription, Card078GodDefenseDescription, Card079GodDefenseDescription, Card080GodDefenseDescription, Card081GodDefenseDescription, Card082GodDefenseDescription, Card083GodDefenseDescription, Card084GodDefenseDescription, Card085GodDefenseDescription, Card086GodDefenseDescription, Card087GodDefenseDescription, Card088GodDefenseDescription, Card089GodDefenseDescription, Card090GodDefenseDescription, Card091GodDefenseDescription, Card092GodDefenseDescription, Card093GodDefenseDescription, Card094GodDefenseDescription, Card095GodDefenseDescription, Card096GodDefenseDescription, Card097GodDefenseDescription, Card098GodDefenseDescription, Card099GodDefenseDescription, Card100GodDefenseDescription, Card101GodDefenseDescription, Card102GodDefenseDescription, Card103GodDefenseDescription, Card104GodDefenseDescription, Card105GodDefenseDescription, Card106GodDefenseDescription, Card107GodDefenseDescription, Card108GodDefenseDescription, Card109GodDefenseDescription, Card110GodDefenseDescription, Card111GodDefenseDescription, Card112GodDefenseDescription, Card113GodDefenseDescription, Card114GodDefenseDescription, Card115GodDefenseDescription, Card116GodDefenseDescription, Card117GodDefenseDescription, Card118GodDefenseDescription, Card119GodDefenseDescription, Card120GodDefenseDescription, Card121GodDefenseDescription, Card122GodDefenseDescription, Card123GodDefenseDescription, Card124GodDefenseDescription, Card125GodDefenseDescription, Card126GodDefenseDescription, Card127GodDefenseDescription, Card128GodDefenseDescription, Card129GodDefenseDescription, Card130GodDefenseDescription, Card131GodDefenseDescription, Card132GodDefenseDescription, Card133GodDefenseDescription, Card134GodDefenseDescription};

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