using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Fireworkaction : MonoBehaviour
{
    [SerializeField]private VisualEffect effectvfx;
    [SerializeField]private VisualEffect firework;
    [SerializeField] private VisualEffect botanfirework;
    [SerializeField] private VisualEffect fireworks2;
    [SerializeField] private VisualEffect beefireworks;
    // Start is called before the first frame update
    void Start()
    {
        effectvfx.SendEvent("OffPlay");
        firework.SendEvent("OffPlay");
        botanfirework.SendEvent("OffPlay");
        fireworks2.SendEvent("OffPlay");
        beefireworks.SendEvent("OffPlay");
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
        if (Input.GetKeyDown(KeyCode.V))
        {
            fireworks2.SendEvent("OnPlay");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            fireworks2.SendEvent("OffPlay");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            beefireworks.SendEvent("OnPlay");
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            beefireworks.SendEvent("OffPlay");
        }
    }
}
