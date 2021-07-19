using UnityEngine;
public class SceneElementManager : MonoBehaviour
{
    public void ToggleActive(GameObject gameObject) => gameObject.SetActive(!gameObject.activeSelf);
}