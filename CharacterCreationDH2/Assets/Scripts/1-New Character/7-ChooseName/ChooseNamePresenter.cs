using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Zenject;

public class ChooseNamePresenter : IPresenter
{
    private List<string> _maleNames = new List<string>()
    {
        "�����","�����","����","�������","������","��������","�����","�����","���������","������","�����","��������","����","������","�����",
        "����","����","������","������","������","������","����","�����","�����","�����","������","����","����","����","�������","���������",
        "�������","�������","����","���","������","�����","�����","�������","�������","�������","������","�������","�����","��������","����",
        "���������","��������","�����","�����","������","������","������","�����","�����","�������","������","�����","�����","�������","�������",
        "�����","�����������","�����������","����","����","��������","�������","�����","�����","����","�������","����","�����","�������","������",
        "�������","�����","�������","�����","�����","������","����","�������","��������","��������","�����","����","������","�����","��������",
        "�����","������","������","�������","��������","���������","��������","�����","��������","����","���������","�����","�����","�����",
        "��������","�������","��������","���������","�������","������","�������","������","����������","�������","�������","������","�������",
        "�������","�����","��������","��������","��������","������","�����","�����","���������","���������","�������","��������","�������","����",
        "��������","���������","�������","����","������","�������","���������","��������","��������","�������","�������","���","������","���������",
        "������","�����","������","������","����","�����","������","�������","�����","��������","�����","������","�������","�������","�������",
        "������","��������","����","����","������","������","��������","��������","����","��������","�����","������","�����","������","�����",
        "������","�����","���","������","������","��������","������","���","��������","�����","��������","������","�����","������","������",
        "�������","������","�������","�����","�����","���","��������","���","�����","�������","������","�������","�������","�������","�����",
        "�������","�������","�������","������","�������","��������","�������","�����","��������","����","�������","������","������","�������",
        "������","������","�����","�����","�������","������","����","������","�����","���","����","�����","����","�����","�����","����","�����",
        "�������","�����","�������","�������","�����","������","���","�����","������","�������","����","�����","�������","�����","�������",
        "������","�������","�������","�������","�����","��������","������","������","����","�����","����������","���������","������","�����",
        "���","�����","�����","�����","�������","�������","����","������","������","���","�����","�������","����","�����","������","��������",
        "�����","������","������","�����","������","�������","���","������","�������","�����","�����","����","������","������","���","���",
        "������","�������","�����","�������","���������","����","�������","����","�������","���������","���������","������","����������","������",
        "��������","����������","������","������","�������","����","���������","������","������","���","�����","�����","�����","����","�������",
        "������","�������","��������","�������","���","����","�����","������","�����","�������","������","������","�����","�������","����������",
        "������","���","�����","�����","�������","����","������","�����������","�����������","������","������","������","���","�����","������",
        "�����","����","������","����","�������","������","������","������","������","��������","�����","�������","��������","��������","������",
        "�����","�����","�����","��������","���","�����","��������","������","��������","����","������","������","������","������","������",
        "��������","�����","������","��������","�����","�����","�������","�����","�����","����","������","������","�������","������","�������",
        "�������","������","�������","�����","���","�����","�����","������","�������","������","�������","������","�������","����","����","�����",
        "�������","������","�������","�����","�������","����","�����","�����","��������","�����","������","�������","�����������","������",
        "�������","��������","�����","��������","����","�����","������","��������","�����","������","��������","��������","��������","������",
        "������","�����","�����","��������","�������","��������","������","��������","����","�����","�������","�������","�����","������","�����",
        "������","�����","�����","�������","������","������","�������","�����","�����","���","�������","�����","�����","������","������","������",
        "������","�����","�����","���������","�����","�������","������","������","�����","�����","���","�����","�����","�����","�������","������",
        "������","������","����","�������","��������","���������","��������","���������","���������","���������","�����","�������","��������","�����",
        "�������","������","�����","���������","�����","�����","������","�������","�������","��������","�������","������","��������","���������",
        "������","������","������","�����","������","�����","����","������","�����","�����","��������","�����","�������","�������","������","��������",
        "�����","������","������","������","�����","�������","�����","���","�������","�����","�����","������","������","������","��������","����",
        "�����","������","�����","������","�����","�����","������","�����","�������","�����","������","��������","��������","���������","������",
        "�����","�������","������","���������","����","�����","����","�������","����","����","�����","�����","�������","��������","�������",
        "���������","������","������","������","������","���������","������","�����","������","����","������","������","�����","������","������",
        "������","�����","����","��������","�����","����","������","�����","����","����","����","�����","����","����","����","����","��","�������",
        "������","�������","����"
    };

    private List<string> _femaleNames = new List<string>()
    {
        "�������","���������","�������","������","������","�������","������","�����","������","�����","�����","�������","������","�����","���������",
        "������","���","��������","�������","������","�����","���������","�����","�������","��������","���","������","�����","����","�������","�������",
        "������","�����","�����","��������","�������","�������","�����","������","��������","����������","������������","����","�����","�����","�����",
        "�����","�����","�����","�����","����","����","����","������","�����","��������","�������","�������","��������","������","��������","���","������",
        "�����","������","������","�����","�����","�����","�����","���������","��������","��������","�����","������","��������","����������","������","������",
        "�����","����","��������","������","�����","�����������","���������","��������","�������","������","�����","��������","�������","������","�����","�����",
        "����","������","�����","������","���","�������","��������","������","����","������","�����","��������","�������","�����","���������","���������","�����",
        "������","������","�������","������","���������","���������","����������","���������","�������","�����","�������","�������","��������","��������","�����",
        "�����","������","����","������","��������","��������","��������","�����","�������","�����","����","�����","����","������","���������","��������","������",
        "������","�������","��������","��������","��������","�������","����","��������","�����","����������","��������","����������","����","��������","���������",
        "������","�����","�����","������","������","��������","�����","���������","��������","����","�����","��������","�������","��������","������","����","������",
        "������","���������","�������","�����","������","�����","��������","�������","��������","�������","����������","������","��������","�����","�����","������",
        "����","�������","�����","�����","������","����","�������","������","�����","�����","�������","����","�����","������","�������","������","�����","������",
        "��������","������","���������","��������","�����","������","���������","�����","������","�������","��������","����","����","������","������","�������",
        "��������","����","����","�������","����","��������","�����","����","�����","���","����������","�������","�������","���������","�������","���������",
        "�����","���������","��������","������","������","������","������","�����","������","���������","��������","����","������","�����","������","������",
        "����","������","������","�������","�������","�������","����","�����","����������","������","���","�������","�����","������","�����","������","�����",
        "���","��������","�������","������","�����","����","������","�����","�����","�����","����","����","���������","������","������","����","������",
        "�������","������","�����","�����","����","����","�����","�����","�����","�����","��","�����","�����","�������","�������","������","����������","����",
        "�����","������","������","�����","����������","��������","��������","��������","�����","����","�������","�������","�����","�������","��������",
        "����������","����������","����������","��������","����","��������","����","��������","������","����","�����","����","�����","����","������","�������",
        "����","������","�����","�����","������","����","��������","�������","����","����","���","�����","�����","�����","����","����","����","�������",
        "�����","����","����","�����","������","�����","����","���","����","������","����","�����","�������","�����","������","������","������","��������",
        "�������","��������","�����","����","������","�����","���������","������","����","������","��������","������","����","��������","���������",
        "��������","������","������","������","��������","������","�����","������","���������","�����","�������","������","�����","������","�������",
        "���������","��������","������","�������","�������","�������","�������","�������","������","����","����","������","������","�����","������",
        "������","������","��������","���������","����","������","�����","�������","���������","�����","���������","��������","������","���","���",
        "�����","������","����","�������","����","��","�������","������","�����","����","�������","������","�����","�����","����","�����","�����",
        "�������","�������","�������","����","����","�����","�������","�������","��������","����","�����","���������","������","����","�������",
        "����","������","�����","���","����","�����","����","�����","�����","������","������","�������","���������","�����","������","���������",
        "�����","������","�����","�������","������","��������","��������","�������","�������","��������","������","���������","����","�������",
        "���������","���������","�����","������","������","���","�������","������","����","������","�����","�����","����","����","�������","�������",
        "����","��������","�������","���������","�������","������","����������","�������","�������","������","�����","��������","�������","������",
        "������","�������","������","�����","�������","������","�����","������","�����","�����","����","�����","����","������","��������","����������",
        "������","��������","������","��������","������","������","�������","����","������","�����","�������","�����","����","�����","�����",
        "����������","������","��������","�������","�����","������","����","������","������","����","�������","�������","������","����","������",
        "����","������","������","������","������","�������","�����","�����","�����","����","������","������","���","�����","�������","������","������",
        "�����","���������","���������","���������","�����","������","������","������","����","��������","������","�������","�������","�����","�������",
        "������","������","��������","�����","�����","�����","�������","�����","����","�����","��������","������","�����","�����","����","������",
        "������","�������","�������","�����","�����","�������","�������","���","�����","������","����","�����","���������","����������","�����","�����",
        "�����","����","���","����","�����","������","������","���","�����","�����","����","�����","��������","������"
    };

    private List<string> _secondNames = new List<string>()
    {
        "������","����","��������","�������","�������","������","��������","�����","�������","����","������","�����","�����","���������","��������",
        "�������","�������","����","�������","�����","����������","������","��������","��������","��������","�������","������","�������","�������",
        "��������","�����","�����","����","������","�����","������","�����","�����","����","�������","�����","�����","�����","�����","�������","�����",
        "�����","�������","������","����","����","������","����","��������","�����","������","������","���","��","����","����","�����","�����",
        "�������","�������","��������","������","���","�������","�����","������","�������","�����","����","������","���","������","������","�����",
        "�����","�����","�����","���������","������","�������","�������","������","������","�����","�����","�����","�������","��������","�����",
        "������","����","����","������","�����","������","�������","�����","�����","�������","�����","��������","������","������","�����","�����",
        "�����","������","������","������","���������","������","����","�������","�����","�������","�����","�����","�����","������","������","����",
        "������","����","������","�����","����","������","������","�����","�����","���","�����","�����","��������","���","�����","�������","������",
        "������","�������","�����","���������","������","�������","�������","������","�������","����","��������","����������","�����","���������",
        "����","������","������","��������","����","�������","�������","�����","�������","����","����","����","�����","������","�������","�����",
        "�����","������","������","��������","�����","����","������","����","�����","������-���������","������","�����","��������","������","�����",
        "������","�����","����","�����","�Ē������","Ē������","Ē������","Ē��������","����������","�������","�������","��������","������","������",
        "���������","�������","������","������","�����","�����","�������","�������","��������","������","�������","���������","������","����","����",
        "�������","���-�������","���","������","�����","������","������","�������","�����","������","�����","���","�����","����","�����","����","�����",
        "�����","����","����","�����","�������","������","������","����","�����","���","�����","��������","�����","�������","�����","������","�����������",
        "������","������","�������","���������","��������","���������","�������","�������","���������","��������","�������","�������","����",
        "�����","������","��������","��������","����","��������","������","����������","������","����","���","�������","������","����","������",
        "���","����","����","�������","�������","�������","������","���","����","�������","�����","����","��������","��������","�������",
        "���������","����","�������","�����","�������","������","������","��������","��������","�����","����","�����","����","������","������",
        "����","�����","�����","�������","������","����","������������","�����","��������","��������","����","�����","�����","�����","�����",
        "������","������","�����","������","�������","������","������","�����","��������","������","�������","������","������","����","��������",
        "����","�����","����","�������","��","����","������","���","�������","����","����","����","����","����","����","�����-����","�����",
        "����","������","�������","����","�����","�����","��������","����","������","���","�����������","��������","������","��������",
        "������","�����������","������","�������","����","�����","�����","���","�����","������","����","������","���������","������",
        "����-������","�����","����","����","����","�����","�������","������","�����","������","�������","����","������","�������","�������",
        "����","������","����","���","�����","������","�����","������","����","����","������","������","������","�������","�����","������",
        "������","������","������","������","�����","��������","����","�������","������","������","�����","���������","�������","��������",
        "������","�����","����������","����������","�������","������","�������","�����","�������","�������","������","�����","������","���",
        "������","�����","�����","������","������������","���������","������","������","�����","�������","����","�����","������","����",
        "�����","���������","����","�������","","���","�����","�������","�����","����","������","������","������","�������","������","�����",
        "�������","�����","�����","����","�����","������","�����","��������","�����","����","�������","������","����","�����","���","�������",
        "�����","�����","�����","�����","������","����","����","������","","������","�����","���������","�������","������","������","�������",
        "�������","�������","����","����������","�����","������","�������","���������","���","����","����","�����","����������","������",
        "������","���","�������","��������-�'������","���","�������","�����","���������","�������","��������","�����","������","���","������",
        "������","������������","�����","����","����","�����","��������","������","���","�����","��������","�����","����","��������",
        "�������","��������","�������","������","����","����","�����","������","�����","���-����","����-����","����-����","����-����������������",
        "������","�������","�����","����","�����","����������","����������","�����������","�������","�����","�����","��������","�����","�����",
        "�������","������","������","������������","����","������","���������","�����","�����","���","����","�����","������","��������","���",
        "�������","����","������","����","������","������","�����","���","����������","������","���������","�����","����","��������","���������",
        "������","�������","����","�������","�����","�����������","�����","�����","�����","�������","������","����","���������������","���",
        "����","�������","����","�����","�����","����","�����","����","�������","������","������","����","����","����","�������","�����","�����",
        "�����","�����","�����","������","���","������","�����","�������","������","����","������","�����","�������","�������","�������","�������",
        "�����","������","�����","������","������","�����","����������","���","�����","�����","�����","�������","�����","�����","�����","�����",
        "�������","������","�������","��������","��������","���","����","��","���"
    };

    public event Action<ICharacter> GoNext;

    private ChooseNameView _view;
    private CharacterWithNameAndProphecy _character;
    private AudioManager _audioManager;
    private string _name;
    private string _sex = "�";

    public ChooseNamePresenter(ChooseNameView view, ICharacter character, AudioManager audioManager)
    {
        _view = view;
        _character = (CharacterWithNameAndProphecy)character;        
        _audioManager = audioManager;
        Subscribe();
    }

    private void Subscribe()
    {
        _view.ChooseName += ChooseNameInputed;
        _view.ChooseSex += ChooseSexSelected;
        _view.GenerateName += GenerateNamePressed;
        _view.GoNext += GoNextDown;
    }

    private void GoNextDown()
    {
        if (_name.Length > 1)
        {
            //_audioManager.PlayDone();
            Unscribe();
            _character.SetName(_name);
            _character.SetGender(_sex);
            GoNext?.Invoke(_character);
            _view.DestroyView();
        }
        else
            _audioManager.PlayWarning();  
    }

    private void GenerateNamePressed()
    {
        _audioManager.PlayClick();
        
        if(_sex == "�")        
            _name = $"{_femaleNames[PoleChudes.GenerateIntValue(_femaleNames.Count - 1)]} {_secondNames[PoleChudes.GenerateIntValue(_secondNames.Count - 1)]}";
        
        else
            _name = $"{_maleNames[PoleChudes.GenerateIntValue(_maleNames.Count - 1)]} {_secondNames[PoleChudes.GenerateIntValue(_secondNames.Count - 1)]}";

        _view.SetName(_name);
    }

    private void ChooseSexSelected(string obj)
    {
        _audioManager.PlayClick();
        _sex = obj;
    }

    private void ChooseNameInputed(string obj)
    {
        _audioManager.PlayClick();
        _name = obj;
    }

    private void Unscribe()
    {
        _view.ChooseName -= ChooseNameInputed;
        _view.ChooseSex -= ChooseSexSelected;
        _view.GenerateName -= GenerateNamePressed;
        _view.GoNext -= GoNextDown;
    }



}
