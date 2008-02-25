//Title:	Employee Class
//Author:	Matthew Wamboldt
//Date:		February 24th, 2008
//Version:	1.0

#ifndef EMPLOYEE_H
#define EMPLOYEE_H
#include <string>
using namespace std;

class Employee
{
public:
	//static methods to manipulate the comaprison values
	static void SetCompareField(int value)
	{
		if( value > 0 && value < 16 )
			ourCompareField = value;
	}

	static int GetCompareField()
	{
		return ourCompareField;
	}

private:
	//used to select which variable to compare
	static int ourCompareField;

	//member variables
	string myId;
	string myLastName;
	string myFirstName;
	string myStreetAddress;
	string myCity;
	string myProvince;
	string myPostalCode;
	string myPhoneNumber;
	string myDeptCategory;
	float myHourlyRate;
	int myAge;
	int myNumDependents;
	char myGender;
	char myMiddleInitial;
	char amInUnion;

public:
	Employee()
	{}

	//Overloaded comparison operators
	bool operator ==(const Employee&);
	bool operator <(const Employee&);
	bool operator <=(const Employee&);
	bool operator >(const Employee&);
	bool operator >=(const Employee&);

	//overloaded stream operators
	friend ostream& operator <<(ostream&, const Employee&);
	friend istream& operator >>(istream&, Employee&);

};

#endif