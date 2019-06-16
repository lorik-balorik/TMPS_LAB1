# Лабораторная работа №1
_Подготовила студентка группы TI-164, Рябинина Алиса_
## Задание 
Целью данной лабораторной работы было имплементировать 5 порождающих паттернов
## Использованные порождающие паттерны
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
В моём приложении реализовано несколько классов:
1. _Franchise_  - использует Singleton и представляет экземпляр класса pizzaNetwork 
2. _PizzaNetwork_ - создаёт Andy's Pizza и Corso pizza 
3. _PizzaStore_ and _Pizza_ - используют Factory Method Pattern
4. _Pizza_ создаются при помощи Builder Design Pattern
5. _IngredientsFactory_ использует Abstract Factory  

Для того, чтобы показать как это работает, было создано несколько диаграмм. Вот к примеру, 
Factory Design Pattern: 
![alt text](DiagramsAndScreens/FactoryMethod.PNG "Logo Title Text 1")

Для того, чтобы комбинировать abstract factory и abstract factory method, factory method был использован для того, чтобы имплиментировать методы в abstract factory (CreateDough(), CreateCheese();...)
![alt text](DiagramsAndScreens/AbstractFactory.PNG "Logo Title Text 1")

Пицца создаётся используя Builder Pattern:  
![alt text](DiagramsAndScreens/Builder.PNG "Logo Title Text 1")

Так же мы можем клонировать пиццу используя паттерн Prototype:
![alt text](DiagramsAndScreens/Prototype.PNG "Logo Title Text 1")

Franchise использует Singleton, и предоставляет нам экземпляр класса pizzaNetwork, который мы используем для создания pizzaStore

![alt text](DiagramsAndScreens/Franchise.PNG "Logo Title Text 1")

Результат работы программы: 
![alt text](DiagramsAndScreens/Result.PNG "Logo Title Text 1")

# Вывод
В ходе данной лабораторной работы мы изучили и реализовали порождающие паттерны, они нам упрощают и структурируют код


