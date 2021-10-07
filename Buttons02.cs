using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class Buttons02 : MonoBehaviour {

// ------------------------------ START: LIST OF VARIABLES ------------------------------
// -------------------- PUBLIC VARIABLES --------------------
    public Button LogInButtonOn;
    public Button LogInButtonOff;
    public Button SignUpButtonOn;
    public Button SignUpButtonOff;
    public Button LogInButton;
    public Button SignUpNextButton;
    public Button SignUpButton;
    public Button SignUpRealmDarkButton;
    public Button SignUpRealmEarthButton;
    public Button SignUpRealmLightButton;
    public Button SignUpRealmSeaButton;
    public Button SignUpRealmSkiesButton;
    public Button ErrorButtonLogIn;
    public Button ErrorButtonSignUp;

    public Text LogInUsernameInput;
    public Text SignUpUsernameInput;
    public Text SignUpFirstNameInput;
    public Text SignUpFavGodInput;

    public Image SignUpRealmDarkImage;
    public Image SignUpRealmEarthImage;
    public Image SignUpRealmLightImage;
    public Image SignUpRealmSeaImage;
    public Image SignUpRealmSkiesImage;

// -------------------- PRIVATE VARIABLES --------------------
    string SelectingRealm;
    Color SelectingRealmChosen = new Color(0.0f, .8051777f, 1.0f);
    Color SelectingRealmOriginal = new Color(1.0f, 1.0f, 1.0f);

// -------------------- STATIC VARIABLES --------------------
    

// ------------------------------ END: LIST OF VARIABLES ------------------------------
// ------------------------------ START: CALLING OTHER SCRIPTS ------------------------------
    // Scene Change
    public SceneChange Scene05LoadRun;
    public SceneChange Scene03LoadRun;

// ------------------------------ END: CALLING OTHER SCRIPTS ------------------------------
// ------------------------------ START: CALLING INITIAL FUNCTIONS ------------------------------
// -------------------- START FUNCTION --------------------
    void Start() {
        SelectingRealm = "None";
        SelectingRealmReset();

        // LogInButtonOn
        Button LogInButtonOnClick = LogInButtonOn.GetComponent<Button>();
        LogInButtonOnClick.onClick.AddListener(LogInButtonOnClicking);

        // LogInButtonOff
        Button LogInButtonOffClick = LogInButtonOff.GetComponent<Button>();
        LogInButtonOffClick.onClick.AddListener(LogInButtonOffClicking);

        // SignUpButtonOn
        Button SignUpButtonOnClick = SignUpButtonOn.GetComponent<Button>();
        SignUpButtonOnClick.onClick.AddListener(SignUpButtonOnClicking);

        // SignUpButtonOff
        Button SignUpButtonOffClick = SignUpButtonOff.GetComponent<Button>();
        SignUpButtonOffClick.onClick.AddListener(SignUpButtonOffClicking);

        // LogInButton
        Button LogInButtonClick = LogInButton.GetComponent<Button>();
        LogInButtonClick.onClick.AddListener(LogInButtonClicking);

        // SignUpNextButton
        Button SignUpNextButtonClick = SignUpNextButton.GetComponent<Button>();
        SignUpNextButtonClick.onClick.AddListener(SignUpNextButtonClicking);

        // SignUpButton
        Button SignUpButtonClick = SignUpButton.GetComponent<Button>();
        SignUpButtonClick.onClick.AddListener(SignUpButtonClicking);

        // SignUpRealmDarkButton
        Button SignUpRealmDarkButtonClick = SignUpRealmDarkButton.GetComponent<Button>();
        SignUpRealmDarkButtonClick.onClick.AddListener(SignUpRealmDarkButtonClicking);

        // SignUpRealmEarthButton
        Button SignUpRealmEarthButtonClick = SignUpRealmEarthButton.GetComponent<Button>();
        SignUpRealmEarthButtonClick.onClick.AddListener(SignUpRealmEarthButtonClicking);

        // SignUpRealmLightButton
        Button SignUpRealmLightButtonClick = SignUpRealmLightButton.GetComponent<Button>();
        SignUpRealmLightButtonClick.onClick.AddListener(SignUpRealmLightButtonClicking);

        // SignUpRealmSeaButton
        Button SignUpRealmSeaButtonClick = SignUpRealmSeaButton.GetComponent<Button>();
        SignUpRealmSeaButtonClick.onClick.AddListener(SignUpRealmSeaButtonClicking);

        // SignUpRealmSkiesButton
        Button SignUpRealmSkiesButtonClick = SignUpRealmSkiesButton.GetComponent<Button>();
        SignUpRealmSkiesButtonClick.onClick.AddListener(SignUpRealmSkiesButtonClicking);

        // ErrorButtonLogIn
        Button ErrorButtonLogInClick = ErrorButtonLogIn.GetComponent<Button>();
        ErrorButtonLogInClick.onClick.AddListener(ErrorButtonLogInClicking);

        // ErrorButtonSignUp
        Button ErrorButtonSignUpClick = ErrorButtonSignUp.GetComponent<Button>();
        ErrorButtonSignUpClick.onClick.AddListener(ErrorButtonSignUpClicking);
    }

// -------------------- AWAKE FUNCTION --------------------
    void Awake() {
        
    }

// -------------------- UPDATE FUNCTION --------------------
    void Update() {
        
    }

// ------------------------------ END: CALLING INITIAL FUNCTIONS ------------------------------
// ------------------------------ START: OTHER FUNCTIONS ------------------------------
// -------------------- BUTTON FUNCTIONS --------------------
    public void LogInButtonOnClicking() {
        EnableObjects02.LogInSignUpInt = 0;
    }

    public void LogInButtonOffClicking() {
        EnableObjects02.LogInSignUpInt = 0;
        LogInUsernameInput.text = "";
        SignUpFirstNameInput.text = "";
        SignUpUsernameInput.text = "";
        SignUpFavGodInput.text = "";
        SelectingRealmReset();
    }

    public void SignUpButtonOnClicking() {
        if (EnableObjects02.LogInSignUpInt == 1) {
            EnableObjects02.LogInSignUpInt = 1;
        }

        else if (EnableObjects02.LogInSignUpInt == 2) {
            EnableObjects02.LogInSignUpInt = 2;
        }
    }

    public void SignUpButtonOffClicking() {
        EnableObjects02.LogInSignUpInt = 1;
        LogInUsernameInput.text = "";
        SignUpFirstNameInput.text = "";
        SignUpUsernameInput.text = "";
        SignUpFavGodInput.text = "";
        SelectingRealmReset();
    }

    public void LogInButtonClicking() {
        PlayerDatabase.PlayerLogInName = LogInUsernameInput.text;
        StartCoroutine(CheckLogInName());
    }

    public void SignUpNextButtonClicking() {
        EnableObjects02.LogInSignUpInt = 2;
    }

    public void ErrorButtonLogInClicking() {
        EnableObjects02.LogInSignUpInt = 0;
    }

    public void ErrorButtonSignUpClicking() {
        EnableObjects02.LogInSignUpInt = 1;
    }

    public void SignUpButtonClicking() {
        // Player Information
        PlayerDatabase.PlayerName = SignUpFirstNameInput.text;
        PlayerDatabase.PlayerLogInName = SignUpUsernameInput.text;
        PlayerDatabase.PlayerFavGod = SignUpFavGodInput.text;
        PlayerDatabase.PlayerRealm = SelectingRealm;
        PlayerDatabase.PlayerStoryLevel = "1";
        PlayerDatabase.PlayerWins = "0";
        PlayerDatabase.PlayerLosses = "0";
        PlayerDatabase.PlayerStalemates = "0";

        // Card Information
        if (SelectingRealm == "Dark") {
            PlayerDatabase.PlayerCardAmount001 = "3";
            PlayerDatabase.PlayerCardAmount002 = "1";
            PlayerDatabase.PlayerCardAmount003 = "1";
            PlayerDatabase.PlayerCardAmount004 = "1";
            PlayerDatabase.PlayerCardAmount005 = "0";
            PlayerDatabase.PlayerCardAmount006 = "0";
            PlayerDatabase.PlayerCardAmount007 = "0";
            PlayerDatabase.PlayerCardAmount008 = "0";
            PlayerDatabase.PlayerCardAmount009 = "0";
            PlayerDatabase.PlayerCardAmount010 = "0";
            PlayerDatabase.PlayerCardAmount011 = "0";
            PlayerDatabase.PlayerCardAmount012 = "0";
            PlayerDatabase.PlayerCardAmount013 = "0";
            PlayerDatabase.PlayerCardAmount014 = "0";
            PlayerDatabase.PlayerCardAmount015 = "0";
            PlayerDatabase.PlayerCardAmount016 = "0";
            PlayerDatabase.PlayerCardAmount017 = "0";
            PlayerDatabase.PlayerCardAmount018 = "1";
            PlayerDatabase.PlayerCardAmount019 = "1";
            PlayerDatabase.PlayerCardAmount020 = "0";
            PlayerDatabase.PlayerCardAmount021 = "0";
            PlayerDatabase.PlayerCardAmount022 = "1";
            PlayerDatabase.PlayerCardAmount023 = "1";
            PlayerDatabase.PlayerCardAmount024 = "0";
            PlayerDatabase.PlayerCardAmount025 = "0";
            PlayerDatabase.PlayerCardAmount026 = "0";
            PlayerDatabase.PlayerCardAmount027 = "0";
            PlayerDatabase.PlayerCardAmount028 = "0";
            PlayerDatabase.PlayerCardAmount029 = "0";
            PlayerDatabase.PlayerCardAmount030 = "0";
            PlayerDatabase.PlayerCardAmount031 = "0";
            PlayerDatabase.PlayerCardAmount032 = "0";
            PlayerDatabase.PlayerCardAmount033 = "0";
            PlayerDatabase.PlayerCardAmount034 = "0";
            PlayerDatabase.PlayerCardAmount035 = "0";
            PlayerDatabase.PlayerCardAmount036 = "0";
            PlayerDatabase.PlayerCardAmount037 = "0";
            PlayerDatabase.PlayerCardAmount038 = "0";
            PlayerDatabase.PlayerCardAmount039 = "0";
            PlayerDatabase.PlayerCardAmount040 = "0";
            PlayerDatabase.PlayerCardAmount041 = "0";
            PlayerDatabase.PlayerCardAmount042 = "0";
            PlayerDatabase.PlayerCardAmount043 = "0";
            PlayerDatabase.PlayerCardAmount044 = "0";
            PlayerDatabase.PlayerCardAmount045 = "0";
            PlayerDatabase.PlayerCardAmount046 = "0";
            PlayerDatabase.PlayerCardAmount047 = "0";
            PlayerDatabase.PlayerCardAmount048 = "0";
            PlayerDatabase.PlayerCardAmount049 = "0";
            PlayerDatabase.PlayerCardAmount050 = "0";
            PlayerDatabase.PlayerCardAmount051 = "0";
            PlayerDatabase.PlayerCardAmount052 = "0";
            PlayerDatabase.PlayerCardAmount053 = "0";
            PlayerDatabase.PlayerCardAmount054 = "0";
            PlayerDatabase.PlayerCardAmount055 = "0";
            PlayerDatabase.PlayerCardAmount056 = "0";
            PlayerDatabase.PlayerCardAmount057 = "0";
            PlayerDatabase.PlayerCardAmount058 = "0";
            PlayerDatabase.PlayerCardAmount059 = "0";
            PlayerDatabase.PlayerCardAmount060 = "0";
            PlayerDatabase.PlayerCardAmount061 = "0";
            PlayerDatabase.PlayerCardAmount062 = "0";
            PlayerDatabase.PlayerCardAmount063 = "0";
            PlayerDatabase.PlayerCardAmount064 = "0";
            PlayerDatabase.PlayerCardAmount065 = "0";
            PlayerDatabase.PlayerCardAmount066 = "0";
            PlayerDatabase.PlayerCardAmount067 = "0";
            PlayerDatabase.PlayerCardAmount068 = "0";
            PlayerDatabase.PlayerCardAmount069 = "0";
            PlayerDatabase.PlayerCardAmount070 = "0";
            PlayerDatabase.PlayerCardAmount071 = "0";
            PlayerDatabase.PlayerCardAmount072 = "0";
            PlayerDatabase.PlayerCardAmount073 = "0";
            PlayerDatabase.PlayerCardAmount074 = "0";
            PlayerDatabase.PlayerCardAmount075 = "0";
            PlayerDatabase.PlayerCardAmount076 = "0";
            PlayerDatabase.PlayerCardAmount077 = "0";
            PlayerDatabase.PlayerCardAmount078 = "0";
            PlayerDatabase.PlayerCardAmount079 = "0";
            PlayerDatabase.PlayerCardAmount080 = "0";
            PlayerDatabase.PlayerCardAmount081 = "0";
            PlayerDatabase.PlayerCardAmount082 = "0";
            PlayerDatabase.PlayerCardAmount083 = "0";
            PlayerDatabase.PlayerCardAmount084 = "0";
            PlayerDatabase.PlayerCardAmount085 = "0";
            PlayerDatabase.PlayerCardAmount086 = "0";
            PlayerDatabase.PlayerCardAmount087 = "0";
            PlayerDatabase.PlayerCardAmount088 = "0";
            PlayerDatabase.PlayerCardAmount089 = "0";
            PlayerDatabase.PlayerCardAmount090 = "0";
            PlayerDatabase.PlayerCardAmount091 = "0";
            PlayerDatabase.PlayerCardAmount092 = "0";
            PlayerDatabase.PlayerCardAmount093 = "0";
            PlayerDatabase.PlayerCardAmount094 = "0";
            PlayerDatabase.PlayerCardAmount095 = "0";
            PlayerDatabase.PlayerCardAmount096 = "0";
            PlayerDatabase.PlayerCardAmount097 = "0";
            PlayerDatabase.PlayerCardAmount098 = "0";
            PlayerDatabase.PlayerCardAmount099 = "0";
            PlayerDatabase.PlayerCardAmount100 = "0";
            PlayerDatabase.PlayerCardAmount101 = "0";
            PlayerDatabase.PlayerCardAmount102 = "0";
            PlayerDatabase.PlayerCardAmount103 = "0";
            PlayerDatabase.PlayerCardAmount104 = "0";
            PlayerDatabase.PlayerCardAmount105 = "0";
            PlayerDatabase.PlayerCardAmount106 = "0";
            PlayerDatabase.PlayerCardAmount107 = "0";
            PlayerDatabase.PlayerCardAmount108 = "0";
            PlayerDatabase.PlayerCardAmount109 = "0";
            PlayerDatabase.PlayerCardAmount110 = "0";
            PlayerDatabase.PlayerCardAmount111 = "0";
            PlayerDatabase.PlayerCardAmount112 = "0";
            PlayerDatabase.PlayerCardAmount113 = "0";
            PlayerDatabase.PlayerCardAmount114 = "0";
            PlayerDatabase.PlayerCardAmount115 = "0";
            PlayerDatabase.PlayerCardAmount116 = "0";
            PlayerDatabase.PlayerCardAmount117 = "0";
            PlayerDatabase.PlayerCardAmount118 = "0";
            PlayerDatabase.PlayerCardAmount119 = "0";
            PlayerDatabase.PlayerCardAmount120 = "0";
            PlayerDatabase.PlayerCardAmount121 = "0";
            PlayerDatabase.PlayerCardAmount122 = "0";
            PlayerDatabase.PlayerCardAmount123 = "0";
            PlayerDatabase.PlayerCardAmount124 = "0";
            PlayerDatabase.PlayerCardAmount125 = "0";
            PlayerDatabase.PlayerCardAmount126 = "0";
            PlayerDatabase.PlayerCardAmount127 = "0";
            PlayerDatabase.PlayerCardAmount128 = "0";
            PlayerDatabase.PlayerCardAmount129 = "0";
            PlayerDatabase.PlayerCardAmount130 = "0";
            PlayerDatabase.PlayerCardAmount131 = "0";
            PlayerDatabase.PlayerCardAmount132 = "0";
            PlayerDatabase.PlayerCardAmount133 = "0";
            PlayerDatabase.PlayerCardAmount134 = "0";
        }

        else if (SelectingRealm == "Earth") {
            PlayerDatabase.PlayerCardAmount001 = "0";
            PlayerDatabase.PlayerCardAmount002 = "0";
            PlayerDatabase.PlayerCardAmount003 = "0";
            PlayerDatabase.PlayerCardAmount004 = "0";
            PlayerDatabase.PlayerCardAmount005 = "0";
            PlayerDatabase.PlayerCardAmount006 = "0";
            PlayerDatabase.PlayerCardAmount007 = "0";
            PlayerDatabase.PlayerCardAmount008 = "0";
            PlayerDatabase.PlayerCardAmount009 = "0";
            PlayerDatabase.PlayerCardAmount010 = "0";
            PlayerDatabase.PlayerCardAmount011 = "0";
            PlayerDatabase.PlayerCardAmount012 = "0";
            PlayerDatabase.PlayerCardAmount013 = "0";
            PlayerDatabase.PlayerCardAmount014 = "0";
            PlayerDatabase.PlayerCardAmount015 = "0";
            PlayerDatabase.PlayerCardAmount016 = "0";
            PlayerDatabase.PlayerCardAmount017 = "0";
            PlayerDatabase.PlayerCardAmount018 = "0";
            PlayerDatabase.PlayerCardAmount019 = "0";
            PlayerDatabase.PlayerCardAmount020 = "0";
            PlayerDatabase.PlayerCardAmount021 = "0";
            PlayerDatabase.PlayerCardAmount022 = "0";
            PlayerDatabase.PlayerCardAmount023 = "0";
            PlayerDatabase.PlayerCardAmount024 = "3";
            PlayerDatabase.PlayerCardAmount025 = "1";
            PlayerDatabase.PlayerCardAmount026 = "1";
            PlayerDatabase.PlayerCardAmount027 = "1";
            PlayerDatabase.PlayerCardAmount028 = "0";
            PlayerDatabase.PlayerCardAmount029 = "0";
            PlayerDatabase.PlayerCardAmount030 = "0";
            PlayerDatabase.PlayerCardAmount031 = "0";
            PlayerDatabase.PlayerCardAmount032 = "0";
            PlayerDatabase.PlayerCardAmount033 = "0";
            PlayerDatabase.PlayerCardAmount034 = "0";
            PlayerDatabase.PlayerCardAmount035 = "1";
            PlayerDatabase.PlayerCardAmount036 = "0";
            PlayerDatabase.PlayerCardAmount037 = "0";
            PlayerDatabase.PlayerCardAmount038 = "0";
            PlayerDatabase.PlayerCardAmount039 = "1";
            PlayerDatabase.PlayerCardAmount040 = "0";
            PlayerDatabase.PlayerCardAmount041 = "0";
            PlayerDatabase.PlayerCardAmount042 = "1";
            PlayerDatabase.PlayerCardAmount043 = "0";
            PlayerDatabase.PlayerCardAmount044 = "0";
            PlayerDatabase.PlayerCardAmount045 = "1";
            PlayerDatabase.PlayerCardAmount046 = "0";
            PlayerDatabase.PlayerCardAmount047 = "0";
            PlayerDatabase.PlayerCardAmount048 = "0";
            PlayerDatabase.PlayerCardAmount049 = "0";
            PlayerDatabase.PlayerCardAmount050 = "0";
            PlayerDatabase.PlayerCardAmount051 = "0";
            PlayerDatabase.PlayerCardAmount052 = "0";
            PlayerDatabase.PlayerCardAmount053 = "0";
            PlayerDatabase.PlayerCardAmount054 = "0";
            PlayerDatabase.PlayerCardAmount055 = "0";
            PlayerDatabase.PlayerCardAmount056 = "0";
            PlayerDatabase.PlayerCardAmount057 = "0";
            PlayerDatabase.PlayerCardAmount058 = "0";
            PlayerDatabase.PlayerCardAmount059 = "0";
            PlayerDatabase.PlayerCardAmount060 = "0";
            PlayerDatabase.PlayerCardAmount061 = "0";
            PlayerDatabase.PlayerCardAmount062 = "0";
            PlayerDatabase.PlayerCardAmount063 = "0";
            PlayerDatabase.PlayerCardAmount064 = "0";
            PlayerDatabase.PlayerCardAmount065 = "0";
            PlayerDatabase.PlayerCardAmount066 = "0";
            PlayerDatabase.PlayerCardAmount067 = "0";
            PlayerDatabase.PlayerCardAmount068 = "0";
            PlayerDatabase.PlayerCardAmount069 = "0";
            PlayerDatabase.PlayerCardAmount070 = "0";
            PlayerDatabase.PlayerCardAmount071 = "0";
            PlayerDatabase.PlayerCardAmount072 = "0";
            PlayerDatabase.PlayerCardAmount073 = "0";
            PlayerDatabase.PlayerCardAmount074 = "0";
            PlayerDatabase.PlayerCardAmount075 = "0";
            PlayerDatabase.PlayerCardAmount076 = "0";
            PlayerDatabase.PlayerCardAmount077 = "0";
            PlayerDatabase.PlayerCardAmount078 = "0";
            PlayerDatabase.PlayerCardAmount079 = "0";
            PlayerDatabase.PlayerCardAmount080 = "0";
            PlayerDatabase.PlayerCardAmount081 = "0";
            PlayerDatabase.PlayerCardAmount082 = "0";
            PlayerDatabase.PlayerCardAmount083 = "0";
            PlayerDatabase.PlayerCardAmount084 = "0";
            PlayerDatabase.PlayerCardAmount085 = "0";
            PlayerDatabase.PlayerCardAmount086 = "0";
            PlayerDatabase.PlayerCardAmount087 = "0";
            PlayerDatabase.PlayerCardAmount088 = "0";
            PlayerDatabase.PlayerCardAmount089 = "0";
            PlayerDatabase.PlayerCardAmount090 = "0";
            PlayerDatabase.PlayerCardAmount091 = "0";
            PlayerDatabase.PlayerCardAmount092 = "0";
            PlayerDatabase.PlayerCardAmount093 = "0";
            PlayerDatabase.PlayerCardAmount094 = "0";
            PlayerDatabase.PlayerCardAmount095 = "0";
            PlayerDatabase.PlayerCardAmount096 = "0";
            PlayerDatabase.PlayerCardAmount097 = "0";
            PlayerDatabase.PlayerCardAmount098 = "0";
            PlayerDatabase.PlayerCardAmount099 = "0";
            PlayerDatabase.PlayerCardAmount100 = "0";
            PlayerDatabase.PlayerCardAmount101 = "0";
            PlayerDatabase.PlayerCardAmount102 = "0";
            PlayerDatabase.PlayerCardAmount103 = "0";
            PlayerDatabase.PlayerCardAmount104 = "0";
            PlayerDatabase.PlayerCardAmount105 = "0";
            PlayerDatabase.PlayerCardAmount106 = "0";
            PlayerDatabase.PlayerCardAmount107 = "0";
            PlayerDatabase.PlayerCardAmount108 = "0";
            PlayerDatabase.PlayerCardAmount109 = "0";
            PlayerDatabase.PlayerCardAmount110 = "0";
            PlayerDatabase.PlayerCardAmount111 = "0";
            PlayerDatabase.PlayerCardAmount112 = "0";
            PlayerDatabase.PlayerCardAmount113 = "0";
            PlayerDatabase.PlayerCardAmount114 = "0";
            PlayerDatabase.PlayerCardAmount115 = "0";
            PlayerDatabase.PlayerCardAmount116 = "0";
            PlayerDatabase.PlayerCardAmount117 = "0";
            PlayerDatabase.PlayerCardAmount118 = "0";
            PlayerDatabase.PlayerCardAmount119 = "0";
            PlayerDatabase.PlayerCardAmount120 = "0";
            PlayerDatabase.PlayerCardAmount121 = "0";
            PlayerDatabase.PlayerCardAmount122 = "0";
            PlayerDatabase.PlayerCardAmount123 = "0";
            PlayerDatabase.PlayerCardAmount124 = "0";
            PlayerDatabase.PlayerCardAmount125 = "0";
            PlayerDatabase.PlayerCardAmount126 = "0";
            PlayerDatabase.PlayerCardAmount127 = "0";
            PlayerDatabase.PlayerCardAmount128 = "0";
            PlayerDatabase.PlayerCardAmount129 = "0";
            PlayerDatabase.PlayerCardAmount130 = "0";
            PlayerDatabase.PlayerCardAmount131 = "0";
            PlayerDatabase.PlayerCardAmount132 = "0";
            PlayerDatabase.PlayerCardAmount133 = "0";
            PlayerDatabase.PlayerCardAmount134 = "0";
        }

        else if (SelectingRealm == "Light") {
            PlayerDatabase.PlayerCardAmount001 = "0";
            PlayerDatabase.PlayerCardAmount002 = "0";
            PlayerDatabase.PlayerCardAmount003 = "0";
            PlayerDatabase.PlayerCardAmount004 = "0";
            PlayerDatabase.PlayerCardAmount005 = "0";
            PlayerDatabase.PlayerCardAmount006 = "0";
            PlayerDatabase.PlayerCardAmount007 = "0";
            PlayerDatabase.PlayerCardAmount008 = "0";
            PlayerDatabase.PlayerCardAmount009 = "0";
            PlayerDatabase.PlayerCardAmount010 = "0";
            PlayerDatabase.PlayerCardAmount011 = "0";
            PlayerDatabase.PlayerCardAmount012 = "0";
            PlayerDatabase.PlayerCardAmount013 = "0";
            PlayerDatabase.PlayerCardAmount014 = "0";
            PlayerDatabase.PlayerCardAmount015 = "0";
            PlayerDatabase.PlayerCardAmount016 = "0";
            PlayerDatabase.PlayerCardAmount017 = "0";
            PlayerDatabase.PlayerCardAmount018 = "0";
            PlayerDatabase.PlayerCardAmount019 = "0";
            PlayerDatabase.PlayerCardAmount020 = "0";
            PlayerDatabase.PlayerCardAmount021 = "0";
            PlayerDatabase.PlayerCardAmount022 = "0";
            PlayerDatabase.PlayerCardAmount023 = "0";
            PlayerDatabase.PlayerCardAmount024 = "0";
            PlayerDatabase.PlayerCardAmount025 = "0";
            PlayerDatabase.PlayerCardAmount026 = "0";
            PlayerDatabase.PlayerCardAmount027 = "0";
            PlayerDatabase.PlayerCardAmount028 = "0";
            PlayerDatabase.PlayerCardAmount029 = "0";
            PlayerDatabase.PlayerCardAmount030 = "0";
            PlayerDatabase.PlayerCardAmount031 = "0";
            PlayerDatabase.PlayerCardAmount032 = "0";
            PlayerDatabase.PlayerCardAmount033 = "0";
            PlayerDatabase.PlayerCardAmount034 = "0";
            PlayerDatabase.PlayerCardAmount035 = "0";
            PlayerDatabase.PlayerCardAmount036 = "0";
            PlayerDatabase.PlayerCardAmount037 = "0";
            PlayerDatabase.PlayerCardAmount038 = "0";
            PlayerDatabase.PlayerCardAmount039 = "0";
            PlayerDatabase.PlayerCardAmount040 = "0";
            PlayerDatabase.PlayerCardAmount041 = "0";
            PlayerDatabase.PlayerCardAmount042 = "0";
            PlayerDatabase.PlayerCardAmount043 = "0";
            PlayerDatabase.PlayerCardAmount044 = "0";
            PlayerDatabase.PlayerCardAmount045 = "0";
            PlayerDatabase.PlayerCardAmount046 = "3";
            PlayerDatabase.PlayerCardAmount047 = "1";
            PlayerDatabase.PlayerCardAmount048 = "1";
            PlayerDatabase.PlayerCardAmount049 = "1";
            PlayerDatabase.PlayerCardAmount050 = "0";
            PlayerDatabase.PlayerCardAmount051 = "0";
            PlayerDatabase.PlayerCardAmount052 = "0";
            PlayerDatabase.PlayerCardAmount053 = "0";
            PlayerDatabase.PlayerCardAmount054 = "0";
            PlayerDatabase.PlayerCardAmount055 = "0";
            PlayerDatabase.PlayerCardAmount056 = "0";
            PlayerDatabase.PlayerCardAmount057 = "0";
            PlayerDatabase.PlayerCardAmount058 = "0";
            PlayerDatabase.PlayerCardAmount059 = "1";
            PlayerDatabase.PlayerCardAmount060 = "0";
            PlayerDatabase.PlayerCardAmount061 = "0";
            PlayerDatabase.PlayerCardAmount062 = "1";
            PlayerDatabase.PlayerCardAmount063 = "0";
            PlayerDatabase.PlayerCardAmount064 = "0";
            PlayerDatabase.PlayerCardAmount065 = "0";
            PlayerDatabase.PlayerCardAmount066 = "1";
            PlayerDatabase.PlayerCardAmount067 = "0";
            PlayerDatabase.PlayerCardAmount068 = "1";
            PlayerDatabase.PlayerCardAmount069 = "0";
            PlayerDatabase.PlayerCardAmount070 = "0";
            PlayerDatabase.PlayerCardAmount071 = "0";
            PlayerDatabase.PlayerCardAmount072 = "0";
            PlayerDatabase.PlayerCardAmount073 = "0";
            PlayerDatabase.PlayerCardAmount074 = "0";
            PlayerDatabase.PlayerCardAmount075 = "0";
            PlayerDatabase.PlayerCardAmount076 = "0";
            PlayerDatabase.PlayerCardAmount077 = "0";
            PlayerDatabase.PlayerCardAmount078 = "0";
            PlayerDatabase.PlayerCardAmount079 = "0";
            PlayerDatabase.PlayerCardAmount080 = "0";
            PlayerDatabase.PlayerCardAmount081 = "0";
            PlayerDatabase.PlayerCardAmount082 = "0";
            PlayerDatabase.PlayerCardAmount083 = "0";
            PlayerDatabase.PlayerCardAmount084 = "0";
            PlayerDatabase.PlayerCardAmount085 = "0";
            PlayerDatabase.PlayerCardAmount086 = "0";
            PlayerDatabase.PlayerCardAmount087 = "0";
            PlayerDatabase.PlayerCardAmount088 = "0";
            PlayerDatabase.PlayerCardAmount089 = "0";
            PlayerDatabase.PlayerCardAmount090 = "0";
            PlayerDatabase.PlayerCardAmount091 = "0";
            PlayerDatabase.PlayerCardAmount092 = "0";
            PlayerDatabase.PlayerCardAmount093 = "0";
            PlayerDatabase.PlayerCardAmount094 = "0";
            PlayerDatabase.PlayerCardAmount095 = "0";
            PlayerDatabase.PlayerCardAmount096 = "0";
            PlayerDatabase.PlayerCardAmount097 = "0";
            PlayerDatabase.PlayerCardAmount098 = "0";
            PlayerDatabase.PlayerCardAmount099 = "0";
            PlayerDatabase.PlayerCardAmount100 = "0";
            PlayerDatabase.PlayerCardAmount101 = "0";
            PlayerDatabase.PlayerCardAmount102 = "0";
            PlayerDatabase.PlayerCardAmount103 = "0";
            PlayerDatabase.PlayerCardAmount104 = "0";
            PlayerDatabase.PlayerCardAmount105 = "0";
            PlayerDatabase.PlayerCardAmount106 = "0";
            PlayerDatabase.PlayerCardAmount107 = "0";
            PlayerDatabase.PlayerCardAmount108 = "0";
            PlayerDatabase.PlayerCardAmount109 = "0";
            PlayerDatabase.PlayerCardAmount110 = "0";
            PlayerDatabase.PlayerCardAmount111 = "0";
            PlayerDatabase.PlayerCardAmount112 = "0";
            PlayerDatabase.PlayerCardAmount113 = "0";
            PlayerDatabase.PlayerCardAmount114 = "0";
            PlayerDatabase.PlayerCardAmount115 = "0";
            PlayerDatabase.PlayerCardAmount116 = "0";
            PlayerDatabase.PlayerCardAmount117 = "0";
            PlayerDatabase.PlayerCardAmount118 = "0";
            PlayerDatabase.PlayerCardAmount119 = "0";
            PlayerDatabase.PlayerCardAmount120 = "0";
            PlayerDatabase.PlayerCardAmount121 = "0";
            PlayerDatabase.PlayerCardAmount122 = "0";
            PlayerDatabase.PlayerCardAmount123 = "0";
            PlayerDatabase.PlayerCardAmount124 = "0";
            PlayerDatabase.PlayerCardAmount125 = "0";
            PlayerDatabase.PlayerCardAmount126 = "0";
            PlayerDatabase.PlayerCardAmount127 = "0";
            PlayerDatabase.PlayerCardAmount128 = "0";
            PlayerDatabase.PlayerCardAmount129 = "0";
            PlayerDatabase.PlayerCardAmount130 = "0";
            PlayerDatabase.PlayerCardAmount131 = "0";
            PlayerDatabase.PlayerCardAmount132 = "0";
            PlayerDatabase.PlayerCardAmount133 = "0";
            PlayerDatabase.PlayerCardAmount134 = "0";
        }

        else if (SelectingRealm == "Sea") {
            PlayerDatabase.PlayerCardAmount001 = "0";
            PlayerDatabase.PlayerCardAmount002 = "0";
            PlayerDatabase.PlayerCardAmount003 = "0";
            PlayerDatabase.PlayerCardAmount004 = "0";
            PlayerDatabase.PlayerCardAmount005 = "0";
            PlayerDatabase.PlayerCardAmount006 = "0";
            PlayerDatabase.PlayerCardAmount007 = "0";
            PlayerDatabase.PlayerCardAmount008 = "0";
            PlayerDatabase.PlayerCardAmount009 = "0";
            PlayerDatabase.PlayerCardAmount010 = "0";
            PlayerDatabase.PlayerCardAmount011 = "0";
            PlayerDatabase.PlayerCardAmount012 = "0";
            PlayerDatabase.PlayerCardAmount013 = "0";
            PlayerDatabase.PlayerCardAmount014 = "0";
            PlayerDatabase.PlayerCardAmount015 = "0";
            PlayerDatabase.PlayerCardAmount016 = "0";
            PlayerDatabase.PlayerCardAmount017 = "0";
            PlayerDatabase.PlayerCardAmount018 = "0";
            PlayerDatabase.PlayerCardAmount019 = "0";
            PlayerDatabase.PlayerCardAmount020 = "0";
            PlayerDatabase.PlayerCardAmount021 = "0";
            PlayerDatabase.PlayerCardAmount022 = "0";
            PlayerDatabase.PlayerCardAmount023 = "0";
            PlayerDatabase.PlayerCardAmount024 = "0";
            PlayerDatabase.PlayerCardAmount025 = "0";
            PlayerDatabase.PlayerCardAmount026 = "0";
            PlayerDatabase.PlayerCardAmount027 = "0";
            PlayerDatabase.PlayerCardAmount028 = "0";
            PlayerDatabase.PlayerCardAmount029 = "0";
            PlayerDatabase.PlayerCardAmount030 = "0";
            PlayerDatabase.PlayerCardAmount031 = "0";
            PlayerDatabase.PlayerCardAmount032 = "0";
            PlayerDatabase.PlayerCardAmount033 = "0";
            PlayerDatabase.PlayerCardAmount034 = "0";
            PlayerDatabase.PlayerCardAmount035 = "0";
            PlayerDatabase.PlayerCardAmount036 = "0";
            PlayerDatabase.PlayerCardAmount037 = "0";
            PlayerDatabase.PlayerCardAmount038 = "0";
            PlayerDatabase.PlayerCardAmount039 = "0";
            PlayerDatabase.PlayerCardAmount040 = "0";
            PlayerDatabase.PlayerCardAmount041 = "0";
            PlayerDatabase.PlayerCardAmount042 = "0";
            PlayerDatabase.PlayerCardAmount043 = "0";
            PlayerDatabase.PlayerCardAmount044 = "0";
            PlayerDatabase.PlayerCardAmount045 = "0";
            PlayerDatabase.PlayerCardAmount046 = "0";
            PlayerDatabase.PlayerCardAmount047 = "0";
            PlayerDatabase.PlayerCardAmount048 = "0";
            PlayerDatabase.PlayerCardAmount049 = "0";
            PlayerDatabase.PlayerCardAmount050 = "0";
            PlayerDatabase.PlayerCardAmount051 = "0";
            PlayerDatabase.PlayerCardAmount052 = "0";
            PlayerDatabase.PlayerCardAmount053 = "0";
            PlayerDatabase.PlayerCardAmount054 = "0";
            PlayerDatabase.PlayerCardAmount055 = "0";
            PlayerDatabase.PlayerCardAmount056 = "0";
            PlayerDatabase.PlayerCardAmount057 = "0";
            PlayerDatabase.PlayerCardAmount058 = "0";
            PlayerDatabase.PlayerCardAmount059 = "0";
            PlayerDatabase.PlayerCardAmount060 = "0";
            PlayerDatabase.PlayerCardAmount061 = "0";
            PlayerDatabase.PlayerCardAmount062 = "0";
            PlayerDatabase.PlayerCardAmount063 = "0";
            PlayerDatabase.PlayerCardAmount064 = "0";
            PlayerDatabase.PlayerCardAmount065 = "0";
            PlayerDatabase.PlayerCardAmount066 = "0";
            PlayerDatabase.PlayerCardAmount067 = "0";
            PlayerDatabase.PlayerCardAmount068 = "0";
            PlayerDatabase.PlayerCardAmount069 = "0";
            PlayerDatabase.PlayerCardAmount070 = "3";
            PlayerDatabase.PlayerCardAmount071 = "1";
            PlayerDatabase.PlayerCardAmount072 = "1";
            PlayerDatabase.PlayerCardAmount073 = "1";
            PlayerDatabase.PlayerCardAmount074 = "0";
            PlayerDatabase.PlayerCardAmount075 = "0";
            PlayerDatabase.PlayerCardAmount076 = "0";
            PlayerDatabase.PlayerCardAmount077 = "0";
            PlayerDatabase.PlayerCardAmount078 = "0";
            PlayerDatabase.PlayerCardAmount079 = "0";
            PlayerDatabase.PlayerCardAmount080 = "0";
            PlayerDatabase.PlayerCardAmount081 = "1";
            PlayerDatabase.PlayerCardAmount082 = "1";
            PlayerDatabase.PlayerCardAmount083 = "0";
            PlayerDatabase.PlayerCardAmount084 = "1";
            PlayerDatabase.PlayerCardAmount085 = "1";
            PlayerDatabase.PlayerCardAmount086 = "0";
            PlayerDatabase.PlayerCardAmount087 = "0";
            PlayerDatabase.PlayerCardAmount088 = "0";
            PlayerDatabase.PlayerCardAmount089 = "0";
            PlayerDatabase.PlayerCardAmount090 = "0";
            PlayerDatabase.PlayerCardAmount091 = "0";
            PlayerDatabase.PlayerCardAmount092 = "0";
            PlayerDatabase.PlayerCardAmount093 = "0";
            PlayerDatabase.PlayerCardAmount094 = "0";
            PlayerDatabase.PlayerCardAmount095 = "0";
            PlayerDatabase.PlayerCardAmount096 = "0";
            PlayerDatabase.PlayerCardAmount097 = "0";
            PlayerDatabase.PlayerCardAmount098 = "0";
            PlayerDatabase.PlayerCardAmount099 = "0";
            PlayerDatabase.PlayerCardAmount100 = "0";
            PlayerDatabase.PlayerCardAmount101 = "0";
            PlayerDatabase.PlayerCardAmount102 = "0";
            PlayerDatabase.PlayerCardAmount103 = "0";
            PlayerDatabase.PlayerCardAmount104 = "0";
            PlayerDatabase.PlayerCardAmount105 = "0";
            PlayerDatabase.PlayerCardAmount106 = "0";
            PlayerDatabase.PlayerCardAmount107 = "0";
            PlayerDatabase.PlayerCardAmount108 = "0";
            PlayerDatabase.PlayerCardAmount109 = "0";
            PlayerDatabase.PlayerCardAmount110 = "0";
            PlayerDatabase.PlayerCardAmount111 = "0";
            PlayerDatabase.PlayerCardAmount112 = "0";
            PlayerDatabase.PlayerCardAmount113 = "0";
            PlayerDatabase.PlayerCardAmount114 = "0";
            PlayerDatabase.PlayerCardAmount115 = "0";
            PlayerDatabase.PlayerCardAmount116 = "0";
            PlayerDatabase.PlayerCardAmount117 = "0";
            PlayerDatabase.PlayerCardAmount118 = "0";
            PlayerDatabase.PlayerCardAmount119 = "0";
            PlayerDatabase.PlayerCardAmount120 = "0";
            PlayerDatabase.PlayerCardAmount121 = "0";
            PlayerDatabase.PlayerCardAmount122 = "0";
            PlayerDatabase.PlayerCardAmount123 = "0";
            PlayerDatabase.PlayerCardAmount124 = "0";
            PlayerDatabase.PlayerCardAmount125 = "0";
            PlayerDatabase.PlayerCardAmount126 = "0";
            PlayerDatabase.PlayerCardAmount127 = "0";
            PlayerDatabase.PlayerCardAmount128 = "0";
            PlayerDatabase.PlayerCardAmount129 = "0";
            PlayerDatabase.PlayerCardAmount130 = "0";
            PlayerDatabase.PlayerCardAmount131 = "0";
            PlayerDatabase.PlayerCardAmount132 = "0";
            PlayerDatabase.PlayerCardAmount133 = "0";
            PlayerDatabase.PlayerCardAmount134 = "0";
        }

        else if (SelectingRealm == "Skies") {
            PlayerDatabase.PlayerCardAmount001 = "0";
            PlayerDatabase.PlayerCardAmount002 = "0";
            PlayerDatabase.PlayerCardAmount003 = "0";
            PlayerDatabase.PlayerCardAmount004 = "0";
            PlayerDatabase.PlayerCardAmount005 = "0";
            PlayerDatabase.PlayerCardAmount006 = "0";
            PlayerDatabase.PlayerCardAmount007 = "0";
            PlayerDatabase.PlayerCardAmount008 = "0";
            PlayerDatabase.PlayerCardAmount009 = "0";
            PlayerDatabase.PlayerCardAmount010 = "0";
            PlayerDatabase.PlayerCardAmount011 = "0";
            PlayerDatabase.PlayerCardAmount012 = "0";
            PlayerDatabase.PlayerCardAmount013 = "0";
            PlayerDatabase.PlayerCardAmount014 = "0";
            PlayerDatabase.PlayerCardAmount015 = "0";
            PlayerDatabase.PlayerCardAmount016 = "0";
            PlayerDatabase.PlayerCardAmount017 = "0";
            PlayerDatabase.PlayerCardAmount018 = "0";
            PlayerDatabase.PlayerCardAmount019 = "0";
            PlayerDatabase.PlayerCardAmount020 = "0";
            PlayerDatabase.PlayerCardAmount021 = "0";
            PlayerDatabase.PlayerCardAmount022 = "0";
            PlayerDatabase.PlayerCardAmount023 = "0";
            PlayerDatabase.PlayerCardAmount024 = "0";
            PlayerDatabase.PlayerCardAmount025 = "0";
            PlayerDatabase.PlayerCardAmount026 = "0";
            PlayerDatabase.PlayerCardAmount027 = "0";
            PlayerDatabase.PlayerCardAmount028 = "0";
            PlayerDatabase.PlayerCardAmount029 = "0";
            PlayerDatabase.PlayerCardAmount030 = "0";
            PlayerDatabase.PlayerCardAmount031 = "0";
            PlayerDatabase.PlayerCardAmount032 = "0";
            PlayerDatabase.PlayerCardAmount033 = "0";
            PlayerDatabase.PlayerCardAmount034 = "0";
            PlayerDatabase.PlayerCardAmount035 = "0";
            PlayerDatabase.PlayerCardAmount036 = "0";
            PlayerDatabase.PlayerCardAmount037 = "0";
            PlayerDatabase.PlayerCardAmount038 = "0";
            PlayerDatabase.PlayerCardAmount039 = "0";
            PlayerDatabase.PlayerCardAmount040 = "0";
            PlayerDatabase.PlayerCardAmount041 = "0";
            PlayerDatabase.PlayerCardAmount042 = "0";
            PlayerDatabase.PlayerCardAmount043 = "0";
            PlayerDatabase.PlayerCardAmount044 = "0";
            PlayerDatabase.PlayerCardAmount045 = "0";
            PlayerDatabase.PlayerCardAmount046 = "0";
            PlayerDatabase.PlayerCardAmount047 = "0";
            PlayerDatabase.PlayerCardAmount048 = "0";
            PlayerDatabase.PlayerCardAmount049 = "0";
            PlayerDatabase.PlayerCardAmount050 = "0";
            PlayerDatabase.PlayerCardAmount051 = "0";
            PlayerDatabase.PlayerCardAmount052 = "0";
            PlayerDatabase.PlayerCardAmount053 = "0";
            PlayerDatabase.PlayerCardAmount054 = "0";
            PlayerDatabase.PlayerCardAmount055 = "0";
            PlayerDatabase.PlayerCardAmount056 = "0";
            PlayerDatabase.PlayerCardAmount057 = "0";
            PlayerDatabase.PlayerCardAmount058 = "0";
            PlayerDatabase.PlayerCardAmount059 = "0";
            PlayerDatabase.PlayerCardAmount060 = "0";
            PlayerDatabase.PlayerCardAmount061 = "0";
            PlayerDatabase.PlayerCardAmount062 = "0";
            PlayerDatabase.PlayerCardAmount063 = "0";
            PlayerDatabase.PlayerCardAmount064 = "0";
            PlayerDatabase.PlayerCardAmount065 = "0";
            PlayerDatabase.PlayerCardAmount066 = "0";
            PlayerDatabase.PlayerCardAmount067 = "0";
            PlayerDatabase.PlayerCardAmount068 = "0";
            PlayerDatabase.PlayerCardAmount069 = "0";
            PlayerDatabase.PlayerCardAmount070 = "0";
            PlayerDatabase.PlayerCardAmount071 = "0";
            PlayerDatabase.PlayerCardAmount072 = "0";
            PlayerDatabase.PlayerCardAmount073 = "0";
            PlayerDatabase.PlayerCardAmount074 = "0";
            PlayerDatabase.PlayerCardAmount075 = "0";
            PlayerDatabase.PlayerCardAmount076 = "0";
            PlayerDatabase.PlayerCardAmount077 = "0";
            PlayerDatabase.PlayerCardAmount078 = "0";
            PlayerDatabase.PlayerCardAmount079 = "0";
            PlayerDatabase.PlayerCardAmount080 = "0";
            PlayerDatabase.PlayerCardAmount081 = "0";
            PlayerDatabase.PlayerCardAmount082 = "0";
            PlayerDatabase.PlayerCardAmount083 = "0";
            PlayerDatabase.PlayerCardAmount084 = "0";
            PlayerDatabase.PlayerCardAmount085 = "0";
            PlayerDatabase.PlayerCardAmount086 = "0";
            PlayerDatabase.PlayerCardAmount087 = "0";
            PlayerDatabase.PlayerCardAmount088 = "0";
            PlayerDatabase.PlayerCardAmount089 = "0";
            PlayerDatabase.PlayerCardAmount090 = "0";
            PlayerDatabase.PlayerCardAmount091 = "3";
            PlayerDatabase.PlayerCardAmount092 = "1";
            PlayerDatabase.PlayerCardAmount093 = "1";
            PlayerDatabase.PlayerCardAmount094 = "1";
            PlayerDatabase.PlayerCardAmount095 = "0";
            PlayerDatabase.PlayerCardAmount096 = "0";
            PlayerDatabase.PlayerCardAmount097 = "0";
            PlayerDatabase.PlayerCardAmount098 = "0";
            PlayerDatabase.PlayerCardAmount099 = "0";
            PlayerDatabase.PlayerCardAmount100 = "0";
            PlayerDatabase.PlayerCardAmount101 = "0";
            PlayerDatabase.PlayerCardAmount102 = "1";
            PlayerDatabase.PlayerCardAmount103 = "0";
            PlayerDatabase.PlayerCardAmount104 = "1";
            PlayerDatabase.PlayerCardAmount105 = "0";
            PlayerDatabase.PlayerCardAmount106 = "0";
            PlayerDatabase.PlayerCardAmount107 = "0";
            PlayerDatabase.PlayerCardAmount108 = "1";
            PlayerDatabase.PlayerCardAmount109 = "0";
            PlayerDatabase.PlayerCardAmount110 = "0";
            PlayerDatabase.PlayerCardAmount111 = "1";
            PlayerDatabase.PlayerCardAmount112 = "0";
            PlayerDatabase.PlayerCardAmount113 = "0";
            PlayerDatabase.PlayerCardAmount114 = "0";
            PlayerDatabase.PlayerCardAmount115 = "0";
            PlayerDatabase.PlayerCardAmount116 = "0";
            PlayerDatabase.PlayerCardAmount117 = "0";
            PlayerDatabase.PlayerCardAmount118 = "0";
            PlayerDatabase.PlayerCardAmount119 = "0";
            PlayerDatabase.PlayerCardAmount120 = "0";
            PlayerDatabase.PlayerCardAmount121 = "0";
            PlayerDatabase.PlayerCardAmount122 = "0";
            PlayerDatabase.PlayerCardAmount123 = "0";
            PlayerDatabase.PlayerCardAmount124 = "0";
            PlayerDatabase.PlayerCardAmount125 = "0";
            PlayerDatabase.PlayerCardAmount126 = "0";
            PlayerDatabase.PlayerCardAmount127 = "0";
            PlayerDatabase.PlayerCardAmount128 = "0";
            PlayerDatabase.PlayerCardAmount129 = "0";
            PlayerDatabase.PlayerCardAmount130 = "0";
            PlayerDatabase.PlayerCardAmount131 = "0";
            PlayerDatabase.PlayerCardAmount132 = "0";
            PlayerDatabase.PlayerCardAmount133 = "0";
            PlayerDatabase.PlayerCardAmount134 = "0";
        }

        // Store Information
        PlayerDatabase.StoreBoughtDarkPack = "0";
        PlayerDatabase.StoreBoughtEarthPack = "0";
        PlayerDatabase.StoreBoughtLightPack = "0";
        PlayerDatabase.StoreBoughtSeaPack = "0";
        PlayerDatabase.StoreBoughtSkiesPack = "0";
        PlayerDatabase.StoreBoughtEpicPack = "0";
        PlayerDatabase.StoreBoughtWorldPack = "0";

        // Start Coroutine
        StartCoroutine(CheckLogInName());
    }

    public void SignUpRealmDarkButtonClicking() {
        SelectingRealmReset();
        SelectingRealm = "Dark";
        SignUpRealmDarkImage.GetComponent<Image>().color = SelectingRealmChosen;
    }

    public void SignUpRealmEarthButtonClicking() {
        SelectingRealmReset();
        SelectingRealm = "Earth";
        SignUpRealmEarthImage.GetComponent<Image>().color = SelectingRealmChosen;
    }

    public void SignUpRealmLightButtonClicking() {
        SelectingRealmReset();
        SelectingRealm = "Light";
        SignUpRealmLightImage.GetComponent<Image>().color = SelectingRealmChosen;
    }

    public void SignUpRealmSeaButtonClicking() {
        SelectingRealmReset();
        SelectingRealm = "Sea";
        SignUpRealmSeaImage.GetComponent<Image>().color = SelectingRealmChosen;
    }

    public void SignUpRealmSkiesButtonClicking() {
        SelectingRealmReset();
        SelectingRealm = "Skies";
        SignUpRealmSkiesImage.GetComponent<Image>().color = SelectingRealmChosen;
    }

// -------------------- RESET COLORS FUNCTIONS --------------------
    public void SelectingRealmReset() {
        SignUpRealmDarkImage.GetComponent<Image>().color = SelectingRealmOriginal;
        SignUpRealmEarthImage.GetComponent<Image>().color = SelectingRealmOriginal;
        SignUpRealmLightImage.GetComponent<Image>().color = SelectingRealmOriginal;
        SignUpRealmSeaImage.GetComponent<Image>().color = SelectingRealmOriginal;
        SignUpRealmSkiesImage.GetComponent<Image>().color = SelectingRealmOriginal;
    }

// -------------------- IENUMERATOR FUNCTIONS --------------------
    public IEnumerator LoadPlayerData() {
        WWWForm LoadPlayerDataForm = new WWWForm();

        LoadPlayerDataForm.AddField("PlayerLogInName", PlayerDatabase.PlayerLogInName);

        using (UnityWebRequest LoadPlayerDataWWW = UnityWebRequest.Post("http://www.theferryman.org/MagiciansOfMythology/PHPLoadPlayerData.php", LoadPlayerDataForm)) {
            yield return LoadPlayerDataWWW.SendWebRequest();

            if ((LoadPlayerDataWWW.result == UnityWebRequest.Result.ConnectionError) || (LoadPlayerDataWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(LoadPlayerDataWWW.error);
            }

            else {
                if (LoadPlayerDataWWW.downloadHandler.text != "Unable to view database") {
                    // Get String Data
                    string jsonArrayString = LoadPlayerDataWWW.downloadHandler.text;
                    string jsonArrayStringA = jsonArrayString.Replace('"', ' ');
                    string jsonArrayStringB = jsonArrayStringA.Replace('{', ' ');
                    string jsonArrayStringC = jsonArrayStringB.Replace('}', ' ');
                    string jsonArrayStringD = jsonArrayStringC.Replace('[', ' ');
                    string jsonArrayStringE = jsonArrayStringD.Replace(']', ' ');
                    string[] jsonArrayStringTwo = jsonArrayStringE.Split(',', ':');

                    // Player Information
                    PlayerDatabase.PlayerName = jsonArrayStringTwo[1].Trim().ToString();
                    PlayerDatabase.PlayerRealm = jsonArrayStringTwo[5].Trim().ToString();
                    PlayerDatabase.PlayerFavGod = jsonArrayStringTwo[7].Trim().ToString();
                    PlayerDatabase.PlayerStoryLevel = jsonArrayStringTwo[9].Trim().ToString();
                    PlayerDatabase.PlayerWins = jsonArrayStringTwo[11].Trim().ToString();
                    PlayerDatabase.PlayerLosses = jsonArrayStringTwo[13].Trim().ToString();
                    PlayerDatabase.PlayerStalemates = jsonArrayStringTwo[15].Trim().ToString();

                    // Load Next Coroutine
                    StartCoroutine(LoadPlayerCardData());
                }

                else {

                }
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

    public IEnumerator LoadPlayerCardData() {
        WWWForm LoadPlayerCardDataForm = new WWWForm();

        LoadPlayerCardDataForm.AddField("PlayerLogInName", PlayerDatabase.PlayerLogInName);

        using (UnityWebRequest LoadPlayerCardDataWWW = UnityWebRequest.Post("http://www.theferryman.org/MagiciansOfMythology/PHPLoadPlayerCardData.php", LoadPlayerCardDataForm)) {
            yield return LoadPlayerCardDataWWW.SendWebRequest();

            if ((LoadPlayerCardDataWWW.result == UnityWebRequest.Result.ConnectionError) || (LoadPlayerCardDataWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(LoadPlayerCardDataWWW.error);
            }

            else {
                if (LoadPlayerCardDataWWW.downloadHandler.text != "Unable to view database") {
					string jsonArrayString = LoadPlayerCardDataWWW.downloadHandler.text;
					string jsonArrayStringA = jsonArrayString.Replace('"', ' ');
					string jsonArrayStringB = jsonArrayStringA.Replace('{', ' ');
					string jsonArrayStringC = jsonArrayStringB.Replace('}', ' ');
					string jsonArrayStringD = jsonArrayStringC.Replace(']', ' ');
					string jsonArrayStringE = jsonArrayStringD.Replace('[', ' ');
                    string[] jsonArrayStringTwo = jsonArrayStringE.Split(',', ':');

                    // Card Information
                    PlayerDatabase.PlayerCardAmount001 = jsonArrayStringTwo[3].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount002 = jsonArrayStringTwo[5].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount003 = jsonArrayStringTwo[7].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount004 = jsonArrayStringTwo[9].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount005 = jsonArrayStringTwo[11].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount006 = jsonArrayStringTwo[13].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount007 = jsonArrayStringTwo[15].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount008 = jsonArrayStringTwo[17].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount009 = jsonArrayStringTwo[19].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount010 = jsonArrayStringTwo[21].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount011 = jsonArrayStringTwo[23].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount012 = jsonArrayStringTwo[25].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount013 = jsonArrayStringTwo[27].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount014 = jsonArrayStringTwo[29].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount015 = jsonArrayStringTwo[31].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount016 = jsonArrayStringTwo[33].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount017 = jsonArrayStringTwo[35].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount018 = jsonArrayStringTwo[37].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount019 = jsonArrayStringTwo[39].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount020 = jsonArrayStringTwo[41].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount021 = jsonArrayStringTwo[43].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount022 = jsonArrayStringTwo[45].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount023 = jsonArrayStringTwo[47].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount024 = jsonArrayStringTwo[49].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount025 = jsonArrayStringTwo[51].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount026 = jsonArrayStringTwo[53].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount027 = jsonArrayStringTwo[55].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount028 = jsonArrayStringTwo[57].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount029 = jsonArrayStringTwo[59].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount030 = jsonArrayStringTwo[61].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount031 = jsonArrayStringTwo[63].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount032 = jsonArrayStringTwo[65].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount033 = jsonArrayStringTwo[67].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount034 = jsonArrayStringTwo[69].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount035 = jsonArrayStringTwo[71].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount036 = jsonArrayStringTwo[73].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount037 = jsonArrayStringTwo[75].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount038 = jsonArrayStringTwo[77].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount039 = jsonArrayStringTwo[79].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount040 = jsonArrayStringTwo[81].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount041 = jsonArrayStringTwo[83].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount042 = jsonArrayStringTwo[85].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount043 = jsonArrayStringTwo[87].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount044 = jsonArrayStringTwo[89].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount045 = jsonArrayStringTwo[91].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount046 = jsonArrayStringTwo[93].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount047 = jsonArrayStringTwo[95].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount048 = jsonArrayStringTwo[97].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount049 = jsonArrayStringTwo[99].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount050 = jsonArrayStringTwo[101].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount051 = jsonArrayStringTwo[103].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount052 = jsonArrayStringTwo[105].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount053 = jsonArrayStringTwo[107].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount054 = jsonArrayStringTwo[109].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount055 = jsonArrayStringTwo[111].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount056 = jsonArrayStringTwo[113].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount057 = jsonArrayStringTwo[115].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount058 = jsonArrayStringTwo[117].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount059 = jsonArrayStringTwo[119].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount060 = jsonArrayStringTwo[121].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount061 = jsonArrayStringTwo[123].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount062 = jsonArrayStringTwo[125].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount063 = jsonArrayStringTwo[127].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount064 = jsonArrayStringTwo[129].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount065 = jsonArrayStringTwo[131].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount066 = jsonArrayStringTwo[133].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount067 = jsonArrayStringTwo[135].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount068 = jsonArrayStringTwo[137].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount069 = jsonArrayStringTwo[139].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount070 = jsonArrayStringTwo[141].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount071 = jsonArrayStringTwo[143].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount072 = jsonArrayStringTwo[145].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount073 = jsonArrayStringTwo[147].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount074 = jsonArrayStringTwo[149].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount075 = jsonArrayStringTwo[151].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount076 = jsonArrayStringTwo[153].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount077 = jsonArrayStringTwo[155].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount078 = jsonArrayStringTwo[157].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount079 = jsonArrayStringTwo[159].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount080 = jsonArrayStringTwo[161].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount081 = jsonArrayStringTwo[163].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount082 = jsonArrayStringTwo[165].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount083 = jsonArrayStringTwo[167].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount084 = jsonArrayStringTwo[169].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount085 = jsonArrayStringTwo[171].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount086 = jsonArrayStringTwo[173].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount087 = jsonArrayStringTwo[175].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount088 = jsonArrayStringTwo[177].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount089 = jsonArrayStringTwo[179].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount090 = jsonArrayStringTwo[181].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount091 = jsonArrayStringTwo[183].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount092 = jsonArrayStringTwo[185].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount093 = jsonArrayStringTwo[187].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount094 = jsonArrayStringTwo[189].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount095 = jsonArrayStringTwo[191].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount096 = jsonArrayStringTwo[193].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount097 = jsonArrayStringTwo[195].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount098 = jsonArrayStringTwo[197].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount099 = jsonArrayStringTwo[199].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount100 = jsonArrayStringTwo[201].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount101 = jsonArrayStringTwo[203].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount102 = jsonArrayStringTwo[205].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount103 = jsonArrayStringTwo[207].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount104 = jsonArrayStringTwo[209].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount105 = jsonArrayStringTwo[211].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount106 = jsonArrayStringTwo[213].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount107 = jsonArrayStringTwo[215].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount108 = jsonArrayStringTwo[217].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount109 = jsonArrayStringTwo[219].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount110 = jsonArrayStringTwo[221].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount111 = jsonArrayStringTwo[223].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount112 = jsonArrayStringTwo[225].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount113 = jsonArrayStringTwo[227].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount114 = jsonArrayStringTwo[229].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount115 = jsonArrayStringTwo[231].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount116 = jsonArrayStringTwo[233].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount117 = jsonArrayStringTwo[235].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount118 = jsonArrayStringTwo[237].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount119 = jsonArrayStringTwo[239].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount120 = jsonArrayStringTwo[241].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount121 = jsonArrayStringTwo[243].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount122 = jsonArrayStringTwo[245].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount123 = jsonArrayStringTwo[247].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount124 = jsonArrayStringTwo[249].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount125 = jsonArrayStringTwo[251].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount126 = jsonArrayStringTwo[253].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount127 = jsonArrayStringTwo[255].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount128 = jsonArrayStringTwo[257].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount129 = jsonArrayStringTwo[259].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount130 = jsonArrayStringTwo[261].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount131 = jsonArrayStringTwo[263].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount132 = jsonArrayStringTwo[265].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount133 = jsonArrayStringTwo[267].Trim().ToString();
                    PlayerDatabase.PlayerCardAmount134 = jsonArrayStringTwo[269].Trim().ToString();

                    // Load Next Coroutine
                    StartCoroutine(LoadPlayerStoreData());
                }

                else {

                }
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

    public IEnumerator LoadPlayerStoreData() {
        WWWForm LoadPlayerStoreDataForm = new WWWForm();

        LoadPlayerStoreDataForm.AddField("PlayerLogInName", PlayerDatabase.PlayerLogInName);

        using (UnityWebRequest LoadPlayerStoreDataWWW = UnityWebRequest.Post("http://www.theferryman.org/MagiciansOfMythology/PHPLoadPlayerStoreData.php", LoadPlayerStoreDataForm)) {
            yield return LoadPlayerStoreDataWWW.SendWebRequest();

            if ((LoadPlayerStoreDataWWW.result == UnityWebRequest.Result.ConnectionError) || (LoadPlayerStoreDataWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(LoadPlayerStoreDataWWW.error);
            }

            else {
                if (LoadPlayerStoreDataWWW.downloadHandler.text != "Unable to view database") {
                    string jsonArrayString = LoadPlayerStoreDataWWW.downloadHandler.text;
					string jsonArrayStringA = jsonArrayString.Replace('"', ' ');
					string jsonArrayStringB = jsonArrayStringA.Replace('{', ' ');
					string jsonArrayStringC = jsonArrayStringB.Replace('}', ' ');
					string jsonArrayStringD = jsonArrayStringC.Replace(']', ' ');
					string jsonArrayStringE = jsonArrayStringD.Replace('[', ' ');
                    string[] jsonArrayStringTwo = jsonArrayStringE.Split(',', ':');

                    // Store Information
                    PlayerDatabase.StoreBoughtDarkPack = jsonArrayStringTwo[3].Trim().ToString();
                    PlayerDatabase.StoreBoughtEarthPack = jsonArrayStringTwo[5].Trim().ToString();
                    PlayerDatabase.StoreBoughtLightPack = jsonArrayStringTwo[7].Trim().ToString();
                    PlayerDatabase.StoreBoughtSeaPack = jsonArrayStringTwo[9].Trim().ToString();
                    PlayerDatabase.StoreBoughtSkiesPack = jsonArrayStringTwo[11].Trim().ToString();
                    PlayerDatabase.StoreBoughtEpicPack = jsonArrayStringTwo[13].Trim().ToString();
                    PlayerDatabase.StoreBoughtWorldPack = jsonArrayStringTwo[15].Trim().ToString();

                    // Load Main Menu Scene
                    Scene05LoadRun.Scene05Load();
                }

                else {

                }
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

    public IEnumerator SettingNewPlayer() {
        WWWForm SettingNewPlayerForm = new WWWForm();

        SettingNewPlayerForm.AddField("PlayerLogInName", PlayerDatabase.PlayerLogInName);
        SettingNewPlayerForm.AddField("PlayerName", PlayerDatabase.PlayerName);
        SettingNewPlayerForm.AddField("PlayerFavGod", PlayerDatabase.PlayerFavGod);
        SettingNewPlayerForm.AddField("PlayerRealm", PlayerDatabase.PlayerRealm);

        using (UnityWebRequest SettingNewPlayerWWW = UnityWebRequest.Post("http://www.theferryman.org/MagiciansOfMythology/PHPSetNewPlayerData.php", SettingNewPlayerForm)) {
            yield return SettingNewPlayerWWW.SendWebRequest();

            if ((SettingNewPlayerWWW.result == UnityWebRequest.Result.ConnectionError) || (SettingNewPlayerWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(SettingNewPlayerWWW.error);
            }

            else {
                if (SettingNewPlayerWWW.downloadHandler.text != "Unable to view database") {
                    Scene03LoadRun.Scene03Load();
                }

                else {

                }
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

    public IEnumerator CheckLogInName() {
        WWWForm CheckLogInNameForm = new WWWForm();

        CheckLogInNameForm.AddField("PlayerLogInName", PlayerDatabase.PlayerLogInName);

        using (UnityWebRequest CheckLogInNameWWW = UnityWebRequest.Post("http://www.theferryman.org/MagiciansOfMythology/PHPCheckLogInName.php", CheckLogInNameForm)) {
            yield return CheckLogInNameWWW.SendWebRequest();

            if ((CheckLogInNameWWW.result == UnityWebRequest.Result.ConnectionError) || (CheckLogInNameWWW.result == UnityWebRequest.Result.ProtocolError)) {
                Debug.Log(CheckLogInNameWWW.error);
            }

            else {
                if (CheckLogInNameWWW.downloadHandler.text != "Unable to view database") {
                    if (EnableObjects02.LogInSignUpInt == 2) {
                        EnableObjects02.LogInSignUpInt = 4;
                    }

                    else if (EnableObjects02.LogInSignUpInt == 0) {
                        StartCoroutine(LoadPlayerData());
                    }
                }

                else {
                    if (EnableObjects02.LogInSignUpInt == 2) {
                        StartCoroutine(SettingNewPlayer());
                    }

                    else if (EnableObjects02.LogInSignUpInt == 0) {
                        EnableObjects02.LogInSignUpInt = 3;
                    }
                }
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

// ------------------------------ END: OTHER FUNCTIONS ------------------------------

}