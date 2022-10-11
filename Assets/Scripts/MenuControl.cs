using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Button buton;
    [SerializeField] Dropdown dropdown;
    [SerializeField] InputField inputField;
    [SerializeField] Image image;
    [SerializeField] Toggle toggle;
    [SerializeField] Slider slider;
    [SerializeField] Scrollbar scrollbar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButonaBasildi()
    {
        text.text = "butona basıldı";
    }

    
}
