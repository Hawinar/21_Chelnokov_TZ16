using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
    private Button _skinBtn;
    [SerializeField] private int _skinId;
    [SerializeField] private int _price;
    [SerializeField] private TextMeshProUGUI _priceTMP;

    void Start()
    {
        _skinBtn = GetComponent<Button>();
        _skinBtn.onClick.AddListener(() => TryBuy());
    }
    private void TryBuy()
    {
        if (GameManager.Money >= _price && GameManager.Skins[_skinId] == false)
        {
            GameManager.Money -= _price;
            _priceTMP.text = _price.ToString();
            GameManager.Skin = _skinBtn.image.sprite;
            GameManager.Skins[_skinId] = true;
        }
        if (GameManager.Skins[_skinId] == true)
        {
            GameManager.Skin = _skinBtn.image.sprite;
        }
    }
}
