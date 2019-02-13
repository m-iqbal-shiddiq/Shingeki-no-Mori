using UnityEngine;

public class CameraControl : MonoBehaviour {

    public float kecepatan = 30f;
    int counter = 1;

    private void Update()
    {
        if (GameControl.gameBerakhir)
        {
            this.enabled = false;
            return;
        }

        if(Input.GetKey("d"))
        {
            transform.Translate(Vector3.left * kecepatan * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.right * kecepatan * Time.deltaTime, Space.World);
        }
    }

    public void Kiri()
    {
        if (GameControl.gameBerakhir)
        {
            this.enabled = false;
            return;
        }
        transform.Translate(Vector3.right * kecepatan * counter, Space.World);
    }

    public void Kanan()
    {
        if (GameControl.gameBerakhir)
        {
            this.enabled = false;
            return;
        }
        transform.Translate(Vector3.left * kecepatan * counter, Space.World);
    }
}
 