using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorChange : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [ColorUsage(true, true)]
    public Color CouleurImpact;
    [ColorUsage(true, true)]
    public Color DefaultColor;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(BlinkColor());


    }
    IEnumerator BlinkColor()
    {
        Material matmat = meshRenderer.material;

        matmat.SetColor("_EmissiveColor", CouleurImpact);
        yield return new WaitForSeconds(0.3f);

        matmat.SetColor("_EmissiveColor", DefaultColor);
    }
}