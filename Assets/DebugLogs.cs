using System;
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
    // Bouton X dans parametres
    public Button btnFermerParametres;

    // Slider
    public Slider volumeSlider;

    // Toggle
    public Toggle multijoueurToggle;

    // Dropdown
    public TMP_Dropdown dropDownNombreJoueurs;

    // Input Field
    public TMP_InputField inputFieldNomJoueur;

    // Objet qui represente les 3 boutons principaux
    public GameObject menuPrincipalFooter;
    
    // Objet qui represente le menu parametres
    public GameObject menuParametres;

    // Start is called before the first frame update
    void Start()
    {
        // Ajouter un listener sur btnJouer
        btnJouer.onClick.AddListener(btnJouer_OnClick);
        // Ajouter un listener sur btnParametres
        btnParametres.onClick.AddListener(btnParametres_OnClick);
        // Ajouter un listener sur btnQuitter
        btnQuitter.onClick.AddListener(btnQuitter_OnClick);
        // Ajouter un listener sur btnX
        btnFermerParametres.onClick.AddListener(btnFermerParametres_OnClick);

        // Ajouter un listener sur slider
        volumeSlider.onValueChanged.AddListener(volumeSlider_OnValueChanged);

        // Ajouter un listener sur toggle
        multijoueurToggle.onValueChanged.AddListener(multijoueurToggle_OnValueChanged);

        // Ajouter un listener pour dropdown
        dropDownNombreJoueurs.onValueChanged.AddListener(dropDownNombreJoueurs_OnValueChanged);

        // Ajouter un listener sur inputField
        inputFieldNomJoueur.onEndEdit.AddListener(inputField_OnEndEdit);
        
        menuParametres.SetActive(false);
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
        menuPrincipalFooter.SetActive(false);
        menuParametres.SetActive(true);
    }

    void btnQuitter_OnClick()
    {
        // Envoyer un message dans la console quand on clique sur le bouton Quitter
        Debug.Log("On a appuye sur Quitter");
    }

    void btnFermerParametres_OnClick()
    {
        menuParametres.SetActive(false);
        menuPrincipalFooter.SetActive(true);
    }

    void volumeSlider_OnValueChanged(float value)
    {
        // Envoyer un message dans la console quand on change la valeur du slider dans les parametres
        Debug.Log($"La valeur du slider de volume est de {value * 100}%");
    }

    void multijoueurToggle_OnValueChanged(bool value)
    {
        // Envoyer un message dans la console quand on clique sur le bouton toggle
        Debug.Log($"La valeur du toggle en ligne est de {value}");
    }

    void dropDownNombreJoueurs_OnValueChanged(int value)
    {
        // Envoyer un message dans la console quand on selectionne une valeur du dropdown
        String optionNombreJoueurs = dropDownNombreJoueurs.options[value].text;
        Debug.Log($"On a selectionne l'option {optionNombreJoueurs} du dropdown de nombre de joueurs");
    }

    void inputField_OnEndEdit(string value)
    {
        // Envoyer un message dans la console quand on entre du texte dans le inputfield
        Debug.Log($"On a entre {value} dans le inputfield du nom du joueur");
    }
}
