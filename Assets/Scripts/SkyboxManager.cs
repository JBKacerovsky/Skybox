using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SkyboxManager : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown = null; 
    public MatStruct[] MatList; // using a struct[] makes it possible to expose key-value pairs for the Dictionary in the unity editor for manual editing of the skybox material dictionary
    private Dictionary<string, Material> MatDictionary;
    // Start is called before the first frame update
    void Start()
    {
        MatDictionary = new Dictionary<string, Material>(); 
        foreach (MatStruct i in MatList)
        {
            MatDictionary.Add(i.key, i.mat);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(MatDictionary.Keys.ToList());
    }
    public void OnChangeSceneSelection() => RenderSettings.skybox = MatDictionary[dropdown.options[dropdown.value].text];
}

// using a struct[] makes it possible to expose key-value pairs for the Dictionary in the unity editor 
// for manual editing of the skybox material dictionary
// normally I would put a public struct in it's own script. But this is a very short script and a verey short single use struct
[Serializable]
public struct MatStruct
{
    public string key; 
    public Material mat;
}