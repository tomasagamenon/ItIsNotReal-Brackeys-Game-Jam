using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PlayerSanity : MonoBehaviour
{
    Volume volume;
    int sanity;
    int sanitySave;

    [Header("SanityUpAndDown")]
    [SerializeField]
    private float darkness;
    [SerializeField]
    private float seeEnemy;
    [SerializeField]
    private float pursued;
    [SerializeField]
    private float quiet;

    [Header("PostProcessing")]
    [SerializeField]
    private float multiplierSanityPerPoint;
    private float multiplierSanity;

    private ChromaticAberration chromatic;
    [SerializeField]
    private int SanityStartCAInt;
    [SerializeField]
    private float MaxCAIntensity;
    [SerializeField]
    private float MinCAIntensity;
    private float ValueCAIntensity;

    private LensDistortion lens;
    [SerializeField]
    private int SanityStartLDInt;
    [SerializeField]
    private float MaxLDIntensity;
    [SerializeField]
    private float MinLDIntensity;
    private float ValueLDIntensity;

    private Vignette vignette;
    [SerializeField]
    private int SanityStartVInt;
    [SerializeField]
    private float MaxVIntensity;
    [SerializeField]
    private float MinVIntensity;
    private float ValueVIntensity;
    [SerializeField]
    private int SanityStartVSmooth;
    [SerializeField]
    private float MaxVSmoothness;
    [SerializeField]
    private float MinVSmoothness;
    private float ValueVSmoothness;

    void Awake()
    {
        sanity = 100;
        multiplierSanity = 1;
        volume.profile.TryGet<Vignette>(out vignette);
        volume.profile.TryGet<LensDistortion>(out lens);
        volume.profile.TryGet<ChromaticAberration>(out chromatic);
        vignette.intensity.value = MinVIntensity;
        vignette.smoothness.value = MinVSmoothness;
        lens.intensity.value = MinLDIntensity;
        chromatic.intensity.value = MinCAIntensity;
    }

    void Update()
    {
        if (sanity != sanitySave)
        {
            sanitySave = sanity;
            if (sanity <= SanityStartVInt)
                vignette.intensity.value = Calculate(MaxVIntensity, vignette.intensity.value, SanityStartVInt);
            if (sanity <= SanityStartVSmooth)
                vignette.smoothness.value = Calculate(MaxVSmoothness, vignette.smoothness.value, SanityStartVSmooth);
            if (sanity <= SanityStartLDInt)
                lens.intensity.value = Calculate(MaxLDIntensity, lens.intensity.value, SanityStartLDInt);
            if (sanity <= SanityStartCAInt)
                chromatic.intensity.value = Calculate(MaxCAIntensity, chromatic.intensity.value, SanityStartCAInt);
            multiplierSanity += multiplierSanityPerPoint;
        }
    }

    float Calculate(float maxValue, float value, int sanityStart)
    {
        var multiplier = 1 + (multiplierSanityPerPoint * sanity);
        var one = (maxValue / sanityStart) / multiplier;
        return (one + value);
    }
}
