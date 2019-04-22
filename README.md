# Лабораторная работа №1
_Подготовила студентка группы TI-164, Рябинина Алиса_
## Задание 
Целью данной лабораторной работы было имплементировать 5 порождающих шабловнов

## Использованные порождающие шаблоны
1. _Abstract Factory_
2. _Factory Method_
3. _Singleton_
4. _Prototype_
5. _Builder_

## _Abstract Factory_
Абстрактная фабрика — это порождающий паттерн проектирования, который позволяет создавать семейства связанных объектов, не привязываясь к конкретным классам создаваемых объектов.

![alt text](https://refactoring.guru/images/patterns/content/abstract-factory/abstract-factory.png "Logo Title Text 1")

## _Factory Method_
Фабричный метод — это порождающий паттерн проектирования, который определяет общий интерфейс для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов.

![alt text](https://refactoring.guru/images/patterns/content/factory-method/factory-method.png "Logo Title Text 1")

## _Singleton_
Singleton — это порождающий паттерн проектирования, который гарантирует, что у класса есть только один экземпляр, и предоставляет к нему глобальную точку доступа.

![alt text](https://refactoring.guru/images/patterns/content/singleton/singleton.png "Logo Title Text 1")

## _Prototype_
Prototype - это порождающий паттерн проектирования, который позволяет копировать объекты, не вдаваясь в подробности их реализации.

![alt text](https://refactoring.guru/images/patterns/content/prototype/prototype.png "Logo Title Text 1")

## _Builder_
Builder - это порождающий паттерн проектирования, который позволяет создавать сложные объекты пошагово. Строитель даёт возможность использовать один и тот же код строительства для получения разных представлений объектов.

![alt text](https://refactoring.guru/images/patterns/content/builder/builder.png "Logo Title Text 1")


## Реализация 
В моём приложении было реализовано несколько классов :
1. _Franchise_  - использует Singleton и представляет экземпляр класса KebabNetwork 
2. _KebabNetwork_ - создаёт StarKebab и FastKebab
3. _KebabStore_ and _Kebab_ - использует Factory Method 
4. _Kebab_ создан используя Builder паттерн
5. _ComponentsFactory_ использует Abstract Factory 

Для того, чтобы показать как это работает, я создала несколько диаграмм. Вот к примеру, 
Factory  Pattern: 
![alt text](Diagrams/diag1.png "Logo Title Text 1")

Для того, чтобы комбинировать abstract factory и abstract factory method, factory method был использован для того, чтобы имплиментировать методы в abstract factory (CreateDough(), CreateMeat();...)
![alt text](Diagrams/diag2.png "Logo Title Text 1")

Кебаб создаётся используя Builder Pattern:  
![alt text](Diagrams/diag3.png "Logo Title Text 1")

Так же мы можем клонировать кебабы используя паттерн Prototype:

![alt text](Diagrams/diag4.png "Logo Title Text 1")


Franchise использует Singleton, и предоставляет нам экземпляр класса KebabNetwork, который мы используем для создания KebabStore

![alt text](Diagrams/diag5.png "Logo Title Text 1")

Результат работы программы: 
![alt text](Diagrams/diag6.png "Logo Title Text 1")

# Вывод
В ходе данной лабораторной работы мы изучили и реализовали порождающие паттерны, они нам упрощают и структурируют код
