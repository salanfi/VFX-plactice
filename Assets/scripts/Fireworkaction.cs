using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Fireworkaction : MonoBehaviour
{
    [SerializeField]private VisualEffect effectvfx;
    [SerializeField]private VisualEffect firework;
    [SerializeField] private VisualEffect botanfirework;
    // Start is called before the first frame update
    void Start()
    {
        effectvfx.SendEvent("OffPlay");
        effectvfx.SendEvent("OffPlay");
        effectvfx.SendEvent("OffPlay");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            effectvfx.SendEvent("OnPlay");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            effectvfx.SendEvent("OffPlay");
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            botanfirework.SendEvent("OnPlay");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            botanfirework.SendEvent("OffPlay");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            firework.SendEvent("OnPlay");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            firework.SendEvent("OffPlay");
        }
    }
}
