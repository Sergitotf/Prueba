using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShipScreen : MonoBehaviour
{
    public Spaceshipdata infoSpaceShip;
    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider heatSlider;
    public TextMeshProUGUI spaceName;
    private float speed = 1f;
    void Start()
    {
        speedSlider.value = 0;
        shieldSlider.value = 0;
        heatSlider.value = 0;
        Debug.Log(infoSpaceShip.speed);
        Debug.Log(infoSpaceShip.shield);
        Debug.Log(infoSpaceShip.spaceshipname);
        Debug.Log(infoSpaceShip.heat);
    }

    // Update is called once per frame
    void Update()
    {
        speedSlider.value = infoSpaceShip.speed;
        heatSlider.value = infoSpaceShip.heat;
        shieldSlider.value = infoSpaceShip.shield;


        if (shieldSlider.value < infoSpaceShip.shield)
        {
            shieldSlider.value += Time.deltaTime * speed;

        }
        if (speedSlider.value < infoSpaceShip.speed)
        {
            speedSlider.value += Time.deltaTime * speed;

        }
        if (heatSlider.value < infoSpaceShip.heat)
        {
            heatSlider.value += Time.deltaTime * speed;

        }
    }
}
