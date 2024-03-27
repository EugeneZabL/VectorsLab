using UnityEngine;

public class Move : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    [SerializeField]float speed = 5f;

    void Start() {


        //this.transform.Translate(6,0,7);
    }

    private void LateUpdate() {
        direction = goal.transform.position - this.transform.position;
        if (direction.magnitude > 2)
        {

            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
        this.transform.LookAt(goal.transform.position);
    }
}
