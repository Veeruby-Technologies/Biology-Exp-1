using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessFlow : MonoBehaviour
{
    public GameObject enableManipulation;
    public GameObject disableManipulation;

    public GameObject petalButton;
    public GameObject sepalButton;
    public GameObject epacylixlButton;
    public GameObject gynoeciumButton;
    public GameObject monoadelphousButton;

    public GameObject petalPlacement;
    public GameObject sepalPlacement;
    public GameObject epacylixPlacement;
    public GameObject gynoeciumPlacement;
    public GameObject monoadellphousPlacement;


    public GameObject petalPart;
    public GameObject sepalPart;
    public GameObject epacylixPartt;
    public GameObject gynoeciumPart;
    public GameObject monoadellphousPart;


    public void SeparatePetals()
    {
        enableManipulation.SetActive(false);
        disableManipulation.SetActive(false);
        petalButton.SetActive(false);
        petalPlacement.SetActive(true);
        sepalButton.SetActive(true);
    }
    public void SeparateSepals()
    {
        sepalButton.SetActive(false);
        sepalPlacement.SetActive(true);
        epacylixlButton.SetActive(true);
    }

    public void Separateepacylixl()
    {
        epacylixlButton.SetActive(false);
        epacylixPlacement.SetActive(true);
        gynoeciumButton.SetActive(true);
    }

    public void Separatgynoecium()
    {
        gynoeciumButton.SetActive(false);
        gynoeciumPlacement.SetActive(true);
        monoadelphousButton.SetActive(true);
    }

    public void Separatmonoadellphous()
    {
        monoadellphousPart.GetComponent<BoxCollider>().enabled = true;
        monoadelphousButton.SetActive(false);
        monoadellphousPlacement.SetActive(true);
    }





}
