using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    [SerializeField]
    private GameObject _lamp;
    private void Awake()
    {
        var position = transform.position;
        Instantiate(_lamp, position, Quaternion.identity);
    }
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    
}