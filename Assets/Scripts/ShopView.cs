using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopView : MonoBehaviour
{
    [SerializeField] private Button _goToMainMenuBtn;
    [SerializeField] private GameObject _mainUI;
    [SerializeField] private TextMeshProUGUI _balanceTMP;

    private void Start()
    {
        _mainUI.SetActive(false);
        _goToMainMenuBtn.onClick.AddListener(() => GoToMainMenu());
    }
    private void GoToMainMenu()
    {
        this.gameObject.SetActive(false);
        _mainUI.SetActive(true);
    }
    private void Update()
    {
        _balanceTMP.text = GameManager.Money.ToString();
    }
}
