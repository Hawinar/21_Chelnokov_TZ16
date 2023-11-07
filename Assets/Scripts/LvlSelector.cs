using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlSelector : MonoBehaviour
{
    [SerializeField] private Button _btn;
    [SerializeField] private int _lvlId;
    void Start()
    {
        if (_btn.GetComponent<Image>().color != new Color32(127, 127, 127, 127))
        {
            _btn.onClick.AddListener(() => GoLevel(_lvlId));         
        }
    }

    // Update is called once per frame
    private void GoLevel(int Id)
    {
        SceneManager.LoadScene($"Level{Id}");
    }
}
