using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ChooseNameView : AnimateShowAndHideView
{
    [SerializeField] TMP_InputField inputName;
    [SerializeField] Toggle toggleMale, toggleFemale;
    [SerializeField] Button _buttonGenerate, _buttonNext;

    public event Action GenerateName;
    public event Action GoNext;
    public event Action<string> ChooseSex;
    public event Action<string> ChooseName;

    private void OnEnable()
    {
        _buttonGenerate.onClick.AddListener(GenerateNamePressed);
        _buttonNext.onClick.AddListener(GoNextPressed);
        _buttonNext.onClick.AddListener(_audio.PlayDone);
        toggleMale.onValueChanged.AddListener(ChooseSexPressed);
        inputName.onDeselect.AddListener(ChooseNameInputed);
    }

    private void OnDisable()
    {
        _buttonGenerate.onClick.RemoveAllListeners();
        _buttonNext.onClick.RemoveAllListeners();
        toggleMale.onValueChanged.RemoveAllListeners();
        inputName.onDeselect.RemoveAllListeners();
    }

    public void SetName(string text) => inputName.text = text;

    private void GenerateNamePressed() => GenerateName?.Invoke();

    private void GoNextPressed() 
    {
        if(inputName.text.Length > 1)
            Hide(GoNext);
        else
            GoNext?.Invoke();
    }

    private void ChooseSexPressed(bool isOn)
    {
        string gender;
        if (isOn)
        {
            gender = "�";
        }
        else
        {
            gender = "�";
        }
        ChooseSex?.Invoke(gender);
    }

    private void ChooseNameInputed(string text) => ChooseName?.Invoke(text);

}
