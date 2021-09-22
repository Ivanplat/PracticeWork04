#pragma once
#include <vector>

class AnimalsFabric
{
public:
	static AnimalsFabric* Instance();
	class IAnimal* CreateAnimal(unsigned int ID);
	void CountAnimals();
private:
	explicit AnimalsFabric() noexcept = default;
	virtual ~AnimalsFabric() noexcept;
public:
	AnimalsFabric& operator=(const AnimalsFabric&) = delete;
	AnimalsFabric& operator=(const AnimalsFabric&&) = delete;
	AnimalsFabric(const AnimalsFabric&) = delete;
	AnimalsFabric(const AnimalsFabric&&) = delete;
private:
	std::vector<class Cat*> Cats;
	std::vector<class Dog*> Dogs;
	std::vector<class Humster*> Humsters;
	std::vector<class Hippo*> Hippos;
};