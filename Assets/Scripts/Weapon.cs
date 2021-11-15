using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected float pause;
    [SerializeField] protected int maxClipAmount, maxBandolierAmount;
    [SerializeField] protected Transform shotPoint;
    [SerializeField] protected float bulletSpeed;
    protected float lastShotTime;
    protected int currentClipAmount, currentBandolierAmount;

    protected void Awake()
    {
        currentClipAmount = maxClipAmount;
    }

    public void TryShoot()
    {
        if(lastShotTime + pause <= Time.time)
            Shoot();
    }

    protected abstract void Shoot();
    public void Reload()
    {
        //TODO: animation
        currentClipAmount = Mathf.Min(currentBandolierAmount, maxClipAmount);
        currentBandolierAmount = Mathf.Max(0, currentBandolierAmount - maxClipAmount);
    }
}
