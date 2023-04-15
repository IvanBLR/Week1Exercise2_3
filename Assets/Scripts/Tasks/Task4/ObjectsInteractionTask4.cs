using UnityEngine;
using UnityEngine.Events;
public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField]
    private GameObject _waffle;
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    public void WaffleIsReady()
    {
        var position = transform.position;
        Instantiate(_waffle, position, Quaternion.identity);
        FindObjectOfType<Toaster>().GetComponent<Toaster>().enabled = false;
    }
}