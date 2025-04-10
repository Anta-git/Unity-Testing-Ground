using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;
    [SerializeField, Range(10, 100)]
    int resolution = 10;

    private void Awake()
    {
        Transform point;
        float step = 2f / resolution;
        var position = Vector3.zero;
        var scale = Vector3.one * step;


        //Instantiate points along the xy axis
        for (int i = 0; i < resolution; i++)
        {
            point = Instantiate(pointPrefab);
            point.SetParent(transform, false);

            position.x = (i + 0.5f) * step - 1f;
            position.y = position.x;
            //Assign position and scale to point instance
            point.localPosition = position;
            point.localScale = scale;
        }
    }
}
