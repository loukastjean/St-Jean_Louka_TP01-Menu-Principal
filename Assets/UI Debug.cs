using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class UIDebug : MonoBehaviour
{

    public Button btnFermer;
    public Slider sliderVolume;
    public TMP_Dropdown dropdownCountry;
    public TMP_InputField inputCountry;
    public Toggle toggleFermer;
    
    public AudioSource sourceMoney;
    
    // Start is called before the first frame update
    void Start()
    {
        // Ajouter eventListener sur btnFermer
        btnFermer.onClick.AddListener(btnFermer_OnClick);
        
        // Ajouter eventListener sur sliderVolume
        sliderVolume.onValueChanged.AddListener(sliderVolume_OnValueChanged);
        
        dropdownCountry.onValueChanged.AddListener(dropdownCountry_OnValueChanged);
        
        inputCountry.onEndEdit.AddListener(inputCountry_OnSubmit);
        
        toggleFermer.onValueChanged.AddListener(toggleFermer_OnValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void btnFermer_OnClick()
    {
        Debug.Log("Fermer");
        
        sourceMoney.Play();
    }

    void dropdownCountry_OnValueChanged(int value)
    {
        Debug.Log("Country dropdown change" + value);
    }

    void sliderVolume_OnValueChanged(float volume)
    {
        Debug.Log("Volume: " + volume);
    }

    void inputCountry_OnSubmit(string country)
    {
        Debug.Log("Country: " + country);
    }

    void toggleFermer_OnValueChanged(bool value)
    {
        Debug.Log("Fermer: " + value);
    }
}
