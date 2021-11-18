using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float pause;
    [SerializeField] protected int maxMagAmount, maxBandolierAmount;
    [SerializeField] protected float hipSpreadSemiAngle;
    [SerializeField] protected Transform shotPoint;
    [SerializeField] protected GameObject bulletPrefab;
    protected float lastShotTime;
    protected int magAmount, bandolierAmount;

    [Space]
    protected float gizmosSpreadDistance;

    protected void Awake()
    {
        magAmount = maxMagAmount;
        bandolierAmount = maxBandolierAmount;
    }

    public void TryShoot(bool isAiming)
    {
        if (magAmount > 0)
        {
            if (lastShotTime + pause <= Time.time)
            {
                if (isAiming)
                    AimedShoot();
                else
                    HipShoot();

                magAmount--;
                lastShotTime = Time.time;
            }
        }
        else if (maxBandolierAmount > 0)
            TryReload();
        else
            EmptyBandolierWarn();
    }

    public void TryReload()
    {
        if (maxBandolierAmount > 0)
            Reload();
    }

    protected void Reload()
    {
        magAmount = Mathf.Min(maxBandolierAmount, maxMagAmount);
        bandolierAmount = Mathf.Max(bandolierAmount - maxMagAmount, 0);
    }

    protected void EmptyBandolierWarn()
    {
        //TODO
    }

    protected abstract void AimedShoot();
    protected abstract void HipShoot();
}
