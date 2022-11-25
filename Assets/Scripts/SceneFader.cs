using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class SceneFader : MonoBehaviour
{
    public Image img;
    public float speed = 1.1f;
    public AnimationCurve curve;
    void Start()
    {
        StartCoroutine(FadeIn());
    }
    public void FadeTo(string scene)
    {
        StartCoroutine (FadeOut(scene));
    }
    IEnumerator FadeIn()
    {
        float t = 1.02f;
        while(t > 0f)
        {
            t -= Time.deltaTime * speed;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
    }
    IEnumerator FadeOut(string scene)
    {
        float t = 0f;
        while (t > 1.02f)
        {
            t -= Time.deltaTime * speed;
            float a = curve.Evaluate(t);
            img.color = new Color(0f, 0f, 0f, a);
            yield return 0;
        }
        SceneManager.LoadScene(scene);
    }
}
