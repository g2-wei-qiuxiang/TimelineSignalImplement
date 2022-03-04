using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class PlayParticleMarker : Marker, INotification
{
    public PropertyName id { get; }
    public int Index = 0;
}
