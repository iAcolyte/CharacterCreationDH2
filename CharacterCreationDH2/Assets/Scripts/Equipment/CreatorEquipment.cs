using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorEquipment
{
    private List<Equipment> equipments = new List<Equipment>();
    private List<List<Equipment>> specialEquipments = new List<List<Equipment>>();
    //private List<Weapon> weapons = new List<Weapon>();
    //private List<Armor> armors = new List<Armor>();
    public CreatorEquipment()
    {
        //---------------------������������-------------------------------------------------------------------
        equipments.Add(new Weapon("�����������", "���������� � ��������, ������������ � ������� ������ ��� ��� ��������� ��������, ��� � ��� ������� ����.",
            "��������", 30,"O/2/-","1�10+2�", "0","30","����", "��������", "1.5"));
        equipments.Add(new Weapon("����-����", "� ������� �� ����-����������, ���� �������� ����� ������������ � �������������� ������������������ ������, " +
            "� ����� � ��������� ��������. ��� � ������������, ��� ����� ����������� � �����������, �� �� ����� ����� �� ������� �����������. ",
            "��������", 30, "O/3/-", "1�10+3�", "0", "9", "����", "", "1.5"));
        equipments.Add(new Weapon("��������", "��������� ������������ ����� � ������������, � �� ������� ������� �������� ������ �� ���������������� ��� ���, " +
            "��� �� ���������� � ������������� ���.",
            "������", 30, "O/-/-", "1�10+4�", "0", "8", "2����", "������", "5"));
        equipments.Add(new Weapon("�������", "������� � ��������� ���������� ���������� ������� �������������� ���������� � ����������������� ��������� � ����� ���� �������� ���������� ����������, " +
            "� ����� ��������� � �������� ���������, ��� ������ �� ��������� �� ��������������, ��������� ��� ������ � ������������ � ������������. ",
            "������", 100, "O/3/10", "1�10+3�", "0", "30", "����", "", "5"));
        equipments.Add(new Weapon("������ �����", "��� �������� �������������� ���������������� ������ ����� �� ��������������� ����. ��� ��������, ������ ������ � ��, ��� ��� ����������, " +
            "������ �� ��������� � ��������� ����� ���� ����� ��������. ������ ������ ����� ���������� ����� ������ � ���, ��� �� ���������� ��� ���� ��� �������������� ��������, " +
            "�������� -10 ����� � ��������� ������ �������� ",
            "��������", 35, "O/-/-", "1�10+4�", "2", "5", "2����", "��������", "3"));
        equipments.Add(new Weapon("������ ������", "��� �� ���������, ��� �������� ��������� ��� ��������, ��� ��������� ������ �������� ��� ��� �� ������� ���������, " +
            "��� �� ����� �������������� � �������� �������� ����� �����, ��� �� �������� ��������. ",
            "��������", 10, "O/-/-", "1�10+4�", "2", "2", "2����", "�����., ������.", "3,5"));
        equipments.Add(new Weapon("����-���������", "����-���������� ���������� ����������� ������ ��� ��������� ���������, � ��������� ����������, ������� ���������� ��������� �������. " +
            "�� �������� ����������� ��������� ����� �������� ����������� ���� � ������ ���������. ",
            "��������", 30, "O/-/-", "1�10+3�", "0", "6", "2����", "��������", "1,5"));
        equipments.Add(new Weapon("������", "������� � �������� ������ ������ ��������� �������, � �������� �������� ����������������� ����� ������������� ��������� ������. " +
            "��� ������ ��������� ����� � ���������. ����� ���������� �������� �� ������ ������ ����������, �������� ����������� � �������� ������������� ��������.",
            "������", 100, "O/3/-", "1�10+3�", "0", "60", "����", "��������", "4"));
        equipments.Add(new Weapon("������������", "���������� � ��������������. ������ ��������-��������� ����� �������������, ��� ���������� � �� �������� ������� ��� �������, ����� ��������� ������. " +
            "��� ��� �� ��������� � �������� �������� � ������ ������ ����� ������� ������� ������ ����. ",
            "��������", 30, "O/-/6", "1�10+2�", "0", "18", "����", "", "1,5"));
        equipments.Add(new Weapon("������������ (� ���. ����������)", "���������� � ��������������. ������������ � ������������ ����������. �������� �������� ��� �������� ������, ����� ���������� ������ ������ ��� �����������. " +
            "�����, ��� �������� ����� ��������������� ������ � ���������� ���������� �������� -20 ����� � �������� �� ���������� ������.  ",
            "��������", 15, "O/-/6", "1�10+1�", "0", "9", "����", "", "0,75"));
        //------------------------------------------------------------------------------------------------------------

        //-----------------�������---------------------------------------------------------------------------------------
        equipments.Add(new Weapon("������� ������", "����������� ���������� ������� ��������, ������� ������ ������ ������ �����������, �� ���������� ������� �� �������, " +
            "�������� �����, ��������� ���� ��� �������������� �������. ��� � ������ ������� ����������� ������, ���� ����������� ���������� ������ ����� ����� ������� ��� ��, ��� ������ ���. ",
            "����������", "1�10+3�", "0", "�������", "2.5"));
        equipments.Add(new Weapon("�����", "������ � ������� ����� �� ������ � �������, ����� ������� ������������� �����. ������ �� ���������� ��� ������ ���������, " +
            "�������������� �� ������ ������, �� ��� �� ��� ����� ���� ������� �������. ������ � ��������� ���������� ������. ",
            "����������", "1�10", "0", "����������������, �����������(7)", "3"));
        equipments.Add(new Weapon("����", "����� ������ ������������ � �������, ����������� ��� ��������� ��������� ��� ������ ���������� ������� �� ����. " +
            "��� ������ � �������� � ������ ���������� ����������� ���������, ��������� ����������, ����� ��� ������� �����, ���� ��� ������� ���������. ",
            "����������", "1�10", "0", "������, �����������(6)", "2"));
        equipments.Add(new Weapon("������ �����", "��������� ������ ��� �������� ������������� ������ ������� �������, ������ ����� ��� ���������� �������� �� ������� ������ ����� �������. " +
            "����� ������� ������ �������, ��� � ������ ������, �� ������ ���� �������� ������������������ ����� � ����� ���������� ���������� �� ����� �������������� � �����������. " +
            "������ � ���� ������� ������������ ������, ��������� ���� ������ � ������ ����. ��� ��������� ���������� ������. ",
            "����������", "1�10+3�", "1", "����������(1), �����������(8)", "4.5"));
        equipments.Add(new Weapon("���", "���� ���������� ���������� ����� ������ ��� �� ������ � ������. �� ����� ����� �����, �� ����������� ������� �� ������ �����. " +
            "�� ���� ���������� � �� ������� ������� �� ������ �����, �� ������������� ������� �� ������������ � � ������� ������ ��� ������������ ������� ��� � ����� ����������, " +
            "��������� ����������� �����. ",
            "����������", "1�10�", "0", "����������������", "3"));
        equipments.Add(new Weapon("������ ���", "�������� ���������������� ��� ������� ������, � ���� ������� ����� ��� ������������ ����������� ���� ������ ������ ���������� � ���� �������. " +
            "�������� �� �� ���������� �������, ������ �������� ����� ���������� ��������� ��������� ���� ������������ ��������� � ������� ������. ��� ������ �������������, ������, ������ ����� �������, " +
            "��� � ���������� ����������� ������, ������� ������ ����������� ����� � �����. ",
            "����������", "1�10+2�", "2", "���������, ����������������", "6"));
        equipments.Add(new Weapon("������ ������", "������ ������ � ���� �� ����� ��������� ����� ������� ������, ���� �������� ������ ����, � ��������� ����� �� ����. " +
            "������ ��������, ��������� ������ �� ����� ����� ������������ ������� ������� �������������, ��� ����� ������� ������. ",
            "����������", "1�10+1�", "1", "���������", "2"));
        equipments.Add(new Weapon("������� �����", "��� ������ �������������� ���, ��� ���� ������� ��� ����, ��������� ��������������� ��������� ��� �������� ����� ������. " +
            "���� �� �� ������������ ��� ���, �������������� ������������ ����� ���������� ����� ������ ��� ��������� ��������. ",
            "����������", "1�10+1�", "0", "������, �������", "3"));
        //-------------------------------------------------------------------------------------------------------------------


        //------------------------------�����-----------------------------------------------------------------------------------------
        equipments.Add(new Armor("˸���� ������� ��������", "������������� �� ����������� ������� �������� ��� ��������, ��������� ����� � ������ ����� �������� ��������� " +
            "������� ����� ��������� �������� � ��������. �������� ��� ����. ����� 5, ������������ �������� 45.", "�������� ��� ����", 5,5,5,5,45,15));
        equipments.Add(new Armor("��������� ���������", "������������� �� ����������� ������� �������� ��� ��������, ��������� ����� � ������ ����� �������� ��������� " +
            "������� ����� ��������� �������� � ��������. �������� ������ ������. ����� 6, ������������ �������� 55.", "�������� ������ ������", 0, 0, 6, 0, 55, 7));
        equipments.Add(new Armor("˸���� ����-����", "����-����� ��������������� �� ��������� ����� ����������� ������ � ����������������� ���������� � �������� �������� ����������� ��������� �� " +
            "����������� ������, �������� � �������� �����. ��������� ��������� �� ������� ������ ����� ����� ������� ��� �����, �� ����� ������ � ��������, ������ ��������� ������������ � " +
            "��������� � ���. �� �������� ������. ����� 2, ������������ �������� 55.", "�������� ��� ����� ������", 0, 2, 2, 2, 55, 8));
        equipments.Add(new Armor("����-�����", "����-����� ��������������� �� ��������� ����� ����������� ������ � ����������������� ���������� � �������� �������� ����������� ��������� �� " +
            "����������� ������, �������� � �������� �����. ��������� ��������� �� ������� ������ ����� ����� ������� ��� �����, �� ����� ������ � ��������, ������ ��������� ������������ � " +
            "��������� � ���. �������� ������ ������. ����� 3, ������������ �������� 60.", "�������� ������ ������", 0, 0, 3, 0, 60, 5));
        equipments.Add(new Armor("����-����� ����� ���������", "����-����� ��������������� �� ��������� ����� ����������� ������ � ����������������� ���������� � �������� �������� ����������� ��������� �� " +
            "����������� ������, �������� � �������� �����. ��������� ��������� �� ������� ������ ����� ����� ������� ��� �����, �� ����� ������ � ��������, ������ ��������� ������������ � " +
            "��������� � ���. ��� ������ �������� ��� ����. ����� 4, ������������ �������� 50.", "�������� ��� ����", 4, 4, 4, 4, 50, 11));
        equipments.Add(new Armor("������������� ����������", "���� ���� ��� ����� �� ����������� ����� ������� �������� �����������, ������ �� ��� ���������� �����." +
            "� ��������� �������������� ������� ������� ������, ����������������, ����� ��������, ������� �������, �������� ������ � ��������.  " +
            "�������� ��� ����� ������. ����� 2.", "�������� ��� ����� ������", 0, 2, 2, 2, 100, 5));
        equipments.Add(new Armor("��������� ������", "���� ���� ��� ����� �� ����������� ����� ������� �������� �����������, ������ �� ��� ���������� �����. " +
            "� ��������� �������������� ������� ������� ������, ����������������, ����� ��������, ������� �������, �������� ������ � ��������. " +
            "�������� ��� ����� ������, ����� 1.", "�������� ��� ����� ������", 0, 1, 1, 1, 100, 4));
        equipments.Add(new Armor("������ ������� �����", "���� ���� ��� ����� �� ����������� ����� ������� �������� �����������, ������ �� ��� ���������� �����. " +
            "� ��������� �������������� ������� ������� ������, ����������������, ����� ��������, ������� �������, �������� ������ � ��������. " +
            "�������� ������ ���� � ����. ����� 1.", "�������� ������ ���� � ����", 0, 1, 1, 1, 100, 5));
        equipments.Add(new Armor("�������� ����", "�������� ����� ����������� �� ����� ��������� �������������� �����, ���������� ������� �� ����� ��������. " +
            "�� ��������� ���������� ��������� ������� ��� �����, ��������� �����. ��������� ���������� ����������� ������� ���������, �� ���� ����� ������ ������������ ������ ������������ �������� ������. " +
            "�������� ��� ����� ������. ����� 4, ������������ �������� 60.", "�������� ��� ����� ������", 0, 4, 4, 4, 60, 3));
        equipments.Add(new Armor("����-����", "����-����� ��������������� �� ��������� ����� ����������� ������ � ����������������� ���������� � �������� �������� ����������� ��������� �� " +
            "����������� ������, �������� � �������� �����. ��������� ��������� �� ������� ������ ����� ����� ������� ��� �����, �� ����� ������ � ��������, ������ ��������� ������������ � " +
            "��������� � ���. �������� ��� ����� ������. ����� 3, ������������ �������� 55.", "�������� ��� ����� ������", 0, 3, 3, 3, 55, 8));
        //-------------------------------------------------------------------------------------------------------------------


        //-----------------�����--------------------------------------------------
        //equipments.Add(new Equipment("��������� ������", ""));
        equipments.Add(new Equipment("��������", "������� ��������� �������� �������������� � ������ ������, � ����������� � �������� ��� �������������� �������, " +
            "��� ���������� ��������� ���������� ����� ��� ���������������� ���� � ������������ ��������� � �������������. ������ ������ ����� ��� ���� ����������� ����������, " +
            "���������� ��� ������ ������� ������� ��� �������� � ����� ��������. �������� � ���������� ������� ������� ����� ������������ ��������, ��� � �������� +10 ����� � ���������, " +
            "���������� � ���� ������ ������. "));
        equipments.Add(new Equipment("�����", "����� � ��� ��������� ����, � ��� ���������� ��� ����, ����� ������� ����� ����������� � ������ �����. ������� ������ ������ ��������� ������� ����� � " +
            "������� ������ ���������, �� ����� ������������ ������ ����� ������������������ � �������� �������� ������ ��� ����������� ��������� ��������. "));
        equipments.Add(new Equipment("�����������", "������������ ������ �������������� � ���������. �� ������� ���������� � ������� � �������������� �������� ������ � ������ �����������, ����� ��� ����� � �����������. " +
            "������������ �������� �������� ����� �������������� ����������, ��� ������������ ������� � ������� ������������. "));
        equipments.Add(new Equipment("��������", "��������� �������� �������� �� ���������, �����������, ������������������ �������, ����� � ������ ����������� ��������. " +
            "����������� �������� ������������� ����� +10 ��� �������� ������, ���� � ��������� ���� ��������������� ������. " +
            "����������� ������ ����� �������� �������, ����������� ���������, ��������������� ���������� � ������ ������������������ ������������. " +
            "��� ������������� ����� +20 ��� �������� ������ (���������� �� ����, �������� �� �������� ���� �������), �� ����� ������������� 3 ���������� � ����� ������ ����������� ������ �������. "));
        equipments.Add(new Equipment("��� ���� ������", "���� ������ ����������, ��� � ���� ������� ����������� � ������ ���� ��������������� ����������, ������� ����� ������� ��� ����, " +
            "��� �� �������� ������������ ������� � ��������� ����������. ������ ���� ������ ������ 3�10 �������. �� ���������� ����� ������� �������� ���������� " +
            "����� �������� ������������� �� ����� � ������������ �����, � ����� ���� �� ����� ���� �������. ����� ������ ������ �������������, �������� �������� ����� -20 � ��������� ����, " +
            "������������ � �������� �� ���� ���, � ��� �� �������� ���� ������� ���������. ����� �������� �����������. "));
        equipments.Add(new Equipment("���������", "������ ��������� �������� �� �������� ��� �������� ��� ���������� ���������� ���� ������� �������������, ���� ������� �� ����������, " +
            "���� ��������� ������ � ������ ������ ��� ��� ������, ����� ����� �����. ���������� � ��������� �������� �������� ����� -40 �� ���� ��������� ������ �������� � ������ ����������. "));
        equipments.Add(new Equipment("12 ������� ���", "������ ��������. ������ �������� �������� ������� ������ ��������, ������� �������� ���������, ������������� ��� ��� ������������� � " +
            "�������� ����� ������� ��������, ������� ������� ������ � ����������. ��������� ������ �������� � ����������� �� �������, ��� ��� �� ����� �������� �� ���� � ����, ��� ����� ������ " +
            "�� ��������� ���������� ��� ��������. "));
        equipments.Add(new Equipment("�����-�������", "��� �� ���������, ��� ����-������, ��� ��������� ���������� ������� � ���� � ��������� ����� ���������� �������� � �������� ��������� " +
            "(� ����������� �� ������ � ���������). ������ �� ��� ����������� ����� � ���, � ������ ����� �������� �������� ����� ���������� ���������� ��� ������� �������. "));
        equipments.Add(new Equipment("���-�����", "������ �������� ���������� ��� ��������� ������������������� ��������, ����� �������� ���� ����� ���, ��� �������� � ������� ����� �����. " +
            "��� ���� ���������� ��������� � ������� �� ������ ���������� ����������� ���������� ��������� ��� �������, ��� ��������� �� ����������� �������������� ���� �����������. " +
            "����� ������� � ���-������� ������ �������� ����������� ����, �� �������� ����� +10. "));
        equipments.Add(new Equipment("������������ �����-�����", "������������ ������ ������������� ��� ����� �������� ������� � �������� ������������ �� ������ �����. " +
            "������ �� ��� �������� �� �������� ��������� �������, � ���� �� ������� ����, ���������� ������ ��������� ����� �� ����� ��������. "));
        equipments.Add(new Equipment("���������� �������������", "����� ������� �� ����� ������, ������������ ������, � ������� ���� ����-������ � ������ ��������� �������������� ��� ������� � �����������. " +
            "�� ����� ���������� �� ��� ������ ��� ����� +10 �� ���� ��������� ����������, ���������� �� ������. ������������� �� ���� ������������� ����-���������� ��������� ����������� " +
            "����������� �� ���������������� ������, � ����� �������������� ��� ���������� ������. ������ ����� ������������� ������� ������������ ������� � ��������� � ���������� � 40 ������. " +
            "� �������� ���� ������� ��������, ������������ ����� ������������� �� �������� ������� � �������. �������� �� �����, ������������� ������� �������, ������� ����� ������� ����� ������ " +
            "�� ������� �������. "));
        equipments.Add(new Equipment("��� ����� ��������� ������", "��������� �������� �����, �������������� ���������, ������ ������� �� ������������� ��������, ������� ��� ��������� " +
            "�� ���������� ����� ������. ���� ������� �� ������ (�� ������ ��������), �� ������ �������������� �� �����, � ������� ���������� ���������, ������� ������� �������� ����� ������. " +
            "���� ������� ��� ������� ������, �� �������� ��� �� �����������, �� ��������� ������ �� ��������� �������� ��������������� �������. "));
        equipments.Add(new Equipment("������", "��������� �������� ������������� ������ �������� 30 �� ����, �� ��� �� ������ ���� �� ������� ���������� ��������� ������ ��������. " +
            "������������ ����� ������ ������ ���� ������ ��� ������������ �����. "));
        equipments.Add(new Equipment("�����-���", "��������� ����� ������ �������� � ����� � ����� �������� ������� � ������� ������ � �������, " +
            "����� �������� �������� ���� ����� �� ����, ��� �� ������� ��������� ����������� ��� ������. "));
        equipments.Add(new Equipment("������������ �����", "����� ��� ������� ��������� 15 ��. �� ����� ���� ��������� ��������, ����������� � ������������ ������, ����� ������� �� ��������� ��������. " +
            "������������ ����� ������ ������ ���� ������ ��� ������������ �����. "));
        equipments.Add(new Equipment("�����������", "��� ������ ��������� ������, ������� ����������� ����������� ��������� ��������. ����������, ��� �� ���� ����� �� ��������� ������������. " +
            "����� ����������� ����������� �������� �������� ����� ��� �� ��������� ����������, ������������ ��������� �����, ��������� ������� ���� � ������ ����-������ ��� ������������ �������. "));
        equipments.Add(new Equipment("��������", "������ ���������� ��������� ���������� ��� �������� ����, ����� ��� �����, ����������� ��� ������� �����. " +
            "������ �� ��� ����� ��������� ���� ���� ������ ���������, ������� �������� ����� ������ �� ������������. "));
        equipments.Add(new Equipment("�����", "�������������� ����� ���������� ����� ���������� ���, ���������� ����� ������ �������. " +
            "����� �������� �������� ���� ����� �� ����, ��� �� ������� ��������� ����������� ��� ������. "));
        equipments.Add(new Equipment("����������", "��� ���������� ������ � ������������� ��������� ��� ������� ������ ����� ����� � ������� ���������, ��� ������������� ��� ������ �������� ���� � " +
            "����� ��������� ��������� � ���� ��������� ��� ������ ��� �����. ������, ������ �������� ����������� �������� ����� ������� ���� �� ���� ��� � ������ ���� ������������ ��������, " +
            "��� �������� ������ ��������. ������ �������� �������� ��������� ��� ����, � �� ����� ��� ������� �������� ������� ���� ������ �������� ��� ������ ��������. " +
            "������� �������� ����� ���������� �����������. "));
        equipments.Add(new Equipment("����� ����������", "������ �� ���� ������� ������������ ��� ��������� ���������� �� ������������ � ��������������. ����������� �������� ���������� ����������� " +
            "����� �����, ����, ��������, ���������, ������, ����������, ��������� ����� � ������ ��������������, ����������� ��� ��������� ������. �������� � ������� ���������� �������� " +
            "����� +20 �� ���� ��������� �������. "));
        equipments.Add(new Equipment("������������� �����", "������� ����� �������� ���� �������� �������� �� ����� �������������, ���� �������� ����� ��������, ���� ����������� �������. " +
            "���� ����� �������� ���������: � ������� ������: ���� ����� +10 ��� ��������, ��������� ��� ���������� ���������� ���������. � ��������� ��������������: ��������� ��������� " +
            "�������� ���� �� ��������� � ������ ���������: ��������� ��������� �������� ���� �� �������� � ��������� ������ ����. � ��������� �����������: ������������� ����� +10 ��������� " +
            "������ � ����� ����������� ������ �����. � ������� �����: ��������� ��������� �������� ���� �� �������� � ��������� ������ ����. "));
        equipments.Add(new Equipment("��� ���� �����", "���� ������ ����������, ��� � ���� ������� ����������� � ������ ���� ��������������� ����������, ������� ����� ������� ��� ����, " +
            "��� �� �������� ������������ ������� � ��������� ����������. ������ ���� ������ ������ 3�10 �������. �� ���������� ����� ������� �������� ���������� " +
            "����� �������� ������������� �� ����� � ������������ �����, � ����� ���� �� ����� ���� �������. ����� ������ ������ �������������, �������� �������� ����� -20 � ��������� ����, " +
            "������������ � �������� �� ���� ���, � ��� �� �������� ���� ������� ���������. ����� �������� �����������. "));
        equipments.Add(new Equipment("�������", "�������� ���������� ��������� �������� ��������� ��� ��������, ����� ������������ ���� ��� ��������� ������ �� ������� (100 �), ������� �����. " +
            "�������� �������� � ������ �����, �������� �� ����������� �����, ����� ������� ����������� �� ������� ��� ������������ ������� ���������, " +
            "������� ����� ��������� ��������� �������������� �� ���� ������ �� �����. "));
        equipments.Add(new Equipment("��� ���� �������", "���� ������� ��� ���������, ������� ���������� ������������� �� ������ ������ ��������������, ��� ����� ������ ��������� �� ���������� �����, " +
            "� ����� ����� �����������, ������ ���������� �� �������� ������� �����. ��������, ��������� �������, �������� ������� � ������� 1�5 ����� " +
            "(� ������ �������� ��������� ����������� ��� ��������� ��������������� �������). ����� ��������� ������� �������� ������� � �������� ��������� �� 1�10 �����, ���� �� ������ ������ ���� " +
            "�������. ������� �������� �����������. "));
        equipments.Add(new Equipment("��� ���� �������", "���� ������� ��� ���������, ������� ���������� ������������� �� ������ ������ ��������������, ��� ����� ������ ��������� �� ���������� �����, " +
            "� ����� ����� �����������, ������ ���������� �� �������� ������� �����. ��������, ��������� �������, �������� ������� � ������� 1�5 ����� " +
            "(� ������ �������� ��������� ����������� ��� ��������� ��������������� �������). ����� ��������� ������� �������� ������� � �������� ��������� �� 1�10 �����, ���� �� ������ ������ ���� " +
            "�������. ������� �������� �����������. "));
        equipments.Add(new Equipment("��� ���� ������", "������ '�����' ���������� ��������� �������� ���������������� ��������, ��������������� ��������� �� �������, " +
            "������������� � ���� �����������, ������� ��������� � ��������� �� ����� ������� ����. ����� �������� ���� � ��, � ��������� �� ���� ������ �� ������ �� �������� �������, " +
            "����� � ������� ��������. ���� �������� ������ �����, �� ����������� ������������ ������ ���������, ������� ��������� � �������������� �������. "));
        equipments.Add(new Equipment("��� ���� �����", "���� ��������, ��� �� ��������� ��� �������, ��������� ��������, �������� �������� ������� � ��������� �������� ���������� ���, " +
            "�� ��� ��������������� ������������� �������� ��������� � ������� �����������. ���� ���� ����������� ����� �������� � ���������� �� 3 �� 2�10 �����. " +
            "�� ��������� ��������, �������� ������ ������� ������ �������� ������������ ��� �������� ����� -20 � ��������� �������� � ���������� �� 1�5 �����. ����� �������� �����������. "));
        equipments.Add(new Equipment("��� �������� ������������ ����", "��� ������� ���� ������������ ����� �����, �������� ��������� �������� ���� �������� �������� � �������� ��� ���, ��� �� ����������� � ����� � ������ ����. " +
            "������: ������������ ���� ��������� +1 � ����� ������ � +1 � �������������. "));
        equipments.Add(new Equipment("��� �������� ����������� ����", "��� ������� ���� ������������� ��� ������������� ������ ��������� ����� ������ �����. ������: �������� ������������� �� 3. "));
        equipments.Add(new Equipment("������� �������", "� ������� �������� ������������ ��� �� ��������������� ������� ������� �������, ����������� ��������� ����� � ������ ������, " +
            "��� � � ������� ������. ������� ������� ���������� �������� � ������������� ����� �5 �����. "));
        equipments.Add(new Equipment("�����-����������", "����������� �����-������������ ������������ ����� ��������� ���������� ����������, ����������� ��������� � ����������� ������, " +
            "��������, �������� � ���������. ��� �������� �������� ��� ������������ ���������� �����, ������� ������������ ��������� �, � �����, ��������� ��������� �������� ����� �� ������� ���������. " +
            "��������, ������������ �����-����������, �������� ����� +10 � ��������� ��������������. "));
        equipments.Add(new Equipment("�������-�������", "�������, ����������� � ������ ������, ����� ��������� �������� ������������ � ������� ����. ��������, ������� �������-�������, " +
            "�������� ����� +20 � ����� ��������� ������������ � ����� ������������� �������� �����. ������� �������� ���� ������������� +10, � �� ����� ��� ������ ������� �������� ������ " +
            "���� �������� ����� ���� ����� �������������, ��� ��� ������ ���������� � ���������� ��� �������������. "));
        equipments.Add(new Equipment("�������", "��� ����������� ��������� ���������� ����������� ������������ ��� ��������� ��������� �������, ��������, ��������� ������������� ����� � " +
            "������ ����������. ��������, ������������ ������, �������� ����� +20 � ��������� ������������ � ����� ��������� �������� �������������� �� ��������� ��������, ����� ������������ ����� ��� " +
            "����������� �����, ����������� ������������ ��������, �������� ��������� ����, ������� �������� ����� ��� ���������� ��������. "));
        equipments.Add(new Equipment("����������", "������� ����������� �����, ����������� ��� � ��� ��� ��� ����, ����������� ������� ������ ������, ��� �������-�������. " +
            "��������, ���������� ����������, �������� +30 ����� � �������� ������������ �� ������������� ����������� ����, � ����� ���������� ����������� ���������. "));


        //----------------------������������-----------------------------------------------------------------
        equipments.Add(new Special("������ ����� � ����-���������", "������ ����� - ��������� ������ ��� �������� ������������� ������ ������� �������, � ����-��������� �������� �������� ������ - " +
            "�� �������� ����������� ��������� ����� �������� ����������� ���� � ������ ���������.", "������ �����", "����-���������"));
        equipments.Add(new Special("����������� � ���", "���������� � �������� ����������� ����� �� ������ ������ �����. ", "�����������", "���"));
        equipments.Add(new Special("����-��������� � ����� ��������������� ���������� ����������� ����", "������: �������� ������������� �� 3.", "����-���������", "��� �������� ����������� ����"));
        equipments.Add(new Special("����-��������� � ����� ��������������� ���������� ������������ ����", "������: ������������ ���� ��������� +1 � ����� ������ � +1 � �������������. ", "����-���������", "��� �������� ������������ ����"));
    }

    public Equipment GetEquipment(string nameEq)
    {
        foreach(Equipment equipment in equipments)
        {
            if(string.Compare(nameEq, equipment.Name, true) == 0)
            {
                return equipment;
            }
        }
        Debug.Log($"!!!!��������!!!! �� ����� ���������� {nameEq}");
        return null;
    }
}
