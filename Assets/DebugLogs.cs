using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugLogs : MonoBehaviour
{
    // Boutons
    public Button btnJouer;
    public Button btnParametres;
    public Button btnQuitter;

    // Slider
    public Slider slider;

    // Toggle
    public Toggle toggle;
    // Dropdown
    public TMP_Dropdown dropDown;

    // Input Field
    public TMP_InputField inputField;



    // Start is called before the first frame update
    void Start()
    {
        // Ajouter un listener sur btnJouer
        btnJouer.onClick.AddListener(btnJouer_OnClick);
        // Ajouter un listener sur btnParametres
        btnParametres.onClick.AddListener(btnParametres_OnClick);
        // Ajouter un listener sur btnQuitter
        btnQuitter.onClick.AddListener(btnQuitter_OnClick);

        // Ajouter un listener sur slider
        slider.onValueChanged.AddListener(slider_OnValueChanged);

        // Ajouter un listener sur toggle
        toggle.onValueChanged.AddListener(toggle_OnValueChanged);

        // Ajouter un listener pour dropdown
        dropDown.onValueChanged.AddListener(dropDown_OnValueChanged);

        // Ajouter un listener sur inputField
        inputField.onEndEdit.AddListener(inputField_OnEndEdit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void btnJouer_OnClick()
    {
        // Envoyer un message dans la console quand on clique sur le bouton Jouer
        Debug.Log("On a appuye sur Jouer");
    }

    void btnParametres_OnClick()
    {
        
    }

    void btnQuitter_OnClick()
    {
        // Envoyer un message dans la console quand on clique sur le bouton Quitter
        Debug.Log("On a appuye sur Quitter");
    }

    void slider_OnValueChanged(float value)
    {
        // Envoyer un message dans la console quand on change la valeur du slider dans les parametres
        Debug.Log($"La valeur du slider est de {value}");
    }

    void toggle_OnValueChanged(bool value)
    {
        // Envoyer un message dans la console quand on clique sur le bouton toggle
        Debug.Log($"La valeur du toggle est de {value}");
    }

    void dropDown_OnValueChanged(int value)
    {
        // Envoyer un message dans la console quand on selectionne une valeur du dropdown
        Debug.Log($"On a selectionne l'option {value} du dropdown");
    }

    void inputField_OnEndEdit(string value)
    {
        // Envoyer un message dans la console quand on entre du texte dans le inputfield
        Debug.Log($"On a entre {value} dans le inputfield");
    }
}
