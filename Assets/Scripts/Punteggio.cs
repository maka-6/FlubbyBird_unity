using TMPro;
using UnityEngine;

public class Punteggio : MonoBehaviour
{
    TextMeshProUGUI punteggio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        punteggio = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        punteggio.SetText(GameController.instance.getPunteggio().ToString());
    }
}
