using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    private Shelf[] _shelves;

    private void Start()
    {
        _shelves = FindObjectsOfType<Shelf>();
    }
    private void Update()
    {
        for (int i = 0; i < _shelves.Length; i++)
        {
            if (_shelves[i].ItemsCount >= 3)
            {
                _shelves[i].Fall();
            }
        }
    }
    private void OnEnable()
    {
        Shelf.ItemSpawned += ConsoleMessage;
    }
    private void OnDisable()
    {
        Shelf.ItemSpawned -= ConsoleMessage;
    }
    private void ConsoleMessage()
    {
        Debug.Log("The next object was created");
    }
}