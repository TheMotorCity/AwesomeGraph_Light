using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphRender : MonoBehaviour
{
    public Toggle DeathsToggleUI;
    public Toggle CasesToggleUI;
    public Toggle RecoveryToggleUI;
    public Button FilterButtonUI;
   
    private Boolean Deaths;
    private Boolean Cases;
    private Boolean Recovery;
    // Start is called before the first frame update
    void Start()
    {
        FilterButtonUI.GetComponent<Button>().onClick.AddListener(FilterOnClickEvent);
        Deaths = DeathsToggleUI.GetComponent<Toggle>().isOn;
        Cases = CasesToggleUI.GetComponent<Toggle>().isOn;
        Recovery = RecoveryToggleUI.GetComponent<Toggle>().isOn;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = Deaths;
        gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = Cases;
        gameObject.transform.GetChild(2).GetComponent<Renderer>().enabled = Recovery;
    }

    void FilterOnClickEvent()
    {
        Deaths = DeathsToggleUI.GetComponent<Toggle>().isOn;
        Cases = CasesToggleUI.GetComponent<Toggle>().isOn;
        Recovery = RecoveryToggleUI.GetComponent<Toggle>().isOn;
    }
}
