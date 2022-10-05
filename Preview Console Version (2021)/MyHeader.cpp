#include<iostream>
#include<windows.h>
#include<random>
#include<ctime>
#include"Header.h"
using namespace std;

int RandNumber(int min, int max)
{
	//������� ��� ��������� ���������� ��������� �������� � �������� ����������
	static std::mt19937 randgenerator(time(NULL));
	uniform_int_distribution<> randnumber(min, max);
	return randnumber(randgenerator);
}

int NumberInput(int min, int max)
{
	//������� ��� ����� ��������� �������� � �������� ����������
	int input;
	while (!(cin >> input) || input < min || input > max)
	{
		if (!cin)
		{
			cin.clear();
			cin.ignore(10000, '\n');
		}
		cout << "�� ����� ������������ ��������. ����������, ��������� ����: ";
	}
	return input;
}

void graphics()
{
	//������� ��� ��������� �������������� ������ � ������ �������
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	//��� ������������� ����������������� � ��������� ����� ������� �� ����� RGB
	/*CONSOLE_SCREEN_BUFFER_INFOEX colorification;
	colorification.cbSize = sizeof(CONSOLE_SCREEN_BUFFER_INFOEX);
	HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
	GetConsoleScreenBufferInfoEx(hConsole, &colorification);
	colorification.ColorTable[1] = RGB(8, 0, 85); //���� ������
	colorification.ColorTable[0] = RGB(182, 229, 255); //���� ����
	SetConsoleScreenBufferInfoEx(hConsole, &colorification);
	SetConsoleTextAttribute(hConsole, 1);*/
}