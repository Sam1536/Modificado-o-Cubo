using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public Vector3 pos;
    public float scale;
    //public Color mat;
    //public Color mat2;
    public Vector3 rot;

    public float timer;
    public Color[] colors;
    public Color[] colors2;
    public float sceneload = 30f;

    void Start()
    {
        transform.position = pos;
        transform.localScale = Vector3.one * scale;

        //Material material = Renderer.material;
        //  material.color = mat;

        if(colors.Length == 0)
        {
            return;
        }
        else
        {
            StartCoroutine(ColorTime());
        }

        Color c = colors[Random.Range(0, colors.Length - 1)];
        
        GetComponent<Renderer>().material.color = c;

      
    }

    IEnumerator ColorTime()
    {
        yield return new WaitForSeconds(timer);
        if (colors2.Length == 0)
        {
            //return;
        }
            Color c = colors2[Random.Range(0, colors2.Length - 1)];
            GetComponent<Renderer>().material.color = c;

        yield return new WaitForSeconds(sceneload);
        SceneManager.LoadScene(0);
        Debug.Log(sceneload);
        //Material material = Renderer.material;
        //material.color = mat2;
    }
    
    void Update()
    {
        transform.Rotate(rot);
      
       // StartCoroutine(ColorTime());
    }
}
