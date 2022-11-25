using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundsSurvived : MonoBehaviour
{
    public TMP_Text roundsText;
    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
        StartCoroutine(AnimateText());
    }
    IEnumerator AnimateText()
    {
        roundsText.text = "0";
        int round = 0;
        yield return new WaitForSeconds(.07f);
        while (round < PlayerStats.Rounds)
        {
            round++;
            roundsText.text = round.ToString();
            yield return new WaitForSeconds(.05f);
        }
    }
}
