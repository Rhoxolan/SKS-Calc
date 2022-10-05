#include<iostream>
#include<windows.h>
#include<random>
#include<ctime>
#include"Header.h"
using namespace std;

int RandNumber(int min, int max)
{
	//Функция для получения рандомного числового значения с заданным диапазоном
	static std::mt19937 randgenerator(time(NULL));
	uniform_int_distribution<> randnumber(min, max);
	return randnumber(randgenerator);
}

int NumberInput(int min, int max)
{
	//Функция для ввода числового значения с заданным диапазоном
	int input;
	while (!(cin >> input) || input < min || input > max)
	{
		if (!cin)
		{
			cin.clear();
			cin.ignore(10000, '\n');
		}
		cout << "Вы ввели недопустимое значение. Пожалуйста, повторите ввод: ";
	}
	return input;
}

void graphics()
{
	//Функция для настройки русскоязычного текста и цветов консоли
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	//При необходимости раскомментировать и настройть цвета консоли по схеме RGB
	/*CONSOLE_SCREEN_BUFFER_INFOEX colorification;
	colorification.cbSize = sizeof(CONSOLE_SCREEN_BUFFER_INFOEX);
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	GetConsoleScreenBufferInfoEx(hConsole, &colorification);
	colorification.ColorTable[1] = RGB(8, 0, 85); //Цвет шрифта
	colorification.ColorTable[0] = RGB(182, 229, 255); //Цвет фона
	SetConsoleScreenBufferInfoEx(hConsole, &colorification);
	SetConsoleTextAttribute(hConsole, 1);*/
}