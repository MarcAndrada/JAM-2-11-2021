using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuableObjectController : MonoBehaviour
{
    [SerializeField]
    bool anim;
    [SerializeField]
    private string AnimName;
    [SerializeField]
    private int RequiredCompanions;
    [SerializeField]
    private Vector3 FinalPos;

    public bool IsAnim() {
        return anim;
    }
    public int GetRequiredCompanions() {
        return RequiredCompanions;
    }

    public string GetAnimName()
    {
        return AnimName;
    }

    public Vector3 GetFinalPos() {
        return FinalPos;
    }
    
}