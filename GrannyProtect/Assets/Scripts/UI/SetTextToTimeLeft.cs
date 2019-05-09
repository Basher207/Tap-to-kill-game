using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTextToTimeLeft : MonoBehaviour
{
    public Image circleImage;
    [HideInInspector] public Text text;
    private void Start() {
        text = GetComponent<Text>();
    }
    private void Update() {
        circleImage.fillAmount = GameManager.normTimeLeft;
        text.text = ((int)Mathf.Clamp(GameManager.timeLeft, 0f, GameManager.levelLength)).ToString();

    }
}
