using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    // // Use this one for slide 8. Drag the Bullet prefab into this slot.
    // public GameObject bulletPrefab;

    // // Use this one for slide 14. Drag PoolManager into this slot instead.
     public SimplePool pool;

     private void Update()
     {
         // Use Keyboard.current instead of Input.GetKeyDown if your project's
         // Active Input Handling is "Input System Package (New)" only,
         // Project Settings > Player > Active Input Handling.
         if (Keyboard.current.spaceKey.wasPressedThisFrame)
             Fire();
     }

    private void Fire()
    {
        // Use this one for slide 8.
        // Instantiate(bulletPrefab, transform.position, transform.rotation);

        // Use this one for slide 14. Comment out the line above first.
        GameObject obj = pool.GetFromPool();
        if (obj != null)
        {
            obj.transform.position = transform.position;
            obj.transform.rotation = transform.rotation;
        }
    }
}
