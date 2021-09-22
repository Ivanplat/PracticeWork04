#include "../public/Animals.h"
#include <iostream>

int Cat::Count = 0;
int Dog::Count = 0;
int Humster::Count = 0;
int Hippo::Count = 0;


void Cat::Speak()
{
	std::cout << "Meow" << std::endl;
}

void Dog::Speak()
{
	std::cout << "Haw" << std::endl;
}

void Humster::Speak()
{
	std::cout << "Hmff" << std::endl;
}

void Hippo::Speak()
{
	std::cout << "AAAAA" << std::endl;
}
