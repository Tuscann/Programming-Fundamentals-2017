// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>
using namespace std;

int main()
{
	int lectures;
	double budget;
	string name;
	cin >> lectures >> budget;

	int lecture_jelev = 0, lecture_royal = 0, lecture_roli = 0, lecture_trofon = 0, lecture_sino = 0, lecture_guests = 0;
	double one_lecture = (budget / lectures)*1.0;

	for (int a = 0; a <= lectures; a++) {
		getline(cin, name);
		if (name == "Jelev") {
			lecture_jelev++;
		}
		else if (name == "RoYaL") {
			lecture_royal++;
		}
		else if (name == "Roli") {
			lecture_roli++;
		}
		else if (name == "Trofon") {
			lecture_trofon++;
		}
		else if (name == "Sino") {
			lecture_sino++;
		}
		else if (name == "Bai Ivan Ivanov") {
			lecture_guests++;
		}
	}
	cout << "Jelev salary: " << fixed << setprecision(2) << (ceil(lecture_jelev*one_lecture*100)/100) << " lv" << endl;
	cout << "RoYaL salary: " << fixed << setprecision(2) << (ceil(lecture_royal*one_lecture*100)/100) << " lv" << endl;
	cout << "Roli salary: " << fixed << setprecision(2) << (ceil(lecture_roli*one_lecture*100))/100 << " lv" << endl;
	cout << "Trofon salary: " << fixed << setprecision(2) << (ceil(lecture_trofon*one_lecture*100)/100) << " lv" << endl;
	cout << "Sino salary: " << fixed << setprecision(2) << (ceil(lecture_sino*one_lecture*100)/100) << " lv" << endl;
	cout << "Others salary: " << fixed << setprecision(2) << (ceil(lecture_guests*one_lecture*100)/100) << " lv" << endl;
	return 0;
}

