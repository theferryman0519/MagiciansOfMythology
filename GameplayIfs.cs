using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class GameplayIfs : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------


// -------------------- PRIVATE VARIABLES --------------------


// -------------------- STATIC VARIABLES --------------------
    // Gameplay Trackers
    public static string CurrentRealmString;

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
        CheckingCurrentRealms();
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- IF FUNCTIONS --------------------
    public void CheckingCurrentRealms() {
        if (CurrentRealmString == "Dark") {
            // Current Realm is Dark - Only Dark Gods can Attack
        }

        else if (CurrentRealmString == "Earth") {
            // Current Realm is Earth - Only Earth Gods can Attack
        }

        else if (CurrentRealmString == "Light") {
            // Current Realm is Light - Only Light Gods can Attack
        }

        else if (CurrentRealmString == "Sea") {
            // Current Realm is Sea - Only Sea Gods can Attack
        }

        else if (CurrentRealmString == "Skies") {
            // Current Realm is Skies - Only Skies Gods can Attack
        }

        else if (CurrentRealmString == "World") {
            // Current Realm is World - Only World Gods can Attack
        }

        else if (CurrentRealmString == "Epic") {
            // Current Realm is Epic - All Gods can Attack
        }
    }

    // Card001
    public void GameplayIfCard001() {
        // Realm of Darkness only allows Dark Gods the ability to attack. Any God may defend, and any Myth may be played
    }

    // Card002
    public void GameplayIfCard002() {
        // All Dark Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn
    }

    // Card003
    public void GameplayIfCard003() {
        // If Moros is in your Temple, add 50 Attack Points to Moros if they are attacking your Opponent this turn
    }

    // Card004
    public void GameplayIfCard004() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card005
    public void GameplayIfCard005() {
        // All Dark Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn
    }

    // Card006
    public void GameplayIfCard006() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card007
    public void GameplayIfCard007() {
        // If Hypnos is in your Temple, they may attack two different of your Opponent's Gods this turn
    }

    // Card008
    public void GameplayIfCard008() {
        // All Olympians in your Opponent's Temple may not attack on your Opponent's next turn
    }

    // Card009
    public void GameplayIfCard009() {
        // If Hades is in the Temple Crypt, add him back to your Temple in Defense Position
    }

    // Card010
    public void GameplayIfCard010() {
        // All Dark Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn
    }

    // Card011
    public void GameplayIfCard011() {
        // If Hades is in your Temple, add 100 Attack Points to Hades if they are attacking your Opponent this turn
    }

    // Card012
    public void GameplayIfCard012() {
        // Heal 120 Health Points to Ares
        // n/a
    }

    // Card013
    public void GameplayIfCard013() {
        // n/a
        // n/a
    }

    // Card014
    public void GameplayIfCard014() {
        // n/a
        // n/a
    }

    // Card015
    public void GameplayIfCard015() {
        // If Phobos is in your Temple, add 100 Attack Points
        // n/a
    }

    // Card016
    public void GameplayIfCard016() {
        // n/a
        // n/a
    }

    // Card017
    public void GameplayIfCard017() {
        // n/a
        // n/a
    }

    // Card018
    public void GameplayIfCard018() {
        // n/a
        // n/a
    }

    // Card019
    public void GameplayIfCard019() {
        // n/a
        // n/a
    }

    // Card020
    public void GameplayIfCard020() {
        // n/a
        // All Primordials in Opponent's Temple may not attack next turn
    }

    // Card021
    public void GameplayIfCard021() {
        // If Deimos is in your Temple, add 100 Attack Points
        // n/a
    }

    // Card022
    public void GameplayIfCard022() {
        // n/a
        // n/a
    }

    // Card023
    public void GameplayIfCard023() {
        // n/a
        // n/a
    }

    // Card024
    public void GameplayIfCard024() {
        // Realm of the Earth only allows Earth Gods the ability to attack. Any God may defend, and any Myth may be played
    }

    // Card025
    public void GameplayIfCard025() {
        // All Earth Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn
    }

    // Card026
    public void GameplayIfCard026() {
        // If Ariadne is in your Temple, add 80 Defense Points to Ariadne if they are defending from your Opponent's next turn
    }

    // Card027
    public void GameplayIfCard027() {
        // Skip your Opponent's next turn at the conclusion of your current turn
    }

    // Card028
    public void GameplayIfCard028() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card029
    public void GameplayIfCard029() {
        // All Earth Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn
    }

    // Card030
    public void GameplayIfCard030() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card031
    public void GameplayIfCard031() {
        // If Persephone and/or Demeter are in the Temple Crypt, add them back to your Temple in Defense Position
    }

    // Card032
    public void GameplayIfCard032() {
        // All Titans in your Temple add 200 Defense Points if they are defending from your Opponent's next turn
    }

    // Card033
    public void GameplayIfCard033() {
        // All Earth Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn
    }

    // Card034
    public void GameplayIfCard034() {
        // If both Persephone and Demeter are in your Temple, heal both by 100 Health Points this turn
    }

    // Card035
    public void GameplayIfCard035() {
        // n/a
        // n/a
    }

    // Card036
    public void GameplayIfCard036() {
        // n/a
        // n/a
    }

    // Card037
    public void GameplayIfCard037() {
        // n/a
        // If Persephone is in your Temple, heal 200 Health Points to Demeter
    }

    // Card038
    public void GameplayIfCard038() {
        // n/a
        // All Olympians in Opponent's Temple may not attack next turn
    }

    // Card039
    public void GameplayIfCard039() {
        // n/a
        // n/a
    }

    // Card040
    public void GameplayIfCard040() {
        // n/a
        // n/a
    }

    // Card041
    public void GameplayIfCard041() {
        // n/a
        // n/a
    }

    // Card042
    public void GameplayIfCard042() {
        // n/a
        // n/a
    }

    // Card043
    public void GameplayIfCard043() {
        // If Hades is in your Temple, add 200 Attack Points to Persephone
        // If Demeter is in your Temple, heal 200 Health Points to Persephone
    }

    // Card044
    public void GameplayIfCard044() {
        // n/a
        // n/a
    }

    // Card045
    public void GameplayIfCard045() {
        // n/a
        // n/a
    }

    // Card046
    public void GameplayIfCard046() {
        // Realm of Light only allows Light Gods the ability to attack. Any God may defend, and any Myth may be played
    }

    // Card047
    public void GameplayIfCard047() {
        // All Light Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn
    }

    // Card048
    public void GameplayIfCard048() {
        // All Light Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn
    }

    // Card049
    public void GameplayIfCard049() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card050
    public void GameplayIfCard050() {
        // If Eos is in your Temple, they may attack two different of your Opponent's Gods this turn
    }

    // Card051
    public void GameplayIfCard051() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card052
    public void GameplayIfCard052() {
        // All Deities in your Opponent's Temple may not attack on your Opponent's next turn
    }

    // Card053
    public void GameplayIfCard053() {
        // If Apollo is in the Temple Crypt, add them back to your Temple in Defense Position
    }

    // Card054
    public void GameplayIfCard054() {
        // If Psyche is in your Temple, they may both attack and defend twice this turn
    }

    // Card055
    public void GameplayIfCard055() {
        // All Light Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn
    }

    // Card056
    public void GameplayIfCard056() {
        // If Zeus is in your Temple, add 100 Attack Points to Zeus if they are attacking your Opponent this turn
    }

    // Card057
    public void GameplayIfCard057() {
        // n/a
        // n/a
    }

    // Card058
    public void GameplayIfCard058() {
        // n/a
        // If Ares is in your Temple, all Gods in your Opponent's Temple each lose 80 Health Points
    }

    // Card059
    public void GameplayIfCard059() {
        // n/a
        // n/a
    }

    // Card060
    public void GameplayIfCard060() {
        // n/a
        // n/a
    }

    // Card061
    public void GameplayIfCard061() {
        // n/a
        // n/a
    }

    // Card062
    public void GameplayIfCard062() {
        // n/a
        // All Titans in Opponent's Temple may not attack next turn
    }

    // Card063
    public void GameplayIfCard063() {
        // n/a
        // n/a
    }

    // Card064
    public void GameplayIfCard064() {
        // n/a
        // n/a
    }

    // Card065
    public void GameplayIfCard065() {
        // n/a
        // n/a
    }

    // Card066
    public void GameplayIfCard066() {
        // During your turn, Phoebe both attacks and defends using Foresight
        // During your turn, Phoebe both attacks and defends using Foresight
    }

    // Card067
    public void GameplayIfCard067() {
        // During your turn, Psyche both attacks and defends using Inner Thoughts
        // During your turn, Psyche both attacks and defends using Inner Thoughts
    }

    // Card068
    public void GameplayIfCard068() {
        // n/a
        // n/a
    }

    // Card069
    public void GameplayIfCard069() {
        // If you have less than 4 Gods in your Temple, this attack does no damage
        // n/a
    }

    // Card070
    public void GameplayIfCard070() {
        // Realm of the Sea only allows Sea Gods the ability to attack. Any God may defend, and any Myth may be played
    }

    // Card071
    public void GameplayIfCard071() {
        // All Sea Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn
    }

    // Card072
    public void GameplayIfCard072() {
        // If Triton is in your Temple, add 20 Attack Points to Triton if they are attacking your Opponent this turn
    }

    // Card073
    public void GameplayIfCard073() {
        // All Sea Gods in your Temple add 70 Defense Points if they are defending from your Opponent's next turn
    }

    // Card074
    public void GameplayIfCard074() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card075
    public void GameplayIfCard075() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card076
    public void GameplayIfCard076() {
        // If Oceanus and/or Tethys are in your Temple, add 100 Defense Points to each Oceanus and/or Tethys if they are defending from your Opponent's next turn
    }

    // Card077
    public void GameplayIfCard077() {
        // All Primordials in your Opponent's Temple may not attack on your Opponent's next turn
    }

    // Card078
    public void GameplayIfCard078() {
        // If Hades, Poseidon, and/or Zeus are in your Temple, add 80 Attack Points to each Hades, Poseidon and/or Zeus if they are attacking your Opponent this turn
    }

    // Card079
    public void GameplayIfCard079() {
        // All Sea Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn
    }

    // Card080
    public void GameplayIfCard080() {
        // If Poseidon is in your Temple, add 100 Attack Points to Poseidon if they are attacking your Opponent this turn
    }

    // Card081
    public void GameplayIfCard081() {
        // n/a
        // n/a
    }

    // Card082
    public void GameplayIfCard082() {
        // All Deities in your Opponent's Temple each lose 30 Health Points
        // n/a
    }

    // Card083
    public void GameplayIfCard083() {
        // n/a
        // n/a
    }

    // Card084
    public void GameplayIfCard084() {
        // All Gods in your Opponent's Temple each lose 30 Health Points
        // n/a
    }

    // Card085
    public void GameplayIfCard085() {
        // n/a
        // Heal 50 Health Points to Galene
    }

    // Card086
    public void GameplayIfCard086() {
        // n/a
        // n/a
    }

    // Card087
    public void GameplayIfCard087() {
        // n/a
        // n/a
    }

    // Card088
    public void GameplayIfCard088() {
        // All Titans in your Opponent's Temple each lose 30 Health Points
        // n/a
    }

    // Card089
    public void GameplayIfCard089() {
        // n/a
        // Heal 120 Health Points to Thalassa
    }

    // Card090
    public void GameplayIfCard090() {
        // n/a
        // n/a
    }

    // Card091
    public void GameplayIfCard091() {
        // Realm of the Skies only allows Sky Gods the ability to attack. Any God may defend, and any Myth may be played
    }

    // Card092
    public void GameplayIfCard092() {
        // All Sky Gods in your Temple add 30 Attack Points if they are attacking your Opponent this turn
    }

    // Card093
    public void GameplayIfCard093() {
        // If Aeolus is in your Temple, add 40 Defense Points to Aeolus if they are Defending from your Opponent's next turn
    }

    // Card094
    public void GameplayIfCard094() {
        // Select one God in your Opponent's Temple, that God may not attack on your Opponent's next turn
    }

    // Card095
    public void GameplayIfCard095() {
        // If Aphrodite is in your Temple, add 200 Defense Points to Aphrodite if they are Defending from your Opponent's next turn
    }

    // Card096
    public void GameplayIfCard096() {
        // All Primordials in your Opponent's Temple may not attack on your Opponent's next turn
    }

    // Card097
    public void GameplayIfCard097() {
        // If Uranus is in the Temple Crypt, add them back to your Temple in Defense Position
    }

    // Card098
    public void GameplayIfCard098() {
        // If Gaia is in your Temple, heal 150 Health Points to Gaia this turn
    }

    // Card099
    public void GameplayIfCard099() {
        // If Coeus and/or Crius are in your Temple, add 150 Attack Points to each Coeus and/or Crius if they are attacking your Opponent this turn
    }

    // Card100
    public void GameplayIfCard100() {
        // All Sky Gods in your Temple add 100 Defense Points if they are defending from your Opponent's next turn
    }

    // Card101
    public void GameplayIfCard101() {
        // If Hera is in your Temple, add 100 Attack Points to Hera if they are attacking your Opponent this turn
    }

    // Card102
    public void GameplayIfCard102() {
        // n/a
        // n/a
    }

    // Card103
    public void GameplayIfCard103() {
        // n/a
        // n/a
    }

    // Card104
    public void GameplayIfCard104() {
        // n/a
        // n/a
    }

    // Card105
    public void GameplayIfCard105() {
        // If Crius is in your Temple, add 130 Attack Points
        // n/a
    }

    // Card106
    public void GameplayIfCard106() {
        // If Coeus is in your Temple, add 130 Attack Points
        // n/a
    }

    // Card107
    public void GameplayIfCard107() {
        // n/a
        // n/a
    }

    // Card108
    public void GameplayIfCard108() {
        // n/a
        // Heal 30 Health Points to Ganymede
    }

    // Card109
    public void GameplayIfCard109() {
        // n/a
        // All Olympians in Opponent's Temple may not attack next turn
    }

    // Card110
    public void GameplayIfCard110() {
        // n/a
        // n/a
    }

    // Card111
    public void GameplayIfCard111() {
        // n/a
        // n/a
    }

    // Card112
    public void GameplayIfCard112() {
        // n/a
        // n/a
    }

    // Card113
    public void GameplayIfCard113() {
        // n/a
        // n/a
    }

    // Card114
    public void GameplayIfCard114() {
        // Realm of the Gods is wild and allows all Gods the ability to attack, no matter their realm. Any God may defend, and any Myth may be played
    }

    // Card115
    public void GameplayIfCard115() {
        //
    }

    // Card116
    public void GameplayIfCard116() {
        //
    }

    // Card117
    public void GameplayIfCard117() {
        //
    }

    // Card118
    public void GameplayIfCard118() {
        //
    }

    // Card119
    public void GameplayIfCard119() {
        //
    }

    // Card120
    public void GameplayIfCard120() {
        //
    }

    // Card121
    public void GameplayIfCard121() {
        //
    }

    // Card122
    public void GameplayIfCard122() {
        //
    }

    // Card123
    public void GameplayIfCard123() {
        //
    }

    // Card124
    public void GameplayIfCard124() {
        //
    }

    // Card125
    public void GameplayIfCard125() {
        //
    }

    // Card126
    public void GameplayIfCard126() {
        //
    }

    // Card127
    public void GameplayIfCard127() {
        //
    }

    // Card128
    public void GameplayIfCard128() {
        //
    }

    // Card129
    public void GameplayIfCard129() {
        //
    }

    // Card130
    public void GameplayIfCard130() {
        //
    }

    // Card131
    public void GameplayIfCard131() {
        //
    }

    // Card132
    public void GameplayIfCard132() {
        //
    }

    // Card133
    public void GameplayIfCard133() {
        //
    }

    // Card134
    public void GameplayIfCard134() {
        //
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}