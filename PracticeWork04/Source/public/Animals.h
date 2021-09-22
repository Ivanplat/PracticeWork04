#pragma once

class IAnimal
{
public:
	explicit IAnimal() noexcept {}
	virtual ~IAnimal() noexcept {}
public:
	virtual void Speak() = 0;
};

class Cat : public IAnimal
{
public:
	explicit Cat() noexcept { Count++; }
public:
	virtual void Speak() override;
public:
	static int Count;
};

class Dog : public IAnimal
{
public:
	explicit Dog() noexcept { Count++; }
public:
	virtual void Speak() override;
public:
	static int Count;
};

class Humster : public IAnimal
{
public:
	explicit Humster() noexcept { Count++; }
public:
	virtual void Speak() override;
public:
	static int Count;
};

class Hippo : public IAnimal
{
public:
	explicit Hippo() noexcept { Count++; }
public:
	virtual void Speak() override;
public:
	static int Count;
};

