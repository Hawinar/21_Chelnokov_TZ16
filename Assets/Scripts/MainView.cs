using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private List<Button> _lvlButtons;

    private List<bool> _lvlStatus = new List<bool>();

    [SerializeField] private TextMeshProUGUI _balanceTMP;

    [SerializeField] private GameObject _shopUI;
    [SerializeField] private Button _goShopBtn;
    private void Start()
    {
        this.gameObject.SetActive(true);
        _shopUI.SetActive(false);

        PlayerPrefs.SetInt($"AvailableLvl_0", 1);
        for (int i = 0; i < _lvlButtons.Count; i++)
        {
            if (PlayerPrefs.GetInt($"AvailableLvl_{i}") == 1)
                _lvlStatus.Add(true);
            else
                _lvlStatus.Add(false);
        }
        for (int i = 0; i < _lvlStatus.Count; i++)
        {
            if (_lvlStatus[i] == true)
            {
                _lvlButtons[i].GetComponent<Image>().color = new Color32(127, 127, 127, 255);
            }
            else
                _lvlButtons[i].GetComponent<Image>().color = new Color32(127, 127, 127, 127);
        }
        int index = _lvlStatus.LastIndexOf(true);
        _lvlButtons[index].GetComponent<Image>().color = new Color32(197, 255, 131, 255);
        PlayAnimation(_lvlButtons[index].GetComponent<Animator>(), "Animations/BtnAnimController", "Animations/NextLvlAnim");

        _goShopBtn.onClick.AddListener(() => GoShop());
    }

    // Update is called once per frame
    private void Update()
    {
        _balanceTMP.text = GameManager.Money.ToString();
    }
    private void PlayAnimation(Animator animator, string fileName, string animName)
    {
        animator.runtimeAnimatorController = Resources.Load(fileName) as RuntimeAnimatorController;
        animator.Play(animName);
    }
    private void GoShop()
    {
        this.gameObject.SetActive(false);
        _shopUI.SetActive(true);
    }
}
