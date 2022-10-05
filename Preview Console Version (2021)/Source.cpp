#include"Header.h"
#include"resource.h"
#include"Text.cpp"
#include<iostream>
#include<chrono>
#include<ctime>
#include<ShlObj.h>
#include<Windows.h>
#include<filesystem>
#include<fstream>
#pragma warning(disable : 4996)
using namespace std;
namespace fs = filesystem;

void saver1(int min, int max, int quant, int amt, int metr)
{
	struct tm* Time;
	time_t tim;
	time(&tim);
	Time = localtime(&tim);
	short tm_sec = Time->tm_sec;
	short tm_min = Time->tm_min;
	short tm_hour = Time->tm_hour;
	short tm_mday = Time->tm_mday;
	short tm_mon = Time->tm_mon;
	short tm_year = (Time->tm_year) + 1900;
	PWSTR path = NULL;
	HRESULT pathres = SHGetKnownFolderPath(FOLDERID_Documents, 0, NULL, &path);
	wstring pathtothefolder(path);
	pathtothefolder += L"/������������ ���";
	if (!fs::exists(pathtothefolder.c_str()))
	{
		fs::create_directory(pathtothefolder.c_str());
	}
	wstring date = to_wstring(tm_year) + L"-" + to_wstring(tm_mon) + L"-" + to_wstring(tm_mday) + L"_" + to_wstring(tm_hour) + L"-" + to_wstring(tm_min) + L"-" + to_wstring(tm_sec);
	wstring filename = pathtothefolder + L"/������������ ��� " + date + L".txt";
	ofstream confin;
	confin.open(filename);
	if (!confin.is_open())
	{
		cout << "\n\a������ ���������� ������������!.\n\n";
		cout << "\n\n\n" << "������� ����� ������� ��� �����������" << "\n\n\n";
		system("pause");
		system("cls");
	}
	else
	{
		confin << "������������ ������� � ��������� SKS-Calc" << TRIendl;
		confin << "���������� ����� ���������� �����: " << min << endl;
		confin << "���������� ����� ���������� �����: " << max << endl;
		confin << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
		confin << "���������� ������� ����: " << quant << endl;
		confin << "���������� ������ �� 1 ������� �����: " << amt << "\n\n";
		confin << "����������� ����������� ������: " << metr << " �";
		confin.close();
	}
}

void saver2(int min, int max, int quant, int amt, int metr, int hankamt, int hank)
{
	struct tm* Time;
	time_t tim;
	time(&tim);
	Time = localtime(&tim);
	short tm_sec = Time->tm_sec;
	short tm_min = Time->tm_min;
	short tm_hour = Time->tm_hour;
	short tm_mday = Time->tm_mday;
	short tm_mon = Time->tm_mon;
	short tm_year = (Time->tm_year) + 1900;
	PWSTR path = NULL;
	HRESULT pathres = SHGetKnownFolderPath(FOLDERID_Documents, 0, NULL, &path);
	wstring pathtothefolder(path);
	pathtothefolder += L"/������������ ���";
	if (!fs::exists(pathtothefolder.c_str()))
	{
		fs::create_directory(pathtothefolder.c_str());
	}
	wstring date = to_wstring(tm_year) + L"-" + to_wstring(tm_mon) + L"-" + to_wstring(tm_mday) + L"_" + to_wstring(tm_hour) + L"-" + to_wstring(tm_min) + L"-" + to_wstring(tm_sec);
	wstring filename = pathtothefolder + L"/������������ ��� " + date + L".txt";
	ofstream confin;
	confin.open(filename);
	if (!confin.is_open())
	{
		cout << "\n\a������ ���������� ������������!.\n\n";
		cout << "\n\n\n" << "������� ����� ������� ��� �����������" << "\n\n\n";
		system("pause");
		system("cls");
	}
	else
	{
		confin << "������������ ������� � ��������� SKS-Calc" << TRIendl;
		confin << "���������� ����� ���������� �����: " << min << endl;
		confin << "���������� ����� ���������� �����: " << max << endl;
		confin << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
		confin << "����������� ������� ����: " << quant << endl;
		confin << "����������� ������ �� 1 ������� �����: " << amt << "\n\n";
		confin << "����������� ����������� ������: " << metr << " �" << endl;
		confin << "����������� ����������� ���� ������: " << hankamt << endl;
		confin << "�������� ����������� ����������� ������: " << hankamt * hank << " �";
		confin.close();
	}
}

void estimatiator()
{
	int min, max, quant, amt, hank, metr;
	cout << "����������, ������� ���������� ����� ����������� ����� (Permament Link) � ������: ";
	min = NumberInput(1, 1000);
	if (min > 90)
	{
		cout << "\n����������, ��� ����� ����������� ����� (Permament Link), �������� ��������� ISO/IEC 11801, �� ����� ��������� 90 �\n";
	}
	cout << "\n����������, ������� ���������� ����� ����������� ����� (Permament Link) � ������: ";
	max = NumberInput(1, 1000);
	if (max > 90)
	{
		cout << "\n����������, ��� ����� ����������� ����� (Permament Link), �������� ��������� ISO/IEC 11801, �� ����� ��������� 90 �\n";
	}
	cout << "\n����������, ������� ���������� ������� ����: ";
	quant = NumberInput(1, 10000);
	cout << "\n����������, ������� ���������� ������ �� 1 ������� �����. ����������, ��� �������� ��������� ISO/IEC 11801, �� 1 ������� ����� ������ ���� �������� �� ����� 2-� ������: ";
	amt = NumberInput(1, 1000);
	cout << "\n����������, ������� �������������� ������ ������ � �����. ����������, ��� ������������ ���������� �������� 305, 500 � 1000 � (0 - ��������� ��� ����� ����): ";
	hank = NumberInput(0, 100000);
	system("cls");
	if (hank == 0)
	{
		metr = (min + max) / 2 * 1.15 * quant * amt;
		cout << "���������� ����� ���������� �����: " << min << endl;
		cout << "���������� ����� ���������� �����: " << max << endl;
		cout << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
		cout << "���������� ������� ����: " << quant << endl;
		cout << "���������� ������ �� 1 ������� �����: " << amt << "\n\n";
		cout << "����������� ����������� ������: " << metr << " �";
		char antwoord[10000];
		cout << TRIendl << "��������� ������� ������������? ������� ������������ ����� ��������� � ����� \"���������\".\nY - ��, N - no: " << TRIendl;
		cin.ignore();
		gets_s(antwoord);
		if (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')))
		{
			do {
				cout << "�� ����� �������� ��������! ����������, ��������� ����:\n";
				gets_s(antwoord);
			} while (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')));
		}
		if (antwoord[0] == 'Y' || antwoord[0] == 'y')
		{
			saver1(min, max, quant, amt, metr);
		}
		system("cls");
		cout << "���������� ����� ���������� �����: " << min << endl;
		cout << "���������� ����� ���������� �����: " << max << endl;
		cout << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
		cout << "���������� ������� ����: " << quant << endl;
		cout << "���������� ������ �� 1 ������� �����: " << amt << "\n\n";
		cout << "����������� ����������� ������: " << metr << " �";
		cout << TRIendl << "������� ����� ������� ��� ������ � ������� ����" << TRIendl;
		system("pause");
		system("cls");
	}
	else
	{
		metr = (min + max) / 2 * 1.15 * quant * amt;
		int average = (min + max) / 2 * 1.15;
		if (average > hank)
		{
			cout << "������ �������� ����������! �������� ������� ����� ���������� ����� ��������� �������� ������� ������ � �����. ";
			cout << "�������� ��������� ISO/IEC 11801, ���������� ����� ���� ���������. ��������� ������ � ������ �����������.";
			cout << TRIendl << "������� ����� ������� ��� ������ � ������� ����" << TRIendl;
			system("pause");
			system("cls");
		}
		else
		{
			int hankamt = ceil(quant * amt / floor(hank / average));
			cout << "���������� ����� ���������� �����: " << min << endl;
			cout << "���������� ����� ���������� �����: " << max << endl;
			cout << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
			cout << "���������� ������� ����: " << quant << endl;
			cout << "���������� ������ �� 1 ������� �����: " << amt << "\n\n";
			cout << "����������� ����������� ������: " << metr << " �" << endl;
			cout << "����������� ����������� ���� ������: " << hankamt << endl;
			cout << "�������� ����������� ����������� ������: " << hankamt * hank << " �";
			char antwoord[10000];
			cout << TRIendl << "��������� ������� ������������? ������� ������������ ����� ��������� � ����� \"���������\".\nY - ��, N - no: " << TRIendl;
			cin.ignore();
			gets_s(antwoord);
			if (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')))
			{
				do {
					std::cout << "�� ����� �������� ��������! ����������, ��������� ����:\n";
					gets_s(antwoord);
				} while (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')));
			}
			if (antwoord[0] == 'Y' || antwoord[0] == 'y')
			{
				saver2(min, max, quant, amt, metr, hankamt, hank);
			}
			system("cls");
			cout << "���������� ����� ���������� �����: " << min << endl;
			cout << "���������� ����� ���������� �����: " << max << endl;
			cout << "������� ����� ���������� �����: " << (min + max) / 2 << endl;
			cout << "���������� ������� ����: " << quant << endl;
			cout << "���������� ������ �� 1 ������� �����: " << amt << "\n\n";
			cout << "����������� ����������� ������: " << metr << " �" << endl;
			cout << "����������� ����������� ���� ������: " << hankamt << endl;
			cout << "�������� ����������� ����������� ������: " << hankamt * hank << " �";
			cout << TRIendl << "������� ����� ������� ��� ������ � ������� ����" << TRIendl;
			system("pause");
			system("cls");
		}
	}
}

void information()
{
	cout << Text;
	cout << TRIendl << "������� ����� ������� ��� ������ � ������� ����" << TRIendl;
	system("pause");
	system("cls");
}

int main()
{
	graphics();
	short determinator;
	do
	{
		cout << "����������, ��������:\n\n1 - �������� ����� ������������\n2 - ���������� � ����������\n0 - ����� �� ���������\n\n";
		determinator = NumberInput(0,2);
		system("cls");
		if (determinator == 1)
		{
			estimatiator();
		}
		if (determinator == 2)
		{
			information();
		}
	} while (determinator != 0);
	return 0;
}