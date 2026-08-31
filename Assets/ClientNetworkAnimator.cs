using Unity.Netcode.Components;
using UnityEngine;

public class ClientNetworkAnimator : NetworkTransform
{
    protected override bool OnIsServerAuthoritative()
    {
        return false;
    }
}
