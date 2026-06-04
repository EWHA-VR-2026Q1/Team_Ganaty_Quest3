using UnityEngine;
using ExpObj; 

public class ExplodeTrigger : MonoBehaviour
{
    [Header("power")]
    [Tooltip("1~5")]
    public float breakForce = 3f;

    private ExplosiveObject explosive;

    void Start()
    {
       
        explosive = GetComponent<ExplosiveObject>();
    }

  
    void OnCollisionEnter(Collision collision)
    {
     
        if (collision.relativeVelocity.magnitude > breakForce)
        {
          
            if (explosive != null)
            {
                explosive.Explode();
            }
        }
    }
}