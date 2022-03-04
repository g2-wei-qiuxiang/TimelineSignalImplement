using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayParticleReceiver : MonoBehaviour, INotificationReceiver
{
    [SerializeField] 
    private Transform positionObject = null;
    
    [SerializeField] 
    private ParticleSystem[] particles = null;
    
    /// <summary>
    /// 通知
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="notification"></param>
    /// <param name="context"></param>
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        var marker = notification as PlayParticleMarker;
        if (marker == null || particles == null || particles.Length <= marker.Index)
        {
            return;
        }
        var particle = Instantiate(particles[marker.Index]);
        particle.transform.position = positionObject.transform.position;
        particle.Play();
    }
}
