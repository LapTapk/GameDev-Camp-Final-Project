using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : CharacterLife
{
    protected override void Die()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
