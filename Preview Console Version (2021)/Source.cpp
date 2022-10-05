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
	pathtothefolder += L"/Конфигурации СКС";
	if (!fs::exists(pathtothefolder.c_str()))
	{
		fs::create_directory(pathtothefolder.c_str());
	}
	wstring date = to_wstring(tm_year) + L"-" + to_wstring(tm_mon) + L"-" + to_wstring(tm_mday) + L"_" + to_wstring(tm_hour) + L"-" + to_wstring(tm_min) + L"-" + to_wstring(tm_sec);
	wstring filename = pathtothefolder + L"/Конфигурация СКС " + date + L".txt";
	ofstream confin;
	confin.open(filename);
	if (!confin.is_open())
	{
		cout << "\n\aОшибка сохранения конфигурации!.\n\n";
		cout << "\n\n\n" << "Нажмите любую клавишу для продолжения" << "\n\n\n";
		system("pause");
		system("cls");
	}
	else
	{
		confin << "Конфигурация создана в программе SKS-Calc" << TRIendl;
		confin << "Наименьшая длина постояного линка: " << min << endl;
		confin << "Наибольшая длина постояного линка: " << max << endl;
		confin << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
		confin << "Количество рабочих мест: " << quant << endl;
		confin << "Количество портов на 1 рабочее место: " << amt << "\n\n";
		confin << "Необходимое колличество кабеля: " << metr << " м";
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
	pathtothefolder += L"/Конфигурации СКС";
	if (!fs::exists(pathtothefolder.c_str()))
	{
		fs::create_directory(pathtothefolder.c_str());
	}
	wstring date = to_wstring(tm_year) + L"-" + to_wstring(tm_mon) + L"-" + to_wstring(tm_mday) + L"_" + to_wstring(tm_hour) + L"-" + to_wstring(tm_min) + L"-" + to_wstring(tm_sec);
	wstring filename = pathtothefolder + L"/Конфигурация СКС " + date + L".txt";
	ofstream confin;
	confin.open(filename);
	if (!confin.is_open())
	{
		cout << "\n\aОшибка сохранения конфигурации!.\n\n";
		cout << "\n\n\n" << "Нажмите любую клавишу для продолжения" << "\n\n\n";
		system("pause");
		system("cls");
	}
	else
	{
		confin << "Конфигурация создана в программе SKS-Calc" << TRIendl;
		confin << "Наименьшая длина постояного линка: " << min << endl;
		confin << "Наибольшая длина постояного линка: " << max << endl;
		confin << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
		confin << "Колличество рабочих мест: " << quant << endl;
		confin << "Колличество портов на 1 рабочее место: " << amt << "\n\n";
		confin << "Необходимое колличество кабеля: " << metr << " м" << endl;
		confin << "Необходимое колличесвто бухт кабеля: " << hankamt << endl;
		confin << "Итоговое колличество закупаемого кабеля: " << hankamt * hank << " м";
		confin.close();
	}
}

void estimatiator()
{
	int min, max, quant, amt, hank, metr;
	cout << "Пожалуйста, введите наименьшую длину постоянного линка (Permament Link) в метрах: ";
	min = NumberInput(1, 1000);
	if (min > 90)
	{
		cout << "\nНапоминаем, что длина постоянного линка (Permament Link), согласно стандарту ISO/IEC 11801, не может превышать 90 м\n";
	}
	cout << "\nПожалуйста, введите наибольшую длину постоянного линка (Permament Link) в метрах: ";
	max = NumberInput(1, 1000);
	if (max > 90)
	{
		cout << "\nНапоминаем, что длина постоянного линка (Permament Link), согласно стандарту ISO/IEC 11801, не может превышать 90 м\n";
	}
	cout << "\nПожалуйста, введите количество рабочих мест: ";
	quant = NumberInput(1, 10000);
	cout << "\nПожалуйста, введите количество портов на 1 рабочее место. Напоминаем, что согласно стандарту ISO/IEC 11801, на 1 рабочее место должно быть выделено не менее 2-х портов: ";
	amt = NumberInput(1, 1000);
	cout << "\nПожалуйста, введите предпологаемый метраж кабеля в бухте. Напоминаем, что стандартными значениями являются 305, 500 и 1000 м (0 - расчитать без учета бухт): ";
	hank = NumberInput(0, 100000);
	system("cls");
	if (hank == 0)
	{
		metr = (min + max) / 2 * 1.15 * quant * amt;
		cout << "Наименьшая длина постояного линка: " << min << endl;
		cout << "Наибольшая длина постояного линка: " << max << endl;
		cout << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
		cout << "Количество рабочих мест: " << quant << endl;
		cout << "Количество портов на 1 рабочее место: " << amt << "\n\n";
		cout << "Необходимое колличество кабеля: " << metr << " м";
		char antwoord[10000];
		cout << TRIendl << "Сохранить текущую конфигурацию? Текущая конфигурация будет сохранена в папке \"Документы\".\nY - да, N - no: " << TRIendl;
		cin.ignore();
		gets_s(antwoord);
		if (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')))
		{
			do {
				cout << "Вы ввели неверное значение! Пожалуйста, повторите ввод:\n";
				gets_s(antwoord);
			} while (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')));
		}
		if (antwoord[0] == 'Y' || antwoord[0] == 'y')
		{
			saver1(min, max, quant, amt, metr);
		}
		system("cls");
		cout << "Наименьшая длина постояного линка: " << min << endl;
		cout << "Наибольшая длина постояного линка: " << max << endl;
		cout << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
		cout << "Количество рабочих мест: " << quant << endl;
		cout << "Количество портов на 1 рабочее место: " << amt << "\n\n";
		cout << "Необходимое колличество кабеля: " << metr << " м";
		cout << TRIendl << "Нажмите любую клавишу для выхода в главное меню" << TRIendl;
		system("pause");
		system("cls");
	}
	else
	{
		metr = (min + max) / 2 * 1.15 * quant * amt;
		int average = (min + max) / 2 * 1.15;
		if (average > hank)
		{
			cout << "Расчет провести невозможно! Значение средней длины постояного линка превышает значение метража кабеля в бухте. ";
			cout << "Согласно стандарту ISO/IEC 11801, сращивание витой пары запрещено. Повторите расчет с друими параметрами.";
			cout << TRIendl << "Нажмите любую клавишу для выхода в главное меню" << TRIendl;
			system("pause");
			system("cls");
		}
		else
		{
			int hankamt = ceil(quant * amt / floor(hank / average));
			cout << "Наименьшая длина постояного линка: " << min << endl;
			cout << "Наибольшая длина постояного линка: " << max << endl;
			cout << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
			cout << "Количество рабочих мест: " << quant << endl;
			cout << "Количество портов на 1 рабочее место: " << amt << "\n\n";
			cout << "Необходимое колличество кабеля: " << metr << " м" << endl;
			cout << "Необходимое колличесвто бухт кабеля: " << hankamt << endl;
			cout << "Итоговое колличество закупаемого кабеля: " << hankamt * hank << " м";
			char antwoord[10000];
			cout << TRIendl << "Сохранить текущую конфигурацию? Текущая конфигурация будет сохранена в папке \"Документы\".\nY - да, N - no: " << TRIendl;
			cin.ignore();
			gets_s(antwoord);
			if (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')))
			{
				do {
					std::cout << "Вы ввели неверное значение! Пожалуйста, повторите ввод:\n";
					gets_s(antwoord);
				} while (!((antwoord[0] == 'Y' && antwoord[1] == '\0') || (antwoord[0] == 'y' && antwoord[1] == '\0') || (antwoord[0] == 'N' && antwoord[1] == '\0') || (antwoord[0] == 'n' && antwoord[1] == '\0')));
			}
			if (antwoord[0] == 'Y' || antwoord[0] == 'y')
			{
				saver2(min, max, quant, amt, metr, hankamt, hank);
			}
			system("cls");
			cout << "Наименьшая длина постояного линка: " << min << endl;
			cout << "Наибольшая длина постояного линка: " << max << endl;
			cout << "Средняя длина постояного линка: " << (min + max) / 2 << endl;
			cout << "Количество рабочих мест: " << quant << endl;
			cout << "Количество портов на 1 рабочее место: " << amt << "\n\n";
			cout << "Необходимое колличество кабеля: " << metr << " м" << endl;
			cout << "Необходимое колличесвто бухт кабеля: " << hankamt << endl;
			cout << "Итоговое колличество закупаемого кабеля: " << hankamt * hank << " м";
			cout << TRIendl << "Нажмите любую клавишу для выхода в главное меню" << TRIendl;
			system("pause");
			system("cls");
		}
	}
}

void information()
{
	cout << Text;
	cout << TRIendl << "Нажмите любую клавишу для выхода в главное меню" << TRIendl;
	system("pause");
	system("cls");
}

int main()
{
	graphics();
	short determinator;
	do
	{
		cout << "Пожалуйста, выберите:\n\n1 - Создание новой конфигурации\n2 - Информация о приложении\n0 - Выход из программы\n\n";
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