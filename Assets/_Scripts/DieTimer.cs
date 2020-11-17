using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieTimer : MonoBehaviour
{

    public Transform HeartParticleTransform;

    // Start is called before the first frame update
    void Start()
    {
        HeartParticleTransform = gameObject.GetComponent<Transform>();
        Destroy(gameObject, 3);
    }

    private void Update()
    {

        HeartParticleTransform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 2 * Time.deltaTime, transform.position.z), 1);

    }

}
